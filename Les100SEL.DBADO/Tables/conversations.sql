CREATE TABLE [dbo].[conversations]
(
	[conversation_id] INT NOT NULL identity PRIMARY KEY,
	titre nvarchar(50) not null,
	proposition_id int,
	demande_id int,
	alerte bit default(0),
	constraint FK_conversations_proposition foreign key(proposition_id) references propositions(proposition_id),
	constraint FK_conversations_demande foreign key(demande_id) references demandes(demande_id)
)
