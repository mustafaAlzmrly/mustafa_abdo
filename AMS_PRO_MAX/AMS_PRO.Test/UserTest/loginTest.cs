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
        public void TestAddNewItem_WithEmptyFields()
        {
            // إعداد البيانات المزيفة للاختبار (حقول فارغة)
            FRM_ADD frm = new FRM_ADD();
            frm.txt_name.Text = "";
            frm.txt_price.Text = "";
            frm.txt_qun.Text = "";
            frm.txt_dat.Text = "";

            // إنشاء كائن من الفئة التي تحتوي على الدالة المراد اختبارها


            try
            {
                // استدعاء الدالة المراد اختبارها
                DatabaseHelper.AddNewItem(frm);

                // إذا وصلت الاختبار إلى هذه النقطة فإنه يجب أن يكون قد فشل
                Assert.Fail("لم يتم إثارة الاستثناء المتوقع");
            }
            catch (ArgumentException ex)

            {

                // التحقق من أن الاستثناء المطلوب تم إثارته
                Assert.AreEqual("يرجى ملء جميع الحقول", ex.Message);
               
            }
            catch (Exception ex)
            {
                Assert.Fail("حدث خطأ غير متوقع: " + ex.Message);
            }
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
