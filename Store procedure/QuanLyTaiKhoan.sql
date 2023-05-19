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
CREATE PROCEDURE them_TK1
	@TaiKhoan nvarchar(50),
	@MatKhau nvarchar(50),
	@Email nvarchar(100),
	@ID_PhanQuyen int
AS
BEGIN
	INSERT INTO TAI_KHOAN(TaiKhoan, MatKhau, Email, ID_PhanQuyen)
	VALUES(@TaiKhoan, @MatKhau, @Email, @ID_PhanQuyen)
END
GO

CREATE PROCEDURE hienthi_TK1

AS
BEGIN
	SELECT TAI_KHOAN.ID_TK, TAI_KHOAN.TaiKhoan, TAI_KHOAN.MatKhau, TAI_KHOAN.Email, PHANQUYEN.TEN_PHANQUYEN
	FROM TAI_KHOAN
	INNER JOIN PHANQUYEN ON TAI_KHOAN.ID_PhanQuyen = PHANQUYEN.ID_PhanQuyen
END
GO

CREATE PROCEDURE timkiem_TK
	@TaiKhoan nvarchar(50),
	@Email nvarchar(100)
AS
BEGIN
	SELECT TAI_KHOAN.ID_TK, TAI_KHOAN.TaiKhoan, TAI_KHOAN.MatKhau, TAI_KHOAN.Email, PHANQUYEN.TEN_PHANQUYEN
	FROM TAI_KHOAN
	INNER JOIN PHANQUYEN ON TAI_KHOAN.ID_PhanQuyen = PHANQUYEN.ID_PhanQuyen
	Where TaiKhoan = @TaiKhoan OR Email = @Email
END
GO
CREATE PROCEDURE update_TK
	@ID_TK int,
	@TaiKhoan nvarchar(50),
	@MatKhau nvarchar(50),
	@Email nvarchar(100),
	@ID_PhanQuyen int
AS
BEGIN
	UPDATE TAI_KHOAN SET TaiKhoan = @TaiKhoan, MatKhau = @MatKhau, Email = @Email, ID_PhanQuyen = @ID_PhanQuyen where ID_TK = @ID_TK

END
GO