
create PROCEDURE [dbo].[Sp_UpdateFoodItem]
	
	@FoodId int,
	@FoodName Varchar(200),
	@price money
AS
BEGIN
	

   
	Update FoodItem set FoodName=@FoodName,price=@price where Id=@FoodId
END
