﻿namespace GiaoDien_qlpks
{
    partial class Checkin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            cbsophong = new ComboBox();
            btcheckin = new Button();
            panel5 = new Panel();
            ngaytra = new DateTimePicker();
            label7 = new Label();
            label4 = new Label();
            panel7 = new Panel();
            cbloaiphong = new ComboBox();
            label6 = new Label();
            panel6 = new Panel();
            ngaydat = new DateTimePicker();
            label5 = new Label();
            panel4 = new Panel();
            tbcccd = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            tbsđt = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            tbten = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cbsophong);
            panel1.Controls.Add(btcheckin);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 451);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(480, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 295);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // cbsophong
            // 
            cbsophong.BackColor = Color.MistyRose;
            cbsophong.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbsophong.FormattingEnabled = true;
            cbsophong.Items.AddRange(new object[] { "122" });
            cbsophong.Location = new Point(171, 251);
            cbsophong.Name = "cbsophong";
            cbsophong.Size = new Size(237, 31);
            cbsophong.TabIndex = 8;
            cbsophong.SelectedIndexChanged += cbsophong_SelectedIndexChanged;
            // 
            // btcheckin
            // 
            btcheckin.BackColor = Color.FromArgb(255, 128, 128);
            btcheckin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btcheckin.Location = new Point(590, 366);
            btcheckin.Name = "btcheckin";
            btcheckin.Size = new Size(154, 53);
            btcheckin.TabIndex = 7;
            btcheckin.Text = "Đặt phòng";
            btcheckin.UseVisualStyleBackColor = false;
            btcheckin.Click += btcheckin_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(ngaytra);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(5, 366);
            panel5.Name = "panel5";
            panel5.Size = new Size(496, 53);
            panel5.TabIndex = 6;
            // 
            // ngaytra
            // 
            ngaytra.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ngaytra.Format = DateTimePickerFormat.Short;
            ngaytra.Location = new Point(164, 8);
            ngaytra.Name = "ngaytra";
            ngaytra.Size = new Size(237, 31);
            ngaytra.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 128, 128);
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 8);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 0;
            label7.Text = "Ngày trả";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 128);
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 254);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 0;
            label4.Text = "Số Phòng";
            // 
            // panel7
            // 
            panel7.Controls.Add(cbloaiphong);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(5, 182);
            panel7.Name = "panel7";
            panel7.Size = new Size(403, 53);
            panel7.TabIndex = 5;
            panel7.Paint += panel7_Paint;
            // 
            // cbloaiphong
            // 
            cbloaiphong.BackColor = Color.MistyRose;
            cbloaiphong.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbloaiphong.FormattingEnabled = true;
            cbloaiphong.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbloaiphong.Location = new Point(166, 11);
            cbloaiphong.Name = "cbloaiphong";
            cbloaiphong.Size = new Size(237, 31);
            cbloaiphong.TabIndex = 2;
            cbloaiphong.SelectedIndexChanged += cbloaiphong_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 128, 128);
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 14);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 0;
            label6.Text = "Loại phòng";
            // 
            // panel6
            // 
            panel6.Controls.Add(ngaydat);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(5, 300);
            panel6.Name = "panel6";
            panel6.Size = new Size(403, 53);
            panel6.TabIndex = 4;
            // 
            // ngaydat
            // 
            ngaydat.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ngaydat.Format = DateTimePickerFormat.Short;
            ngaydat.Location = new Point(163, 8);
            ngaydat.Name = "ngaydat";
            ngaydat.Size = new Size(238, 31);
            ngaydat.TabIndex = 2;
            ngaydat.ValueChanged += ngaydat_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 128, 128);
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(7, 14);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 0;
            label5.Text = "Ngày đặt";
            // 
            // panel4
            // 
            panel4.Controls.Add(tbcccd);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(6, 123);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 53);
            panel4.TabIndex = 2;
            // 
            // tbcccd
            // 
            tbcccd.BackColor = Color.MistyRose;
            tbcccd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbcccd.Location = new Point(165, 11);
            tbcccd.Name = "tbcccd";
            tbcccd.Size = new Size(237, 31);
            tbcccd.TabIndex = 2;
            tbcccd.TextChanged += tbcccd_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 128);
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 14);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 0;
            label3.Text = "CCCD";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbsđt);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(6, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 54);
            panel3.TabIndex = 1;
            // 
            // tbsđt
            // 
            tbsđt.BackColor = Color.MistyRose;
            tbsđt.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbsđt.Location = new Point(165, 11);
            tbsđt.Name = "tbsđt";
            tbsđt.Size = new Size(237, 31);
            tbsđt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 14);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 0;
            label2.Text = "Số điện thoại";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbten);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(6, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 53);
            panel2.TabIndex = 0;
            // 
            // tbten
            // 
            tbten.BackColor = Color.MistyRose;
            tbten.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbten.Location = new Point(165, 11);
            tbten.Name = "tbten";
            tbten.Size = new Size(237, 31);
            tbten.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // Checkin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Checkin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check in";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private TextBox tbcccd;
        private Label label3;
        private Panel panel3;
        private TextBox tbsđt;
        private Label label2;
        private TextBox tbten;
        private Label label4;
        private Panel panel6;
        private Label label5;
        private Panel panel7;
        private ComboBox cbloaiphong;
        private Label label6;
        private Panel panel5;
        private DateTimePicker ngaytra;
        private Label label7;
        private DateTimePicker ngaydat;
        private Button btcheckin;
        private ComboBox cbsophong;
        private PictureBox pictureBox1;
    }
}