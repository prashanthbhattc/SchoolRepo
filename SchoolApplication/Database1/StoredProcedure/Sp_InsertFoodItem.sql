
Create PROCEDURE [dbo].[Sp_InsertFoodItem]
	
	@FoodName varchar(200),
	@CategoryId int,
	@Price money

AS
BEGIN
		  
insert into FoodItem(FoodName,CategoryId,Price) values(@FoodName,@CategoryId,@Price)

END
