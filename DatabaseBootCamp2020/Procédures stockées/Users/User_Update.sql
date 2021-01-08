CREATE PROCEDURE [dbo].[User_Update]
    @Id int NOT NULL,
	@Email NVARCHAR(230) NOT NULL, 
    @LastName NVARCHAR(50) NOT NULL, 
    @FirstName NVARCHAR(50) NOT NULL,
    @BirthDate DateTime2(7) NOT NULL,
    @Address NVARCHAR(250) NOT NULL, 
    @Cp INT NOT NULL, 
    @Land NVARCHAR(50) NOT NULL, 
    @Phone INT NOT NULL 
AS
	UPDATE Users
    set [Email]= @Email ,
        [LastName]=@LastName,
        [FirstName]=@FirstName,
        [BirthDate]=@BirthDate,
        [Address]=@Address,
        [Cp]=@Cp,
        [Land]=@Land,
        [Phone]=@Phone 
    where [Id]=@Id
RETURN 0
