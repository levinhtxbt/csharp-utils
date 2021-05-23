using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Zin.StringUtils.Test
{
    public class NormalizeTextByRegexTest
    {
        [Test]
        public void Test_NormalizeTextByRegex_A()
        {

            var originalText = "ÀÁÂÃĂẠẢẤẦẨẪẬẮẰẲẴẶàáâãăạảấầẩẫậắằẳẵặ";
            var expectedText = "AAAAAAAAAAAAAAAAAaaaaaaaaaaaaaaaaa";

            var normalizedText = originalText.NormalizeTextByRegex();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeTextByRegex_E()
        {
            var originalText = "ÈÉÊẸẺẼỀỀỂỄỆèéêẹẻẽềềểễệ";
            var expectedText = "EEEEEEEEEEEeeeeeeeeeee";

            var normalizedText = originalText.NormalizeTextByRegex();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeTextByRegex_I()
        {
            var originalText = "ÌÍỈĨỊìíỉĩị";
            var expectedText = "IIIIIiiiii";

            var normalizedText = originalText.NormalizeTextByRegex();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeTextByRegex_O()
        {
            // ReSharper disable once StringLiteralTypo
            var originalText = "ÒÓÔÕỌỎỐỒỔỖỘƠỚỜỞỠỢòóôõọỏốồổỗộơớờởỡợ";
            var expectedText = "OOOOOOOOOOOOOOOOOooooooooooooooooo";

            var normalizedText = originalText.NormalizeTextByRegex();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeTextByRegex_U()
        {
            var originalText = "ÙÚŨỤỦƯỨỪỬỮỰùúũụủưứừửữự";
            var expectedText = "UUUUUUUUUUUuuuuuuuuuuu";

            var normalizedText = originalText.NormalizeTextByRegex();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeTextByRegex_Y()
        {
            var originalText = "ỲỴÝỶỸỳỵýỷỹ";
            var expectedText = "YYYYYyyyyy";

            var normalizedText = originalText.NormalizeTextByRegex();

            Assert.AreEqual(expectedText, normalizedText);
        }

        [Test]
        public void Test_NormalizeTextByRegex_D()
        {
            var originalText = "Đđ";
            var expectedText = "Dd";

            var normalizedText = originalText.NormalizeTextByRegex();

            Assert.AreEqual(expectedText, normalizedText);
        }
    }
}
