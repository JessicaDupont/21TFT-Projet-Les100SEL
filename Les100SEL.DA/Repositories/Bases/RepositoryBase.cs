using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;
using ToolIca.DataBases.Repositories;

namespace Les100SEL.DA.Repositories.Bases
{
    public abstract class RepositoryBase
    {
        private readonly string sourceDB = "Data Source=FORMAVDI1307\\TFTIC;" +
            "Initial Catalog=Les100SEL;" +
            "Integrated Security=True;" +
            "Connect Timeout=60;" +
            "Encrypt=False;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";
        protected readonly Connexion connect;
        protected IList<Filtre> filtres;

        public RepositoryBase()
        {
            connect = new Connexion(SqlClientFactory.Instance, sourceDB);
            InitialisationFiltres();
        }

        protected void InitialisationFiltres()
        {
            filtres = new List<Filtre>();
        }
    }
}
