using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yammy
{
    public partial class Commande : Form
    {
        public Commande()
        {
            InitializeComponent();
        }
        SqlConnection macnx = new SqlConnection(@"Data Source=YAHYA-PC\SQLEXPRESS;Initial Catalog=DB_BESTRESTO;Integrated Security=True");
        SqlCommand macmd = new SqlCommand();
       

        private void Commande_Load(object sender, EventArgs e)
        {
            if (macnx.State != ConnectionState.Open)
            {
                macnx.Open();

            }
            macmd.Parameters.Clear();
            macmd.Connection = macnx;
            macmd.CommandText = "select IdR ,Nom  from Restaurant";
            SqlDataReader DR = macmd.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            comboBoxR.DataSource = DT;
            comboBoxR.ValueMember = "IdR";  //element a récupuré
            comboBoxR.DisplayMember = "Nom";  //element a afficher

            macmd.Parameters.Clear();
            macmd.Connection = macnx;
            macmd.CommandText = "select IdP,Nom from Boisson";
            SqlDataReader DR1 = macmd.ExecuteReader();
            DataTable DT1 = new DataTable();
            DT1.Load(DR1);
            comboBoxB.DataSource = DT1;
            comboBoxB.ValueMember = "IdP";  //element a récupuré
            comboBoxB.DisplayMember = "Nom";  //element a afficher

            macmd.Parameters.Clear();
            macmd.Connection = macnx;
            macmd.CommandText = "select IdP,Nom from Plat";
            SqlDataReader DR2 = macmd.ExecuteReader();
            DataTable DT2 = new DataTable();
            DT2.Load(DR2);
            comboBoxP.DataSource = DT2;
            comboBoxP.ValueMember = "IdP";  //element a récupuré
            comboBoxP.DisplayMember = "Nom";  //element a afficher

            macmd.Parameters.Clear();
            macmd.Connection = macnx;
            macmd.CommandText = "select IdC ,Nom from Client";
            SqlDataReader DR3 = macmd.ExecuteReader();
            DataTable DT3 = new DataTable();
            DT3.Load(DR3);
            comboBoxclient.DataSource = DT3;
            comboBoxclient.ValueMember = "IdC";  //element a récupuré
            comboBoxclient.DisplayMember = "Nom";  //element a afficher
            RempliDGV();

        }
        void initialisation(Control C)
        {

            foreach (Control item in C.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                    ((TextBox)item).Clear();
                
                if (item.GetType() == typeof(ComboBox))
                    ((ComboBox)item).SelectedIndex =-1;
                if (item.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)item).Value = DateTime.Today;

                if (item.Controls.Count != 0)
                    initialisation(item);
            }

        }
        public int nombre()
        {
            macmd.Parameters.Clear();
            int cpt;
            macmd.Connection = macnx;
            macmd.CommandText = "select count(IdCmd) from Commande where IdCmd=@IdCmd";
            macmd.Parameters.AddWithValue("@IdCmd", SqlDbType.Int).Value = textBoxnum.Text;
            cpt = (int)macmd.ExecuteScalar();
            return cpt;
        }
        void RempliDGV()
        {
            macmd.Parameters.Clear();
            macmd.Connection = macnx;
            macmd.CommandText = "select IdCmd [Numero],Restaurant.Nom [Non Restaurant] ,Client.Nom [Nom Client],Plat.Nom [Nom Plat],Boisson.Nom [Nom Boisson],Commande.Date_Cmd [Date Commande],Commande.Description ,Commande.Qantité_P [Quantité Plat],Commande.Qantité_B [Quantité Boisson] from Commande inner join Client on Client.IdC=Commande.IdC inner join Restaurant on Commande.IdR=Restaurant.IdR inner join Plat on Commande.IdP=Plat.IdP inner join Boisson on Commande.IdP=Boisson.IdP";
            SqlDataReader DR = macmd.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(DR);
            dataGridViewCommande.DataSource = DT;
        }


        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (nombre() == 0)
                {
                    macmd.Parameters.Clear();
                    macmd.Connection = macnx;
                    macmd.CommandText = "insert into Commande values(@IdCmd,@IdC,@IdR,@IdP,@IdB,@date,@des,@QB,@QP)";
                    macmd.Parameters.AddWithValue("@IdCmd", SqlDbType.Int).Value = textBoxnum.Text;
                    macmd.Parameters.AddWithValue("@IdC", SqlDbType.Int).Value = comboBoxclient.SelectedValue;
                    macmd.Parameters.AddWithValue("@IdR", SqlDbType.Int).Value = comboBoxR.SelectedValue;
                    macmd.Parameters.AddWithValue("@IdP", SqlDbType.Int).Value = comboBoxP.SelectedValue;
                    macmd.Parameters.AddWithValue("@IdB", SqlDbType.Int).Value = comboBoxB.SelectedValue;
                    macmd.Parameters.AddWithValue("@date", SqlDbType.Date).Value = dateTimePicker1.Text;
                    macmd.Parameters.AddWithValue("@des", SqlDbType.VarChar).Value = textBoxdes.Text;
                    macmd.Parameters.AddWithValue("@QB", SqlDbType.Int).Value = textBoxQ_B.Text;
                    macmd.Parameters.AddWithValue("@QP", SqlDbType.Int).Value = textBoxQ_P.Text;
                    macmd.ExecuteNonQuery();
                    initialisation(this);
                    RempliDGV();
                }
                else
                {
                    MessageBox.Show("Il est déja exist");
                    initialisation(this);
                }
 
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            macmd.Parameters.Clear();
            if (nombre() != 0)
            {
                macmd.Parameters.Clear();
                macmd.Connection = macnx;
                macmd.CommandText = "Delete from Commande where IdCmd=@IdCmd";
                macmd.Parameters.AddWithValue("@IdCmd", SqlDbType.Int).Value = textBoxnum.Text;
                macmd.ExecuteNonQuery();
                MessageBox.Show("Il est supprimé avec succès");
                RempliDGV();
            }
            else
            {
                MessageBox.Show("N'exist pas!!!");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            macmd.Parameters.Clear();
            if (textBoxnum.Text == "" || comboBoxclient.Text == "" || dataGridViewCommande.Text == "" || comboBoxR.Text == "" || comboBoxP.Text == "" || comboBoxB.Text == "" || textBoxQ_B.Text == "" || textBoxQ_P.Text == "" || textBoxdes.Text == "")
            {
                MessageBox.Show("S'il te plait remplir tout les champs");
            }
           
            else
            {
                macmd.Parameters.Clear();
                macmd.Connection = macnx;

                macmd.CommandText = "Update Client set IdCmd=@IdCmd , IdC=@IdC , date=@date ,IdR=@IdR,IdP=@IdP,IdB=@IdB,QB=@QB ,QB=@QB,QP=@QP where IdCmd=@IdCdm";
                macmd.Parameters.AddWithValue("@IdCmd", SqlDbType.Int).Value = textBoxnum.Text;
                macmd.Parameters.AddWithValue("@IdC", SqlDbType.VarChar).Value = comboBoxclient.SelectedValue;
                macmd.Parameters.AddWithValue("@date", SqlDbType.Date).Value = dataGridViewCommande.Text;
                macmd.Parameters.AddWithValue("@IdR", SqlDbType.Int).Value = comboBoxR.SelectedValue;
                macmd.Parameters.AddWithValue("@IdP", SqlDbType.VarChar).Value = comboBoxP.SelectedValue;
                macmd.Parameters.AddWithValue("@IdB", SqlDbType.VarChar).Value = comboBoxB.SelectedValue;
                macmd.Parameters.AddWithValue("@QB", SqlDbType.Int).Value = textBoxQ_B.Text;
                macmd.Parameters.AddWithValue("@QP", SqlDbType.Int).Value = textBoxdes.Text;

                macmd.ExecuteNonQuery();
                initialisation(this);

                MessageBox.Show("Il est modifié avec succès");
                RempliDGV();
            }
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {

            macmd.Parameters.Clear();
            macmd.Connection = macnx;
            macmd.CommandText = "select * from Client where IdCmd=@IdCmd";
            macmd.Parameters.AddWithValue("@IdC", SqlDbType.Int).Value = textBoxnum.Text;
            SqlDataReader dr = macmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows == true)
            {
                textBoxnum.Text = dr[0].ToString();
                comboBoxclient.Text = dr[1].ToString();
                dataGridViewCommande.Text = dr[2].ToString();
                comboBoxR.Text = dr[3].ToString();
                comboBoxP.Text = dr[4].ToString();
                comboBoxB.Text = dr[5].ToString();
                textBoxQ_B.Text = dr[6].ToString();
                textBoxQ_P.Text = dr[7].ToString();
                textBoxdes.Text = dr[8].ToString();

            }
            else
            {
                MessageBox.Show("N'exist pas");
                initialisation(this);
            }
            dr.Close();

        }

        private void Premier_Click(object sender, EventArgs e)
        {
            macmd.Parameters.Clear();
            macmd.Connection = macnx;
            macmd = new SqlCommand("select * from Commande", macnx);
            SqlDataReader dr = macmd.ExecuteReader();

            dr.Read();

            textBoxnum.Text = dr[0].ToString();
            comboBoxclient.Text = dr[1].ToString();
            comboBoxR.Text = dr[2].ToString();
            comboBoxP.Text = dr[3].ToString();
            comboBoxB.Text = dr[4].ToString();
            dateTimePicker1.Text = dr[5].ToString();
            textBoxdes.Text = dr[6].ToString();
            textBoxQ_P.Text = dr[7].ToString();
            textBoxQ_B.Text = dr[8].ToString();
            
            dr.Close();
        }

        private void Précedent_Click(object sender, EventArgs e)
        {
            macmd.Parameters.Clear();
            try
            {
                macmd.Connection = macnx;
                macmd = new SqlCommand("select * from Commande where IdCmd <" + textBoxnum.Text + "order by IdCmd desc", macnx);

                SqlDataReader dr = macmd.ExecuteReader();

                dr.Read();
                textBoxnum.Text = dr[0].ToString();
                comboBoxclient.ValueMember = dr[1].ToString();
                comboBoxR.ValueMember = dr[2].ToString();
                comboBoxP.ValueMember = dr[3].ToString();
                comboBoxB.ValueMember = dr[4].ToString();
                dateTimePicker1.Text = dr[5].ToString();
                textBoxdes.Text = dr[6].ToString();
                textBoxQ_P.Text = dr[7].ToString();
                textBoxQ_B.Text = dr[8].ToString();
                dr.Close();
            }
            catch { MessageBox.Show("C'est le derniére"); }
            

        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            macmd.Parameters.Clear();
            try
            {
                macmd.Connection = macnx;
                macmd = new SqlCommand("select * from Commande where IdCmd >" + textBoxnum.Text + "order by IdCmd asc", macnx);

                SqlDataReader dr = macmd.ExecuteReader();

                dr.Read();
                textBoxnum.Text = dr[0].ToString();
                comboBoxclient.Text = dr[1].ToString();
                comboBoxR.Text = dr[2].ToString();
                comboBoxP.Text = dr[3].ToString();
                comboBoxB.Text = dr[4].ToString();
                dateTimePicker1.Text = dr[5].ToString();
                textBoxdes.Text = dr[6].ToString();
                textBoxQ_P.Text = dr[7].ToString();
                textBoxQ_B.Text = dr[8].ToString();
                dr.Close();
            }
            catch { MessageBox.Show("C'est le derniére"); }

        }

        private void Dérniere_Click(object sender, EventArgs e)
        {
            macmd.Parameters.Clear();
            macmd.Connection = macnx;
            macmd = new SqlCommand("select * from Commande", macnx);
            SqlDataReader dr = macmd.ExecuteReader();

            while (dr.Read())
            {
                textBoxnum.Text = dr[0].ToString();
                comboBoxclient.Text = dr[1].ToString();
                comboBoxR.Text = dr[2].ToString();
                comboBoxP.Text = dr[3].ToString();
                comboBoxB.Text = dr[4].ToString();
                dateTimePicker1.Text = dr[5].ToString();
                textBoxdes.Text = dr[6].ToString();
                textBoxQ_P.Text = dr[7].ToString();
                textBoxQ_B.Text = dr[8].ToString();
            }
            dr.Close();

        }

        private void Calculer_Click(object sender, EventArgs e)
        {

            macmd.Parameters.Clear();
            macmd.Connection = macnx;
            macmd.CommandText = "select Totale=((t1.Prix*t.Qantité_P)+(t2.Prix*t.Qantité_B)),Totale =@Totale FROM Commande t JOIN Plat t1 ON t1.idp = t.idp JOIN Boisson t2 ON t2.idp = t.idp where t.IdCmd = @IdCmd";
            macmd.Parameters.AddWithValue("@IdCmd", SqlDbType.Int).Value = textBoxnum.Text;
            macmd.Parameters.AddWithValue("@Totale", SqlDbType.Int).Value = textBoxTotale.Text;
            SqlDataReader dr = macmd.ExecuteReader();

            while (dr.Read())
            {
                textBoxTotale.Text = dr[0].ToString();
            }
            dr.Close();

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Yammy yammy = new Yammy();
            yammy.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
