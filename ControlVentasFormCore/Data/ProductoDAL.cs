using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Data
{
    public class ProductoDAL
    {
        #region Global Variables
        public const string BookName = "BookProductos";
        public const string TableName = "dbENC79";

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
        public Entity.ProductoInfo GetEntityObject(int Id)
        {
            string SQL = $"select * from {TableName} where {Entity.ProductoInfo.FieldName.Id} = {Id}";
            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(SQL, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) throw new Exception($"No pude obtener los datos del Id [{Id}]");

            return GetEntityObject(dt.Rows[0]);
        }

        /// <summary>
        /// Devulve un objeto entidad con los datos recibidos en el row
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>
        public Entity.ProductoInfo GetEntityObject(DataRow Row)
        {
            if (Row == null) throw new ArgumentNullException("No recibimos el datarow para obtener los datos");

            Entity.ProductoInfo ProductoInfo = new Entity.ProductoInfo();
            ProductoInfo.Id = Convert.ToInt32(Row[Entity.ProductoInfo.FieldName.Id]);
            ProductoInfo.Nombre = Row[Entity.ProductoInfo.FieldName.Nombre].ToString();
            ProductoInfo.Descripcion = Row[Entity.ProductoInfo.FieldName.Descripcion].ToString();
            ProductoInfo.Precio = Convert.ToDecimal(Row[Entity.ProductoInfo.FieldName.Precio].ToString());
            ProductoInfo.CategoriaId = Convert.ToInt32(Row[Entity.ProductoInfo.FieldName.CategoriaId]);

            return ProductoInfo;
        }

        /// <summary>
        /// inserta el objeto entidad especificado en la BD
        /// </summary>
        /// <param name="ProductoInfo"></param>
        /// <returns></returns>
        public int Insert(Entity.ProductoInfo ProductoInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("declare @Id int");
            sb.AppendLine($"select @Id = fol_act from dbconf_Bloq where des_bloq = '{BookName}'");
            sb.AppendLine($"insert into {TableName} (NUM_DOC,");
            sb.Append(Entity.ProductoInfo.FieldName.Nombre);
            sb.Append($", {Entity.ProductoInfo.FieldName.Descripcion}");
            sb.Append($", {Entity.ProductoInfo.FieldName.Precio}");
            sb.Append($", {Entity.ProductoInfo.FieldName.CategoriaId}");
            sb.AppendLine(")");
            sb.AppendLine("values(@Id,");
            sb.Append($"'{ProductoInfo.Nombre}'");
            sb.Append($",'{ProductoInfo.Descripcion}'");
            sb.Append($",'{ProductoInfo.Precio}'");
            sb.Append($",'{ProductoInfo.CategoriaId}'");
            sb.AppendLine(")");
            sb.AppendLine("select SCOPE_IDENTITY()");
            sb.AppendLine($"update dbconf_bloq set fol_act = fol_act + 1 where des_bloq = {BookName}");

            object Id = SOLTUM.Framework.Utilities.SQLHelper.ExecuteScalar(sb.ToString(), ConnectionString);
            if (Id == null) return 0;
            return Convert.ToInt32(Id);
        }

        /// <summary>
        /// actualiza el objetoe entidad especificad
        /// </summary>
        /// <param name="ProductoInfo"></param>
        /// <returns></returns>
        public int Update(Entity.ProductoInfo ProductoInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"update {TableName} set");
            sb.Append($"{Entity.ProductoInfo.FieldName.Nombre} = '{ProductoInfo.Nombre}'");
            sb.Append($",{Entity.ProductoInfo.FieldName.Descripcion} = '{ProductoInfo.Descripcion}'");
            sb.Append($",{Entity.ProductoInfo.FieldName.Precio} = '{ProductoInfo.Precio}'");
            sb.Append($",{Entity.ProductoInfo.FieldName.CategoriaId} = '{ProductoInfo.CategoriaId}'");
            sb.Append($" where {Entity.ProductoInfo.FieldName.Id} = {ProductoInfo.Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return ProductoInfo.Id;
        }

        /// <summary>
        /// borra el objeto entidad con el id especificado
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(int Id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"update {TableName} set NUM_DOC = NUM_DOC * (-1)");
            sb.Append($" where {Entity.ProductoInfo.FieldName.Id} = {Id}");

            Utilerias.SQLHelper.ExecuteNonQuery(sb.ToString(), ConnectionString);
            return Id;
        }

        /// <summary>
        /// Devulve una lista de objetos entidad que cumplen las condiciones modificadas en el objeto entidad especificado
        /// </summary>
        /// <param name="Producto"></param>
        /// <returns></returns>
        public List<Entity.ProductoInfo> FindBy(Entity.ProductoInfo Producto)
        {
            string Filter = string.Empty;

            //generamos un nuevo objeto para poder comparar y detectar variaciones
            Entity.ProductoInfo nProducto = new Entity.ProductoInfo();
            if (string.Compare(Producto.Nombre, nProducto.Nombre, true) != 0)
                Filter += $" and {Entity.ProductoInfo.FieldName.Nombre} = '{Producto.Nombre}'";
            if (string.Compare(Producto.Descripcion, nProducto.Descripcion, true) != 0)
                Filter += $" and {Entity.ProductoInfo.FieldName.Descripcion} = '{Producto.Descripcion}'";
            if (Producto.Precio != nProducto.Precio)
                Filter += $" and {Entity.ProductoInfo.FieldName.Precio} = '{Producto.Precio}'";
            if (Producto.CategoriaId != nProducto.CategoriaId)
                Filter += $" and {Entity.ProductoInfo.FieldName.CategoriaId} = '{Producto.CategoriaId}'";

            // generamos una sentencia sql con el filtro dinamico...
            string sql = $"select * from {TableName} where {Entity.ProductoInfo.FieldName.Id} > 0 " + Filter;

            DataTable dt = Utilerias.SQLHelper.ExecuteDatatable(sql, ConnectionString);

            if (dt == null || dt.Rows.Count == 0) return null;

            //generamos un ciclo por cada registro que devolvio la consulta y llenamos la lista
            List<Entity.ProductoInfo> ProductosInfo = new List<Entity.ProductoInfo>();
            foreach (DataRow Row in dt.Rows)
                ProductosInfo.Add(GetEntityObject(Row));

            return ProductosInfo;
        }
        #endregion
    }
}
