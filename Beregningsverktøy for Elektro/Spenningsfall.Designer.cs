namespace Beregningsverktøy_for_Elektro
{
    partial class Spenningsfall
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
            this.labelCosphi = new System.Windows.Forms.Label();
            this.textBoxCosphi = new System.Windows.Forms.TextBox();
            this.labelRho = new System.Windows.Forms.Label();
            this.labelLengde = new System.Windows.Forms.Label();
            this.textBoxLengde = new System.Windows.Forms.TextBox();
            this.labelLedere = new System.Windows.Forms.Label();
            this.labelStrom = new System.Windows.Forms.Label();
            this.textBoxStrom = new System.Windows.Forms.TextBox();
            this.labelTverrsnitt = new System.Windows.Forms.Label();
            this.comboBoxLedere = new System.Windows.Forms.ComboBox();
            this.comboBoxTverrsnitt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSpenning = new System.Windows.Forms.Label();
            this.textBoxSpenning = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxResultatAUP = new System.Windows.Forms.RichTextBox();
            this.richTextBoxResultatAU = new System.Windows.Forms.RichTextBox();
            this.comboBoxResitivitet = new System.Windows.Forms.ComboBox();
            this.groupBoxNEK = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.buttonNullstill = new System.Windows.Forms.Button();
            this.buttonLukk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beregning av Spenningsfall";
            // 
            // labelCosphi
            // 
            this.labelCosphi.AutoSize = true;
            this.labelCosphi.Location = new System.Drawing.Point(16, 390);
            this.labelCosphi.Name = "labelCosphi";
            this.labelCosphi.Size = new System.Drawing.Size(131, 25);
            this.labelCosphi.TabIndex = 1;
            this.labelCosphi.Text = "Cosinus Phi (φ)";
            // 
            // textBoxCosphi
            // 
            this.textBoxCosphi.Location = new System.Drawing.Point(16, 418);
            this.textBoxCosphi.Name = "textBoxCosphi";
            this.textBoxCosphi.Size = new System.Drawing.Size(207, 31);
            this.textBoxCosphi.TabIndex = 2;
            // 
            // labelRho
            // 
            this.labelRho.AutoSize = true;
            this.labelRho.Location = new System.Drawing.Point(14, 191);
            this.labelRho.Name = "labelRho";
            this.labelRho.Size = new System.Drawing.Size(113, 25);
            this.labelRho.TabIndex = 3;
            this.labelRho.Text = "Resitivitet (ρ)";
            // 
            // labelLengde
            // 
            this.labelLengde.AutoSize = true;
            this.labelLengde.Location = new System.Drawing.Point(16, 259);
            this.labelLengde.Name = "labelLengde";
            this.labelLengde.Size = new System.Drawing.Size(182, 30);
            this.labelLengde.TabIndex = 5;
            this.labelLengde.Text = "Kabel Lengde (meter)";
            this.labelLengde.UseCompatibleTextRendering = true;
            // 
            // textBoxLengde
            // 
            this.textBoxLengde.Location = new System.Drawing.Point(16, 292);
            this.textBoxLengde.Name = "textBoxLengde";
            this.textBoxLengde.Size = new System.Drawing.Size(205, 31);
            this.textBoxLengde.TabIndex = 6;
            // 
            // labelLedere
            // 
            this.labelLedere.AutoSize = true;
            this.labelLedere.Location = new System.Drawing.Point(16, 326);
            this.labelLedere.Name = "labelLedere";
            this.labelLedere.Size = new System.Drawing.Size(114, 25);
            this.labelLedere.TabIndex = 8;
            this.labelLedere.Text = "Antall Ledere";
            // 
            // labelStrom
            // 
            this.labelStrom.AutoSize = true;
            this.labelStrom.Location = new System.Drawing.Point(16, 132);
            this.labelStrom.Name = "labelStrom";
            this.labelStrom.Size = new System.Drawing.Size(87, 25);
            this.labelStrom.TabIndex = 9;
            this.labelStrom.Text = "Strøm (A)";
            // 
            // textBoxStrom
            // 
            this.textBoxStrom.Location = new System.Drawing.Point(16, 160);
            this.textBoxStrom.Name = "textBoxStrom";
            this.textBoxStrom.Size = new System.Drawing.Size(206, 31);
            this.textBoxStrom.TabIndex = 10;
            // 
            // labelTverrsnitt
            // 
            this.labelTverrsnitt.AutoSize = true;
            this.labelTverrsnitt.Location = new System.Drawing.Point(16, 450);
            this.labelTverrsnitt.Name = "labelTverrsnitt";
            this.labelTverrsnitt.Size = new System.Drawing.Size(109, 25);
            this.labelTverrsnitt.TabIndex = 11;
            this.labelTverrsnitt.Text = "Areal (mm2)";
            // 
            // comboBoxLedere
            // 
            this.comboBoxLedere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLedere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLedere.FormattingEnabled = true;
            this.comboBoxLedere.Items.AddRange(new object[] {
            "2",
            "3"});
            this.comboBoxLedere.Location = new System.Drawing.Point(16, 354);
            this.comboBoxLedere.Name = "comboBoxLedere";
            this.comboBoxLedere.Size = new System.Drawing.Size(205, 33);
            this.comboBoxLedere.TabIndex = 13;
            // 
            // comboBoxTverrsnitt
            // 
            this.comboBoxTverrsnitt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxTverrsnitt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTverrsnitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTverrsnitt.FormattingEnabled = true;
            this.comboBoxTverrsnitt.Items.AddRange(new object[] {
            "1,5",
            "2,5",
            "4",
            "6",
            "10",
            "16",
            "25",
            "35",
            "50",
            "70",
            "95",
            "120",
            "150",
            "185",
            "240",
            "300"});
            this.comboBoxTverrsnitt.Location = new System.Drawing.Point(16, 479);
            this.comboBoxTverrsnitt.Name = "comboBoxTverrsnitt";
            this.comboBoxTverrsnitt.Size = new System.Drawing.Size(205, 33);
            this.comboBoxTverrsnitt.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Beregn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSpenning
            // 
            this.labelSpenning.AutoSize = true;
            this.labelSpenning.Location = new System.Drawing.Point(17, 67);
            this.labelSpenning.Name = "labelSpenning";
            this.labelSpenning.Size = new System.Drawing.Size(113, 25);
            this.labelSpenning.TabIndex = 16;
            this.labelSpenning.Text = "Spenning (V)";
            // 
            // textBoxSpenning
            // 
            this.textBoxSpenning.Location = new System.Drawing.Point(19, 95);
            this.textBoxSpenning.Name = "textBoxSpenning";
            this.textBoxSpenning.Size = new System.Drawing.Size(205, 31);
            this.textBoxSpenning.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Resultat ∆U";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Resultat ∆U%";
            // 
            // richTextBoxResultatAUP
            // 
            this.richTextBoxResultatAUP.Location = new System.Drawing.Point(238, 259);
            this.richTextBoxResultatAUP.Name = "richTextBoxResultatAUP";
            this.richTextBoxResultatAUP.Size = new System.Drawing.Size(415, 114);
            this.richTextBoxResultatAUP.TabIndex = 20;
            this.richTextBoxResultatAUP.Text = "";
            // 
            // richTextBoxResultatAU
            // 
            this.richTextBoxResultatAU.Location = new System.Drawing.Point(236, 95);
            this.richTextBoxResultatAU.Name = "richTextBoxResultatAU";
            this.richTextBoxResultatAU.Size = new System.Drawing.Size(417, 121);
            this.richTextBoxResultatAU.TabIndex = 18;
            this.richTextBoxResultatAU.Text = "";
            // 
            // comboBoxResitivitet
            // 
            this.comboBoxResitivitet.FormattingEnabled = true;
            this.comboBoxResitivitet.Items.AddRange(new object[] {
            "Cu (0,0172)",
            "Al  (0,0264)"});
            this.comboBoxResitivitet.Location = new System.Drawing.Point(14, 223);
            this.comboBoxResitivitet.Name = "comboBoxResitivitet";
            this.comboBoxResitivitet.Size = new System.Drawing.Size(207, 33);
            this.comboBoxResitivitet.TabIndex = 22;
            // 
            // groupBoxNEK
            // 
            this.groupBoxNEK.Location = new System.Drawing.Point(239, 388);
            this.groupBoxNEK.Name = "groupBoxNEK";
            this.groupBoxNEK.Size = new System.Drawing.Size(413, 165);
            this.groupBoxNEK.TabIndex = 0;
            this.groupBoxNEK.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(232, 390);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(310, 25);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Krav til spenningsfall (NEK 400-5-525)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(232, 450);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(423, 25);
            this.linkLabel2.TabIndex = 24;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forskrift om elektriske lavspenningsanlegg (FEL §27)";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(232, 421);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(371, 25);
            this.linkLabel3.TabIndex = 25;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Krav til spenningsfall (NEK 400-5-52 Tillegg F)";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // buttonNullstill
            // 
            this.buttonNullstill.Location = new System.Drawing.Point(109, 518);
            this.buttonNullstill.Name = "buttonNullstill";
            this.buttonNullstill.Size = new System.Drawing.Size(112, 34);
            this.buttonNullstill.TabIndex = 26;
            this.buttonNullstill.Text = "Nullstill";
            this.buttonNullstill.UseVisualStyleBackColor = true;
            this.buttonNullstill.Click += new System.EventHandler(this.buttonNullstill_Click);
            // 
            // buttonLukk
            // 
            this.buttonLukk.Location = new System.Drawing.Point(227, 518);
            this.buttonLukk.Name = "buttonLukk";
            this.buttonLukk.Size = new System.Drawing.Size(112, 34);
            this.buttonLukk.TabIndex = 27;
            this.buttonLukk.Text = "Lukk";
            this.buttonLukk.UseVisualStyleBackColor = true;
            this.buttonLukk.Click += new System.EventHandler(this.buttonLukk_Click);
            // 
            // Spenningsfall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 559);
            this.Controls.Add(this.buttonLukk);
            this.Controls.Add(this.buttonNullstill);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboBoxResitivitet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxResultatAUP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxResultatAU);
            this.Controls.Add(this.textBoxSpenning);
            this.Controls.Add(this.labelSpenning);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxTverrsnitt);
            this.Controls.Add(this.comboBoxLedere);
            this.Controls.Add(this.labelTverrsnitt);
            this.Controls.Add(this.textBoxStrom);
            this.Controls.Add(this.labelStrom);
            this.Controls.Add(this.labelLedere);
            this.Controls.Add(this.textBoxLengde);
            this.Controls.Add(this.labelLengde);
            this.Controls.Add(this.labelRho);
            this.Controls.Add(this.textBoxCosphi);
            this.Controls.Add(this.labelCosphi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Spenningsfall";
            this.Text = "Spenningsfall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelCosphi;
        private TextBox textBoxCosphi;
        private Label labelRho;
        private Label labelLengde;
        private TextBox textBoxLengde;
        private Label labelLedere;
        private Label labelStrom;
        private TextBox textBoxStrom;
        private Label labelTverrsnitt;
        private ComboBox comboBoxLedere;
        private ComboBox comboBoxTverrsnitt;
        private Button button1;
        private Label labelSpenning;
        private TextBox textBoxSpenning;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBoxResultatAUP;
        private RichTextBox richTextBoxResultatAU;
        private ComboBox comboBoxResitivitet;
        private GroupBox groupBoxNEK;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Button buttonNullstill;
        private Button buttonLukk;
    }
}