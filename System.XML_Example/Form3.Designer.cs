namespace System.XML_Example
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.pnlIncluir = new System.Windows.Forms.Panel();
            this.pnlAlterar = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlIncluir.SuspendLayout();
            this.pnlAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(0, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Incluir";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(24, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(106, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(24, 107);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(106, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(24, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(24, 88);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(213, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(417, 277);
            this.listBox1.TabIndex = 12;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(555, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(462, 325);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 14;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // pnlIncluir
            // 
            this.pnlIncluir.Controls.Add(this.btnSalvar);
            this.pnlIncluir.Location = new System.Drawing.Point(24, 168);
            this.pnlIncluir.Name = "pnlIncluir";
            this.pnlIncluir.Size = new System.Drawing.Size(88, 33);
            this.pnlIncluir.TabIndex = 15;
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.Controls.Add(this.btnCancelar);
            this.pnlAlterar.Controls.Add(this.btnAlterar);
            this.pnlAlterar.Location = new System.Drawing.Point(12, 168);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(160, 33);
            this.pnlAlterar.TabIndex = 16;
            this.pnlAlterar.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(0, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(81, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(136, 46);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(10, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = " ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 440);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pnlAlterar);
            this.Controls.Add(this.pnlIncluir);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlIncluir.ResumeLayout(false);
            this.pnlAlterar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Windows.Forms.Button btnSalvar;
        private Windows.Forms.TextBox txtNome;
        private Windows.Forms.TextBox txtTelefone;
        private Windows.Forms.Label lblNome;
        private Windows.Forms.Label lblTelefone;
        private Windows.Forms.ListBox listBox1;
        private Windows.Forms.Button btnDelete;
        private Windows.Forms.Button btnSelecionar;
        private Windows.Forms.Panel pnlIncluir;
        private Windows.Forms.Panel pnlAlterar;
        private Windows.Forms.Button btnCancelar;
        private Windows.Forms.Button btnAlterar;
        private Windows.Forms.Label lblId;
    }
}