using System.IO;
using System.Text;

namespace Odeon.Tests.Helpers
{
    public static class TestHelper
    {
        public static Stream OpenRead(string fileName)
        {
            string filePath = GetFullPath(fileName);
            FileStream stream = File.OpenRead(filePath);
            return stream;
        }

        public static string ReadFileAsString(string fileName)
        {
            string xml = Encoding.UTF8.GetString(ReadFileAsBytes(fileName));
            return xml;
        }

        public static byte[] ReadFileAsBytes(string fileName)
        {
            string filePath = GetFullPath(fileName);
            byte[] data = File.ReadAllBytes(filePath);
            return data;
        }

        private static string GetFullPath(string fileName)
        {
            var dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

            string filePath = @$"{dir}\Files\{fileName}";

            return filePath;
        }
    }
}
