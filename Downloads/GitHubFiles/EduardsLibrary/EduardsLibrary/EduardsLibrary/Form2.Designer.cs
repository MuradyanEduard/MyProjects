namespace EduardsLibrary
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.GdTrain = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslateRU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslateAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrueFalse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Red = new System.Windows.Forms.PictureBox();
            this.Green = new System.Windows.Forms.PictureBox();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.Tm1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BtnRotate = new System.Windows.Forms.Button();
            this.LessonCheckBox = new System.Windows.Forms.CheckedListBox();
            this.btnCheckBox = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.GdTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            this.SuspendLayout();
            // 
            // GdTrain
            // 
            this.GdTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdTrain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Word,
            this.TranslateRU,
            this.TranslateAM,
            this.Lesson,
            this.TrueFalse});
            this.GdTrain.Location = new System.Drawing.Point(90, 459);
            this.GdTrain.Name = "GdTrain";
            this.GdTrain.ReadOnly = true;
            this.GdTrain.Size = new System.Drawing.Size(518, 419);
            this.GdTrain.TabIndex = 0;
            this.GdTrain.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // Word
            // 
            this.Word.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Word.DataPropertyName = "Word";
            this.Word.HeaderText = "Word";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            this.Word.Width = 58;
            // 
            // TranslateRU
            // 
            this.TranslateRU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TranslateRU.DataPropertyName = "TranslateRU";
            this.TranslateRU.HeaderText = "TranslateRU";
            this.TranslateRU.Name = "TranslateRU";
            this.TranslateRU.ReadOnly = true;
            this.TranslateRU.Width = 92;
            // 
            // TranslateAM
            // 
            this.TranslateAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TranslateAM.DataPropertyName = "TranslateAM";
            this.TranslateAM.HeaderText = "TranslateAM";
            this.TranslateAM.Name = "TranslateAM";
            this.TranslateAM.ReadOnly = true;
            this.TranslateAM.Width = 92;
            // 
            // Lesson
            // 
            this.Lesson.DataPropertyName = "Lesson";
            this.Lesson.HeaderText = "№";
            this.Lesson.Name = "Lesson";
            this.Lesson.ReadOnly = true;
            this.Lesson.Width = 30;
            // 
            // TrueFalse
            // 
            this.TrueFalse.FalseValue = "";
            this.TrueFalse.HeaderText = "TrueFalse";
            this.TrueFalse.Name = "TrueFalse";
            this.TrueFalse.ReadOnly = true;
            this.TrueFalse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrueFalse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TrueFalse.TrueValue = "";
            // 
            // Red
            // 
            this.Red.Image = ((System.Drawing.Image)(resources.GetObject("Red.Image")));
            this.Red.Location = new System.Drawing.Point(745, 143);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(150, 150);
            this.Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Red.TabIndex = 1;
            this.Red.TabStop = false;
            this.Red.Visible = false;
            // 
            // Green
            // 
            this.Green.Image = ((System.Drawing.Image)(resources.GetObject("Green.Image")));
            this.Green.Location = new System.Drawing.Point(745, 143);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(150, 150);
            this.Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Green.TabIndex = 2;
            this.Green.TabStop = false;
            this.Green.Visible = false;
            // 
            // WordBox
            // 
            this.WordBox.BackColor = System.Drawing.SystemColors.Info;
            this.WordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F);
            this.WordBox.Location = new System.Drawing.Point(90, 213);
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(372, 77);
            this.WordBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.SystemColors.Info;
            this.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOk.Image = ((System.Drawing.Image)(resources.GetObject("BtnOk.Image")));
            this.BtnOk.Location = new System.Drawing.Point(468, 213);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(80, 80);
            this.BtnOk.TabIndex = 5;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // Tm1
            // 
            this.Tm1.Interval = 2000;
            this.Tm1.Tick += new System.EventHandler(this.Tm_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(741, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(814, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "Armenia",
            "Russia"});
            this.comboBox1.Location = new System.Drawing.Point(95, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 33);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "English",
            "Armenia",
            "Russia"});
            this.comboBox2.Location = new System.Drawing.Point(378, 143);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 33);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // BtnRotate
            // 
            this.BtnRotate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRotate.BackgroundImage")));
            this.BtnRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRotate.Location = new System.Drawing.Point(303, 143);
            this.BtnRotate.Name = "BtnRotate";
            this.BtnRotate.Size = new System.Drawing.Size(39, 33);
            this.BtnRotate.TabIndex = 11;
            this.BtnRotate.UseVisualStyleBackColor = true;
            this.BtnRotate.Click += new System.EventHandler(this.BtnRotate_Click);
            // 
            // LessonCheckBox
            // 
            this.LessonCheckBox.BackColor = System.Drawing.SystemColors.Info;
            this.LessonCheckBox.CheckOnClick = true;
            this.LessonCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LessonCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LessonCheckBox.FormattingEnabled = true;
            this.LessonCheckBox.Items.AddRange(new object[] {
            "Lesson 1",
            "Lesson 2",
            "Lesson 3",
            "Lesson 4",
            "Lesson 5",
            "GT1"});
            this.LessonCheckBox.Location = new System.Drawing.Point(608, 143);
            this.LessonCheckBox.Name = "LessonCheckBox";
            this.LessonCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LessonCheckBox.Size = new System.Drawing.Size(118, 109);
            this.LessonCheckBox.TabIndex = 12;
            this.LessonCheckBox.SelectedIndexChanged += new System.EventHandler(this.LessonCheckBox_SelectedIndexChanged);
            // 
            // btnCheckBox
            // 
            this.btnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCheckBox.Location = new System.Drawing.Point(608, 258);
            this.btnCheckBox.Name = "btnCheckBox";
            this.btnCheckBox.Size = new System.Drawing.Size(118, 43);
            this.btnCheckBox.TabIndex = 14;
            this.btnCheckBox.Text = "Enter";
            this.btnCheckBox.UseVisualStyleBackColor = true;
            this.btnCheckBox.Click += new System.EventHandler(this.btnCheckBox_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(90, 308);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(636, 124);
            this.listBox1.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1015, 467);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCheckBox);
            this.Controls.Add(this.LessonCheckBox);
            this.Controls.Add(this.BtnRotate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordBox);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.GdTrain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GdTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GdTrain;
        private System.Windows.Forms.PictureBox Red;
        private System.Windows.Forms.PictureBox Green;
        private System.Windows.Forms.TextBox WordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Timer Tm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslateRU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslateAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lesson;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrueFalse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BtnRotate;
        private System.Windows.Forms.CheckedListBox LessonCheckBox;
        private System.Windows.Forms.Button btnCheckBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}