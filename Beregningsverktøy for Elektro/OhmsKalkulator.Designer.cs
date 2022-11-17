namespace Beregningsverktøy_for_Elektro
{
    partial class OhmsKalkulator
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
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelSpenning = new System.Windows.Forms.Label();
            this.textBoxSpenning = new System.Windows.Forms.TextBox();
            this.labelAmpere = new System.Windows.Forms.Label();
            this.textBoxAmpere = new System.Windows.Forms.TextBox();
            this.labelMotstand = new System.Windows.Forms.Label();
            this.textBoxMotstand = new System.Windows.Forms.TextBox();
            this.labelEffekt = new System.Windows.Forms.Label();
            this.textBoxEffekt = new System.Windows.Forms.TextBox();
            this.buttonOhmKalkuler = new System.Windows.Forms.Button();
            this.buttonOhmNullstill = new System.Windows.Forms.Button();
            this.buttonOhmClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogo.Location = new System.Drawing.Point(11, 8);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(498, 65);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Ohms Lov Kalkulator";
            this.labelLogo.UseWaitCursor = true;
            // 
            // labelSpenning
            // 
            this.labelSpenning.AutoSize = true;
            this.labelSpenning.Location = new System.Drawing.Point(11, 85);
            this.labelSpenning.Name = "labelSpenning";
            this.labelSpenning.Size = new System.Drawing.Size(113, 25);
            this.labelSpenning.TabIndex = 1;
            this.labelSpenning.Text = "Spenning (V)";
            // 
            // textBoxSpenning
            // 
            this.textBoxSpenning.Location = new System.Drawing.Point(14, 113);
            this.textBoxSpenning.Name = "textBoxSpenning";
            this.textBoxSpenning.Size = new System.Drawing.Size(487, 31);
            this.textBoxSpenning.TabIndex = 2;
            // 
            // labelAmpere
            // 
            this.labelAmpere.AutoSize = true;
            this.labelAmpere.Location = new System.Drawing.Point(11, 158);
            this.labelAmpere.Name = "labelAmpere";
            this.labelAmpere.Size = new System.Drawing.Size(102, 25);
            this.labelAmpere.TabIndex = 3;
            this.labelAmpere.Text = "Ampere (A)";
            // 
            // textBoxAmpere
            // 
            this.textBoxAmpere.Location = new System.Drawing.Point(16, 187);
            this.textBoxAmpere.Name = "textBoxAmpere";
            this.textBoxAmpere.Size = new System.Drawing.Size(485, 31);
            this.textBoxAmpere.TabIndex = 4;
            // 
            // labelMotstand
            // 
            this.labelMotstand.AutoSize = true;
            this.labelMotstand.Location = new System.Drawing.Point(11, 233);
            this.labelMotstand.Name = "labelMotstand";
            this.labelMotstand.Size = new System.Drawing.Size(118, 25);
            this.labelMotstand.TabIndex = 5;
            this.labelMotstand.Text = "Motstand (Ω)";
            // 
            // textBoxMotstand
            // 
            this.textBoxMotstand.Location = new System.Drawing.Point(16, 262);
            this.textBoxMotstand.Name = "textBoxMotstand";
            this.textBoxMotstand.Size = new System.Drawing.Size(485, 31);
            this.textBoxMotstand.TabIndex = 6;
            // 
            // labelEffekt
            // 
            this.labelEffekt.AutoSize = true;
            this.labelEffekt.Location = new System.Drawing.Point(11, 307);
            this.labelEffekt.Name = "labelEffekt";
            this.labelEffekt.Size = new System.Drawing.Size(89, 25);
            this.labelEffekt.TabIndex = 7;
            this.labelEffekt.Text = "Effekt (W)";
            // 
            // textBoxEffekt
            // 
            this.textBoxEffekt.Location = new System.Drawing.Point(14, 333);
            this.textBoxEffekt.Name = "textBoxEffekt";
            this.textBoxEffekt.Size = new System.Drawing.Size(487, 31);
            this.textBoxEffekt.TabIndex = 8;
            // 
            // buttonOhmKalkuler
            // 
            this.buttonOhmKalkuler.Location = new System.Drawing.Point(11, 403);
            this.buttonOhmKalkuler.Name = "buttonOhmKalkuler";
            this.buttonOhmKalkuler.Size = new System.Drawing.Size(157, 33);
            this.buttonOhmKalkuler.TabIndex = 9;
            this.buttonOhmKalkuler.Text = "Beregn";
            this.buttonOhmKalkuler.UseVisualStyleBackColor = true;
            this.buttonOhmKalkuler.Click += new System.EventHandler(this.buttonOhmKalkuler_Click);
            // 
            // buttonOhmNullstill
            // 
            this.buttonOhmNullstill.Location = new System.Drawing.Point(180, 403);
            this.buttonOhmNullstill.Name = "buttonOhmNullstill";
            this.buttonOhmNullstill.Size = new System.Drawing.Size(157, 33);
            this.buttonOhmNullstill.TabIndex = 10;
            this.buttonOhmNullstill.Text = "Nullstill";
            this.buttonOhmNullstill.UseVisualStyleBackColor = true;
            this.buttonOhmNullstill.Click += new System.EventHandler(this.buttonOhmNullstill_Click);
            // 
            // buttonOhmClose
            // 
            this.buttonOhmClose.Location = new System.Drawing.Point(346, 403);
            this.buttonOhmClose.Name = "buttonOhmClose";
            this.buttonOhmClose.Size = new System.Drawing.Size(157, 33);
            this.buttonOhmClose.TabIndex = 11;
            this.buttonOhmClose.Text = "Lukk";
            this.buttonOhmClose.UseVisualStyleBackColor = true;
            this.buttonOhmClose.Click += new System.EventHandler(this.buttonOhmClose_Click);
            // 
            // OhmsKalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.buttonOhmClose);
            this.Controls.Add(this.buttonOhmNullstill);
            this.Controls.Add(this.buttonOhmKalkuler);
            this.Controls.Add(this.textBoxEffekt);
            this.Controls.Add(this.labelEffekt);
            this.Controls.Add(this.textBoxMotstand);
            this.Controls.Add(this.labelMotstand);
            this.Controls.Add(this.textBoxAmpere);
            this.Controls.Add(this.labelAmpere);
            this.Controls.Add(this.textBoxSpenning);
            this.Controls.Add(this.labelSpenning);
            this.Controls.Add(this.labelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OhmsKalkulator";
            this.Text = "Ohms Lov Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLogo;
        private Label labelSpenning;
        private TextBox textBoxSpenning;
        private Label labelAmpere;
        private TextBox textBoxAmpere;
        private Label labelMotstand;
        private TextBox textBoxMotstand;
        private Label labelEffekt;
        private TextBox textBoxEffekt;
        private Button buttonOhmKalkuler;
        private Button buttonOhmNullstill;
        private Button buttonOhmClose;
    }
}