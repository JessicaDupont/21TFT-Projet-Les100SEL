using Les100SEL.Models.Bases;
using System;

namespace Les100SEL.Models.IModels
{
    public interface IMessage : IModel, IAlerte
    {
        public IUtilisateur Auteur { get; set; }
        public DateTime DateEnvoi { get; set; }
        public string Message { get; set; }
        
        //IAlerte
        public new bool EstSignaler { get; set; }

        //IModel
        public new int Id { get; set; }
        public new bool DonneesRecuperees { get; set; }
    }
}