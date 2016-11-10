using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Util
{
    public class Criptografia
    {
        public static string GetMD5Hash(string Valor)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            return BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(Valor))).Replace("--", string.Empty);
        }
        
    }
}
