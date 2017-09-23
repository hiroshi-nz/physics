using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Class;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Example example;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double magnitude = 0;
            double angle = 0;
            if(Double.TryParse(textBox1.Text, out magnitude) && Double.TryParse(textBox2.Text, out angle))
            {
                Vector vector = new Vector(magnitude, angle);

                double x = MathHelper.RoundXth(vector.xy.x, 100);
                double y = MathHelper.RoundXth(vector.xy.y, 100);

                textBox3.Text = x.ToString();
                textBox4.Text = y.ToString();
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            if (Double.TryParse(textBox3.Text, out x) && Double.TryParse(textBox4.Text, out y))
            {
                XY xy = new XY(x, y);
                Vector vector = new Vector(xy);
                double magnitude = MathHelper.RoundXth(vector.magnitude, 100);
                double angle = MathHelper.RoundXth(vector.angle, 100);

                textBox1.Text = magnitude.ToString();
                textBox2.Text = angle.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            msg.Text = example.Tick();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            example = new Example();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            msg.Text += example.Tick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Line line = new Line(new Class.XY(0, 6), new Class.XY(1, 6));
            msg.Text = Check.CheckLine(line);
            
        }
    }
}
