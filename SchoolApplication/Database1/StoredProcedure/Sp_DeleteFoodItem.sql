-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_DeleteFoodItem
	-- Add the parameters for the stored procedure here
	@FoodId int
AS
BEGIN
	

    -- Insert statements for procedure here
	delete from FoodItem where Id=@FoodId
END
GO

