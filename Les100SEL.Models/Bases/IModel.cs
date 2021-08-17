using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.Models.Bases;

namespace Les100SEL.Models.Bases
{
    public interface IModel : IModelBase
    {
        public bool DonneesRecuperees { get; set; }
    }
}
