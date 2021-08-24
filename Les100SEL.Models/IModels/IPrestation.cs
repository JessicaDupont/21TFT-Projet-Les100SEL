using Les100SEL.Models.Bases;
using System;

namespace Les100SEL.Models.IModels
{
    public interface IPrestation : IModel, IAlerte
    {
        public IOffre Offre { get; set; }
        public int NbGrains { get; set; }
        public DateTime Debut { get; set; }
        public TimeSpan Duree { get; set; }
        public void ActiverTimer();
        public void DesactiverTimer();

        //IAlerte
        public new bool EstSignaler { get; set; }

        //IModel
        public new int Id { get; set; }
        public new bool DonneesRecuperees { get; set; }
    }
}