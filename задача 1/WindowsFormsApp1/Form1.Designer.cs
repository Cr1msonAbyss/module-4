namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RectSide1input = new System.Windows.Forms.TextBox();
            this.RectSide2input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RectArPerCalculate = new System.Windows.Forms.Button();
            this.TrianArPerCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TriangleSide2input = new System.Windows.Forms.TextBox();
            this.TriangleSide1input = new System.Windows.Forms.TextBox();
            this.TriangleSide3input = new System.Windows.Forms.TextBox();
            this.CircleRadiusInput = new System.Windows.Forms.TextBox();
            this.CircleArPerCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RectSide1input
            // 
            this.RectSide1input.Location = new System.Drawing.Point(333, 80);
            this.RectSide1input.Name = "RectSide1input";
            this.RectSide1input.Size = new System.Drawing.Size(100, 20);
            this.RectSide1input.TabIndex = 0;
            // 
            // RectSide2input
            // 
            this.RectSide2input.Location = new System.Drawing.Point(333, 122);
            this.RectSide2input.Name = "RectSide2input";
            this.RectSide2input.Size = new System.Drawing.Size(100, 20);
            this.RectSide2input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите стороны прямоугольника";
            // 
            // RectArPerCalculate
            // 
            this.RectArPerCalculate.Location = new System.Drawing.Point(346, 162);
            this.RectArPerCalculate.Name = "RectArPerCalculate";
            this.RectArPerCalculate.Size = new System.Drawing.Size(75, 23);
            this.RectArPerCalculate.TabIndex = 3;
            this.RectArPerCalculate.Text = "расчёт";
            this.RectArPerCalculate.UseVisualStyleBackColor = true;
            this.RectArPerCalculate.Click += new System.EventHandler(this.RectArPerCalculate_Click);
            // 
            // TrianArPerCalculate
            // 
            this.TrianArPerCalculate.Location = new System.Drawing.Point(83, 204);
            this.TrianArPerCalculate.Name = "TrianArPerCalculate";
            this.TrianArPerCalculate.Size = new System.Drawing.Size(75, 23);
            this.TrianArPerCalculate.TabIndex = 7;
            this.TrianArPerCalculate.Text = "расчёт";
            this.TrianArPerCalculate.UseVisualStyleBackColor = true;
            this.TrianArPerCalculate.Click += new System.EventHandler(this.TrianArPerCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите стороны треугольника\r\n";
            // 
            // TriangleSide2input
            // 
            this.TriangleSide2input.Location = new System.Drawing.Point(70, 122);
            this.TriangleSide2input.Name = "TriangleSide2input";
            this.TriangleSide2input.Size = new System.Drawing.Size(100, 20);
            this.TriangleSide2input.TabIndex = 5;
            // 
            // TriangleSide1input
            // 
            this.TriangleSide1input.Location = new System.Drawing.Point(70, 80);
            this.TriangleSide1input.Name = "TriangleSide1input";
            this.TriangleSide1input.Size = new System.Drawing.Size(100, 20);
            this.TriangleSide1input.TabIndex = 4;
            // 
            // TriangleSide3input
            // 
            this.TriangleSide3input.Location = new System.Drawing.Point(70, 162);
            this.TriangleSide3input.Name = "TriangleSide3input";
            this.TriangleSide3input.Size = new System.Drawing.Size(100, 20);
            this.TriangleSide3input.TabIndex = 8;
            // 
            // CircleRadiusInput
            // 
            this.CircleRadiusInput.Location = new System.Drawing.Point(527, 80);
            this.CircleRadiusInput.Name = "CircleRadiusInput";
            this.CircleRadiusInput.Size = new System.Drawing.Size(100, 20);
            this.CircleRadiusInput.TabIndex = 9;
            // 
            // CircleArPerCalculate
            // 
            this.CircleArPerCalculate.Location = new System.Drawing.Point(540, 122);
            this.CircleArPerCalculate.Name = "CircleArPerCalculate";
            this.CircleArPerCalculate.Size = new System.Drawing.Size(75, 23);
            this.CircleArPerCalculate.TabIndex = 12;
            this.CircleArPerCalculate.Text = "расчёт";
            this.CircleArPerCalculate.UseVisualStyleBackColor = true;
            this.CircleArPerCalculate.Click += new System.EventHandler(this.CircleArPerCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введите радиус круга\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CircleArPerCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CircleRadiusInput);
            this.Controls.Add(this.TriangleSide3input);
            this.Controls.Add(this.TrianArPerCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TriangleSide2input);
            this.Controls.Add(this.TriangleSide1input);
            this.Controls.Add(this.RectArPerCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RectSide2input);
            this.Controls.Add(this.RectSide1input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RectSide1input;
        private System.Windows.Forms.TextBox RectSide2input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RectArPerCalculate;
        private System.Windows.Forms.Button TrianArPerCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TriangleSide2input;
        private System.Windows.Forms.TextBox TriangleSide1input;
        private System.Windows.Forms.TextBox TriangleSide3input;
        private System.Windows.Forms.TextBox CircleRadiusInput;
        private System.Windows.Forms.Button CircleArPerCalculate;
        private System.Windows.Forms.Label label3;
    }
}

