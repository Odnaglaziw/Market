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
            // Генерация соли
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // Хэширование пароля с использованием соли
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000))
            {
                byte[] hash = pbkdf2.GetBytes(20);

                // Комбинируем соль и хэш для хранения
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                // Возвращаем результат в виде строки Base64
                return Convert.ToBase64String(hashBytes);
            }
        }
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Извлечение байтов из строки Base64
            byte[] hashBytes = Convert.FromBase64String(storedHash);

            // Извлечение соли из первых 16 байтов
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Хэширование введённого пароля с использованием той же соли
            using (var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 100000))
            {
                byte[] hash = pbkdf2.GetBytes(20);

                // Проверка соответствия хэшей
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