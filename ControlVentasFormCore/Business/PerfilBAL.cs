using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class PerfilBAL
    {
        #region Variables Globales...
        public Data.PerfilDAL PerfilDAL;
        #endregion

        #region Constructor...
        public PerfilBAL()
        {
            PerfilDAL = new Data.PerfilDAL();
        }
        #endregion

        #region Properties
        public string ConnectionString
        {
            get { return PerfilDAL.ConnectionString; }
            set { PerfilDAL.ConnectionString = value; }
        }
        #endregion

        #region Methods
        public Entity.PerfilInfo GetPerfil(int Id)
        {
            if (Id == 0) throw new ArgumentException("No recibi el id del producto que desea obtener");
            return PerfilDAL.GetEntityObject(Id);
        }

        /// <summary>
        /// Metodo que devuelve TODOS los productos existentes
        /// </summary>
        /// <param name="Producto"></param>
        /// <returns></returns>
        public List<Entity.PerfilInfo> GetPerfiles()
        {
            return PerfilDAL.FindBy(new Entity.PerfilInfo());
        }

       
        /// <summary>
        /// Aplica un filtro sobre una entidad de producto
        /// </summary>
        /// <param name="PerfilInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Entity.PerfilInfo> FindBy(Entity.PerfilInfo PerfilInfo)
        {
            if (PerfilInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Producto para aplicar el filtro");
            return PerfilDAL.FindBy(PerfilInfo);
        }

        /// <summary>
        /// Metodo para guardar datos de un producto, insertar o actualizar
        /// </summary>
        /// <param name="PerfilInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Save(Entity.PerfilInfo PerfilInfo)
        {
            if (PerfilInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Producto para aplicar el filtro");
            if (PerfilInfo.Id == 0)
                return PerfilDAL.Insert(PerfilInfo);
            else
                return PerfilDAL.Update(PerfilInfo);
        }

        /// <summary>
        /// Metodo para eliminar un producto a traves de su Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            PerfilDAL.Delete(Id);
            return true;
        }

        
        #endregion
    }
}
