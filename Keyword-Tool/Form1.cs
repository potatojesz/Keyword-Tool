﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Keyword_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxEnter.Text))
            {
                string[] separateWords = textBoxEnter.Text.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);

                List<string> input = new List<string>();
                foreach (string str in separateWords)
                {
                    input.Add(str.Trim());
                }

                textBoxGenerated.Text = Engine.GenerateKeywordsString(input);
            }
            else
            {
                textBoxGenerated.Text = "";
            }
        }
    }
}
