using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;
using System.Globalization;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.Ratings[0]);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Set_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_ID_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "test";

            // Assert
            Assert.AreEqual(result.Id,"test");
        }

        [TestMethod]
        public void ProductModel_Set_ID_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "test";

            // Assert
            Assert.AreEqual(result.Id, "test");
        }

        [TestMethod]
        public void ProductModel_Get_Maker_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "test";

            // Assert
            Assert.AreEqual(result.Maker, "test");
        }

        [TestMethod]
        public void ProductModel_Set_Maker_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "test";

            // Assert
            Assert.AreEqual(result.Maker, "test");
        }

        [TestMethod]
        public void ProductModel_Get_Image_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "test";

            // Assert
            Assert.AreEqual(result.Image, "test");
        }

        [TestMethod]
        public void ProductModel_Set_Image_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "test";

            // Assert
            Assert.AreEqual(result.Image, "test");
        }

        [TestMethod]
        public void ProductModel_Get_Url_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "test";

            // Assert
            Assert.AreEqual(result.Url, "test");
        }

        [TestMethod]
        public void ProductModel_Set_Url_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "test";

            // Assert
            Assert.AreEqual(result.Url, "test");
        }


        [TestMethod]
        public void ProductModel_Get_Title_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "test";

            // Assert
            Assert.AreEqual(result.Title, "test");
        }

        [TestMethod]
        public void ProductModel_Set_Title_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "test";

            // Assert
            Assert.AreEqual(result.Title, "test");
        }

        [TestMethod]
        public void ProductModel_Get_Description_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "test";

            // Assert
            Assert.AreEqual(result.Description, "test");
        }

        [TestMethod]
        public void ProductModel_Set_Description_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "test";

            // Assert
            Assert.AreEqual(result.Description, "test");
        }


        [TestMethod]
        public void ProductModel_Get_Sequence_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "test";

            // Assert
            Assert.AreEqual(result.Sequence, "test");
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "test";

            // Assert
            Assert.AreEqual(result.Sequence, "test");
        }

        [TestMethod]
        public void ProductModel_Override_ToString_Should_Pass()
        {
            // Arrange
            string s;
            var result = new ProductModel();

            // Act
            s = result.ToString();

            // Assert
            Assert.AreEqual(s, "{\"Id\":null,\"Maker\":null,\"img\":null,\"Url\":null,\"Title\":null,\"Description\":null,\"Date\":\""+ result.Date.ToString("o", CultureInfo.InvariantCulture)+"\",\"Sequence\":null,\"Email\":\"Unknown\",\"Logistics\":\"\",\"Ratings\":[5]}");
            //Date conversion source:  https://dirask.com/posts/C-NET-convert-DateTime-to-iso-8601-l1GVEj
        }

        [TestMethod]
        public void ProductModel_AverageRating_Ratings_Null_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = null;

            // Assert
            Assert.AreEqual(result.AverageRating(), 0);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Ratings_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings[0] = 3;

            // Assert
            Assert.AreEqual(result.AverageRating(), 3);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Ratings_Zero_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings[0] = 0;

            // Assert
            Assert.AreEqual(result.AverageRating(), 0);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Count_Zero_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = new int[] { };

            // Assert
            Assert.AreEqual(result.AverageRating(), 0);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Total_Zero_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings[0] = 0;

            // Assert
            Assert.AreEqual(result.AverageRating(), 0);
        }


    }
}
