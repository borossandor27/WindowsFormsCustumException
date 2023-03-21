using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsCustumException
{
    public partial class Form1 : Form
    {
        List<Athaladas> athaladasok = new List<Athaladas>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            athaladasok.Clear();
            try
            {
                athaladasok.Add(new Athaladas(9, 2, 3, "be"));
                athaladasok.Add(new Athaladas(3, 2, 3, "be"));
                athaladasok.Add(new Athaladas(9, 2, 3, "be"));
                athaladasok.Add(new Athaladas(9, 2, 3, "be"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            label_beolvasott_sorok.Text = "beolvasott sorok száma: " + athaladasok.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                 a = int.Parse(textBox_a.Text);
                 b = int.Parse(textBox_b.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nem egész számokat adott meg!");
                return;
            }

            switch (comboBox_muvelet.Text)
            {
                case "+":
                    textBox_eredmeny.Text = (a + b).ToString();
                    break;
                case "-":
                    textBox_eredmeny.Text = (a - b).ToString();
                    break;
                case "*":
                    textBox_eredmeny.Text = (a * b).ToString();
                    break;
                case "/":
                    try
                    {
                        textBox_eredmeny.Text = ((a * 1.0) / b).ToString();

                    }
                    catch (DivideByZeroException)
                    {

                        MessageBox.Show("Nullával nem lehet osztani");
                    }
                    break;
                default:
                    textBox_eredmeny.Text = String.Empty;
                    break;
            }
        }
    }
}
