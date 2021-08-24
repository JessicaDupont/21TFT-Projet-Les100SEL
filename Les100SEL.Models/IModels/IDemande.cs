using Les100SEL.Models.Bases;

namespace Les100SEL.Models.IModels
{
    public interface IDemande : IModel, IAlerte
    {
        public ICategorie Categorie { get; set; }
        public IUtilisateur Utilisateur { get; set; }
        public IRegion Region { get; set; }
        public string Titre { get; set; }
        public string Adresse { get; set; }
        public string Description { get; set; }
        public int NbGrains { get; set; }
        public bool Active { get; }

        public void Activer();
        public void Desactiver();

        //IAlerte
        public new bool EstSignaler { get; set; }

        //IModel
        public new int Id { get; set; }
        public new bool DonneesRecuperees { get; set; }
    }
}