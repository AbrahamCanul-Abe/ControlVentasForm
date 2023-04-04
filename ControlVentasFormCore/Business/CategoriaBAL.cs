using SOLTUM.Framework.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class CategoriaBAL : BookBaseBAL<Entity.CategoriaInfo, Entity.CategoriaInfo.FieldName, Data.CategoriaDAL>
    {
        #region Constructor...
        public CategoriaBAL() : base() 
        {
            Version = "1.0.0.0";
        }
        #endregion

        #region Methods
        public Entity.CategoriaInfo GetCategoria(int Id)
        {
            if (Id == 0) throw new ArgumentException("No recibi el id de la categoria que desea obtener");
            return DataAccessLayer.GetEntityObjects(new List<SOLTUM.Framework.Data.Attributes.Condition>() { new SOLTUM.Framework.Data.Attributes.Condition(Entity.CategoriaInfo.FieldName.Id, "=", Id.ToString()) }).FirstOrDefault(); ;
        }

        /// <summary>
        /// Metodo que devuelve TODAS las Categorias existentes
        /// </summary>
        /// <param name="Categoria"></param>
        /// <returns></returns>
        public List<Entity.CategoriaInfo> GetCategorias()
        {
            //System.Threading.Thread.Sleep(3000);
            return DataAccessLayer.GetEntityObjects(new List<SOLTUM.Framework.Data.Attributes.Condition>()).ToList();
        }

        

        
        #endregion
    }
}
