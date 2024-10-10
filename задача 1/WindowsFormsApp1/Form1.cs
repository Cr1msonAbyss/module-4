using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RectArPerCalculate_Click(object sender, EventArgs e)
        {
            int Ra = int.Parse(RectSide1input.Text);
            int Rb = int.Parse(RectSide2input.Text);
            Rectangle rect = new Rectangle(Ra, Rb);
            double Rarea = rect.Area();
            double Rperim = rect.Perim();
            MessageBox.Show($"Площадь прямоугольника =  {Rarea} ; Периметр = {Rperim}" );

        }

        private void TrianArPerCalculate_Click(object sender, EventArgs e)
        {
            int Tra = int.Parse(TriangleSide1input.Text);
            int Trb = int.Parse(TriangleSide2input.Text);
            int Trc = int.Parse(TriangleSide3input.Text);
            Triangle tr = new Triangle(Tra, Trb, Trc);
            double Trarea = tr.Area();
            double Trperim = tr.Perim();
            MessageBox.Show($"Площадь треугольника =  {Trarea} ; Периметр = {Trperim}");
        }

        private void CircleArPerCalculate_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(CircleRadiusInput.Text);
            Circle tr = new Circle(radius);
            double Crarea = tr.Area();
            double Crperim = tr.Perim();
            MessageBox.Show($"Площадь окружности =  {Crarea} ; Периметр = {Crperim}");
        }
    }
}
