using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // var keyword: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var


            //var numOne = int.Parse(num1Text.Text);
            //var numTwo = int.Parse(num2Text.Text);
            //var numThree = int.Parse(num3Text.Text);

            

            var numOne = int.Parse(num1Text.Text);
            var numTwo = int.Parse(num2Text.Text);
            var numThree = int.Parse(num3Text.Text);

            var outputMethodRunner = MethodRunner.RunAllMethods(numOne, numTwo, numThree);
            var outputLambdaRunner = LambdaRunner.RunAllMethods(numOne, numTwo, numThree);
            
            methodOutput.Text = outputMethodRunner;
            lambdaOutput.Text = outputLambdaRunner;

            // ... Compare both outputs and check if they are the same
            // When they are equal, show a messagebox:


            string[] dit = outputLambdaRunner.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            string[] dit2 = outputMethodRunner.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            var correct = true;
            for (int i = 0; i < dit.Length; i+=1)
            {
                var isIndex = dit[i].LastIndexOf('=');
                var isIndex2 = dit2[i].LastIndexOf('=');
                var ans1 = dit[i].Substring(isIndex +1).Trim();
                var ans2 = dit2[i].Substring(isIndex2 +1).Trim();
                
                if (!ans1.Equals(ans2))
                {
                    correct = false;
                    MessageBox.Show(i.ToString());
                    MessageBox.Show(ans1 + ans2);
                }
            }

            if (correct)
            {
                MessageBox.Show("Het is: Goed");
            }
            else
            {
                MessageBox.Show("Het is: Fout");
            }




        }

        private void num1Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number1 = rand.Next(0, 10);
            int number2 = rand.Next(0, 10);
            int number3 = rand.Next(0, 10);

            num1Text.Text = number1.ToString();
            num2Text.Text = number2.ToString();
            num3Text.Text = number3.ToString();
        }
    }
}
