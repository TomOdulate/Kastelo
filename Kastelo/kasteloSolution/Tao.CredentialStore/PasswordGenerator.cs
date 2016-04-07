using System;
using System.Text;
using System.Collections.Generic;

namespace Tao.CredentialStore
{
    [Serializable]
    public class PasswordGenerator
    {    
        /// <summary>
        /// Defines a default length of generated passwords.
        /// </summary>
        [NonSerialized]
        private const short DefaultLength = 8;

        /// <summary>
        /// Generate a string consisting of a randomly generated password characters. 
        /// </summary>
        /// <param name="size">The length of the password</param>
        /// <param name="disallowedChars">Characters to omit from the generated password.</param>
        /// <returns>A string consisting of a randomly generated password</returns>
        public static string GeneratePassword(char[] allowedCharacters, short size = DefaultLength )
        {
            var disallowedCharacters = new List<char>();
            disallowedCharacters.AddRange(" ".ToCharArray());

            var rnd = new Random();
            var sb = new StringBuilder();
            for (var i = 1; i <= size; i++)
            {
                char newChar;
                do
                {
                    newChar = allowedCharacters[rnd.Next(0, allowedCharacters.Length)];
                } while (disallowedCharacters.Contains(newChar));               
                
                sb.Append(newChar);
            }
            return sb.ToString();
        }

    }
}
