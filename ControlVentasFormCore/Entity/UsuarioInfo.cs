using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    public class UsuarioInfo
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Id = "Id";
            public const string Username = "Username";
            public const string Password = "Password";
            public const string RolId = "RolId";
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RolId { get; set; }
        #endregion
    }
}
