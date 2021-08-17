using System;
namespace DurinMedia.Common
{
    public class Common
    {
        public Common()
        {
        }

        public static string GetFullName(string firstname, string lastname) {
            return string.Format("{0} {1}", firstname, lastname);
        }
    }
}
