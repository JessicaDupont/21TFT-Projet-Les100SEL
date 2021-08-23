using Les100SEL.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les100SEL.Models.Forms
{
    public class PropositionForm : IForm
    {
        public int Categorie { get; set; }
        public int Utilisateur { get; set; }
        public string Profil { get; set; }
        public int NbGrains { get; set; }
        public bool EstSignaler { get; set; }
        public int Id { get; set; }
    }
}
