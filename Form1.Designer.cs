namespace Encriptador
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAbrirTexto = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btAbrirFichTexto = new System.Windows.Forms.Button();
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.btGuardarTexto = new System.Windows.Forms.Button();
            this.btGuardarEncriptado = new System.Windows.Forms.Button();
            this.tbEncriptado = new System.Windows.Forms.TextBox();
            this.btAbrirEncriptado = new System.Windows.Forms.Button();
            this.tbAbrirEncriptado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudChaveEncripta = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDesencripta = new System.Windows.Forms.NumericUpDown();
            this.btEncripta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudChaveEncripta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesencripta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ficheiro de texto:";
            // 
            // tbAbrirTexto
            // 
            this.tbAbrirTexto.Location = new System.Drawing.Point(106, 6);
            this.tbAbrirTexto.Name = "tbAbrirTexto";
            this.tbAbrirTexto.Size = new System.Drawing.Size(383, 20);
            this.tbAbrirTexto.TabIndex = 1;
            // 
            // btAbrirFichTexto
            // 
            this.btAbrirFichTexto.Location = new System.Drawing.Point(504, 6);
            this.btAbrirFichTexto.Name = "btAbrirFichTexto";
            this.btAbrirFichTexto.Size = new System.Drawing.Size(86, 20);
            this.btAbrirFichTexto.TabIndex = 2;
            this.btAbrirFichTexto.Text = "Abrir";
            this.btAbrirFichTexto.UseVisualStyleBackColor = true;
            this.btAbrirFichTexto.Click += new System.EventHandler(this.BtAbrirFichTexto_Click);
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(15, 58);
            this.tbTexto.Multiline = true;
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTexto.Size = new System.Drawing.Size(575, 446);
            this.tbTexto.TabIndex = 3;
            // 
            // btGuardarTexto
            // 
            this.btGuardarTexto.Location = new System.Drawing.Point(504, 32);
            this.btGuardarTexto.Name = "btGuardarTexto";
            this.btGuardarTexto.Size = new System.Drawing.Size(85, 20);
            this.btGuardarTexto.TabIndex = 6;
            this.btGuardarTexto.Text = "Guardar";
            this.btGuardarTexto.UseVisualStyleBackColor = true;
            this.btGuardarTexto.Click += new System.EventHandler(this.BtGuardarTexto_Click);
            // 
            // btGuardarEncriptado
            // 
            this.btGuardarEncriptado.Location = new System.Drawing.Point(1191, 32);
            this.btGuardarEncriptado.Name = "btGuardarEncriptado";
            this.btGuardarEncriptado.Size = new System.Drawing.Size(86, 20);
            this.btGuardarEncriptado.TabIndex = 13;
            this.btGuardarEncriptado.Text = "Guardar";
            this.btGuardarEncriptado.UseVisualStyleBackColor = true;
            this.btGuardarEncriptado.Click += new System.EventHandler(this.BtGuardarEncriptado_Click);
            // 
            // tbEncriptado
            // 
            this.tbEncriptado.Location = new System.Drawing.Point(702, 58);
            this.tbEncriptado.Multiline = true;
            this.tbEncriptado.Name = "tbEncriptado";
            this.tbEncriptado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEncriptado.Size = new System.Drawing.Size(575, 446);
            this.tbEncriptado.TabIndex = 10;
            // 
            // btAbrirEncriptado
            // 
            this.btAbrirEncriptado.Location = new System.Drawing.Point(1191, 6);
            this.btAbrirEncriptado.Name = "btAbrirEncriptado";
            this.btAbrirEncriptado.Size = new System.Drawing.Size(86, 20);
            this.btAbrirEncriptado.TabIndex = 9;
            this.btAbrirEncriptado.Text = "Abrir";
            this.btAbrirEncriptado.UseVisualStyleBackColor = true;
            this.btAbrirEncriptado.Click += new System.EventHandler(this.BtAbrirEncriptado_Click);
            // 
            // tbAbrirEncriptado
            // 
            this.tbAbrirEncriptado.Location = new System.Drawing.Point(793, 6);
            this.tbAbrirEncriptado.Name = "tbAbrirEncriptado";
            this.tbAbrirEncriptado.Size = new System.Drawing.Size(383, 20);
            this.tbAbrirEncriptado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ficheiro encriptado:";
            // 
            // nudChaveEncripta
            // 
            this.nudChaveEncripta.Location = new System.Drawing.Point(596, 123);
            this.nudChaveEncripta.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudChaveEncripta.Name = "nudChaveEncripta";
            this.nudChaveEncripta.Size = new System.Drawing.Size(100, 20);
            this.nudChaveEncripta.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Chave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(623, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Chave";
            // 
            // nudDesencripta
            // 
            this.nudDesencripta.Location = new System.Drawing.Point(596, 350);
            this.nudDesencripta.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudDesencripta.Name = "nudDesencripta";
            this.nudDesencripta.Size = new System.Drawing.Size(100, 20);
            this.nudDesencripta.TabIndex = 16;
            // 
            // btEncripta
            // 
            this.btEncripta.Location = new System.Drawing.Point(596, 149);
            this.btEncripta.Name = "btEncripta";
            this.btEncripta.Size = new System.Drawing.Size(100, 21);
            this.btEncripta.TabIndex = 18;
            this.btEncripta.Text = "Encripta >>";
            this.btEncripta.UseVisualStyleBackColor = true;
            this.btEncripta.Click += new System.EventHandler(this.BtEncripta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 21);
            this.button1.TabIndex = 19;
            this.button1.Text = "<< Desencripta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btEncripta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudDesencripta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudChaveEncripta);
            this.Controls.Add(this.btGuardarEncriptado);
            this.Controls.Add(this.tbEncriptado);
            this.Controls.Add(this.btAbrirEncriptado);
            this.Controls.Add(this.tbAbrirEncriptado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGuardarTexto);
            this.Controls.Add(this.tbTexto);
            this.Controls.Add(this.btAbrirFichTexto);
            this.Controls.Add(this.tbAbrirTexto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Encriptador";
            ((System.ComponentModel.ISupportInitialize)(this.nudChaveEncripta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesencripta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAbrirTexto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btAbrirFichTexto;
        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Button btGuardarTexto;
        private System.Windows.Forms.Button btGuardarEncriptado;
        private System.Windows.Forms.TextBox tbEncriptado;
        private System.Windows.Forms.Button btAbrirEncriptado;
        private System.Windows.Forms.TextBox tbAbrirEncriptado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudChaveEncripta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDesencripta;
        private System.Windows.Forms.Button btEncripta;
        private System.Windows.Forms.Button button1;
    }
}

