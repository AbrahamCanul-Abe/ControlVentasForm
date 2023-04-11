using SOLTUM.Framework.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class MesaDAL : BookBaseDAL<Entity.MesaInfo, Entity.MesaInfo.FieldName>
    {
        #region Constructor...
        public MesaDAL() : base()
        {
            BookName = "BookMesas";
        }
        #endregion

    }
}
