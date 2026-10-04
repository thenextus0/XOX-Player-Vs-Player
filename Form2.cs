using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static public string player1;
        static public string player2;

        static public string butona;
        static public int turn = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            Player1Name.Text = player1;
            Player2Name.Text = player2;
        }

        private void yenioyunbutton_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button1.Enabled = true;

            button2.Text = "";
            button2.Enabled = true;

            button3.Text = "";
            button3.Enabled = true;

            button4.Text = "";
            button4.Enabled = true;

            button5.Text = "";
            button5.Enabled = true;

            button6.Text = "";
            button6.Enabled = true;

            button7.Text = "";
            button7.Enabled = true;

            button8.Text = "";
            button8.Enabled = true;

            button9.Text = "";
            button9.Enabled = true;

            turn = 0;
            yenioyunbutton.Visible = false;
        }

        private void xoxkontrol()
        {
            if (turn % 2 == 0)
            {
                if (butona == "button1") button1.Text = "X";
                else if (butona == "button2") button2.Text = "X";
                else if (butona == "button3") button3.Text = "X";
                else if (butona == "button4") button4.Text = "X";
                else if (butona == "button5") button5.Text = "X";
                else if (butona == "button6") button6.Text = "X";
                else if (butona == "button7") button7.Text = "X";
                else if (butona == "button8") button8.Text = "X";
                else if (butona == "button9") button9.Text = "X";
            }
            else
            {
                if (butona == "button1") button1.Text = "O";
                else if (butona == "button2") button2.Text = "O";
                else if (butona == "button3") button3.Text = "O";
                else if (butona == "button4") button4.Text = "O";
                else if (butona == "button5") button5.Text = "O";
                else if (butona == "button6") button6.Text = "O";
                else if (butona == "button7") button7.Text = "O";
                else if (butona == "button8") button8.Text = "O";
                else if (butona == "button9") button9.Text = "O";

            }

            turn += 1;

            if (button1.Text == button2.Text && button1.Text == button3.Text)
            {
                if (button1.Text == "X") MessageBox.Show(player1 + " oyunu kazandı.");
                else if (button1.Text == "O") MessageBox.Show(player2 + " oyuncu kazandı.");
                if (button1.Text != "") yenioyunbutton.Visible = true;
            }
            else if (button4.Text == button5.Text && button4.Text == button6.Text)
            {
                if (button4.Text == "X") MessageBox.Show(player1 + " oyunu kazandı.");
                else if (button4.Text == "O") MessageBox.Show(player2 + " oyunu kazandı.");
                if (button4.Text != "") yenioyunbutton.Visible = true;
            }
            else if (button7.Text == button8.Text && button7.Text == button9.Text)
            {
                if (button7.Text == "X") MessageBox.Show(player1 + " oyunu kazandı.");
                else if (button7.Text == "O") MessageBox.Show(player2 + " oyunu kazandı.");
                if (button7.Text != "") yenioyunbutton.Visible = true;
            }

            if (button1.Text == button4.Text && button1.Text == button7.Text)
            {
                if (button1.Text == "X") MessageBox.Show(player1 + " oyunu kazandı.");
                else if (button1.Text == "O") MessageBox.Show(player2 + " oyuncu kazandı.");
                if (button1.Text != "") yenioyunbutton.Visible = true;
            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text)
            {
                if (button2.Text == "X") MessageBox.Show(player1 + " oyunu kazandı.");
                else if (button2.Text == "O") MessageBox.Show(player2 + " oyunu kazandı.");
                if (button2.Text != "") yenioyunbutton.Visible = true;
            }
            else if (button3.Text == button6.Text && button3.Text == button9.Text)
            {
                if (button3.Text == "X") MessageBox.Show(player1 + " oyunu kazandı.");
                else if (button3.Text == "O") MessageBox.Show(player2 + " oyunu kazandı.");
                if (button3.Text != "") yenioyunbutton.Visible = true;
            }

            if (button1.Text == button5.Text && button1.Text == button9.Text)
            {
                if (button1.Text == "X") MessageBox.Show(player1 + " oyunu kazandı.");
                else if (button1.Text == "O") MessageBox.Show(player2 + " oyunu kazandı.");
                if (button1.Text != "") yenioyunbutton.Visible = true;
            }
            else if (button3.Text == button5.Text && button3.Text == button7.Text)
            {
                if (button3.Text == "X") MessageBox.Show(player1 + " oyunu kazandı.");
                else if (button3.Text == "O") MessageBox.Show(player2 + " oyunu kazandı.");
                if (button3.Text != "") yenioyunbutton.Visible = true;
            }
            else if (turn == 9)
            {
                yenioyunbutton.Visible = true;
                MessageBox.Show("Berabere Kalındı.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            butona = button1.Name.ToString();
            Player1Name.Text = butona;
            xoxkontrol();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            butona = button2.Name.ToString();
            xoxkontrol();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            butona = button3.Name.ToString();
            xoxkontrol();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            butona = button4.Name.ToString();
            xoxkontrol();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            butona = button5.Name.ToString();
            xoxkontrol();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            butona = button6.Name.ToString();
            xoxkontrol();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            butona = button7.Name.ToString();
            xoxkontrol();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            butona = button8.Name.ToString();
            xoxkontrol();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            butona = button9.Name.ToString();
            xoxkontrol();
            button9.Enabled = false;
        }

    }
}
