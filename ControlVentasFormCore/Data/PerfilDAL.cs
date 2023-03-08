using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class PerfilDAL
    {
        #region Global Variables
        public const string TableName = "Perfiles";

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
        public Entity.PerfilInfo GetEntityObject(int Id)
        {
            string SQL = $"select * from {TableName} where {Entity.PerfilInfo.FieldName.Id} = {Id}";
            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(SQL, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) throw new Exception($"No pude obtener los datos del Id [{Id}]");

            return GetEntityObject(dt.Rows[0]);
        }

        /// <summary>
        /// Devulve un objeto entidad con los datos recibidos en el row
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>
        public Entity.PerfilInfo GetEntityObject(DataRow Row)
        {
            if (Row == null) throw new ArgumentNullException("No recibimos el datarow para obtener los datos");

            Entity.PerfilInfo PerfilInfo = new Entity.PerfilInfo();
            PerfilInfo.Id = Convert.ToInt32(Row[Entity.PerfilInfo.FieldName.Id]);
            PerfilInfo.Nombre = Row[Entity.PerfilInfo.FieldName.Nombre].ToString();
            PerfilInfo.Apellido = Row[Entity.PerfilInfo.FieldName.Apellido].ToString();
            PerfilInfo.Cargo = Row[Entity.PerfilInfo.FieldName.Cargo].ToString();
            PerfilInfo.UsuarioId = Convert.ToInt32(Row[Entity.PerfilInfo.FieldName.UsuarioId]);

            return PerfilInfo;
        }

        /// <summary>
        /// inserta el objeto entidad especificado en la BD
        /// </summary>
        /// <param name="PerfilInfo"></param>
        /// <returns></returns>
        public int Insert(Entity.PerfilInfo PerfilInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"insert into {TableName} (");
            sb.Append(Entity.PerfilInfo.FieldName.Nombre);
            sb.Append($", {Entity.PerfilInfo.FieldName.Apellido}");
            sb.Append($", {Entity.PerfilInfo.FieldName.Cargo}");
            sb.Append($", {Entity.PerfilInfo.FieldName.UsuarioId}");
            sb.AppendLine(")");
            sb.AppendLine("values(");
            sb.Append($"'{PerfilInfo.Nombre}'");
            sb.Append($",'{PerfilInfo.Apellido}'");
            sb.Append($",'{PerfilInfo.Cargo}'");
            sb.Append($",'{PerfilInfo.UsuarioId}'");
            sb.AppendLine(")");
            sb.AppendLine("select SCOPE_IDENTITY()");

            object Id = Utilerias.SQLHelper.ExecuteScalar(sb.ToString(), ConnectionString);
            if (Id == null) return 0;
            return Convert.ToInt32(Id);
        }

        /// <summary>
        /// actualiza el objetoe entidad especificad
        /// </summary>
        /// <param name="PerfilInfo"></param>
        /// <returns></returns>
        public int Update(Entity.PerfilInfo PerfilInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"update {TableName} set");
            sb.Append($"{Entity.PerfilInfo.FieldName.Nombre} = '{PerfilInfo.Nombre}'");
            sb.Append($",{Entity.PerfilInfo.FieldName.Apellido} = '{PerfilInfo.Apellido}'");
            sb.Append($",{Entity.PerfilInfo.FieldName.Cargo} = '{PerfilInfo.Cargo}'");
            sb.Append($",{Entity.PerfilInfo.FieldName.UsuarioId} = '{PerfilInfo.UsuarioId}'");
            sb.Append($" where {Entity.PerfilInfo.FieldName.Id} = {PerfilInfo.Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return PerfilInfo.Id;
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
            sb.Append($" where {Entity.PerfilInfo.FieldName.Id} = {Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return Id;
        }

        /// <summary>
        /// Devulve una lista de objetos entidad que cumplen las condiciones modificadas en el objeto entidad especificado
        /// </summary>
        /// <param name="Perfil"></param>
        /// <returns></returns>
        public List<Entity.PerfilInfo> FindBy(Entity.PerfilInfo Perfil)
        {
            string Filter = string.Empty;

            //generamos un nuevo objeto para poder comparar y detectar variaciones
            Entity.PerfilInfo nPerfil = new Entity.PerfilInfo();
            if (string.Compare(Perfil.Nombre, nPerfil.Nombre, true) != 0)
                Filter += $" and {Entity.PerfilInfo.FieldName.Nombre} = '{Perfil.Nombre}'";
            if (string.Compare(Perfil.Apellido, nPerfil.Apellido, true) != 0)
                Filter += $" and {Entity.PerfilInfo.FieldName.Apellido} = '{Perfil.Apellido}'";
            if (string.Compare(Perfil.Cargo, nPerfil.Cargo, true) != 0)
                Filter += $" and {Entity.PerfilInfo.FieldName.Cargo} = '{Perfil.Cargo}'";
            if (Perfil.UsuarioId != nPerfil.UsuarioId)
                Filter += $" and {Entity.PerfilInfo.FieldName.UsuarioId} = '{Perfil.UsuarioId}'";

            // generamos una sentencia sql con el filtro dinamico...
            string sql = $"select * from {TableName} where {Entity.PerfilInfo.FieldName.Id} > 0 " + Filter;

            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(sql, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) return null;

            //generamos un ciclo por cada registro que devolvio la consulta y llenamos la lista
            List<Entity.PerfilInfo> PerfilInfo = new List<Entity.PerfilInfo>();
            foreach (DataRow Row in dt.Rows)
                PerfilInfo.Add(GetEntityObject(Row));

            return PerfilInfo;
        }
        #endregion
    }
}
