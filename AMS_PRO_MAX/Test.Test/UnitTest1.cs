using AMS_PRO_MAX;

namespace Test.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddNewItem_WhenFieldsAreEmpty_ShowDialogWithErrorMessage()
        {
            // Arrange
            var frm = new FRM_ADD();
            frm.txt_name.Text = "";
            frm.txt_price.Text = "";
            frm.txt_qun.Text = "";
            frm.txt_dat.Text = "";

            // Act
            AddNewItem(frm);

            // Assert
            // Verify that the dialog with the error message is shown
            // You need to implement this assertion based on your DialogHelper implementation
            Assert.IsTrue(DialogHelper.IsDialogShownWithMessage("يرجى ملء جميع الحقول"));
        }

        [Test]
        public void AddNewItem_WhenItemNameIsDuplicate_ShowDialogWithErrorMessage()
        {
            // Arrange
            var frm = new FRM_ADD();
            frm.txt_name.Text = "Duplicate Item";

            // Assuming an existing item with the same name already exists in the database
            var existingItem = new Item { Name = "Duplicate Item" };
            var dbMock = new DB_AMS_PROEntities6Mock();
            dbMock.Items.Add(existingItem);

            // Act
            AddNewItem(frm);

            // Assert
            // Verify that the dialog with the error message is shown
            // You need to implement this assertion based on your DialogHelper implementation
            Assert.IsTrue(DialogHelper.IsDialogShownWithMessage("اسم الصنف مكرر"));
        }

        [Test]
        public void AddNewItem_WhenAllFieldsAreValid_AddsNewItemToDatabase()
        {
            // Arrange
            var frm = new FRM_ADD();
            frm.txt_name.Text = "New Item";
            frm.txt_price.Text = "10";
            frm.txt_qun.Text = "5";
            frm.txt_dat.Text = "2024-03-08";

            var dbMock = new DB_AMS_PROEntities6Mock();

            // Act
            AddNewItem(frm);

            // Assert
            // Verify that a new item is added to the database with the correct values
            Assert.AreEqual(1, dbMock.Items.Count);
            var newItem = dbMock.Items[0];
            Assert.AreEqual("New Item", newItem.Name);
            Assert.AreEqual(10, newItem.Price);
            Assert.AreEqual(5, newItem.QuantityAvailable);
            // You can add more assertions for other properties of the new item
        }

        [Test]
        public void AddNewItem_WhenExceptionThrown_ShowMessageBoxWithErrorMessage()
        {
            // Arrange
            var frm = new FRM_ADD();
            var dbMock = new DB_AMS_PROEntities6Mock(executeSaveChanges: () => throw new Exception("No server"));

            // Act
            AddNewItem(frm);

            // Assert
            // Verify that a message box with the error message is shown
            // You need to implement this assertion based on your MessageBox.Show method
            Assert.IsTrue(MessageBoxHelper.IsMessageBoxShownWithMessage("no server"));
        }
    }

    // Mock implementation of DB_AMS_PROEntities6 for testing purposes
    public class DB_AMS_PROEntities6Mock : DB_AMS_PROEntities6
    {
        public List<Item> Items { get; private set; }

        public DB_AMS_PROEntities6Mock()
        {
            Items = new List<Item>();
        }

        public override int SaveChanges()
        {
            // Mock implementation of SaveChanges method
            return 1;
        }
    }
}