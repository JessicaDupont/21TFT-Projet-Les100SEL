using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TConversations : ITable
    {
        public string NomTable => "Conversations";
        public string Id => "conversation_id";
        public string Titre => "titre";
        public string PropositionId => "proposition_id";
        public string DemandeId => "demande_id";
        public string Alerte => "alerte";
    }
}
