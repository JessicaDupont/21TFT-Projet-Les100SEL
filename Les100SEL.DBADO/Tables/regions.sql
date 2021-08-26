CREATE TABLE [dbo].[regions]
(
	region_id INT NOT NULL PRIMARY KEY,
	code_postal int not null,
	ville nvarchar(60) not null,
	constraint U_regions unique(code_postal, ville)
)
