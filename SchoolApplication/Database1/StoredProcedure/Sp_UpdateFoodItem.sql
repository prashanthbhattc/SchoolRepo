-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_UpdateFoodItem
	-- Add the parameters for the stored procedure here
	@FoodId int,
	@FoodName Varchar(200)
AS
BEGIN
	

    -- Insert statements for procedure here
	Update FoodItem set FoodName=@FoodName where Id=@FoodId
END
GO

