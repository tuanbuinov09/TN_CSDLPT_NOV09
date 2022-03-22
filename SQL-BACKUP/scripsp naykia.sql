USE [TN_CSDLPT]
GO
/****** Object:  User [HTKN]    Script Date: 22/03/2022 10:37:07 am ******/
CREATE USER [HTKN] FOR LOGIN [HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [sv_dungchung]    Script Date: 22/03/2022 10:37:07 am ******/
CREATE USER [sv_dungchung] FOR LOGIN [sv_dungchung] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [TH002]    Script Date: 22/03/2022 10:37:07 am ******/
CREATE USER [TH002] FOR LOGIN [vengian_giangvien] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [TH101]    Script Date: 22/03/2022 10:37:07 am ******/
CREATE USER [TH101] FOR LOGIN [kdthien_coso] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [TH657]    Script Date: 22/03/2022 10:37:07 am ******/
CREATE USER [TH657] FOR LOGIN [phngoc_truong] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [COSO]    Script Date: 22/03/2022 10:37:07 am ******/
CREATE ROLE [COSO]
GO
/****** Object:  DatabaseRole [GIANGVIEN]    Script Date: 22/03/2022 10:37:07 am ******/
CREATE ROLE [GIANGVIEN]
GO
/****** Object:  DatabaseRole [SINHVIEN]    Script Date: 22/03/2022 10:37:07 am ******/
CREATE ROLE [SINHVIEN]
GO
/****** Object:  DatabaseRole [TRUONG]    Script Date: 22/03/2022 10:37:07 am ******/
CREATE ROLE [TRUONG]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN]
GO
ALTER ROLE [SINHVIEN] ADD MEMBER [sv_dungchung]
GO
ALTER ROLE [GIANGVIEN] ADD MEMBER [TH002]
GO
ALTER ROLE [db_datareader] ADD MEMBER [TH002]
GO
ALTER ROLE [COSO] ADD MEMBER [TH101]
GO
ALTER ROLE [db_owner] ADD MEMBER [TH101]
GO
ALTER ROLE [TRUONG] ADD MEMBER [TH657]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [TH657]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [TH657]
GO
ALTER ROLE [db_datareader] ADD MEMBER [TH657]
GO
ALTER ROLE [db_owner] ADD MEMBER [COSO]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GIANGVIEN]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [TRUONG]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [TRUONG]
GO
ALTER ROLE [db_datareader] ADD MEMBER [TRUONG]
GO
/****** Object:  StoredProcedure [dbo].[SP_KT_GIAOVIEN_DATONTAI]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_KT_GIAOVIEN_DATONTAI] 
	@MAGV char(8)
AS
	IF  exists(SELECT MAGV FROM  dbo.GIAOVIEN WHERE MAGV = @MAGV)
   		RAISERROR ('Mã giáo viên đã tồn tại, vui lòng nhập mã khác', 16, 1)

	--IF  exists(SELECT TENMH FROM  dbo.MONHOC WHERE TENMH = @TENMH)
	--	RAISERROR ('Tên môn học đã tồn tại, vui lòng nhập tên khác', 16, 2)


GO
/****** Object:  StoredProcedure [dbo].[SP_KT_KHOA_DATONTAI]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_KT_KHOA_DATONTAI] 
	@MAKH char(8),
	@TENKH nvarchar(50),
	@CHEDOCHECK nchar(10)
AS
	--EXEC SP_KT_KHOA_DATONTAI 'VT2', N'Công nghệ thông tin', 'KTRATHEM'
	IF(@CHEDOCHECK='KTRATHEM')
	-- nếu thêm thì mã khoa ph chưa tồn tại ở 2 site, cộng thêm tên khoa cũng k đc trùng
		BEGIN 
			IF (EXISTS(SELECT MAKH FROM KHOA WHERE MAKH=@MAKH) 
				OR EXISTS (SELECT MAKH FROM LINK1.TN_CSDLPT.dbo.KHOA WHERE MAKH=@MAKH))
				RAISERROR('Mã khoa đã tồn tại', 16, 1) 
			IF(EXISTS (SELECT MAKH FROM KHOA WHERE TENKH=@TENKH) 
				OR EXISTS (SELECT MAKH FROM LINK1.TN_CSDLPT.dbo.KHOA WHERE TENKH=@TENKH))
				RAISERROR('Tên khoa đã tồn tại', 16, 2)
		END
	ELSE --@CHEDOCHECK='KTRASUA'
	-- nếu thêm thì nếu mã giống tên giống thì hợp lệ (không sửa chính nó nhưng vẫn lưu)
	-- nếu có mã khoa khác trùng tên khoa thì không hợp lí, ta bắt lỗi này
		BEGIN
			IF(EXISTS (SELECT TENKH FROM KHOA WHERE MAKH<>@MAKH AND TENKH=@TENKH ) 
				OR EXISTS (SELECT TENKH FROM LINK1.TN_CSDLPT.dbo.KHOA WHERE MAKH<>@MAKH AND TENKH=@TENKH))
				RAISERROR('Tên khoa muốn sửa trùng với khoa khác', 16, 2)
		END

GO
/****** Object:  StoredProcedure [dbo].[SP_KT_MONHOC_DATONTAI]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_KT_MONHOC_DATONTAI] @MAMH nchar(5),
  @TENMH nvarchar(50)
AS
	IF  exists(SELECT MAMH FROM  dbo.MONHOC WHERE MAMH = @MAMH)
   		RAISERROR ('Mã môn học đã tồn tại, vui lòng nhập mã khác', 16, 1)

	IF  exists(SELECT TENMH FROM  dbo.MONHOC WHERE TENMH = @TENMH)
		RAISERROR ('Tên môn học đã tồn tại, vui lòng nhập tên khác', 16, 2)


GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_DS_MONHOC]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LAY_DS_MONHOC] 
AS
--DECLARE @TENMH
	SELECT MAMH, TENMH = CONCAT(TRIM(MAMH), ' - ', TRIM(TENMH)) FROM MONHOC


GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_STT_CAUHOI_TIEPTHEO]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[SP_LAY_STT_CAUHOI_TIEPTHEO]
AS
 SELECT MAX(CAUHOI)+1 AS NEXTID FROM BODE
 
  

GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_TT_GIANGVIEN_LOGIN]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[SP_LAY_TT_GIANGVIEN_LOGIN]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM dbo.GIAOVIEN  WHERE MAGV = @TENUSER ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE 
   UID = (SELECT GROUPUID FROM SYS.SYSMEMBERS 
							WHERE MEMBERUID = (SELECT UID FROM sys.sysusers WHERE NAME=@TENUSER))

GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_TT_SV]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[SP_LAY_TT_SV]
@MASV NCHAR (8),
@MATKHAU NCHAR(25)
AS
 SELECT MASV, 
  HOTEN = HO+ ' '+ TEN FROM dbo.SINHVIEN  WHERE MASV = @MASV AND MATKHAU=@MATKHAU
  

GO
/****** Object:  StoredProcedure [dbo].[SP_SUA_CAUHOI]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SUA_CAUHOI]
	@idCauHoi int,
	@MAMH char(5),
	@TRINHDO char(1),
	@NOIDUNG ntext,
	@A ntext,
	@B ntext,
	@C ntext,
	@D ntext,
	@DAP_AN char(1),
	@MAGV char(8)
AS
	--IF  exists(SELECT CAUHOI FROM  dbo.BODE WHERE CAUHOI = @idCauHoi)
   	--	RAISERROR ('Mã câu hỏi đã tồn tại', 16, 1)
		-- có nên check thêm điều kiện cùng nội dung cùng mã môn mới là trùng câu?
	--ELSE 
	-- khi sửa thì xem có câu hỏi nào khác id trùng nội dung k
	IF  exists(SELECT NOIDUNG FROM  dbo.BODE WHERE 
	cast(NOIDUNG as nvarchar(max)) = cast(@NOIDUNG as nvarchar(max)) AND CAUHOI<>@idCauHoi) 
   		RAISERROR ('Câu hỏi đã tồn tại', 16, 1)
	 
		UPDATE dbo.BODE SET MAMH=@MAMH, TRINHDO=@TRINHDO, NOIDUNG=@NOIDUNG
		, A=@A, B=@B, C=@C, D=@D, DAP_AN=@DAP_AN, MAGV=@MAGV WHERE CAUHOI=@idCauHoi
	SELECT @idCauHoi AFFECTED_ID	-- lấy id vừa suwar 
 
 
  

GO
/****** Object:  StoredProcedure [dbo].[SP_SUA_GIAOVIEN]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_SUA_GIAOVIEN]
  @MAGV nchar(5),
  @HO nvarchar(50),
  @TEN nvarchar(10),
  @DIACHI nvarchar(50),
  @MAKH nchar(8)
AS
	--IF  exists(SELECT MAGV FROM  dbo.GIAOVIEN WHERE MAGV = @MAGV)
   	--	RAISERROR ('Mã giáo viên đã tồn tại, vui lòng nhập mã khác', 16, 1)
	--ELSE 
	ALTER TABLE dbo.GIAOVIEN  
	NOCHECK CONSTRAINT FK_GIAOVIEN_KHOA; 

		UPDATE dbo.GIAOVIEN SET MAGV=@MAGV, HO=@HO, TEN=@TEN, DIACHI=@DIACHI , MAKH=@MAKH WHERE MAGV=@MAGV
	SELECT @MAGV AFFECTED_ID	-- lấy id vừa sửa 

	ALTER TABLE dbo.GIAOVIEN 
	CHECK CONSTRAINT FK_GIAOVIEN_KHOA; 
	


GO
/****** Object:  StoredProcedure [dbo].[SP_SUA_GIAOVIEN_IGNORE_FK]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_SUA_GIAOVIEN_IGNORE_FK]
  @MAGV nchar(5),
  @HO nvarchar(50),
  @TEN nvarchar(10),
  @DIACHI nvarchar(50),
  @MAKH nchar(8)
AS
	-- phải ignore khóa ngoại vì khoa không nhân bản
	--IF  exists(SELECT MAGV FROM  dbo.GIAOVIEN WHERE MAGV = @MAGV)
   	--	RAISERROR ('Mã giáo viên đã tồn tại, vui lòng nhập mã khác', 16, 1)
	--ELSE 
	ALTER TABLE dbo.GIAOVIEN  
	NOCHECK CONSTRAINT FK_GIAOVIEN_KHOA; 

		UPDATE dbo.GIAOVIEN SET HO=@HO, TEN=@TEN, DIACHI=@DIACHI , MAKH=@MAKH WHERE MAGV=@MAGV
	SELECT @MAGV AFFECTED_ID	-- lấy id vừa sửa 

	ALTER TABLE dbo.GIAOVIEN 
	CHECK CONSTRAINT FK_GIAOVIEN_KHOA; 
	


GO
/****** Object:  StoredProcedure [dbo].[SP_SUA_KHOA]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_SUA_KHOA]
  @MAKH char(8),
  @TENKH nvarchar(50)
  --,
  --@MACS nchar(3) không cần mã cơ sở vì bên code cũng k cho sửa mã cơ sở mà
AS
	--IF  exists(SELECT @MAKH FROM  dbo.KHOA WHERE MAKH = @MAKH)
   	--	RAISERROR ('Mã khoa đã tồn tại, không thể phục hồi', 16, 1)
	--ELSE 
		UPDATE dbo.KHOA SET TENKH=@TENKH WHERE MAKH=@MAKH
	SELECT @MAKH AFFECTED_ID	-- lấy id vừa thêm 
	


GO
/****** Object:  StoredProcedure [dbo].[SP_SUA_MONHOC]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_SUA_MONHOC]
  @MAMH nchar(5),
  @TENMH nvarchar(50)
AS
	--IF  exists(SELECT MAMH FROM  dbo.MONHOC WHERE MAMH = @MAMH)
   	--	RAISERROR ('Mã môn học đã tồn tại, vui lòng nhập mã khác', 16, 1)
	--ELSE 
		UPDATE dbo.MONHOC  SET TENMH = @TENMH WHERE MAMH=@MAMH
		SELECT @MAMH AFFECTED_ID


GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_CAUHOI]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THEM_CAUHOI]
	@idCauHoi int,
	@MAMH char(5),
	@TRINHDO char(1),
	@NOIDUNG ntext,
	@A ntext,
	@B ntext,
	@C ntext,
	@D ntext,
	@DAP_AN char(1),
	@MAGV char(8)
AS
	IF  exists(SELECT CAUHOI FROM  dbo.BODE WHERE CAUHOI = @idCauHoi)
   		RAISERROR ('Mã câu hỏi đã tồn tại', 16, 1)
		-- có nên check thêm điều kiện cùng nội dung cùng mã môn mới là trùng câu?
	ELSE IF  exists(SELECT NOIDUNG FROM  dbo.BODE WHERE cast(NOIDUNG as nvarchar(max)) = cast(@NOIDUNG as nvarchar(max))) 
   		RAISERROR ('Câu hỏi đã tồn tại', 16, 2)
	ELSE 
		INSERT INTO dbo.BODE (CAUHOI, MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN, MAGV) 
						VALUES(@idCauHoi, @MAMH, @TRINHDO, @NOIDUNG, @A, @B, @C, @D, @DAP_AN, @MAGV)
	SELECT @idCauHoi AFFECTED_ID	-- lấy id vừa thêm 
 
 
  

GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_GIAOVIEN]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_THEM_GIAOVIEN]
  @MAGV nchar(5),
  @HO nvarchar(50),
  @TEN nvarchar(10),
  @DIACHI nvarchar(50),
  @MAKH nchar(8)
AS
	IF  exists(SELECT MAGV FROM  dbo.GIAOVIEN WHERE MAGV = @MAGV)
   		RAISERROR ('Mã giáo viên đã tồn tại, vui lòng nhập mã khác', 16, 1)
	ELSE 
		INSERT INTO dbo.GIAOVIEN (MAGV, HO, TEN, DIACHI, MAKH) VALUES(@MAGV, @HO, @TEN, @DIACHI, @MAKH)
	SELECT @MAGV AFFECTED_ID	-- lấy id vừa thêm 
	


GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_KHOA]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_THEM_KHOA]
  @MAKH char(8),
  @TENKH nvarchar(50),
  @MACS nchar(3)
AS
	IF  exists(SELECT @MAKH FROM  dbo.KHOA WHERE MAKH = @MAKH)
   		RAISERROR ('Mã khoa đã tồn tại, không thể phục hồi', 16, 1)
	ELSE 
		INSERT INTO dbo.KHOA (MAKH, TENKH, MACS) VALUES(@MAKH, @TENKH, @MACS)
	SELECT @MAKH AFFECTED_ID	-- lấy id vừa thêm 
	


GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_MONHOC]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_THEM_MONHOC]
  @MAMH nchar(5),
  @TENMH nvarchar(50)
AS
	IF  exists(SELECT MAMH FROM  dbo.MONHOC WHERE MAMH = @MAMH)
   		RAISERROR ('Mã môn học đã tồn tại, vui lòng nhập mã khác', 16, 1)
	ELSE 
		INSERT INTO dbo.MONHOC (MAMH, TENMH) VALUES(@MAMH, @TENMH)
	SELECT @MAMH AFFECTED_ID	-- lấy id vừa thêm 
	


GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_CAUHOI]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_XOA_CAUHOI]
  @idCauHoi int
AS
		DELETE FROM dbo.BODE WHERE CAUHOI=@idCauHoi
	


GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_GIAOVIEN]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_XOA_GIAOVIEN]
  @MAGV char(8)
AS
		DELETE FROM dbo.GIAOVIEN WHERE MAGV=@MAGV
	


GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_KHOA]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_XOA_KHOA]
  @MAKH char(8)
AS
	--IF  exists(SELECT @MAKH FROM  dbo.KHOA WHERE MAKH = @MAKH)
   	--	RAISERROR ('Mã khoa đã tồn tại, không thể phục hồi', 16, 1)
	--ELSE 
		DELETE FROM KHOA WHERE MAKH=@MAKH
	
	


GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_MONHOC]    Script Date: 22/03/2022 10:37:07 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_XOA_MONHOC]
  @MAMH nchar(5)
AS
	--IF  exists(SELECT MAMH FROM  dbo.MONHOC WHERE MAMH = @MAMH)
   	--	RAISERROR ('Mã môn học đã tồn tại, vui lòng nhập mã khác', 16, 1)
	--ELSE 
		DELETE FROM dbo.MONHOC WHERE MAMH=@MAMH
	


GO
