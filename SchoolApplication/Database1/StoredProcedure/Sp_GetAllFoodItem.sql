
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_GetAllFoodItem
	

AS
BEGIN
	
 SELECT 
 f.Id,
 f.FoodName,
 f.CategoryId,
 c.[Name] as categoryname 
 from FoodItem f 
 JOIN Category c on f.CategoryId=c.Id

END
GO
