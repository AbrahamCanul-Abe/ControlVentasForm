using SOLTUM.Framework.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class OrdenBAL : BookBaseBAL<Entity.OrdenInfo, Entity.OrdenInfo.FieldName, Data.OrdenDAL>
    {
        #region Constructor...
        public OrdenBAL() : base()
        {
            Version = "1.0.0.0";
        }
        #endregion

        #region Methods
        public Entity.OrdenInfo GetOrden(int Id)
        {
            if (Id == 0) throw new ArgumentException("No recibi el id de la orden que desea obtener");
            return DataAccessLayer.GetEntityObjects(new List<SOLTUM.Framework.Data.Attributes.Condition>() { new SOLTUM.Framework.Data.Attributes.Condition(Entity.OrdenInfo.FieldName.Id, "=", Id.ToString()) }).FirstOrDefault(); ;
        }

        /// <summary>
        /// Metodo que devuelve TODAS las ordenes existentes
        /// </summary>
        /// <param name="Orden"></param>
        /// <returns></returns>
        public List<Entity.OrdenInfo> GetOrdenes()
        {
            return DataAccessLayer.GetEntityObjects(new List<SOLTUM.Framework.Data.Attributes.Condition>()).ToList();
        }
        #endregion
    }
}
