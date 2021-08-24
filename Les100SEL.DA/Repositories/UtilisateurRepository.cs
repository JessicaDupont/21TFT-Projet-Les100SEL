using Les100SEL.DA.Mapping;
using Les100SEL.DA.Repositories.Bases;
using Les100SEL.DA.Tables;
using Les100SEL.Models;
using Les100SEL.Models.Forms;
using Les100SEL.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;
using ToolIca.DataBases.ADO.Mapping;

namespace Les100SEL.DA.Repositories
{
    public class UtilisateurRepository : RepositoryBase, IUtilisateurRepository
    {
        private readonly TUtilisateur table;
        private readonly UtilisateurMapping map;

        public UtilisateurRepository() : base()
        {
            table = new TUtilisateur();
            map = new UtilisateurMapping(table);
        }

        public IUtilisateur Create(UtilisateurForm form)
        {
            Command cmd = map.Mapping(form, CRUD.Create);
            int result = connect.ExecuteScalar<int>(cmd);
            return Read(result);
        }

        public IUtilisateur Delete(IUtilisateur model)
        {
            return Delete(model.Id);
        }

        public IUtilisateur Delete(int id)
        {
            IUtilisateur result = Read(id);
            Command cmd = map.Mapping(new UtilisateurForm(result.Id), CRUD.Delete);
            connect.ExecuteNonQuery(cmd);
            return result;
        }

        public IUtilisateur Read(int id)
        {
            Command cmd = map.Mapping(new UtilisateurForm(id), CRUD.Read);
            IUtilisateur result = connect.ExecuteReader(cmd, reader => map.Mapping(reader)).First();
            result = ObtenirInfos(result);
            return result;
        }

        private IUtilisateur ObtenirInfos(IUtilisateur result)
        {
            //result.Conversations = ObtenirConversations(result.Id);
            //result.Demandes = ObtenirDemandes(result.Id);
            //result.Prestations = ObtenirPrestations(result.Id);
            //result.Propositions = ObtenirPropositions(result.Id);
            return result;
        }

        public IEnumerable<IUtilisateur> Read()
        {
            Command cmd = map.Mapping(new UtilisateurForm(), CRUD.List);
            IEnumerable<IUtilisateur> result = connect.ExecuteReader(cmd, reader => map.Mapping(reader));
            foreach (IUtilisateur u in result)
            {
                yield return ObtenirInfos(u);
            }
        }

        public IUtilisateur Update(int id, UtilisateurForm form)
        {
            form.Id = id;
            Command cmd = map.Mapping(form, CRUD.Update);
            int result = connect.ExecuteScalar<int>(cmd);
            return Read(result);
        }

        public IUtilisateur Alert(int id)
        {
            Command cmd = map.Mapping(new UtilisateurForm(id), CRUD.Alert);
            int result = connect.ExecuteScalar<int>(cmd);
            return Read(result);
        }

        public IUtilisateur NoAlert(int id)
        {
            Command cmd = map.Mapping(new UtilisateurForm(id), CRUD.NoAlert);
            int result = connect.ExecuteScalar<int>(cmd);
            return Read(result);
        }

        public IEnumerable<IUtilisateur> GetAlert()
        {
            Command cmd = map.Mapping(new UtilisateurForm(), CRUD.ListAlerts);
            IEnumerable<IUtilisateur> result = connect.ExecuteReader(cmd, reader => map.Mapping(reader));
            foreach (IUtilisateur u in result)
            {
                yield return ObtenirInfos(u);
            }
        }
    }
}
