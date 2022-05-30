using System.Security.Cryptography;

namespace Studioat.Utility
{
    internal static class Helper
    {
        internal static HashAlgorithm Hashes(HashType hash)
        {
            switch (hash)
            {
                case HashType.MD5:
                    return MD5.Create();
                case HashType.SHA1:
                    return SHA1.Create();
                case HashType.SHA256:
                    return SHA256.Create();
                case HashType.SHA384:
                    return SHA384.Create();
                case HashType.SHA512:
                    return SHA512.Create();
                default: return null;
            }
        }
    }
}
