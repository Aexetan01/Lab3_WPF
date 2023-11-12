using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Ivan
{
    public partial class Form1 : Form
    {
        private List<Prism> prisms;
        public Form1()
        {
            InitializeComponent();
            prisms = new List<Prism>();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            prisms.Clear();
            listBox1.Items.Clear();
            Random random = new Random();


            for(int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                if(random.Next(0, 2) == 0)
                {
                    prisms.Add(new TrianglePrism("Трикутна призма", random.Next(1, 100), random.Next(1, 100)));
                }
                else
                {
                    prisms.Add(new QuadrilateralPrism("Чотирикутна призма", random.Next(1, 100), random.Next(1, 100)));
                }

                listBox1.Items.Add(prisms[i].ToString());
            }
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            if(prisms.Count > 0)
            {
                double min = prisms.Select(x => x.GetVolume()).Min();
                MessageBox.Show($"Мінімальний об'єм: {min}.");
            }
            else
            {  
                MessageBox.Show("Помилка!");
            }
        }
    }
}
