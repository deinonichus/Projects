namespace DBConnection {
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
            this.textBoxInputConnection = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.radioButtonSelect = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonDrop = new System.Windows.Forms.RadioButton();
            this.radioButtonCreate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDataBase = new System.Windows.Forms.Label();
            this.labelTable = new System.Windows.Forms.Label();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.labelColumn = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelFieldValue = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInputConnection
            // 
            this.textBoxInputConnection.Location = new System.Drawing.Point(13, 9);
            this.textBoxInputConnection.Name = "textBoxInputConnection";
            this.textBoxInputConnection.Size = new System.Drawing.Size(202, 20);
            this.textBoxInputConnection.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 35);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(202, 373);
            this.textBoxOutput.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(13, 415);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(201, 37);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "execute";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // radioButtonSelect
            // 
            this.radioButtonSelect.AutoSize = true;
            this.radioButtonSelect.Location = new System.Drawing.Point(6, 21);
            this.radioButtonSelect.Name = "radioButtonSelect";
            this.radioButtonSelect.Size = new System.Drawing.Size(66, 17);
            this.radioButtonSelect.TabIndex = 3;
            this.radioButtonSelect.TabStop = true;
            this.radioButtonSelect.Text = "SELECT";
            this.radioButtonSelect.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(6, 44);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(69, 17);
            this.radioButtonUpdate.TabIndex = 4;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "UPDATE";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Location = new System.Drawing.Point(6, 67);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(65, 17);
            this.radioButtonInsert.TabIndex = 5;
            this.radioButtonInsert.TabStop = true;
            this.radioButtonInsert.Text = "INSERT";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(6, 90);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(67, 17);
            this.radioButtonDelete.TabIndex = 6;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "DELETE";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            // 
            // radioButtonDrop
            // 
            this.radioButtonDrop.AutoSize = true;
            this.radioButtonDrop.Location = new System.Drawing.Point(6, 113);
            this.radioButtonDrop.Name = "radioButtonDrop";
            this.radioButtonDrop.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDrop.TabIndex = 7;
            this.radioButtonDrop.TabStop = true;
            this.radioButtonDrop.Text = "DROP";
            this.radioButtonDrop.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreate
            // 
            this.radioButtonCreate.AutoSize = true;
            this.radioButtonCreate.Location = new System.Drawing.Point(6, 136);
            this.radioButtonCreate.Name = "radioButtonCreate";
            this.radioButtonCreate.Size = new System.Drawing.Size(68, 17);
            this.radioButtonCreate.TabIndex = 8;
            this.radioButtonCreate.TabStop = true;
            this.radioButtonCreate.Text = "CREATE";
            this.radioButtonCreate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonInsert);
            this.groupBox1.Controls.Add(this.radioButtonCreate);
            this.groupBox1.Controls.Add(this.radioButtonSelect);
            this.groupBox1.Controls.Add(this.radioButtonDrop);
            this.groupBox1.Controls.Add(this.radioButtonUpdate);
            this.groupBox1.Controls.Add(this.radioButtonDelete);
            this.groupBox1.Location = new System.Drawing.Point(242, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 159);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Operation";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // labelDataBase
            // 
            this.labelDataBase.AutoSize = true;
            this.labelDataBase.Location = new System.Drawing.Point(10, 27);
            this.labelDataBase.Name = "labelDataBase";
            this.labelDataBase.Size = new System.Drawing.Size(54, 13);
            this.labelDataBase.TabIndex = 11;
            this.labelDataBase.Text = "DataBase";
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Location = new System.Drawing.Point(10, 65);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(34, 13);
            this.labelTable.TabIndex = 13;
            this.labelTable.Text = "Table";
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(91, 58);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(100, 20);
            this.textBoxTable.TabIndex = 12;
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.Location = new System.Drawing.Point(10, 103);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(42, 13);
            this.labelColumn.TabIndex = 15;
            this.labelColumn.Text = "Column";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // labelFieldValue
            // 
            this.labelFieldValue.AutoSize = true;
            this.labelFieldValue.Location = new System.Drawing.Point(10, 144);
            this.labelFieldValue.Name = "labelFieldValue";
            this.labelFieldValue.Size = new System.Drawing.Size(59, 13);
            this.labelFieldValue.TabIndex = 17;
            this.labelFieldValue.Text = "Field Value";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.labelFieldValue);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.labelDataBase);
            this.groupBox2.Controls.Add(this.labelColumn);
            this.groupBox2.Controls.Add(this.textBoxTable);
            this.groupBox2.Controls.Add(this.labelTable);
            this.groupBox2.Location = new System.Drawing.Point(355, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 181);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInputConnection);
            this.Name = "Form1";
            this.Text = "DB Connector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputConnection;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.RadioButton radioButtonSelect;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonInsert;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonDrop;
        private System.Windows.Forms.RadioButton radioButtonCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDataBase;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelFieldValue;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

