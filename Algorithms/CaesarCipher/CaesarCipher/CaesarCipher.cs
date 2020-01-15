using System.Text;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        public static string Encrypt(string text, int index)
        {
            index = Index(index);
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                var asciiShift = AsciiShift(c);
                var ch = (char)((c + index - asciiShift) % 26 + asciiShift);
                sb.Append(ch);
            }
            return sb.ToString();
        }

        public static string Decrypt(string text, int index)
        {
            index = Index(index);
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                var asciiShift = AsciiShift(c);
                var ch = (char)((c - index - asciiShift + 26) % 26 + asciiShift);
                sb.Append(ch);
            }
            return sb.ToString();
        }

        private static int Index(int index) => index % 26;

        private static int AsciiShift(char c) => char.IsUpper(c) ? 65 : 97;
    }
}
