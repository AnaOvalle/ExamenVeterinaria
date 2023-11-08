create database Veterinaria

use Veterinaria

create table Usuario
(
Nombre varchar (50) null,
Usuario varchar(50) null,
Contraseña varchar (50) null,
Tip_user varchar (50) null
)
drop table Usuario

insert into Usuario values
('Ana Ovalle','nagini','2016','Admin');

create table Pacientes
(
IDPaciente int primary key not null,
Nombre varchar(50),
Especie varchar(50),
Raza varchar(50),
Edad varchar(50),
FechaNacimiento date,
Color varchar(50),
Propietario varchar(50),
Imagen varbinary(max)
)

create table Especie
(
TipoEspecie varchar(50) not null
)

insert into Especie values
('Can'),
('Felino'),
('Roedor'),
('Reptil'),
('Lagomorfo'),
('Ave')

select * from Pacientes