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
EXEC [SP_Book_Insert] 
	@title = N'Belladonna', 
	@releaseDate = '2023-05-11', 
	@author = N'Adalyn Grace', 
	@isbn = '9782378762896'

EXEC [SP_Book_Insert] 
	@title = N'Foxglove', 
	@releaseDate = '2024-01-03', 
	@author = N'Adalyn Grace', 
	@isbn = '9782378764043'

EXEC [SP_Book_Insert] 
	@title = N'Holly', 
	@releaseDate = '2025-11-27', 
	@author = N'Adalyn Grace', 
	@isbn = '9782378768003'

EXEC [SP_Book_Insert] 
	@title = N'Wisteria', 
	@releaseDate = '2025-03-27', 
	@author = N'Adalyn Grace', 
	@isbn = '9782378766641'

EXEC [SP_Book_Insert] 
	@title = N'N''invite pas la forêt à entrer', 
	@releaseDate = '2025-08-28', 
	@author = N'Drews C.G.', 
	@isbn = '9782378767396'

EXEC [SP_Book_Insert] 
	@title = N'Phobos Origine', 
	@releaseDate = '2016-06-02', 
	@author = N'Victor Dixen', 
	@isbn = '9782221193204'

EXEC [SP_Book_Insert] 
	@title = N'Phobos Tome 1', 
	@releaseDate = '2015-06-11', 
	@author = N'Victor Dixen', 
	@isbn = '9782221146637'

EXEC [SP_Book_Insert] 
	@title = N'Phobos Tome 2', 
	@releaseDate = '2015-11-19', 
	@author = N'Victor Dixen', 
	@isbn = '9782221146644'

EXEC [SP_Book_Insert] 
	@title = N'Phobos Tome 3', 
	@releaseDate = '2016-11-24', 
	@author = N'Victor Dixen', 
	@isbn = '9782221195734'

EXEC [SP_Book_Insert] 
	@title = N'Phobos Tome 4', 
	@releaseDate = '2017-11-23', 
	@author = N'Victor Dixen', 
	@isbn = '9782221202197'
GO
