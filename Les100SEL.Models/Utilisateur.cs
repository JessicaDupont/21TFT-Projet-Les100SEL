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
        public bool Alerte { get; set; }
        public int Id { get; set; }
        public bool DonneesRecuperees { get; set; }
        public IDictionary<IRegion, float> Regions() 
        {
            throw new NotImplementedException();
        }
        public IEnumerable<IConversation> Conversations()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<IProposition> Propositions()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<IDemande> Demandes()
        {
            throw new NotImplementedException();
        }
    }
}
