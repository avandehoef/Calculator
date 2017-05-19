using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Calculator : Form
    {

        double resultaat = 0;
        string uitvoeren = "";
        bool commandoUitgevoerd = false;

        public Calculator()
        {
            InitializeComponent();
        }
                
        private void btn_click(object sender, EventArgs e)
        {
            if
                ((textUitvoer.Text == "0") || (commandoUitgevoerd))
                textUitvoer.Clear();

            commandoUitgevoerd = false;
            Button button = (Button)sender;
            textUitvoer.Text = textUitvoer.Text + button.Text;
        }

        private void clear_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textUitvoer.Text = "0";
            textUitvoerPrime.Text = "";
            textUitvoerFibonacci.Text = "";
            resultaat = 0;                
        }

        private void btn_commando(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;
        }

        private void btnPlusMin_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;
            textUitvoer.Text = Convert.ToString(resultaat * (0 - 1));
        }

        private void btnIsAntwoord_Click(object sender, EventArgs e)
        {

            switch (uitvoeren)
            {
                case "+":
                    textUitvoer.Text = (Double.Parse(textUitvoer.Text) + resultaat).ToString();
                    break;

                case "-":
                    textUitvoer.Text = (resultaat - Double.Parse(textUitvoer.Text)).ToString();
                    break;

                case "x":
                    textUitvoer.Text = (resultaat * Double.Parse(textUitvoer.Text)).ToString();
                    break;

                case "÷":
                    textUitvoer.Text = (resultaat / Double.Parse(textUitvoer.Text)).ToString();
                    break;

                case "x²":
                    textUitvoer.Text = (resultaat * Double.Parse(textUitvoer.Text)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void btn_commandoKwadraat(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;
            textUitvoer.Text = Convert.ToString(resultaat * resultaat);            
        }

        private void btn_click_komma(object sender, EventArgs e)
        {
            if 
            ((textUitvoer.Text == "0") || (commandoUitgevoerd))
                textUitvoer.Clear();

            commandoUitgevoerd = false;
            Button button = (Button)sender;
            textUitvoer.Text = textUitvoer.Text + ",";
        }

        private void btn_commandoDerdeMacht(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;
            textUitvoer.Text = Convert.ToString(resultaat * resultaat * resultaat);                
        }

        private void btn_commandoWortel(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;
            textUitvoer.Text = Convert.ToString(Math.Sqrt(resultaat));            
        }
            
        private void btn_commando_een_gedeeld_door_x(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;
            textUitvoer.Text = Convert.ToString(1 / resultaat);
        }

        double resultaatMemory = 0;
        double resultaatm = 0;

        private void btn_commando_memory(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            commandoUitgevoerd = true;
            resultaatMemory = resultaatm;

            switch (uitvoeren)
            {
                case "M Store":
                    resultaatm = Double.Parse(textUitvoer.Text);
                    resultaatMemory = resultaatm;
                    textUitvoer.Text = Convert.ToString(resultaatMemory);
                    textUitvoerMemory.Text = Convert.ToString("M " + resultaatMemory);
                    break;

                case "M Recall":
                    textUitvoer.Text = Convert.ToString(resultaatMemory);
                    break;

                case "M Clear":
                    resultaatMemory = 0;
                    resultaatm = 0;
                    textUitvoerMemory.Text = Convert.ToString("");
                    break;

                case "M -":
                    textUitvoer.Text = (double.Parse(textUitvoer.Text) - (resultaatMemory)).ToString();
                    break;

                case "M +":
                    textUitvoer.Text = (double.Parse(textUitvoer.Text) + (resultaatMemory)).ToString();
                    break;
            }

        }

        private void btn_click_pi(object sender, EventArgs e)
        {
            if
            ((textUitvoer.Text == "0") || (commandoUitgevoerd))
                textUitvoer.Clear();

            commandoUitgevoerd = false;

            Button button = (Button)sender;
            textUitvoer.Text = textUitvoer.Text + Convert.ToString(Math.PI);
        }

        private void btnEuroClick(object sender, EventArgs e)
        {
            decimal resultaatEuro;

            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaatEuro = Decimal.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;
            textUitvoer.Text = String.Format("{0:C}", resultaatEuro);
        }

        private void btn_commando_test_for_prime(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;

            switch (uitvoeren)
            {
                case "Test for Prime Number":
                    
                    double y = resultaat -2;
                    double getal2;

                    if (resultaat == 2)
                    {
                    textUitvoerPrime.Text = Convert.ToString(resultaat + " is a prime number");
                        break;
                    }
                    else
                    {
                        if (resultaat <= 1 || resultaat % 1 != 0)
                        {
                            textUitvoerPrime.Text = Convert.ToString("This is NOT a prime number");
                            break;
                        }
                        else

                        {
                            if (resultaat % 2 == 0)
                            {
                                textUitvoerPrime.Text = Convert.ToString("This is NOT a prime number");
                                break;
                            }
                            else
                            {
                                for (getal2 = resultaat; y > 0; y = y - 2)
                                {
                                    if (getal2 % y != 0 || y == 1)
                                    {
                                        if (y < 2)
                                        {
                                            textUitvoerPrime.Text = Convert.ToString("This IS a prime number");
                                            break;
                                        }
                                        else
                                        {
                                            if (getal2 % y == 0)
                                            {
                                                textUitvoerPrime.Text = Convert.ToString("This is NOT a prime number");
                                                break;
                                            }
                                            else
                                                continue;
                                        }
                                    }
                                    else
                                    {
                                        textUitvoerPrime.Text = Convert.ToString("This is NOT a prime number");
                                        break;
                                    }
                                }
                            }

                        }
                    }
                    break;
            }
        }
        
        private void textUitvoer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUitvoerPrime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUitvoerMemory_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_commando_test_for_fibonacci(object sender, EventArgs e)
        {

        }

        private void textUitvoerFibonacci_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
