using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TUsers : ITable
    {
        public string NomTable => "[users]";

        public string Id => "[user_id]";
        public string ModeDeConnexion => "mode_connexion";
        public string Login => "[login]";
        public string Password => "mdp";
        public string DateInscription => "inscription";
        public string DateLastConnexion => "connexion";
        public string CommentaireMod => "commentaire_mod";
        public string DateFinDeBannissement => "fin_ban";
        public string UtilisateurId => "utilisateur_id";
    }
}
