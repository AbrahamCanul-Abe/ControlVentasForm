using SOLTUM.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    /// <summary>
    /// Definicion de clase que permite exponer los atributos de un producto
    /// </summary>
    public class ProductoInfo : IEntity
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Id = "NUM_DOC";

            [Field(Nombre, "Nombre",  FieldAttribute.eFieldType.Texto, Length = 200)]
            public const string Nombre = "Nombre";

            [Field(Descripcion, "Descripcion", FieldAttribute.eFieldType.Texto, Length = 255)]
            public const string Descripcion = "Descripcion";

            [Field(Precio, "Precio", FieldAttribute.eFieldType.Numero)]
            public const string Precio = "Precio";

            [Field(CategoriaId, "CategoriaId", FieldAttribute.eFieldType.Numero)]
            public const string CategoriaId = "CategoriaId";
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }
        #endregion
    }
}
