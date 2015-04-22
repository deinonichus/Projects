namespace simpleCalculator {
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
            this.radioButtonAddieren = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiplizieren = new System.Windows.Forms.RadioButton();
            this.textBoxNumberOne = new System.Windows.Forms.TextBox();
            this.textBoxNumberTwo = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.labelDigitOne = new System.Windows.Forms.Label();
            this.labelDigitTwo = new System.Windows.Forms.Label();
            this.labelResultat = new System.Windows.Forms.Label();
            this.radioButtonSubtrahieren = new System.Windows.Forms.RadioButton();
            this.radioButtonDividieren = new System.Windows.Forms.RadioButton();
            this.groupBoxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonAddieren
            // 
            this.radioButtonAddieren.AutoSize = true;
            this.radioButtonAddieren.Location = new System.Drawing.Point(6, 32);
            this.radioButtonAddieren.Name = "radioButtonAddieren";
            this.radioButtonAddieren.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAddieren.TabIndex = 0;
            this.radioButtonAddieren.TabStop = true;
            this.radioButtonAddieren.Text = "addieren";
            this.radioButtonAddieren.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiplizieren
            // 
            this.radioButtonMultiplizieren.AutoSize = true;
            this.radioButtonMultiplizieren.Location = new System.Drawing.Point(6, 64);
            this.radioButtonMultiplizieren.Name = "radioButtonMultiplizieren";
            this.radioButtonMultiplizieren.Size = new System.Drawing.Size(84, 17);
            this.radioButtonMultiplizieren.TabIndex = 1;
            this.radioButtonMultiplizieren.TabStop = true;
            this.radioButtonMultiplizieren.Text = "multiplizieren";
            this.radioButtonMultiplizieren.UseVisualStyleBackColor = true;
            // 
            // textBoxNumberOne
            // 
            this.textBoxNumberOne.Location = new System.Drawing.Point(70, 45);
            this.textBoxNumberOne.Name = "textBoxNumberOne";
            this.textBoxNumberOne.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOne.TabIndex = 2;
            // 
            // textBoxNumberTwo
            // 
            this.textBoxNumberTwo.Location = new System.Drawing.Point(70, 94);
            this.textBoxNumberTwo.Name = "textBoxNumberTwo";
            this.textBoxNumberTwo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberTwo.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(70, 143);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(70, 196);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "berechnen";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.radioButtonDividieren);
            this.groupBoxOperations.Controls.Add(this.radioButtonSubtrahieren);
            this.groupBoxOperations.Controls.Add(this.radioButtonMultiplizieren);
            this.groupBoxOperations.Controls.Add(this.radioButtonAddieren);
            this.groupBoxOperations.Location = new System.Drawing.Point(197, 45);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(123, 174);
            this.groupBoxOperations.TabIndex = 6;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Operationen";
            // 
            // labelDigitOne
            // 
            this.labelDigitOne.AutoSize = true;
            this.labelDigitOne.Location = new System.Drawing.Point(13, 51);
            this.labelDigitOne.Name = "labelDigitOne";
            this.labelDigitOne.Size = new System.Drawing.Size(37, 13);
            this.labelDigitOne.TabIndex = 7;
            this.labelDigitOne.Text = "Zahl 1";
            // 
            // labelDigitTwo
            // 
            this.labelDigitTwo.AutoSize = true;
            this.labelDigitTwo.Location = new System.Drawing.Point(13, 102);
            this.labelDigitTwo.Name = "labelDigitTwo";
            this.labelDigitTwo.Size = new System.Drawing.Size(37, 13);
            this.labelDigitTwo.TabIndex = 8;
            this.labelDigitTwo.Text = "Zahl 2";
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Location = new System.Drawing.Point(12, 150);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(46, 13);
            this.labelResultat.TabIndex = 9;
            this.labelResultat.Text = "Resultat";
            // 
            // radioButtonSubtrahieren
            // 
            this.radioButtonSubtrahieren.AutoSize = true;
            this.radioButtonSubtrahieren.Location = new System.Drawing.Point(6, 99);
            this.radioButtonSubtrahieren.Name = "radioButtonSubtrahieren";
            this.radioButtonSubtrahieren.Size = new System.Drawing.Size(83, 17);
            this.radioButtonSubtrahieren.TabIndex = 2;
            this.radioButtonSubtrahieren.TabStop = true;
            this.radioButtonSubtrahieren.Text = "subtrahieren";
            this.radioButtonSubtrahieren.UseVisualStyleBackColor = true;
            // 
            // radioButtonDividieren
            // 
            this.radioButtonDividieren.AutoSize = true;
            this.radioButtonDividieren.Location = new System.Drawing.Point(6, 131);
            this.radioButtonDividieren.Name = "radioButtonDividieren";
            this.radioButtonDividieren.Size = new System.Drawing.Size(70, 17);
            this.radioButtonDividieren.TabIndex = 3;
            this.radioButtonDividieren.TabStop = true;
            this.radioButtonDividieren.Text = "dividieren";
            this.radioButtonDividieren.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 263);
            this.Controls.Add(this.labelResultat);
            this.Controls.Add(this.labelDigitTwo);
            this.Controls.Add(this.labelDigitOne);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxNumberTwo);
            this.Controls.Add(this.textBoxNumberOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAddieren;
        private System.Windows.Forms.RadioButton radioButtonMultiplizieren;
        private System.Windows.Forms.TextBox textBoxNumberOne;
        private System.Windows.Forms.TextBox textBoxNumberTwo;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.Label labelDigitOne;
        private System.Windows.Forms.Label labelDigitTwo;
        private System.Windows.Forms.Label labelResultat;
        private System.Windows.Forms.RadioButton radioButtonDividieren;
        private System.Windows.Forms.RadioButton radioButtonSubtrahieren;
    }
}

