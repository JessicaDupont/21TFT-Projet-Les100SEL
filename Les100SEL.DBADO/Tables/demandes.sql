CREATE TABLE [dbo].[demandes]
(
	[demande_id] INT NOT NULL identity PRIMARY KEY,
	categorie_id int not null,
	utilisateur_id int not null,
	region_id int not null,
	adresse nvarchar(100),
	[description] text,
	nb_grains int not null,
	alerte bit default(0),
	constraint FK_demandes_categorie foreign key(categorie_id) references categories(categorie_id),
	constraint FK_demandes_utilisateur foreign key(utilisateur_id) references utilisateurs(utilisateur_id),
	constraint FK_demandes_region foreign key(region_id) references regions(region_id)
)
