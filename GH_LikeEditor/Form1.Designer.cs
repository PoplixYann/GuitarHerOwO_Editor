
namespace GH_LikeEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.Ouvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BPM_Label = new System.Windows.Forms.Label();
            this.BPMBox = new System.Windows.Forms.NumericUpDown();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Moins = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Red = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yellow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Green = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TotalLinesLabel = new System.Windows.Forms.Label();
            this.TotalDurationLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MoinsBut = new System.Windows.Forms.Button();
            this.PlusBut = new System.Windows.Forms.Button();
            this.ModeCombo = new System.Windows.Forms.ComboBox();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BPMBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nouveau,
            this.Ouvrir,
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem,
            this.fermerToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // Nouveau
            // 
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(166, 22);
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // Ouvrir
            // 
            this.Ouvrir.Name = "Ouvrir";
            this.Ouvrir.Size = new System.Drawing.Size(166, 22);
            this.Ouvrir.Text = "Ouvrir";
            this.Ouvrir.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer...";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous...";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // BPM_Label
            // 
            this.BPM_Label.AutoSize = true;
            this.BPM_Label.Location = new System.Drawing.Point(29, 37);
            this.BPM_Label.Name = "BPM_Label";
            this.BPM_Label.Size = new System.Drawing.Size(32, 15);
            this.BPM_Label.TabIndex = 1;
            this.BPM_Label.Text = "BPM";
            // 
            // BPMBox
            // 
            this.BPMBox.Location = new System.Drawing.Point(67, 32);
            this.BPMBox.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.BPMBox.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.BPMBox.Name = "BPMBox";
            this.BPMBox.Size = new System.Drawing.Size(120, 23);
            this.BPMBox.TabIndex = 4;
            this.BPMBox.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.BPMBox.ValueChanged += new System.EventHandler(this.BPMBox_ValueChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 20;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Moins,
            this.Line,
            this.Time,
            this.Red,
            this.Yellow,
            this.Green,
            this.Blue,
            this.Plus});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.Location = new System.Drawing.Point(1, 71);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.Size = new System.Drawing.Size(680, 500);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.Visible = false;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            this.dataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);
            // 
            // Moins
            // 
            this.Moins.FillWeight = 30F;
            this.Moins.HeaderText = "M";
            this.Moins.Name = "Moins";
            this.Moins.ReadOnly = true;
            this.Moins.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Moins.Text = "-";
            // 
            // Line
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            this.Line.DefaultCellStyle = dataGridViewCellStyle3;
            this.Line.FillWeight = 70F;
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Line.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Time
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            this.Time.DefaultCellStyle = dataGridViewCellStyle4;
            this.Time.FillWeight = 70F;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Red
            // 
            this.Red.HeaderText = "Red";
            this.Red.Name = "Red";
            this.Red.ReadOnly = true;
            this.Red.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Red.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Yellow
            // 
            this.Yellow.HeaderText = "Yellow";
            this.Yellow.Name = "Yellow";
            this.Yellow.ReadOnly = true;
            this.Yellow.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Yellow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Green
            // 
            this.Green.HeaderText = "Green";
            this.Green.Name = "Green";
            this.Green.ReadOnly = true;
            this.Green.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Green.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Blue
            // 
            this.Blue.HeaderText = "Blue";
            this.Blue.Name = "Blue";
            this.Blue.ReadOnly = true;
            this.Blue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Blue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Plus
            // 
            this.Plus.FillWeight = 30F;
            this.Plus.HeaderText = "P";
            this.Plus.Name = "Plus";
            this.Plus.ReadOnly = true;
            this.Plus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Plus.Text = "+";
            // 
            // TotalLinesLabel
            // 
            this.TotalLinesLabel.AutoSize = true;
            this.TotalLinesLabel.Location = new System.Drawing.Point(35, 583);
            this.TotalLinesLabel.Name = "TotalLinesLabel";
            this.TotalLinesLabel.Size = new System.Drawing.Size(86, 15);
            this.TotalLinesLabel.TabIndex = 6;
            this.TotalLinesLabel.Text = "Total Lines : ***";
            // 
            // TotalDurationLabel
            // 
            this.TotalDurationLabel.AutoSize = true;
            this.TotalDurationLabel.Location = new System.Drawing.Point(303, 583);
            this.TotalDurationLabel.Name = "TotalDurationLabel";
            this.TotalDurationLabel.Size = new System.Drawing.Size(105, 15);
            this.TotalDurationLabel.TabIndex = 7;
            this.TotalDurationLabel.Text = "Total Duration : ***";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MoinsBut
            // 
            this.MoinsBut.Location = new System.Drawing.Point(579, 577);
            this.MoinsBut.Name = "MoinsBut";
            this.MoinsBut.Size = new System.Drawing.Size(29, 23);
            this.MoinsBut.TabIndex = 10;
            this.MoinsBut.Text = "-";
            this.MoinsBut.UseVisualStyleBackColor = true;
            this.MoinsBut.Click += new System.EventHandler(this.MoinsBut_Click);
            // 
            // PlusBut
            // 
            this.PlusBut.Location = new System.Drawing.Point(614, 577);
            this.PlusBut.Name = "PlusBut";
            this.PlusBut.Size = new System.Drawing.Size(29, 23);
            this.PlusBut.TabIndex = 11;
            this.PlusBut.Text = "+";
            this.PlusBut.UseVisualStyleBackColor = true;
            this.PlusBut.Click += new System.EventHandler(this.PlusBut_Click);
            // 
            // ModeCombo
            // 
            this.ModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeCombo.FormattingEnabled = true;
            this.ModeCombo.Items.AddRange(new object[] {
            "Fill",
            "Clear"});
            this.ModeCombo.Location = new System.Drawing.Point(413, 35);
            this.ModeCombo.Name = "ModeCombo";
            this.ModeCombo.Size = new System.Drawing.Size(121, 23);
            this.ModeCombo.TabIndex = 12;
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(369, 39);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(38, 15);
            this.ModeLabel.TabIndex = 13;
            this.ModeLabel.Text = "Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.ModeCombo);
            this.Controls.Add(this.PlusBut);
            this.Controls.Add(this.MoinsBut);
            this.Controls.Add(this.TotalDurationLabel);
            this.Controls.Add(this.TotalLinesLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.BPMBox);
            this.Controls.Add(this.BPM_Label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GH Like Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BPMBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ouvrir;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label BPM_Label;
        private System.Windows.Forms.NumericUpDown BPMBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label TotalLinesLabel;
        private System.Windows.Forms.Label TotalDurationLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem Nouveau;
        private System.Windows.Forms.Button MoinsBut;
        private System.Windows.Forms.Button PlusBut;
        private System.Windows.Forms.DataGridViewButtonColumn Moins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Red;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yellow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Green;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blue;
        private System.Windows.Forms.DataGridViewButtonColumn Plus;
        private System.Windows.Forms.ComboBox ModeCombo;
        private System.Windows.Forms.Label ModeLabel;
    }
}

