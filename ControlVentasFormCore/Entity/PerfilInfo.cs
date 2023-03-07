using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    public class PerfilInfo
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Id = "Id";
            public const string Nombre = "Nombre";
            public const string Apellido = "Apellido";
            public const string Cargo = "Cargo";
            public const string UsuarioId = "UsuarioId";
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public int UsuarioId { get; set; }
        #endregion
    }
}
