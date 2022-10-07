namespace Hatvacayin
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.radioEsb = new System.Windows.Forms.RadioButton();
            this.radioCfb = new System.Windows.Forms.RadioButton();
            this.radioPbc = new System.Windows.Forms.RadioButton();
            this.radioCbc = new System.Windows.Forms.RadioButton();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtReady = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtText.Location = new System.Drawing.Point(29, 23);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(303, 30);
            this.txtText.TabIndex = 0;
            // 
            // radioEsb
            // 
            this.radioEsb.AutoSize = true;
            this.radioEsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioEsb.Location = new System.Drawing.Point(29, 59);
            this.radioEsb.Name = "radioEsb";
            this.radioEsb.Size = new System.Drawing.Size(71, 29);
            this.radioEsb.TabIndex = 1;
            this.radioEsb.TabStop = true;
            this.radioEsb.Text = "ECB";
            this.radioEsb.UseVisualStyleBackColor = true;
            // 
            // radioCfb
            // 
            this.radioCfb.AutoSize = true;
            this.radioCfb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioCfb.Location = new System.Drawing.Point(262, 59);
            this.radioCfb.Name = "radioCfb";
            this.radioCfb.Size = new System.Drawing.Size(70, 29);
            this.radioCfb.TabIndex = 2;
            this.radioCfb.TabStop = true;
            this.radioCfb.Text = "CFB";
            this.radioCfb.UseVisualStyleBackColor = true;
            this.radioCfb.Visible = false;
            // 
            // radioPbc
            // 
            this.radioPbc.AutoSize = true;
            this.radioPbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioPbc.Location = new System.Drawing.Point(185, 59);
            this.radioPbc.Name = "radioPbc";
            this.radioPbc.Size = new System.Drawing.Size(71, 29);
            this.radioPbc.TabIndex = 3;
            this.radioPbc.TabStop = true;
            this.radioPbc.Text = "PBC";
            this.radioPbc.UseVisualStyleBackColor = true;
            this.radioPbc.Visible = false;
            // 
            // radioCbc
            // 
            this.radioCbc.AutoSize = true;
            this.radioCbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioCbc.Location = new System.Drawing.Point(106, 59);
            this.radioCbc.Name = "radioCbc";
            this.radioCbc.Size = new System.Drawing.Size(73, 29);
            this.radioCbc.TabIndex = 4;
            this.radioCbc.TabStop = true;
            this.radioCbc.Text = "CBC";
            this.radioCbc.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEncrypt.Location = new System.Drawing.Point(371, 91);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(89, 37);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtReady
            // 
            this.txtReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtReady.Location = new System.Drawing.Point(29, 94);
            this.txtReady.Name = "txtReady";
            this.txtReady.Size = new System.Drawing.Size(303, 30);
            this.txtReady.TabIndex = 6;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDecrypt.Location = new System.Drawing.Point(466, 91);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(89, 37);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtKey.Location = new System.Drawing.Point(371, 23);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(184, 30);
            this.txtKey.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(29, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 369);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Understand";
            this.Column1.Name = "Column1";
            this.Column1.Width = 87;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 578);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtReady);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.radioCbc);
            this.Controls.Add(this.radioPbc);
            this.Controls.Add(this.radioCfb);
            this.Controls.Add(this.radioEsb);
            this.Controls.Add(this.txtText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.RadioButton radioEsb;
        private System.Windows.Forms.RadioButton radioCfb;
        private System.Windows.Forms.RadioButton radioPbc;
        private System.Windows.Forms.RadioButton radioCbc;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtReady;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

