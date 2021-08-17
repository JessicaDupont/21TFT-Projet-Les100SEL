using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TConversationUsers : ITable
    {
        public string NomTable => "conversation_users";
        public string UtilisateurId => "utilisateur_id";
        public string ConversationId => "conversation_id";
    }
}
