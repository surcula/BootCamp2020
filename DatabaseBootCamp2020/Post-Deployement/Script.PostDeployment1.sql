/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


exec [RegChacha].User_add @Email ='david.gaillet@live.fr',@Password='test1234',@LastName='Gaillet',@FirstName='David',@BirthDate='1989-04-10',@Address='Rue Baudouin 1er 131',@Cp='6180',@Land='Belgique',@Phone=0497845642;
exec [RegChacha].User_add @Email ='tal_quilla@live.fr',@Password='test1234',@LastName='Gantois',@FirstName='Roxane',@BirthDate='1989-07-19',@Address='Rue Baudouin 1er 131',@Cp='6180',@Land='Belgique',@Phone=0497845642;
exec [RegChacha].User_add @Email ='Chacha@land.be',@Password='test1234',@LastName='Gaillet',@FirstName='David',@BirthDate='1989-01-10',@Address='Rue Baudouin 1er 131',@Cp='6180',@Land='Belgique',@Phone=0497845642;
exec [RegChacha].User_add @Email ='Nymeria@dog.Be',@Password='test1234',@LastName='Gaillet',@FirstName='David',@BirthDate='1989-01-27',@Address='Rue Baudouin 1er 131',@Cp='6180',@Land='Belgique',@Phone=0497845642;

exec [RegChacha].Series_Add @nom='One piece';
exec [RegChacha].Series_Add @nom='Star Wars';
exec [RegChacha].Series_Add @nom='Tintin';
exec [RegChacha].Series_Add @nom='Spirou';
exec [RegChacha].Series_Add @nom='Les nombrils';
exec [RegChacha].Series_Add @nom='Lanfeust';
exec [RegChacha].Series_Add @nom='Lanfeust des étoiles';
exec [RegChacha].Series_Add @nom='Lanfeust Odyssé';
exec [RegChacha].Series_Add @nom='Assassination Classroom';
exec [RegChacha].Series_Add @nom='Sword Art Online';
exec [RegChacha].Series_Add @nom='Autres';

exec [RegChacha].Type_Add @type='Mangas'
exec [RegChacha].Type_Add @type='Bande Dessinée'
exec [RegChacha].Type_Add @type='Romans'
exec [RegChacha].Type_Add @type='Autres'


exec [RegChacha].Novels_add @Title='Tome 1', @Series=1, @Authors = 'Ochida',  @SerialNumber = '#75868', @Price=6.99, @Informations='', @Langue='Fr', @Dimension='10 x 10 x 10', @Published='2000-01-01' ,@type = 1
exec [RegChacha].Novels_add @Title='Tome 2', @Series=1, @Authors = 'Ochida',  @SerialNumber = '#75869', @Price=6.99, @Informations='', @Langue='Fr', @Dimension='10 x 10 x 10', @Published='2000-03-01' ,@type = 1
exec [RegChacha].Novels_add @Title='Tome 3', @Series=1, @Authors = 'Ochida',  @SerialNumber = '#75870', @Price=6.99, @Informations='', @Langue='Fr', @Dimension='10 x 10 x 10', @Published='2000-05-01' ,@type = 1
exec [RegChacha].Novels_add @Title='Tom 1 - Pour qui tu te prends?', @Series=5, @Authors = 'Dubuc',  @SerialNumber = '#75868', @Price=9.50, @Informations='', @Langue='Fr', @Dimension='10 x 10 x 10', @Published='2006-01-01',@type = 2
exec [RegChacha].Novels_add @Title='Ahsoka - ', @Series=2, @Authors = 'Emily Kate Johnston',  @SerialNumber = '#345786', @Price=9.90, @Informations='', @Langue='Fr', @Dimension='10 x 10 x 10', @Published='2020-07-02' ,@type = 3
exec [RegChacha].Novels_add @Title='Tome 16 - Objectif Lune', @Series=3, @Authors = 'Hergé',  @SerialNumber = '#213457', @Price=11.50, @Informations='', @Langue='Fr', @Dimension= '22.5 x 1 x 30.5 cm', @Published='1993-05-04' ,@type = 3


