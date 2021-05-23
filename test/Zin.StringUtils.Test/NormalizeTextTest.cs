using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Zin.StringUtils.Test
{
    // ReSharper disable once StringLiteralTypo
    public class NormalizeTextTest
    {
        [Test]
        public void Test_NormalizeText_A()
        {

            var originalText = "ÀÁÂÃĂẠẢẤẦẨẪẬẮẰẲẴẶàáâãăạảấầẩẫậắằẳẵặ";
            var expectedText = "AAAAAAAAAAAAAAAAAaaaaaaaaaaaaaaaaa";

            var normalizedText = originalText.NormalizeText();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeText_E()
        {
            var originalText = "ÈÉÊẸẺẼỀỀỂỄỆèéêẹẻẽềềểễệ";
            var expectedText = "EEEEEEEEEEEeeeeeeeeeee";

            var normalizedText = originalText.NormalizeText();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeText_I()
        {
            var originalText = "ÌÍỈĨỊìíỉĩị";
            var expectedText = "IIIIIiiiii";

            var normalizedText = originalText.NormalizeText();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeText_O()
        {
            // ReSharper disable once StringLiteralTypo
            var originalText = "ÒÓÔÕỌỎỐỒỔỖỘƠỚỜỞỠỢòóôõọỏốồổỗộơớờởỡợ";
            var expectedText = "OOOOOOOOOOOOOOOOOooooooooooooooooo";

            var normalizedText = originalText.NormalizeText();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeText_U()
        {
            var originalText = "ÙÚŨỤỦƯỨỪỬỮỰùúũụủưứừửữự";
            var expectedText = "UUUUUUUUUUUuuuuuuuuuuu";

            var normalizedText = originalText.NormalizeText();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeText_Y()
        {
            var originalText = "ỲỴÝỶỸỳỵýỷỹ";
            var expectedText = "YYYYYyyyyy";

            var normalizedText = originalText.NormalizeText();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeText_D()
        {
            var originalText = "Đđ";
            var expectedText = "Dd";

            var normalizedText = originalText.NormalizeText();

            Assert.AreEqual(expectedText, normalizedText);
        }
    }
}
