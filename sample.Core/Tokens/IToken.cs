using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sample.Core.Tokens
{
    interface IToken
    {
        Dictionary<string, string> GetTokens(object obj);
    }
}
