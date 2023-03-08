using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class StatusBAL
    {
        #region Variables Globales...
        public Data.StatusDAL StatusDAL;
        #endregion

        #region Constructor...
        public StatusBAL()
        {
            StatusDAL = new Data.StatusDAL();
        }
        #endregion

        #region Properties
        public string ConnectionString
        {
            get { return StatusDAL.ConnectionString; }
            set { StatusDAL.ConnectionString = value; }
        }
        #endregion

        #region Methods
        public Entity.StatusInfo GetStatus(int Id)
        {
            if (Id == 0) throw new ArgumentException("No recibi el id del Status que desea obtener");
            return StatusDAL.GetEntityObject(Id);
        }

        /// <summary>
        /// Metodo que devuelve TODOS los status existentes
        /// </summary>
        /// <param name="Status"></param>
        /// <returns></returns>
        public List<Entity.StatusInfo> GetStatuss()
        {
            return StatusDAL.FindBy(new Entity.StatusInfo());
        }

        /// <summary>
        /// Aplica un filtro sobre una entidad de producto
        /// </summary>
        /// <param name="StatusInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Entity.StatusInfo> FindBy(Entity.StatusInfo StatusInfo)
        {
            if (StatusInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Status para aplicar el filtro");
            return StatusDAL.FindBy(StatusInfo);
        }

        /// <summary>
        /// Metodo para guardar datos de un status, insertar o actualizar
        /// </summary>
        /// <param name="StatusInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Save(Entity.StatusInfo StatusInfo)
        {
            if (StatusInfo == null) throw new ArgumentNullException("No recibi un objeto entidad Status para aplicar el filtro");
            if (StatusInfo.Id == 0)
                return StatusDAL.Insert(StatusInfo);
            else
                return StatusDAL.Update(StatusInfo);
        }

        /// <summary>
        /// Metodo para eliminar un status a traves de su Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            StatusDAL.Delete(Id);
            return true;
        }
        #endregion
    }
}
