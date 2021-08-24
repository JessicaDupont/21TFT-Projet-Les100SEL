using Les100SEL.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les100SEL.Models.IModels
{
    public interface IProposition : IModel, IAlerte
    {
        public ICategorie Categorie { get; set; }
        public IUtilisateur Utilisateur { get; set; }
        public string Titre { get; set; }
        public string Profil { get; set; }
        public int NbGrains { get; set; }
        
        //IAlerte
        public new bool EstSignaler { get; set; }

        //IModel
        public new int Id { get; set; }
        public new bool DonneesRecuperees { get; set; }
    }
}
