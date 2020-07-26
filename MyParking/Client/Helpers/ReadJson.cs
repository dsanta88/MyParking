
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyParking.Client.Helpers

{
    public class ReadJson
    {
        public string GetUrlAPI()
        {
            return "https://localhost:44320/api";
           // //Leer archivo appsettings.json
           // var builder = new ConfigurationBuilder()
           //.AddJsonFile("config.json", optional: false, reloadOnChange: true);
           // var configuration = builder.Build();
       
           // return configuration["UrlAPI"];

        }
    }
}


//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;

//namespace MyParking.Client.Helpers
//{
//    public class ReadJson
//    {
//        public string GetUrlAPI()
//        {

//            using (StreamReader r = new StreamReader("config.json"))
//            {
//                string json = r.ReadToEnd();
//                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
//            }

//           // var builder = new ConfigurationBuilder()
//           //.AddJsonFile("", optional: false, reloadOnChange: true);
//           // var configuration = builder.Build();

//           // return configuration["UrlAPI"];

//        }
//    }
//}
