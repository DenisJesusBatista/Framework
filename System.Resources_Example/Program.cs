using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Resources;

namespace System.Resources_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Resources.ResourceManager rm = new ResourceManager(typeof(System.Resources_Example.Main));
            System.Globalization.CultureInfo ci = new Globalization.CultureInfo("en-US");
            string d = rm.GetString("DESCRICAO",ci);
            Console.Write(d);
            Console.ReadKey();

            /*Usando a classe ResourceHelper*/
            ResourceHelper.getResource("DESCRICAO");



        }
    }
}
