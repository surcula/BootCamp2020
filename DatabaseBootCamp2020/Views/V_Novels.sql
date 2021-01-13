CREATE VIEW [RegChacha].[V_Novels]
	AS SELECT 
		[Novels].Id,
		[Novels].Title,
		[Novels].SerieId,
		[Series].Nom as [Serie],
		[Novels].Authors,
		[Novels].SerialNumber,
		[Novels].Price,
		[Novels].Informations,
		[Novels].Langue,
		[Novels].Dimension,
		[Novels].Published,
		[Novels].[Type]as [TypeId],
		[Types].[type] as [Type]
	FROM [Novels]
	Inner join [Series] on [Novels].[SerieId] = [Series].[Id]
	Inner join [Types] on [Novels].[Type] = [Types].[Id]
