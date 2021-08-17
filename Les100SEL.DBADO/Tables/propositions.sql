CREATE TABLE [dbo].[propositions]
(
	[proposition_id] INT NOT NULL identity PRIMARY KEY,
	categorie_id int not null,
	utilisateur_id int not null,
	profil_propose text,
	nb_grains int not null,
	alerte bit default(0),
	constraint FK_propositions_categorie foreign key(categorie_id) references categories(categorie_id),
	constraint FK_propositions_utilisateur foreign key(utilisateur_id) references utilisateurs(utilisateur_id)
)
