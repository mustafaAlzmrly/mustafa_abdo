using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_PRO_MAX.ItemP
{
    public static class condittionsItem
    {
       static FRM_ADD  frm = new FRM_ADD();
        public static bool NameTest(string name)
        {
            if (name == null) return false;

            return true;
        }
        public static bool priceTest(FRM_ADD frm ,ref string  ex)
        {

            int pricee = Convert.ToInt32(frm.txt_price.Text);
            int maxPrice = 1000000; // تعيين الحد الأقصى المسموح به للسعر
            // التحقق من الحد الأدنى للسعر
            if (pricee <= 0 || pricee > maxPrice)
            {
                DialogHelper.ShowDialog(frm, "يرجى ملء السعر بقيمة صحيحة");
                ex="يرجى ملء السعر بقيمة صحيحة";
                // السعر أقل من الحد الأدنى المسموح به
                return true;
            }else if(string.IsNullOrEmpty(frm.txt_price.Text))
            {
                DialogHelper.ShowDialog(frm, "يرجى ملء السعر ");
                // السعر أقل من الحد الأدنى المسموح به
                return true;
            }
            else
            {
                return false;
            }

           
            
               
        }

    }
}
