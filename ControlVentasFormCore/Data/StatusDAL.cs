using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class StatusDAL
    {

        #region Global Variables
        public const string TableName = "Status";

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
        /// <param name="Id"></param>
        /// <returns></returns>
        public Entity.StatusInfo GetEntityObject(int Id)
        {
            string SQL = $"select * from {TableName} where {Entity.StatusInfo.FieldName.Id} = {Id}";
            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(SQL, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) throw new Exception($"No pude obtener los datos del Id [{Id}]");

            return GetEntityObject(dt.Rows[0]);
        }

        /// <summary>
        /// Devulve un objeto entidad con los datos recibidos en el row
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>
        public Entity.StatusInfo GetEntityObject(DataRow Row)
        {
            if (Row == null) throw new ArgumentNullException("No recibimos el datarow para obtener los datos");

            Entity.StatusInfo StatusInfo = new Entity.StatusInfo();
            StatusInfo.Id = Convert.ToInt32(Row[Entity.StatusInfo.FieldName.Id]);
            StatusInfo.Descripcion = Row[Entity.StatusInfo.FieldName.Descripcion].ToString();

            return StatusInfo;
        }

        /// <summary>
        /// inserta el objeto entidad especificado en la BD
        /// </summary>
        /// <param name="StatusInfo"></param>
        /// <returns></returns>
        public int Insert(Entity.StatusInfo StatusInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"insert into {TableName} (");
            sb.Append(Entity.StatusInfo.FieldName.Descripcion);
            sb.AppendLine(")");
            sb.AppendLine("values(");
            sb.Append($"'{StatusInfo.Descripcion}'");
            sb.AppendLine(")");
            sb.AppendLine("select SCOPE_IDENTITY()");

            object Id = Utilerias.SQLHelper.ExecuteScalar(sb.ToString(), ConnectionString);
            if (Id == null) return 0;
            return Convert.ToInt32(Id);
        }

        /// <summary>
        /// actualiza el objetoe entidad especificad
        /// </summary>
        /// <param name="StatusInfo"></param>
        /// <returns></returns>
        public int Update(Entity.StatusInfo StatusInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"update {TableName} set");
            sb.Append($"{Entity.StatusInfo.FieldName.Descripcion} = '{StatusInfo.Descripcion}'");
            sb.Append($" where {Entity.StatusInfo.FieldName.Id} = {StatusInfo.Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return StatusInfo.Id;
        }

        /// <summary>
        /// borra el objeto entidad con el id especificado
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(int Id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"delete {TableName}");
            sb.Append($" where {Entity.StatusInfo.FieldName.Id} = {Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return Id;
        }

        /// <summary>
        /// Devulve una lista de objetos entidad que cumplen las condiciones modificadas en el objeto entidad especificado
        /// </summary>
        /// <param name="Producto"></param>
        /// <returns></returns>
        public List<Entity.StatusInfo> FindBy(Entity.StatusInfo Status)
        {
            string Filter = string.Empty;

            //generamos un nuevo objeto para poder comparar y detectar variaciones
            Entity.StatusInfo nStatus = new Entity.StatusInfo();
            if (string.Compare(Status.Descripcion, nStatus.Descripcion, true) != 0)
                Filter += $" and {Entity.StatusInfo.FieldName.Descripcion} = '{Status.Descripcion}'";
            
            // generamos una sentencia sql con el filtro dinamico...
            string sql = $"select * from {TableName} where {Entity.StatusInfo.FieldName.Id} > 0 " + Filter;

            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(sql, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) return null;

            //generamos un ciclo por cada registro que devolvio la consulta y llenamos la lista
            List<Entity.StatusInfo> StatussInfo = new List<Entity.StatusInfo>();
            foreach (DataRow Row in dt.Rows)
                StatussInfo.Add(GetEntityObject(Row));

            return StatussInfo;
        }
        #endregion
    }
}
