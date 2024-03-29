﻿using Les100SEL.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les100SEL.Models.IModels
{
    public interface IConversation : IModel, IAlerte
    {
        public string Titre { get; set; }
        public IEnumerable<IUtilisateur> Utilisateurs { get; set; }
        public IProposition Proposition { get; set; }
        public IDemande Demande { get; set; }
        public IEnumerable<IMessage> Messages { get; set; }

        //IAlerte
        public new bool EstSignaler { get; set; }

        //IModel
        public new int Id { get; set; }
        public new bool DonneesRecuperees { get; set; }
    }
}
