using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class UsuarioDAL
    {
        #region Global Variables
        public const string TableName = "Usuarios";

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
        public Entity.UsuarioInfo GetEntityObject(int Id)
        {
            string SQL = $"select * from {TableName} where {Entity.UsuarioInfo.FieldName.Id} = {Id}";
            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(SQL, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) throw new Exception($"No pude obtener los datos del Id [{Id}]");

            return GetEntityObject(dt.Rows[0]);
        }

        /// <summary>
        /// Devulve un objeto entidad con los datos recibidos en el row
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>
        public Entity.UsuarioInfo GetEntityObject(DataRow Row)
        {
            if (Row == null) throw new ArgumentNullException("No recibimos el datarow para obtener los datos");

            Entity.UsuarioInfo UsuarioInfo = new Entity.UsuarioInfo();
            UsuarioInfo.Id = Convert.ToInt32(Row[Entity.UsuarioInfo.FieldName.Id]);
            UsuarioInfo.Username = Row[Entity.UsuarioInfo.FieldName.Username].ToString();
            UsuarioInfo.Password = Row[Entity.UsuarioInfo.FieldName.Password].ToString();
            UsuarioInfo.RolId = Convert.ToInt32(Row[Entity.UsuarioInfo.FieldName.Id]);

            return UsuarioInfo;
        }

        /// <summary>
        /// inserta el objeto entidad especificado en la BD
        /// </summary>
        /// <param name="UsuarioInfo"></param>
        /// <returns></returns>
        public int Insert(Entity.UsuarioInfo UsuarioInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"insert into {TableName} (");
            sb.Append(Entity.UsuarioInfo.FieldName.Username);
            sb.Append($", {Entity.UsuarioInfo.FieldName.Password}");
            sb.Append($", {Entity.UsuarioInfo.FieldName.RolId}");
            sb.AppendLine(")");
            sb.AppendLine("values(");
            sb.Append($"'{UsuarioInfo.Username}'");
            sb.Append($",'{UsuarioInfo.Password}'");
            sb.Append($",'{UsuarioInfo.RolId}'");
            sb.AppendLine(")");
            sb.AppendLine("select SCOPE_IDENTITY()");

            object Id = Utilerias.SQLHelper.ExecuteScalar(sb.ToString(), ConnectionString);
            if (Id == null) return 0;
            return Convert.ToInt32(Id);
        }

        /// <summary>
        /// actualiza el objetoe entidad especificad
        /// </summary>
        /// <param name="UsuarioInfo"></param>
        /// <returns></returns>
        public int Update(Entity.UsuarioInfo UsuarioInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"update {TableName} set");
            sb.Append($"{Entity.UsuarioInfo.FieldName.Username} = '{UsuarioInfo.Username}'");
            sb.Append($",{Entity.UsuarioInfo.FieldName.Password} = '{UsuarioInfo.Password}'");
            sb.Append($",{Entity.UsuarioInfo.FieldName.RolId} = '{UsuarioInfo.RolId}'");
            sb.Append($" where {Entity.UsuarioInfo.FieldName.Id} = {UsuarioInfo.Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return UsuarioInfo.Id;
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
            sb.Append($" where {Entity.UsuarioInfo.FieldName.Id} = {Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return Id;
        }

        /// <summary>
        /// Devulve una lista de objetos entidad que cumplen las condiciones modificadas en el objeto entidad especificado
        /// </summary>
        /// <param name="Usuario"></param>
        /// <returns></returns>
        public List<Entity.UsuarioInfo> FindBy(Entity.UsuarioInfo Usuario)
        {
            string Filter = string.Empty;

            //generamos un nuevo objeto para poder comparar y detectar variaciones
            Entity.UsuarioInfo nUsuario = new Entity.UsuarioInfo();
            if (string.Compare(Usuario.Username, nUsuario.Username, true) != 0)
                Filter += $" and {Entity.UsuarioInfo.FieldName.Username} = '{Usuario.Username}'";
            if (string.Compare(Usuario.Password, nUsuario.Password, true) != 0)
                Filter += $" and {Entity.UsuarioInfo.FieldName.Password} = '{Usuario.Password}'";
            if (Usuario.RolId != nUsuario.RolId)
                Filter += $" and {Entity.UsuarioInfo.FieldName.RolId} = '{Usuario.RolId}'";

            // generamos una sentencia sql con el filtro dinamico...
            string sql = $"select * from {TableName} where {Entity.UsuarioInfo.FieldName.Id} > 0 " + Filter;

            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(sql, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) return null;

            //generamos un ciclo por cada registro que devolvio la consulta y llenamos la lista
            List<Entity.UsuarioInfo> UsuariosInfo = new List<Entity.UsuarioInfo>();
            foreach (DataRow Row in dt.Rows)
                UsuariosInfo.Add(GetEntityObject(Row));

            return UsuariosInfo;
        }
        #endregion
    }
}
