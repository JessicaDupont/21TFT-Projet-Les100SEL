using Les100SEL.DA.Mapping;
using Les100SEL.DA.Repositories.Bases;
using Les100SEL.DA.Tables;
using Les100SEL.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;
using ToolIca.DataBases.Repositories;

namespace Les100SEL.DA.Repositories
{
    public class CategorieRepository : RepositoryBase, ICategoriesRepository
    {
        private readonly TCategories table;
        private readonly CategorieMapping map;
        public CategorieRepository() : base()
        {
            table = new TCategories();
            map = new CategorieMapping(table);
        }

        public ICategorie Read(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICategorie> Read()
        {
            Command cmd = new Command("select * from "+table.NomTable, false);
            return connect.ExecuteReader(cmd, reader => map.Mapping(reader));
        }

        public IEnumerable<ICategorie> Search(Filtre filtre)
        {
            //construire la requete
            string requete = "select * from " + table.NomTable + " ";
            switch (filtre.Champ.ToLower())
            {
                case "root":
                    requete += "where "+table.CategorieParent+" is null";
                    break;
                case "parent":
                    requete += "where "+table.CategorieParent+" = "+filtre.Valeur;
                    break;
                default: 
                    throw new NotImplementedException();
            }

            //executer la requete
            Command cmd = new Command(requete, false);
            return connect.ExecuteReader(cmd, reader => map.Mapping(reader));
        }

        public IEnumerable<ICategorie> Search(IEnumerable<Filtre> filtres)
        {
            throw new NotImplementedException();
        }
    }
}
