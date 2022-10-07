namespace Rider
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.MainMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuPictureBox
            // 
            this.MainMenuPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainMenuPictureBox.BackgroundImage")));
            this.MainMenuPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuPictureBox.Location = new System.Drawing.Point(490, 48);
            this.MainMenuPictureBox.Name = "MainMenuPictureBox";
            this.MainMenuPictureBox.Size = new System.Drawing.Size(279, 199);
            this.MainMenuPictureBox.TabIndex = 2;
            this.MainMenuPictureBox.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnEnd.ForeColor = System.Drawing.Color.Coral;
            this.btnEnd.Location = new System.Drawing.Point(576, 172);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(109, 50);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnStart.ForeColor = System.Drawing.Color.Coral;
            this.btnStart.Location = new System.Drawing.Point(576, 87);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 53);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.MainMenuPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartMenu_FormClosed);
            this.Load += new System.EventHandler(this.StartMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainMenuPictureBox;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
    }
}