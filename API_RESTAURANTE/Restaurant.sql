create database Restaurant

go

use 
Restaurant
go

create table Cliente(
idCliente int primary key identity (1,1)not null,
);

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


create table Venta(
idVenta int primary key identity(1,1) not null,
idCliente int not null,
num_comprobante varchar (10) not null,
fecha_hora datetime default getdate(),
total decimal (11,2) not null,
FOREIGN KEY (idCliente) REFERENCES Cliente (idCliente)
);

go

create table detalle_factura(
idDetalle_venta integer primary key identity (1,1),
idVenta int not null,
idProducto int not null,
idCliente int not null,
precio decimal(11,2) not null,
FOREIGN KEY (idVenta) REFERENCES Venta (idVenta),
FOREIGN KEY (idProducto) REFERENCES Producto (idProducto),
FOREIGN KEY (idCliente) REFERENCES Cliente (idCliente)
);

go
