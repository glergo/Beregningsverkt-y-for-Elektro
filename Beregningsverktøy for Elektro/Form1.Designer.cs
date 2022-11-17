namespace Beregningsverktøy_for_Elektro
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ohmskalk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSpenningsfall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ohmskalk
            // 
            this.ohmskalk.Location = new System.Drawing.Point(12, 122);
            this.ohmskalk.Name = "ohmskalk";
            this.ohmskalk.Size = new System.Drawing.Size(251, 34);
            this.ohmskalk.TabIndex = 0;
            this.ohmskalk.Text = "Ohms Lov Kalkulator";
            this.ohmskalk.UseVisualStyleBackColor = true;
            this.ohmskalk.Click += new System.EventHandler(this.ohmskalk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beregningsverktøy for Elektro.";
            // 
            // buttonSpenningsfall
            // 
            this.buttonSpenningsfall.Location = new System.Drawing.Point(269, 122);
            this.buttonSpenningsfall.Name = "buttonSpenningsfall";
            this.buttonSpenningsfall.Size = new System.Drawing.Size(251, 34);
            this.buttonSpenningsfall.TabIndex = 2;
            this.buttonSpenningsfall.Text = "Beregning av spenningsfall";
            this.buttonSpenningsfall.UseVisualStyleBackColor = true;
            this.buttonSpenningsfall.Click += new System.EventHandler(this.buttonSpenningsfall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 167);
            this.Controls.Add(this.buttonSpenningsfall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ohmskalk);
            this.Name = "Form1";
            this.Text = "Beregningsverktøy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ohmskalk;
        private Label label1;
        private Button buttonSpenningsfall;
    }
}