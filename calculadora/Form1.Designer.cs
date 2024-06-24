using System.Drawing.Drawing2D;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            resultadoTextBox = new Label();
            num1 = new RoundButton();
            num2 = new RoundButton();
            num3 = new RoundButton();
            num4 = new RoundButton();
            num5 = new RoundButton();
            num6 = new RoundButton();
            num7 = new RoundButton();
            num8 = new RoundButton();
            num9 = new RoundButton();
            num0 = new RoundButton();
            virgula = new RoundButton();
            negativar = new RoundButton();
            mais = new RoundButton();
            menos = new RoundButton();
            vezes = new RoundButton();
            divisao = new RoundButton();
            igual = new RoundButton();
            delet1 = new RoundButton();
            clear = new RoundButton();
            porcentagem = new RoundButton();
            SuspendLayout();
            // 
            // resultadoTextBox
            // 
            resultadoTextBox.BackColor = Color.Transparent;
            resultadoTextBox.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            resultadoTextBox.ForeColor = Color.White;
            resultadoTextBox.Location = new Point(2, 51);
            resultadoTextBox.Name = "resultadoTextBox";
            resultadoTextBox.Size = new Size(304, 127);
            resultadoTextBox.TabIndex = 0;
            resultadoTextBox.TextAlign = ContentAlignment.BottomRight;
            // 
            // num1
            // 
            num1.BackgroundImage = (Image)resources.GetObject("num1.BackgroundImage");
            num1.BorderRadius = 10;
            num1.Cursor = Cursors.Hand;
            num1.FlatAppearance.BorderSize = 0;
            num1.FlatStyle = FlatStyle.Flat;
            num1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            num1.ForeColor = Color.White;
            num1.Location = new Point(9, 377);
            num1.Name = "num1";
            num1.Size = new Size(67, 52);
            num1.TabIndex = 1;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // num2
            // 
            num2.BackgroundImage = (Image)resources.GetObject("num2.BackgroundImage");
            num2.BorderRadius = 10;
            num2.Cursor = Cursors.Hand;
            num2.FlatAppearance.BorderSize = 0;
            num2.FlatStyle = FlatStyle.Flat;
            num2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            num2.ForeColor = Color.White;
            num2.Location = new Point(82, 377);
            num2.Name = "num2";
            num2.Size = new Size(67, 52);
            num2.TabIndex = 2;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // num3
            // 
            num3.BackgroundImage = (Image)resources.GetObject("num3.BackgroundImage");
            num3.BorderRadius = 10;
            num3.Cursor = Cursors.Hand;
            num3.FlatAppearance.BorderSize = 0;
            num3.FlatStyle = FlatStyle.Flat;
            num3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            num3.ForeColor = Color.White;
            num3.Location = new Point(155, 377);
            num3.Name = "num3";
            num3.Size = new Size(67, 52);
            num3.TabIndex = 3;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // num4
            // 
            num4.BackgroundImage = (Image)resources.GetObject("num4.BackgroundImage");
            num4.BorderRadius = 10;
            num4.Cursor = Cursors.Hand;
            num4.FlatAppearance.BorderSize = 0;
            num4.FlatStyle = FlatStyle.Flat;
            num4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            num4.ForeColor = Color.White;
            num4.Location = new Point(9, 319);
            num4.Name = "num4";
            num4.Size = new Size(67, 52);
            num4.TabIndex = 4;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num4_Click;
            // 
            // num5
            // 
            num5.BackgroundImage = (Image)resources.GetObject("num5.BackgroundImage");
            num5.BorderRadius = 10;
            num5.Cursor = Cursors.Hand;
            num5.FlatAppearance.BorderSize = 0;
            num5.FlatStyle = FlatStyle.Flat;
            num5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            num5.ForeColor = Color.White;
            num5.Location = new Point(82, 319);
            num5.Name = "num5";
            num5.Size = new Size(67, 52);
            num5.TabIndex = 5;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num5_Click;
            // 
            // num6
            // 
            num6.BackgroundImage = (Image)resources.GetObject("num6.BackgroundImage");
            num6.BorderRadius = 10;
            num6.Cursor = Cursors.Hand;
            num6.FlatAppearance.BorderSize = 0;
            num6.FlatStyle = FlatStyle.Flat;
            num6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            num6.ForeColor = Color.White;
            num6.Location = new Point(155, 319);
            num6.Name = "num6";
            num6.Size = new Size(67, 52);
            num6.TabIndex = 6;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num7
            // 
            num7.BackgroundImage = (Image)resources.GetObject("num7.BackgroundImage");
            num7.BorderRadius = 10;
            num7.Cursor = Cursors.Hand;
            num7.FlatAppearance.BorderSize = 0;
            num7.FlatStyle = FlatStyle.Flat;
            num7.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            num7.ForeColor = Color.White;
            num7.Location = new Point(9, 261);
            num7.Name = "num7";
            num7.Size = new Size(67, 52);
            num7.TabIndex = 7;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num7_Click;
            // 
            // num8
            // 
            num8.BackgroundImage = (Image)resources.GetObject("num8.BackgroundImage");
            num8.BorderRadius = 10;
            num8.Cursor = Cursors.Hand;
            num8.FlatAppearance.BorderSize = 0;
            num8.FlatStyle = FlatStyle.Flat;
            num8.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            num8.ForeColor = Color.White;
            num8.Location = new Point(82, 261);
            num8.Name = "num8";
            num8.Size = new Size(67, 52);
            num8.TabIndex = 8;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num8_Click;
            // 
            // num9
            // 
            num9.BackgroundImage = (Image)resources.GetObject("num9.BackgroundImage");
            num9.BorderRadius = 10;
            num9.Cursor = Cursors.Hand;
            num9.FlatAppearance.BorderSize = 0;
            num9.FlatStyle = FlatStyle.Flat;
            num9.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            num9.ForeColor = Color.White;
            num9.Location = new Point(155, 261);
            num9.Name = "num9";
            num9.Size = new Size(67, 52);
            num9.TabIndex = 9;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // num0
            // 
            num0.BackgroundImage = (Image)resources.GetObject("num0.BackgroundImage");
            num0.BorderRadius = 10;
            num0.Cursor = Cursors.Hand;
            num0.FlatAppearance.BorderSize = 0;
            num0.FlatStyle = FlatStyle.Flat;
            num0.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            num0.ForeColor = Color.White;
            num0.Location = new Point(82, 435);
            num0.Name = "num0";
            num0.Size = new Size(67, 52);
            num0.TabIndex = 10;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += num0_Click;
            // 
            // virgula
            // 
            virgula.BackgroundImage = (Image)resources.GetObject("virgula.BackgroundImage");
            virgula.BorderRadius = 10;
            virgula.Cursor = Cursors.Hand;
            virgula.FlatAppearance.BorderSize = 0;
            virgula.FlatStyle = FlatStyle.Flat;
            virgula.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            virgula.ForeColor = Color.White;
            virgula.Location = new Point(155, 435);
            virgula.Name = "virgula";
            virgula.Size = new Size(67, 52);
            virgula.TabIndex = 11;
            virgula.Text = ",";
            virgula.UseVisualStyleBackColor = true;
            virgula.Click += virgula_Click;
            // 
            // negativar
            // 
            negativar.BackgroundImage = (Image)resources.GetObject("negativar.BackgroundImage");
            negativar.BorderRadius = 10;
            negativar.Cursor = Cursors.Hand;
            negativar.FlatAppearance.BorderSize = 0;
            negativar.FlatStyle = FlatStyle.Flat;
            negativar.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            negativar.ForeColor = Color.White;
            negativar.Location = new Point(9, 435);
            negativar.Name = "negativar";
            negativar.Size = new Size(67, 52);
            negativar.TabIndex = 12;
            negativar.Text = "+/-";
            negativar.UseVisualStyleBackColor = true;
            negativar.Click += negativar_Click;
            // 
            // mais
            // 
            mais.BackgroundImage = (Image)resources.GetObject("mais.BackgroundImage");
            mais.BorderRadius = 10;
            mais.Cursor = Cursors.Hand;
            mais.FlatAppearance.BorderSize = 0;
            mais.FlatStyle = FlatStyle.Flat;
            mais.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            mais.ForeColor = Color.White;
            mais.Location = new Point(228, 377);
            mais.Name = "mais";
            mais.Size = new Size(67, 52);
            mais.TabIndex = 13;
            mais.Text = "+";
            mais.UseVisualStyleBackColor = true;
            mais.Click += mais_Click;
            // 
            // menos
            // 
            menos.BackgroundImage = (Image)resources.GetObject("menos.BackgroundImage");
            menos.BorderRadius = 10;
            menos.Cursor = Cursors.Hand;
            menos.FlatAppearance.BorderSize = 0;
            menos.FlatStyle = FlatStyle.Flat;
            menos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            menos.ForeColor = Color.White;
            menos.Location = new Point(228, 319);
            menos.Name = "menos";
            menos.Size = new Size(67, 52);
            menos.TabIndex = 14;
            menos.Text = "-";
            menos.UseVisualStyleBackColor = true;
            menos.Click += menos_Click;
            // 
            // vezes
            // 
            vezes.BackgroundImage = (Image)resources.GetObject("vezes.BackgroundImage");
            vezes.BorderRadius = 10;
            vezes.Cursor = Cursors.Hand;
            vezes.FlatAppearance.BorderSize = 0;
            vezes.FlatStyle = FlatStyle.Flat;
            vezes.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            vezes.ForeColor = Color.White;
            vezes.Location = new Point(228, 261);
            vezes.Name = "vezes";
            vezes.Size = new Size(67, 52);
            vezes.TabIndex = 15;
            vezes.Text = "X";
            vezes.UseVisualStyleBackColor = true;
            vezes.Click += vezes_Click;
            // 
            // divisao
            // 
            divisao.BackgroundImage = (Image)resources.GetObject("divisao.BackgroundImage");
            divisao.BorderRadius = 10;
            divisao.Cursor = Cursors.Hand;
            divisao.FlatAppearance.BorderSize = 0;
            divisao.FlatStyle = FlatStyle.Flat;
            divisao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            divisao.ForeColor = Color.White;
            divisao.Location = new Point(228, 203);
            divisao.Name = "divisao";
            divisao.Size = new Size(67, 52);
            divisao.TabIndex = 16;
            divisao.Text = "÷";
            divisao.UseVisualStyleBackColor = true;
            divisao.Click += divisao_Click;
            // 
            // igual
            // 
            igual.BackColor = Color.CornflowerBlue;
            igual.BackgroundImage = (Image)resources.GetObject("igual.BackgroundImage");
            igual.BorderRadius = 10;
            igual.Cursor = Cursors.Hand;
            igual.FlatAppearance.BorderSize = 0;
            igual.FlatStyle = FlatStyle.Flat;
            igual.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            igual.ForeColor = Color.Black;
            igual.Location = new Point(228, 435);
            igual.Name = "igual";
            igual.Size = new Size(67, 52);
            igual.TabIndex = 17;
            igual.Text = "=";
            igual.UseVisualStyleBackColor = false;
            igual.Click += igual_Click;
            // 
            // delet1
            // 
            delet1.BackgroundImage = (Image)resources.GetObject("delet1.BackgroundImage");
            delet1.BackgroundImageLayout = ImageLayout.Zoom;
            delet1.BorderRadius = 10;
            delet1.Cursor = Cursors.Hand;
            delet1.FlatAppearance.BorderSize = 0;
            delet1.FlatStyle = FlatStyle.Flat;
            delet1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            delet1.ForeColor = Color.White;
            delet1.Location = new Point(155, 203);
            delet1.Name = "delet1";
            delet1.Size = new Size(67, 52);
            delet1.TabIndex = 18;
            delet1.UseVisualStyleBackColor = true;
            delet1.Click += delet1_Click;
            // 
            // clear
            // 
            clear.BackgroundImage = (Image)resources.GetObject("clear.BackgroundImage");
            clear.BorderRadius = 10;
            clear.Cursor = Cursors.Hand;
            clear.FlatAppearance.BorderSize = 0;
            clear.FlatStyle = FlatStyle.Flat;
            clear.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            clear.ForeColor = Color.White;
            clear.Location = new Point(82, 203);
            clear.Name = "clear";
            clear.Size = new Size(67, 52);
            clear.TabIndex = 19;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // porcentagem
            // 
            porcentagem.BackgroundImage = (Image)resources.GetObject("porcentagem.BackgroundImage");
            porcentagem.BorderRadius = 10;
            porcentagem.Cursor = Cursors.Hand;
            porcentagem.FlatAppearance.BorderSize = 0;
            porcentagem.FlatStyle = FlatStyle.Flat;
            porcentagem.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            porcentagem.ForeColor = Color.White;
            porcentagem.Location = new Point(9, 203);
            porcentagem.Name = "porcentagem";
            porcentagem.Size = new Size(67, 52);
            porcentagem.TabIndex = 20;
            porcentagem.Text = "%";
            porcentagem.UseVisualStyleBackColor = true;
            porcentagem.Click += porcentagem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(307, 493);
            Controls.Add(porcentagem);
            Controls.Add(clear);
            Controls.Add(delet1);
            Controls.Add(igual);
            Controls.Add(divisao);
            Controls.Add(vezes);
            Controls.Add(menos);
            Controls.Add(mais);
            Controls.Add(negativar);
            Controls.Add(virgula);
            Controls.Add(num0);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(resultadoTextBox);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
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
        private RoundButton delet1;
        private RoundButton clear;
        private RoundButton porcentagem;
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
            Color borderColor = Color.Black;
           
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

            // Desenha a borda do botão
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, borderColor, ButtonBorderStyle.Solid);

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