﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCinema
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            picMovOne.Image = Image.FromFile(@"D:\MyCinema\Poster\Jisoo.jpg");
        }

        private void PicMovOne_Click(object sender, EventArgs e)
        {
          
        }
    }
}
