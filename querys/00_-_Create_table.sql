use Master
go

------------
Create database ZooZone
go

------------

Use ZooZone
go
------------


Create table Proveedor(
	Id_Proveedor int primary key identity(1,1),
	Compañía varchar(50),
	Dirección varchar(100)
)
go

Create table Categoría(
	Id_Categoria int primary key identity(1,1),
	Nombre varchar(20),
	Descripción varchar(50)
)
go

create table Alimento(
	Id_Alimento int primary key identity(1,1),
	Nombre varchar(20),
	Existencia int,
	Id_Categaria int not null
)
Alter table Alimento Add foreign key (Id_Categaria)
references Categoría(Id_Categoria)
go

Create table Proveedor_Alimento(
	Id_Proveedor int not null,
	Id_Alimento int not null,
	Cantidad int,
	Descripción varchar(50),
	[Fecha de Compra] date,
	[Fecha de vencimiento] date
)
Alter table Proveedor_Alimento Add foreign key (Id_Proveedor)
references Proveedor(Id_Proveedor)
Alter table Proveedor_Alimento Add foreign key (Id_Alimento)
references Alimento(Id_Alimento)
go

Create table Donador(
	Id_Donador int primary key identity(1,1),
	Nombre varchar(20)
)
go

Create table Donador_Alimento(
	Id_Donador int not null,
	Id_Alimento int not null,
	Cantidad int,
	Descripcion varchar(50),
	[Fecha de Compra] date,
	[Fecha de vencimiento] date
)
Alter table Donador_Alimento Add foreign key (Id_Donador)
references Donador(Id_Donador)
Alter table Donador_Alimento Add foreign key (Id_Alimento)
references Alimento(Id_Alimento)
go

Create table Continete(
	Id_Continente int primary key identity(1,1),
	Nombre varchar(20)
)
go

Create table Hábitat(
	Id_Habitat int primary key identity(1,1),
	Id_Continente int not null,
	Nombre varchar(20),
	Clima varchar(20),
	[Tipo de vegetación] varchar(20)
)
Alter table Hábitat Add foreign key (Id_Continente)
references Continete(Id_Continente)
go

Create table Especie(
	Id_Especie int primary key Identity(1,1),
	[Nombre Vulgar] varchar(20),
	[Nombre científico] varchar(30),
	Descripción varchar(80)
)
go

Create table Especie_Hábitat(
	Id_Especie int not null,
	Id_Habitat int not null
)
Alter table Especie_Hábitat Add foreign key (Id_Especie)
references Especie(Id_Especie)
Alter table Especie_Hábitat Add foreign key (Id_Habitat)
references Hábitat(Id_Habitat)
go

Create table Zona(
	Id_Zona int primary key identity(1,1),
	Nombre varchar(20),
	Extensión int
)
go

Create table Animal(
	Id_Animal int primary key identity(1,1),
	Id_Especie int not null,
	Id_Zona int not null,
	Nombre varchar(20),
	Descripción varchar(50),
	Peso int,
	Altura int
)
Alter table Animal Add foreign key (Id_Especie)
references Especie(Id_Especie)
Alter table Animal Add foreign key (Id_Zona)
references Zona(Id_Zona)
go

Create table Consumo(
	Id_Animal int not null,
	Id_Alimento int not null,
	[Cantidad Consumida] int,
	Fecha datetime
)
Alter table Consumo Add foreign key (Id_Animal)
references Animal(Id_Animal)
Alter table Consumo Add foreign key (Id_Alimento)
references Alimento(Id_Alimento)
go

Create table Veterinario(
	Id_Veterinario int primary key identity(1,1),
	[Primer Nombre] varchar(20),
	[Segundo Nombre] varchar(20),
	[Primer Apellido] varchar(20),
	[Segundo Apellido] varchar(20),
	Dirección varchar(40),
	Teléfono varchar(20),
	Sexo varchar (12),
	[Fecha de Ingreso] date,
	Cédula varchar(20),
	[Años de Experiencia] int
)
go

Create table Vacuna(
	Id_Vacuna int primary key identity(1,1),
	Nombre varchar(20)
)
go

Create table Detalle_Vacuna(
	Id_Veterinario int not null,
	Id_Vacuna int not null,
	Id_Animal int not null,
	Dósis float,
	Fecha date
)
Alter table Detalle_Vacuna Add foreign key (Id_Veterinario)
references Veterinario(Id_Veterinario)
Alter table Detalle_Vacuna Add foreign key (Id_Vacuna)
references Vacuna(Id_Vacuna)
Alter table Detalle_Vacuna Add foreign key (Id_Animal)
references Animal(Id_Animal)
go

