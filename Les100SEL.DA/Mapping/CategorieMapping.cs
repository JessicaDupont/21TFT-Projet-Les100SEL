using Les100SEL.DA.Tables;
using Les100SEL.Models;
using Les100SEL.Models.IModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Mapping;

namespace Les100SEL.DA.Mapping
{
    public class CategorieMapping : IMapping<DbDataReader, ICategorie>
    {
        private readonly TCategories t;

        public CategorieMapping(TCategories table)
        {
            this.t = table;
        }
        public DbDataReader Mapping(ICategorie model)
        {
            throw new NotImplementedException();
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
    }
}
