﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using operaciones;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Nacho_Opera
{
    public partial class FormMenu : Form
    {
        /*--------------------------------------Variables---------------------------------------------------------------------------*/

        int equals = 0, CE = 0, Count = 0;
        double fact1 = 0, fact2 = 0, result;
        string operation = null;

        /*--------------------------------------Funtions----------------------------------------------------------------------------*/

        public void Fill(double Num)
        {
            if(Count != 16)
            {
                Count += 1;
                if (equals == 1)
                {
                    txtFactHistory.Clear();
                    txtFactWrite.Clear();
                    fact1 = 0;
                    fact2 = 0;
                    equals = 0;
                    txtFactWrite.Text += Num;
                }
                else
                {
                    txtFactWrite.Text += Num;
                    equals = 0;
                }
            }
        }
        public void Operation(string tipe)
        {
            Count = 0;
            if (txtFactWrite.Text != "")
            {
                fact1 = Convert.ToDouble(txtFactWrite.Text);
                txtFactHistory.Text = txtFactWrite.Text + " " + tipe;
                txtFactWrite.Clear();
                operation = tipe;
            }
        }

        /*--------------------------------------------------------------------------------------------------------------------------*/
        public FormMenu()
        {
            InitializeComponent();
        }

        /*----------------------------Numbers-------------------------------------------------------------------------------------*/
        
        private void cmd0_Click(object sender, EventArgs e)
        {
            Fill(0);
        }

        private void cdm1_Click(object sender, EventArgs e)
        {
           Fill(1);
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            Fill(2);
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            Fill(3);
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            Fill(4);
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            Fill(5);
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            Fill(6);
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            Fill(7);
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            Fill(8);
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            Fill(9);
        }
        private void cmdPoint_Click(object sender, EventArgs e)
        {
            txtFactWrite.Text += ",";
        }
        /*---------------------------------Operations------------------------------------------------------------------------------*/

        private void cmdEquals_Click(object sender, EventArgs e)
        {
            if (equals == 0 && txtFactWrite.Text != "")
            {
                fact2 = Convert.ToDouble(txtFactWrite.Text);
                txtFactHistory.Text += " " + txtFactWrite.Text;

                switch (operation)
                {
                    case "+":
                        result = operacion.Sumar(fact1, fact2);
                        txtFactWrite.Text = "= " + Convert.ToString(result);
                        break;
                    case "-":
                        result = operacion.Restar(fact1, fact2);
                        txtFactWrite.Text = "= " + Convert.ToString(result);
                        break;
                    case "x":
                        if (CE != 1)
                        {
                            result = operacion.Multiplicar(fact1, fact2);
                            txtFactWrite.Text = "= " + Convert.ToString(result);
                        }
                        else
                        {
                            result = fact2;
                            txtFactWrite.Text = "= " + Convert.ToString(result);
                        }
                        
                        break;
                    case "/":
                        if (fact2 == 0)
                        {
                            txtFactWrite.Text = "Sintax Error";
                            txtFactHistory.Clear();
                        }
                        else
                        {
                            result = operacion.Dividir(fact1, fact2);
                            txtFactWrite.Text = "= " + Convert.ToString(result);
                        }
                        break;
                }
                equals = 1;
            }
        }

        private void CmdPlus_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void cmdMinus_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void cmdTimes_Click(object sender, EventArgs e)
        {
            Operation("x");
        }

        private void cmdDivided_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void cmdCE_Click(object sender, EventArgs e)
        {
            if (equals == 0)
            {
                txtFactWrite.Clear();
                fact2 = 0;
                CE = 1;
                Count = 0;
            }
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            if (txtFactWrite.Text.Length > 1)
            {
                if (equals == 0)
                {
                    txtFactWrite.Text = txtFactWrite.Text.Substring(0, txtFactWrite.Text.Length - 1);
                    Count -= 1;
                }
            }
            else
            {
                txtFactWrite.Clear();
            }
        }

        private void cmdInvert_Click(object sender, EventArgs e)
        {
            if (equals != 0)
            {
                result = result * (-1);
                txtFactWrite.Text = "= " + Convert.ToString(result);
            }            
        }

        private void cmdC_Click(object sender, EventArgs e)
        {
            txtFactHistory.Clear();
            txtFactWrite.Clear();
            fact1 = 0;
            fact2 = 0;
            result = 0;
            operation = null;
            equals = 0;
            Count = 0;
        }
    }
}
