using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class RolBAL
    {
        #region Variables Globales...
        public Data.RolDAL RolDAL;
        #endregion

        #region Constructor...
        public RolBAL()
        {
            RolDAL = new Data.RolDAL();
        }
        #endregion

        #region Properties
        public string ConnectionString
        {
            get { return RolDAL.ConnectionString; }
            set { RolDAL.ConnectionString = value; }
        }
        #endregion

        #region Methods
        public Entity.RolInfo GetRol(int Id)
        {
            if (Id == 0) throw new ArgumentException("No recibi el id del producto que desea obtener");
            return RolDAL.GetEntityObject(Id);
        }

        /// <summary>
        /// Metodo que devuelve TODOS los productos existentes
        /// </summary>
        /// <param name="Rol"></param>
        /// <returns></returns>
        public List<Entity.RolInfo> GetRoles()
        {
            return RolDAL.FindBy(new Entity.RolInfo());
        }

        /// <summary>
        /// Aplica un filtro sobre una entidad de producto
        /// </summary>
        /// <param name="RolInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Entity.RolInfo> FindBy(Entity.RolInfo RolInfo)
        {
            if (RolInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Producto para aplicar el filtro");
            return RolDAL.FindBy(RolInfo);
        }

        /// <summary>
        /// Metodo para guardar datos de un producto, insertar o actualizar
        /// </summary>
        /// <param name="RolInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Save(Entity.RolInfo RolInfo)
        {
            if (RolInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Producto para aplicar el filtro");
            if (RolInfo.Id == 0)
                return RolDAL.Insert(RolInfo);
            else
                return RolDAL.Update(RolInfo);
        }

        /// <summary>
        /// Metodo para eliminar un producto a traves de su Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            RolDAL.Delete(Id);
            return true;
        }

        #endregion
    }
}
