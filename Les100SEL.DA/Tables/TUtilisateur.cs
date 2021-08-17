using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TUtilisateur : ITable
    {
        public string NomTable => "utilisateurs";

        public string Id => "utilisateur_id";
        public string Nom => "nom";
        public string DateDeNaissance => "ddn";
        public string Alerte => "alerte";
    }
}
