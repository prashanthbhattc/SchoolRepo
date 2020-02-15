
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_InsertCategory
	-- Add the parameters for the stored procedure here
	@CategoryName varchar(200)
AS
BEGIN
	insert into Category values(@CategoryName)
END

