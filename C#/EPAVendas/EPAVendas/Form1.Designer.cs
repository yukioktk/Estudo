namespace EPAVendas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSalvarEmjson = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNomeComprador = new System.Windows.Forms.TextBox();
            this.textBoxEnderecoComprador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonFinalizarVenda = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(225, 104);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(119, 52);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(119, 78);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescricao.TabIndex = 2;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(119, 104);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidade.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade";
            // 
            // buttonSalvarEmjson
            // 
            this.buttonSalvarEmjson.Location = new System.Drawing.Point(225, 139);
            this.buttonSalvarEmjson.Name = "buttonSalvarEmjson";
            this.buttonSalvarEmjson.Size = new System.Drawing.Size(94, 23);
            this.buttonSalvarEmjson.TabIndex = 8;
            this.buttonSalvarEmjson.Text = "Salvar em Json";
            this.buttonSalvarEmjson.UseVisualStyleBackColor = true;
            this.buttonSalvarEmjson.Click += new System.EventHandler(this.buttonSalvarEmjson_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cadastro de produtos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Endereço";
            // 
            // textBoxNomeComprador
            // 
            this.textBoxNomeComprador.Location = new System.Drawing.Point(119, 289);
            this.textBoxNomeComprador.Name = "textBoxNomeComprador";
            this.textBoxNomeComprador.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomeComprador.TabIndex = 12;
            // 
            // textBoxEnderecoComprador
            // 
            this.textBoxEnderecoComprador.Location = new System.Drawing.Point(119, 314);
            this.textBoxEnderecoComprador.Name = "textBoxEnderecoComprador";
            this.textBoxEnderecoComprador.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnderecoComprador.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dados do comprador";
            // 
            // buttonFinalizarVenda
            // 
            this.buttonFinalizarVenda.Location = new System.Drawing.Point(133, 340);
            this.buttonFinalizarVenda.Name = "buttonFinalizarVenda";
            this.buttonFinalizarVenda.Size = new System.Drawing.Size(86, 23);
            this.buttonFinalizarVenda.TabIndex = 15;
            this.buttonFinalizarVenda.Text = "Finalizar venda";
            this.buttonFinalizarVenda.UseVisualStyleBackColor = true;
            this.buttonFinalizarVenda.Click += new System.EventHandler(this.buttonFinalizarVenda_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(325, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFinalizarVenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEnderecoComprador);
            this.Controls.Add(this.textBoxNomeComprador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSalvarEmjson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSalvarEmjson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNomeComprador;
        private System.Windows.Forms.TextBox textBoxEnderecoComprador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonFinalizarVenda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}

