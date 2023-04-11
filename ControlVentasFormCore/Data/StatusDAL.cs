using SOLTUM.Framework.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class StatusDAL : BookBaseDAL<Entity.StatusInfo, Entity.StatusInfo.FieldName>
    {

        #region Constructor...
        public StatusDAL() : base()
        {
            BookName = "BookStatus";
        }
        #endregion
    }
}
