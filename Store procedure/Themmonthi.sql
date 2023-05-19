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
CREATE PROCEDURE Them_MonThi
	@IdMonThi nvarchar(20),
	@TenMonThi nvarchar(20),
	@NgayThi date
AS
BEGIN
	Insert into MONTHI VALUES(@IdMonThi, @TenMonThi, @NgayThi)
END
GO
CREATE PROCEDURE Sua_MonThi
	@IdMonThi nvarchar(20),
	@TenMonThi nvarchar(20),
	@NgayThi date
AS
BEGIN
	UPDATE MONTHI SET TenMonThi = @TenMonThi, NgayThi = @NgayThi where IdMonThi = @IdMonThi 
END
GO
CREATE PROCEDURE Xoa_MonThi
	@IdMonThi nvarchar(20)
AS
BEGIN
	DELETE MONTHI WHERE IdMonThi = @IdMonThi
END
GO