namespace SPA5BlackBoxReader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelReadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelChngLangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSaveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSaveSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAboutProgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageDecEventTable = new System.Windows.Forms.TabPage();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxMessageText = new System.Windows.Forms.ComboBox();
            this.comboBoxEvAl = new System.Windows.Forms.ComboBox();
            this.comboBoxLxChannel = new System.Windows.Forms.ComboBox();
            this.comboBoxLxNumber = new System.Windows.Forms.ComboBox();
            this.dataGridViewEventsAndAlarms = new System.Windows.Forms.DataGridView();
            this.tabPageBin = new System.Windows.Forms.TabPage();
            this.richTextBoxBin = new System.Windows.Forms.RichTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPageDecEventTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsAndAlarms)).BeginInit();
            this.tabPageBin.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(974, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Margin = new System.Windows.Forms.Padding(12, 3, 1, 3);
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(400, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelFileToolStripMenuItem,
            this.labelInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelFileToolStripMenuItem
            // 
            this.labelFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelDecodeToolStripMenuItem,
            this.labelReadToolStripMenuItem,
            this.labelStopToolStripMenuItem,
            this.labelChngLangToolStripMenuItem,
            this.labelSaveAllToolStripMenuItem,
            this.labelSaveSelectedToolStripMenuItem,
            this.labelCloseToolStripMenuItem});
            this.labelFileToolStripMenuItem.Name = "labelFileToolStripMenuItem";
            this.labelFileToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.labelFileToolStripMenuItem.Text = "labelFile";
            // 
            // labelDecodeToolStripMenuItem
            // 
            this.labelDecodeToolStripMenuItem.Name = "labelDecodeToolStripMenuItem";
            this.labelDecodeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.labelDecodeToolStripMenuItem.Text = "labelDecode";
            this.labelDecodeToolStripMenuItem.Click += new System.EventHandler(this.labelDecodeToolStripMenuItem_Click);
            // 
            // labelReadToolStripMenuItem
            // 
            this.labelReadToolStripMenuItem.Name = "labelReadToolStripMenuItem";
            this.labelReadToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.labelReadToolStripMenuItem.Text = "labelRead";
            this.labelReadToolStripMenuItem.Click += new System.EventHandler(this.labelReadToolStripMenuItem_Click);
            // 
            // labelStopToolStripMenuItem
            // 
            this.labelStopToolStripMenuItem.Name = "labelStopToolStripMenuItem";
            this.labelStopToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.labelStopToolStripMenuItem.Text = "labelStop";
            this.labelStopToolStripMenuItem.Click += new System.EventHandler(this.labelStopToolStripMenuItem_Click);
            // 
            // labelChngLangToolStripMenuItem
            // 
            this.labelChngLangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polskiToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.labelChngLangToolStripMenuItem.Name = "labelChngLangToolStripMenuItem";
            this.labelChngLangToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.labelChngLangToolStripMenuItem.Text = "labelChngLang";
            // 
            // polskiToolStripMenuItem
            // 
            this.polskiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("polskiToolStripMenuItem.Image")));
            this.polskiToolStripMenuItem.Name = "polskiToolStripMenuItem";
            this.polskiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.polskiToolStripMenuItem.Text = "Polski";
            this.polskiToolStripMenuItem.Click += new System.EventHandler(this.polskiToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("englishToolStripMenuItem.Image")));
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // labelSaveAllToolStripMenuItem
            // 
            this.labelSaveAllToolStripMenuItem.Name = "labelSaveAllToolStripMenuItem";
            this.labelSaveAllToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.labelSaveAllToolStripMenuItem.Text = "labelSaveAll";
            this.labelSaveAllToolStripMenuItem.Click += new System.EventHandler(this.labelSaveAllToolStripMenuItem_Click);
            // 
            // labelSaveSelectedToolStripMenuItem
            // 
            this.labelSaveSelectedToolStripMenuItem.Name = "labelSaveSelectedToolStripMenuItem";
            this.labelSaveSelectedToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.labelSaveSelectedToolStripMenuItem.Text = "LabelSaveSelected";
            // 
            // labelCloseToolStripMenuItem
            // 
            this.labelCloseToolStripMenuItem.Name = "labelCloseToolStripMenuItem";
            this.labelCloseToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.labelCloseToolStripMenuItem.Text = "LabelClose";
            this.labelCloseToolStripMenuItem.Click += new System.EventHandler(this.labelCloseToolStripMenuItem_Click);
            // 
            // labelInfoToolStripMenuItem
            // 
            this.labelInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelAboutProgToolStripMenuItem});
            this.labelInfoToolStripMenuItem.Name = "labelInfoToolStripMenuItem";
            this.labelInfoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.labelInfoToolStripMenuItem.Text = "labelInfo";
            // 
            // labelAboutProgToolStripMenuItem
            // 
            this.labelAboutProgToolStripMenuItem.Name = "labelAboutProgToolStripMenuItem";
            this.labelAboutProgToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.labelAboutProgToolStripMenuItem.Text = "labelAboutProg";
            // 
            // tabPageDecEventTable
            // 
            this.tabPageDecEventTable.Controls.Add(this.comboBoxNumber);
            this.tabPageDecEventTable.Controls.Add(this.dateTimePickerTo);
            this.tabPageDecEventTable.Controls.Add(this.dateTimePickerFrom);
            this.tabPageDecEventTable.Controls.Add(this.comboBoxGroup);
            this.tabPageDecEventTable.Controls.Add(this.comboBoxCategory);
            this.tabPageDecEventTable.Controls.Add(this.comboBoxStatus);
            this.tabPageDecEventTable.Controls.Add(this.comboBoxMessageText);
            this.tabPageDecEventTable.Controls.Add(this.comboBoxEvAl);
            this.tabPageDecEventTable.Controls.Add(this.comboBoxLxChannel);
            this.tabPageDecEventTable.Controls.Add(this.comboBoxLxNumber);
            this.tabPageDecEventTable.Controls.Add(this.dataGridViewEventsAndAlarms);
            this.tabPageDecEventTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageDecEventTable.Name = "tabPageDecEventTable";
            this.tabPageDecEventTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDecEventTable.Size = new System.Drawing.Size(951, 423);
            this.tabPageDecEventTable.TabIndex = 2;
            this.tabPageDecEventTable.Text = "tabPageDecEventTable";
            this.tabPageDecEventTable.UseVisualStyleBackColor = true;
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.DropDownWidth = 60;
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Location = new System.Drawing.Point(389, 32);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(60, 21);
            this.comboBoxNumber.TabIndex = 10;
            this.comboBoxNumber.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLxNumber_SelectedValueChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(6, 32);
            this.dateTimePickerTo.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerTo.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(168, 20);
            this.dateTimePickerTo.TabIndex = 9;
            this.dateTimePickerTo.Value = new System.DateTime(2020, 12, 30, 0, 0, 0, 0);
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.comboBoxLxNumber_SelectedValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(6, 6);
            this.dateTimePickerFrom.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFrom.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(168, 20);
            this.dateTimePickerFrom.TabIndex = 8;
            this.dateTimePickerFrom.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.comboBoxLxNumber_SelectedValueChanged);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DropDownWidth = 110;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(869, 32);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(69, 21);
            this.comboBoxGroup.TabIndex = 7;
            this.comboBoxGroup.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLxNumber_SelectedValueChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownWidth = 110;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(759, 32);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(110, 21);
            this.comboBoxCategory.TabIndex = 6;
            this.comboBoxCategory.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLxNumber_SelectedValueChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownWidth = 110;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(649, 32);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(109, 21);
            this.comboBoxStatus.TabIndex = 5;
            this.comboBoxStatus.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLxNumber_SelectedValueChanged);
            // 
            // comboBoxMessageText
            // 
            this.comboBoxMessageText.DropDownWidth = 110;
            this.comboBoxMessageText.FormattingEnabled = true;
            this.comboBoxMessageText.Location = new System.Drawing.Point(449, 32);
            this.comboBoxMessageText.Name = "comboBoxMessageText";
            this.comboBoxMessageText.Size = new System.Drawing.Size(199, 21);
            this.comboBoxMessageText.TabIndex = 4;
            this.comboBoxMessageText.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLxNumber_SelectedValueChanged);
            // 
            // comboBoxEvAl
            // 
            this.comboBoxEvAl.DropDownWidth = 90;
            this.comboBoxEvAl.FormattingEnabled = true;
            this.comboBoxEvAl.Location = new System.Drawing.Point(299, 32);
            this.comboBoxEvAl.Name = "comboBoxEvAl";
            this.comboBoxEvAl.Size = new System.Drawing.Size(90, 21);
            this.comboBoxEvAl.TabIndex = 3;
            this.comboBoxEvAl.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLxNumber_SelectedValueChanged);
            // 
            // comboBoxLxChannel
            // 
            this.comboBoxLxChannel.DropDownWidth = 60;
            this.comboBoxLxChannel.FormattingEnabled = true;
            this.comboBoxLxChannel.Location = new System.Drawing.Point(238, 32);
            this.comboBoxLxChannel.Name = "comboBoxLxChannel";
            this.comboBoxLxChannel.Size = new System.Drawing.Size(60, 21);
            this.comboBoxLxChannel.TabIndex = 2;
            this.comboBoxLxChannel.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLxNumber_SelectedValueChanged);
            // 
            // comboBoxLxNumber
            // 
            this.comboBoxLxNumber.FormattingEnabled = true;
            this.comboBoxLxNumber.Location = new System.Drawing.Point(177, 32);
            this.comboBoxLxNumber.Name = "comboBoxLxNumber";
            this.comboBoxLxNumber.Size = new System.Drawing.Size(60, 21);
            this.comboBoxLxNumber.TabIndex = 1;
            this.comboBoxLxNumber.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLxNumber_SelectedValueChanged);
            // 
            // dataGridViewEventsAndAlarms
            // 
            this.dataGridViewEventsAndAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEventsAndAlarms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewEventsAndAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEventsAndAlarms.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewEventsAndAlarms.Location = new System.Drawing.Point(6, 57);
            this.dataGridViewEventsAndAlarms.Name = "dataGridViewEventsAndAlarms";
            this.dataGridViewEventsAndAlarms.RowTemplate.Height = 30;
            this.dataGridViewEventsAndAlarms.Size = new System.Drawing.Size(939, 333);
            this.dataGridViewEventsAndAlarms.TabIndex = 0;
            this.dataGridViewEventsAndAlarms.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewEventsAndAlarms_DataBindingComplete);
            // 
            // tabPageBin
            // 
            this.tabPageBin.Controls.Add(this.richTextBoxBin);
            this.tabPageBin.Location = new System.Drawing.Point(4, 22);
            this.tabPageBin.Name = "tabPageBin";
            this.tabPageBin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBin.Size = new System.Drawing.Size(951, 423);
            this.tabPageBin.TabIndex = 0;
            this.tabPageBin.Text = "labelBin";
            this.tabPageBin.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBin
            // 
            this.richTextBoxBin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxBin.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxBin.Name = "richTextBoxBin";
            this.richTextBoxBin.Size = new System.Drawing.Size(883, 316);
            this.richTextBoxBin.TabIndex = 1;
            this.richTextBoxBin.Text = "";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageDecEventTable);
            this.tabControl.Controls.Add(this.tabPageBin);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(959, 449);
            this.tabControl.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 501);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SPA-5 Black Box Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageDecEventTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsAndAlarms)).EndInit();
            this.tabPageBin.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem labelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelReadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelChngLangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelAboutProgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem labelStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelDecodeToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageDecEventTable;
        private System.Windows.Forms.DataGridView dataGridViewEventsAndAlarms;
        private System.Windows.Forms.TabPage tabPageBin;
        private System.Windows.Forms.RichTextBox richTextBoxBin;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ComboBox comboBoxLxNumber;
        private System.Windows.Forms.ComboBox comboBoxLxChannel;
        private System.Windows.Forms.ComboBox comboBoxEvAl;
        private System.Windows.Forms.ComboBox comboBoxMessageText;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.ToolStripMenuItem labelSaveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelSaveSelectedToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxNumber;
    }
}

