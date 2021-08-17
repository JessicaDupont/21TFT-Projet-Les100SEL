using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TUtilisateurRegions : ITable
    {
        public string NomTable => "utilisateur_regions";
        public string UtilisateurId => "utilisateur_id";
        public string RegionId => "region_id";
        public string FraisDeDeplacement => "frais_deplacement";
    }
}
