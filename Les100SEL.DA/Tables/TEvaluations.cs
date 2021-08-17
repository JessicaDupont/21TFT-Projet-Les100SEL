using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TEvaluations : ITable
    {
        public string NomTable => "evaluations";
        public string Id => "evaluation_id";
        public string PrestationId => "prestation_id";
        public string UtilisateurId => "utilisateur_id";
        public string NoteSurUtilisateur => "note_utilisateur";
        public string CommentaireSurUtilisateur => "commentaire_utilisateur";
        public string PrestataireId => "prestataire_id";
        public string NoteSurPrestataire => "note_prestataire";
        public string CommentaireSurPrestataire => "commentaire_prestataire";
        public string Alerte => "alerte";
    }
}
