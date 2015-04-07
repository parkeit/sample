using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sample.Core.Data;

namespace sample.Core.Tokens
{
    class ParkToken : IToken
    {
        public Dictionary<string, string> GetTokens(Object obj)
        {
            var park = obj as Park;
            var parkNameToken = new Dictionary<string, string>();
            if (park == null) return parkNameToken;
            parkNameToken.Add("{parkName}",park.Name ?? "");
            return parkNameToken;
        } 
    }
}
