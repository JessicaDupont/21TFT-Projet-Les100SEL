using Les100SEL.DA.Tables;
using Les100SEL.Models;
using Les100SEL.Models.Forms;
using Les100SEL.Models.IModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;
using ToolIca.DataBases.ADO.Mapping;

namespace Les100SEL.DA.Mapping
{
    public class UtilisateurMapping : IMapping<DbDataReader, IUtilisateur, UtilisateurForm>
    {
        private readonly TUtilisateur t;
        public UtilisateurMapping(TUtilisateur table)
        {
            t = table;
        }

        public Command Mapping(UtilisateurForm form, CRUD type)
        {
            string requete;
            Command cmd;
            switch (type)
            {
                case CRUD.Create:
                    requete = $"insert into {t.NomTable} " +
                        $"({t.DateDeNaissance}, {t.Nom}) " +
                        $"values (@ddn, @nom); " +
                        $"SELECT CAST(scope_identity() AS int);";
                    cmd = new Command(requete, false);
                    cmd.AddParameter("ddn", form.Ddn);
                    cmd.AddParameter("nom", form.Nom);
                    break;
                case CRUD.Read:
                    requete = $"select * from {t.NomTable} " +
                        $"where {t.Id} = @id";
                    cmd = new Command(requete, false);
                    cmd.AddParameter("id", form.Id);
                    break;
                case CRUD.Update:
                    requete = $"update {t.NomTable} " +
                        $"set {t.DateDeNaissance} = @ddn, " +
                        $"{t.Nom} = @nom " +
                        $"where {t.Id} = @id;" +
                        $"SELECT {t.Id} from {t.NomTable} where {t.Id} = @idbis;";
                    cmd = new Command(requete, false);
                    cmd.AddParameter("ddn", form.Ddn);
                    cmd.AddParameter("nom", form.Nom);
                    cmd.AddParameter("id", form.Id);
                    cmd.AddParameter("idbis", form.Id);
                    break;
                case CRUD.Delete:
                    requete = $"Delete from {t.NomTable} " +
                        $"where {t.Id} = @id;";
                    cmd = new Command(requete, false);
                    cmd.AddParameter("id", form.Id);
                    break;
                case CRUD.Alert:
                    requete = $"update {t.NomTable} " +
                        $"set {t.Alerte} = 1 " +
                        $"where {t.Id} = @id;" +
                        $"SELECT {t.Id} from {t.NomTable} where {t.Id} = @idbis;";
                    cmd = new Command(requete, false);
                    cmd.AddParameter("id", form.Id);
                    cmd.AddParameter("idbis", form.Id);
                    break;
                case CRUD.NoAlert:
                    requete = $"update {t.NomTable} " +
                        $"set {t.Alerte} = 0 " +
                        $"where {t.Id} = @id;" +
                        $"SELECT {t.Id} from {t.NomTable} where {t.Id} = @idbis;";
                    cmd = new Command(requete, false);
                    cmd.AddParameter("id", form.Id);
                    cmd.AddParameter("idbis", form.Id);
                    break;
                case CRUD.ListAlerts:
                    requete = $"select * from {t.NomTable} " +
                        $"where {t.Alerte} = 1";
                    cmd = new Command(requete, false);
                    break;
                case CRUD.List:
                default:
                    requete = $"select * from {t.NomTable};";
                    cmd = new Command(requete, false);
                    break;
            }
            return cmd;
        }

        public IUtilisateur Mapping(DbDataReader data)
        {
            IUtilisateur result = new Utilisateur((int)data[t.Id]);
            result.Ddn = (DateTime)data[t.DateDeNaissance];
            result.Alerte = (bool)data[t.Alerte];
            result.Nom = (string)data[t.Nom];
            result.DonneesRecuperees = true;
            return result;
        }
    }
}
