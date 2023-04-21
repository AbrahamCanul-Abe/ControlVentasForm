using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ControlDeCasasWebApplication
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Inicializa los strings de conexion...
            SOLTUM.Framework.Global.ProjectConnection = new SOLTUM.Framework.Utilities.ProjectConnection
            {
                DataConnectionString = "Data Source=LENO\\SQLEXPRESS2; Initial Catalog=dbRestaurantventas_data;" + "Integrated Security=true;", //ConfigurationManager.ConnectionStrings["DataConnectionString"].ConnectionString,
                CredentialsConnectionString = "", //ConfigurationManager.ConnectionStrings["CredentialsConnectionString"].ConnectionString,
                ConfigConnectionString = ""//ConfigurationManager.ConnectionStrings["DataConnectionString"].ConnectionString
            };
        }
    }
}