-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_InsertFoodItem
	-- Add the parameters for the stored procedure here
	@FoodName varchar(200),
	@CategoryId int

AS
BEGIN
		    -- Insert statements for procedure here
insert into FoodItem(FoodName,CategoryId) values(@FoodName,@CategoryId)

END
GO
