using SOLTUM.Framework.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class StatusBAL : BookBaseBAL<Entity.StatusInfo, Entity.StatusInfo.FieldName, Data.StatusDAL>
    {
        #region Constructor...
        public StatusBAL() : base()
        {
            Version = "1.0.0.0";
        }
        #endregion

        #region Methods
        public Entity.StatusInfo GetStatus(int Id)
        {
            if (Id == 0) throw new ArgumentException("No recibi el id del Status que desea obtener");
            return DataAccessLayer.GetEntityObjects(new List<SOLTUM.Framework.Data.Attributes.Condition>() { new SOLTUM.Framework.Data.Attributes.Condition(Entity.StatusInfo.FieldName.Id, "=", Id.ToString()) }).FirstOrDefault(); ;
        }

        /// <summary>
        /// Metodo que devuelve TODOS los status existentes
        /// </summary>
        /// <param name="Status"></param>
        /// <returns></returns>
        public List<Entity.StatusInfo> GetStatuss()
        {
            return DataAccessLayer.GetEntityObjects(new List<SOLTUM.Framework.Data.Attributes.Condition>()).ToList();
        }

        #endregion
    }
}
