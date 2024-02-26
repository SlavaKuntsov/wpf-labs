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
            this.BookInput1 = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormTitle.ForeColor = System.Drawing.Color.Silver;
            this.FormTitle.Location = new System.Drawing.Point(3, 0);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(734, 44);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "Find by ...";
            this.FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FormTitle);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.Find);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 390);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.BookLabel1);
            this.flowLayoutPanel2.Controls.Add(this.BookInput1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 77);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(734, 38);
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
            // Find
            // 
            this.Find.FlatAppearance.BorderSize = 2;
            this.Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find.ForeColor = System.Drawing.Color.Silver;
            this.Find.Location = new System.Drawing.Point(3, 165);
            this.Find.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(187, 58);
            this.Find.TabIndex = 7;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // FindBySomethingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FindBySomethingForm";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "FindByPublisher";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label BookLabel1;
        private System.Windows.Forms.TextBox BookInput1;
        private System.Windows.Forms.Button Find;
    }
}