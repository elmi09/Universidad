--114275-1w4-Colazo Braian
--1.1
create database universidad
go
use universidad
go
create table carreras
(id_carrera int,
nombre varchar(50),
constraint pk_carrera primary key (id_carrera))

create table asignaturas 
(id_asignatura int,
nombre varchar (50),
constraint pk_asignatura primary key (id_asignatura))

create table detalles_carreras
(id_detalle_carrera int,
id_carrera int,
id_asignatura int,
anioCursado int,
cuatrimestre int,
constraint pk_detalle_carrera primary key (id_detalle_carrera),
constraint fk_carrera foreign key (id_carrera) references carreras(id_carrera),
constraint fk_asignatura foreign key (id_asignatura) references asignaturas(id_asignatura))

go

--muestra las ingenierias
create proc carreras_ingenierias
as
select nombre
from carreras
where nombre like 'Ingenieria%'
go
insert into asignaturas(id_asignatura,nombre)
values (1,'Programacion I')
insert into asignaturas(id_asignatura,nombre)
values (2,'Ingles II')
insert into asignaturas(id_asignatura,nombre)
values (3,'Laboratorio en computacion I')
insert into asignaturas(id_asignatura,nombre)
values (4,'Ingles I')
go
create procedure SP_CONSULTAR_ASIGNATURAS
AS
BEGIN
select * from asignaturas
end
go
create procedure SP_CONSULTAR_CARRERA
AS
BEGIN
select * from carreras
end
go
create procedure SP_INSERTAR_DETALLE
@id_carrera int,
@id_detalle int,
@id_asignatura int,
@anio int,
@cuatrimestre int
as
begin
insert into detalles_carreras (id_detalle_carrera,id_carrera,id_asignatura,anioCursado,cuatrimestre)
values (@id_detalle,@id_carrera,@id_asignatura,@anio,@cuatrimestre)
end
go
create procedure [dbo].[SP_CONSULTAR_DETALLE]
AS
BEGIN
select dc.id_detalle_carrera ID, c.nombre Carrera ,a.nombre Asignatura,dc.anioCursado Año,cuatrimestre Cuatrimestre 
from detalles_carreras dc join asignaturas a on dc.id_asignatura=a.id_asignatura
join carreras c on dc.id_carrera=c.id_carrera
end
go
create procedure [dbo].[SP_CONSULTAR_DETALLES_CARRERA]
AS
begin
select * from detalles_carreras
end
go
create procedure [dbo].[SP_EDITAR_CARRERA]
@id_carrera int,
@nombre_carrera varchar(100)
as
begin
update carreras
set nombre=@nombre_carrera
where id_carrera = @id_carrera
end
go
create procedure [dbo].[SP_ELIMINAR_DETALLE_CARRERA]
@id_detalle int
as
begin
delete detalles_carreras
where  id_detalle_carrera = @id_detalle
end
go
create PROCEDURE [dbo].[SP_INSERTAR_MAESTRO] 
	@nombre varchar(255),
	
	@new_id int OUTPUT
AS
BEGIN
	INSERT INTO carreras(nombre)
    VALUES (@nombre);
    --Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
    SET @new_id = SCOPE_IDENTITY();

END
go
create procedure [dbo].[SP_BUSCARCARRERA]
@palabra varchar(100)
as
begin
select *
from carreras
where nombre like '%'+@palabra +'%'
end
