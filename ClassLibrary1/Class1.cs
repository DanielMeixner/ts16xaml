using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Class1
    {
        public static async void CrashNow()
        {
    
                HttpClient cl = new HttpClient();
                await cl.GetStringAsync("willcrash");


        }
    }
}
