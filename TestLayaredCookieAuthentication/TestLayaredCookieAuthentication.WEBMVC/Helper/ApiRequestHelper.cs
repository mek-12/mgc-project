using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestLayaredCookieAuthentication.WEBMVC.Models;
using TestLayaredCookieAuthentication.WEBMVC.Models.Account;

namespace TestLayaredCookieAuthentication.WEBMVC.Helper
{
    public class ApiRequestHelper : IDisposable
    {
        public async Task<UserInfo> GetUserWithToken(LoginViewModel model)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(model);
                var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + model.TOKEN);
                var response = await client.PostAsync("http://localhost:51408/api/auth/getuser", stringContent);
                var userInfo = await response.Content.ReadAsAsync<UserInfo>();
                return userInfo;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
