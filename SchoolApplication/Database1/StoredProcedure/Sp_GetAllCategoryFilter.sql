-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_GetAllCategoryFilter
	-- Add the parameters for the stored procedure here
	@Id INT,
	@CategoryName VARCHAR(200)
AS
BEGIN
	

    -- Insert statements for procedure here
	SELECT @CategoryName FROM Category WHERE Id=@Id
END
GO

	
