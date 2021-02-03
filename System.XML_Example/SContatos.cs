using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace System.XML_Example
{
    public class SContatos
    {
        private static string arquivo =
            @"C:\projeto\devmedia\.NET Framework 4.5\Fontes\NetFwk45\Framework\Framework\System.XML_Example\XML\Agenda3.xml";

        private static XmlDocument xmlDoc = new XmlDocument();
        private static XElement xDoc;
        private static Contatos contatos;

        public SContatos()
        {
            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xmlDoc.CreateElement("Contatos");
                xmlDoc.AppendChild(nodeRoot);
                xmlDoc.Save(arquivo);
            }
        }

        public static Contatos Read()
        {
            xDoc = XElement.Load(arquivo);
            contatos = Serializer.Deserialize<Contatos>(xDoc);

            return contatos;
        }

        public static void Write(Contatos contatos)
        {
            XElement xmlReturn = Serializer.Serialize<Contatos>(contatos);

            xmlReturn.Save(arquivo);
        }

        public static List<Contato> GetList()
        {
            return contatos.Contato;
        }
    
    }
}
