using Les100SEL.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les100SEL.Models.Forms
{
    public class UtilisateurForm : IForm
    {
        public UtilisateurForm()
        {
        }

        public UtilisateurForm(int id)
        {
            Id = id;
        }

        public string Nom { get; set; }
        public DateTime Ddn { get; set; }
        public int Id { get; set; }

        public bool EstSignaler { get; set; }
    }
}
