
create PROCEDURE [dbo].[Sp_GetAllFoodItem]
	

AS
BEGIN
	
 SELECT 
 f.Id,
 f.FoodName,
 f.CategoryId,
 f.price,
 
 c.[Name] as categoryname 
 from FoodItem f 
 JOIN Category c on f.CategoryId=c.Id

END
