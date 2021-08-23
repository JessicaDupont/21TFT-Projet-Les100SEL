using Les100SEL.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les100SEL.Models
{
    public class Utilisateur : IUtilisateur
    {
        public Utilisateur()
        {
        }

        public Utilisateur(int id)
        {
            Id = id;
        }

        public string Nom { get; set; }
        public DateTime Ddn { get; set; }
        public bool EstSignaler { get; set; }
        public int Id { get; set; }
        public bool DonneesRecuperees { get; set; }
        public IDictionary<IRegion, float> Regions { get; set; }
        public IEnumerable<IConversation> Conversations { get; set; }
        public IEnumerable<IProposition> Propositions { get; set; }
        public IEnumerable<IDemande> Demandes { get; set; }
        public IEnumerable<IPrestation> Prestations { get; set; }
    }
}
