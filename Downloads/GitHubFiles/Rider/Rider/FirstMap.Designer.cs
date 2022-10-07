namespace Rider
{
    partial class FirstMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstMap));
            this.TmMap = new System.Windows.Forms.Timer(this.components);
            this.TmUnits = new System.Windows.Forms.Timer(this.components);
            this.BtnPick = new System.Windows.Forms.Button();
            this.BtnAxe = new System.Windows.Forms.Button();
            this.BtnShovel = new System.Windows.Forms.Button();
            this.BtnHummer = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.ConsoleBox = new System.Windows.Forms.TextBox();
            this.BtnConsole = new System.Windows.Forms.Button();
            this.BtnWorker = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TmResultOfBattle = new System.Windows.Forms.Timer(this.components);
            this.easyGraph = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TmMap
            // 
            this.TmMap.Enabled = true;
            this.TmMap.Interval = 10;
            this.TmMap.Tick += new System.EventHandler(this.TmMap_Tick);
            // 
            // TmUnits
            // 
            this.TmUnits.Enabled = true;
            this.TmUnits.Interval = 1;
            this.TmUnits.Tick += new System.EventHandler(this.TmUnits_Tick);
            // 
            // BtnPick
            // 
            this.BtnPick.BackColor = System.Drawing.Color.Tomato;
            this.BtnPick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPick.BackgroundImage")));
            this.BtnPick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPick.Location = new System.Drawing.Point(508, 269);
            this.BtnPick.Name = "BtnPick";
            this.BtnPick.Size = new System.Drawing.Size(65, 63);
            this.BtnPick.TabIndex = 1;
            this.BtnPick.TabStop = false;
            this.BtnPick.UseVisualStyleBackColor = false;
            this.BtnPick.Visible = false;
            this.BtnPick.Click += new System.EventHandler(this.BtnPick_Click);
            // 
            // BtnAxe
            // 
            this.BtnAxe.BackColor = System.Drawing.Color.Tomato;
            this.BtnAxe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAxe.BackgroundImage")));
            this.BtnAxe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAxe.Location = new System.Drawing.Point(579, 269);
            this.BtnAxe.Name = "BtnAxe";
            this.BtnAxe.Size = new System.Drawing.Size(57, 63);
            this.BtnAxe.TabIndex = 2;
            this.BtnAxe.TabStop = false;
            this.BtnAxe.UseVisualStyleBackColor = false;
            this.BtnAxe.Visible = false;
            this.BtnAxe.Click += new System.EventHandler(this.BtnAxe_Click);
            // 
            // BtnShovel
            // 
            this.BtnShovel.BackColor = System.Drawing.Color.Tomato;
            this.BtnShovel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnShovel.BackgroundImage")));
            this.BtnShovel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnShovel.Location = new System.Drawing.Point(642, 269);
            this.BtnShovel.Name = "BtnShovel";
            this.BtnShovel.Size = new System.Drawing.Size(53, 63);
            this.BtnShovel.TabIndex = 3;
            this.BtnShovel.TabStop = false;
            this.BtnShovel.UseVisualStyleBackColor = false;
            this.BtnShovel.Visible = false;
            this.BtnShovel.Click += new System.EventHandler(this.BtnShovel_Click);
            // 
            // BtnHummer
            // 
            this.BtnHummer.BackColor = System.Drawing.Color.Tomato;
            this.BtnHummer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHummer.BackgroundImage")));
            this.BtnHummer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHummer.Location = new System.Drawing.Point(701, 269);
            this.BtnHummer.Name = "BtnHummer";
            this.BtnHummer.Size = new System.Drawing.Size(58, 63);
            this.BtnHummer.TabIndex = 4;
            this.BtnHummer.TabStop = false;
            this.BtnHummer.UseVisualStyleBackColor = false;
            this.BtnHummer.Visible = false;
            this.BtnHummer.Click += new System.EventHandler(this.BtnHummer_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRemove.BackgroundImage")));
            this.BtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRemove.Location = new System.Drawing.Point(556, 364);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(16, 12);
            this.BtnRemove.TabIndex = 5;
            this.BtnRemove.TabStop = false;
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Visible = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.BackColor = System.Drawing.Color.Blue;
            this.ConsoleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ConsoleBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ConsoleBox.Location = new System.Drawing.Point(22, 56);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(175, 30);
            this.ConsoleBox.TabIndex = 6;
            this.ConsoleBox.TabStop = false;
            this.ConsoleBox.Visible = false;
            this.ConsoleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsoleBox_KeyDown);
            // 
            // BtnConsole
            // 
            this.BtnConsole.BackColor = System.Drawing.Color.Red;
            this.BtnConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnConsole.ForeColor = System.Drawing.Color.White;
            this.BtnConsole.Location = new System.Drawing.Point(203, 56);
            this.BtnConsole.Name = "BtnConsole";
            this.BtnConsole.Size = new System.Drawing.Size(74, 30);
            this.BtnConsole.TabIndex = 7;
            this.BtnConsole.Text = "Send!";
            this.BtnConsole.UseVisualStyleBackColor = false;
            this.BtnConsole.Visible = false;
            this.BtnConsole.Click += new System.EventHandler(this.BtnConsole_Click);
            // 
            // BtnWorker
            // 
            this.BtnWorker.BackColor = System.Drawing.Color.Khaki;
            this.BtnWorker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnWorker.BackgroundImage")));
            this.BtnWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnWorker.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnWorker.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnWorker.Location = new System.Drawing.Point(508, 361);
            this.BtnWorker.Name = "BtnWorker";
            this.BtnWorker.Size = new System.Drawing.Size(65, 59);
            this.BtnWorker.TabIndex = 0;
            this.BtnWorker.TabStop = false;
            this.BtnWorker.UseVisualStyleBackColor = false;
            this.BtnWorker.Click += new System.EventHandler(this.BtnWorker_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Blue;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(613, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 30);
            this.textBox2.TabIndex = 9;
            this.textBox2.TabStop = false;
            this.textBox2.Visible = false;
            // 
            // TmResultOfBattle
            // 
            this.TmResultOfBattle.Tick += new System.EventHandler(this.TmResultOfBattle_Tick);
            // 
            // easyGraph
            // 
            this.easyGraph.AutoSize = true;
            this.easyGraph.Location = new System.Drawing.Point(12, 12);
            this.easyGraph.Name = "easyGraph";
            this.easyGraph.Size = new System.Drawing.Size(57, 17);
            this.easyGraph.TabIndex = 10;
            this.easyGraph.Text = "Simple";
            this.easyGraph.UseVisualStyleBackColor = true;
            this.easyGraph.CheckedChanged += new System.EventHandler(this.easyGraph_CheckedChanged);
            // 
            // FirstMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.easyGraph);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnConsole);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnHummer);
            this.Controls.Add(this.BtnShovel);
            this.Controls.Add(this.BtnAxe);
            this.Controls.Add(this.BtnPick);
            this.Controls.Add(this.BtnWorker);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstMap";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.FirstMap_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TmMap;
        private System.Windows.Forms.Timer TmUnits;
        private System.Windows.Forms.Button BtnPick;
        private System.Windows.Forms.Button BtnAxe;
        private System.Windows.Forms.Button BtnShovel;
        private System.Windows.Forms.Button BtnHummer;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.TextBox ConsoleBox;
        private System.Windows.Forms.Button BtnConsole;
        private System.Windows.Forms.Button BtnWorker;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer TmResultOfBattle;
        private System.Windows.Forms.CheckBox easyGraph;
    }
}

