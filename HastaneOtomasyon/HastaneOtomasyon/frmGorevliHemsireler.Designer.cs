﻿namespace HastaneOtomasyon
{
    partial class frmGorevliHemsireler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDoktorlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hemşireler = new System.Windows.Forms.GroupBox();
            this.lstHemsireler = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.Hemşireler.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDoktorlar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktorlar";
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDoktorlar.FullRowSelect = true;
            this.lstDoktorlar.GridLines = true;
            this.lstDoktorlar.HideSelection = false;
            this.lstDoktorlar.Location = new System.Drawing.Point(10, 55);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(319, 238);
            this.lstDoktorlar.TabIndex = 0;
            this.lstDoktorlar.UseCompatibleStateImageBehavior = false;
            this.lstDoktorlar.View = System.Windows.Forms.View.Details;
            this.lstDoktorlar.SelectedIndexChanged += new System.EventHandler(this.lstDoktorlar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 171;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ara:";
            // 
            // Hemşireler
            // 
            this.Hemşireler.Controls.Add(this.lstHemsireler);
            this.Hemşireler.Location = new System.Drawing.Point(421, 24);
            this.Hemşireler.Name = "Hemşireler";
            this.Hemşireler.Size = new System.Drawing.Size(347, 293);
            this.Hemşireler.TabIndex = 1;
            this.Hemşireler.TabStop = false;
            this.Hemşireler.Text = "Hemşireler";
            // 
            // lstHemsireler
            // 
            this.lstHemsireler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstHemsireler.FullRowSelect = true;
            this.lstHemsireler.GridLines = true;
            this.lstHemsireler.HideSelection = false;
            this.lstHemsireler.Location = new System.Drawing.Point(6, 34);
            this.lstHemsireler.Name = "lstHemsireler";
            this.lstHemsireler.Size = new System.Drawing.Size(318, 253);
            this.lstHemsireler.TabIndex = 0;
            this.lstHemsireler.UseCompatibleStateImageBehavior = false;
            this.lstHemsireler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adı";
            this.columnHeader3.Width = 139;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Soyadı";
            this.columnHeader4.Width = 171;
            // 
            // frmGorevliHemsireler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.Hemşireler);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGorevliHemsireler";
            this.Text = "Görevli Hemşire Listesi";
            this.Load += new System.EventHandler(this.frmGorevliHemsireler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Hemşireler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstDoktorlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Hemşireler;
        private System.Windows.Forms.ListView lstHemsireler;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}