using Les100SEL.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les100SEL.Models.Forms
{
    public class CategorieForm : IForm
    {
        public CategorieForm(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int NbGrainsMin { get; set; }
        public int Parent { get; set; }
    }
}
