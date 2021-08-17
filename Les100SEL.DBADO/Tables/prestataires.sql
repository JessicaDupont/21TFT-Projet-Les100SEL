CREATE TABLE [dbo].[prestataires]
(
	prestataire_id int not null identity primary key,
	proposition_id INT NOT NULL,
	demande_id INT NOT NULL,
	[message] text,
	alerte bit default(0),
	constraint FK_prestataire_proposition foreign key(proposition_id) references propositions(proposition_id),
	constraint FK_prestataire_demande foreign key(demande_id) references demandes(demande_id)
)
