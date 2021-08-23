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
    public class CategorieMapping : IMapping<DbDataReader, ICategorie, CategorieForm>
    {
        private readonly TCategories t;

        public CategorieMapping(TCategories table)
        {
            this.t = table;
        }

        public ICategorie Mapping(DbDataReader data)
        {
            ICategorie result = new Categorie((int)data[t.Id]);
            result.Description = data[t.Description] == DBNull.Value ? null : (string)data[t.Description];
            result.NbGrainsMin = (int)data[t.NbGrainsMin];
            result.Nom = (string)data[t.Nom];
            result.Parent = data[t.CategorieParent] == DBNull.Value ? null : new Categorie((int)data[t.CategorieParent]);
            result.DonneesRecuperees = true;
            return result;
        }

        public Command Mapping(CategorieForm form, CRUD type)
        {
            string requete;
            Command cmd;
            switch (type) 
            {
                case CRUD.Create:
                    requete = $"insert into {t.NomTable} " +
                        $"({t.Nom}, {t.Description}, {t.NbGrainsMin}, {t.CategorieParent}) " +
                        $"values (@nom, @description, @nbGrainsMin, @parent); " +
                        $"SELECT CAST(scope_identity() AS int);";
                    cmd = new Command(requete, false);
                    cmd.AddParameter("nom", form.Nom);
                    cmd.AddParameter("description", form.Description);
                    cmd.AddParameter("nbGrainsMin", form.NbGrainsMin);
                    cmd.AddParameter("parent", form.Parent);
                    break;
                case CRUD.Update:
                    requete = $"update {t.NomTable} " +
                        $"set {t.CategorieParent} = @parent, " +
                        $"{t.Description} = @desc, " +
                        $"{t.NbGrainsMin} = @grains, " +
                        $"{t.Nom} = @nom " +
                        $"where {t.Id} = @id;" +
                        $"SELECT {t.Id} from {t.NomTable} where {t.Id} = @idbis;";
                    cmd = new Command(requete, false);
                    cmd.AddParameter("parent", form.Parent);
                    cmd.AddParameter("desc", form.Description);
                    cmd.AddParameter("grains", form.NbGrainsMin);
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
                case CRUD.Read:
                default:
                    requete = $"select * from {t.NomTable};";
                    cmd = new Command(requete, false);
                    break;
            }
            return cmd;
        }
    }
}
