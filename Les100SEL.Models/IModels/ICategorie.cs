using Les100SEL.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les100SEL.Models.IModels
{
    public interface ICategorie : IModel
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public int NbGrainsMin { get; set; }
        public ICategorie Parent { get; set; }

        //IModel
        public new int Id { get; set; }
        public new bool DonneesRecuperees { get; set; }
    }
}
