using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sample.Core.Models;

namespace sample.Core.Tokens
{
	class UserToken : IToken
	{
		public Dictionary<string, string> GetTokens(Object obj)
		{
			var user = obj as User;
			var userToken = new Dictionary<string, string>();
			if (user== null) return userToken;
			userToken.Add("{FirstName}", user.FirstName ?? "");
			userToken.Add("{LastName}", user.LastName ?? "");
			return userToken;
		}
	}
}
