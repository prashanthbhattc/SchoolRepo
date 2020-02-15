-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create  PROCEDURE Sp_UpdateCategory
	-- Add the parameters for the stored procedure here
	@Id int,
	@Name varchar(200)
AS
BEGIN
	
    -- Insert statements for procedure here
	Update Category set [Name]=@Name where Id=@Id
END
