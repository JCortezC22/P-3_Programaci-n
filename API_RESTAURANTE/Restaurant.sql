create database Restaurant

go

use 
Restaurant
go


create table Producto (
idProducto int identity(1,1) NOT NULL PRIMARY KEY,
Nombre varchar(50) not null,
Descripcion varchar(700) not null,
Precio decimal(5,2) not null,
Cantidad int,
Estado int,
Foto varchar (1000)
);

go


