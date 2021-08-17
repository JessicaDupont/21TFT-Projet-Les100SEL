CREATE TABLE [dbo].[messages]
(
	[message_id] INT NOT NULL identity PRIMARY KEY,
	conversation_id int not null,
	utilisateur_id int not null,
	envoi datetime2 default(getdate()),
	[message] text not null,
	alerte bit default(0),
	constraint FK_messages_conversation foreign key (conversation_id) references conversations(conversation_id),
	constraint FK_messages_utilisateur foreign key (utilisateur_id) references utilisateurs(utilisateur_id)
)
