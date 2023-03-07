using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class CategoriaDAL
    {
        #region Global Variables
        public const string TableName = "Categorias";

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
        public Entity.CategoriaInfo GetEntityObject(int Id)
        {
            string SQL = $"select * from {TableName} where {Entity.CategoriaInfo.FieldName.Id} = {Id}";
            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(SQL, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) throw new Exception($"No pude obtener los datos del Id [{Id}]");

            return GetEntityObject(dt.Rows[0]);
        }

        /// <summary>
        /// Devulve un objeto entidad con los datos recibidos en el row
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>
        public Entity.CategoriaInfo GetEntityObject(DataRow Row)
        {
            if (Row == null) throw new ArgumentNullException("No recibimos el datarow para obtener los datos");

            Entity.CategoriaInfo CategoriaInfo = new Entity.CategoriaInfo();
            CategoriaInfo.Id = Convert.ToInt32(Row[Entity.CategoriaInfo.FieldName.Id]);
            CategoriaInfo.Nombre = Row[Entity.CategoriaInfo.FieldName.Nombre].ToString();
            

            return CategoriaInfo;
        }

        /// <summary>
        /// inserta el objeto entidad especificado en la BD
        /// </summary>
        /// <param name="CategoriaInfo"></param>
        /// <returns></returns>
        public int Insert(Entity.CategoriaInfo CategoriaInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"insert into {TableName} (");
            sb.Append(Entity.CategoriaInfo.FieldName.Nombre);
            sb.AppendLine(")");
            sb.AppendLine("values(");
            sb.Append($"'{CategoriaInfo.Nombre}'");
            sb.AppendLine(")");
            sb.AppendLine("select SCOPE_IDENTITY()");

            object Id = Utilerias.SQLHelper.ExecuteScalar(sb.ToString(), ConnectionString);
            if (Id == null) return 0;
            return Convert.ToInt32(Id);
        }

        /// <summary>
        /// actualiza el objetoe entidad especificad
        /// </summary>
        /// <param name="CategoriaInfo"></param>
        /// <returns></returns>
        public int Update(Entity.CategoriaInfo CategoriaInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"update {TableName} set");
            sb.Append($"{Entity.CategoriaInfo.FieldName.Nombre} = '{CategoriaInfo.Nombre}'");
            sb.Append($" where {Entity.CategoriaInfo.FieldName.Id} = {CategoriaInfo.Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return CategoriaInfo.Id;
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
            sb.Append($" where {Entity.CategoriaInfo.FieldName.Id} = {Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return Id;
        }

        /// <summary>
        /// Devulve una lista de objetos entidad que cumplen las condiciones modificadas en el objeto entidad especificado
        /// </summary>
        /// <param name="Categoria"></param>
        /// <returns></returns>
        public List<Entity.CategoriaInfo> FindBy(Entity.CategoriaInfo Categoria)
        {
            string Filter = string.Empty;

            //generamos un nuevo objeto para poder comparar y detectar variaciones
            Entity.CategoriaInfo nCategoria = new Entity.CategoriaInfo();
            if (string.Compare(Categoria.Nombre, nCategoria.Nombre, true) != 0)
                Filter += $" and {Entity.CategoriaInfo.FieldName.Nombre} = '{Categoria.Nombre}'";

            // generamos una sentencia sql con el filtro dinamico...
            string sql = $"select * from {TableName} where {Entity.CategoriaInfo.FieldName.Id} > 0 " + Filter;

            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(sql, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) return null;

            //generamos un ciclo por cada registro que devolvio la consulta y llenamos la lista
            List<Entity.CategoriaInfo> CategoriasInfo = new List<Entity.CategoriaInfo>();
            foreach (DataRow Row in dt.Rows)
                CategoriasInfo.Add(GetEntityObject(Row));

            return CategoriasInfo;
        }
        #endregion
    }
}
