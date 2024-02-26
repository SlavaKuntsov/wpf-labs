namespace _3
{
    partial class AuthorForm
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
            this.Heading = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookLabel1 = new System.Windows.Forms.Label();
            this.BookInput1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookLabel2 = new System.Windows.Forms.Label();
            this.BookInput2 = new System.Windows.Forms.TextBox();
            this.SaveAuthor = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Heading.Dock = System.Windows.Forms.DockStyle.Right;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading.ForeColor = System.Drawing.Color.Silver;
            this.Heading.Location = new System.Drawing.Point(3, 3);
            this.Heading.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(731, 60);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Add Author";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Heading);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.SaveAuthor);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(734, 638);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.BookLabel1);
            this.flowLayoutPanel2.Controls.Add(this.BookInput1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 116);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(731, 38);
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
            this.BookLabel1.Size = new System.Drawing.Size(150, 35);
            this.BookLabel1.TabIndex = 3;
            this.BookLabel1.Text = "Fullname:";
            this.BookLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookInput1
            // 
            this.BookInput1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BookInput1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookInput1.Location = new System.Drawing.Point(159, 3);
            this.BookInput1.Multiline = true;
            this.BookInput1.Name = "BookInput1";
            this.BookInput1.Size = new System.Drawing.Size(458, 32);
            this.BookInput1.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.BookLabel2);
            this.flowLayoutPanel3.Controls.Add(this.BookInput2);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 177);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(731, 38);
            this.flowLayoutPanel3.TabIndex = 7;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // BookLabel2
            // 
            this.BookLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.BookLabel2.Location = new System.Drawing.Point(3, 0);
            this.BookLabel2.Name = "BookLabel2";
            this.BookLabel2.Size = new System.Drawing.Size(150, 35);
            this.BookLabel2.TabIndex = 3;
            this.BookLabel2.Text = "Country:";
            this.BookLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookInput2
            // 
            this.BookInput2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BookInput2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookInput2.Location = new System.Drawing.Point(159, 3);
            this.BookInput2.Multiline = true;
            this.BookInput2.Name = "BookInput2";
            this.BookInput2.Size = new System.Drawing.Size(458, 32);
            this.BookInput2.TabIndex = 4;
            // 
            // SaveAuthor
            // 
            this.SaveAuthor.FlatAppearance.BorderSize = 2;
            this.SaveAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAuthor.ForeColor = System.Drawing.Color.Silver;
            this.SaveAuthor.Location = new System.Drawing.Point(3, 265);
            this.SaveAuthor.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.SaveAuthor.Name = "SaveAuthor";
            this.SaveAuthor.Size = new System.Drawing.Size(187, 58);
            this.SaveAuthor.TabIndex = 8;
            this.SaveAuthor.Text = "Save";
            this.SaveAuthor.UseVisualStyleBackColor = true;
            this.SaveAuthor.Click += new System.EventHandler(this.Save_Click);
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(794, 718);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AuthorForm";
            this.Padding = new System.Windows.Forms.Padding(30, 50, 30, 30);
            this.Text = "Author";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label BookLabel1;
        private System.Windows.Forms.TextBox BookInput1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label BookLabel2;
        private System.Windows.Forms.TextBox BookInput2;
        private System.Windows.Forms.Button SaveAuthor;
    }
}