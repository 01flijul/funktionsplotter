namespace FunktionsPlotter
{
    partial class PlotterGUI
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
            this.tbA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.lbXvalues = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbXmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbXmax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPlot = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.pnl_ausgabe = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(12, 12);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 0;
            this.tbA.Text = "1";
            this.tbA.TextChanged += new System.EventHandler(this.tbA_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "x ² +";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(160, 14);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 3;
            this.tbB.Text = "2";
            this.tbB.TextChanged += new System.EventHandler(this.tbB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "x +";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(317, 14);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 20);
            this.tbC.TabIndex = 5;
            this.tbC.Text = "3";
            this.tbC.TextChanged += new System.EventHandler(this.tbC_TextChanged);
            // 
            // lbXvalues
            // 
            this.lbXvalues.FormattingEnabled = true;
            this.lbXvalues.Location = new System.Drawing.Point(22, 95);
            this.lbXvalues.Name = "lbXvalues";
            this.lbXvalues.Size = new System.Drawing.Size(145, 355);
            this.lbXvalues.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "x-Min";
            // 
            // tbXmin
            // 
            this.tbXmin.Location = new System.Drawing.Point(67, 42);
            this.tbXmin.Name = "tbXmin";
            this.tbXmin.Size = new System.Drawing.Size(100, 20);
            this.tbXmin.TabIndex = 8;
            this.tbXmin.Text = "-10";
            this.tbXmin.TextChanged += new System.EventHandler(this.tbXmin_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "x-Max";
            // 
            // tbXmax
            // 
            this.tbXmax.Location = new System.Drawing.Point(265, 41);
            this.tbXmax.Name = "tbXmax";
            this.tbXmax.Size = new System.Drawing.Size(100, 20);
            this.tbXmax.TabIndex = 10;
            this.tbXmax.Text = "10";
            this.tbXmax.TextChanged += new System.EventHandler(this.tbXmax_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wertetabelle";
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(548, 421);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 12;
            this.btnPlot.Text = "plot";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "step between xvals";
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(548, 42);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(100, 20);
            this.tbStep.TabIndex = 14;
            this.tbStep.Text = "1";
            this.tbStep.TextChanged += new System.EventHandler(this.tbStep_TextChanged);
            // 
            // tbMessages
            // 
            this.tbMessages.Enabled = false;
            this.tbMessages.Location = new System.Drawing.Point(187, 421);
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.Size = new System.Drawing.Size(355, 20);
            this.tbMessages.TabIndex = 15;
            // 
            // pnl_ausgabe
            // 
            this.pnl_ausgabe.Location = new System.Drawing.Point(207, 95);
            this.pnl_ausgabe.Name = "pnl_ausgabe";
            this.pnl_ausgabe.Size = new System.Drawing.Size(397, 287);
            this.pnl_ausgabe.TabIndex = 16;
            // 
            // PlotterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 457);
            this.Controls.Add(this.pnl_ausgabe);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.tbStep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbXmax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbXmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbXvalues);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbA);
            this.Name = "PlotterGUI";
            this.Text = "FunktionsPlotter";
            this.Load += new System.EventHandler(this.PlotterGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.ListBox lbXvalues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbXmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbXmax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.TextBox tbMessages;
        private System.Windows.Forms.Panel pnl_ausgabe;
    }
}

