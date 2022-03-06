CREATE PROCEDURE [dbo].[NoAccounts]
AS
BEGIN
SELECT * 
FROM Users 
LEFT JOIN Accounts 
	ON UserId = Users.id 
WHERE AccountNumber IS NULL
END