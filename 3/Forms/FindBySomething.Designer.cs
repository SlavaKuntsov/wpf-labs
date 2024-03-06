namespace _3.Forms.Find
{
    partial class FindBySomethingForm
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
            this.FormTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookLabel1 = new System.Windows.Forms.Label();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.NotFoundLabel = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.RegularFind = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormTitle.ForeColor = System.Drawing.Color.Silver;
            this.FormTitle.Location = new System.Drawing.Point(3, 0);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(936, 38);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "Find by ...";
            this.FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FormTitle);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.RegularFind);
            this.flowLayoutPanel1.Controls.Add(this.NotFoundLabel);
            this.flowLayoutPanel1.Controls.Add(this.Find);
            this.flowLayoutPanel1.Controls.Add(this.DataGridView);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(939, 702);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.BookLabel1);
            this.flowLayoutPanel2.Controls.Add(this.Input1);
            this.flowLayoutPanel2.Controls.Add(this.Input2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 71);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(936, 38);
            this.flowLayoutPanel2.TabIndex = 6;
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
            // Input1
            // 
            this.Input1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Input1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input1.Location = new System.Drawing.Point(166, 3);
            this.Input1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.Input1.MinimumSize = new System.Drawing.Size(300, 0);
            this.Input1.Multiline = true;
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(300, 32);
            this.Input1.TabIndex = 5;
            this.Input1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Input2
            // 
            this.Input2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Input2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input2.Location = new System.Drawing.Point(499, 3);
            this.Input2.MinimumSize = new System.Drawing.Size(300, 0);
            this.Input2.Multiline = true;
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(300, 32);
            this.Input2.TabIndex = 6;
            this.Input2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // NotFoundLabel
            // 
            this.NotFoundLabel.AutoSize = true;
            this.NotFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotFoundLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.NotFoundLabel.Location = new System.Drawing.Point(3, 185);
            this.NotFoundLabel.Name = "NotFoundLabel";
            this.NotFoundLabel.Size = new System.Drawing.Size(114, 25);
            this.NotFoundLabel.TabIndex = 8;
            this.NotFoundLabel.Text = "Not found";
            this.NotFoundLabel.Visible = false;
            // 
            // Find
            // 
            this.Find.FlatAppearance.BorderSize = 2;
            this.Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find.ForeColor = System.Drawing.Color.Silver;
            this.Find.Location = new System.Drawing.Point(3, 240);
            this.Find.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(187, 58);
            this.Find.TabIndex = 7;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridView.Location = new System.Drawing.Point(3, 331);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 72;
            this.DataGridView.RowTemplate.Height = 31;
            this.DataGridView.Size = new System.Drawing.Size(936, 368);
            this.DataGridView.TabIndex = 12;
            this.DataGridView.Visible = false;
            // 
            // RegularFind
            // 
            this.RegularFind.AutoSize = true;
            this.RegularFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegularFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.RegularFind.Location = new System.Drawing.Point(3, 132);
            this.RegularFind.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.RegularFind.Name = "RegularFind";
            this.RegularFind.Size = new System.Drawing.Size(273, 33);
            this.RegularFind.TabIndex = 13;
            this.RegularFind.Text = "Полное совпадение";
            this.RegularFind.UseVisualStyleBackColor = true;
            // 
            // FindBySomethingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(999, 762);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FindBySomethingForm";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "FindByPublisher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindBySomethingForm_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label BookLabel1;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label NotFoundLabel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.CheckBox RegularFind;
    }
}