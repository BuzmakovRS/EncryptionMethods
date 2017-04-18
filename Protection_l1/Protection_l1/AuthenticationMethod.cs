using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionMethods
{
    public sealed class AuthenticationMethod
    {

        private readonly String name;
        private readonly int value;

        public static readonly AuthenticationMethod PermutationСipher = new AuthenticationMethod(1, "Перестановки");
        public static readonly AuthenticationMethod RSA = new AuthenticationMethod(2, "RSA");
        public static readonly AuthenticationMethod Diffie_Hellman = new AuthenticationMethod(3, "Диффи-Хеллмана");
        public static readonly AuthenticationMethod TEA = new AuthenticationMethod(4, "TEA");

        private AuthenticationMethod(int value, String name)
        {
            this.name = name;
            this.value = value;
        }

        public override String ToString()
        {
            return name;
        }

    }
}
