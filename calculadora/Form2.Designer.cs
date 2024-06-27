using System.Security.Cryptography.Xml;
//using iText.Layout.Properties;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace calculadoraimposto1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.impostoMunicipal = new calculadora.RoundButton();
            this.roundButton2 = new calculadora.RoundButton();
            this.roundButton3 = new calculadora.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hamburguer = new calculadora.RoundButton();
            this.classe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.padraoButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.impostoRendaButton = new System.Windows.Forms.Button();
            this.historicoTemp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO DE IMPOSTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // impostoMunicipal
            // 
            this.impostoMunicipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.impostoMunicipal.BorderRadius = 10;
            this.impostoMunicipal.FlatAppearance.BorderSize = 0;
            this.impostoMunicipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impostoMunicipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.impostoMunicipal.ForeColor = System.Drawing.Color.White;
            this.impostoMunicipal.Location = new System.Drawing.Point(54, 228);
            this.impostoMunicipal.Name = "impostoMunicipal";
            this.impostoMunicipal.Size = new System.Drawing.Size(183, 23);
            this.impostoMunicipal.TabIndex = 4;
            this.impostoMunicipal.Text = "IMPOSTO MUNICIPAL";
            this.impostoMunicipal.UseVisualStyleBackColor = false;
            this.impostoMunicipal.Click += new System.EventHandler(this.impostoMunicipal_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.roundButton2.BorderRadius = 10;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(54, 257);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(183, 23);
            this.roundButton2.TabIndex = 5;
            this.roundButton2.Text = "IMPOSTO ESTADUAL";
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.roundButton3.BorderRadius = 10;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(54, 286);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(183, 23);
            this.roundButton3.TabIndex = 6;
            this.roundButton3.Text = "IMPOSTO FEDERAL";
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.hamburguer);
            this.panel1.Controls.Add(this.classe);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 135);
            this.panel1.TabIndex = 7;
            // 
            // hamburguer
            // 
            this.hamburguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hamburguer.BorderRadius = 10;
            this.hamburguer.FlatAppearance.BorderSize = 0;
            this.hamburguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hamburguer.Image = ((System.Drawing.Image)(resources.GetObject("hamburguer.Image")));
            this.hamburguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hamburguer.Location = new System.Drawing.Point(7, 7);
            this.hamburguer.Name = "hamburguer";
            this.hamburguer.Size = new System.Drawing.Size(37, 33);
            this.hamburguer.TabIndex = 24;
            this.hamburguer.UseVisualStyleBackColor = true;
            this.hamburguer.Click += new System.EventHandler(this.hamburguer_Click);
            // 
            // classe
            // 
            this.classe.AutoSize = true;
            this.classe.BackColor = System.Drawing.Color.Transparent;
            this.classe.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classe.ForeColor = System.Drawing.Color.White;
            this.classe.Location = new System.Drawing.Point(44, 10);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(162, 25);
            this.classe.TabIndex = 25;
            this.classe.Text = "Imposto de renda";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel2.Location = new System.Drawing.Point(-5, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 135);
            this.panel2.TabIndex = 8;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.historicoTemp);
            this.sidebar.Controls.Add(this.label2);
            this.sidebar.Location = new System.Drawing.Point(-5, 46);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(0, 448);
            this.sidebar.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.padraoButton);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 35);
            this.panel3.TabIndex = 29;
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
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.impostoRendaButton);
            this.panel4.Location = new System.Drawing.Point(3, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 35);
            this.panel4.TabIndex = 26;
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 30);
            this.label2.TabIndex = 28;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(307, 493);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.impostoMunicipal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private calculadora.RoundButton impostoMunicipal;
        private calculadora.RoundButton roundButton2;
        private calculadora.RoundButton roundButton3;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel sidebar;
        private Panel panel3;
        private Button padraoButton;
        private Panel panel4;
        private Button impostoRendaButton;
        private Label historicoTemp;
        private Label label2;
        private calculadora.RoundButton hamburguer;
        private Label classe;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}