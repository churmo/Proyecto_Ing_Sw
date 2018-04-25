create database BDIS;
use bdis;

-- TABLA RESIDENTE
create table Residente
(
noControl 	varchar(9) primary key 		not null,
Nombre 		varchar(45) 				not null,
apellidoP 	varchar(45) 				not null,
apellidoM 	varchar(45) 				not null,
Carrera 	varchar(45) 				not null,
correo 		varchar(100)				not null,
NoSS 		varchar (50) 				not null,
Ciudad 		varchar (100) 				not null,
Telefono 	varchar (10) 				not null,
idCoordi 	int							not null,
idTutor		int 						not null,
idEmpresa	int							not null,
constraint	foreign key(idCoordi) references coordi(idCoordi),
constraint	foreign key(idTutor) references Tutor(idTutor),
constraint	foreign key(idEmpresa) references Empresa(idEmpresa)
);

-- TABLA PROYECTO
create table Proyecto
(
idProyecto 				int 														not null primary key,
Nombre 					varchar(45) 												not null,
PeriodoProyecto 		varchar (100) 												not null,
NumeroResidencias 		int 														not null,
opcionElegida 			enum ('Banco de Proyectos','Propuesta propia','Trabajador') not null,
idEmpresa 				int 														not null,
constraint	foreign key(idEmpresa) references Empresa(idEmpresa)
);

-- TABLA EMPRESA
create table Empresa
(
idEmpresa 					int not null primary key,
giraRamaSector 				enum ('Industrial','Servicios','Publico','Privado') not null,
otrogrs 					varchar (45) 		not null,
rfc 						varchar (1) 		not null,
cp 							varchar (5) 		not null,
domicilio 					varchar (100) 		not null,
fax 						varchar (10) 		not null,
colonia 					varchar (100) 		not null,
telefono 					varchar (10) 		not null,
MisionEmpresa 				longtext 			not null,
NombreTitularEmpresa 		varchar (150) 		not null,
PuestoTitularEmpresa 		varchar (50) 		not null,
NombreAsesorExterno 		varchar (150) 		not null,
PuestoAsesorExterno 		varchar (50) 		not null,
NombrePersonaFirma 			varchar (150) 		not null,
PuestoPersonaFirma 			varchar (150) 		not null
);

-- TABLA COORDINADOR
create table coordi
(
idCoordi 	int primary key not null,
Nombre 		varchar(45) 	not null,
apellidoP 	varchar(45) 	not null,
apellidoM 	varchar(45) 	null,
Carrera 	varchar(45) 	not null,
correo 		varchar(100)	null,
Telefono 	varchar (10) 	null
);

-- TABLA TUTOR 
CREATE TABLE Tutor
(
idTutor					int	primary key 			not null,
nombre					varchar(45)					not null,
apellido1				varchar(45) 				not null,
apellido2				varchar(45) 				null
);

-- TABLA REVISOR 
CREATE TABLE Revisor
(
idRevisor				int				primary key not null,
nombre					varchar(45)					not null,
apellido1				varchar(45) 				not null,
apellido2				varchar(45) 				null
);

-- TABLA USUARIOS
create table usuarios
(
nombreUsuario varchar (50) not null,
contrasenia varchar (20) not null
);

-- TABLA REVISAR DOCUMENTOS
create table RevisarDoc
(
idDocumento 		int primary key 	not null,
Calificacion 		int 				not null,
Notas 				longtext 			null,
idRevisor 			int 				not null,
noControl 			varchar (9) 		not null,
constraint	foreign key(idRevisor) references Revisor(idRevisor),
constraint	foreign key(noControl) references Residente(noControl)
);