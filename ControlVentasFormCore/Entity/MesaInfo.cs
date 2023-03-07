using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    public class MesaInfo
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Id = "Id";
            public const string OrdenFolio = "OrdenFolio";
            public const string StatusId = "StatusId";
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public int OrdenFolio { get; set; }
        public int StatusId { get; set; }
        #endregion
    }
}
