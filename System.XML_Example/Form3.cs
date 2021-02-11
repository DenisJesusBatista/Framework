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

        private void BindListBox(List<Contato> lContato)
        {
            listBox1.DataSource = lContato;
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Id";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            contatos = SContatos.Read();
            this.BindListBox(contatos.Contato);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Id = this.NextId();
            c.Nome = txtNome.Text;
            c.Telefone = new List<Telefone>();
            c.Telefone.Add(new Telefone((int)TiposTelefone.Residencial,txtFoneResidencial.Text));
            c.Telefone.Add(new Telefone((int)TiposTelefone.Comercial, txtFoneComercial.Text));
            c.Telefone.Add(new Telefone((int)TiposTelefone.Celular, txtCelular.Text));
            c.Obs = txtObs.Text;

            contatos.Contato.Add(c);

            SContatos.Write(contatos);

            this.BindListBox(SContatos.Read().Contato);

        }

        private int NextId()
        {
            int next = contatos.Contato[contatos.Contato.Count - 1].Id + 1;
            return next;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Contato c = contatos.Contato.Find(p => p.Id == (int) listBox1.SelectedValue);
                contatos.Contato.Remove(c);
                SContatos.Write(contatos);

                this.BindListBox(SContatos.Read().Contato);

            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Contato c = contatos.Contato.Find(p => p.Id == (int)listBox1.SelectedValue);
            MessageBox.Show("Nome: " + c.Nome + "\n" + "Telefone: " + c.Telefone + "\n" + "Obs: " + c.Obs);

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                pnlAlterar.Visible = true;
                pnlIncluir.Visible = false;
                Contato c = contatos.Contato.Find(p => p.Id == (int)listBox1.SelectedValue);
                txtNome.Text = c.Nome;
                if (c.Telefone.Count > 0)
                {
                   txtFoneResidencial.Text = c.Telefone[(int)TiposTelefone.Residencial].Numero;
                    txtFoneComercial.Text = c.Telefone[(int)TiposTelefone.Comercial].Numero;
                    txtCelular.Text = c.Telefone[(int)TiposTelefone.Celular].Numero;
                }
             
                lblId.Text = c.Id.ToString();
                txtObs.Text = c.Obs;

            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            Contato c = contatos.Contato.Find(p => p.Id == id);
            
            c.Nome = txtNome.Text;
            //c.Telefone = new List<string>();
            c.Telefone[(int)TiposTelefone.Residencial].Numero = txtFoneResidencial.Text;
            c.Telefone[(int)TiposTelefone.Comercial].Numero = txtFoneComercial.Text;
            c.Telefone[(int)TiposTelefone.Celular].Numero = txtCelular.Text;
            c.Obs = txtObs.Text;

            SContatos.Write(contatos);

            this.BindListBox(SContatos.Read().Contato);

            this.btnCancelar_Click(null,null);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAlterar.Visible = false;
            pnlIncluir.Visible = true;
            txtNome.Text = txtFoneResidencial.Text = txtFoneComercial.Text = txtCelular.Text = txtObs.Text = lblId.Text = string.Empty;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.FormClosed += form4_FormClosed;       
            form4.ShowDialog();
        }

        private void form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FiltroContatos.Filtro.Count > 0)
            {
                btnLimpar.Visible = true;
                this.BindListBox(FiltroContatos.Filtro);

            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado.");
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnLimpar.Visible = false;
            this.BindListBox(SContatos.Read().Contato);
        }
    }
}
