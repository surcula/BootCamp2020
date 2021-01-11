CREATE PROCEDURE [RegChacha].[Novels_update] 
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
	INSERT INTO [Novels](title, SerieId, Authors, SerialNumber, Price, Informations, Langue, Dimension, Published,[Type]) VALUES (@Title,@Series, @Author,  @SerialNumber, @Price, @Informations, @Langue, @Dimension, @Published,@type)
RETURN 0
