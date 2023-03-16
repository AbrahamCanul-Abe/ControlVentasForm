using SOLTUM.Framework.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class CategoriaDAL : BookBaseDAL<Entity.CategoriaInfo, Entity.CategoriaInfo.FieldName>
    {
        #region Constructor...
        public CategoriaDAL() : base()
        {
            BookName = "BookCategorias";
        }
        #endregion

        #region Methods...

        #endregion
    }
}
