using System;
using System.Net;

namespace ImportaPaginaWeb {
    class ImportaPaginaWeb {
        static void Main(string[] args) {

            WebClient cliente = new WebClient();


            //string cliente = client.DownloadString("http://google.com.br");


            Console.WriteLine(cliente);
        }
    }
}
