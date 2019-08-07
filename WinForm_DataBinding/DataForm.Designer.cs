namespace WinForm_DataBinding
{
    partial class DataForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.TeamTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.MembersListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MembersGrid = new System.Windows.Forms.DataGridView();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.TeamsComboBox = new System.Windows.Forms.ComboBox();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceComBox = new System.Windows.Forms.ComboBox();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MembersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 25);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 425);
            this.TabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NameTextBox);
            this.tabPage1.Controls.Add(this.EmailTextBox);
            this.tabPage1.Controls.Add(this.TeamTextBox);
            this.tabPage1.Controls.Add(this.IdTextBox);
            this.tabPage1.Controls.Add(this.MembersListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(289, 227);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(233, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(289, 126);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(233, 20);
            this.EmailTextBox.TabIndex = 4;
            // 
            // TeamTextBox
            // 
            this.TeamTextBox.Location = new System.Drawing.Point(289, 178);
            this.TeamTextBox.Name = "TeamTextBox";
            this.TeamTextBox.ReadOnly = true;
            this.TeamTextBox.Size = new System.Drawing.Size(233, 20);
            this.TeamTextBox.TabIndex = 3;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(289, 75);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(233, 20);
            this.IdTextBox.TabIndex = 2;
            // 
            // MembersListBox
            // 
            this.MembersListBox.FormattingEnabled = true;
            this.MembersListBox.Location = new System.Drawing.Point(28, 75);
            this.MembersListBox.Name = "MembersListBox";
            this.MembersListBox.Size = new System.Drawing.Size(186, 186);
            this.MembersListBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MembersGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grid";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MembersGrid
            // 
            this.MembersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembersGrid.Location = new System.Drawing.Point(3, 3);
            this.MembersGrid.Name = "MembersGrid";
            this.MembersGrid.Size = new System.Drawing.Size(786, 393);
            this.MembersGrid.TabIndex = 0;
            // 
            // NextButton
            // 
            this.NextButton.Image = global::WinForm_DataBinding.Properties.Resources.Forward_16xMD;
            this.NextButton.Location = new System.Drawing.Point(462, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(24, 23);
            this.NextButton.TabIndex = 3;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Image = global::WinForm_DataBinding.Properties.Resources.Backward_color_16xMD1;
            this.BackButton.Location = new System.Drawing.Point(432, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(24, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TeamsComboBox
            // 
            this.TeamsComboBox.FormattingEnabled = true;
            this.TeamsComboBox.Location = new System.Drawing.Point(52, 3);
            this.TeamsComboBox.Name = "TeamsComboBox";
            this.TeamsComboBox.Size = new System.Drawing.Size(166, 21);
            this.TeamsComboBox.TabIndex = 4;
            this.TeamsComboBox.SelectedIndexChanged += new System.EventHandler(this.TeamsComboBox_SelectedIndexChanged);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(800, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Team:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source:";
            // 
            // SourceComBox
            // 
            this.SourceComBox.FormattingEnabled = true;
            this.SourceComBox.Items.AddRange(new object[] {
            "Objects",
            "DataSets",
            "LinqToSQL"});
            this.SourceComBox.Location = new System.Drawing.Point(282, 4);
            this.SourceComBox.Name = "SourceComBox";
            this.SourceComBox.Size = new System.Drawing.Size(121, 21);
            this.SourceComBox.TabIndex = 7;
            this.SourceComBox.SelectedIndexChanged += new System.EventHandler(this.SourceComBox_SelectedIndexChanged);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SourceComBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamsComboBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ToolStrip);
            this.Name = "DataForm";
            this.Text = "Data Binding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MembersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView MembersGrid;
        private System.Windows.Forms.ListBox MembersListBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox TeamTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ComboBox TeamsComboBox;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SourceComBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}

