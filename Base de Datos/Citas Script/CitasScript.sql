/*PROCEDIMIENTOS ALMACENADOS DE CITAS: ConsultarCitas */

CREATE PROCEDURE [dbo].[ConsultarCitaSP]
AS
BEGIN
SELECT [id_cita]
      ,[estilista]
      ,[fecha]
      ,[sede]
      ,[nombre_cliente]
      ,[servicio]
      ,[descripcion_servicio]
  FROM [dbo].[citas]
END
GO



/*PROCEDIMIENTOS ALMACENADOS DE CITAS: RegistrarCitas */

CREATE PROCEDURE [dbo].[RegistrarCitaSP]
    @estilista VARCHAR(100),
    @fecha DATETIME,
    @sede VARCHAR(50),
    @nombre_cliente VARCHAR(100),
    @servicio VARCHAR(30),
    @descripcion_servicio VARCHAR(200)
AS
BEGIN
    INSERT INTO Citas (estilista, fecha, sede, nombre_cliente, servicio, descripcion_servicio)
    VALUES (@estilista, @fecha, @sede, @nombre_cliente, @servicio, @descripcion_servicio)
END
GO


USE [salonbellezaMN]
GO

/****** Object:  StoredProcedure [dbo].[ActualizarCitaSP]    Script Date: 10/11/2023 22:51:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ActualizarCitaSP]
		@estilista				varchar(100),
		@fecha					datetime,
		@sede					varchar(50),
		@nombre_cliente			varchar(100),
		@servicio				varchar(30),
		@descripcion_servicio	varchar(200),
		@id_cita int
AS
BEGIN
		
UPDATE dbo.citas
   SET estilista =				@estilista,
       fecha =					@fecha,
       sede =					@sede, 
       nombre_cliente =		    @nombre_cliente,
       servicio =			    @servicio,
       descripcion_servicio =   @descripcion_servicio

	   where id_cita =			@id_cita
END
GO




