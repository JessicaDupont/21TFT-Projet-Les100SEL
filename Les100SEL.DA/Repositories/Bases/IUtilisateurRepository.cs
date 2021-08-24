using Les100SEL.Models.Forms;
using Les100SEL.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.Repositories;

namespace Les100SEL.DA.Repositories.Bases
{
    public interface IUtilisateurRepository :
        IRepositoryCreate<IUtilisateur, UtilisateurForm, int>,
        IRepositoryRead<IUtilisateur, int>,
        IRepositoryUpdate<IUtilisateur, UtilisateurForm, int>,
        IRepositoryDelete<IUtilisateur, int>,
        IRepositoryAlert<IUtilisateur, int>
    {
    }
}
