-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE timkiem_CauHoii
@cauhoi nvarchar(200)
AS
BEGIN 
SELECT CAUHOI.IdCauHoi,  CAUHOI.CauHoi, CAUHOI.Dap_An_A, CAUHOI.Dap_An_B, CAUHOI.Dap_An_C, CAUHOi.Dap_An_D, CAUHOI.DapAnDung, MONTHI.TenMonThi, MUCDO.TenMucDo, CHUONG.TenChuong 
FROM CAUHOI
INNER JOIN Chuong ON CAUHOI.IdChuong = Chuong.IdChuong
INNER JOIN MONTHI ON CAUHOI.IdMonThi = MONTHI.IdMonThi
INNER JOIN MUCDO ON CAUHOI.IdMucDo = MUCDO.IdMucDo
WHERE CAUHOI.CauHoi = @cauhoi
END

