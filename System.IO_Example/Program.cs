using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.IO;

namespace System.IO_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Primeiro arquivo texto gravado no diretório.");
            File.AppendAllText(@"C:\projeto\devmedia\.NET Framework 4.5\Fontes\NetFwk45\Framework\Framework\System.IO_Example\Arquivo.txt", sb.ToString());

            /*Escrever as informação em um array*/
            string[] values = { "Linha 1", "Linha 2", "Linha 3" };
            File.AppendAllLines(@"C:\projeto\devmedia\.NET Framework 4.5\Fontes\NetFwk45\Framework\Framework\System.IO_Example\Arquivo2.txt", values);

            /*Copiar um determinado arquivo*/
            File.Copy(@"C:\projeto\devmedia\.NET Framework 4.5\Fontes\NetFwk45\Framework\Framework\System.IO_Example\Arquivo2.txt", @"C:\projeto\devmedia\.NET Framework 4.5\Fontes\NetFwk45\Framework\Framework\System.IO_Example\copy\Arquivo4.txt");

            /*Deixar apenas o usuário ter acesso*/
            File.Encrypt(@"C:\projeto\devmedia\.NET Framework 4.5\Fontes\NetFwk45\Framework\Framework\System.IO_Example\copy\Arquivo4.txt");

            File.Decrypt(@"C:\projeto\devmedia\.NET Framework 4.5\Fontes\NetFwk45\Framework\Framework\System.IO_Example\copy\Arquivo4.txt");

        }
    }
}
