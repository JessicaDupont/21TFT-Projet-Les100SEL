using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TCategories : ITable
    {
        public string NomTable => "categories";
        public string Id => "categorie_id";
        public string Nom => "nom";
        public string Description => "[description]";
        public string NbGrainsMin => "grains_min";
        public string CategorieParent => "categorie_parent";
    }
}
