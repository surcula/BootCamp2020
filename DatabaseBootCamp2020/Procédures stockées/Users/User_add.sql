CREATE PROCEDURE [dbo].[User_add]
	@Email NVARCHAR(230) NOT NULL, 
    @Password nvarchar(20) NOT NULL, 
    @LastName NVARCHAR(50) NOT NULL, 
    @FirstName NVARCHAR(50) NOT NULL,
    @BirthDate DateTime2(7) NOT NULL,
    @Address NVARCHAR(250) NOT NULL, 
    @Cp INT NOT NULL, 
    @Land NVARCHAR(50) NOT NULL, 
    @Phone INT NOT NULL 
AS
	INSERT INTO Users ([Email], [Passwd],[LastName],[FirstName],[BirthDate],[Address],[Cp],[Land],[Phone]) VALUES (@Email,salade(@Password),@LastName,@FirstName,@BirthDate,@Address,@Cp,@Land,@Phone)
RETURN 0
