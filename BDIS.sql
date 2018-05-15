drop database BDIS;
create database BDIS;
use bdis;

-- TABLA Alumno 
CREATE TABLE Alumno
(
idAlumno			    varchar(9) primary key 		not null,
nombre					varchar(45)					not null,
apellido1				varchar(45) 				not null,
apellido2				varchar(45) 				null,
Carrera 				varchar(45) 				not null
);

-- TABLA EMPRESA
create table Empresa
(
idEmpresa 					varchar (100) not null primary key,
giraRamaSector 				enum ('Industrial','Servicios','Publico','Privado','Otro') not null,
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
idCoordi 	varchar(9) primary key  not null,
Nombre 		varchar(45) 			not null,
apellidoP 	varchar(45) 			not null,
apellidoM 	varchar(45) 			null,
Carrera 	varchar(45) 			not null,
correo 		varchar(100)			null,
Telefono 	varchar (10) 			null,
contrasenia varchar (16) 			not null
);

-- TABLA TUTOR 
CREATE TABLE Tutor
(
idTutor					varchar(9)	primary key     not null,
nombre					varchar(45)					not null,
apellido1				varchar(45) 				not null,
apellido2				varchar(45) 				null
);

-- TABLA REVISOR 
CREATE TABLE Revisor
(
idRevisor				varchar(9)		primary key not null,
nombre					varchar(45)					not null,
apellido1				varchar(45) 				not null,
apellido2				varchar(45) 				null,
contrasenia				varchar(16) 				not null
);

-- TABLA USUARIOS
create table usuarios
(
nombreUsuario varchar (50) not null,
contrasenia varchar (20) not null
);

-- TABLA RESIDENTE
create table Residente
(
noControl 	varchar(9) primary key 		not null,
Contrasenia	varchar(45) 				not null,
Nombre 		varchar(45) 				not null,
apellidoP 	varchar(45) 				not null,
apellidoM 	varchar(45) 				not null,
Carrera 	varchar(45) 				not null,
Aceptado    enum('Aceptado','Rechazado')null,
correo 		varchar(100)				not null,
NoSS 		varchar (50) 				not null,
Ciudad 		varchar (100) 				not null,
Telefono 	varchar (10) 				not null,
idCoordi 	varchar(9)				    null,
idTutor		varchar(9) 				    null,
idEmpresa	varchar(100)				not null,
idRevisor1	varchar(9)					null,
idRevisor2	varchar(9)					null,
constraint	foreign key(idCoordi) references coordi(idCoordi),
constraint	foreign key(idTutor) references Tutor(idTutor),
constraint	foreign key(idRevisor1) references Revisor(idRevisor),
constraint	foreign key(idRevisor2) references Revisor(idRevisor),
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
idEmpresa 				varchar(100)												not null,
constraint	foreign key(idEmpresa) references Empresa(idEmpresa)
);

-- TABLA REVISAR DOCUMENTOS

create table RevisarDoc
(
idDocumento 		int primary key 	not null,
Calificacion 		int 				not null,
Notas 				longtext 			null,
idRevisor 			varchar(9) 			not null,
idResidente 		varchar (9) 		not null,
constraint	foreign key(idRevisor) references Revisor(idRevisor),
constraint	foreign key(idResidente) references Residente(noControl)
);


-- INSERTAR DATOS EN TABLA ALUMNO
-- IdAlumno | Nombre | Apellido1 | Apellido2 | Carrera
insert into Alumno values ('S15120001','Juan Carlos','Hurtado','Morales','Sistemas'),
('S15120002','Miguel Alejandro','Vazquez','Alberto','Industrial'),
('S15120003','Ricardo Fabian','Juarez','Santoyo','Gestion'),
('S15120004','Jose Guadalupe','Rivera','Alcantar','Automotriz'),
('S15120005','Juan Manuel','Garcia','Ibarra','Gastronomia');
select * from alumno where concat(Nombre,' ',apellido1,' ',apellido2) like 'Ricardo Fabian Juarez Santoyo';
-- INSERTAR DATOS EN LA TABLA COORDI
-- IdCoordi | Nombre | ApellidoP | ApellidoM | Carrera | Correo | Telefono | Contrasenia
insert into Coordi values ('C18100001','Lionel','Messi','Perez','Sistemas','messi@gmail.com','','Messi10'),
('C18100002','Cristiano','Ronaldo','Gonzalez','Gastronomia','','1234567890','cr7papa'),
('C18100003','Dele','Alli','Fernandez','Industrial','da@gmail.com','2345678901','nopor69'),
('C18100004','Mohammed','Salah','Gomez','Gestion','','','allahuakbar911'),
('C18100005','Jerome','Boateng','Morales','Automotriz','jb17@gmail.com','3456789012','elmeromero17');

-- INSERTAR DATOS EN LA TABLA TUTOR
-- IdTutor | Nombre | ApellidoP | ApellidoM
insert into Tutor values ('T18100001', 'Efren','Vega','Chavez'),
('T18100002','German','Gutierrez',''),
('T18100003','Jorge','Guzman','Ramos'),
('T18100004','German','Guzman','Guzman'),
('T18100005', 'David','Morales','Orozco');

-- INSERTAR DATOS EN LA TABLA REVISORRES
-- IdRevisor | Nombre | ApellidoP | ApellidoM | Contrasenia
insert into Revisor values ('R18100001', 'Efren','Vega','Chavez','petit17'),
('R18100002','German','Gutierrez','Torres','ronaldo9'),
('R18100003','Jorge','Guzman','Ramos','yashin1'),
('R18100004','German','Guzman','Guzman','magneto97'),
('R18100005', 'David','Morales','Orozco','lastjedi9') ;


