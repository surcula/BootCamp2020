CREATE FUNCTION [dbo].[Salade](@mdp nvarchar(20))

	
RETURNS VARBINARY(64)
AS
BEGIN
	RETURN Hashbytes('SHA2_512',Presalt()+@mdp+PostSalt())
END
