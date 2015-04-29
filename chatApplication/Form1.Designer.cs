namespace chatApplication {
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
            this.textBoxObserverA = new System.Windows.Forms.TextBox();
            this.buttonSendB = new System.Windows.Forms.Button();
            this.textBoxObserverB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSendA = new System.Windows.Forms.TextBox();
            this.textBoxSendB = new System.Windows.Forms.TextBox();
            this.buttonSendA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxObserverA
            // 
            this.textBoxObserverA.Location = new System.Drawing.Point(12, 36);
            this.textBoxObserverA.Multiline = true;
            this.textBoxObserverA.Name = "textBoxObserverA";
            this.textBoxObserverA.ReadOnly = true;
            this.textBoxObserverA.Size = new System.Drawing.Size(246, 331);
            this.textBoxObserverA.TabIndex = 0;
            // 
            // buttonSendB
            // 
            this.buttonSendB.Location = new System.Drawing.Point(277, 399);
            this.buttonSendB.Name = "buttonSendB";
            this.buttonSendB.Size = new System.Drawing.Size(246, 23);
            this.buttonSendB.TabIndex = 1;
            this.buttonSendB.Text = "send";
            this.buttonSendB.UseVisualStyleBackColor = true;
            this.buttonSendB.Click += new System.EventHandler(this.buttonSendB_Click);
            // 
            // textBoxObserverB
            // 
            this.textBoxObserverB.Location = new System.Drawing.Point(277, 36);
            this.textBoxObserverB.Multiline = true;
            this.textBoxObserverB.Name = "textBoxObserverB";
            this.textBoxObserverB.ReadOnly = true;
            this.textBoxObserverB.Size = new System.Drawing.Size(246, 331);
            this.textBoxObserverB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Observer A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Observer B";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(538, 36);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(246, 386);
            this.textBoxLog.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Log";
            // 
            // textBoxSendA
            // 
            this.textBoxSendA.Location = new System.Drawing.Point(12, 373);
            this.textBoxSendA.Name = "textBoxSendA";
            this.textBoxSendA.Size = new System.Drawing.Size(246, 20);
            this.textBoxSendA.TabIndex = 7;
            // 
            // textBoxSendB
            // 
            this.textBoxSendB.Location = new System.Drawing.Point(277, 373);
            this.textBoxSendB.Name = "textBoxSendB";
            this.textBoxSendB.Size = new System.Drawing.Size(246, 20);
            this.textBoxSendB.TabIndex = 8;
            // 
            // buttonSendA
            // 
            this.buttonSendA.Location = new System.Drawing.Point(12, 399);
            this.buttonSendA.Name = "buttonSendA";
            this.buttonSendA.Size = new System.Drawing.Size(246, 23);
            this.buttonSendA.TabIndex = 9;
            this.buttonSendA.Text = "send";
            this.buttonSendA.UseVisualStyleBackColor = true;
            this.buttonSendA.Click += new System.EventHandler(this.buttonSendA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.buttonSendA);
            this.Controls.Add(this.textBoxSendB);
            this.Controls.Add(this.textBoxSendA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxObserverB);
            this.Controls.Add(this.buttonSendB);
            this.Controls.Add(this.textBoxObserverA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxObserverA;
        private System.Windows.Forms.Button buttonSendB;
        private System.Windows.Forms.TextBox textBoxObserverB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSendA;
        private System.Windows.Forms.TextBox textBoxSendB;
        private System.Windows.Forms.Button buttonSendA;
    }
}

