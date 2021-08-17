using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TPrestataires : ITable
    {
        public string NomTable => "[prestataires]";
        public string Id => "prestataire_id";
        public string PropositionId => "proposition_id";
        public string DemandeId => "demande_id";
        public string Message => "[message]";
        public string Alerte => "alerte";
    }
}
