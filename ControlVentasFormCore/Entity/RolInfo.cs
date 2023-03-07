using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    public class RolInfo
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Id = "Id";
            public const string Tipo = "Tipo";
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Tipo { get; set; }
        #endregion
    }
}
