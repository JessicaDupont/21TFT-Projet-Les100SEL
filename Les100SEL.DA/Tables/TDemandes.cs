using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TDemandes : ITable
    {
        public string NomTable => "[demandes]";
        public string Id => "[demande_id]";
        public string CategorieId => "categorie_id";
        public string UtilisateurId => "utilisateur_id";
        public string RegionId => "region_id";
        public string Adresse => "adresse";
        public string Description => "[description]";
        public string NbGrains => "nb_grains";
        public string Alerte => "alerte";
    }
}
