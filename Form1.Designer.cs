﻿namespace Activity14
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstShapes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOutline = new System.Windows.Forms.RadioButton();
            this.rbFill = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a shape";
            // 
            // lstShapes
            // 
            this.lstShapes.FormattingEnabled = true;
            this.lstShapes.ItemHeight = 16;
            this.lstShapes.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectangle",
            "Pentagon",
            "Hexagon"});
            this.lstShapes.Location = new System.Drawing.Point(43, 112);
            this.lstShapes.Name = "lstShapes";
            this.lstShapes.Size = new System.Drawing.Size(120, 84);
            this.lstShapes.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOutline);
            this.groupBox1.Controls.Add(this.rbFill);
            this.groupBox1.Location = new System.Drawing.Point(43, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select fill mode";
            // 
            // rbOutline
            // 
            this.rbOutline.AutoSize = true;
            this.rbOutline.Location = new System.Drawing.Point(7, 59);
            this.rbOutline.Name = "rbOutline";
            this.rbOutline.Size = new System.Drawing.Size(69, 20);
            this.rbOutline.TabIndex = 1;
            this.rbOutline.TabStop = true;
            this.rbOutline.Text = "Outline";
            this.rbOutline.UseVisualStyleBackColor = true;
            // 
            // rbFill
            // 
            this.rbFill.AutoSize = true;
            this.rbFill.Location = new System.Drawing.Point(7, 22);
            this.rbFill.Name = "rbFill";
            this.rbFill.Size = new System.Drawing.Size(45, 20);
            this.rbFill.TabIndex = 0;
            this.rbFill.TabStop = true;
            this.rbFill.Text = "Fill";
            this.rbFill.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDate);
            this.groupBox2.Controls.Add(this.cbName);
            this.groupBox2.Location = new System.Drawing.Point(43, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select details";
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(7, 63);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(58, 20);
            this.cbDate.TabIndex = 3;
            this.cbDate.Text = "Date";
            this.cbDate.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Location = new System.Drawing.Point(7, 22);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(66, 20);
            this.cbName.TabIndex = 2;
            this.cbName.Text = "Name";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(307, 417);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(116, 28);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(454, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(379, 351);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(379, 317);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 16);
            this.lblDate.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(299, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 233);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstShapes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Shape Maker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstShapes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOutline;
        private System.Windows.Forms.RadioButton rbFill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel1;
    }
}