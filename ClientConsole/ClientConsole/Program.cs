using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("enter the input text file path");
            var path = Console.ReadLine();
            var soapClient = new WordService.WebServiceSoapClient();
            //c:\users\farid.azayev\source\repos\ClientConsole\ClientConsole\input.txt
            System.IO.File.ReadAllText(path).Split(' ').ToList()
                .ForEach((w)=> Console.WriteLine(soapClient.ReverseWord(w)));
        }
    }
}
