using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    public class CategoriaInfo
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Id = "Id";
            public const string Nombre = "Nombre";
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Nombre { get; set; }
        #endregion
    }
}
