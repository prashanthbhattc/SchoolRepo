-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_GetAllCategoryFilter
	-- Add the parameters for the stored procedure here
	@Id int,
	@CategoryName varchar(200)
AS
BEGIN
	

    -- Insert statements for procedure here
	SELECT @CategoryName from Category where Id=@Id
END
GO

	
