CREATE PROCEDURE [dbo].[uspGetUserById]
	@Id varchar(128)
	
AS
BEGIN
Set nocount on;

	SELECT Id, FirstName, LastName, EmailAddress, CreatedDate
	FROM [dbo].[Users]
	WHERE Id = @Id
	END
