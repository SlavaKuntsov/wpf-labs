using System.Windows.Forms;

namespace _3
{
	partial class Library
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
			this.Container = new System.Windows.Forms.FlowLayoutPanel();
			this.Heading = new System.Windows.Forms.Label();
			this.SmallLabel = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.BookLabel1 = new System.Windows.Forms.Label();
			this.BookInput1 = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.BookLabel2 = new System.Windows.Forms.Label();
			this.BookInputCombobox2 = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
			this.BookLabel3 = new System.Windows.Forms.Label();
			this.BookInput3 = new System.Windows.Forms.TextBox();
			this.RadioButton3_1 = new System.Windows.Forms.RadioButton();
			this.RadioButton3_2 = new System.Windows.Forms.RadioButton();
			this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
			this.BookLabel4 = new System.Windows.Forms.Label();
			this.BookInput4 = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
			this.BookLabel5 = new System.Windows.Forms.Label();
			this.YearPicker5 = new System.Windows.Forms.DateTimePicker();
			this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
			this.BookLabel6 = new System.Windows.Forms.Label();
			this.BookInput6 = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
			this.BookLabel7 = new System.Windows.Forms.Label();
			this.AddPublisher = new System.Windows.Forms.Button();
			this.PublisherInfo = new System.Windows.Forms.Label();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.BookLabel8 = new System.Windows.Forms.Label();
			this.AddAuthor = new System.Windows.Forms.Button();
			this.AuthorsList = new System.Windows.Forms.ListBox();
			this.SaveBook = new System.Windows.Forms.Button();
			this.OutputBooks = new System.Windows.Forms.Button();
			this.ResetButton = new System.Windows.Forms.Button();
			this.BigContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.FindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.SortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripReset = new System.Windows.Forms.ToolStripButton();
			this.ToolStripDelete = new System.Windows.Forms.ToolStripButton();
			this.ToolStripBack = new System.Windows.Forms.ToolStripButton();
			this.ToolStripNext = new System.Windows.Forms.ToolStripButton();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.BookFileCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.LastActionLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.TimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.DateLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.Container.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel7.SuspendLayout();
			this.flowLayoutPanel8.SuspendLayout();
			this.flowLayoutPanel9.SuspendLayout();
			this.flowLayoutPanel10.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.BigContainer.SuspendLayout();
			this.ToolStrip.SuspendLayout();
			this.ToolStrip2.SuspendLayout();
			this.StatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// Container
			// 
			this.Container.Controls.Add(this.Heading);
			this.Container.Controls.Add(this.SmallLabel);
			this.Container.Controls.Add(this.flowLayoutPanel2);
			this.Container.Controls.Add(this.flowLayoutPanel1);
			this.Container.Controls.Add(this.flowLayoutPanel6);
			this.Container.Controls.Add(this.flowLayoutPanel7);
			this.Container.Controls.Add(this.flowLayoutPanel8);
			this.Container.Controls.Add(this.flowLayoutPanel9);
			this.Container.Controls.Add(this.flowLayoutPanel10);
			this.Container.Controls.Add(this.flowLayoutPanel4);
			this.Container.Controls.Add(this.SaveBook);
			this.Container.Controls.Add(this.OutputBooks);
			this.Container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.Container.Location = new System.Drawing.Point(50, 130);
			this.Container.Margin = new System.Windows.Forms.Padding(50, 30, 50, 50);
			this.Container.Name = "Container";
			this.Container.Size = new System.Drawing.Size(1060, 1109);
			this.Container.TabIndex = 1;
			// 
			// Heading
			// 
			this.Heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Heading.Dock = System.Windows.Forms.DockStyle.Right;
			this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Heading.ForeColor = System.Drawing.Color.Silver;
			this.Heading.Location = new System.Drawing.Point(20, 3);
			this.Heading.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
			this.Heading.Name = "Heading";
			this.Heading.Size = new System.Drawing.Size(1092, 43);
			this.Heading.TabIndex = 1;
			this.Heading.Text = "Electronic library";
			this.Heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// SmallLabel
			// 
			this.SmallLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.SmallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SmallLabel.ForeColor = System.Drawing.Color.Gainsboro;
			this.SmallLabel.Location = new System.Drawing.Point(3, 99);
			this.SmallLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.SmallLabel.Name = "SmallLabel";
			this.SmallLabel.Size = new System.Drawing.Size(234, 32);
			this.SmallLabel.TabIndex = 2;
			this.SmallLabel.Text = "New Book File:";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.Controls.Add(this.BookLabel1);
			this.flowLayoutPanel2.Controls.Add(this.BookInput1);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 154);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(1109, 38);
			this.flowLayoutPanel2.TabIndex = 5;
			this.flowLayoutPanel2.WrapContents = false;
			// 
			// BookLabel1
			// 
			this.BookLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BookLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookLabel1.ForeColor = System.Drawing.Color.Gainsboro;
			this.BookLabel1.Location = new System.Drawing.Point(3, 0);
			this.BookLabel1.Name = "BookLabel1";
			this.BookLabel1.Size = new System.Drawing.Size(157, 35);
			this.BookLabel1.TabIndex = 3;
			this.BookLabel1.Text = "Name:";
			this.BookLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BookInput1
			// 
			this.BookInput1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.BookInput1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BookInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookInput1.Location = new System.Drawing.Point(166, 3);
			this.BookInput1.Multiline = true;
			this.BookInput1.Name = "BookInput1";
			this.BookInput1.Size = new System.Drawing.Size(458, 32);
			this.BookInput1.TabIndex = 4;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.BookLabel2);
			this.flowLayoutPanel1.Controls.Add(this.BookInputCombobox2);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 215);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1109, 39);
			this.flowLayoutPanel1.TabIndex = 6;
			this.flowLayoutPanel1.WrapContents = false;
			// 
			// BookLabel2
			// 
			this.BookLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BookLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookLabel2.ForeColor = System.Drawing.Color.Gainsboro;
			this.BookLabel2.Location = new System.Drawing.Point(3, 0);
			this.BookLabel2.Name = "BookLabel2";
			this.BookLabel2.Size = new System.Drawing.Size(157, 35);
			this.BookLabel2.TabIndex = 3;
			this.BookLabel2.Text = "Type:";
			this.BookLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BookInputCombobox2
			// 
			this.BookInputCombobox2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.BookInputCombobox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BookInputCombobox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BookInputCombobox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookInputCombobox2.FormattingEnabled = true;
			this.BookInputCombobox2.Location = new System.Drawing.Point(166, 3);
			this.BookInputCombobox2.Name = "BookInputCombobox2";
			this.BookInputCombobox2.Size = new System.Drawing.Size(134, 33);
			this.BookInputCombobox2.TabIndex = 4;
			// 
			// flowLayoutPanel6
			// 
			this.flowLayoutPanel6.AutoSize = true;
			this.flowLayoutPanel6.Controls.Add(this.BookLabel3);
			this.flowLayoutPanel6.Controls.Add(this.BookInput3);
			this.flowLayoutPanel6.Controls.Add(this.RadioButton3_1);
			this.flowLayoutPanel6.Controls.Add(this.RadioButton3_2);
			this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 277);
			this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.flowLayoutPanel6.Name = "flowLayoutPanel6";
			this.flowLayoutPanel6.Size = new System.Drawing.Size(1109, 38);
			this.flowLayoutPanel6.TabIndex = 9;
			this.flowLayoutPanel6.WrapContents = false;
			// 
			// BookLabel3
			// 
			this.BookLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BookLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookLabel3.ForeColor = System.Drawing.Color.Gainsboro;
			this.BookLabel3.Location = new System.Drawing.Point(3, 0);
			this.BookLabel3.Name = "BookLabel3";
			this.BookLabel3.Size = new System.Drawing.Size(157, 35);
			this.BookLabel3.TabIndex = 3;
			this.BookLabel3.Text = "File Size:";
			this.BookLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BookInput3
			// 
			this.BookInput3.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.BookInput3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BookInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookInput3.Location = new System.Drawing.Point(166, 3);
			this.BookInput3.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
			this.BookInput3.Multiline = true;
			this.BookInput3.Name = "BookInput3";
			this.BookInput3.Size = new System.Drawing.Size(458, 32);
			this.BookInput3.TabIndex = 4;
			this.BookInput3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// RadioButton3_1
			// 
			this.RadioButton3_1.AutoSize = true;
			this.RadioButton3_1.Checked = true;
			this.RadioButton3_1.ForeColor = System.Drawing.Color.Gainsboro;
			this.RadioButton3_1.Location = new System.Drawing.Point(657, 3);
			this.RadioButton3_1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
			this.RadioButton3_1.Name = "RadioButton3_1";
			this.RadioButton3_1.Size = new System.Drawing.Size(67, 29);
			this.RadioButton3_1.TabIndex = 5;
			this.RadioButton3_1.TabStop = true;
			this.RadioButton3_1.Text = "MB";
			this.RadioButton3_1.UseVisualStyleBackColor = true;
			// 
			// RadioButton3_2
			// 
			this.RadioButton3_2.AutoSize = true;
			this.RadioButton3_2.ForeColor = System.Drawing.Color.Gainsboro;
			this.RadioButton3_2.Location = new System.Drawing.Point(757, 3);
			this.RadioButton3_2.Name = "RadioButton3_2";
			this.RadioButton3_2.Size = new System.Drawing.Size(65, 29);
			this.RadioButton3_2.TabIndex = 6;
			this.RadioButton3_2.TabStop = true;
			this.RadioButton3_2.Text = "GB";
			this.RadioButton3_2.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel7
			// 
			this.flowLayoutPanel7.AutoSize = true;
			this.flowLayoutPanel7.Controls.Add(this.BookLabel4);
			this.flowLayoutPanel7.Controls.Add(this.BookInput4);
			this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 338);
			this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.flowLayoutPanel7.Name = "flowLayoutPanel7";
			this.flowLayoutPanel7.Size = new System.Drawing.Size(1109, 38);
			this.flowLayoutPanel7.TabIndex = 10;
			this.flowLayoutPanel7.WrapContents = false;
			// 
			// BookLabel4
			// 
			this.BookLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BookLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookLabel4.ForeColor = System.Drawing.Color.Gainsboro;
			this.BookLabel4.Location = new System.Drawing.Point(3, 0);
			this.BookLabel4.Name = "BookLabel4";
			this.BookLabel4.Size = new System.Drawing.Size(157, 35);
			this.BookLabel4.TabIndex = 3;
			this.BookLabel4.Text = "Page Count:";
			this.BookLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BookInput4
			// 
			this.BookInput4.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.BookInput4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BookInput4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookInput4.Location = new System.Drawing.Point(166, 3);
			this.BookInput4.Multiline = true;
			this.BookInput4.Name = "BookInput4";
			this.BookInput4.Size = new System.Drawing.Size(458, 32);
			this.BookInput4.TabIndex = 4;
			this.BookInput4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// flowLayoutPanel8
			// 
			this.flowLayoutPanel8.AutoSize = true;
			this.flowLayoutPanel8.Controls.Add(this.BookLabel5);
			this.flowLayoutPanel8.Controls.Add(this.YearPicker5);
			this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 399);
			this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.flowLayoutPanel8.Name = "flowLayoutPanel8";
			this.flowLayoutPanel8.Size = new System.Drawing.Size(1109, 37);
			this.flowLayoutPanel8.TabIndex = 11;
			this.flowLayoutPanel8.WrapContents = false;
			// 
			// BookLabel5
			// 
			this.BookLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BookLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookLabel5.ForeColor = System.Drawing.Color.Gainsboro;
			this.BookLabel5.Location = new System.Drawing.Point(3, 0);
			this.BookLabel5.Name = "BookLabel5";
			this.BookLabel5.Size = new System.Drawing.Size(157, 35);
			this.BookLabel5.TabIndex = 3;
			this.BookLabel5.Text = "Year:";
			this.BookLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// YearPicker5
			// 
			this.YearPicker5.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
			this.YearPicker5.Location = new System.Drawing.Point(166, 3);
			this.YearPicker5.Name = "YearPicker5";
			this.YearPicker5.Size = new System.Drawing.Size(200, 31);
			this.YearPicker5.TabIndex = 2;
			// 
			// flowLayoutPanel9
			// 
			this.flowLayoutPanel9.AutoSize = true;
			this.flowLayoutPanel9.Controls.Add(this.BookLabel6);
			this.flowLayoutPanel9.Controls.Add(this.BookInput6);
			this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 459);
			this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.flowLayoutPanel9.Name = "flowLayoutPanel9";
			this.flowLayoutPanel9.Size = new System.Drawing.Size(1109, 38);
			this.flowLayoutPanel9.TabIndex = 11;
			this.flowLayoutPanel9.WrapContents = false;
			// 
			// BookLabel6
			// 
			this.BookLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BookLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookLabel6.ForeColor = System.Drawing.Color.Gainsboro;
			this.BookLabel6.Location = new System.Drawing.Point(3, 0);
			this.BookLabel6.Name = "BookLabel6";
			this.BookLabel6.Size = new System.Drawing.Size(157, 35);
			this.BookLabel6.TabIndex = 3;
			this.BookLabel6.Text = "UDC:";
			this.BookLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BookInput6
			// 
			this.BookInput6.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.BookInput6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BookInput6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookInput6.Location = new System.Drawing.Point(166, 3);
			this.BookInput6.Multiline = true;
			this.BookInput6.Name = "BookInput6";
			this.BookInput6.Size = new System.Drawing.Size(458, 32);
			this.BookInput6.TabIndex = 4;
			this.BookInput6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// flowLayoutPanel10
			// 
			this.flowLayoutPanel10.AutoSize = true;
			this.flowLayoutPanel10.Controls.Add(this.BookLabel7);
			this.flowLayoutPanel10.Controls.Add(this.AddPublisher);
			this.flowLayoutPanel10.Controls.Add(this.PublisherInfo);
			this.flowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 520);
			this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.flowLayoutPanel10.Name = "flowLayoutPanel10";
			this.flowLayoutPanel10.Size = new System.Drawing.Size(1109, 43);
			this.flowLayoutPanel10.TabIndex = 31;
			this.flowLayoutPanel10.WrapContents = false;
			// 
			// BookLabel7
			// 
			this.BookLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BookLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookLabel7.ForeColor = System.Drawing.Color.Gainsboro;
			this.BookLabel7.Location = new System.Drawing.Point(3, 0);
			this.BookLabel7.Name = "BookLabel7";
			this.BookLabel7.Size = new System.Drawing.Size(154, 38);
			this.BookLabel7.TabIndex = 3;
			this.BookLabel7.Text = "Publisher:";
			this.BookLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AddPublisher
			// 
			this.AddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.AddPublisher.Location = new System.Drawing.Point(163, 3);
			this.AddPublisher.Name = "AddPublisher";
			this.AddPublisher.Size = new System.Drawing.Size(178, 37);
			this.AddPublisher.TabIndex = 4;
			this.AddPublisher.Text = "Add";
			this.AddPublisher.UseVisualStyleBackColor = true;
			this.AddPublisher.Click += new System.EventHandler(this.AddPublisher_Click);
			// 
			// PublisherInfo
			// 
			this.PublisherInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PublisherInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PublisherInfo.ForeColor = System.Drawing.Color.Gainsboro;
			this.PublisherInfo.Location = new System.Drawing.Point(347, 0);
			this.PublisherInfo.Name = "PublisherInfo";
			this.PublisherInfo.Size = new System.Drawing.Size(154, 38);
			this.PublisherInfo.TabIndex = 5;
			this.PublisherInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.PublisherInfo.Visible = false;
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.AutoSize = true;
			this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel5);
			this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
			this.flowLayoutPanel4.Controls.Add(this.AuthorsList);
			this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 586);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(1109, 336);
			this.flowLayoutPanel4.TabIndex = 5;
			// 
			// flowLayoutPanel5
			// 
			this.flowLayoutPanel5.AutoSize = true;
			this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Size = new System.Drawing.Size(0, 0);
			this.flowLayoutPanel5.TabIndex = 31;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.BookLabel8);
			this.flowLayoutPanel3.Controls.Add(this.AddAuthor);
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 9);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(1103, 40);
			this.flowLayoutPanel3.TabIndex = 30;
			this.flowLayoutPanel3.WrapContents = false;
			// 
			// BookLabel8
			// 
			this.BookLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BookLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BookLabel8.ForeColor = System.Drawing.Color.Gainsboro;
			this.BookLabel8.Location = new System.Drawing.Point(3, 0);
			this.BookLabel8.Name = "BookLabel8";
			this.BookLabel8.Size = new System.Drawing.Size(154, 38);
			this.BookLabel8.TabIndex = 3;
			this.BookLabel8.Text = "Author(s):";
			this.BookLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AddAuthor
			// 
			this.AddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.AddAuthor.Location = new System.Drawing.Point(163, 3);
			this.AddAuthor.Name = "AddAuthor";
			this.AddAuthor.Size = new System.Drawing.Size(178, 37);
			this.AddAuthor.TabIndex = 4;
			this.AddAuthor.Text = "Add";
			this.AddAuthor.UseVisualStyleBackColor = true;
			this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
			// 
			// AuthorsList
			// 
			this.AuthorsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.AuthorsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AuthorsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorsList.ForeColor = System.Drawing.Color.Gainsboro;
			this.AuthorsList.FormattingEnabled = true;
			this.AuthorsList.ItemHeight = 29;
			this.AuthorsList.Location = new System.Drawing.Point(3, 72);
			this.AuthorsList.Name = "AuthorsList";
			this.AuthorsList.Size = new System.Drawing.Size(1054, 261);
			this.AuthorsList.TabIndex = 0;
			// 
			// SaveBook
			// 
			this.SaveBook.FlatAppearance.BorderSize = 2;
			this.SaveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SaveBook.ForeColor = System.Drawing.Color.Silver;
			this.SaveBook.Location = new System.Drawing.Point(3, 955);
			this.SaveBook.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
			this.SaveBook.Name = "SaveBook";
			this.SaveBook.Size = new System.Drawing.Size(187, 58);
			this.SaveBook.TabIndex = 0;
			this.SaveBook.Text = "Save";
			this.SaveBook.UseVisualStyleBackColor = true;
			this.SaveBook.Click += new System.EventHandler(this.SaveBook_Click);
			// 
			// OutputBooks
			// 
			this.OutputBooks.FlatAppearance.BorderSize = 2;
			this.OutputBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OutputBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OutputBooks.ForeColor = System.Drawing.Color.Silver;
			this.OutputBooks.Location = new System.Drawing.Point(3, 1046);
			this.OutputBooks.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
			this.OutputBooks.Name = "OutputBooks";
			this.OutputBooks.Size = new System.Drawing.Size(187, 58);
			this.OutputBooks.TabIndex = 12;
			this.OutputBooks.Text = "Output";
			this.OutputBooks.UseVisualStyleBackColor = true;
			this.OutputBooks.Click += new System.EventHandler(this.OutputBooks_Click);
			// 
			// ResetButton
			// 
			this.ResetButton.Location = new System.Drawing.Point(0, 0);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(75, 23);
			this.ResetButton.TabIndex = 0;
			// 
			// BigContainer
			// 
			this.BigContainer.Controls.Add(this.ToolStrip);
			this.BigContainer.Controls.Add(this.ToolStrip2);
			this.BigContainer.Controls.Add(this.Container);
			this.BigContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BigContainer.Location = new System.Drawing.Point(0, 0);
			this.BigContainer.Name = "BigContainer";
			this.BigContainer.Size = new System.Drawing.Size(1169, 1309);
			this.BigContainer.TabIndex = 2;
			// 
			// ToolStrip
			// 
			this.ToolStrip.AutoSize = false;
			this.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.ToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindToolStripMenuItem,
            this.SortToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.AboutToolStripMenuItem});
			this.ToolStrip.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip.MinimumSize = new System.Drawing.Size(0, 50);
			this.ToolStrip.Name = "ToolStrip";
			this.ToolStrip.Size = new System.Drawing.Size(1169, 50);
			this.ToolStrip.Stretch = true;
			this.ToolStrip.TabIndex = 10;
			this.ToolStrip.Text = "toolStrip1";
			// 
			// FindToolStripMenuItem
			// 
			this.FindToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
			this.FindToolStripMenuItem.Name = "FindToolStripMenuItem";
			this.FindToolStripMenuItem.Size = new System.Drawing.Size(90, 50);
			this.FindToolStripMenuItem.Text = "Поиск";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(349, 40);
			this.toolStripMenuItem2.Text = "По издательству";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.FindByPublisher_ToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(349, 40);
			this.toolStripMenuItem3.Text = "По  году издания";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.FindByYear_ToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(349, 40);
			this.toolStripMenuItem4.Text = "По диапазону страниц";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.FindByPageCount_ToolStripMenuItem_Click);
			// 
			// SortToolStripMenuItem
			// 
			this.SortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
			this.SortToolStripMenuItem.Name = "SortToolStripMenuItem";
			this.SortToolStripMenuItem.Size = new System.Drawing.Size(145, 50);
			this.SortToolStripMenuItem.Text = "Сортировка";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(315, 40);
			this.toolStripMenuItem6.Text = "По названию";
			this.toolStripMenuItem6.Click += new System.EventHandler(this.SortByName_ToolStripMenuItem_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(293, 40);
			this.toolStripMenuItem7.Text = "По дате загрузки";
			this.toolStripMenuItem7.Click += new System.EventHandler(this.SortByUploadDate_ToolStripMenuItem_Click);
			// 
			// SaveToolStripMenuItem
			// 
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new System.Drawing.Size(133, 50);
			this.SaveToolStripMenuItem.Text = "Сохранить";
			this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToDifferentFiles_ToolStripMenuItem_Click);
			// 
			// AboutToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(161, 50);
			this.AboutToolStripMenuItem.Text = "О программе";
			this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramm_ToolStripMenuItem_Click);
			// 
			// ToolStrip2
			// 
			this.ToolStrip2.AutoSize = false;
			this.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None;
			this.ToolStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4,
            this.toolStripReset,
            this.ToolStripDelete,
            this.ToolStripBack,
            this.ToolStripNext});
			this.ToolStrip2.Location = new System.Drawing.Point(0, 50);
			this.ToolStrip2.MinimumSize = new System.Drawing.Size(0, 50);
			this.ToolStrip2.Name = "ToolStrip2";
			this.ToolStrip2.Size = new System.Drawing.Size(1169, 50);
			this.ToolStrip2.Stretch = true;
			this.ToolStrip2.TabIndex = 32;
			this.ToolStrip2.Text = "toolStrip1";
			// 
			// toolStripDropDownButton3
			// 
			this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem24,
            this.toolStripMenuItem25,
            this.toolStripMenuItem26});
			this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
			this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
			this.toolStripDropDownButton3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripDropDownButton3.Size = new System.Drawing.Size(69, 44);
			this.toolStripDropDownButton3.Text = "Find";
			// 
			// toolStripMenuItem24
			// 
			this.toolStripMenuItem24.Name = "toolStripMenuItem24";
			this.toolStripMenuItem24.Size = new System.Drawing.Size(349, 40);
			this.toolStripMenuItem24.Text = "По издательству";
			this.toolStripMenuItem24.Click += new System.EventHandler(this.FindByPublisher_ToolStripMenuItem_Click);
			// 
			// toolStripMenuItem25
			// 
			this.toolStripMenuItem25.Name = "toolStripMenuItem25";
			this.toolStripMenuItem25.Size = new System.Drawing.Size(349, 40);
			this.toolStripMenuItem25.Text = "По  году издания";
			this.toolStripMenuItem25.Click += new System.EventHandler(this.FindByYear_ToolStripMenuItem_Click);
			// 
			// toolStripMenuItem26
			// 
			this.toolStripMenuItem26.Name = "toolStripMenuItem26";
			this.toolStripMenuItem26.Size = new System.Drawing.Size(349, 40);
			this.toolStripMenuItem26.Text = "По диапазону страниц";
			this.toolStripMenuItem26.Click += new System.EventHandler(this.FindByPageCount_ToolStripMenuItem_Click);
			// 
			// toolStripDropDownButton4
			// 
			this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem27,
            this.toolStripMenuItem28});
			this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
			this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
			this.toolStripDropDownButton4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripDropDownButton4.Size = new System.Drawing.Size(69, 44);
			this.toolStripDropDownButton4.Text = "Sort";
			// 
			// toolStripMenuItem27
			// 
			this.toolStripMenuItem27.Name = "toolStripMenuItem27";
			this.toolStripMenuItem27.Size = new System.Drawing.Size(293, 40);
			this.toolStripMenuItem27.Text = "По названию";
			this.toolStripMenuItem27.Click += new System.EventHandler(this.SortByName_ToolStripMenuItem_Click);
			// 
			// toolStripMenuItem28
			// 
			this.toolStripMenuItem28.Name = "toolStripMenuItem28";
			this.toolStripMenuItem28.Size = new System.Drawing.Size(293, 40);
			this.toolStripMenuItem28.Text = "По дате загрузки";
			this.toolStripMenuItem28.Click += new System.EventHandler(this.SortByUploadDate_ToolStripMenuItem_Click);
			// 
			// toolStripReset
			// 
			this.toolStripReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripReset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReset.Image")));
			this.toolStripReset.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripReset.Name = "toolStripReset";
			this.toolStripReset.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripReset.Size = new System.Drawing.Size(52, 44);
			this.toolStripReset.Text = "Reset";
			this.toolStripReset.Click += new System.EventHandler(this.ToolStripResetAll_Click);
			// 
			// ToolStripDelete
			// 
			this.ToolStripDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripDelete.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripDelete.Image")));
			this.ToolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripDelete.Name = "ToolStripDelete";
			this.ToolStripDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ToolStripDelete.Size = new System.Drawing.Size(52, 44);
			this.ToolStripDelete.Text = "Delete";
			this.ToolStripDelete.Click += new System.EventHandler(this.ToolStripDelete_Click);
			// 
			// ToolStripBack
			// 
			this.ToolStripBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripBack.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBack.Image")));
			this.ToolStripBack.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripBack.Name = "ToolStripBack";
			this.ToolStripBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ToolStripBack.Size = new System.Drawing.Size(52, 44);
			this.ToolStripBack.Text = "Back";
			this.ToolStripBack.Click += new System.EventHandler(this.ToolStripBack_Click);
			// 
			// ToolStripNext
			// 
			this.ToolStripNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripNext.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripNext.Image")));
			this.ToolStripNext.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripNext.Name = "ToolStripNext";
			this.ToolStripNext.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ToolStripNext.Size = new System.Drawing.Size(52, 44);
			this.ToolStripNext.Text = "Next";
			this.ToolStripNext.Click += new System.EventHandler(this.ToolStripNext_Click);
			// 
			// StatusStrip
			// 
			this.StatusStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookFileCountLabel,
            this.LastActionLabel,
            this.TimeLabel,
            this.DateLabel});
			this.StatusStrip.Location = new System.Drawing.Point(0, 1270);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(1169, 39);
			this.StatusStrip.TabIndex = 3;
			this.StatusStrip.Text = "statusStrip1";
			// 
			// BookFileCountLabel
			// 
			this.BookFileCountLabel.BackColor = System.Drawing.Color.Transparent;
			this.BookFileCountLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.BookFileCountLabel.Margin = new System.Windows.Forms.Padding(0, 5, 10, 4);
			this.BookFileCountLabel.Name = "BookFileCountLabel";
			this.BookFileCountLabel.Size = new System.Drawing.Size(157, 30);
			this.BookFileCountLabel.Text = "BookFile Count:";
			this.BookFileCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LastActionLabel
			// 
			this.LastActionLabel.BackColor = System.Drawing.Color.Transparent;
			this.LastActionLabel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 4);
			this.LastActionLabel.Name = "LastActionLabel";
			this.LastActionLabel.Size = new System.Drawing.Size(819, 30);
			this.LastActionLabel.Spring = true;
			this.LastActionLabel.Text = "LastAction: ...";
			this.LastActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TimeLabel
			// 
			this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
			this.TimeLabel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 4);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(54, 30);
			this.TimeLabel.Text = "time";
			this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DateLabel
			// 
			this.DateLabel.BackColor = System.Drawing.Color.Transparent;
			this.DateLabel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 4);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(54, 30);
			this.DateLabel.Text = "date";
			// 
			// Library
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1169, 1309);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.BigContainer);
			this.Name = "Library";
			this.Text = "Library";
			this.Container.ResumeLayout(false);
			this.Container.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel6.ResumeLayout(false);
			this.flowLayoutPanel6.PerformLayout();
			this.flowLayoutPanel7.ResumeLayout(false);
			this.flowLayoutPanel7.PerformLayout();
			this.flowLayoutPanel8.ResumeLayout(false);
			this.flowLayoutPanel9.ResumeLayout(false);
			this.flowLayoutPanel9.PerformLayout();
			this.flowLayoutPanel10.ResumeLayout(false);
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.BigContainer.ResumeLayout(false);
			this.ToolStrip.ResumeLayout(false);
			this.ToolStrip.PerformLayout();
			this.ToolStrip2.ResumeLayout(false);
			this.ToolStrip2.PerformLayout();
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private System.Windows.Forms.Button SaveBook;
        private System.Windows.Forms.FlowLayoutPanel Container;
        private System.Windows.Forms.Label BookLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label SmallLabel;
        private System.Windows.Forms.TextBox BookInput1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label BookLabel2;
        private System.Windows.Forms.ComboBox BookInputCombobox2;
        private System.Windows.Forms.Button ResetButton;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label BookLabel8;
        private FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button AddAuthor;
        private FlowLayoutPanel flowLayoutPanel5;
        private ListBox AuthorsList;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label BookLabel3;
        private System.Windows.Forms.TextBox BookInput3;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label BookLabel4;
        private System.Windows.Forms.TextBox BookInput4;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label BookLabel5;
        private DateTimePicker YearPicker5;
        private RadioButton RadioButton3_1;
        private RadioButton RadioButton3_2;
        private System.Windows.Forms.Button OutputBooks;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label BookLabel6;
        private System.Windows.Forms.TextBox BookInput6;
        private FlowLayoutPanel flowLayoutPanel10;
        private Label BookLabel7;
        private System.Windows.Forms.Button AddPublisher;
        private Label PublisherInfo;
        private FlowLayoutPanel BigContainer;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel BookFileCountLabel;
        private ToolStripStatusLabel DateLabel;
        private ToolStripStatusLabel TimeLabel;
        private ToolStripStatusLabel LastActionLabel;
		private ToolStrip ToolStrip;
		private ToolStripMenuItem FindToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItem2;
		private ToolStripMenuItem toolStripMenuItem3;
		private ToolStripMenuItem toolStripMenuItem4;
		private ToolStripMenuItem SortToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItem6;
		private ToolStripMenuItem toolStripMenuItem7;
		private ToolStripMenuItem SaveToolStripMenuItem;
		private ToolStripMenuItem AboutToolStripMenuItem;
		private ToolStrip ToolStrip2;
		private ToolStripDropDownButton toolStripDropDownButton3;
		private ToolStripMenuItem toolStripMenuItem24;
		private ToolStripMenuItem toolStripMenuItem25;
		private ToolStripMenuItem toolStripMenuItem26;
		private ToolStripDropDownButton toolStripDropDownButton4;
		private ToolStripMenuItem toolStripMenuItem27;
		private ToolStripMenuItem toolStripMenuItem28;
		private ToolStripButton toolStripReset;
		private ToolStripButton ToolStripDelete;
		private ToolStripButton ToolStripBack;
		private ToolStripButton ToolStripNext;
	}
}

