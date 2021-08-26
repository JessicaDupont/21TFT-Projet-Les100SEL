CREATE TABLE [dbo].[categories]
(
	categorie_id INT NOT NULL PRIMARY KEY,
	nom nvarchar(150) not null,
	[description] text,
	grains_min int default(1),
	categorie_parent int,
	constraint FK_categories_parent foreign key(categorie_parent) references categories(categorie_id)
)
