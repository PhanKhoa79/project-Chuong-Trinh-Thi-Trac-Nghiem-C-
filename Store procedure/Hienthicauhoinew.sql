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
CREATE PROCEDURE up_cauhoii
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
BEGIN

	INSERT INTO CAUHOI(CauHoi ,Dap_An_A ,Dap_An_B ,Dap_An_C ,Dap_An_D ,DapAnDung ,IdMonThi ,IdMucDo ,IdChuong)
	VALUES( @CauHoi, @Dap_An_A, @Dap_An_B, @Dap_An_C, @Dap_An_D, @DapAnDung, @IdMonThi, @IdMucDo, @IdChuong)
END
GO
