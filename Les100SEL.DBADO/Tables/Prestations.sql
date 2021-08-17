CREATE TABLE [dbo].[prestations]
(
	[prestation_id] INT NOT NULL identity PRIMARY KEY,
	prestataire_id int not null,
	nb_grains int not null,
	debut datetime2,
	duree time,
	alerte bit default(0),
	constraint FK_prestations_prestataire foreign key (prestataire_id) references prestataires(prestataire_id)
)
