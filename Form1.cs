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

        private void btnPlusMin_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;

            switch (uitvoeren)
            {

                case "+ / -":
                    textUitvoer.Text = Convert.ToString(resultaat * (0-1));
                    break;

            }
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
            resultaat = 0;
                
        }

        private void btn_commando(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;
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

            switch (uitvoeren)
            {

                case "x²":
                    textUitvoer.Text = Convert.ToString(resultaat*resultaat);
                    break;

            }

        }

        private void btn_click_komma(object sender, EventArgs e)
        {
            if 
            ((textUitvoer.Text == "0") || (commandoUitgevoerd))
                textUitvoer.Clear();

            commandoUitgevoerd = false;
            Button button = (Button)sender;
            textUitvoer.Text = textUitvoer.Text + ".";
        }

        private void btn_commandoDerdeMacht(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;

            switch (uitvoeren)
            {
                case "x³":
                    textUitvoer.Text = Convert.ToString(resultaat * resultaat * resultaat);
                    break;
            }
        }

        private void btn_commandoWortel(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;

            switch (uitvoeren)
            {
                case "√":
                    textUitvoer.Text = Convert.ToString(Math.Sqrt(resultaat));
                    break;
            }

        }

        private void btn_commando_pi(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;

            switch (uitvoeren)
            {
                case "π":
                    textUitvoer.Text = Convert.ToString(Math.PI);
                    break;
            }


        }

        private void btn_commando_een_gedeeld_door_x(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            uitvoeren = button.Text;
            resultaat = Double.Parse(textUitvoer.Text);
            commandoUitgevoerd = true;

            switch (uitvoeren)
            {
                case "1 / x":
                    textUitvoer.Text = Convert.ToString(1 / resultaat);
                    break;
            }
        }
    }
}
