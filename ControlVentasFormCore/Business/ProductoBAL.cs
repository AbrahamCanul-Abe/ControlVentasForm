using DocumentFormat.OpenXml.Office2010.Excel;
using SOLTUM.Framework.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    /// <summary>
    /// Definicion de clase que permite exponer metodos de negocio para los productos
    /// </summary>
    public class ProductoBAL : BookBaseBAL<Entity.ProductoInfo, Entity.ProductoInfo.FieldName, Data.ProductoDAL>
    {

        #region Constructor...
        public ProductoBAL() : base()
        {
            Version = "1.0.0.0";
        }
        #endregion

        #region Methods
        public Entity.ProductoInfo GetProducto(int Id)
        {
            if (Id == 0) throw new ArgumentNullException("No recibi el id del producto que desea obtener");
            return DataAccessLayer.GetEntityObjects(new List<SOLTUM.Framework.Data.Attributes.Condition>() {
                new SOLTUM.Framework.Data.Attributes.Condition(Entity.ProductoInfo.FieldName.Id, "=", Id.ToString()) 
            }).FirstOrDefault();
        }

        /// <summary>
        /// Metodo que devuelve TODOS los productos existentes
        /// </summary>
        /// <param name="Producto"></param>
        /// <returns></returns>
        public List<Entity.ProductoInfo> GetProductos()
        {
            return DataAccessLayer.GetEntityObjects(new List<SOLTUM.Framework.Data.Attributes.Condition>()).ToList();
        }

        /// <summary>
        /// Metodo que devulve un producto por medio de su categoria
        /// </summary>
        /// <param name="CategoriaId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Entity.ProductoInfo> GetProductosPorId(int CategoriaId)
        {
            if (CategoriaId == 0) throw new Exception("No recibí el Id de la categoría de la que se desean obtener los productos");
            return DataAccessLayer.GetEntityObjects(new List<SOLTUM.Framework.Data.Attributes.Condition>() { 
                new SOLTUM.Framework.Data.Attributes.Condition(Entity.ProductoInfo.FieldName.CategoriaId, "=", CategoriaId.ToString()) 
            }).ToList();
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
