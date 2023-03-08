using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class UsuarioBAL
    {
        #region Variables Globales...
        public Data.UsuarioDAL UsuarioDAL;
        #endregion

        #region Constructor...
        public UsuarioBAL()
        {
            UsuarioDAL = new Data.UsuarioDAL();
        }
        #endregion

        #region Properties
        public string ConnectionString
        {
            get { return UsuarioDAL.ConnectionString; }
            set { UsuarioDAL.ConnectionString = value; }
        }
        #endregion

        #region Methods
        public Entity.UsuarioInfo GetUsuario(int Id)
        {
            if (Id == 0) throw new ArgumentException("No recibi el id del Usuario que desea obtener");
            return UsuarioDAL.GetEntityObject(Id);
        }

        /// <summary>
        /// Metodo que devuelve TODOS los Usuarios existentes
        /// </summary>
        /// <param name="Usuario"></param>
        /// <returns></returns>
        public List<Entity.UsuarioInfo> GetUsuarios()
        {
            return UsuarioDAL.FindBy(new Entity.UsuarioInfo());
        }

        /// <summary>
        /// Metodo que devulve los Usuarios por medio de su rol
        /// </summary>
        /// <param name="RolId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Entity.UsuarioInfo> GetUsuariosPorRol(int RolId)
        {
            if (RolId == 0) throw new Exception("No recibí el Id del rol del que se desean obtener los Usuarios");
            return UsuarioDAL.FindBy(new Entity.UsuarioInfo() { RolId = RolId });
        }

        /// <summary>
        /// Aplica un filtro sobre una entidad de Usuario
        /// </summary>
        /// <param name="UsuarioInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Entity.UsuarioInfo> FindBy(Entity.UsuarioInfo UsuarioInfo)
        {
            if (UsuarioInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Usuario para aplicar el filtro");
            return UsuarioDAL.FindBy(UsuarioInfo);
        }

        /// <summary>
        /// Metodo para guardar datos de un usuario, insertar o actualizar
        /// </summary>
        /// <param name="UsuarioInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Save(Entity.UsuarioInfo UsuarioInfo)
        {
            if (UsuarioInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Usuario para aplicar el filtro");
            if (UsuarioInfo.Id == 0)
                return UsuarioDAL.Insert(UsuarioInfo);
            else
                return UsuarioDAL.Update(UsuarioInfo);
        }

        /// <summary>
        /// Metodo para eliminar un Usuario a traves de su Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            UsuarioDAL.Delete(Id);
            return true;
        }

        #endregion
    }
}
