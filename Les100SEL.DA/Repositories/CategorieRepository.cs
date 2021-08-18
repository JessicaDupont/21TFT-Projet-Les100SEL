using Les100SEL.DA.Mapping;
using Les100SEL.DA.Repositories.Bases;
using Les100SEL.DA.Tables;
using Les100SEL.Models.Forms;
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
        public const string CategoriesRacine = "root";
        public const string CategoriesEnfantDe = "parent";
        //public const string CategoriesAncetresDe = "ancetres";
        //public const string CategoriesDescendantsDe = "descendants";

        private readonly TCategories table;
        private readonly CategorieMapping map;

        public CategorieRepository() : base()
        {
            table = new TCategories();
            map = new CategorieMapping(table);
        }

        public ICategorie Create(CategorieForm form)
        {
            throw new NotImplementedException();
        }

        public ICategorie Delete(ICategorie model)
        {
            throw new NotImplementedException();
        }

        public ICategorie Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ICategorie Read(int id)
        {
            Command cmd = new Command("select * from " + table.NomTable + 
                " where " + table.Id + " = " + id, false);
            return connect.ExecuteReader(cmd, reader => map.Mapping(reader)).First();
        }

        public IEnumerable<ICategorie> Read()
        {
            //récupérer les catégories racines
            IEnumerable<ICategorie> racines = Search(new Filtre(CategoriesRacine, 0));
            //récupérer les catégories enfants
            foreach (ICategorie racine in racines)
            {
                yield return ObtenirDescendants(racine);
            }

        }

        private ICategorie ObtenirDescendants(ICategorie parent)
        {
            //ajout des enfants au parent
            parent.Enfants = AjouterEnfants(parent);

            //recherche des petits-enfants (résursif)
            foreach (ICategorie enfant in parent.Enfants)
            {
                ObtenirDescendants(enfant);
            }

            return parent;
        }

        private IEnumerable<ICategorie> AjouterEnfants(ICategorie parent)
        {
            IEnumerable<ICategorie> enfants = Search(new Filtre(CategoriesEnfantDe, parent.Id));
            foreach (ICategorie enfant in enfants) 
            { 
                yield return enfant; 
            }
        }

        public IEnumerable<ICategorie> Search(Filtre filtre)
        {
            //construire la requete
            string requete = "select * from " + table.NomTable + " ";
            switch (filtre.Champ.ToLower())
            {
                case CategoriesRacine:
                    requete += "where "+table.CategorieParent+" is null";
                    break;
                case CategoriesEnfantDe:
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

        public ICategorie Update(int id, CategorieForm form)
        {
            throw new NotImplementedException();
        }
    }
}
