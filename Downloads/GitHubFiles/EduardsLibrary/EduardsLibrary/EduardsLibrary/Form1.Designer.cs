namespace EduardsLibrary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GdVerb = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslateRU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslateAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title1 = new System.Windows.Forms.Label();
            this.GdAdverb = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslateRU2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslateAM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GdAdjective = new System.Windows.Forms.DataGridView();
            this.id3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslateRU3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslateAM3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GdNoun = new System.Windows.Forms.DataGridView();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslateRU1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslateAM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title4 = new System.Windows.Forms.Label();
            this.title3 = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.btnArm = new System.Windows.Forms.Button();
            this.btnRu = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDEL = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TxtAddEng = new System.Windows.Forms.TextBox();
            this.TxtAddRu = new System.Windows.Forms.TextBox();
            this.TxtAddAm = new System.Windows.Forms.TextBox();
            this.AddSpreachBox = new System.Windows.Forms.ComboBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.DelSpreachBox = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GdVerb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdAdverb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdAdjective)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdNoun)).BeginInit();
            this.SuspendLayout();
            // 
            // GdVerb
            // 
            this.GdVerb.AccessibleDescription = "";
            this.GdVerb.AccessibleName = "";
            this.GdVerb.AllowUserToAddRows = false;
            this.GdVerb.AllowUserToDeleteRows = false;
            this.GdVerb.AllowUserToResizeColumns = false;
            this.GdVerb.AllowUserToResizeRows = false;
            this.GdVerb.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GdVerb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdVerb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Word,
            this.TranslateRU,
            this.TranslateAM});
            this.GdVerb.Location = new System.Drawing.Point(614, 430);
            this.GdVerb.Name = "GdVerb";
            this.GdVerb.Size = new System.Drawing.Size(510, 290);
            this.GdVerb.TabIndex = 0;
            this.GdVerb.Visible = false;
            this.GdVerb.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GdVerb_CellValueChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.DefaultCellStyle = dataGridViewCellStyle19;
            this.Word.HeaderText = "Word";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            this.Word.Width = 58;
            // 
            // TranslateRU
            // 
            this.TranslateRU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TranslateRU.DataPropertyName = "TranslateRU";
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TranslateRU.DefaultCellStyle = dataGridViewCellStyle20;
            this.TranslateRU.HeaderText = "TranslateRU";
            this.TranslateRU.Name = "TranslateRU";
            this.TranslateRU.ReadOnly = true;
            this.TranslateRU.Width = 92;
            // 
            // TranslateAM
            // 
            this.TranslateAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TranslateAM.DataPropertyName = "TranslateAM";
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TranslateAM.DefaultCellStyle = dataGridViewCellStyle21;
            this.TranslateAM.HeaderText = "TranslateAM";
            this.TranslateAM.Name = "TranslateAM";
            this.TranslateAM.ReadOnly = true;
            this.TranslateAM.Width = 92;
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(608, 396);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(71, 31);
            this.title1.TabIndex = 1;
            this.title1.Text = "Verb";
            this.title1.Visible = false;
            // 
            // GdAdverb
            // 
            this.GdAdverb.AccessibleDescription = "";
            this.GdAdverb.AccessibleName = "";
            this.GdAdverb.AllowUserToAddRows = false;
            this.GdAdverb.AllowUserToDeleteRows = false;
            this.GdAdverb.AllowUserToResizeColumns = false;
            this.GdAdverb.AllowUserToResizeRows = false;
            this.GdAdverb.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GdAdverb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdAdverb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.Word2,
            this.TranslateRU2,
            this.TranslateAM2});
            this.GdAdverb.Location = new System.Drawing.Point(614, 792);
            this.GdAdverb.Name = "GdAdverb";
            this.GdAdverb.ReadOnly = true;
            this.GdAdverb.Size = new System.Drawing.Size(510, 250);
            this.GdAdverb.TabIndex = 2;
            this.GdAdverb.Visible = false;
            // 
            // id2
            // 
            this.id2.DataPropertyName = "id";
            this.id2.HeaderText = "id";
            this.id2.Name = "id2";
            this.id2.ReadOnly = true;
            this.id2.Width = 40;
            // 
            // Word2
            // 
            this.Word2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Word2.DataPropertyName = "Word";
            this.Word2.HeaderText = "Word";
            this.Word2.Name = "Word2";
            this.Word2.ReadOnly = true;
            this.Word2.Width = 58;
            // 
            // TranslateRU2
            // 
            this.TranslateRU2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TranslateRU2.DataPropertyName = "TranslateRU";
            this.TranslateRU2.HeaderText = "TranslateRU";
            this.TranslateRU2.Name = "TranslateRU2";
            this.TranslateRU2.ReadOnly = true;
            this.TranslateRU2.Width = 92;
            // 
            // TranslateAM2
            // 
            this.TranslateAM2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TranslateAM2.DataPropertyName = "TranslateAM";
            this.TranslateAM2.HeaderText = "TranslateAM";
            this.TranslateAM2.Name = "TranslateAM2";
            this.TranslateAM2.ReadOnly = true;
            this.TranslateAM2.Width = 92;
            // 
            // GdAdjective
            // 
            this.GdAdjective.AccessibleDescription = "";
            this.GdAdjective.AccessibleName = "";
            this.GdAdjective.AllowUserToAddRows = false;
            this.GdAdjective.AllowUserToDeleteRows = false;
            this.GdAdjective.AllowUserToResizeColumns = false;
            this.GdAdjective.AllowUserToResizeRows = false;
            this.GdAdjective.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GdAdjective.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdAdjective.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id3,
            this.Word3,
            this.TranslateRU3,
            this.TranslateAM3});
            this.GdAdjective.Location = new System.Drawing.Point(38, 792);
            this.GdAdjective.Name = "GdAdjective";
            this.GdAdjective.ReadOnly = true;
            this.GdAdjective.Size = new System.Drawing.Size(510, 250);
            this.GdAdjective.TabIndex = 3;
            this.GdAdjective.Visible = false;
            // 
            // id3
            // 
            this.id3.DataPropertyName = "id";
            this.id3.HeaderText = "id";
            this.id3.Name = "id3";
            this.id3.ReadOnly = true;
            this.id3.Width = 40;
            // 
            // Word3
            // 
            this.Word3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Word3.DataPropertyName = "Word";
            this.Word3.HeaderText = "Word";
            this.Word3.Name = "Word3";
            this.Word3.ReadOnly = true;
            this.Word3.Width = 58;
            // 
            // TranslateRU3
            // 
            this.TranslateRU3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TranslateRU3.DataPropertyName = "TranslateRU";
            this.TranslateRU3.HeaderText = "TranslateRU";
            this.TranslateRU3.Name = "TranslateRU3";
            this.TranslateRU3.ReadOnly = true;
            this.TranslateRU3.Width = 92;
            // 
            // TranslateAM3
            // 
            this.TranslateAM3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TranslateAM3.DataPropertyName = "TranslateAM";
            this.TranslateAM3.HeaderText = "TranslateAM";
            this.TranslateAM3.Name = "TranslateAM3";
            this.TranslateAM3.ReadOnly = true;
            this.TranslateAM3.Width = 92;
            // 
            // GdNoun
            // 
            this.GdNoun.AccessibleDescription = "";
            this.GdNoun.AccessibleName = "";
            this.GdNoun.AllowUserToAddRows = false;
            this.GdNoun.AllowUserToDeleteRows = false;
            this.GdNoun.AllowUserToResizeColumns = false;
            this.GdNoun.AllowUserToResizeRows = false;
            this.GdNoun.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GdNoun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdNoun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.Word1,
            this.TranslateRU1,
            this.TranslateAM1});
            this.GdNoun.Location = new System.Drawing.Point(34, 430);
            this.GdNoun.Name = "GdNoun";
            this.GdNoun.ReadOnly = true;
            this.GdNoun.Size = new System.Drawing.Size(510, 290);
            this.GdNoun.TabIndex = 4;
            this.GdNoun.Visible = false;
            // 
            // id1
            // 
            this.id1.DataPropertyName = "id";
            this.id1.HeaderText = "id";
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            this.id1.Width = 40;
            // 
            // Word1
            // 
            this.Word1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Word1.DataPropertyName = "Word";
            this.Word1.HeaderText = "Word";
            this.Word1.Name = "Word1";
            this.Word1.ReadOnly = true;
            this.Word1.Width = 58;
            // 
            // TranslateRU1
            // 
            this.TranslateRU1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TranslateRU1.DataPropertyName = "TranslateRU";
            this.TranslateRU1.HeaderText = "TranslateRU";
            this.TranslateRU1.Name = "TranslateRU1";
            this.TranslateRU1.ReadOnly = true;
            this.TranslateRU1.Width = 92;
            // 
            // TranslateAM1
            // 
            this.TranslateAM1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TranslateAM1.DataPropertyName = "TranslateAM";
            this.TranslateAM1.HeaderText = "TranslateAM";
            this.TranslateAM1.Name = "TranslateAM1";
            this.TranslateAM1.ReadOnly = true;
            this.TranslateAM1.Width = 92;
            // 
            // title4
            // 
            this.title4.AutoSize = true;
            this.title4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title4.Location = new System.Drawing.Point(32, 758);
            this.title4.Name = "title4";
            this.title4.Size = new System.Drawing.Size(125, 31);
            this.title4.TabIndex = 5;
            this.title4.Text = "Adjective";
            this.title4.Visible = false;
            // 
            // title3
            // 
            this.title3.AutoSize = true;
            this.title3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title3.Location = new System.Drawing.Point(608, 758);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(100, 31);
            this.title3.TabIndex = 6;
            this.title3.Text = "Adverb";
            this.title3.Visible = false;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.Location = new System.Drawing.Point(32, 396);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(79, 31);
            this.title2.TabIndex = 7;
            this.title2.Text = "Noun";
            this.title2.Visible = false;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(206, 188);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(49, 188);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(151, 20);
            this.TxtSearch.TabIndex = 9;
            // 
            // TxtBox
            // 
            this.TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox.Location = new System.Drawing.Point(338, 39);
            this.TxtBox.Multiline = true;
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.ReadOnly = true;
            this.TxtBox.Size = new System.Drawing.Size(786, 205);
            this.TxtBox.TabIndex = 11;
            // 
            // btnArm
            // 
            this.btnArm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArm.BackgroundImage")));
            this.btnArm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArm.Location = new System.Drawing.Point(211, 99);
            this.btnArm.Name = "btnArm";
            this.btnArm.Size = new System.Drawing.Size(75, 49);
            this.btnArm.TabIndex = 12;
            this.btnArm.UseVisualStyleBackColor = true;
            this.btnArm.Click += new System.EventHandler(this.btnArm_Click);
            // 
            // btnRu
            // 
            this.btnRu.BackColor = System.Drawing.SystemColors.Control;
            this.btnRu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRu.BackgroundImage")));
            this.btnRu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRu.ForeColor = System.Drawing.Color.Black;
            this.btnRu.Location = new System.Drawing.Point(130, 99);
            this.btnRu.Name = "btnRu";
            this.btnRu.Size = new System.Drawing.Size(75, 49);
            this.btnRu.TabIndex = 13;
            this.btnRu.UseVisualStyleBackColor = false;
            this.btnRu.Click += new System.EventHandler(this.btnRu_Click);
            // 
            // btnEng
            // 
            this.btnEng.BackColor = System.Drawing.SystemColors.Control;
            this.btnEng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEng.BackgroundImage")));
            this.btnEng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEng.Location = new System.Drawing.Point(49, 99);
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(75, 49);
            this.btnEng.TabIndex = 14;
            this.btnEng.UseVisualStyleBackColor = false;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(788, 288);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(53, 27);
            this.butAdd.TabIndex = 15;
            this.butAdd.Text = "ADD";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Visible = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDEL
            // 
            this.butDEL.Location = new System.Drawing.Point(357, 317);
            this.butDEL.Name = "butDEL";
            this.butDEL.Size = new System.Drawing.Size(56, 24);
            this.butDEL.TabIndex = 16;
            this.butDEL.Text = "DEL";
            this.butDEL.UseVisualStyleBackColor = true;
            this.butDEL.Visible = false;
            this.butDEL.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(49, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Add";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TxtAddEng
            // 
            this.TxtAddEng.Location = new System.Drawing.Point(262, 291);
            this.TxtAddEng.Name = "TxtAddEng";
            this.TxtAddEng.Size = new System.Drawing.Size(151, 20);
            this.TxtAddEng.TabIndex = 18;
            this.TxtAddEng.Visible = false;
            // 
            // TxtAddRu
            // 
            this.TxtAddRu.Location = new System.Drawing.Point(438, 291);
            this.TxtAddRu.Name = "TxtAddRu";
            this.TxtAddRu.Size = new System.Drawing.Size(151, 20);
            this.TxtAddRu.TabIndex = 19;
            this.TxtAddRu.Visible = false;
            // 
            // TxtAddAm
            // 
            this.TxtAddAm.Location = new System.Drawing.Point(611, 291);
            this.TxtAddAm.Name = "TxtAddAm";
            this.TxtAddAm.Size = new System.Drawing.Size(151, 20);
            this.TxtAddAm.TabIndex = 20;
            this.TxtAddAm.Visible = false;
            // 
            // AddSpreachBox
            // 
            this.AddSpreachBox.FormattingEnabled = true;
            this.AddSpreachBox.Items.AddRange(new object[] {
            "Noun",
            "Adjective",
            "Verb",
            "Adverb"});
            this.AddSpreachBox.Location = new System.Drawing.Point(117, 290);
            this.AddSpreachBox.Name = "AddSpreachBox";
            this.AddSpreachBox.Size = new System.Drawing.Size(121, 21);
            this.AddSpreachBox.TabIndex = 21;
            this.AddSpreachBox.Text = "Sellect a spreach";
            this.AddSpreachBox.Visible = false;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(262, 319);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(89, 20);
            this.TxtId.TabIndex = 22;
            this.TxtId.Visible = false;
            // 
            // DelSpreachBox
            // 
            this.DelSpreachBox.FormattingEnabled = true;
            this.DelSpreachBox.Items.AddRange(new object[] {
            "Noun",
            "Adjective",
            "Verb",
            "Adverb"});
            this.DelSpreachBox.Location = new System.Drawing.Point(117, 320);
            this.DelSpreachBox.Name = "DelSpreachBox";
            this.DelSpreachBox.Size = new System.Drawing.Size(121, 21);
            this.DelSpreachBox.TabIndex = 23;
            this.DelSpreachBox.Text = "Sellect a spreach";
            this.DelSpreachBox.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(49, 322);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(42, 17);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Del";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(49, 39);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 25;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(990, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 123);
            this.button1.TabIndex = 26;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1225, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.DelSpreachBox);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.AddSpreachBox);
            this.Controls.Add(this.TxtAddAm);
            this.Controls.Add(this.TxtAddRu);
            this.Controls.Add(this.TxtAddEng);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.butDEL);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.btnRu);
            this.Controls.Add(this.btnArm);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.title3);
            this.Controls.Add(this.title4);
            this.Controls.Add(this.GdNoun);
            this.Controls.Add(this.GdAdjective);
            this.Controls.Add(this.GdAdverb);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.GdVerb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Eduard\'s Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GdVerb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdAdverb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdAdjective)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdNoun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GdVerb;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.DataGridView GdAdverb;
        private System.Windows.Forms.DataGridView GdAdjective;
        private System.Windows.Forms.DataGridView GdNoun;
        private System.Windows.Forms.Label title4;
        private System.Windows.Forms.Label title3;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Button btnArm;
        private System.Windows.Forms.Button btnRu;
        private System.Windows.Forms.Button btnEng;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDEL;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TxtAddEng;
        private System.Windows.Forms.TextBox TxtAddRu;
        private System.Windows.Forms.TextBox TxtAddAm;
        private System.Windows.Forms.ComboBox AddSpreachBox;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.ComboBox DelSpreachBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslateRU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslateAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslateRU2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslateAM2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslateRU3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslateAM3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslateRU1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslateAM1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
    }
}

