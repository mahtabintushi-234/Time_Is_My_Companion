namespace Lab5b
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
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.DoctorPictureBox = new System.Windows.Forms.PictureBox();
            this.FirstEpisodeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.SeriesTextBox = new System.Windows.Forms.TextBox();
            this.ActorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorComboBox = new System.Windows.Forms.ComboBox();
            this.CompanionsGroupBox = new System.Windows.Forms.GroupBox();
            this.CompanionsListBox = new System.Windows.Forms.ListBox();
            this.QueryOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.LinqRadioButton = new System.Windows.Forms.RadioButton();
            this.SqlRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPictureBox)).BeginInit();
            this.CompanionsGroupBox.SuspendLayout();
            this.QueryOptionsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.DoctorPictureBox);
            this.groupBoxDoctor.Controls.Add(this.FirstEpisodeTextBox);
            this.groupBoxDoctor.Controls.Add(this.label5);
            this.groupBoxDoctor.Controls.Add(this.AgeTextBox);
            this.groupBoxDoctor.Controls.Add(this.label6);
            this.groupBoxDoctor.Controls.Add(this.YearTextBox);
            this.groupBoxDoctor.Controls.Add(this.SeriesTextBox);
            this.groupBoxDoctor.Controls.Add(this.ActorTextBox);
            this.groupBoxDoctor.Controls.Add(this.label4);
            this.groupBoxDoctor.Controls.Add(this.label3);
            this.groupBoxDoctor.Controls.Add(this.label2);
            this.groupBoxDoctor.Controls.Add(this.label1);
            this.groupBoxDoctor.Controls.Add(this.DoctorComboBox);
            this.groupBoxDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDoctor.Location = new System.Drawing.Point(12, 70);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(490, 369);
            this.groupBoxDoctor.TabIndex = 0;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "The Doctor";
            // 
            // DoctorPictureBox
            // 
            this.DoctorPictureBox.Location = new System.Drawing.Point(350, 71);
            this.DoctorPictureBox.Name = "DoctorPictureBox";
            this.DoctorPictureBox.Size = new System.Drawing.Size(113, 178);
            this.DoctorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoctorPictureBox.TabIndex = 12;
            this.DoctorPictureBox.TabStop = false;
            // 
            // FirstEpisodeTextBox
            // 
            this.FirstEpisodeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FirstEpisodeTextBox.Location = new System.Drawing.Point(20, 276);
            this.FirstEpisodeTextBox.Name = "FirstEpisodeTextBox";
            this.FirstEpisodeTextBox.ReadOnly = true;
            this.FirstEpisodeTextBox.Size = new System.Drawing.Size(342, 26);
            this.FirstEpisodeTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "First Full Episode:\r\n";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AgeTextBox.Location = new System.Drawing.Point(132, 194);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.ReadOnly = true;
            this.AgeTextBox.Size = new System.Drawing.Size(166, 26);
            this.AgeTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Age at start:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.YearTextBox.Location = new System.Drawing.Point(111, 111);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.ReadOnly = true;
            this.YearTextBox.Size = new System.Drawing.Size(166, 26);
            this.YearTextBox.TabIndex = 5;
            // 
            // SeriesTextBox
            // 
            this.SeriesTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SeriesTextBox.Location = new System.Drawing.Point(111, 149);
            this.SeriesTextBox.Name = "SeriesTextBox";
            this.SeriesTextBox.ReadOnly = true;
            this.SeriesTextBox.Size = new System.Drawing.Size(166, 26);
            this.SeriesTextBox.TabIndex = 4;
            // 
            // ActorTextBox
            // 
            this.ActorTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ActorTextBox.Location = new System.Drawing.Point(111, 71);
            this.ActorTextBox.Name = "ActorTextBox";
            this.ActorTextBox.ReadOnly = true;
            this.ActorTextBox.Size = new System.Drawing.Size(166, 26);
            this.ActorTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Played By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Series:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year:\r\n\r\n";
            // 
            // DoctorComboBox
            // 
            this.DoctorComboBox.FormattingEnabled = true;
            this.DoctorComboBox.Location = new System.Drawing.Point(111, 19);
            this.DoctorComboBox.Name = "DoctorComboBox";
            this.DoctorComboBox.Size = new System.Drawing.Size(166, 28);
            this.DoctorComboBox.TabIndex = 0;
            this.DoctorComboBox.SelectedIndexChanged += new System.EventHandler(this.DoctorComboBox_SelectedIndexChanged);
            // 
            // CompanionsGroupBox
            // 
            this.CompanionsGroupBox.Controls.Add(this.CompanionsListBox);
            this.CompanionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanionsGroupBox.Location = new System.Drawing.Point(555, 25);
            this.CompanionsGroupBox.Name = "CompanionsGroupBox";
            this.CompanionsGroupBox.Size = new System.Drawing.Size(482, 491);
            this.CompanionsGroupBox.TabIndex = 1;
            this.CompanionsGroupBox.TabStop = false;
            this.CompanionsGroupBox.Text = "Companions and their first episode with this Doctor";
            // 
            // CompanionsListBox
            // 
            this.CompanionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanionsListBox.FormattingEnabled = true;
            this.CompanionsListBox.Location = new System.Drawing.Point(15, 45);
            this.CompanionsListBox.Name = "CompanionsListBox";
            this.CompanionsListBox.Size = new System.Drawing.Size(467, 368);
            this.CompanionsListBox.TabIndex = 0;
            // 
            // QueryOptionsGroupBox
            // 
            this.QueryOptionsGroupBox.Controls.Add(this.LinqRadioButton);
            this.QueryOptionsGroupBox.Controls.Add(this.SqlRadioButton);
            this.QueryOptionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryOptionsGroupBox.Location = new System.Drawing.Point(1043, 278);
            this.QueryOptionsGroupBox.Name = "QueryOptionsGroupBox";
            this.QueryOptionsGroupBox.Size = new System.Drawing.Size(144, 161);
            this.QueryOptionsGroupBox.TabIndex = 4;
            this.QueryOptionsGroupBox.TabStop = false;
            this.QueryOptionsGroupBox.Text = "Query";
            // 
            // LinqRadioButton
            // 
            this.LinqRadioButton.AutoSize = true;
            this.LinqRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinqRadioButton.Location = new System.Drawing.Point(18, 70);
            this.LinqRadioButton.Name = "LinqRadioButton";
            this.LinqRadioButton.Size = new System.Drawing.Size(124, 17);
            this.LinqRadioButton.TabIndex = 1;
            this.LinqRadioButton.TabStop = true;
            this.LinqRadioButton.Text = "Solve using LINQ\r\n";
            this.LinqRadioButton.UseVisualStyleBackColor = true;
            // 
            // SqlRadioButton
            // 
            this.SqlRadioButton.AutoSize = true;
            this.SqlRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlRadioButton.Location = new System.Drawing.Point(18, 34);
            this.SqlRadioButton.Name = "SqlRadioButton";
            this.SqlRadioButton.Size = new System.Drawing.Size(121, 17);
            this.SqlRadioButton.TabIndex = 0;
            this.SqlRadioButton.TabStop = true;
            this.SqlRadioButton.Text = "Solve Using SQL\r\n";
            this.SqlRadioButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1210, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::Lab5b.Properties.Resources.tardis;
            this.pictureBox2.Image = global::Lab5b.Properties.Resources.tardis;
            this.pictureBox2.Location = new System.Drawing.Point(1061, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 549);
            this.Controls.Add(this.QueryOptionsGroupBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CompanionsGroupBox);
            this.Controls.Add(this.groupBoxDoctor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Doctor and Companions";
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPictureBox)).EndInit();
            this.CompanionsGroupBox.ResumeLayout(false);
            this.QueryOptionsGroupBox.ResumeLayout(false);
            this.QueryOptionsGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.ComboBox DoctorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ActorTextBox;
        private System.Windows.Forms.TextBox SeriesTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.PictureBox DoctorPictureBox;
        private System.Windows.Forms.TextBox FirstEpisodeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox CompanionsGroupBox;
        private System.Windows.Forms.ListBox CompanionsListBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox QueryOptionsGroupBox;
        private System.Windows.Forms.RadioButton LinqRadioButton;
        private System.Windows.Forms.RadioButton SqlRadioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}

