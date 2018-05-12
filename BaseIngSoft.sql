create database ing;
use ing;
drop database ing ;

create table alumnos(
idClaveAlumnos   int  not null,
Nombre    varchar(50)   not null,
ApellidoP varchar(50) not null,
ApellidoM  Varchar(50) not null,
Carrera    varchar(50) not null,
FechaIngreso date not null,
idClaveTutor int not null,
constraint primary key (idClaveAlumnos),
constraint foreign key (idClaveTutor) references tutor (idClaveTutor)
);



create table maestro
(
idClaveMaestro  int not null,
Nombre    varchar(50)   not null,
ApellidoP varchar(50) not null,
ApellidoM  Varchar(50) not null,
Carrera    varchar(50) not null,
FechaIngreso date not null,
idClaveAlumnos   int  not null   ,
idClaveCoordi int not null,
constraint primary key (idClaveMaestro),
constraint foreign key (idClaveAlumnos) references alumnos (idClaveAlumnos),
constraint foreign key (idClaveCoordi) references coordinador (idClaveCoordi)
);

create table tutor
(
idClaveTutor  int not null primary key,
Nombre    varchar(50)   not null,
ApellidoP varchar(50) not null,
ApellidoM  Varchar(50) not null,
Carrera    varchar(50) not null,
FechaIngreso date not null
);

create table coordinador
(
idClaveCoordi  int not null primary key,
Nombre    varchar(50)   not null,
ApellidoP varchar(50) not null,
ApellidoM  Varchar(50) not null,
Carrera    varchar(50) not null,
FechaIngreso date not null
);
