using SOLTUM.Framework.Core;
using SOLTUM.Framework.Utilities.BackgroundTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasFormCore.Business
{
    public class VerificacionTablasBAL : SOLTUM.Framework.Business.VerificaTablasBAL
    {
        #region Properties...
        private BackgroundCallBack Callback;
        public override string ConnectionString { get ; set ; }
        #endregion
        #region Methods...
        public override string GetAssemblyDescription()
        {
            return Properties.Resources.ProgramDescription;
        }

        public override System.Drawing.Image GetAssemblyIcon()
        {
            throw new NotImplementedException();
        }

        public override string GetAssemblyName()
        {
            return Properties.Resources.ProgramName;
        }

        public override string GetAssemblyUrl()
        {
            return "www.soltum.com.mx";
        }

        public override List<BookStructureInfo> GetBookStructures()
        {
            Callback = new BackgroundCallBack();
            List<BookStructureInfo> Books = new List<BookStructureInfo>();

            //Estructura de los productos
            if (Callback != null) Callback.FireEvent(new BackgroundResponseInfo() { StepCustom = "SHOWLOADING" });
            if (Callback != null) Callback.FireEvent(new BackgroundResponseInfo() { StepCustom = "MESSAGETOSPLASH", MssgGral = "Realizando la verificacion de tablas" });
            ProductoBAL ProductoBAL = new ProductoBAL() { ConnectionString = ConnectionString};
            CategoriaBAL CategoriaBAL = new CategoriaBAL() { ConnectionString = ConnectionString };
            MesaBAL MesaBAL = new MesaBAL() { ConnectionString = ConnectionString };
            OrdenBAL OrdenBAL = new OrdenBAL() { ConnectionString = ConnectionString };
            StatusBAL StatusBAL = new StatusBAL() { ConnectionString = ConnectionString };
            Books.Add(ProductoBAL.GetBookStructure(Properties.Resources.ProgramDescription, Properties.Resources.ProgramName));
            Books.Add(CategoriaBAL.GetBookStructure(Properties.Resources.ProgramDescription, Properties.Resources.ProgramName));
            Books.Add(MesaBAL.GetBookStructure(Properties.Resources.ProgramDescription, Properties.Resources.ProgramName));
            Books.Add(OrdenBAL.GetBookStructure(Properties.Resources.ProgramDescription, Properties.Resources.ProgramName));
            Books.Add(StatusBAL.GetBookStructure(Properties.Resources.ProgramDescription, Properties.Resources.ProgramName));
            if (Callback != null) Callback.FireEvent(new BackgroundResponseInfo() { StepCustom = "HIDELOADING" });
            return Books;
        }

        public override bool VerifyDefaultReports()
        {
            return false;
        }

        public override int ExecuteVerificacionDeTablas()
        {
            return base.ExecuteVerificacionDeTablas();

            //ejecutar cualquier otro metodo importante que sirva para construir algo sobre el producto

            return 1;
        }
        #endregion
    }
}
