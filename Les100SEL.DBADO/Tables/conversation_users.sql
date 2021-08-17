CREATE TABLE [dbo].[conversation_users]
(
	utilisateur_id int not null,
	conversation_id int not null,
	constraint FK_conversationuser_utilisateur foreign key(utilisateur_id) references utilisateurs(utilisateur_id),
	constraint FK_conversationuser_conversation foreign key(conversation_id) references conversations(conversation_id)
)
