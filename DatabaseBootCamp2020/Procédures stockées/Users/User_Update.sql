CREATE PROCEDURE [RegChacha].[User_Update]
    @Id int ,
	@Email NVARCHAR(230) ,
    @LastName NVARCHAR(50),
    @FirstName NVARCHAR(50),
    @BirthDate DateTime2(7) ,
    @Address NVARCHAR(250) ,
    @Cp INT ,
    @Land NVARCHAR(50) ,
    @Phone nvarchar(12) 
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
