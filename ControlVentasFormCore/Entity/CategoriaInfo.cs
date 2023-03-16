using SOLTUM.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    public class CategoriaInfo : IEntity
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Id = "NUM_DOC";

            [Field(Nombre, "Nombre", FieldAttribute.eFieldType.Texto, Length = 200)]
            public const string Nombre = "Nombre";
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Nombre { get; set; }
        #endregion
    }
}
