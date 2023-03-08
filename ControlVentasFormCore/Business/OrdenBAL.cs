using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class OrdenBAL
    {
        #region Variables Globales...
        public Data.OrdenDAL OrdenDAL;
        #endregion

        #region Constructor...
        public OrdenBAL()
        {
            OrdenDAL = new Data.OrdenDAL();
        }
        #endregion

        #region Properties
        public string ConnectionString
        {
            get { return OrdenDAL.ConnectionString; }
            set { OrdenDAL.ConnectionString = value; }
        }
        #endregion

        #region Methods
        public Entity.OrdenInfo GetOrden(int Id)
        {
            if (Id == 0) throw new ArgumentException("No recibi el id de la orden que desea obtener");
            return OrdenDAL.GetEntityObject(Id);
        }

        /// <summary>
        /// Metodo que devuelve TODAS las ordenes existentes
        /// </summary>
        /// <param name="Orden"></param>
        /// <returns></returns>
        public List<Entity.OrdenInfo> GetOrdenes()
        {
            return OrdenDAL.FindBy(new Entity.OrdenInfo());
        }


        /// <summary>
        /// Aplica un filtro sobre una entidad de orden
        /// </summary>
        /// <param name="OrdenInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Entity.OrdenInfo> FindBy(Entity.OrdenInfo OrdenInfo)
        {
            if (OrdenInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Orden para aplicar el filtro");
            return OrdenDAL.FindBy(OrdenInfo);
        }

        /// <summary>
        /// Metodo para guardar datos de una orden, insertar o actualizar
        /// </summary>
        /// <param name="OrdenInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Save(Entity.OrdenInfo OrdenInfo)
        {
            if (OrdenInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Orden para aplicar el filtro");
            if (OrdenInfo.Folio == 0)
                return OrdenDAL.Insert(OrdenInfo);
            else
                return OrdenDAL.Update(OrdenInfo);
        }

        /// <summary>
        /// Metodo para eliminar una orden a traves de su Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            OrdenDAL.Delete(Id);
            return true;
        }

        #endregion
    }
}
