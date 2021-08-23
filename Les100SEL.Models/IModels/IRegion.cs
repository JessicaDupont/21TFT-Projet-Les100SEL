using Les100SEL.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les100SEL.Models.IModels
{
    public interface IRegion : IModel
    {
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        
        //IModel
        public new int Id { get; set; }
        public new bool DonneesRecuperees { get; set; }
    }
}
