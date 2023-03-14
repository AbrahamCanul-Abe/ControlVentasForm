using SOLTUM.Framework.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class ProductoDAL : BookBaseDAL<Entity.ProductoInfo, Entity.ProductoInfo.FieldName>
    {
        #region Constructor...
        public ProductoDAL() : base()
        {
            BookName = "BookProductos";
        }
        #endregion

        #region Methods...

        #endregion
    }
}
