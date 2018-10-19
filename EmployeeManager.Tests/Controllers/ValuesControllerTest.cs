//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Web.Http;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using EmployeeManager;
//using EmployeeManager.Controllers;
//using EmployeeManager.IoCContainerConfig;
//using Autofac;

//namespace EmployeeManager.Tests.Controllers
//{
//    [TestClass]
//    public class ValuesControllerTest
//    {
//        [TestMethod]
//        public void Get()
//        {
//            // Arrange
//            EmployeesController controller = IoCContainer.Container.Resolve<EmployeesController>(); //new EmployeesController();

//            // Act
//            IEnumerable<string> result = controller.Get();

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.AreEqual(2, result.Count());
//            Assert.AreEqual("value1", result.ElementAt(0));
//            Assert.AreEqual("value2", result.ElementAt(1));
//        }

//        [TestMethod]
//        public void GetById()
//        {
//            // Arrange
//            EmployeesController controller = new EmployeesController();

//            // Act
//            string result = controller.Get(5);

//            // Assert
//            Assert.AreEqual("value", result);
//        }

//        [TestMethod]
//        public void Post()
//        {
//            // Arrange
//            EmployeesController controller = new EmployeesController();

//            // Act
//            controller.Post("value");

//            // Assert
//        }

//        [TestMethod]
//        public void Put()
//        {
//            // Arrange
//            EmployeesController controller = new EmployeesController();

//            // Act
//            controller.Put(5, "value");

//            // Assert
//        }

//        [TestMethod]
//        public void Delete()
//        {
//            // Arrange
//            EmployeesController controller = new EmployeesController();

//            // Act
//            controller.Delete(5);

//            // Assert
//        }
//    }
//}
