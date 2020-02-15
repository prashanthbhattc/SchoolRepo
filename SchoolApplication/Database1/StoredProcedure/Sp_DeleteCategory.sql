-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_DeleteCategory
	-- Add the parameters for the stored procedure here
	@Id int
AS
BEGIN
	
	delete from Category where Id=@Id
END
GO
