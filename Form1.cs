using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldNhor02sept2019
{
    public partial class Form1 : Form
    {
        int numberOneNhor = 0;
        int numberTwoNhor = 0;
        int answerNhor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHelloWorldNhor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void BtnMultiplyNhor_Click(object sender, EventArgs e)
        {
            numberOneNhor = Convert.ToInt32(txbNumberOneNhor.Text);
            numberTwoNhor = Convert.ToInt32(txbNumberTwoNhor.Text);

            answerNhor = numberOneNhor * numberTwoNhor;
            lblAnswerNhor.Text = Convert.ToString(answerNhor);

        }

        private void BtnPlusNhor_Click(object sender, EventArgs e)
        {
            numberOneNhor = Convert.ToInt32(txbNumberOneNhor.Text);
            numberTwoNhor = Convert.ToInt32(txbNumberTwoNhor.Text);

            answerNhor = numberOneNhor + numberTwoNhor;
            lblAnswerNhor.Text = Convert.ToString(answerNhor);

        }
    }
}
