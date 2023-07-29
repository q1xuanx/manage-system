using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.Forms
{
    internal class Utils
    {
        public static string generateUUID()
        {
            Guid myUUId = Guid.NewGuid();
            string convertedUUID = myUUId.ToString();
            return convertedUUID;
        }


        public static string GenerateUsername(string fullName)
        {
            // Tách các từ trong tên đầy đủ
            string[] nameParts = fullName.Trim().Split(' ');

            // Lấy từ cuối cùng làm tên đầy đủ
            string lastName = nameParts[nameParts.Length - 1];

            // Tạo tên người dùng từ tên đầy đủ và các từ còn lại được viết tắt
            string username = lastName.ToLower();

            // Lặp qua các từ còn lại để lấy chữ cái đầu tiên
            for (int i = 0; i < nameParts.Length - 1; i++)
            {
                string part = nameParts[i];
                if (!string.IsNullOrEmpty(part))
                {
                    username += part.Substring(0, 1).ToLower();
                }
            }

            return username;
        }

        // maxa hoa

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}





