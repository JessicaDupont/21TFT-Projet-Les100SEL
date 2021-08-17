using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TPrestations : ITable
    {
        public string NomTable => "prestations";
        public string Id => "[prestation_id]";
        public string ChoixPrestataireId => "prestataire_id";
        public string NbGrains => "nb_grains";
        public string DateDeDebut => "debut";
        public string DureeDeLaPrestation => "duree";
        public string Alerte => "alerte";
    }
}
