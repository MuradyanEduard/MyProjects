namespace MailImitator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxWhere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDefMail = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.labelPersent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnStart.Location = new System.Drawing.Point(60, 358);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(281, 90);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Generate";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelCount.Location = new System.Drawing.Point(55, 41);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(181, 25);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "Count of messages";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxCount.Location = new System.Drawing.Point(60, 69);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(281, 30);
            this.textBoxCount.TabIndex = 2;
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxWhere.Location = new System.Drawing.Point(60, 152);
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(239, 30);
            this.textBoxWhere.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(55, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Where send";
            // 
            // buttonDefMail
            // 
            this.buttonDefMail.Location = new System.Drawing.Point(306, 152);
            this.buttonDefMail.Name = "buttonDefMail";
            this.buttonDefMail.Size = new System.Drawing.Size(35, 30);
            this.buttonDefMail.TabIndex = 5;
            this.buttonDefMail.UseVisualStyleBackColor = true;
            this.buttonDefMail.Click += new System.EventHandler(this.buttonDefMail_Click);
            // 
            // pBar
            // 
            this.pBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pBar.Location = new System.Drawing.Point(60, 479);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(280, 42);
            this.pBar.TabIndex = 6;
            this.pBar.Visible = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnOpenFile.Location = new System.Drawing.Point(60, 236);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(281, 90);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.checkBoxAuto.Location = new System.Drawing.Point(60, 188);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(72, 29);
            this.checkBoxAuto.TabIndex = 9;
            this.checkBoxAuto.Text = "Auto";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            this.checkBoxAuto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelPersent
            // 
            this.labelPersent.AutoSize = true;
            this.labelPersent.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelPersent.Location = new System.Drawing.Point(346, 479);
            this.labelPersent.Name = "labelPersent";
            this.labelPersent.Size = new System.Drawing.Size(66, 39);
            this.labelPersent.TabIndex = 10;
            this.labelPersent.Text = "0%";
            this.labelPersent.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 555);
            this.Controls.Add(this.labelPersent);
            this.Controls.Add(this.checkBoxAuto);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.buttonDefMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWhere);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxWhere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDefMail;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxAuto;
        private System.Windows.Forms.Label labelPersent;
    }
}

