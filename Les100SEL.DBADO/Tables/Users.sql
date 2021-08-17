CREATE TABLE [dbo].[users]
(
	[user_id] INT NOT NULL identity PRIMARY KEY,
	mode_connexion int not null,
	[login] nvarchar(350) unique,
	mdp binary,
	[role] int not null default(1),
	inscription datetime2 default(getdate()),
	connexion datetime2 not null,
	commentaire_mod text,
	fin_ban datetime2,
	utilisateur_id int not null,
	constraint FK_users_utilisateur foreign key (utilisateur_id) references utilisateurs(utilisateur_id)
)
