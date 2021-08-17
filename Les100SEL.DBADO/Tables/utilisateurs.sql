CREATE TABLE [dbo].[utilisateurs]
(
	[utilisateur_id] INT NOT NULL identity PRIMARY KEY,
	nom nvarchar(100) not null,
	ddn datetime2 not null,
	alerte bit default(0)
)
