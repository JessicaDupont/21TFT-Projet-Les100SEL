using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TPropositions : ITable
    {
        public string NomTable => "[propositions]";
        public string Id => "[proposition_id]";
        public string CategorieId => "categorie_id";
        public string UtilisateurId => "utilisateur_id";
        public string ProfilPropose => "profil_propose";
        public string NbGrains => "nb_grains";
        public string Alerte => "alerte";
    }
}
