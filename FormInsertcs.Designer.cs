namespace DBChemical
{
    partial class FormInsertcs
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
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSymbol = new System.Windows.Forms.TextBox();
            this.textBoxNuclearCharge = new System.Windows.Forms.TextBox();
            this.textBoxMolarMass = new System.Windows.Forms.TextBox();
            this.textBoxAtomicRadius = new System.Windows.Forms.TextBox();
            this.textBoxDebyeTemperature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(122, 312);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название элемента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "химический символ";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(158, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxSymbol
            // 
            this.textBoxSymbol.Location = new System.Drawing.Point(158, 34);
            this.textBoxSymbol.Name = "textBoxSymbol";
            this.textBoxSymbol.Size = new System.Drawing.Size(100, 22);
            this.textBoxSymbol.TabIndex = 4;
            // 
            // textBoxNuclearCharge
            // 
            this.textBoxNuclearCharge.Location = new System.Drawing.Point(158, 62);
            this.textBoxNuclearCharge.Name = "textBoxNuclearCharge";
            this.textBoxNuclearCharge.Size = new System.Drawing.Size(100, 22);
            this.textBoxNuclearCharge.TabIndex = 5;
            // 
            // textBoxMolarMass
            // 
            this.textBoxMolarMass.Location = new System.Drawing.Point(158, 90);
            this.textBoxMolarMass.Name = "textBoxMolarMass";
            this.textBoxMolarMass.Size = new System.Drawing.Size(100, 22);
            this.textBoxMolarMass.TabIndex = 6;
            // 
            // textBoxAtomicRadius
            // 
            this.textBoxAtomicRadius.Location = new System.Drawing.Point(158, 118);
            this.textBoxAtomicRadius.Name = "textBoxAtomicRadius";
            this.textBoxAtomicRadius.Size = new System.Drawing.Size(100, 22);
            this.textBoxAtomicRadius.TabIndex = 7;
            // 
            // textBoxDebyeTemperature
            // 
            this.textBoxDebyeTemperature.Location = new System.Drawing.Point(158, 146);
            this.textBoxDebyeTemperature.Name = "textBoxDebyeTemperature";
            this.textBoxDebyeTemperature.Size = new System.Drawing.Size(100, 22);
            this.textBoxDebyeTemperature.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "заряд ядра";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "молярная масса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "атомный радиус";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "температура Дебая";
            // 
            // FormInsertcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 414);
            this.Controls.Add(this.textBoxDebyeTemperature);
            this.Controls.Add(this.textBoxAtomicRadius);
            this.Controls.Add(this.textBoxMolarMass);
            this.Controls.Add(this.textBoxNuclearCharge);
            this.Controls.Add(this.textBoxSymbol);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsert);
            this.Name = "FormInsertcs";
            this.Text = "FormInsertcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSymbol;
        private System.Windows.Forms.TextBox textBoxNuclearCharge;
        private System.Windows.Forms.TextBox textBoxMolarMass;
        private System.Windows.Forms.TextBox textBoxAtomicRadius;
        private System.Windows.Forms.TextBox textBoxDebyeTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}