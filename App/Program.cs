using DataAccess;
using Models.Models;
using System.Security.Cryptography;

namespace App
{
    public static class Program
    {
        public static User user;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Root());
        }
        public static string HashPassword(string password)
        {
            // ��������� ����
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // ����������� ������ � �������������� ����
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000))
            {
                byte[] hash = pbkdf2.GetBytes(20);

                // ����������� ���� � ��� ��� ��������
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                // ���������� ��������� � ���� ������ Base64
                return Convert.ToBase64String(hashBytes);
            }
        }
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // ���������� ������ �� ������ Base64
            byte[] hashBytes = Convert.FromBase64String(storedHash);

            // ���������� ���� �� ������ 16 ������
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // ����������� ��������� ������ � �������������� ��� �� ����
            using (var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 100000))
            {
                byte[] hash = pbkdf2.GetBytes(20);

                // �������� ������������ �����
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}