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
/*_____*****_____UTILISATEURS_____*****_____*/
insert into utilisateurs(nom, ddn) values('Jessica', getdate());
insert into utilisateurs(nom, ddn) values('Maud', getdate());
insert into utilisateurs(nom, ddn) values('Isabel', getdate());
insert into utilisateurs(nom, ddn) values('Corentin', getdate());
insert into utilisateurs(nom, ddn) values('Aveline', getdate());
insert into utilisateurs(nom, ddn) values('nbvcxw5', getdate());
insert into utilisateurs(nom, ddn) values('rgnthj6', getdate());
insert into utilisateurs(nom, ddn) values('oknbvd7', getdate());
insert into utilisateurs(nom, ddn) values('scderg8', getdate());
insert into utilisateurs(nom, ddn) values('uygdza9', getdate());
/*_____*****_____USERSCONNECT_____*****_____*/
/*_____*****_____REGIONS_____*****_____*/
insert into regions(code_postal, ville) values (1000, 'Bruxelles');
insert into regions(code_postal, ville) values (4000, 'Liège');
insert into regions(code_postal, ville) values (4100, 'Boncelles');
insert into regions(code_postal, ville) values (4300, 'Waremme');
insert into regions(code_postal, ville) values (4500, 'Huy');/*5*/
insert into regions(code_postal, ville) values (4520, 'Wanze');
insert into regions(code_postal, ville) values (4530, 'Villers-le-Bouillet');
insert into regions(code_postal, ville) values (4540, 'Amay');
insert into regions(code_postal, ville) values (4550, 'Nandrin');
insert into regions(code_postal, ville) values (4560, 'Clavier');
insert into regions(code_postal, ville) values (4570, 'Marchin');/*11*/
insert into regions(code_postal, ville) values (4577, 'Modave');
insert into regions(code_postal, ville) values (4920, 'Aywaille');
insert into regions(code_postal, ville) values (5000, 'Namur');
insert into regions(code_postal, ville) values (5300, 'Andenne');
insert into regions(code_postal, ville) values (5590, 'Ciney');
insert into regions(code_postal, ville) values (6040, 'Gosselies');/*17*/
insert into regions(code_postal, ville) values (6000, 'Charleroi');
/*_____*****_____UTILISATEUR_REGIONS_____*****_____*/
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 2);
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 3);
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 5);
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 6);
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 7);
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 8);
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 9);
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 10);
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 11);
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 12);
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 14);
insert into utilisateur_regions(utilisateur_id, region_id) values (1, 15);
insert into utilisateur_regions(utilisateur_id, region_id) values (2, 4);
insert into utilisateur_regions(utilisateur_id, region_id) values (2, 5);
insert into utilisateur_regions(utilisateur_id, region_id) values (2, 7);
insert into utilisateur_regions(utilisateur_id, region_id) values (2, 14);
insert into utilisateur_regions(utilisateur_id, region_id) values (2, 15);
insert into utilisateur_regions(utilisateur_id, region_id) values (2, 16);
insert into utilisateur_regions(utilisateur_id, region_id) values (3, 1);
insert into utilisateur_regions(utilisateur_id, region_id) values (3, 4);
insert into utilisateur_regions(utilisateur_id, region_id) values (3, 14);
insert into utilisateur_regions(utilisateur_id, region_id) values (4, 17);
insert into utilisateur_regions(utilisateur_id, region_id) values (4, 18);
insert into utilisateur_regions(utilisateur_id, region_id) values (5, 2);
/*_____*****_____CATEGORIES_____*****_____https://sel-services.be/indexoffers.asp*/
set identity_insert categories on;
insert into categories(categorie_id, nom) values(1, 'Aide administratrive, sociale et juridique');
insert into categories(categorie_id, categorie_parent, nom) values(101, 1, 'Vie sociale: écoute - conseil - accompagnement');
insert into categories(categorie_id, categorie_parent, nom) values(102, 1, 'Aide administrative');
insert into categories(categorie_id, categorie_parent, nom) values(103, 1, 'Aide juridique');
insert into categories(categorie_id, categorie_parent, nom) values(104, 1, 'Informations');
insert into categories(categorie_id, categorie_parent, nom) values(105, 1, 'Biographie');
insert into categories(categorie_id, categorie_parent, nom) values(106, 1, 'Ecriture - relecture');
insert into categories(categorie_id, categorie_parent, nom) values(107, 1, 'Aide sociale');
insert into categories(categorie_id, nom) values(2, 'Maison et Habitat : réparation électro, plomberie et électricité (petites réparations), établir des plans');
insert into categories(categorie_id, categorie_parent, nom) values(202, 2, 'Plomberie');
insert into categories(categorie_id, categorie_parent, nom) values(203, 2, 'Electricité');
insert into categories(categorie_id, categorie_parent, nom) values(204, 2, 'Vitres');
insert into categories(categorie_id, categorie_parent, nom) values(205, 2, 'Bois');
insert into categories(categorie_id, categorie_parent, nom) values(206, 2, 'Petits travaux');
insert into categories(categorie_id, categorie_parent, nom) values(207, 2, 'Aménagement intérieur et décoration');
insert into categories(categorie_id, categorie_parent, nom) values(208, 2, 'Découverte de la nature, plante, fleurs et jardins');
insert into categories(categorie_id, categorie_parent, nom) values(209, 2, 'Déménagement');
insert into categories(categorie_id, categorie_parent, nom) values(210, 2, 'Home-sitting');
insert into categories(categorie_id, categorie_parent, nom) values(211, 2, 'Chantier');
insert into categories(categorie_id, categorie_parent, nom) values(212, 2, 'Pierre');
insert into categories(categorie_id, categorie_parent, nom) values(213, 2, 'Textile');
insert into categories(categorie_id, categorie_parent, nom) values(214, 2, 'Electro-ménager');
insert into categories(categorie_id, categorie_parent, nom) values(215, 2, 'Chauffage');
insert into categories(categorie_id, categorie_parent, nom) values(216, 2, 'Jardinage');
insert into categories(categorie_id, nom) values(3, 'Quotidien');
insert into categories(categorie_id, categorie_parent, nom) values(301, 3, 'Informatique');
insert into categories(categorie_id, categorie_parent, nom) values(302, 3, 'Baby-sitting');
insert into categories(categorie_id, categorie_parent, nom) values(303, 3, 'Hi-fi, autoradio, électroménager');
insert into categories(categorie_id, categorie_parent, nom) values(304, 3, 'Travaux ménagers');
insert into categories(categorie_id, categorie_parent, nom) values(305, 3, 'Couture');
insert into categories(categorie_id, categorie_parent, nom) values(306, 3, 'Animaux');
insert into categories(categorie_id, categorie_parent, nom) values(307, 3, 'Courses, transports');
insert into categories(categorie_id, categorie_parent, nom) values(309, 3, 'Eco-conseils');
insert into categories(categorie_id, categorie_parent, nom) values(311, 3, 'Automobile');
insert into categories(categorie_id, categorie_parent, nom) values(312, 3, 'Aide aux personnes');
insert into categories(categorie_id, categorie_parent, nom) values(313, 3, 'Aide ménagère');
insert into categories(categorie_id, categorie_parent, nom) values(314, 3, 'Aide à l''organisation');
insert into categories(categorie_id, categorie_parent, nom) values(315, 3, 'Arroser les plantes des personnes en déplacement');
insert into categories(categorie_id, categorie_parent, nom) values(316, 3, 'Accompagnement pour promenade');
insert into categories(categorie_id, nom) values(4, 'Cours et langues');
insert into categories(categorie_id, categorie_parent, nom) values(401, 4, 'Langues : Français');
insert into categories(categorie_id, categorie_parent, nom) values(402, 4, 'Langues : Néerlandais');
insert into categories(categorie_id, categorie_parent, nom) values(403, 4, 'Langues : Cours');
insert into categories(categorie_id, categorie_parent, nom) values(404, 4, 'Langues : Conversations');
insert into categories(categorie_id, categorie_parent, nom) values(405, 4, 'Aide scolaire de niveau primaire');
insert into categories(categorie_id, categorie_parent, nom) values(406, 4, 'Aide scolaire de niveau secondaire');
insert into categories(categorie_id, categorie_parent, nom) values(407, 4, 'Aide scolaire de niveau supérieur');
insert into categories(categorie_id, categorie_parent, nom) values(408, 4, 'Coach-orientation pour étudiants');
insert into categories(categorie_id, categorie_parent, nom) values(409, 4, 'Informatique');
insert into categories(categorie_id, categorie_parent, nom) values(410, 4, 'Musique et chant');
insert into categories(categorie_id, categorie_parent, nom) values(411, 4, 'Cuisine et alimentation');
insert into categories(categorie_id, categorie_parent, nom) values(412, 4, 'Video');
insert into categories(categorie_id, categorie_parent, nom) values(413, 4, 'Jardinage');
insert into categories(categorie_id, categorie_parent, nom) values(414, 4, 'Mise en page et correction de travaux de fin d''études');
insert into categories(categorie_id, categorie_parent, nom) values(415, 4, 'Usage de soi');
insert into categories(categorie_id, categorie_parent, nom) values(416, 4, 'Concours administratifs');
insert into categories(categorie_id, categorie_parent, nom) values(417, 4, 'Traduction');
insert into categories(categorie_id, categorie_parent, nom) values(418, 4, 'Langues : Italien');
insert into categories(categorie_id, categorie_parent, nom) values(419, 4, 'Langues : Anglais');
insert into categories(categorie_id, nom) values(5, 'Loisirs');
insert into categories(categorie_id, categorie_parent, nom) values(501, 5, 'Fêtes, événements et animations');
insert into categories(categorie_id, categorie_parent, nom) values(502, 5, 'Artisanat');
insert into categories(categorie_id, categorie_parent, nom) values(503, 5, 'Art et littérature');
insert into categories(categorie_id, categorie_parent, nom) values(504, 5, 'Théâtre et danse');
insert into categories(categorie_id, categorie_parent, nom) values(505, 5, 'Photo et vidéo');
insert into categories(categorie_id, categorie_parent, nom) values(506, 5, 'Musique et chant');
insert into categories(categorie_id, categorie_parent, nom) values(507, 5, 'Sports et activités en plein air');
insert into categories(categorie_id, categorie_parent, nom) values(508, 5, 'Illustration, dessin, peinture, sculpture et graphisme');
insert into categories(categorie_id, categorie_parent, nom) values(509, 5, 'Visites');
insert into categories(categorie_id, categorie_parent, nom) values(510, 5, 'Vacances et voyages');
insert into categories(categorie_id, categorie_parent, nom) values(511, 5, 'Jeux');
insert into categories(categorie_id, nom) values(6, 'Corps, âme et esprit');
insert into categories(categorie_id, categorie_parent, nom) values(601, 6, 'Soins du corps');
insert into categories(categorie_id, categorie_parent, nom) values(603, 6, 'Soins de l''esprit');
insert into categories(categorie_id, categorie_parent, nom) values(605, 6, 'Look et style');
insert into categories(categorie_id, nom) values(7, 'Gastronomie et alimentation');
insert into categories(categorie_id, categorie_parent, nom) values(701, 7, 'Cuisine');
insert into categories(categorie_id, categorie_parent, nom) values(702, 7, 'Spécialités salées');
insert into categories(categorie_id, categorie_parent, nom) values(703, 7, 'Spécialités sucrées');
insert into categories(categorie_id, categorie_parent, nom) values(704, 7, 'Tables d''hôte');
insert into categories(categorie_id, categorie_parent, nom) values(705, 7, 'Conseils alimentaires');
insert into categories(categorie_id, categorie_parent, nom) values(706, 7, 'Vins');
insert into categories(categorie_id, nom) values(8, 'Relations publiques');
insert into categories(categorie_id, categorie_parent, nom) values(801, 8, 'Relations publiques, contact presse');
insert into categories(categorie_id, nom) values(9, 'Preterie - Donnerie');
set identity_insert categories off;
/*_____*****_____PROPOSITIONS_____*****_____*/
insert into propositions(titre, categorie_id, utilisateur_id, nb_grains) values ('Apprendre la Harpe', 410,5,2);
insert into propositions(titre, categorie_id, utilisateur_id, nb_grains) values ('Ecriture de lettre', 106,1,1);
insert into propositions(titre, categorie_id, utilisateur_id, nb_grains) values ('Relever votre boite aux lettres', 210,1,2);
insert into propositions(titre, categorie_id, utilisateur_id, nb_grains) values ('Coudre vos tentures', 213,1,2);
insert into propositions(titre, categorie_id, utilisateur_id, nb_grains) values ('Installer votre ordinateur', 301,1,1);
insert into propositions(titre, categorie_id, utilisateur_id, nb_grains) values ('Petites réparations', 305,1,1);
insert into propositions(titre, categorie_id, utilisateur_id, nb_grains) values ('Promenade à partie de la place', 316,1,1);
insert into propositions(titre, categorie_id, utilisateur_id, nb_grains) values ('Sciences et mathématiques', 405,1,1);
insert into propositions(titre, categorie_id, utilisateur_id, nb_grains) values ('Word, Excel et PowerPoint', 409,1,2);
insert into propositions(titre, categorie_id, utilisateur_id, nb_grains) values ('Affiche pour un évènement privé', 508,2,5);
/*_____*****_____DEMANDES_____*****_____*/
insert into demandes(titre, categorie_id, utilisateur_id, nb_grains, region_id) values ('Jouer de la Harpe', 410,1,2,2);
insert into demandes(titre, categorie_id, utilisateur_id, nb_grains, region_id) values ('Apprendre l''anglais B2', 419,1,1,11);
/*_____*****_____PRESTATAIRES_____*****_____*/
insert into prestataires(proposition_id, demande_id) values (1,1);
/*_____*****_____PRESTATIONS_____*****_____*/
insert into prestations(prestataire_id, nb_grains) values (1, 2);
/*_____*****_____EVALUATIONS_____*****_____*/
/*_____*****_____CONVERSATIONS_____*****_____*/
/*_____*****_____CONVERSATION_USERS_____*****_____*/
/*_____*****_____MESSAGES_____*****_____*/