Create table Consulta(
	Id_Consulta int primary key identity(1,1),
	Id_Animal int not null,
	Id_Veterinario int not null,
	Costo float,
	Descripción varchar(50)
)
Alter table Consulta Add foreign key (Id_Veterinario)
references Veterinario(Id_Veterinario)
Alter table Consulta Add foreign key (Id_Animal)
references Animal(Id_Animal)
go

Create table Detalle_Consulta(
	Id_Consulta int not null,
	Costo float,
	Descripción varchar(50)
)
Alter table Detalle_Consulta Add foreign key (Id_Consulta)
references Consulta(Id_Consulta)
go

Create table Desparasitante(
	Id_Desparasitante int primary key identity(1,1),
	Nombre varchar(20)
)
go

Create table Cuidador(
	Id_Cuidador int primary key identity(1,1),
	[Primer Nombre] varchar(20),
	[Segundo Nombre] varchar(20),
	[Primer Apellido] varchar(20),
	[Segundo Apellido] varchar(20),
	Dirección varchar(40),
	Teléfono varchar(20),
	Sexo varchar (12),
	[Fecha de Ingreso] date,
	Cédula varchar(20)
)
go

Create table Detalle_Desparasitante(
	Id_Animal int not null,
	Id_Desparasitante int not null,
	Id_Cuidador int not null,
	Dósis float,
	Fecha date
)
Alter table Detalle_Desparasitante Add foreign key (Id_Cuidador)
references Cuidador(Id_Cuidador)
Alter table Detalle_Desparasitante Add foreign key (Id_Desparasitante)
references Desparasitante(Id_Desparasitante)
Alter table Detalle_Desparasitante Add foreign key (Id_Animal)
references Animal(Id_Animal)
go

Create table Vendedor_ticket(
	Id_Vendedor int primary key identity(1,1),
	[Primer Nombre] varchar(20),
	[Segundo Nombre] varchar(20),
	[Primer Apellido] varchar(20),
	[Segundo Apellido] varchar(20),
	Dirección varchar(40),
	Teléfono varchar(20),
	Sexo varchar (12),
	[Fecha de Ingreso] date,
	Cédula varchar(20)
)
go

Create table Cliente(
	Id_Cliente int primary key identity(1,1),
	[Primer Nombre] varchar(20),
	[Segundo Nombre] varchar(20),
	[Primer Apellido] varchar(20),
	[Segundo Apellido] varchar(20),
	Cédula varchar(20)
)
go

Create table Venta(
	Id_Venta int primary key identity(1,1),
	Id_Cliente int not null,
	Id_Vendedor int not null,
	Fecha datetime,
	[Venta total] float
)
Alter table Venta Add foreign key (Id_Cliente)
references Cliente(Id_Cliente)
Alter table Venta Add foreign key (Id_Vendedor)
references Vendedor_ticket(Id_Vendedor)
go

Create table Boletos(
	Id_Venta int not null,
	[Cantidad de Niños] int,
	[Precio de Niños] float,
	[Cantidad de Adultos] int,
	[Precio de Adultos] float
)
Alter table Boletos Add foreign key (Id_Venta)
references Venta(Id_Venta)
go

Create table Cuidador_Zona(
	Id_Cuidador int not null,
	Id_Zona int not null
)
Alter table Cuidador_Zona Add foreign key (Id_Cuidador)
references Cuidador(Id_Cuidador)
Alter table Cuidador_Zona Add foreign key (Id_Zona)
references Zona(Id_Zona)
go

Create table Guía(
	Id_Guia int primary key identity(1,1),
	[Primer Nombre] varchar(20),
	[Segundo Nombre] varchar(20),
	[Primer Apellido] varchar(20),
	[Segundo Apellido] varchar(20),
	Dirección varchar(40),
	Teléfono varchar(20),
	Sexo varchar (12),
	[Fecha de Ingreso] date,
	Cédula varchar(20)
)
go

Create table Tour(
	Id_Tour int primary key identity(1,1),
	Duración float,
	[Máximo de Visitantes autorizados] int
)
go

Create table Zona_Guia(
	Id_Zona int not null,
	Id_Tour int not null
)
go
Alter table Zona_Guia Add foreign key (Id_Tour)
references Tour(Id_Tour)
Alter table Zona_Guia Add foreign key (Id_Zona)
references Zona(Id_Zona)
go

Create table Detalle_Tour(
	Id_Guia int not null,
	Id_Tour int not null,
	Id_Venta int primary key,
	Fecha datetime,
	Precio float
)
Alter table Detalle_Tour Add foreign key (Id_Tour)
references Tour(Id_Tour)
Alter table Detalle_Tour Add foreign key (Id_Guia)
references Guía(Id_Guia)
Alter table Detalle_Tour Add foreign key (Id_Venta)
references Venta(Id_Venta)
go