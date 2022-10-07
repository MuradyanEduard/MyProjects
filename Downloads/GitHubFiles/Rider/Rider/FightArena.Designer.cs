namespace Rider
{
    partial class FightArena
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightArena));
            this.TmUnit = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TmUnit
            // 
            this.TmUnit.Interval = 35;
            this.TmUnit.Tick += new System.EventHandler(this.TmUnit_Tick);
            // 
            // FightArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 616);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FightArena";
            this.Text = "FightArena";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FightArena_FormClosed);
            this.Load += new System.EventHandler(this.FightArena_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FightArena_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FightArena_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FightArena_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TmUnit;
    }
}