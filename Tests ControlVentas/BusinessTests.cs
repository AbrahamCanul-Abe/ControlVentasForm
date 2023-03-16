using ControlVentasFormCore.Business;
using ControlVentasFormCore.Data;
using ControlVentasFormCore.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_ControlVentas
{
    [TestClass]
    public class BusinessTests
    {
        #region Variables
        private ProductoBAL ProductoBAL;
        #endregion

        #region Initialize test
        //Instancia de objetos y conexion con la BD
        [TestInitialize]
        public void testInit()
        {
            ProductoBAL = new ProductoBAL();
            ProductoBAL.ConnectionString = "server=LENO\\SQLEXPRESS2; uid=sa; pwd=developer; database=dbRestaurantventas_data";
        }
        #endregion

        #region Methods
        //Test para el metodo Getproducto que recibe un Id
        [TestMethod]
        public void GetProductWithIdAndReturnThatProduct()
        {
            //Arrange
            int Id = 3;

            //Act
            var actual = ProductoBAL.GetProducto(Id);

            //Assert
            Assert.AreEqual(Id, actual.Id);
        }

        //Test para el metodo Getproducto ArgumentNullException
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetProduct_ShouldThrowArgumentNullException()
        {
            //Arrange
            int Id = 0;

            //Act
            var actual = ProductoBAL.GetProducto(Id);

            //Assert
        }

        //Test para el metodo GetProductos evalua que el contador sea igual al numero de productos actuales
        [TestMethod]
        public void GetProductosAndCompareWithTheNumberOfProducts()
        {
            //Arrange
            var numberProducts = 11;

            //Act
            var actual = ProductoBAL.GetProductos();

            //Assert
            Assert.AreEqual(actual.Count, numberProducts);

        }

        //Test para el metodo GetProductos, devuelve todos los productos evalua que no devuelva una lista vacia
        [TestMethod]
        public void GetProductosIsNotNullList()
        {
            //Arrange

            //Act
            var actual = ProductoBAL.GetProductos();

            //Assert
            Assert.IsNotNull(actual);

        }

        //Test para el metodo Save, evalua si es una instancia del tipo correcto y si el Id se guarda correctamente
        [TestMethod]
        public void SaveProductAndCheckTheNewProductIdIsSave()
        {
            //Arrange
            var NewProduct = new ProductoInfo
            {
                Nombre = "Producto de prueba",
                Descripcion = "prueba",
                Precio = 30,
                CategoriaId = 1
            };

            //Act
            var actual = ProductoBAL.Save(NewProduct);

            //Assert
            Assert.IsTrue(actual > 0);
        }

        
        #endregion
    }
}
