CREATE PROCEDURE [RegChacha].[Novels_update] 
    @Id int,
    @Title NVARCHAR(50) ,
    @Series int,
    @Author NVARCHAR(50) ,
    @SerialNumber NVARCHAR(50), 
    @Price FLOAT , 
    @Informations NVARCHAR(1000) ,
    @Langue NVARCHAR(50) , 
    @Dimension NVARCHAR(20) ,
    @Published DATETIME2,
    @type int
AS
begin
Update [Novels]
    set title=@Title, 
    SerieId=@Series, 
    Authors=@Author, 
    SerialNumber=@SerialNumber, 
    Price=@Price, 
    Informations=@Informations, 
    Langue=@Langue, 
    Dimension=@Dimension, 
    Published=@Published,
    [Type]=@type
where Id=@Id
end
	