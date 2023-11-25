namespace AP_Promedio
{
    partial class promedio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numero1 = new Label();
            numero2 = new Label();
            numero3 = new Label();
            label4 = new Label();
            txt_numero1 = new TextBox();
            txt_numero2 = new TextBox();
            txt_numero3 = new TextBox();
            txt_promedio = new TextBox();
            bt_calcular = new Button();
            SuspendLayout();
            // 
            // numero1
            // 
            numero1.AutoSize = true;
            numero1.BackColor = SystemColors.GradientActiveCaption;
            numero1.ForeColor = SystemColors.WindowFrame;
            numero1.Location = new Point(79, 51);
            numero1.Name = "numero1";
            numero1.Size = new Size(60, 15);
            numero1.TabIndex = 0;
            numero1.Text = "Número 1";
            numero1.Click += label1_Click;
            // 
            // numero2
            // 
            numero2.AutoSize = true;
            numero2.ForeColor = SystemColors.WindowFrame;
            numero2.Location = new Point(79, 92);
            numero2.Name = "numero2";
            numero2.Size = new Size(60, 15);
            numero2.TabIndex = 1;
            numero2.Text = "Número 2";
            // 
            // numero3
            // 
            numero3.AutoSize = true;
            numero3.ForeColor = SystemColors.WindowFrame;
            numero3.Location = new Point(79, 135);
            numero3.Name = "numero3";
            numero3.Size = new Size(60, 15);
            numero3.TabIndex = 2;
            numero3.Text = "Número 3";
            numero3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(79, 210);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Promedio";
            // 
            // txt_numero1
            // 
            txt_numero1.Location = new Point(176, 48);
            txt_numero1.Name = "txt_numero1";
            txt_numero1.Size = new Size(100, 23);
            txt_numero1.TabIndex = 4;
            txt_numero1.TextChanged += textBox1_TextChanged;
            // 
            // txt_numero2
            // 
            txt_numero2.Location = new Point(176, 89);
            txt_numero2.Name = "txt_numero2";
            txt_numero2.Size = new Size(100, 23);
            txt_numero2.TabIndex = 5;
            // 
            // txt_numero3
            // 
            txt_numero3.Location = new Point(176, 132);
            txt_numero3.Name = "txt_numero3";
            txt_numero3.Size = new Size(100, 23);
            txt_numero3.TabIndex = 6;
            // 
            // txt_promedio
            // 
            txt_promedio.Location = new Point(176, 207);
            txt_promedio.Name = "txt_promedio";
            txt_promedio.Size = new Size(100, 23);
            txt_promedio.TabIndex = 7;
            // 
            // bt_calcular
            // 
            bt_calcular.BackColor = SystemColors.ActiveCaption;
            bt_calcular.Cursor = Cursors.Hand;
            bt_calcular.FlatStyle = FlatStyle.Flat;
            bt_calcular.ForeColor = Color.Brown;
            bt_calcular.Location = new Point(106, 169);
            bt_calcular.Name = "bt_calcular";
            bt_calcular.Size = new Size(75, 23);
            bt_calcular.TabIndex = 8;
            bt_calcular.Text = "Calcular";
            bt_calcular.UseVisualStyleBackColor = false;
            bt_calcular.Click += bt_calcular_Click;
            // 
            // promedio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources._1b61264ce01b44500c86fd28d8519b33;
            ClientSize = new Size(382, 247);
            Controls.Add(bt_calcular);
            Controls.Add(txt_promedio);
            Controls.Add(txt_numero3);
            Controls.Add(txt_numero2);
            Controls.Add(txt_numero1);
            Controls.Add(label4);
            Controls.Add(numero3);
            Controls.Add(numero2);
            Controls.Add(numero1);
            ForeColor = SystemColors.WindowFrame;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "promedio";
            Text = "Promedio_de_3_numeros";
            Load += promedio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numero1;
        private Label numero2;
        private Label numero3;
        private Label label4;
        private TextBox txt_numero1;
        private TextBox txt_numero2;
        private TextBox txt_numero3;
        private TextBox txt_promedio;
        private Button bt_calcular;
    }
}