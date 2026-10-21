Create database SistemaInventario
go

use SistemaInventario
go

Create Table Categorias 
(
CategoriaId int identity(1,1) primary key
,Nombre Varchar(100) not null unique
,Descripcion Varchar(500) not null
,Activo bit not null default 1
,FechaCreacion Datetime not null default getdate()
,FechaModificacion Datetime null
)
go

Create Table CategoriaFoto 
(
FotoId int identity(1,1) primary key
,CategoriaId int not null
,RutaFoto Varchar(200) not null
,foreign key (CategoriaId) references Categorias(CategoriaId) 
on 
delete 
cascade
)
go

Create Table Suplidores 
(
SuplidorId int identity(1,1) primary key
,NombreEmpresa Varchar(100) not null unique
,NombreContacto Varchar(100) not null
,Telefono Varchar(15) not null
,CorreoEmail Varchar(100) not null
,Activo bit not null default 1
,FechaCreacion datetime not null default getdate()
,FechaModificacion datetime null
)
go

Create Table Productos 
(
ProductoId int identity(1,1) primary key
,Nombre Varchar(100) not null
,PrecioUnitario decimal(18,2) not null check (PrecioUnitario > 0)
,CategoriaId int not null
,SuplidorId int not null
,Activo bit not null default 1
,FechaCreacion datetime not null default getdate()
,FechaModificacion datetime null
,foreign key (CategoriaId) references Categorias(CategoriaId)
,foreign key (SuplidorId) references Suplidores(SuplidorId)
)
go