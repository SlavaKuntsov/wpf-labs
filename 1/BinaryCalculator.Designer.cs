using System.Windows.Forms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace _1
{
    partial class BinaryCalculator
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
            this.Container = new System.Windows.Forms.FlowLayoutPanel();
            this.Heading = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.FirsrValue = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.TextBox();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.SecondValue = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ComboBoxSystems = new System.Windows.Forms.ComboBox();
            this.OutputValue = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.Container.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Container.Controls.Add(this.Heading);
            this.Container.Controls.Add(this.InputLabel);
            this.Container.Controls.Add(this.flowLayoutPanel2);
            this.Container.Controls.Add(this.ComboBox);
            this.Container.Controls.Add(this.SecondValue);
            this.Container.Controls.Add(this.OutputLabel);
            this.Container.Controls.Add(this.ComboBoxSystems);
            this.Container.Controls.Add(this.OutputValue);
            this.Container.Controls.Add(this.ResetButton);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Container.Location = new System.Drawing.Point(30, 30);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(868, 842);
            this.Container.TabIndex = 2;
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading.ForeColor = System.Drawing.Color.Gray;
            this.Heading.Location = new System.Drawing.Point(3, 0);
            this.Heading.Margin = new System.Windows.Forms.Padding(3, 0, 3, 50);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(351, 48);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Binary Calculator:";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(87)))), ((int)(((byte)(145)))));
            this.InputLabel.Location = new System.Drawing.Point(3, 98);
            this.InputLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(103, 44);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.FirsrValue);
            this.flowLayoutPanel2.Controls.Add(this.Error);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 175);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(485, 49);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // FirsrValue
            // 
            this.FirsrValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.FirsrValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirsrValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirsrValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirsrValue.ForeColor = System.Drawing.Color.Gray;
            this.FirsrValue.Location = new System.Drawing.Point(3, 3);
            this.FirsrValue.Margin = new System.Windows.Forms.Padding(3, 3, 20, 10);
            this.FirsrValue.Multiline = true;
            this.FirsrValue.Name = "FirsrValue";
            this.FirsrValue.Size = new System.Drawing.Size(416, 36);
            this.FirsrValue.TabIndex = 3;
            this.FirsrValue.TextChanged += new System.EventHandler(this.FirstValue_changed);
            this.FirsrValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Error
            // 
            this.Error.BackColor = System.Drawing.Color.Red;
            this.Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error.ForeColor = System.Drawing.Color.White;
            this.Error.Location = new System.Drawing.Point(442, 3);
            this.Error.Multiline = true;
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(40, 36);
            this.Error.TabIndex = 0;
            this.Error.Text = "?";
            this.Error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComboBox
            // 
            this.ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox.ForeColor = System.Drawing.Color.Gray;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(3, 230);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(233, 37);
            this.ComboBox.TabIndex = 8;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_selectedChanged);
            // 
            // SecondValue
            // 
            this.SecondValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.SecondValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondValue.ForeColor = System.Drawing.Color.Gray;
            this.SecondValue.Location = new System.Drawing.Point(3, 280);
            this.SecondValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.SecondValue.Multiline = true;
            this.SecondValue.Name = "SecondValue";
            this.SecondValue.Size = new System.Drawing.Size(416, 36);
            this.SecondValue.TabIndex = 6;
            this.SecondValue.Text = this.FirsrValue.Text;
            this.SecondValue.TextChanged += new System.EventHandler(this.SecondValue_changed);
            this.SecondValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(87)))), ((int)(((byte)(145)))));
            this.OutputLabel.Location = new System.Drawing.Point(3, 366);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(134, 44);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.Text = "Output";
            // 
            // ComboBoxSystems
            // 
            this.ComboBoxSystems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ComboBoxSystems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSystems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxSystems.ForeColor = System.Drawing.Color.Gray;
            this.ComboBoxSystems.FormattingEnabled = true;
            this.ComboBoxSystems.Location = new System.Drawing.Point(3, 443);
            this.ComboBoxSystems.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ComboBoxSystems.Name = "ComboBoxSystems";
            this.ComboBoxSystems.Size = new System.Drawing.Size(233, 37);
            this.ComboBoxSystems.TabIndex = 2;
            this.ComboBoxSystems.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSystems_selectedChanged);
            // 
            // OutputValue
            // 
            this.OutputValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.OutputValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputValue.ForeColor = System.Drawing.Color.Gray;
            this.OutputValue.Location = new System.Drawing.Point(3, 493);
            this.OutputValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.OutputValue.Multiline = true;
            this.OutputValue.Name = "OutputValue";
            this.OutputValue.ReadOnly = true;
            this.OutputValue.Size = new System.Drawing.Size(416, 94);
            this.OutputValue.TabIndex = 7;
            this.OutputValue.Text = this.FirsrValue.Text;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(87)))), ((int)(((byte)(145)))));
            this.ResetButton.Location = new System.Drawing.Point(3, 640);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Padding = new System.Windows.Forms.Padding(10);
            this.ResetButton.Size = new System.Drawing.Size(177, 66);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BinaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(928, 902);
            this.Controls.Add(this.Container);
            this.Name = "BinaryCalculator";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "BinaryCalculator";
            this.Load += new System.EventHandler(this.BinaryCalculator_Load);
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.FlowLayoutPanel Container;
        private System.Windows.Forms.ComboBox ComboBoxSystems;
        private System.Windows.Forms.TextBox FirsrValue;
        private Label OutputLabel;
        private System.Windows.Forms.TextBox SecondValue;
        private System.Windows.Forms.TextBox OutputValue;
        private System.Windows.Forms.ComboBox ComboBox;
        private Label label3;
        private System.Windows.Forms.Button ResetButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox Error;
    }
}

