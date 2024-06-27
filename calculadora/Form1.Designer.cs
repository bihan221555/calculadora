using System.Security.Cryptography.Xml;
//using iText.Layout.Properties;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resultadoTextBox = new System.Windows.Forms.Label();
            this.num1 = new calculadora.RoundButton();
            this.num2 = new calculadora.RoundButton();
            this.num3 = new calculadora.RoundButton();
            this.num4 = new calculadora.RoundButton();
            this.num5 = new calculadora.RoundButton();
            this.num6 = new calculadora.RoundButton();
            this.num7 = new calculadora.RoundButton();
            this.num8 = new calculadora.RoundButton();
            this.num9 = new calculadora.RoundButton();
            this.num0 = new calculadora.RoundButton();
            this.virgula = new calculadora.RoundButton();
            this.negativar = new calculadora.RoundButton();
            this.mais = new calculadora.RoundButton();
            this.menos = new calculadora.RoundButton();
            this.vezes = new calculadora.RoundButton();
            this.divisao = new calculadora.RoundButton();
            this.igual = new calculadora.RoundButton();
            this.clear = new calculadora.RoundButton();
            this.porcentagem = new calculadora.RoundButton();
            this.classe = new System.Windows.Forms.Label();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebar2 = new System.Windows.Forms.Panel();
            this.sidebarTransition2 = new System.Windows.Forms.Timer(this.components);
            this.delet1 = new calculadora.RoundButton();
            this.hamburguer = new calculadora.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.historicoTemp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.impostoRendaButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.padraoButton = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.BackColor = System.Drawing.Color.Transparent;
            this.resultadoTextBox.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultadoTextBox.ForeColor = System.Drawing.Color.White;
            this.resultadoTextBox.Location = new System.Drawing.Point(3, 49);
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.Size = new System.Drawing.Size(302, 127);
            this.resultadoTextBox.TabIndex = 0;
            this.resultadoTextBox.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.num1.BorderRadius = 10;
            this.num1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num1.FlatAppearance.BorderSize = 0;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num1.ForeColor = System.Drawing.Color.White;
            this.num1.Location = new System.Drawing.Point(9, 377);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(67, 52);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.num2.BorderRadius = 10;
            this.num2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num2.FlatAppearance.BorderSize = 0;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num2.ForeColor = System.Drawing.Color.White;
            this.num2.Location = new System.Drawing.Point(82, 377);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(67, 52);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.num3.BorderRadius = 10;
            this.num3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num3.FlatAppearance.BorderSize = 0;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num3.ForeColor = System.Drawing.Color.White;
            this.num3.Location = new System.Drawing.Point(155, 377);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(67, 52);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.num4.BorderRadius = 10;
            this.num4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num4.FlatAppearance.BorderSize = 0;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num4.ForeColor = System.Drawing.Color.White;
            this.num4.Location = new System.Drawing.Point(9, 319);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(67, 52);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.num5.BorderRadius = 10;
            this.num5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num5.FlatAppearance.BorderSize = 0;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num5.ForeColor = System.Drawing.Color.White;
            this.num5.Location = new System.Drawing.Point(82, 319);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(67, 52);
            this.num5.TabIndex = 5;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.num6.BorderRadius = 10;
            this.num6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num6.FlatAppearance.BorderSize = 0;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num6.ForeColor = System.Drawing.Color.White;
            this.num6.Location = new System.Drawing.Point(155, 319);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(67, 52);
            this.num6.TabIndex = 6;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.num7.BorderRadius = 10;
            this.num7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num7.FlatAppearance.BorderSize = 0;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num7.ForeColor = System.Drawing.Color.White;
            this.num7.Location = new System.Drawing.Point(9, 261);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(67, 52);
            this.num7.TabIndex = 7;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.num8.BorderRadius = 10;
            this.num8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num8.FlatAppearance.BorderSize = 0;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num8.ForeColor = System.Drawing.Color.White;
            this.num8.Location = new System.Drawing.Point(82, 261);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(67, 52);
            this.num8.TabIndex = 8;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.num9.BorderRadius = 10;
            this.num9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num9.FlatAppearance.BorderSize = 0;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num9.ForeColor = System.Drawing.Color.White;
            this.num9.Location = new System.Drawing.Point(155, 261);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(67, 52);
            this.num9.TabIndex = 9;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.num0.BorderRadius = 10;
            this.num0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num0.FlatAppearance.BorderSize = 0;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num0.ForeColor = System.Drawing.Color.White;
            this.num0.Location = new System.Drawing.Point(82, 435);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(67, 52);
            this.num0.TabIndex = 10;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // virgula
            // 
            this.virgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.virgula.BorderRadius = 10;
            this.virgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.virgula.FlatAppearance.BorderSize = 0;
            this.virgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.virgula.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.virgula.ForeColor = System.Drawing.Color.White;
            this.virgula.Location = new System.Drawing.Point(155, 435);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(67, 52);
            this.virgula.TabIndex = 11;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = false;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // negativar
            // 
            this.negativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.negativar.BorderRadius = 10;
            this.negativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.negativar.FlatAppearance.BorderSize = 0;
            this.negativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.negativar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.negativar.ForeColor = System.Drawing.Color.White;
            this.negativar.Location = new System.Drawing.Point(9, 435);
            this.negativar.Name = "negativar";
            this.negativar.Size = new System.Drawing.Size(67, 52);
            this.negativar.TabIndex = 12;
            this.negativar.Text = "+/-";
            this.negativar.UseVisualStyleBackColor = false;
            this.negativar.Click += new System.EventHandler(this.negativar_Click);
            // 
            // mais
            // 
            this.mais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.mais.BorderRadius = 10;
            this.mais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mais.FlatAppearance.BorderSize = 0;
            this.mais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mais.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mais.ForeColor = System.Drawing.Color.White;
            this.mais.Location = new System.Drawing.Point(228, 377);
            this.mais.Name = "mais";
            this.mais.Size = new System.Drawing.Size(67, 52);
            this.mais.TabIndex = 13;
            this.mais.Text = "+";
            this.mais.UseVisualStyleBackColor = false;
            this.mais.Click += new System.EventHandler(this.mais_Click);
            // 
            // menos
            // 
            this.menos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.menos.BorderRadius = 10;
            this.menos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menos.FlatAppearance.BorderSize = 0;
            this.menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menos.ForeColor = System.Drawing.Color.White;
            this.menos.Location = new System.Drawing.Point(228, 319);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(67, 52);
            this.menos.TabIndex = 14;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = false;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // vezes
            // 
            this.vezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.vezes.BorderRadius = 10;
            this.vezes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vezes.FlatAppearance.BorderSize = 0;
            this.vezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vezes.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vezes.ForeColor = System.Drawing.Color.White;
            this.vezes.Location = new System.Drawing.Point(228, 261);
            this.vezes.Name = "vezes";
            this.vezes.Size = new System.Drawing.Size(67, 52);
            this.vezes.TabIndex = 15;
            this.vezes.Text = "X";
            this.vezes.UseVisualStyleBackColor = false;
            this.vezes.Click += new System.EventHandler(this.vezes_Click);
            // 
            // divisao
            // 
            this.divisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.divisao.BorderRadius = 10;
            this.divisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divisao.FlatAppearance.BorderSize = 0;
            this.divisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divisao.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divisao.ForeColor = System.Drawing.Color.White;
            this.divisao.Location = new System.Drawing.Point(228, 203);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(67, 52);
            this.divisao.TabIndex = 16;
            this.divisao.Text = "÷";
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(236)))));
            this.igual.BorderRadius = 10;
            this.igual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igual.FlatAppearance.BorderSize = 0;
            this.igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igual.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.igual.ForeColor = System.Drawing.Color.Black;
            this.igual.Location = new System.Drawing.Point(228, 435);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(67, 52);
            this.igual.TabIndex = 17;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.clear.BorderRadius = 10;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(82, 203);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(67, 52);
            this.clear.TabIndex = 19;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // porcentagem
            // 
            this.porcentagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.porcentagem.BorderRadius = 10;
            this.porcentagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.porcentagem.FlatAppearance.BorderSize = 0;
            this.porcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.porcentagem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.porcentagem.ForeColor = System.Drawing.Color.White;
            this.porcentagem.Location = new System.Drawing.Point(9, 203);
            this.porcentagem.Name = "porcentagem";
            this.porcentagem.Size = new System.Drawing.Size(67, 52);
            this.porcentagem.TabIndex = 20;
            this.porcentagem.Text = "%";
            this.porcentagem.UseVisualStyleBackColor = false;
            this.porcentagem.Click += new System.EventHandler(this.porcentagem_Click);
            // 
            // classe
            // 
            this.classe.AutoSize = true;
            this.classe.BackColor = System.Drawing.Color.Transparent;
            this.classe.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classe.ForeColor = System.Drawing.Color.White;
            this.classe.Location = new System.Drawing.Point(44, 10);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(72, 25);
            this.classe.TabIndex = 22;
            this.classe.Text = "Padrão";
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // sidebar2
            // 
            this.sidebar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.sidebar2.Location = new System.Drawing.Point(-5, -2);
            this.sidebar2.Name = "sidebar2";
            this.sidebar2.Size = new System.Drawing.Size(0, 48);
            this.sidebar2.TabIndex = 27;
            // 
            // sidebarTransition2
            // 
            this.sidebarTransition2.Interval = 1;
            this.sidebarTransition2.Tick += new System.EventHandler(this.sidebarTransition2_Tick);
            // 
            // delet1
            // 
            this.delet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.delet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delet1.BackgroundImage")));
            this.delet1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delet1.BorderRadius = 10;
            this.delet1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delet1.FlatAppearance.BorderSize = 0;
            this.delet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delet1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delet1.ForeColor = System.Drawing.Color.White;
            this.delet1.Location = new System.Drawing.Point(155, 203);
            this.delet1.Name = "delet1";
            this.delet1.Size = new System.Drawing.Size(67, 52);
            this.delet1.TabIndex = 18;
            this.delet1.UseVisualStyleBackColor = false;
            this.delet1.Click += new System.EventHandler(this.delet1_Click);
            // 
            // hamburguer
            // 
            this.hamburguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hamburguer.BorderRadius = 10;
            this.hamburguer.FlatAppearance.BorderSize = 0;
            this.hamburguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hamburguer.Image = ((System.Drawing.Image)(resources.GetObject("hamburguer.Image")));
            this.hamburguer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hamburguer.Location = new System.Drawing.Point(1, 7);
            this.hamburguer.Name = "hamburguer";
            this.hamburguer.Size = new System.Drawing.Size(37, 33);
            this.hamburguer.TabIndex = 23;
            this.hamburguer.UseVisualStyleBackColor = true;
            this.hamburguer.Click += new System.EventHandler(this.hamburguer_Click);
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
            this.sidebar.TabIndex = 25;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(307, 493);
            this.Controls.Add(this.hamburguer);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.delet1);
            this.Controls.Add(this.porcentagem);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.vezes);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.mais);
            this.Controls.Add(this.negativar);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(this.sidebar2);
            this.Controls.Add(this.classe);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label resultadoTextBox;
        private RoundButton num1;
        private RoundButton num2;
        private RoundButton num3;
        private RoundButton num4;
        private RoundButton num5;
        private RoundButton num6;
        private RoundButton num7;
        private RoundButton num8;
        private RoundButton num9;
        private RoundButton num0;
        private RoundButton virgula;
        private RoundButton negativar;
        private RoundButton mais;
        private RoundButton menos;
        private RoundButton vezes;
        private RoundButton divisao;
        private RoundButton igual;
        private RoundButton clear;
        private RoundButton porcentagem;
        private Label classe;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel sidebar2;
        private System.Windows.Forms.Timer sidebarTransition2;
        private RoundButton delet1;
        private RoundButton hamburguer;
        private Label label1;
        private Label historicoTemp;
        private Panel panel1;
        private Button impostoRendaButton;
        private Panel panel2;
        private Button padraoButton;
        private FlowLayoutPanel sidebar;
    }


    public class RoundButton : Button
    {
        // Propriedade para definir o raio dos cantos arredondados
        public int BorderRadius { get; set; } = 10;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Cores para o botão (fundo, borda e texto)
            Color bgColor = Color.Transparent;
            
           
            // Configurações de alinhamento para o texto
            StringFormat format = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };

            // Retângulo do botão
            RectangleF rect = new RectangleF(0, 0, ClientRectangle.Width, ClientRectangle.Height);

            // Preenche o fundo do botão
            e.Graphics.FillRectangle(new SolidBrush(bgColor), ClientRectangle);

            // Desenha o texto no botão
            
            // Cria um GraphicsPath com os cantos arredondados
            GraphicsPath path = TransformBorderRadius(ClientRectangle, BorderRadius);

            // Define o GraphicsPath como a região do botão
            Region = new Region(path);
        }

        // Método para criar um GraphicsPath com cantos arredondados
        private GraphicsPath TransformBorderRadius(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.X, rect.Y, diameter, diameter);

            // Top-left corner
            path.AddArc(arc, 180, 90);

            // Top-right corner
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom-right corner
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom-left corner
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }
    }

}