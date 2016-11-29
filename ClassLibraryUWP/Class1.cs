using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUWP
{
    public static class Class1
    {
        static string url = "willcrash";


        public static async void CrashNow()
        {
            HttpClient cl = new HttpClient();
            await cl.GetStringAsync(url);


        }
    }
}
