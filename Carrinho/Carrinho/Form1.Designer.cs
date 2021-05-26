
namespace Carrinho
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
            this.label1 = new System.Windows.Forms.Label();
            this.btADcmp = new System.Windows.Forms.Button();
            this.ckbxLista = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbxCarrinho = new System.Windows.Forms.CheckedListBox();
            this.cbMerc = new System.Windows.Forms.ComboBox();
            this.btFim = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mercado";
            // 
            // btADcmp
            // 
            this.btADcmp.Location = new System.Drawing.Point(267, 24);
            this.btADcmp.Name = "btADcmp";
            this.btADcmp.Size = new System.Drawing.Size(75, 23);
            this.btADcmp.TabIndex = 2;
            this.btADcmp.Text = "Adicionar";
            this.btADcmp.UseVisualStyleBackColor = true;
            this.btADcmp.Click += new System.EventHandler(this.btADcmp_Click);
            // 
            // ckbxLista
            // 
            this.ckbxLista.FormattingEnabled = true;
            this.ckbxLista.Location = new System.Drawing.Point(412, 12);
            this.ckbxLista.Name = "ckbxLista";
            this.ckbxLista.Size = new System.Drawing.Size(120, 94);
            this.ckbxLista.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbxCarrinho);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrinho";
            // 
            // ckbxCarrinho
            // 
            this.ckbxCarrinho.FormattingEnabled = true;
            this.ckbxCarrinho.Location = new System.Drawing.Point(6, 19);
            this.ckbxCarrinho.Name = "ckbxCarrinho";
            this.ckbxCarrinho.Size = new System.Drawing.Size(496, 79);
            this.ckbxCarrinho.TabIndex = 4;
            this.ckbxCarrinho.SelectedValueChanged += new System.EventHandler(this.ckbxCarrinho_SelectedValueChanged);
            // 
            // cbMerc
            // 
            this.cbMerc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMerc.BackColor = System.Drawing.SystemColors.Window;
            this.cbMerc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMerc.FormattingEnabled = true;
            this.cbMerc.Location = new System.Drawing.Point(67, 26);
            this.cbMerc.Name = "cbMerc";
            this.cbMerc.Size = new System.Drawing.Size(194, 21);
            this.cbMerc.TabIndex = 1;
            // 
            // btFim
            // 
            this.btFim.Location = new System.Drawing.Point(457, 252);
            this.btFim.Name = "btFim";
            this.btFim.Size = new System.Drawing.Size(75, 23);
            this.btFim.TabIndex = 5;
            this.btFim.Text = "Finalizar";
            this.btFim.UseVisualStyleBackColor = true;
            this.btFim.Click += new System.EventHandler(this.btFim_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(15, 252);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "Remover";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Visible = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 279);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btFim);
            this.Controls.Add(this.cbMerc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckbxLista);
            this.Controls.Add(this.btADcmp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Carrinho";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btADcmp;
        private System.Windows.Forms.CheckedListBox ckbxLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox ckbxCarrinho;
        private System.Windows.Forms.ComboBox cbMerc;
        private System.Windows.Forms.Button btFim;
        private System.Windows.Forms.Button btRemove;
    }
}

