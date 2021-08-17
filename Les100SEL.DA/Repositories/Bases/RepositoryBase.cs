using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolIca.DataBases.ADO.Bases;

namespace Les100SEL.DA.Repositories.Bases
{
    public abstract class RepositoryBase
    {
        protected readonly Connexion connect;
        private readonly string sourceDB = "Data Source=FORMAVDI1307\\TFTIC;" +
            "Initial Catalog=Les100SEL;" +
            "Integrated Security=True;" +
            "Connect Timeout=60;" +
            "Encrypt=False;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";

        public RepositoryBase()
        {
            connect = new Connexion(SqlClientFactory.Instance, sourceDB);
        }
    }
}
