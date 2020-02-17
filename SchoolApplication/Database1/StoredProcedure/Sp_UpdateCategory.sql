-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create  PROCEDURE Sp_UpdateCategory
	-- Add the parameters for the stored procedure here
	@Id INT,
	@Name VARCHAR(200),
	@Discount INT
AS
BEGIN
	
    -- Insert statements for procedure here
	UPDATE Category SET [Name]=@Name, Discount=@Discount WHERE Id=@Id
END
GO
