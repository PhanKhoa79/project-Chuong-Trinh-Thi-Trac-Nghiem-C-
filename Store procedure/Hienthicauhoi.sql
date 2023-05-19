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
CREATE PROCEDURE hienthi_cauhoi
AS
BEGIN
	SELECT CAUHOI.IdCauHoi,  CAUHOI.CauHoi, CAUHOI.Dap_An_A, CAUHOI.Dap_An_B, CAUHOI.Dap_An_C, CAUHOi.Dap_An_D, CAUHOI.DapAnDung, MONTHI.TenMonThi, MUCDO.TenMucDo, CHUONG.TenChuong
FROM CAUHOI
INNER JOIN Chuong ON CAUHOI.IdChuong = Chuong.IdChuong
INNER JOIN MONTHI ON CAUHOI.IdMonThi = MONTHI.IdMonThi
INNER JOIN MUCDO ON CAUHOI.IdMucDo = MUCDO.IdMucDo
END
GO
EXEC hienthi_cauhoi
CREATE PROCEDURE hienthi_cauhoi_1
@monthi nvarchar(20)
AS
BEGIN
	SELECT CAUHOI.IdCauHoi,  CAUHOI.CauHoi, CAUHOI.Dap_An_A, CAUHOI.Dap_An_B, CAUHOI.Dap_An_C, CAUHOi.Dap_An_D, CAUHOI.DapAnDung, MONTHI.TenMonThi, MUCDO.TenMucDo, CHUONG.TenChuong 
FROM CAUHOI
INNER JOIN Chuong ON CAUHOI.IdChuong = Chuong.IdChuong
INNER JOIN MONTHI ON CAUHOI.IdMonThi = MONTHI.IdMonThi
INNER JOIN MUCDO ON CAUHOI.IdMucDo = MUCDO.IdMucDo
where MONTHI.IdMonThi = @monthi
END
CREATE PROCEDURE hienthi_cauhoi_3
         @chuong nvarchar(20),
         @monthi nvarchar(20)
AS
BEGIN
	SELECT CAUHOI.IdCauHoi,  CAUHOI.CauHoi, CAUHOI.Dap_An_A, CAUHOI.Dap_An_B, CAUHOI.Dap_An_C, CAUHOi.Dap_An_D, CAUHOI.DapAnDung, MONTHI.TenMonThi, MUCDO.TenMucDo, CHUONG.TenChuong 
FROM CAUHOI
INNER JOIN Chuong ON CAUHOI.IdChuong = Chuong.IdChuong
INNER JOIN MONTHI ON CAUHOI.IdMonThi = MONTHI.IdMonThi
INNER JOIN MUCDO ON CAUHOI.IdMucDo = MUCDO.IdMucDo
where CHUONG.IdChuong = @chuong AND MONTHI.IdMonThi = @monthi
END

CREATE PROCEDURE xoa_cauHoii
@cauhoi nvarchar(200)
AS
BEGIN
DELETE FROM CAUHOI WHERE CauHoi = @cauhoi
END

CREATE PROCEDURE update_CauHoii
	@IdCauHoi int,
    @CauHoi nvarchar(200),
	@Dap_An_A nvarchar(100),
	@Dap_An_B nvarchar(100),
	@Dap_An_C nvarchar(100),
	@Dap_An_D nvarchar(100),
	@DapAnDung nvarchar(100),
	@IdMonThi nvarchar(20),
	@IdMucDo nvarchar(20),
	@IdChuong nvarchar(20)
AS
BEGIn
UPDATE CAUHOI SET CauHoi = @CauHoi, Dap_An_A = @Dap_An_A, Dap_An_B = @Dap_An_B, Dap_An_C = @Dap_An_C, Dap_An_D = @Dap_An_D, DapAnDung = @DapAnDung, IdMonThi = @IdMonThi, IdMucDo = @IdMucDo, IdChuong = @IdChuong where IdCauHoi = @IdCauHoi
END


