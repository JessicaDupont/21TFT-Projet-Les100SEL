using Les100SEL.Models.Bases;

namespace Les100SEL.Models.IModels
{
    public interface IOffre : IModel, IAlerte
    {
        public IProposition Proposition { get; set; }
        public IDemande Demande { get; set; }
        public string Message { get; set; }

        //IAlerte
        public new bool EstSignaler { get; set; }

        //IModel
        public new int Id { get; set; }
        public new bool DonneesRecuperees { get; set; }
    }
}