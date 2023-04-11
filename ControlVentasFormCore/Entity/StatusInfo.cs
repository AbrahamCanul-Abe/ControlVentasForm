using SOLTUM.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    public class StatusInfo : IEntity
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Id = "NUM_DOC";

            [Field(Descripcion, "Descripcion", FieldAttribute.eFieldType.Texto, Length = 255)]
            public const string Descripcion = "Descripcion";
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Descripcion { get; set; }
        #endregion
    }
}
