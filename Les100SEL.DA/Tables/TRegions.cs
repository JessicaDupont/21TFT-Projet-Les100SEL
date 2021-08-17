using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Tables
{
    public class TRegions : ITable
    {
        public string NomTable => "[regions]";
        public string Id => "region_id";
        public string CodePostal => "code_postal";
        public string Ville => "ville";
    }
}
