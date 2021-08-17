CREATE TABLE [dbo].[utilisateur_regions]
(
	utilisateur_id int not null,
	region_id int not null,
	frais_deplacement money default(0),
	constraint PK_utilisateurregions primary key(utilisateur_id, region_id),
	constraint FK_utilisateurregions_utilisateur foreign key(utilisateur_id) references utilisateurs(utilisateur_id),
	constraint FK_utilisateurregions_region foreign key(region_id) references regions(region_id)
)
