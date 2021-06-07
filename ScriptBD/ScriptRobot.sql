use master
go

if exists(select 1 from sys.databases where name = 'BDROBOT')
	begin
		drop database BDROBOT
	end
go

create database BDROBOT
go

use BDROBOT
go

create table Tb_Proceso
(
	ProcesoID int primary key,
	ProcesoName	varchar(30),
	ProcesoDescription varchar(150),
	FlagActivo int,
	TipoProcesoID int,
	DiasSemana	varchar(100),
	HoraEjecucion time,
	FechaEjecucion date,
	NumDias int,
	NumMinutos int
)
go

create procedure Tb_Proceso_INSERT
	@ProcesoName varchar(30),
	@ProcesoDescription varchar(150),
	@FlagActivo int,
	@TipoProcesoID int,
	@DiasSemana	varchar(100),
	@HoraEjecucion time,
	@FechaEjecucion date,
	@NumDias int,
	@NumMinutos int
as
begin
	insert into Tb_Proceso
	(
		ProcesoID,
		ProcesoName,
		ProcesoDescription,
		FlagActivo,
		TipoProcesoID,
		DiasSemana,
		HoraEjecucion,
		FechaEjecucion,
		NumDias,
		NumMinutos
	)
	values
	(
		(select ISNULL(MAX(ProcesoID), 0) + 1 from Tb_Proceso),
		@ProcesoName,
		@ProcesoDescription,
		@FlagActivo,
		@TipoProcesoID,
		@DiasSemana,
		@HoraEjecucion,
		@FechaEjecucion,
		@NumDias,
		@NumMinutos
	)
end
go