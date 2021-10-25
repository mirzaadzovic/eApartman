using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using eApartman.Model.Helpers;
using eApartman.Model;

namespace eApartman.WinUI
{
    public class APIService
    {
        private readonly string _url;
        public static Korisnik Korisnik { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static void Reset()
        {
            Korisnik = null;
            Username = null;
            Password = null;
        }

        public APIService(string route)
        {
            this._url = $"{Properties.Settings.Default.APIURL}/{route}"; ;
        }
        public async Task<T> Get<T>(object request=null)
        {
            string url = _url;
            if(request!=null)
            {
                url += "?";
                url += await request.ToQueryString();
            }

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> GetById<T>(int id)
        {
            var url = $"{_url}/{id}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            return await _url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(int id, object request)
        {
            string url = $"{_url}/{id}";

            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Delete<T>(int id)
        {
            string url = $"{_url}/{id}";
            return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
        }
    }
}
