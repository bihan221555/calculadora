namespace calculadora
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.padraoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.impostoRendaButton = new System.Windows.Forms.Button();
            this.historicoTemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hamburguer = new calculadora.RoundButton();
            this.classe = new System.Windows.Forms.Label();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebar2 = new System.Windows.Forms.Panel();
            this.sidebarTransition2 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.roundButton4 = new calculadora.RoundButton();
            this.roundButton2 = new calculadora.RoundButton();
            this.label2 = new System.Windows.Forms.Label();
            this.municipalButton = new calculadora.RoundButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.historicoTemp);
            this.sidebar.Controls.Add(this.label1);
            this.sidebar.Location = new System.Drawing.Point(-5, 46);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(0, 448);
            this.sidebar.TabIndex = 26;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(3, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 30);
            this.label1.TabIndex = 28;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.hamburguer.TabIndex = 31;
            this.hamburguer.UseVisualStyleBackColor = true;
            this.hamburguer.Click += new System.EventHandler(this.hamburguer_Click);
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
            this.classe.TabIndex = 30;
            this.classe.Text = "Imposto de renda";
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // sidebar2
            // 
            this.sidebar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.sidebar2.Location = new System.Drawing.Point(-5, -1);
            this.sidebar2.Name = "sidebar2";
            this.sidebar2.Size = new System.Drawing.Size(0, 48);
            this.sidebar2.TabIndex = 32;
            // 
            // sidebarTransition2
            // 
            this.sidebarTransition2.Interval = 1;
            this.sidebarTransition2.Tick += new System.EventHandler(this.sidebarTransition2_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.roundButton4);
            this.panel3.Controls.Add(this.roundButton2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.municipalButton);
            this.panel3.Location = new System.Drawing.Point(54, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 237);
            this.panel3.TabIndex = 33;
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.roundButton4.BorderRadius = 10;
            this.roundButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundButton4.ForeColor = System.Drawing.Color.White;
            this.roundButton4.Location = new System.Drawing.Point(24, 161);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(152, 23);
            this.roundButton4.TabIndex = 38;
            this.roundButton4.Text = "Imposto Federal";
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.roundButton2.BorderRadius = 10;
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(24, 125);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(152, 23);
            this.roundButton2.TabIndex = 37;
            this.roundButton2.Text = "Imposto Estadual";
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "TIPOS DE IMPOSTO";
            // 
            // municipalButton
            // 
            this.municipalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.municipalButton.BorderRadius = 10;
            this.municipalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.municipalButton.FlatAppearance.BorderSize = 0;
            this.municipalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.municipalButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.municipalButton.ForeColor = System.Drawing.Color.White;
            this.municipalButton.Location = new System.Drawing.Point(24, 87);
            this.municipalButton.Name = "municipalButton";
            this.municipalButton.Size = new System.Drawing.Size(152, 23);
            this.municipalButton.TabIndex = 0;
            this.municipalButton.Text = "Imposto Municipal";
            this.municipalButton.UseVisualStyleBackColor = false;
            this.municipalButton.Click += new System.EventHandler(this.municipalButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel4.Location = new System.Drawing.Point(-5, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 100);
            this.panel4.TabIndex = 34;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(307, 493);
            this.Controls.Add(this.hamburguer);
            this.Controls.Add(this.sidebar2);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.classe);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton hamburguer;
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Button padraoButton;
        private Panel panel1;
        private Button impostoRendaButton;
        private Label historicoTemp;
        private Label label1;
        private RoundButton delet1;
        private RoundButton porcentagem;
        private RoundButton clear;
        private RoundButton igual;
        private RoundButton divisao;
        private RoundButton vezes;
        private RoundButton menos;
        private RoundButton mais;
        private RoundButton negativar;
        private RoundButton virgula;
        private RoundButton num0;
        private RoundButton num9;
        private RoundButton num8;
        private RoundButton num7;
        private RoundButton num6;
        private RoundButton num5;
        private RoundButton num4;
        private RoundButton num3;
        private RoundButton num2;
        private RoundButton num1;
        private Label resultadoTextBox;
        private Panel sidebar2;
        private Label classe;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Timer sidebarTransition2;
        private Panel panel3;
        private Label label2;
        private RoundButton municipalButton;
        private RoundButton roundButton4;
        private RoundButton roundButton2;
        private Panel panel4;
    }
}