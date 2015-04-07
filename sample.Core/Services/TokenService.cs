using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using sample.Core.Models;
using sample.Core.Tokens;

namespace sample.Core.Services
{
    public class TokenService
    {
        public Dictionary<string, string> TokenDictionary { get; set; }

        /// <summary>
        /// Gets token dictionary based on token type
        /// </summary>
        /// <param name="token">type of token in TokenType enum</param>
        /// <param name="obj">the object with the data for the token</param>
        /// <returns>dictionary of tokens based on the object and tokentype passed in</returns>
        public TokenService(TokenType token, Object obj)
        {
            switch (token)
            {
                case TokenType.Park:
                    TokenDictionary = new ParkToken().GetTokens(obj);
                    break;
                case TokenType.User:
                    TokenDictionary = new UserToken().GetTokens(obj);
                    break;
            }
        }

        /// <summary>
        /// Replaces tokens in the text, tokens are in the format of {tokenstring}
        /// </summary>
        /// <param name="text">text with tokens to be replaced</param>
        /// <returns>a string of text with tokens replaced</returns>
        public string ReplaceTokens(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";
            if (!Regex.IsMatch(text, "{.+}") || TokenDictionary == null) return text;
            //replace tokens in text
            return TokenDictionary.Aggregate(text, (current, t) => current.Replace(t.Key, t.Value));
        }
    }
}
