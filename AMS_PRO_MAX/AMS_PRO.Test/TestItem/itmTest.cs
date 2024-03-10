using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace AMS_PRO_MAX.Test.itmTest
{
    [TestClass]
    public class itmTest
    {
       
        [TestMethod]
        public void TestAddNewItem_WithEmptyFields()
        {
            // إعداد البيانات المزيفة للاختبار (حقول فارغة)
            FRM_ADD frm = new FRM_ADD();
            frm.txt_name.Text = "";
            frm.txt_price.Text = "";
            frm.txt_qun.Text = "";
            frm.txt_dat.Text = DateTime.Now.ToString();

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
        public void TestAddNewItem_Duplicate()
        {
            // إعداد البيانات المزيفة للاختبار (حقول فارغة)
            FRM_ADD frm = new FRM_ADD();
            frm.txt_name.Text = "Duplicate";
            frm.txt_price.Text = "23";
            frm.txt_qun.Text = "86";
            frm.txt_dat.Text = DateTime.Now.ToString();

            // إنشاء كائن من الفئة التي تحتوي على الدالة المراد اختبارها
           


            try
            {
                // استدعاء الدالة المراد اختبارها
                DatabaseHelper.AddNewItem(frm);
               

                // إذا وصلت الاختبار إلى هذه النقطة فإنه يجب أن يكون قد فشل
                Assert.Fail("لم يتم إثارة الاستثناء المتوقع");
            }
            catch (DuplicateItemException ex)

            {

                // التحقق من أن الاستثناء المطلوب تم إثارته
                Assert.AreEqual("اسم الصنف مكرر", ex.Message);

            }
            catch (Exception ex)
            {
                Assert.Fail("حدث خطأ : " + ex.Message);
            }
        }
        [TestMethod]
        public void TestAddNewItem_withErorrprice()
        {
            // إعداد البيانات المزيفة للاختبار (حقول فارغة)
            FRM_ADD frm = new FRM_ADD();
            frm.txt_name.Text = "itemm3";
            frm.txt_price.Text = "-23";
            frm.txt_qun.Text = "86";
            frm.txt_dat.Text = DateTime.Now.ToString();

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
                Assert.AreEqual("يرجى ملء السعر بقيمة صحيحة", ex.Message);

            }
            catch (Exception ex)
            {
                Assert.Fail("حدث خطأ : " + ex.Message);
            }
        }

    }
}
