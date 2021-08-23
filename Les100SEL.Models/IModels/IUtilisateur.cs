using Les100SEL.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les100SEL.Models.IModels
{
    public interface IUtilisateur : IModel, IAlerte
    {
        public string Nom { get; set; }
        public DateTime Ddn { get; set; }

        public IDictionary<IRegion, float> Regions { get; set; }
        public IEnumerable<IConversation> Conversations { get; set; }
        public IEnumerable<IProposition> Propositions { get; set; }
        public IEnumerable<IDemande> Demandes { get; set; }
        public IEnumerable<IPrestation> Prestations { get; set; }

        //IAlerte
        public new bool EstSignaler { get; set; }

        //IModel
        public new int Id { get; set; }
        public new bool DonneesRecuperees { get; set; }
    }
}
