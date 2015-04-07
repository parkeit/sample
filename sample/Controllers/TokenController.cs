using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using sample.Core.Models;
using sample.Core.Services;

namespace sample.Controllers
{
    public class TokenController : ApiController
    {
        // GET api/<controller>
        public string Get()
        {
            const string text = "{FirstName} {LastName}, You have a confirmed reservation for today";
            var user = new sample.Core.Models.User {FirstName = "Homer", LastName = "Simpson"};
            var userTokenService = new TokenService(TokenType.User, user);
            return userTokenService.ReplaceTokens(text);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}