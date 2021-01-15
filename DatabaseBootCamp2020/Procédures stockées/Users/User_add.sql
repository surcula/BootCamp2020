CREATE PROCEDURE [RegChacha].[User_add]
	@Email NVARCHAR(230) , 
    @Password nvarchar(20) , 
    @LastName NVARCHAR(50), 
    @FirstName NVARCHAR(50) ,
    @BirthDate DateTime2(7) ,
    @Address NVARCHAR(250) , 
    @Cp INT , 
    @Land NVARCHAR(50), 
    @Phone nvarchar(12) 
AS
	INSERT INTO Users ([Email], [Passwd],[LastName],[FirstName],[BirthDate],[Address],[Cp],[Land],[Phone]) VALUES (
    @Email,dbo.salade(@Password),@LastName,@FirstName,@BirthDate,@Address,@Cp,@Land,@Phone)
RETURN 0
