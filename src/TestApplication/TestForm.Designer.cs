namespace TestApplication
{
    partial class TestForm
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
            this.word = new System.Windows.Forms.TextBox();
            this.getSynSets = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.synSets = new System.Windows.Forms.ListBox();
            this.getRelatedSynSets = new System.Windows.Forms.Button();
            this.semanticRelations = new System.Windows.Forms.ListBox();
            this.pos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mostCommon = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.synsetID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wordNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lexicalRelations = new System.Windows.Forms.ListBox();
            this.computeSemSim = new System.Windows.Forms.Button();
            this.ss1 = new System.Windows.Forms.Label();
            this.ss2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // word
            // 
            this.word.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word.Location = new System.Drawing.Point(52, 28);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(133, 20);
            this.word.TabIndex = 0;
            this.word.TextChanged += new System.EventHandler(this.word_TextChanged);
            this.word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.word_KeyDown);
            // 
            // getSynSets
            // 
            this.getSynSets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getSynSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSynSets.Location = new System.Drawing.Point(482, 26);
            this.getSynSets.Name = "getSynSets";
            this.getSynSets.Size = new System.Drawing.Size(75, 23);
            this.getSynSets.TabIndex = 3;
            this.getSynSets.Text = "Get synsets";
            this.getSynSets.UseVisualStyleBackColor = true;
            this.getSynSets.Click += new System.EventHandler(this.getSynSets_Click);
            // 
            // test
            // 
            this.test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.test.Location = new System.Drawing.Point(690, 403);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(252, 23);
            this.test.TabIndex = 2;
            this.test.Text = "Test WordNet engine";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // synSets
            // 
            this.synSets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.synSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synSets.FormattingEnabled = true;
            this.synSets.Location = new System.Drawing.Point(13, 54);
            this.synSets.Name = "synSets";
            this.synSets.Size = new System.Drawing.Size(644, 134);
            this.synSets.TabIndex = 4;
            this.synSets.SelectedIndexChanged += new System.EventHandler(this.synSets_SelectedIndexChanged);
            this.synSets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.synSets_MouseDoubleClick);
            // 
            // getRelatedSynSets
            // 
            this.getRelatedSynSets.Enabled = false;
            this.getRelatedSynSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRelatedSynSets.Location = new System.Drawing.Point(13, 26);
            this.getRelatedSynSets.Name = "getRelatedSynSets";
            this.getRelatedSynSets.Size = new System.Drawing.Size(112, 23);
            this.getRelatedSynSets.TabIndex = 0;
            this.getRelatedSynSets.Text = "Get related synsets";
            this.getRelatedSynSets.UseVisualStyleBackColor = true;
            this.getRelatedSynSets.Click += new System.EventHandler(this.getRelatedSynSets_Click);
            // 
            // semanticRelations
            // 
            this.semanticRelations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.semanticRelations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semanticRelations.FormattingEnabled = true;
            this.semanticRelations.Location = new System.Drawing.Point(13, 54);
            this.semanticRelations.Name = "semanticRelations";
            this.semanticRelations.Size = new System.Drawing.Size(224, 134);
            this.semanticRelations.TabIndex = 1;
            this.semanticRelations.DoubleClick += new System.EventHandler(this.synSetRelations_DoubleClick);
            // 
            // pos
            // 
            this.pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos.FormattingEnabled = true;
            this.pos.Location = new System.Drawing.Point(229, 28);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(61, 21);
            this.pos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "POS:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mostCommon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.synsetID);
            this.groupBox1.Controls.Add(this.synSets);
            this.groupBox1.Controls.Add(this.word);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.getSynSets);
            this.groupBox1.Controls.Add(this.pos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Synsets";
            // 
            // mostCommon
            // 
            this.mostCommon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mostCommon.AutoSize = true;
            this.mostCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostCommon.Location = new System.Drawing.Point(563, 30);
            this.mostCommon.Name = "mostCommon";
            this.mostCommon.Size = new System.Drawing.Size(92, 17);
            this.mostCommon.TabIndex = 7;
            this.mostCommon.Text = "Most common";
            this.mostCommon.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // synsetID
            // 
            this.synsetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synsetID.Location = new System.Drawing.Point(323, 28);
            this.synsetID.Name = "synsetID";
            this.synsetID.Size = new System.Drawing.Size(139, 20);
            this.synsetID.TabIndex = 5;
            this.synsetID.TextChanged += new System.EventHandler(this.synsetID_TextChanged);
            this.synsetID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.synsetID_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.semanticRelations);
            this.groupBox2.Controls.Add(this.getRelatedSynSets);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(690, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Semantic relations";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordNetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wordNetToolStripMenuItem
            // 
            this.wordNetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.wordNetToolStripMenuItem.Name = "wordNetToolStripMenuItem";
            this.wordNetToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.wordNetToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lexicalRelations);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(691, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lexical relations";
            // 
            // lexicalRelations
            // 
            this.lexicalRelations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lexicalRelations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lexicalRelations.FormattingEnabled = true;
            this.lexicalRelations.HorizontalScrollbar = true;
            this.lexicalRelations.Location = new System.Drawing.Point(12, 25);
            this.lexicalRelations.Name = "lexicalRelations";
            this.lexicalRelations.Size = new System.Drawing.Size(224, 82);
            this.lexicalRelations.TabIndex = 1;
            // 
            // computeSemSim
            // 
            this.computeSemSim.Enabled = false;
            this.computeSemSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeSemSim.Location = new System.Drawing.Point(12, 87);
            this.computeSemSim.Name = "computeSemSim";
            this.computeSemSim.Size = new System.Drawing.Size(190, 23);
            this.computeSemSim.TabIndex = 8;
            this.computeSemSim.Text = "Compute semantic similarity";
            this.computeSemSim.UseVisualStyleBackColor = true;
            this.computeSemSim.Click += new System.EventHandler(this.computeSemSim_Click);
            // 
            // ss1
            // 
            this.ss1.AutoSize = true;
            this.ss1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss1.Location = new System.Drawing.Point(9, 40);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(132, 13);
            this.ss1.TabIndex = 9;
            this.ss1.Text = "Double-click synset to add";
            this.ss1.DoubleClick += new System.EventHandler(this.ss1_DoubleClick);
            // 
            // ss2
            // 
            this.ss2.AutoSize = true;
            this.ss2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss2.Location = new System.Drawing.Point(9, 60);
            this.ss2.Name = "ss2";
            this.ss2.Size = new System.Drawing.Size(132, 13);
            this.ss2.TabIndex = 10;
            this.ss2.Text = "Double-click synset to add";
            this.ss2.DoubleClick += new System.EventHandler(this.ss2_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ss1);
            this.groupBox4.Controls.Add(this.ss2);
            this.groupBox4.Controls.Add(this.computeSemSim);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(672, 130);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Semantic similarity";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 456);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(961, 490);
            this.Name = "TestForm";
            this.Text = "Test Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Button getSynSets;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox synSets;
        private System.Windows.Forms.Button getRelatedSynSets;
        private System.Windows.Forms.ListBox semanticRelations;
        private System.Windows.Forms.ComboBox pos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wordNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox synsetID;
        private System.Windows.Forms.CheckBox mostCommon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lexicalRelations;
        private System.Windows.Forms.Button computeSemSim;
        private System.Windows.Forms.Label ss2;
        private System.Windows.Forms.Label ss1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

