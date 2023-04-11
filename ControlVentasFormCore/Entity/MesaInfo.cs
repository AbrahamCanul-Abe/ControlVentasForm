using SOLTUM.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Entity
{
    public class MesaInfo : IEntity
    {
        #region Database FieldNames
        public class FieldName
        {
            public const string Id = "NUM_DOC";

            [Field(OrdenFolio, "OrdenFolio", FieldAttribute.eFieldType.Numero)]
            public const string OrdenFolio = "OrdenFolio";

            [Field(StatusId, "StatusId", FieldAttribute.eFieldType.Numero)]
            public const string StatusId = "StatusId";
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public int OrdenFolio { get; set; }
        public int StatusId { get; set; }
        #endregion
    }
}
