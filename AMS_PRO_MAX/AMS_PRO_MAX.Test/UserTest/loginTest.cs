using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AMS_PRO_MAX.Test.loginTest
{
    [TestClass]
    public class loginTest
    {
        [TestMethod]
        public void CheckLogin_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            var login = new Login(); 
            login.txt_username.Text = "valid_username";
            login.txt_pass.Text = "valid_password";

            // Act
            var result = login.Checklogin();

            // Assert
            Assert.IsTrue(result);
            
        }

        [TestMethod]
        public void CheckLogin_EmptyFields_ReturnsFalse()
        {
            // Arrange
            var login = new Login(); 
            login.txt_username.Text = "";
            login.txt_pass.Text = "";

            // Act
            var result = login.Checklogin();

            // Assert
            Assert.IsFalse(result);
        }

    }
}
