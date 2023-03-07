using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class MesaDAL
    {
        #region Global Variables
        public const string TableName = "Mesas";

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
        public Entity.MesaInfo GetEntityObject(int Id)
        {
            string SQL = $"select * from {TableName} where {Entity.MesaInfo.FieldName.Id} = {Id}";
            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(SQL, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) throw new Exception($"No pude obtener los datos del Id [{Id}]");

            return GetEntityObject(dt.Rows[0]);
        }

        /// <summary>
        /// Devulve un objeto entidad con los datos recibidos en el row
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>
        public Entity.MesaInfo GetEntityObject(DataRow Row)
        {
            if (Row == null) throw new ArgumentNullException("No recibimos el datarow para obtener los datos");

            Entity.MesaInfo MesaInfo = new Entity.MesaInfo();
            MesaInfo.Id = Convert.ToInt32(Row[Entity.MesaInfo.FieldName.Id]);
            MesaInfo.OrdenFolio = Convert.ToInt32(Row[Entity.MesaInfo.FieldName.OrdenFolio]);
            MesaInfo.StatusId = Convert.ToInt32(Row[Entity.MesaInfo.FieldName.StatusId]);
            

            return MesaInfo;
        }

        /// <summary>
        /// inserta el objeto entidad especificado en la BD
        /// </summary>
        /// <param name="MesaInfo"></param>
        /// <returns></returns>
        public int Insert(Entity.MesaInfo MesaInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"insert into {TableName} (");
            sb.Append(Entity.MesaInfo.FieldName.OrdenFolio);
            sb.Append($", {Entity.MesaInfo.FieldName.StatusId}");
            sb.AppendLine(")");
            sb.AppendLine("values(");
            sb.Append($"'{MesaInfo.OrdenFolio}'");
            sb.Append($",'{MesaInfo.StatusId}'");
            sb.AppendLine(")");
            sb.AppendLine("select SCOPE_IDENTITY()");

            object Id = Utilerias.SQLHelper.ExecuteScalar(sb.ToString(), ConnectionString);
            if (Id == null) return 0;
            return Convert.ToInt32(Id);
        }

        /// <summary>
        /// actualiza el objetoe entidad especificad
        /// </summary>
        /// <param name="MesaInfo"></param>
        /// <returns></returns>
        public int Update(Entity.MesaInfo MesaInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"update {TableName} set");
            sb.Append($"{Entity.MesaInfo.FieldName.OrdenFolio} = '{MesaInfo.OrdenFolio}'");
            sb.Append($",{Entity.MesaInfo.FieldName.StatusId} = '{MesaInfo.StatusId}'");
            sb.Append($" where {Entity.MesaInfo.FieldName.Id} = {MesaInfo.Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return MesaInfo.Id;
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
            sb.Append($" where {Entity.MesaInfo.FieldName.Id} = {Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return Id;
        }

        /// <summary>
        /// Devulve una lista de objetos entidad que cumplen las condiciones modificadas en el objeto entidad especificado
        /// </summary>
        /// <param name="Mesa"></param>
        /// <returns></returns>
        public List<Entity.MesaInfo> FindBy(Entity.MesaInfo Mesa)
        {
            string Filter = string.Empty;

            //generamos un nuevo objeto para poder comparar y detectar variaciones
            Entity.MesaInfo nMesa = new Entity.MesaInfo();
            if (Mesa.OrdenFolio != nMesa.OrdenFolio)
                Filter += $" and {Entity.MesaInfo.FieldName.OrdenFolio} = '{Mesa.OrdenFolio}'";
            if (Mesa.StatusId != nMesa.StatusId)
                Filter += $" and {Entity.MesaInfo.FieldName.StatusId} = '{Mesa.StatusId}'";

            // generamos una sentencia sql con el filtro dinamico...
            string sql = $"select * from {TableName} where {Entity.MesaInfo.FieldName.Id} > 0 " + Filter;

            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(sql, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) return null;

            //generamos un ciclo por cada registro que devolvio la consulta y llenamos la lista
            List<Entity.MesaInfo> MesasInfo = new List<Entity.MesaInfo>();
            foreach (DataRow Row in dt.Rows)
                MesasInfo.Add(GetEntityObject(Row));

            return MesasInfo;
        }
        #endregion
    }
}
