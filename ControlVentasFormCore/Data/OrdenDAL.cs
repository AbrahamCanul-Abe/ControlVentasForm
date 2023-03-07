using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class OrdenDAL
    {
        #region Global Variables
        public const string TableName = "Ordenes";

        #endregion

        #region Properties
        /// <summary>
        /// String de conexion a la bd
        /// </summary>
        public string ConnectionString { get; set; }

        #endregion

        #region Methods 

        /// <summary>
        /// devuelve un objeto entidad del id solicitado
        /// </summary>
        /// <param name="Folio"></param>
        /// <returns></returns>
        public Entity.OrdenInfo GetEntityObject(int Folio)
        {
            string SQL = $"select * from {TableName} where {Entity.OrdenInfo.FieldName.Folio} = {Folio}";
            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(SQL, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) throw new Exception($"No pude obtener los datos del Id [{Folio}]");

            return GetEntityObject(dt.Rows[0]);
        }

        /// <summary>
        /// Devulve un objeto entidad con los datos recibidos en el row
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>
        public Entity.OrdenInfo GetEntityObject(DataRow Row)
        {
            if (Row == null) throw new ArgumentNullException("No recibimos el datarow para obtener los datos");

            Entity.OrdenInfo OrdenInfo = new Entity.OrdenInfo();
            OrdenInfo.Folio = Convert.ToInt32(Row[Entity.OrdenInfo.FieldName.Folio]);
            OrdenInfo.Fecha = Convert.ToDateTime(Row[Entity.OrdenInfo.FieldName.Fecha].ToString());
            OrdenInfo.Total = Convert.ToDecimal(Row[Entity.OrdenInfo.FieldName.Total].ToString());
            OrdenInfo.PerfilId = Convert.ToInt32(Row[Entity.OrdenInfo.FieldName.PerfilId]);
            

            return OrdenInfo;
        }

        /// <summary>
        /// inserta el objeto entidad especificado en la BD
        /// </summary>
        /// <param name="OrdenInfo"></param>
        /// <returns></returns>
        public int Insert(Entity.OrdenInfo OrdenInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"insert into {TableName} (");
            sb.Append(Entity.OrdenInfo.FieldName.Fecha);
            sb.Append($", {Entity.OrdenInfo.FieldName.Total}");
            sb.Append($", {Entity.OrdenInfo.FieldName.PerfilId}");
            sb.AppendLine(")");
            sb.AppendLine("values(");
            sb.Append($"'{OrdenInfo.Fecha}'");
            sb.Append($",'{OrdenInfo.Total}'");
            sb.Append($",'{OrdenInfo.PerfilId}'");
            sb.AppendLine(")");
            sb.AppendLine("select SCOPE_IDENTITY()");

            object Id = Utilerias.SQLHelper.ExecuteScalar(sb.ToString(), ConnectionString);
            if (Id == null) return 0;
            return Convert.ToInt32(Id);
        }

        /// <summary>
        /// actualiza el objetoe entidad especificad
        /// </summary>
        /// <param name="OrdenInfo"></param>
        /// <returns></returns>
        public int Update(Entity.OrdenInfo OrdenInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"update {TableName} set");
            sb.Append($"{Entity.OrdenInfo.FieldName.Fecha} = '{OrdenInfo.Fecha}'");
            sb.Append($",{Entity.OrdenInfo.FieldName.Total} = '{OrdenInfo.Total}'");
            sb.Append($",{Entity.OrdenInfo.FieldName.PerfilId} = '{OrdenInfo.PerfilId}'");
            sb.Append($" where {Entity.OrdenInfo.FieldName.Folio} = {OrdenInfo.Folio}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return OrdenInfo.Folio;
        }

        /// <summary>
        /// borra el objeto entidad con el id especificado
        /// </summary>
        /// <param name="Folio"></param>
        /// <returns></returns>
        public int Delete(int Folio)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"delete {TableName}");
            sb.Append($" where {Entity.OrdenInfo.FieldName.Folio} = {Folio}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return Folio;
        }

        /// <summary>
        /// Devulve una lista de objetos entidad que cumplen las condiciones modificadas en el objeto entidad especificado
        /// </summary>
        /// <param name="Orden"></param>
        /// <returns></returns>
        public List<Entity.OrdenInfo> FindBy(Entity.OrdenInfo Orden)
        {
            string Filter = string.Empty;

            //generamos un nuevo objeto para poder comparar y detectar variaciones
            Entity.OrdenInfo nOrden = new Entity.OrdenInfo();
            if (Orden.Fecha != nOrden.Fecha) 
                Filter += $" and {Entity.OrdenInfo.FieldName.Fecha} = '{Orden.Fecha}'";
            if (Orden.Total != Orden.Total)
                Filter += $" and {Entity.OrdenInfo.FieldName.Total} = '{Orden.Total}'";
            if (Orden.PerfilId != nOrden.PerfilId)
                Filter += $" and {Entity.OrdenInfo.FieldName.PerfilId} = '{Orden.PerfilId}'";

            // generamos una sentencia sql con el filtro dinamico...
            string sql = $"select * from {TableName} where {Entity.OrdenInfo.FieldName.Folio} > 0 " + Filter;

            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(sql, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) return null;

            //generamos un ciclo por cada registro que devolvio la consulta y llenamos la lista
            List<Entity.OrdenInfo> OrdenesInfo = new List<Entity.OrdenInfo>();
            foreach (DataRow Row in dt.Rows)
                OrdenesInfo.Add(GetEntityObject(Row));

            return OrdenesInfo;
        }
        #endregion
    }
}
