﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeApplicantShop
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct AddProduct = new AddProduct();
            AddProduct.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMenu viewMenu = new ViewMenu();
            viewMenu.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
