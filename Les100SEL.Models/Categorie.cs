using Les100SEL.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les100SEL.Models
{
    public class Categorie : ICategorie
    {
        public Categorie(int id)
        {
            Id = id;
            DonneesRecuperees = false;
        }

        public string Nom { get; set; }
        public string Description { get; set; }
        public int NbGrainsMin { get; set; }
        public ICategorie Parent { get; set; }
        public int Id { get; set; }
        public bool DonneesRecuperees { get; set; }
    }
}
