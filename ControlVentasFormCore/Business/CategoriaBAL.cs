using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class CategoriaBAL
    {
        #region Variables Globales...
        public Data.CategoriaDAL CategoriaDAL;
        #endregion

        #region Constructor...
        public CategoriaBAL()
        {
            CategoriaDAL = new Data.CategoriaDAL();
        }
        #endregion

        #region Properties
        public string ConnectionString
        {
            get { return CategoriaDAL.ConnectionString; }
            set { CategoriaDAL.ConnectionString = value; }
        }
        #endregion

        #region Methods
        public Entity.CategoriaInfo GetCategoria(int Id)
        {
            if (Id == 0) throw new ArgumentException("No recibi el id del producto que desea obtener");
            return CategoriaDAL.GetEntityObject(Id);
        }

        /// <summary>
        /// Metodo que devuelve TODOS los productos existentes
        /// </summary>
        /// <param name="Categoria"></param>
        /// <returns></returns>
        public List<Entity.CategoriaInfo> GetCategorias()
        {
            return CategoriaDAL.FindBy(new Entity.CategoriaInfo());
        }

        /// <summary>
        /// Aplica un filtro sobre una entidad de producto
        /// </summary>
        /// <param name="CategoriaInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Entity.CategoriaInfo> FindBy(Entity.CategoriaInfo CategoriaInfo)
        {
            if (CategoriaInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Producto para aplicar el filtro");
            return CategoriaDAL.FindBy(CategoriaInfo);
        }

        /// <summary>
        /// Metodo para guardar datos de un producto, insertar o actualizar
        /// </summary>
        /// <param name="CategoriaInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Save(Entity.CategoriaInfo CategoriaInfo)
        {
            if (CategoriaInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Producto para aplicar el filtro");
            if (CategoriaInfo.Id == 0)
                return CategoriaDAL.Insert(CategoriaInfo);
            else
                return CategoriaDAL.Update(CategoriaInfo);
        }

        /// <summary>
        /// Metodo para eliminar un producto a traves de su Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            CategoriaDAL.Delete(Id);
            return true;
        }

        /// <summary>
        /// Metodo para probar la conexion a la bd
        /// </summary>
        /// <returns></returns>
        public bool Ok()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
