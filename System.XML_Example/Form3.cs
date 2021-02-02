using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace System.XML_Example
{
    public partial class Form3 : Form
    {
        private string arquivo =
            @"C:\projeto\devmedia\.NET Framework 4.5\Fontes\NetFwk45\Framework\Framework\System.XML_Example\XML\Agenda3.xml";

        private XmlDocument xmlDoc = new XmlDocument();
        private XElement xDoc;
        private Contatos contatos;
       
        public Form3()
        {
            InitializeComponent();

            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xmlDoc.CreateElement("Contatos");
                xmlDoc.AppendChild(nodeRoot);
                xmlDoc.Save(arquivo);
            }
            
        }

        private void ReadAgenda()
        {
            xDoc = XElement.Load(arquivo);
            contatos = Serializer.Deserialize<Contatos>(xDoc);
            lblContato.Text = string.Empty;

            foreach (Contato c in contatos.Contato)
            {
                lblContato.Text += "Nome: " + c.Nome + "\nTelefone: " + c.Telefone + "\n\n";

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ReadAgenda();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Id = this.NextId();
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;

            contatos.Contato.Add(c);

            XElement xmlReturn = Serializer.Serialize<Contatos>(contatos);
            xmlReturn.Save(arquivo);

            ReadAgenda();
        }

        private int NextId()
        {
            int next = contatos.Contato[contatos.Contato.Count - 1].Id + 1;
            return 0;
        }
    }
}
