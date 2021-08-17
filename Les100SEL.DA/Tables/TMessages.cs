using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TMessages : ITable
    {
        public string NomTable => "[messages]";
        public string Id => "message_id";
        public string ConversationId => "conversation_id";
        public string UtilisateurId => "utilisateur_id";
        public string DateEnvoiMessage => "envoi";
        public string Message => "[message]";
        public string Alerte => "alerte";
    }
}
