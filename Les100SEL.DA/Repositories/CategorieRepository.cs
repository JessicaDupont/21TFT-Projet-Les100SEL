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
using ToolIca.DataBases.ADO.Mapping;
using ToolIca.DataBases.Repositories;

namespace Les100SEL.DA.Repositories
{
    public class CategorieRepository : RepositoryBase, ICategoriesRepository
    {
        public const string CategorieId = "id";
        public const string CategoriesRacine = "root";
        public const string CategoriesEnfantDe = "parent";

        private readonly TCategories table;
        private readonly CategorieMapping map;

        public CategorieRepository() : base()
        {
            table = new TCategories();
            map = new CategorieMapping(table);
        }

        public ICategorie Create(CategorieForm form)
        {
            Command cmd = map.Mapping(form, CRUD.Create);

            int result = connect.ExecuteScalar<int>(cmd);
            
            return Read(result);
        }

        public ICategorie Delete(ICategorie model)
        {
            return Delete(model.Id);
        }

        public ICategorie Delete(int id)
        {
            ICategorie result = Read(id);

            Command cmd = map.Mapping(new CategorieForm(id), CRUD.Delete);
            connect.ExecuteNonQuery(cmd);

            return result;
        }

        public ICategorie Read(int id)
        {
            return Search(new Filtre(CategorieId, id)).First();
        }

        public IEnumerable<ICategorie> Read()
        {
            return Search(new Filtre(CategoriesRacine, 0));
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
                case CategorieId:
                    requete += "where "+table.Id+" = "+filtre.Valeur;
                    break;
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
            IEnumerable<ICategorie> result = connect.ExecuteReader(cmd, reader => map.Mapping(reader));

            //récuperer les enfants + return
            foreach (ICategorie cat in result) 
            {
                yield return ObtenirDescendants(cat);
            }

        }

        public IEnumerable<ICategorie> Search(IEnumerable<Filtre> filtres)
        {
            throw new NotImplementedException();
        }

        public ICategorie Update(int id, CategorieForm form)
        {
            form.Id = id;
            Command cmd = map.Mapping(form, CRUD.Update);

            int result = connect.ExecuteScalar<int>(cmd);
            return Read(result);
        }
    }
}
