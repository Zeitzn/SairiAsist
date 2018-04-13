
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Isac huamán PIneda
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- Test: exec sp_asistencia_docente_lst
-- =============================================
alter PROCEDURE sp_asistencia_docente_lst
	
AS
BEGIN
	
	select * from AsistenciaDocente;
END
GO

