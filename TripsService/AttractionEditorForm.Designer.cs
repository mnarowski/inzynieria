﻿namespace TripsService
{
    partial class AttractionEdiorForm
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
            this.textBoxNameAttraction = new System.Windows.Forms.TextBox();
            this.textBoxTypeAttraction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLongitudeAttraction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLatiudeAttraction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa";
            // 
            // textBoxNameAttraction
            // 
            this.textBoxNameAttraction.Location = new System.Drawing.Point(156, 34);
            this.textBoxNameAttraction.Name = "textBoxNameAttraction";
            this.textBoxNameAttraction.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameAttraction.TabIndex = 1;
            // 
            // textBoxTypeAttraction
            // 
            this.textBoxTypeAttraction.Location = new System.Drawing.Point(156, 59);
            this.textBoxTypeAttraction.Name = "textBoxTypeAttraction";
            this.textBoxTypeAttraction.Size = new System.Drawing.Size(100, 20);
            this.textBoxTypeAttraction.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Typ";
            // 
            // textBoxLongitudeAttraction
            // 
            this.textBoxLongitudeAttraction.Location = new System.Drawing.Point(156, 86);
            this.textBoxLongitudeAttraction.Name = "textBoxLongitudeAttraction";
            this.textBoxLongitudeAttraction.Size = new System.Drawing.Size(100, 20);
            this.textBoxLongitudeAttraction.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Długość geograficzna";
            // 
            // textBoxLatiudeAttraction
            // 
            this.textBoxLatiudeAttraction.Location = new System.Drawing.Point(156, 115);
            this.textBoxLatiudeAttraction.Name = "textBoxLatiudeAttraction";
            this.textBoxLatiudeAttraction.Size = new System.Drawing.Size(100, 20);
            this.textBoxLatiudeAttraction.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Szerokość geograficzna";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AttractionEdiorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLatiudeAttraction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLongitudeAttraction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTypeAttraction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameAttraction);
            this.Controls.Add(this.label1);
            this.Name = "AttractionEdiorForm";
            this.Text = "Atrakcje";
            this.Load += new System.EventHandler(this.AttractionEdiorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameAttraction;
        private System.Windows.Forms.TextBox textBoxTypeAttraction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLongitudeAttraction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLatiudeAttraction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}