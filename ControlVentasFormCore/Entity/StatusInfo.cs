using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    public class StatusInfo
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Id = "Id";
            public const string Descripcion = "Descripcion";
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Descripcion { get; set; }
        #endregion
    }
}
