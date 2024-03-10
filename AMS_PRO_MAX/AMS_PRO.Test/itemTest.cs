using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AMS_PRO_MAX;


using Assert = NUnit.Framework.Assert;

namespace AMS_PRO_MAX.Test.ItemTest
{


    [TestClass]
    public class itemTest
    {
        private ItemManager _itemManager;
        private Mock<IDatabaseHelper> _mockDatabaseHelper;

        [SetUp]
        public void SetUp()
        {
            _mockDatabaseHelper = new Mock<IDatabaseHelper>();
            _itemManager = new ItemManager(_mockDatabaseHelper.Object);
        }
       // [TestMethod]
        /*public void AddNewItem_WhenItemNameIsDuplicate_ThrowsDuplicateItemException()
        {
            // Arrange
            var frm = new FRM_ADD();
            frm.txt_name.Text = "Duplicate Item";

            var existingItem = new Item { Name = "Duplicate Item" };
            var dbContextMock = new Mock<IDBContext>();
            dbContextMock.Setup(d => d.Items.FirstOrDefault(item => item.Name == frm.txt_name.Text)).Returns(existingItem);

            var dialogHelperMock = new Mock<IDialogHelper>();

            var target = new ItemManager(dialogHelperMock.Object, dbContextMock.Object);

            // Act & Assert
            Assert.Throws<DuplicateItemException>(() => target.AddNewItem(frm));
        }*/
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
                 //Assert.AreEqual("يرجى ملء جميع الحقول", ex.Message);
               // Assert.IsTrue(string.Equals("يرجى ملء جميع الحقول", ex.Message));
            }
            catch (Exception ex)
            {
                Assert.Fail("حدث خطأ غير متوقع: " + ex.Message);
            }
        }
    }
}