﻿namespace Calculator
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
            this.hasil = new System.Windows.Forms.TextBox();
            this.bOn = new System.Windows.Forms.Button();
            this.bOff = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bMulti = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.bMin = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.bEq = new System.Windows.Forms.Button();
            this.bPoint = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hasil
            // 
            this.hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasil.Location = new System.Drawing.Point(13, 12);
            this.hasil.Multiline = true;
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(178, 34);
            this.hasil.TabIndex = 0;
            this.hasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bOn
            // 
            this.bOn.Location = new System.Drawing.Point(13, 63);
            this.bOn.Name = "bOn";
            this.bOn.Size = new System.Drawing.Size(40, 31);
            this.bOn.TabIndex = 1;
            this.bOn.Text = "ON";
            this.bOn.UseVisualStyleBackColor = true;
            this.bOn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bOff
            // 
            this.bOff.Location = new System.Drawing.Point(13, 63);
            this.bOff.Name = "bOff";
            this.bOff.Size = new System.Drawing.Size(40, 31);
            this.bOff.TabIndex = 2;
            this.bOff.Text = "OFF";
            this.bOff.UseVisualStyleBackColor = true;
            this.bOff.Click += new System.EventHandler(this.button2_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(59, 63);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(40, 31);
            this.bBack.TabIndex = 3;
            this.bBack.Text = "<--";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(105, 63);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(40, 31);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.button4_Click);
            // 
            // bMulti
            // 
            this.bMulti.Location = new System.Drawing.Point(151, 63);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(40, 31);
            this.bMulti.TabIndex = 5;
            this.bMulti.Text = "x";
            this.bMulti.UseVisualStyleBackColor = true;
            this.bMulti.Click += new System.EventHandler(this.button5_Click);
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(151, 100);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(40, 31);
            this.bDiv.TabIndex = 9;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(105, 100);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(40, 31);
            this.b9.TabIndex = 8;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(59, 100);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(40, 31);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button8_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(13, 100);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(40, 31);
            this.b7.TabIndex = 6;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button9_Click);
            // 
            // bMin
            // 
            this.bMin.Location = new System.Drawing.Point(151, 137);
            this.bMin.Name = "bMin";
            this.bMin.Size = new System.Drawing.Size(40, 31);
            this.bMin.TabIndex = 13;
            this.bMin.Text = "-";
            this.bMin.UseVisualStyleBackColor = true;
            this.bMin.Click += new System.EventHandler(this.bMin_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(105, 137);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(40, 31);
            this.b6.TabIndex = 12;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button11_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(59, 137);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(40, 31);
            this.b5.TabIndex = 11;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button12_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(13, 137);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(40, 31);
            this.b4.TabIndex = 10;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button13_Click);
            // 
            // bPlus
            // 
            this.bPlus.Location = new System.Drawing.Point(151, 174);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(40, 31);
            this.bPlus.TabIndex = 17;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(105, 174);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 31);
            this.b3.TabIndex = 16;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button15_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(59, 174);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(40, 31);
            this.b2.TabIndex = 15;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button16_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(13, 174);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 31);
            this.b1.TabIndex = 14;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button17_Click);
            // 
            // bEq
            // 
            this.bEq.Location = new System.Drawing.Point(105, 211);
            this.bEq.Name = "bEq";
            this.bEq.Size = new System.Drawing.Size(86, 31);
            this.bEq.TabIndex = 20;
            this.bEq.Text = "=";
            this.bEq.UseVisualStyleBackColor = true;
            this.bEq.Click += new System.EventHandler(this.bEq_Click);
            // 
            // bPoint
            // 
            this.bPoint.Location = new System.Drawing.Point(59, 211);
            this.bPoint.Name = "bPoint";
            this.bPoint.Size = new System.Drawing.Size(40, 31);
            this.bPoint.TabIndex = 19;
            this.bPoint.Text = ".";
            this.bPoint.UseVisualStyleBackColor = true;
            this.bPoint.Click += new System.EventHandler(this.button20_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(13, 211);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(40, 31);
            this.b0.TabIndex = 18;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.button21_Click);
            // 
            // prev
            // 
            this.prev.AutoSize = true;
            this.prev.BackColor = System.Drawing.SystemColors.Window;
            this.prev.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.prev.Location = new System.Drawing.Point(17, 16);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(0, 13);
            this.prev.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 255);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.bEq);
            this.Controls.Add(this.bPoint);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bMin);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.bMulti);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bOff);
            this.Controls.Add(this.bOn);
            this.Controls.Add(this.hasil);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hasil;
        private System.Windows.Forms.Button bOn;
        private System.Windows.Forms.Button bOff;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button bMin;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button bEq;
        private System.Windows.Forms.Button bPoint;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Label prev;
    }
}

