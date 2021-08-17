CREATE TABLE [dbo].[evaluations]
(
	[evaluation_id] INT NOT NULL identity PRIMARY KEY,
	prestation_id int not null,
	utilisateur_id int not null,
	note_utilisateur int,
	commentaire_utilisateur text,
	prestataire_id int not null,
	note_prestataire int,
	commentaire_prestataire text,
	alerte bit default(0),
	constraint FK_evaluations_prestation foreign key(prestation_id) references prestations(prestation_id),
	constraint FK_evaluations_utilisateur foreign key(utilisateur_id) references utilisateurs(utilisateur_id),
	constraint FK_evaluations_prestataire foreign key(prestataire_id) references utilisateurs(utilisateur_id),
)
