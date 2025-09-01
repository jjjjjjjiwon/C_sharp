

using System.Text;

namespace MyExtension
{

    public static class ExClass
    {
        /// <summary>
        /// 대문자 => 소문자, 소문자 => 대문자
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToChangeCase(this String str) // 확장은 this가 있고 String 대문자로 작성
        {
            var sb = new StringBuilder();
            foreach (var ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                    sb.Append((char)('a' + ch - 'A'));
                else if (ch >= 'a' && ch <= 'z')
                    sb.Append((char)('A' + ch - 'a'));
                else
                    sb.Append(ch);
            }
            return sb.ToString();
        }


        /// <summary>
        /// char가 있는지 판다, 결과를 bool로
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ch"></param>
        /// <returns></returns>
        public static bool Found(this String str, char ch)
        {
            int Position = str.IndexOf(ch);
            return Position >= 0;
        }
    }
}