create database RestauranteFormulario

go

use RestauranteFormulario

go

create table Producto (
idProducto int identity(1,1) NOT NULL PRIMARY KEY,
Nombre varchar(50) not null,
Descripcion varchar(700) not null,
Precio decimal(5,2) not null,
Cantidad int,
Estado int,
)

go


--------------------------------------------
--ESTOS SON LOS PROCEDIMIENTOS ALMACENADOS-- 
--------------------------------------------

----------MOSTRAR-----------
create proc MostrarProductos
as
select *from Producto
go

exec MostrarProductos

--------INSERTAR------------
create proc InsertarProductos
@nombre varchar (100),
@descripcion varchar (100),
@precio float,
@cantidad int,
@estado int
as
insert into Producto values (@nombre,@descripcion,@precio,@cantidad,@estado)

go

exec InsertarProductos 'Pupusas', 'Revueltas', 0.25, 35,1

