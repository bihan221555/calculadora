namespace calculadoraimposto1
{
    partial class calculoitbi
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
            this.valorvenalitbi = new System.Windows.Forms.TextBox();
            this.aliquotaitbi = new System.Windows.Forms.TextBox();
            this.resultadoitbi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoVoltar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valorvenalitbi
            // 
            this.valorvenalitbi.Location = new System.Drawing.Point(296, 148);
            this.valorvenalitbi.Name = "valorvenalitbi";
            this.valorvenalitbi.Size = new System.Drawing.Size(149, 23);
            this.valorvenalitbi.TabIndex = 0;
            // 
            // aliquotaitbi
            // 
            this.aliquotaitbi.Location = new System.Drawing.Point(296, 230);
            this.aliquotaitbi.Name = "aliquotaitbi";
            this.aliquotaitbi.Size = new System.Drawing.Size(149, 23);
            this.aliquotaitbi.TabIndex = 1;
            // 
            // resultadoitbi
            // 
            this.resultadoitbi.Location = new System.Drawing.Point(296, 362);
            this.resultadoitbi.Name = "resultadoitbi";
            this.resultadoitbi.Size = new System.Drawing.Size(149, 23);
            this.resultadoitbi.TabIndex = 2;
            this.resultadoitbi.TextChanged += new System.EventHandler(this.resultadoitbi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(311, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor venal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(324, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aliquota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(273, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Imposto a ser pago:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(289, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calculo ITBI";
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.AutoSize = true;
            this.botaoVoltar.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botaoVoltar.Location = new System.Drawing.Point(23, 27);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(45, 15);
            this.botaoVoltar.TabIndex = 8;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // calculoitbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultadoitbi);
            this.Controls.Add(this.aliquotaitbi);
            this.Controls.Add(this.valorvenalitbi);
            this.Name = "calculoitbi";
            this.Text = "calculoitbi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox valorvenalitbi;
        private TextBox aliquotaitbi;
        private TextBox resultadoitbi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label botaoVoltar;
    }
}