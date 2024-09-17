using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EncryptionPractice.Models
{
    internal class Encryption
    {
        //
        public static string HashPasswordSalt(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var saltedPassword = password + salt;
                var saltedPasswordBytes = Encoding.UTF8.GetBytes(saltedPassword);
                var hashBytes = sha256.ComputeHash(saltedPasswordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        // Generates a unique salt for each user 
        public static string GenerateSalt(int size = 16)
        {
            var rng = new RNGCryptoServiceProvider();
            var saltBytes = new byte[size];
            rng.GetBytes(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }

        //
        public static bool VerifyPassword(string enteredPassword, string storedSalt, string storedHash)
        {
            string hashedEnteredPassword = HashPasswordSalt(enteredPassword, storedSalt);
            return StringComparer.OrdinalIgnoreCase.Equals(hashedEnteredPassword, storedHash);
        }
    }
}