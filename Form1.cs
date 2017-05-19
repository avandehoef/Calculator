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
        bool opCommandoGeclicked;

        public Calculator()
        {
            InitializeComponent();
        }              

        private void btn_click(object sender, EventArgs e)
        {
            if
                ((textUitvoer.Text == "0") || (opCommandoGeclicked))
                textUitvoer.Clear();

            opCommandoGeclicked = false;
            Button button = (Button)sender;
            textUitvoer.Text = textUitvoer.Text + button.Text;
        }

        private void clear_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textUitvoer.Text = "0";
            textUitvoerPrime.Text = "";
            textUitvoerFibonacci.Text = "";
            textUitvoerHuidigeBerekening.Text = "";
            resultaat = 0;                
        }

        private void btn_commando(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            /**
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            textUitvoerHuidigeBerekening.Text = resultaat + " " + uitvoeren;
            commandoUitgevoerd = true;
            */            
            if (resultaat != 0)
            {
                btnIsAntwoord.PerformClick();
                uitvoeren = button.Text;
                resultaat = Double.Parse(textUitvoer.Text);
                textUitvoerHuidigeBerekening.Text = resultaat + " " + uitvoeren;
                opCommandoGeclicked = true;
            }
            else
            {               
                uitvoeren = button.Text;
                resultaat = Double.Parse(textUitvoer.Text);
                textUitvoerHuidigeBerekening.Text = resultaat + " " + uitvoeren;
                opCommandoGeclicked = true;                
            }
            
        }

        private void btnPlusMin_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            textUitvoerHuidigeBerekening.Text = resultaat + " " + uitvoeren;
            textUitvoer.Text = Convert.ToString(resultaat * (0 - 1));
        }

        private void btnIsAntwoord_Click(object sender, EventArgs e)
        {
            switch (uitvoeren)
            {
                case "+":
                    textUitvoer.Text = (resultaat + Double.Parse(textUitvoer.Text)).ToString();
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

                default:
                    break;
            }
            resultaat = Double.Parse(textUitvoer.Text);
            uitvoeren = "";
        }

        private void btn_commandoKwadraat(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            textUitvoerHuidigeBerekening.Text = resultaat + " " + uitvoeren;
            textUitvoer.Text = Convert.ToString(resultaat * resultaat);            
        }

        private void btn_click_komma(object sender, EventArgs e)
        {
            if 
            ((textUitvoer.Text == "0") || (opCommandoGeclicked))
                textUitvoer.Clear();

            opCommandoGeclicked = false;
            Button button = (Button)sender;
            if (textUitvoer.Text.Contains(","))
            { }
            else
            {
                textUitvoer.Text = textUitvoer.Text + ",";
            }
        }

        private void btn_commandoDerdeMacht(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            textUitvoerHuidigeBerekening.Text = resultaat + " " + uitvoeren;
            textUitvoer.Text = Convert.ToString(resultaat * resultaat * resultaat);                
        }

        private void btn_commandoWortel(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            textUitvoerHuidigeBerekening.Text = resultaat + " " + uitvoeren;
            textUitvoer.Text = Convert.ToString(Math.Sqrt(resultaat));            
        }
            
        private void btn_commando_een_gedeeld_door_x(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            textUitvoerHuidigeBerekening.Text = resultaat + " " + uitvoeren;
            textUitvoer.Text = Convert.ToString(1 / resultaat);
        }

        double resultaatMemory = 0;
        double resultaatm = 0;

        private void btn_commando_memory(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            opCommandoGeclicked = true;
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
                    resultaatMemory = Double.Parse(textUitvoer.Text);
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

                default:
                    break;
            }

        }

        private void btn_click_pi(object sender, EventArgs e)
        {
            if
            ((textUitvoer.Text == "0") || (opCommandoGeclicked))
                textUitvoer.Clear();

            opCommandoGeclicked = false;

            Button button = (Button)sender;
            if (textUitvoer.Text.Contains(Convert.ToString(Math.PI)))
            { }
            else
            {
                textUitvoer.Text = textUitvoer.Text + Convert.ToString(Math.PI);
            }
        }

        private void btnEuroClick(object sender, EventArgs e)
        {
            decimal resultaatEuro;

            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaatEuro = Decimal.Parse(textUitvoer.Text);
            opCommandoGeclicked = true;
            textUitvoer.Text = String.Format("{0:C}", resultaatEuro);
        }

        private void btn_commando_test_for_prime(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            
            switch (uitvoeren)
            {
                case "Prime Number":
                    
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

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIsAntwoord.PerformClick();                
            }

            switch (e.KeyChar.ToString())
            {
                case "1":
                    btnEen.TabIndex = 1;
                    btnEen.TabStop = false;
                    btnEen.PerformClick();
                    break;

                case "2":
                    btnTwee.TabIndex = 2;
                    btnTwee.TabStop = false;
                    btnTwee.PerformClick();
                    break;

                case "3":
                    btnDrie.TabIndex = 3;
                    btnDrie.TabStop = false;
                    btnDrie.PerformClick();
                    break;

                case "4":
                    btnVier.TabIndex = 4;
                    btnVier.TabStop = false;
                    btnVier.PerformClick();
                    break;

                case "5":
                    btnVijf.TabIndex = 5;
                    btnVijf.TabStop = false;
                    btnVijf.PerformClick();
                    break;

                case "6":
                    btnZes.TabIndex = 6;
                    btnZes.TabStop = false;
                    btnZes.PerformClick();
                    break;

                case "7":
                    btnZeven.TabIndex = 7;
                    btnZeven.TabStop = false;
                    btnZeven.PerformClick();
                    break;

                case "8":
                    btnAcht.TabIndex = 8;
                    btnAcht.TabStop = false;
                    btnAcht.PerformClick();
                    break;

                case "9":
                    btnNegen.TabIndex = 9;
                    btnNegen.TabStop = false;
                    btnNegen.PerformClick();
                    break;

                case "0":
                    btnNul.TabIndex = 10;
                    btnNul.TabStop = false;
                    btnNul.PerformClick();
                    break;

                case "+":
                    btnPlus.TabIndex = 11;
                    btnPlus.TabStop = false;
                    btnPlus.PerformClick();
                    break;
                
                case "-":
                    btnMin.TabIndex = 12;
                    btnMin.TabStop = false;
                    btnMin.PerformClick();
                    break;

                case "*":
                    btnKeer.TabIndex = 13;
                    btnKeer.TabStop = false;
                    btnKeer.PerformClick();
                    break;

                case "/":
                    btnGedeeldDoor.TabIndex = 14;
                    btnGedeeldDoor.TabStop = false;
                    btnGedeeldDoor.PerformClick();
                    break;

                case ".":
                    btnKomma.TabIndex = 15;
                    btnKomma.TabStop = false;
                    btnKomma.PerformClick();
                    break;

                case ",":
                    btnKomma.TabStop = false;
                    btnKomma.PerformClick();
                    break;

                case "=":
                    btnIsAntwoord.PerformClick();
                    break;
                    
                default:
                    break;
            }
        }
    }
}
