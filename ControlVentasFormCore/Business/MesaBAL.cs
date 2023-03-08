using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class MesaBAL
    {
        #region Variables Globales...
        public Data.MesaDAL MesaDAL;
        #endregion

        #region Constructor...
        public MesaBAL()
        {
            MesaDAL = new Data.MesaDAL();
        }
        #endregion

        #region Properties
        public string ConnectionString
        {
            get { return MesaDAL.ConnectionString; }
            set { MesaDAL.ConnectionString = value; }
        }
        #endregion

        #region Methods
        public Entity.MesaInfo GetMesa(int Id)
        {
            if (Id == 0) throw new ArgumentException("No recibi el id del producto que desea obtener");
            return MesaDAL.GetEntityObject(Id);
        }

        /// <summary>
        /// Metodo que devuelve TODOS los productos existentes
        /// </summary>
        /// <param name="Mesa"></param>
        /// <returns></returns>
        public List<Entity.MesaInfo> GetMesas()
        {
            return MesaDAL.FindBy(new Entity.MesaInfo());
        }


        /// <summary>
        /// Aplica un filtro sobre una entidad de producto
        /// </summary>
        /// <param name="MesaInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Entity.MesaInfo> FindBy(Entity.MesaInfo MesaInfo)
        {
            if (MesaInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Producto para aplicar el filtro");
            return MesaDAL.FindBy(MesaInfo);
        }

        /// <summary>
        /// Metodo para guardar datos de un producto, insertar o actualizar
        /// </summary>
        /// <param name="MesaInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Save(Entity.MesaInfo MesaInfo)
        {
            if (MesaInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Producto para aplicar el filtro");
            if (MesaInfo.Id == 0)
                return MesaDAL.Insert(MesaInfo);
            else
                return MesaDAL.Update(MesaInfo);
        }

        /// <summary>
        /// Metodo para eliminar un producto a traves de su Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            MesaDAL.Delete(Id);
            return true;
        }

        
        #endregion
    }
}
