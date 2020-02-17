-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_DeleteCategory
	-- Add the parameters for the stored procedure here
	@Id INT
AS
BEGIN
	
	DELETE FROM Category WHERE Id=@Id
END
GO
