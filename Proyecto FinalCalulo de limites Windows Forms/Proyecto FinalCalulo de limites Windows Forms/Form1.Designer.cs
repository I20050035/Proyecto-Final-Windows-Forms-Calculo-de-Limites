namespace Proyecto_FinalCalulo_de_limites_Windows_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumV1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboOperacion1 = new System.Windows.Forms.ComboBox();
            this.NumV2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboOperacion2 = new System.Windows.Forms.ComboBox();
            this.NumV3 = new System.Windows.Forms.NumericUpDown();
            this.numLimite = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCalcularResultadoFinal = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lblResultadoFinaltotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumV3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // NumV1
            // 
            this.NumV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumV1.Location = new System.Drawing.Point(167, 48);
            this.NumV1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumV1.Name = "NumV1";
            this.NumV1.Size = new System.Drawing.Size(48, 38);
            this.NumV1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "(";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = ")";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 69);
            this.label4.TabIndex = 1;
            this.label4.Text = "(";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(734, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 69);
            this.label5.TabIndex = 1;
            this.label5.Text = ")";
            // 
            // cboOperacion1
            // 
            this.cboOperacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperacion1.FormattingEnabled = true;
            this.cboOperacion1.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cboOperacion1.Location = new System.Drawing.Point(353, 50);
            this.cboOperacion1.Name = "cboOperacion1";
            this.cboOperacion1.Size = new System.Drawing.Size(51, 39);
            this.cboOperacion1.TabIndex = 2;
            // 
            // NumV2
            // 
            this.NumV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumV2.Location = new System.Drawing.Point(422, 49);
            this.NumV2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumV2.Name = "NumV2";
            this.NumV2.Size = new System.Drawing.Size(48, 38);
            this.NumV2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "(";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 46);
            this.label6.TabIndex = 1;
            this.label6.Text = ")";
            // 
            // cboOperacion2
            // 
            this.cboOperacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperacion2.FormattingEnabled = true;
            this.cboOperacion2.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cboOperacion2.Location = new System.Drawing.Point(608, 50);
            this.cboOperacion2.Name = "cboOperacion2";
            this.cboOperacion2.Size = new System.Drawing.Size(51, 39);
            this.cboOperacion2.TabIndex = 2;
            // 
            // NumV3
            // 
            this.NumV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumV3.Location = new System.Drawing.Point(680, 51);
            this.NumV3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumV3.Name = "NumV3";
            this.NumV3.Size = new System.Drawing.Size(48, 38);
            this.NumV3.TabIndex = 0;
            // 
            // numLimite
            // 
            this.numLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLimite.Location = new System.Drawing.Point(122, 117);
            this.numLimite.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numLimite.Name = "numLimite";
            this.numLimite.Size = new System.Drawing.Size(48, 38);
            this.numLimite.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lim --->";
            // 
            // lblCalcularResultadoFinal
            // 
            this.lblCalcularResultadoFinal.AutoSize = true;
            this.lblCalcularResultadoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcularResultadoFinal.Location = new System.Drawing.Point(770, 40);
            this.lblCalcularResultadoFinal.Name = "lblCalcularResultadoFinal";
            this.lblCalcularResultadoFinal.Size = new System.Drawing.Size(43, 46);
            this.lblCalcularResultadoFinal.TabIndex = 1;
            this.lblCalcularResultadoFinal.Text = "=";
            this.lblCalcularResultadoFinal.Click += new System.EventHandler(this.lblCalcularResultadoFinal_Click);
            // 
            // txtX1
            // 
            this.txtX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(259, 47);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(49, 38);
            this.txtX1.TabIndex = 4;
            // 
            // txtX2
            // 
            this.txtX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(514, 50);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(49, 38);
            this.txtX2.TabIndex = 4;
            // 
            // lblResultadoFinaltotal
            // 
            this.lblResultadoFinaltotal.AutoSize = true;
            this.lblResultadoFinaltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoFinaltotal.Location = new System.Drawing.Point(808, 41);
            this.lblResultadoFinaltotal.Name = "lblResultadoFinaltotal";
            this.lblResultadoFinaltotal.Size = new System.Drawing.Size(31, 46);
            this.lblResultadoFinaltotal.TabIndex = 1;
            this.lblResultadoFinaltotal.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboOperacion2);
            this.Controls.Add(this.cboOperacion1);
            this.Controls.Add(this.lblResultadoFinaltotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCalcularResultadoFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumV2);
            this.Controls.Add(this.NumV3);
            this.Controls.Add(this.numLimite);
            this.Controls.Add(this.NumV1);
            this.Name = "Form1";
            this.Text = "lblResultadoTotal";
            ((System.ComponentModel.ISupportInitialize)(this.NumV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumV3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumV1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboOperacion1;
        private System.Windows.Forms.NumericUpDown NumV2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboOperacion2;
        private System.Windows.Forms.NumericUpDown NumV3;
        private System.Windows.Forms.NumericUpDown numLimite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCalcularResultadoFinal;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label lblResultadoFinaltotal;
        private System.Windows.Forms.Label label8;
    }
}

