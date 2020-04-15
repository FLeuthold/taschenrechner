namespace Taschenrechner
{
    partial class frmTaschenrechner
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
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.Ergebnis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(66, 73);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 0;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(66, 114);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 1;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(66, 29);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 2;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(66, 155);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(35, 13);
            this.lblOperator.TabIndex = 3;
            this.lblOperator.Text = "label1";
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.Location = new System.Drawing.Point(66, 220);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(35, 13);
            this.lblErgebnis.TabIndex = 5;
            this.lblErgebnis.Text = "label3";
            // 
            // Ergebnis
            // 
            this.Ergebnis.BackColor = System.Drawing.Color.White;
            this.Ergebnis.Location = new System.Drawing.Point(70, 186);
            this.Ergebnis.Name = "Ergebnis";
            this.Ergebnis.Size = new System.Drawing.Size(70, 21);
            this.Ergebnis.TabIndex = 6;
            // 
            // frmTaschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Ergebnis);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Name = "frmTaschenrechner";
            this.Text = "Taschenrechner";
            this.Load += new System.EventHandler(this.frmTaschenrechner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.Label Ergebnis;
    }
}

