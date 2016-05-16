namespace Billetautomat
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAirolo = new System.Windows.Forms.Button();
            this.cbHalbtax = new System.Windows.Forms.CheckBox();
            this.cbZurueck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZueri = new System.Windows.Forms.Button();
            this.buttonWallisellen = new System.Windows.Forms.Button();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.tbCHF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonKaufen = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGuthaben = new System.Windows.Forms.TextBox();
            this.buttonMuenzCHF1 = new System.Windows.Forms.Button();
            this.buttonMuenzCHF2 = new System.Windows.Forms.Button();
            this.buttonMuenzCHF5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAirolo
            // 
            this.buttonAirolo.Location = new System.Drawing.Point(12, 99);
            this.buttonAirolo.Name = "buttonAirolo";
            this.buttonAirolo.Size = new System.Drawing.Size(75, 23);
            this.buttonAirolo.TabIndex = 0;
            this.buttonAirolo.Text = "Airolo";
            this.buttonAirolo.UseVisualStyleBackColor = true;
            this.buttonAirolo.Click += new System.EventHandler(this.buttonAirolo_Click);
            // 
            // cbHalbtax
            // 
            this.cbHalbtax.AutoSize = true;
            this.cbHalbtax.Location = new System.Drawing.Point(123, 103);
            this.cbHalbtax.Name = "cbHalbtax";
            this.cbHalbtax.Size = new System.Drawing.Size(62, 17);
            this.cbHalbtax.TabIndex = 1;
            this.cbHalbtax.Text = "Halbtax";
            this.cbHalbtax.UseVisualStyleBackColor = true;
            this.cbHalbtax.CheckedChanged += new System.EventHandler(this.cbHalbtax_CheckedChanged);
            // 
            // cbZurueck
            // 
            this.cbZurueck.AutoSize = true;
            this.cbZurueck.Location = new System.Drawing.Point(123, 132);
            this.cbZurueck.Name = "cbZurueck";
            this.cbZurueck.Size = new System.Drawing.Size(41, 17);
            this.cbZurueck.TabIndex = 2;
            this.cbZurueck.Text = "<->";
            this.cbZurueck.UseVisualStyleBackColor = true;
            this.cbZurueck.CheckedChanged += new System.EventHandler(this.cbZurueck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Billetautomat Göschenen";
            // 
            // buttonZueri
            // 
            this.buttonZueri.Location = new System.Drawing.Point(12, 128);
            this.buttonZueri.Name = "buttonZueri";
            this.buttonZueri.Size = new System.Drawing.Size(75, 23);
            this.buttonZueri.TabIndex = 4;
            this.buttonZueri.Text = "Züri";
            this.buttonZueri.UseVisualStyleBackColor = true;
            this.buttonZueri.Click += new System.EventHandler(this.buttonZueri_Click);
            // 
            // buttonWallisellen
            // 
            this.buttonWallisellen.Location = new System.Drawing.Point(12, 157);
            this.buttonWallisellen.Name = "buttonWallisellen";
            this.buttonWallisellen.Size = new System.Drawing.Size(75, 23);
            this.buttonWallisellen.TabIndex = 5;
            this.buttonWallisellen.Text = "Wallisellen";
            this.buttonWallisellen.UseVisualStyleBackColor = true;
            this.buttonWallisellen.Click += new System.EventHandler(this.buttonWallisellen_Click);
            // 
            // tbPreis
            // 
            this.tbPreis.Location = new System.Drawing.Point(335, 130);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.ReadOnly = true;
            this.tbPreis.Size = new System.Drawing.Size(107, 20);
            this.tbPreis.TabIndex = 6;
            // 
            // tbCHF
            // 
            this.tbCHF.AutoSize = true;
            this.tbCHF.Location = new System.Drawing.Point(283, 133);
            this.tbCHF.Name = "tbCHF";
            this.tbCHF.Size = new System.Drawing.Size(30, 13);
            this.tbCHF.TabIndex = 7;
            this.tbCHF.Text = "Preis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Optionen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Zielort";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(123, 161);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Francine Jordi";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kauf";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(367, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Abbrechen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonKaufen
            // 
            this.buttonKaufen.Location = new System.Drawing.Point(286, 157);
            this.buttonKaufen.Name = "buttonKaufen";
            this.buttonKaufen.Size = new System.Drawing.Size(75, 23);
            this.buttonKaufen.TabIndex = 13;
            this.buttonKaufen.Text = "Kaufen";
            this.buttonKaufen.UseVisualStyleBackColor = true;
            this.buttonKaufen.Click += new System.EventHandler(this.buttonKaufen_Click);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(286, 279);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.Size = new System.Drawing.Size(156, 108);
            this.tbDisplay.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Display";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Einwurf";
            // 
            // tbGuthaben
            // 
            this.tbGuthaben.Location = new System.Drawing.Point(335, 99);
            this.tbGuthaben.Name = "tbGuthaben";
            this.tbGuthaben.ReadOnly = true;
            this.tbGuthaben.Size = new System.Drawing.Size(107, 20);
            this.tbGuthaben.TabIndex = 19;
            // 
            // buttonMuenzCHF1
            // 
            this.buttonMuenzCHF1.Location = new System.Drawing.Point(12, 279);
            this.buttonMuenzCHF1.Name = "buttonMuenzCHF1";
            this.buttonMuenzCHF1.Size = new System.Drawing.Size(75, 23);
            this.buttonMuenzCHF1.TabIndex = 21;
            this.buttonMuenzCHF1.Text = "CHF 1";
            this.buttonMuenzCHF1.UseVisualStyleBackColor = true;
            this.buttonMuenzCHF1.Click += new System.EventHandler(this.buttonMuenzCHF1_Click);
            // 
            // buttonMuenzCHF2
            // 
            this.buttonMuenzCHF2.Location = new System.Drawing.Point(12, 308);
            this.buttonMuenzCHF2.Name = "buttonMuenzCHF2";
            this.buttonMuenzCHF2.Size = new System.Drawing.Size(75, 23);
            this.buttonMuenzCHF2.TabIndex = 22;
            this.buttonMuenzCHF2.Text = "CHF 2";
            this.buttonMuenzCHF2.UseVisualStyleBackColor = true;
            this.buttonMuenzCHF2.Click += new System.EventHandler(this.buttonMuenzCHF2_Click);
            // 
            // buttonMuenzCHF5
            // 
            this.buttonMuenzCHF5.Location = new System.Drawing.Point(12, 337);
            this.buttonMuenzCHF5.Name = "buttonMuenzCHF5";
            this.buttonMuenzCHF5.Size = new System.Drawing.Size(75, 23);
            this.buttonMuenzCHF5.TabIndex = 23;
            this.buttonMuenzCHF5.Text = "CHF 5";
            this.buttonMuenzCHF5.UseVisualStyleBackColor = true;
            this.buttonMuenzCHF5.Click += new System.EventHandler(this.buttonMuenzCHF5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 399);
            this.Controls.Add(this.buttonMuenzCHF5);
            this.Controls.Add(this.buttonMuenzCHF2);
            this.Controls.Add(this.buttonMuenzCHF1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbGuthaben);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.buttonKaufen);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCHF);
            this.Controls.Add(this.tbPreis);
            this.Controls.Add(this.buttonWallisellen);
            this.Controls.Add(this.buttonZueri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbZurueck);
            this.Controls.Add(this.cbHalbtax);
            this.Controls.Add(this.buttonAirolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAirolo;
        private System.Windows.Forms.CheckBox cbHalbtax;
        private System.Windows.Forms.CheckBox cbZurueck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZueri;
        private System.Windows.Forms.Button buttonWallisellen;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.Label tbCHF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonKaufen;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGuthaben;
        private System.Windows.Forms.Button buttonMuenzCHF2;
        private System.Windows.Forms.Button buttonMuenzCHF5;
        private System.Windows.Forms.Button buttonMuenzCHF1;
    }
}

