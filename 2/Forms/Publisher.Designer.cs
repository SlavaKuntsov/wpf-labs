using System;

namespace _2.Forms
{
    partial class PublisherForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Heading = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookLabel1 = new System.Windows.Forms.Label();
            this.BookInput1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookLabel2 = new System.Windows.Forms.Label();
            this.BookInput2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookLabel3 = new System.Windows.Forms.Label();
            this.BookInput3 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookLabel4 = new System.Windows.Forms.Label();
            this.YearSelectResult = new System.Windows.Forms.Label();
            this.YearSelectBar4 = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookLabel5 = new System.Windows.Forms.Label();
            this.RadioButton5_1 = new System.Windows.Forms.RadioButton();
            this.RadioButton5_2 = new System.Windows.Forms.RadioButton();
            this.SavePublisher = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearSelectBar4)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Heading);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.SavePublisher);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(734, 638);
            this.flowLayoutPanel1.TabIndex = 3;
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
            this.Heading.Text = "Add Publisher";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BookLabel1.Text = "Name:";
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
            this.BookInput1.TextChanged += new System.EventHandler(this.BookInput1_TextChanged);
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
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.BookLabel3);
            this.flowLayoutPanel4.Controls.Add(this.BookInput3);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 238);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(731, 38);
            this.flowLayoutPanel4.TabIndex = 9;
            this.flowLayoutPanel4.WrapContents = false;
            // 
            // BookLabel3
            // 
            this.BookLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.BookLabel3.Location = new System.Drawing.Point(3, 0);
            this.BookLabel3.Name = "BookLabel3";
            this.BookLabel3.Size = new System.Drawing.Size(150, 35);
            this.BookLabel3.TabIndex = 3;
            this.BookLabel3.Text = "Sity:";
            this.BookLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookInput3
            // 
            this.BookInput3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BookInput3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookInput3.Location = new System.Drawing.Point(159, 3);
            this.BookInput3.Multiline = true;
            this.BookInput3.Name = "BookInput3";
            this.BookInput3.Size = new System.Drawing.Size(458, 32);
            this.BookInput3.TabIndex = 4;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.BookLabel4);
            this.flowLayoutPanel5.Controls.Add(this.YearSelectResult);
            this.flowLayoutPanel5.Controls.Add(this.YearSelectBar4);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 299);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(731, 55);
            this.flowLayoutPanel5.TabIndex = 10;
            this.flowLayoutPanel5.WrapContents = false;
            // 
            // BookLabel4
            // 
            this.BookLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookLabel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.BookLabel4.Location = new System.Drawing.Point(3, 0);
            this.BookLabel4.Name = "BookLabel4";
            this.BookLabel4.Size = new System.Drawing.Size(225, 35);
            this.BookLabel4.TabIndex = 3;
            this.BookLabel4.Text = "Year of foundation:";
            this.BookLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // YearSelectResult
            // 
            this.YearSelectResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearSelectResult.ForeColor = System.Drawing.Color.Gainsboro;
            this.YearSelectResult.Location = new System.Drawing.Point(234, 0);
            this.YearSelectResult.Name = "YearSelectResult";
            this.YearSelectResult.Size = new System.Drawing.Size(100, 35);
            this.YearSelectResult.TabIndex = 5;
            this.YearSelectResult.Text = "2024";
            this.YearSelectResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearSelectBar4
            // 
            this.YearSelectBar4.AutoSize = false;
            this.YearSelectBar4.Location = new System.Drawing.Point(340, 3);
            this.YearSelectBar4.Maximum = 2024;
            this.YearSelectBar4.Minimum = 1900;
            this.YearSelectBar4.Name = "YearSelectBar4";
            this.YearSelectBar4.Size = new System.Drawing.Size(302, 49);
            this.YearSelectBar4.TabIndex = 4;
            this.YearSelectBar4.TickFrequency = 10;
            this.YearSelectBar4.Value = 2024;
            this.YearSelectBar4.Scroll += new System.EventHandler(this.TrackBarYear_Scroll);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.BookLabel5);
            this.flowLayoutPanel6.Controls.Add(this.RadioButton5_1);
            this.flowLayoutPanel6.Controls.Add(this.RadioButton5_2);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 377);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(731, 35);
            this.flowLayoutPanel6.TabIndex = 11;
            this.flowLayoutPanel6.WrapContents = false;
            // 
            // BookLabel5
            // 
            this.BookLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookLabel5.ForeColor = System.Drawing.Color.Gainsboro;
            this.BookLabel5.Location = new System.Drawing.Point(3, 0);
            this.BookLabel5.Name = "BookLabel5";
            this.BookLabel5.Size = new System.Drawing.Size(150, 35);
            this.BookLabel5.TabIndex = 3;
            this.BookLabel5.Text = "Private:";
            this.BookLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RadioButton5_1
            // 
            this.RadioButton5_1.AutoSize = true;
            this.RadioButton5_1.Checked = true;
            this.RadioButton5_1.ForeColor = System.Drawing.Color.Gainsboro;
            this.RadioButton5_1.Location = new System.Drawing.Point(159, 3);
            this.RadioButton5_1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.RadioButton5_1.Name = "RadioButton5_1";
            this.RadioButton5_1.Size = new System.Drawing.Size(71, 29);
            this.RadioButton5_1.TabIndex = 6;
            this.RadioButton5_1.TabStop = true;
            this.RadioButton5_1.Text = "Yes";
            this.RadioButton5_1.UseVisualStyleBackColor = true;
            // 
            // RadioButton5_2
            // 
            this.RadioButton5_2.AutoSize = true;
            this.RadioButton5_2.ForeColor = System.Drawing.Color.Gainsboro;
            this.RadioButton5_2.Location = new System.Drawing.Point(263, 3);
            this.RadioButton5_2.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.RadioButton5_2.Name = "RadioButton5_2";
            this.RadioButton5_2.Size = new System.Drawing.Size(62, 29);
            this.RadioButton5_2.TabIndex = 7;
            this.RadioButton5_2.TabStop = true;
            this.RadioButton5_2.Text = "No";
            this.RadioButton5_2.UseVisualStyleBackColor = true;
            // 
            // SavePublisher
            // 
            this.SavePublisher.FlatAppearance.BorderSize = 2;
            this.SavePublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavePublisher.ForeColor = System.Drawing.Color.Silver;
            this.SavePublisher.Location = new System.Drawing.Point(3, 462);
            this.SavePublisher.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.SavePublisher.Name = "SavePublisher";
            this.SavePublisher.Size = new System.Drawing.Size(187, 58);
            this.SavePublisher.TabIndex = 8;
            this.SavePublisher.Text = "Save";
            this.SavePublisher.UseVisualStyleBackColor = true;
            this.SavePublisher.Click += new System.EventHandler(this.Save_Click);
            // 
            // PublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(794, 718);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PublisherForm";
            this.Padding = new System.Windows.Forms.Padding(30, 50, 30, 30);
            this.Text = "Publisher";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YearSelectBar4)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label BookLabel1;
        private System.Windows.Forms.TextBox BookInput1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label BookLabel2;
        private System.Windows.Forms.TextBox BookInput2;
        private System.Windows.Forms.Button SavePublisher;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label BookLabel3;
        private System.Windows.Forms.TextBox BookInput3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label BookLabel4;
        private System.Windows.Forms.TrackBar YearSelectBar4;
        private System.Windows.Forms.Label YearSelectResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label BookLabel5;
        private System.Windows.Forms.RadioButton RadioButton5_1;
        private System.Windows.Forms.RadioButton RadioButton5_2;
    }
}