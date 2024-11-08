namespace BordroOtomasyon.UI
{
    partial class AdminPanel
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
            lblHosgeldin = new Label();
            groupBoxÇalışanBilgileri = new GroupBox();
            groupBoxKıdem = new GroupBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            lblKıdem = new Label();
            lblDerece = new Label();
            lblBurutMaas = new Label();
            grpBoxİkramiyeHesapla = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            lblIsBaslangıc = new Label();
            btnÇıkış = new Button();
            LBLTEDİYE1 = new Label();
            lbl2tediye = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            textbirtediye = new TextBox();
            this.text2tediye = new TextBox();
            label3 = new Label();
            text1sonuc = new TextBox();
            label4 = new Label();
            text2sonuc = new TextBox();
            Hesapla = new Button();
            button1 = new Button();
            groupBoxÇalışanBilgileri.SuspendLayout();
            groupBoxKıdem.SuspendLayout();
            SuspendLayout();
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.AutoSize = true;
            lblHosgeldin.Location = new Point(34, 27);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new Size(157, 25);
            lblHosgeldin.TabIndex = 0;
            lblHosgeldin.Text = "Hoş Geldin Admin";
            // 
            // groupBoxÇalışanBilgileri
            // 
            groupBoxÇalışanBilgileri.BackColor = Color.WhiteSmoke;
            groupBoxÇalışanBilgileri.Controls.Add(dateTimePicker1);
            groupBoxÇalışanBilgileri.Controls.Add(lblIsBaslangıc);
            groupBoxÇalışanBilgileri.Controls.Add(lblBurutMaas);
            groupBoxÇalışanBilgileri.Controls.Add(lblDerece);
            groupBoxÇalışanBilgileri.Controls.Add(lblKıdem);
            groupBoxÇalışanBilgileri.Controls.Add(textBox1);
            groupBoxÇalışanBilgileri.Controls.Add(comboBox2);
            groupBoxÇalışanBilgileri.Controls.Add(comboBox1);
            groupBoxÇalışanBilgileri.Location = new Point(34, 93);
            groupBoxÇalışanBilgileri.Name = "groupBoxÇalışanBilgileri";
            groupBoxÇalışanBilgileri.Size = new Size(427, 418);
            groupBoxÇalışanBilgileri.TabIndex = 1;
            groupBoxÇalışanBilgileri.TabStop = false;
            groupBoxÇalışanBilgileri.Text = "Çalışan Bilgileri";
            // 
            // groupBoxKıdem
            // 
            groupBoxKıdem.BackColor = Color.Gainsboro;
            groupBoxKıdem.Controls.Add(Hesapla);
            groupBoxKıdem.Controls.Add(text2sonuc);
            groupBoxKıdem.Controls.Add(label4);
            groupBoxKıdem.Controls.Add(text1sonuc);
            groupBoxKıdem.Controls.Add(label3);
            groupBoxKıdem.Controls.Add(this.text2tediye);
            groupBoxKıdem.Controls.Add(textbirtediye);
            groupBoxKıdem.Controls.Add(label2);
            groupBoxKıdem.Controls.Add(label1);
            groupBoxKıdem.Controls.Add(dateTimePicker3);
            groupBoxKıdem.Controls.Add(dateTimePicker2);
            groupBoxKıdem.Controls.Add(lbl2tediye);
            groupBoxKıdem.Controls.Add(LBLTEDİYE1);
            groupBoxKıdem.Location = new Point(535, 93);
            groupBoxKıdem.Name = "groupBoxKıdem";
            groupBoxKıdem.Size = new Size(342, 463);
            groupBoxKıdem.TabIndex = 2;
            groupBoxKıdem.TabStop = false;
            groupBoxKıdem.Text = "Tediye Hesapla";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(203, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1,2,3,4,5,6" });
            comboBox2.Location = new Point(203, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // lblKıdem
            // 
            lblKıdem.AutoSize = true;
            lblKıdem.Location = new Point(81, 54);
            lblKıdem.Name = "lblKıdem";
            lblKıdem.Size = new Size(62, 25);
            lblKıdem.TabIndex = 3;
            lblKıdem.Text = "Kıdem";
            // 
            // lblDerece
            // 
            lblDerece.AutoSize = true;
            lblDerece.Location = new Point(81, 131);
            lblDerece.Name = "lblDerece";
            lblDerece.Size = new Size(66, 25);
            lblDerece.TabIndex = 4;
            lblDerece.Text = "Derece";
            // 
            // lblBurutMaas
            // 
            lblBurutMaas.AutoSize = true;
            lblBurutMaas.Location = new Point(81, 217);
            lblBurutMaas.Name = "lblBurutMaas";
            lblBurutMaas.Size = new Size(101, 25);
            lblBurutMaas.TabIndex = 5;
            lblBurutMaas.Text = "Bürüt Maaş";
            // 
            // grpBoxİkramiyeHesapla
            // 
            grpBoxİkramiyeHesapla.BackColor = Color.Gainsboro;
            grpBoxİkramiyeHesapla.Location = new Point(982, 93);
            grpBoxİkramiyeHesapla.Name = "grpBoxİkramiyeHesapla";
            grpBoxİkramiyeHesapla.Size = new Size(310, 407);
            grpBoxİkramiyeHesapla.TabIndex = 3;
            grpBoxİkramiyeHesapla.TabStop = false;
            grpBoxİkramiyeHesapla.Text = "İkramiye Hesapla";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(151, 313);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // lblIsBaslangıc
            // 
            lblIsBaslangıc.AutoSize = true;
            lblIsBaslangıc.Location = new Point(6, 319);
            lblIsBaslangıc.Name = "lblIsBaslangıc";
            lblIsBaslangıc.Size = new Size(112, 25);
            lblIsBaslangıc.TabIndex = 1;
            lblIsBaslangıc.Text = "İşe Başlangıç";
            // 
            // btnÇıkış
            // 
            btnÇıkış.BackColor = Color.Silver;
            btnÇıkış.Location = new Point(244, 24);
            btnÇıkış.Name = "btnÇıkış";
            btnÇıkış.Size = new Size(112, 34);
            btnÇıkış.TabIndex = 4;
            btnÇıkış.Text = "Çıkış";
            btnÇıkış.UseVisualStyleBackColor = false;
            // 
            // LBLTEDİYE1
            // 
            LBLTEDİYE1.AutoSize = true;
            LBLTEDİYE1.Location = new Point(6, 61);
            LBLTEDİYE1.Name = "LBLTEDİYE1";
            LBLTEDİYE1.Size = new Size(75, 25);
            LBLTEDİYE1.TabIndex = 0;
            LBLTEDİYE1.Text = "1.Tediye";
            // 
            // lbl2tediye
            // 
            lbl2tediye.AutoSize = true;
            lbl2tediye.Location = new Point(0, 131);
            lbl2tediye.Name = "lbl2tediye";
            lbl2tediye.Size = new Size(75, 25);
            lbl2tediye.TabIndex = 1;
            lbl2tediye.Text = "2.Tediye";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(87, 56);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(249, 31);
            dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(81, 131);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(249, 31);
            dateTimePicker3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 227);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 4;
            label1.Text = "1.Tediye";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 350);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 5;
            label2.Text = "2.Tediye";
            // 
            // textbirtediye
            // 
            textbirtediye.Location = new Point(86, 223);
            textbirtediye.Name = "textbirtediye";
            textbirtediye.Size = new Size(150, 31);
            textbirtediye.TabIndex = 6;
            // 
            // text2tediye
            // 
            this.text2tediye.Location = new Point(87, 344);
            this.text2tediye.Name = "text2tediye";
            this.text2tediye.Size = new Size(150, 31);
            this.text2tediye.TabIndex = 7;
            this.text2tediye.TextChanged += this.textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 285);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 8;
            label3.Text = "1.Sonuç";
            // 
            // text1sonuc
            // 
            text1sonuc.Location = new Point(87, 285);
            text1sonuc.Name = "text1sonuc";
            text1sonuc.Size = new Size(150, 31);
            text1sonuc.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 405);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 10;
            label4.Text = "2.Sonuç";
            // 
            // text2sonuc
            // 
            text2sonuc.Location = new Point(87, 399);
            text2sonuc.Name = "text2sonuc";
            text2sonuc.Size = new Size(150, 31);
            text2sonuc.TabIndex = 11;
            // 
            // Hesapla
            // 
            Hesapla.Location = new Point(110, 168);
            Hesapla.Name = "Hesapla";
            Hesapla.Size = new Size(112, 34);
            Hesapla.TabIndex = 12;
            Hesapla.Text = "Hesapla";
            Hesapla.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(977, 390);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1396, 546);
            Controls.Add(button1);
            Controls.Add(btnÇıkış);
            Controls.Add(grpBoxİkramiyeHesapla);
            Controls.Add(groupBoxKıdem);
            Controls.Add(groupBoxÇalışanBilgileri);
            Controls.Add(lblHosgeldin);
            Name = "AdminPanel";
            Text = "Admin";
            groupBoxÇalışanBilgileri.ResumeLayout(false);
            groupBoxÇalışanBilgileri.PerformLayout();
            groupBoxKıdem.ResumeLayout(false);
            groupBoxKıdem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHosgeldin;
        private GroupBox groupBoxÇalışanBilgileri;
        private GroupBox groupBoxKıdem;
        private Label lblBurutMaas;
        private Label lblDerece;
        private Label lblKıdem;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label lblIsBaslangıc;
        private DateTimePicker dateTimePicker1;
        private GroupBox grpBoxİkramiyeHesapla;
        private Button btnÇıkış;
        private Label lbl2tediye;
        private Label LBLTEDİYE1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textbirtediye;
        private TextBox text2sonuc;
        private Label label4;
        private TextBox text1sonuc;
        private Label label3;
        private Button Hesapla;
        private Button button1;
    }
}