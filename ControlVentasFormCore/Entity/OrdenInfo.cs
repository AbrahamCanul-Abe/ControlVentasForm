using SOLTUM.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    public class OrdenInfo : IEntity
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Id = "NUM_DOC";

            [Field(Fecha, "Fecha", FieldAttribute.eFieldType.Fecha)]
            public const string Fecha = "Fecha";

            [Field(Total, "Total", FieldAttribute.eFieldType.Numero)]
            public const string Total = "Total";

            [Field(PerfilId, "PerfilId", FieldAttribute.eFieldType.Numero)]
            public const string PerfilId = "PerfilId";
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int PerfilId { get; set; }
        #endregion
    }
}
