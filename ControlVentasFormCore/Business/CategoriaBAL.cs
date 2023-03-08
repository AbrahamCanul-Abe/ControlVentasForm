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
            if (Id == 0) throw new ArgumentException("No recibi el id de la categoria que desea obtener");
            return CategoriaDAL.GetEntityObject(Id);
        }

        /// <summary>
        /// Metodo que devuelve TODAS las Categorias existentes
        /// </summary>
        /// <param name="Categoria"></param>
        /// <returns></returns>
        public List<Entity.CategoriaInfo> GetCategorias()
        {
            return CategoriaDAL.FindBy(new Entity.CategoriaInfo());
        }

        /// <summary>
        /// Aplica un filtro sobre una entidad de categoria
        /// </summary>
        /// <param name="CategoriaInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Entity.CategoriaInfo> FindBy(Entity.CategoriaInfo CategoriaInfo)
        {
            if (CategoriaInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Categoria para aplicar el filtro");
            return CategoriaDAL.FindBy(CategoriaInfo);
        }

        /// <summary>
        /// Metodo para guardar datos de una categoria, insertar o actualizar
        /// </summary>
        /// <param name="CategoriaInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Save(Entity.CategoriaInfo CategoriaInfo)
        {
            if (CategoriaInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Categoria para aplicar el filtro");
            if (CategoriaInfo.Id == 0)
                return CategoriaDAL.Insert(CategoriaInfo);
            else
                return CategoriaDAL.Update(CategoriaInfo);
        }

        /// <summary>
        /// Metodo para eliminar una categoria a traves de su Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            CategoriaDAL.Delete(Id);
            return true;
        }

        
        #endregion
    }
}
