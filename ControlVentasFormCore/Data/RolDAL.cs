using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class RolDAL
    {
        #region Global Variables
        public const string TableName = "Roles";

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
        public Entity.RolInfo GetEntityObject(int Id)
        {
            string SQL = $"select * from {TableName} where {Entity.RolInfo.FieldName.Id} = {Id}";
            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(SQL, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) throw new Exception($"No pude obtener los datos del Id [{Id}]");

            return GetEntityObject(dt.Rows[0]);
        }

        /// <summary>
        /// Devulve un objeto entidad con los datos recibidos en el row
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>
        public Entity.RolInfo GetEntityObject(DataRow Row)
        {
            if (Row == null) throw new ArgumentNullException("No recibimos el datarow para obtener los datos");

            Entity.RolInfo RolInfo = new Entity.RolInfo();
            RolInfo.Id = Convert.ToInt32(Row[Entity.RolInfo.FieldName.Id]);
            RolInfo.Tipo = Row[Entity.RolInfo.FieldName.Tipo].ToString();

            return RolInfo;
        }

        /// <summary>
        /// inserta el objeto entidad especificado en la BD
        /// </summary>
        /// <param name="RolInfo"></param>
        /// <returns></returns>
        public int Insert(Entity.RolInfo RolInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"insert into {TableName} (");
            sb.Append(Entity.RolInfo.FieldName.Tipo);
            sb.AppendLine(")");
            sb.AppendLine("values(");
            sb.Append($"'{RolInfo.Tipo}'");
            sb.AppendLine(")");
            sb.AppendLine("select SCOPE_IDENTITY()");

            object Id = Utilerias.SQLHelper.ExecuteScalar(sb.ToString(), ConnectionString);
            if (Id == null) return 0;
            return Convert.ToInt32(Id);
        }

        /// <summary>
        /// actualiza el objetoe entidad especificad
        /// </summary>
        /// <param name="RolInfo"></param>
        /// <returns></returns>
        public int Update(Entity.RolInfo RolInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"update {TableName} set");
            sb.Append($"{Entity.RolInfo.FieldName.Tipo} = '{RolInfo.Tipo}'");
            sb.Append($" where {Entity.RolInfo.FieldName.Id} = {RolInfo.Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return RolInfo.Id;
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
            sb.Append($" where {Entity.RolInfo.FieldName.Id} = {Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return Id;
        }

        /// <summary>
        /// Devulve una lista de objetos entidad que cumplen las condiciones modificadas en el objeto entidad especificado
        /// </summary>
        /// <param name="Rol"></param>
        /// <returns></returns>
        public List<Entity.RolInfo> FindBy(Entity.RolInfo Rol)
        {
            string Filter = string.Empty;

            //generamos un nuevo objeto para poder comparar y detectar variaciones
            Entity.RolInfo nRol = new Entity.RolInfo();
            if (string.Compare(Rol.Tipo, nRol.Tipo, true) != 0)
                Filter += $" and {Entity.RolInfo.FieldName.Tipo} = '{Rol.Tipo}'";

            // generamos una sentencia sql con el filtro dinamico...
            string sql = $"select * from {TableName} where {Entity.RolInfo.FieldName.Id} > 0 " + Filter;

            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(sql, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) return null;

            //generamos un ciclo por cada registro que devolvio la consulta y llenamos la lista
            List<Entity.RolInfo> RolesInfo = new List<Entity.RolInfo>();
            foreach (DataRow Row in dt.Rows)
                RolesInfo.Add(GetEntityObject(Row));

            return RolesInfo;
        }
        #endregion
    }
}
