namespace BillettSelfKioskSystem {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1Klasse = new System.Windows.Forms.CheckBox();
            this.checkBoxRetour = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Location = new System.Drawing.Point(397, 33);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.ReadOnly = true;
            this.textBoxPreis.Size = new System.Drawing.Size(100, 20);
            this.textBoxPreis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preis (CHF)";
            // 
            // checkBox1Klasse
            // 
            this.checkBox1Klasse.AutoSize = true;
            this.checkBox1Klasse.Location = new System.Drawing.Point(245, 36);
            this.checkBox1Klasse.Name = "checkBox1Klasse";
            this.checkBox1Klasse.Size = new System.Drawing.Size(69, 17);
            this.checkBox1Klasse.TabIndex = 3;
            this.checkBox1Klasse.Text = "1. Klasse";
            this.checkBox1Klasse.UseVisualStyleBackColor = true;
            // 
            // checkBoxRetour
            // 
            this.checkBoxRetour.AutoSize = true;
            this.checkBoxRetour.Location = new System.Drawing.Point(245, 60);
            this.checkBoxRetour.Name = "checkBoxRetour";
            this.checkBoxRetour.Size = new System.Drawing.Size(58, 17);
            this.checkBoxRetour.TabIndex = 4;
            this.checkBoxRetour.Text = "Retour";
            this.checkBoxRetour.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 393);
            this.Controls.Add(this.checkBoxRetour);
            this.Controls.Add(this.checkBox1Klasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPreis);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1Klasse;
        private System.Windows.Forms.CheckBox checkBoxRetour;
    }
}

