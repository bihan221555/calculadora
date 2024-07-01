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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculoitbi));
            this.valorvenalitbi = new System.Windows.Forms.TextBox();
            this.aliquotaitbi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button1 = new calculadora.RoundButton();
            this.resultadoitbi = new System.Windows.Forms.Label();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition2 = new System.Windows.Forms.Timer(this.components);
            this.hamburguer = new calculadora.RoundButton();
            this.sidebar2 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.padraoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.impostoRendaButton = new System.Windows.Forms.Button();
            this.historicoTemp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.classe = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valorvenalitbi
            // 
            this.valorvenalitbi.Location = new System.Drawing.Point(74, 169);
            this.valorvenalitbi.Name = "valorvenalitbi";
            this.valorvenalitbi.Size = new System.Drawing.Size(149, 23);
            this.valorvenalitbi.TabIndex = 0;
            // 
            // aliquotaitbi
            // 
            this.aliquotaitbi.Location = new System.Drawing.Point(74, 251);
            this.aliquotaitbi.Name = "aliquotaitbi";
            this.aliquotaitbi.Size = new System.Drawing.Size(149, 23);
            this.aliquotaitbi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor venal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alíquota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Imposto a ser pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calculo ITBI";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button1.BorderRadius = 10;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(74, 305);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(149, 23);
            this.Button1.TabIndex = 13;
            this.Button1.Text = "Calcular";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // resultadoitbi
            // 
            this.resultadoitbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultadoitbi.ForeColor = System.Drawing.Color.White;
            this.resultadoitbi.Location = new System.Drawing.Point(52, 386);
            this.resultadoitbi.Name = "resultadoitbi";
            this.resultadoitbi.Size = new System.Drawing.Size(186, 24);
            this.resultadoitbi.TabIndex = 14;
            this.resultadoitbi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // sidebarTransition2
            // 
            this.sidebarTransition2.Interval = 1;
            this.sidebarTransition2.Tick += new System.EventHandler(this.sidebarTransition2_Tick);
            // 
            // hamburguer
            // 
            this.hamburguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hamburguer.BorderRadius = 10;
            this.hamburguer.FlatAppearance.BorderSize = 0;
            this.hamburguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hamburguer.Image = ((System.Drawing.Image)(resources.GetObject("hamburguer.Image")));
            this.hamburguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hamburguer.Location = new System.Drawing.Point(3, 7);
            this.hamburguer.Name = "hamburguer";
            this.hamburguer.Size = new System.Drawing.Size(37, 33);
            this.hamburguer.TabIndex = 39;
            this.hamburguer.UseVisualStyleBackColor = true;
            this.hamburguer.Click += new System.EventHandler(this.hamburguer_Click);
            // 
            // sidebar2
            // 
            this.sidebar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.sidebar2.Location = new System.Drawing.Point(-5, -1);
            this.sidebar2.Name = "sidebar2";
            this.sidebar2.Size = new System.Drawing.Size(0, 48);
            this.sidebar2.TabIndex = 40;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.historicoTemp);
            this.sidebar.Controls.Add(this.label6);
            this.sidebar.Location = new System.Drawing.Point(-5, 46);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(0, 448);
            this.sidebar.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.padraoButton);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 35);
            this.panel2.TabIndex = 29;
            // 
            // padraoButton
            // 
            this.padraoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.padraoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.padraoButton.FlatAppearance.BorderSize = 0;
            this.padraoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.padraoButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.padraoButton.ForeColor = System.Drawing.Color.White;
            this.padraoButton.Image = ((System.Drawing.Image)(resources.GetObject("padraoButton.Image")));
            this.padraoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.padraoButton.Location = new System.Drawing.Point(-13, -15);
            this.padraoButton.Name = "padraoButton";
            this.padraoButton.Padding = new System.Windows.Forms.Padding(20, 0, 140, 5);
            this.padraoButton.Size = new System.Drawing.Size(246, 70);
            this.padraoButton.TabIndex = 27;
            this.padraoButton.Text = "Padrão";
            this.padraoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.padraoButton.UseVisualStyleBackColor = false;
            this.padraoButton.Click += new System.EventHandler(this.padraoButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.impostoRendaButton);
            this.panel1.Location = new System.Drawing.Point(3, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 35);
            this.panel1.TabIndex = 26;
            // 
            // impostoRendaButton
            // 
            this.impostoRendaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.impostoRendaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.impostoRendaButton.FlatAppearance.BorderSize = 0;
            this.impostoRendaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impostoRendaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.impostoRendaButton.ForeColor = System.Drawing.Color.White;
            this.impostoRendaButton.Image = ((System.Drawing.Image)(resources.GetObject("impostoRendaButton.Image")));
            this.impostoRendaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.impostoRendaButton.Location = new System.Drawing.Point(-13, -15);
            this.impostoRendaButton.Name = "impostoRendaButton";
            this.impostoRendaButton.Padding = new System.Windows.Forms.Padding(20, 0, 80, 5);
            this.impostoRendaButton.Size = new System.Drawing.Size(246, 70);
            this.impostoRendaButton.TabIndex = 27;
            this.impostoRendaButton.Text = "Imposto de renda";
            this.impostoRendaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.impostoRendaButton.UseVisualStyleBackColor = false;
            this.impostoRendaButton.Click += new System.EventHandler(this.impostoRendaButton_Click);
            // 
            // historicoTemp
            // 
            this.historicoTemp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.historicoTemp.ForeColor = System.Drawing.Color.DarkGray;
            this.historicoTemp.Location = new System.Drawing.Point(3, 82);
            this.historicoTemp.Name = "historicoTemp";
            this.historicoTemp.Size = new System.Drawing.Size(236, 30);
            this.historicoTemp.TabIndex = 24;
            this.historicoTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 30);
            this.label6.TabIndex = 28;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // classe
            // 
            this.classe.AutoSize = true;
            this.classe.BackColor = System.Drawing.Color.Transparent;
            this.classe.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classe.ForeColor = System.Drawing.Color.White;
            this.classe.Location = new System.Drawing.Point(44, 11);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(162, 25);
            this.classe.TabIndex = 38;
            this.classe.Text = "Imposto de renda";
            // 
            // calculoitbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(307, 493);
            this.Controls.Add(this.hamburguer);
            this.Controls.Add(this.sidebar2);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.classe);
            this.Controls.Add(this.resultadoitbi);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aliquotaitbi);
            this.Controls.Add(this.valorvenalitbi);
            this.Name = "calculoitbi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculoitbi";
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox valorvenalitbi;
        private TextBox aliquotaitbi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private calculadora.RoundButton Button1;
        private Label resultadoitbi;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Timer sidebarTransition2;
        private calculadora.RoundButton hamburguer;
        private Panel sidebar2;
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Button padraoButton;
        private Panel panel1;
        private Button impostoRendaButton;
        private Label historicoTemp;
        private Label label6;
        private Label classe;
    }
}