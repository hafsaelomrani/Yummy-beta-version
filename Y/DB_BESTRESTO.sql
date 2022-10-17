create database DB_BESTRESTO
use DB_BESTRESTO
create table Restaurant (IdR int primary key,
						Nom varchar(20),Tel int,
						Addersse varchar(50))
create table Client (IdC int primary key,
					Nom varchar(20),
					Prénom varchar(20),
					Tel int ,
					Email varchar(50),
					Addresse varchar(50),
					Nationalité varchar(20),
					IdR int foreign key references Restaurant)
create table Commande(IdCmd int primary key,
					IdC int foreign key references Client,
					IdR int foreign key references Restaurant,
					IdP int foreign key references Plat,
					IdB int foreign key references Boisson,
					Date_Cmd datetime,Description varchar(40),
					Qantité_P int,
					Qantité_B int)
create table Plat(IdP int primary key ,
					Nom varchar(20),
					Prix int)
create table Boisson(IdP int primary key ,
					Nom varchar(20),
					Prix int)
create table Administration(Login  varchar(14) not null,
							Mot_de_Passe varchar(14) not null,
							constraint ctprim primary key (Login,Mot_de_Passe))


