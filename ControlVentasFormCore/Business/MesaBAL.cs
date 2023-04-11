using SOLTUM.Framework.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class MesaBAL : BookBaseBAL<Entity.MesaInfo, Entity.MesaInfo.FieldName, Data.MesaDAL>
    {
        #region Constructor...
        public MesaBAL() : base()
        {
            Version = "1.0.0.0";
        }
        #endregion

        #region Methods
        public Entity.MesaInfo GetMesa(int Id)
        {
            if (Id == 0) throw new ArgumentException("No recibi el id de la mesa que desea obtener");
            return DataAccessLayer.GetEntityObjects(new List<SOLTUM.Framework.Data.Attributes.Condition>() { new SOLTUM.Framework.Data.Attributes.Condition(Entity.MesaInfo.FieldName.Id, "=", Id.ToString()) }).FirstOrDefault(); ;

        }

        /// <summary>
        /// Metodo que devuelve TODOS las mesas existentes
        /// </summary>
        /// <param name="Mesa"></param>
        /// <returns></returns>
        public List<Entity.MesaInfo> GetMesas()
        {
            return DataAccessLayer.GetEntityObjects(new List<SOLTUM.Framework.Data.Attributes.Condition>()).ToList();
        }


        
        #endregion
    }
}
