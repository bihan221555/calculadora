﻿namespace calculadoraimposto1
{
    partial class calculoicms
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultadoicms = new System.Windows.Forms.TextBox();
            this.aliquotaicms = new System.Windows.Forms.TextBox();
            this.valorProdutoicms = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Kufi Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(38, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 46);
            this.label4.TabIndex = 15;
            this.label4.Text = "Calculo ICMS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(51, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Imposto a ser pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(102, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Alíquota:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(78, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor produto:";
            // 
            // resultadoicms
            // 
            this.resultadoicms.Location = new System.Drawing.Point(73, 405);
            this.resultadoicms.Name = "resultadoicms";
            this.resultadoicms.Size = new System.Drawing.Size(149, 23);
            this.resultadoicms.TabIndex = 10;
            this.resultadoicms.TextChanged += new System.EventHandler(this.resultadoicms_TextChanged);
            // 
            // aliquotaicms
            // 
            this.aliquotaicms.Location = new System.Drawing.Point(74, 262);
            this.aliquotaicms.Name = "aliquotaicms";
            this.aliquotaicms.Size = new System.Drawing.Size(149, 23);
            this.aliquotaicms.TabIndex = 9;
            // 
            // valorProdutoicms
            // 
            this.valorProdutoicms.Location = new System.Drawing.Point(74, 180);
            this.valorProdutoicms.Name = "valorProdutoicms";
            this.valorProdutoicms.Size = new System.Drawing.Size(149, 23);
            this.valorProdutoicms.TabIndex = 8;
            // 
            // calculoicms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(307, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultadoicms);
            this.Controls.Add(this.aliquotaicms);
            this.Controls.Add(this.valorProdutoicms);
            this.Name = "calculoicms";
            this.Text = "calculoicms";
            this.Load += new System.EventHandler(this.calculoicms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox resultadoicms;
        private TextBox aliquotaicms;
        private TextBox valorProdutoicms;
    }
}