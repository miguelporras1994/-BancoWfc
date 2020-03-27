create  database inventario;
drop table His;
drop  table  tercero;
drop table Eqs;
drop table lic;
drop table Est;
drop table Mar;
drop table tip;
drop table Sde;



create table Tip(
Id_tipo int primary key  IDENTITY(1,1),
Nombre_tipo varchar(20) not null,
)

create  table Mar(
Id_marca int primary Key IDENTITY(1,1),
Nom_marca varchar(30) not null,
);

create table Est (
Id_estado int primary key  IDENTITY(1,1) ,
Nom_estado varchar(20) not null
);

create table Sde(
id_sede varchar(10) primary key ,
Nom_sede  varchar(30) not null,
Dirrecion_sed  varchar(60),
Fecha_sed date not null
)

create table  Eqs(
id_dispositivo varchar(10) primary key not null,
id_marca  int not null,
Nom_marca varchar(20) not null,
Modelo varchar(30) not null,
Id_tipo int not null,
Nom_tipo varchar(30 ) not null,
Ram varchar(10) ,
Procesador varchar(20) ,
Tipo_disco varchar(20) ,
Capa_disco varchar(20),
Costo float not null,
Fecha_de_compra date not null,
Id_estado int not null,
Nom_estado varchar(20) not null,
FOREIGN KEY (id_marca)  REFERENCES mar (id_marca),
FOREIGN KEY (Id_tipo)  REFERENCES tip (id_tipo),
FOREIGN KEY (Id_estado) REFERENCES est(id_estado)
)


create table Tercero(
Id_tercero varchar(20) primary key ,
Nombre_ter  varchar(40) not null,
Apellido_ter varchar(40) not null,
Cargo varchar(40) not null,
Id_estado  int,
Nom_estado varchar(20)  not null
FOREIGN KEY (Id_estado) REFERENCES  est(id_estado)
)

create table Lic (
Id_licencia varchar(10) primary key,
Nombre_lic varchar(30),
Version_lic varchar(30),
Costo_lic    float  ,
Id_marca    int,
Nom_marca   varchar(30),
Fecha_compra_lic date ,
Fecha_vencimiento date, 
Id_Estado   int ,
Nom_Estado  varchar(20),
FOREIGN KEY (id_marca)  REFERENCES mar (id_marca),
FOREIGN KEY (Id_Estado) REFERENCES  est(id_estado))





create table  His (
id_moviento int IDENTITY(1,1) primary key,
id_dispositivo varchar(10),
id_tercero varchar(20),
Nombre_ter varchar(40),
Apellido_ter varchar(40),
Id_sede varchar(10),
Fecha_adicion  date,
Id_licencia varchar(10),
Nom_licencia varchar(40),
Id_Estado int,
Nom_Estado  varchar(20),
Observacion varchar(200),
FOREIGN KEY (id_dispositivo) REFERENCES  eqs (id_dispositivo),
FOREIGN KEY (id_tercero) REFERENCES tercero (Id_tercero),
FOREIGN KEY (Id_licencia) REFERENCES lic (Id_licencia),
FOREIGN KEY (Id_sede) REFERENCES sde(Id_sede),
FOREIGN KEY (Id_estado) REFERENCES  est(id_estado)
)


