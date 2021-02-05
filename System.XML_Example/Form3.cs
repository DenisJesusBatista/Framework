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
        private Contatos contatos = null;

        public Form3()
        {
            InitializeComponent();

        }

        private void BindListBox()
        {
            contatos = SContatos.Read();
            listBox1.DataSource = contatos.Contato;
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Id";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BindListBox();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Id = this.NextId();
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;

            contatos.Contato.Add(c);

            SContatos.Write(contatos);

            this.BindListBox();

        }

        private int NextId()
        {
            int next = contatos.Contato[contatos.Contato.Count - 1].Id + 1;
            return 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Contato c = contatos.Contato.Find(p => p.Id == (int) listBox1.SelectedValue);
                contatos.Contato.Remove(c);
                SContatos.Write(contatos);

                this.BindListBox();

            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Contato c = contatos.Contato.Find(p => p.Id == (int)listBox1.SelectedValue);
            MessageBox.Show("Nome: " + c.Nome + "\n" + "Telefone: " + c.Telefone);

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                pnlAlterar.Visible = true;
                pnlIncluir.Visible = false;
                Contato c = contatos.Contato.Find(p => p.Id == (int)listBox1.SelectedValue);
                txtNome.Text = c.Nome;
                txtTelefone.Text = c.Telefone;
                lblId.Text = c.Id.ToString();

            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            contatos.Contato.Find(p => p.Id == id).Nome = txtNome.Text;
            contatos.Contato.Find(p => p.Id == id).Telefone = txtTelefone.Text;
            SContatos.Write(contatos);

            this.BindListBox();

            this.btnCancelar_Click(null,null);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAlterar.Visible = false;
            pnlIncluir.Visible = true;
            txtNome.Text = txtTelefone.Text = lblId.Text = string.Empty;
        }
    }
}
