namespace ListaTelefonica
{
    partial class Form1
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
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TelTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TelTable = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TelTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(475, 172);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(75, 20);
            this.lblTel.TabIndex = 0;
            this.lblTel.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(475, 125);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(565, 121);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(148, 26);
            this.NameTextBox.TabIndex = 2;
            // 
            // TelTextBox
            // 
            this.TelTextBox.Location = new System.Drawing.Point(565, 161);
            this.TelTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TelTextBox.Mask = "(99) 000000-0000";
            this.TelTextBox.Name = "TelTextBox";
            this.TelTextBox.Size = new System.Drawing.Size(148, 26);
            this.TelTextBox.TabIndex = 3;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(531, 215);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(96, 35);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Adicionar";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TelTable
            // 
            this.TelTable.AllowUserToAddRows = false;
            this.TelTable.AllowUserToDeleteRows = false;
            this.TelTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Telefone});
            this.TelTable.Location = new System.Drawing.Point(1, 18);
            this.TelTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TelTable.Name = "TelTable";
            this.TelTable.ReadOnly = true;
            this.TelTable.RowHeadersWidth = 62;
            this.TelTable.Size = new System.Drawing.Size(466, 372);
            this.TelTable.TabIndex = 5;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 8;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MinimumWidth = 8;
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 150;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(531, 260);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(96, 35);
            this.RemoveBtn.TabIndex = 6;
            this.RemoveBtn.Text = "Remover";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 411);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.TelTable);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TelTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "LISTA TELEFONICA";
            ((System.ComponentModel.ISupportInitialize)(this.TelTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.MaskedTextBox TelTextBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView TelTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.Button RemoveBtn;
    }
}
