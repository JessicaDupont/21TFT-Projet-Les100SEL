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

        public IDictionary<IRegion, float> Regions();
        public IEnumerable<IConversation> Conversations();
        public IEnumerable<IProposition> Propositions();
        public IEnumerable<IDemande> Demandes();

        //IAlerte
        public new bool Alerte { get; set; }

        //IModel
        public new int Id { get; set; }
        public new bool DonneesRecuperees { get; set; }
    }
}
