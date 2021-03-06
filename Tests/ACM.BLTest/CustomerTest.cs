using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        /// <summary>
        /// Tests successful creation and functionality of Full name property
        /// </summary>
        [TestMethod]
        public void FullName_TestValid()
        {
            // Arrange
            Customer customer = new Customer { FirstName = "Ahmed", LastName = "Shaban" };
            string expected = "Shaban, Ahmed";
            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected,actual);
        }
        /* FullName Property - Invalid Cases */
        
        // Case 2
        /// <summary>
        /// Tests Hanlding of Empty FirstName
        /// </summary>
        [TestMethod]
        public void FullName_FirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer { LastName = "Shaban" };
            string expected = "Shaban";
            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Tests Hanlding of Empty LastName
        /// </summary>
        [TestMethod]
        public void FullName_LastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer { FirstName = "Ahmed" };
            string expected = "Ahmed";
            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Tests handling of both empty First and Last names
        /// </summary>
        [TestMethod]
        public void FullName_FirstLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            string expected = "New, User";
            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
