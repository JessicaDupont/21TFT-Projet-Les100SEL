using Les100SEL.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.Repositories;

namespace Les100SEL.DA.Repositories.Bases
{
    public interface ICategoriesRepository : 
        IRepositoryRead<ICategorie, int>,
        IRepositorySearch<ICategorie, int>
    {
    }
}
