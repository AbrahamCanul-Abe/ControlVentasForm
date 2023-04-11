using SOLTUM.Framework.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class OrdenDAL : BookBaseDAL<Entity.OrdenInfo, Entity.OrdenInfo.FieldName>
    {
        #region Constructor...
        public OrdenDAL() : base()
        {
            BookName = "BookOrdenes";
        }
        #endregion
    }
}
