namespace Calculadora
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnResolver = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(28, 25);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(50, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Numero1";
            this.lblNum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(28, 62);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(50, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Numero2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(28, 100);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(114, 22);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(114, 59);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 4;
            // 
            // btnSumar
            // 
            this.btnSumar.Image = global::Calculadora.Properties.Resources.plus1;
            this.btnSumar.Location = new System.Drawing.Point(67, 129);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(69, 42);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(426, 129);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(75, 23);
            this.btnNum7.TabIndex = 6;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(426, 166);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(75, 23);
            this.btnNum4.TabIndex = 7;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(523, 129);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(75, 23);
            this.btnNum8.TabIndex = 8;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(523, 166);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(75, 23);
            this.btnNum5.TabIndex = 9;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(426, 205);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(75, 23);
            this.btnNum1.TabIndex = 10;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(523, 205);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(75, 23);
            this.btnNum2.TabIndex = 11;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(618, 205);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(75, 23);
            this.btnNum3.TabIndex = 12;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(618, 166);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(75, 23);
            this.btnNum6.TabIndex = 13;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(618, 129);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(75, 23);
            this.btnNum9.TabIndex = 14;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(523, 247);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(75, 23);
            this.btnNum0.TabIndex = 15;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(713, 205);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 16;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(713, 166);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 17;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(713, 129);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 18;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(713, 95);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 19;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(713, 247);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(75, 23);
            this.btnResolver.TabIndex = 20;
            this.btnResolver.Text = "=";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // btnComa
            // 
            this.btnComa.Location = new System.Drawing.Point(618, 247);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(75, 23);
            this.btnComa.TabIndex = 21;
            this.btnComa.Text = ",";
            this.btnComa.UseVisualStyleBackColor = true;
            this.btnComa.Click += new System.EventHandler(this.btnComa_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(426, 95);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(267, 20);
            this.textBoxResult.TabIndex = 22;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(426, 247);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 23;
            this.btnBorrar.Text = "C";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.btnComa);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button btnBorrar;
    }
}

