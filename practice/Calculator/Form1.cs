﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        enum OperType
        {
            NONE, ADD, SUB, MUL, DIV, RES
        }

        private bool isOper = false;
        private OperType opertype = OperType.NONE;
        private OperType lastOpertype = OperType.NONE;
        private float result = 0;
        private string resultString = "";
        private float left = 0;
        private float right = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void OperationFunction(string s, OperType type)
        {
            switch(type)
            {
                case OperType.NONE:
                    {
                        if (lastOpertype != OperType.NONE)
                            resultString = "";
                        if (!(resultString == "" && s == "0"))
                            resultString += s;
                        tbResult.Text = resultString;
                    }
                    break;

                case OperType.ADD:
                case OperType.SUB:
                case OperType.MUL:
                case OperType.DIV:
                    Calc(Convert.ToSingle(tbResult.Text), type);
                    break;
                case OperType.RES:
                    Calc(Convert.ToSingle(tbResult.Text), type);
                    tbResult.Text = result.ToString();
                    isOper = false;
                    lastOpertype = OperType.NONE;
                    opertype = OperType.NONE;
                    resultString = "";
                    break;
            }
            lastOpertype = type;
        }

        private void Calc(float val, OperType type)
        {
            if (isOper == false)
            {
                isOper = true;
                result = val;
            }
            else
            {
                switch (opertype)
                {
                    case OperType.ADD:
                        result += val;
                        break;
                    case OperType.SUB:
                        result -= val;
                        break;
                    case OperType.MUL:
                        result *= val;
                        break;
                    case OperType.DIV:
                        result /= val;
                        break;
                    default:
                        return;
                }
            }
            tbResult.Text = result.ToString();
            opertype = type;
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            OperationFunction(btn.Text, OperType.NONE);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OperationFunction("+", OperType.ADD);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            OperationFunction("-", OperType.SUB);
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            OperationFunction("*", OperType.MUL);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            OperationFunction("/", OperType.DIV);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            OperationFunction("=", OperType.RES);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }
    }
}
