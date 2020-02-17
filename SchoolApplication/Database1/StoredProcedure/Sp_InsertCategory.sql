
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sp_InsertCategory
	-- Add the parameters for the stored procedure here
	@CategoryName VARCHAR(200),
	@Discount INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Category
           (NAME
           ,Discount)
     VALUES
           (@CategoryName,
		   @Discount)


END
GO



