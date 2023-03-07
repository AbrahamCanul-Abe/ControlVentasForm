using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    public class OrdenInfo
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Folio = "Folio";
            public const string Fecha = "Fecha";
            public const string Total = "Total";
            public const string PerfilId = "PerfilId";
        }
        #endregion

        #region Properties
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int PerfilId { get; set; }
        #endregion
    }
}
