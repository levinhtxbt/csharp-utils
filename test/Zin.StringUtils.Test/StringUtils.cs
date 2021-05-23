using NUnit.Framework;

namespace Zin.StringUtils.Test
{
    // ReSharper disable once StringLiteralTypo
    public class Tests
    {
        [Test]
        public void Test_ReplaceWhitespace()
        {
            // ReSharper disable once StringLiteralTypo
            var originalText = "Đây là đoạn văn bản vô nghĩa để kiểm tra thử      hàm xử lý     Tiếng Việt thôi";
            var expectedText = "day-la-doan-van-ban-vo-nghia-de-kiem-tra-thu-ham-xu-ly-tieng-viet-thoi";
            var result = originalText.NormalizeText()
                .ToLower()
                .ReplaceWhitespace("-");

            Assert.AreEqual(expectedText, result);


        }



    }
}