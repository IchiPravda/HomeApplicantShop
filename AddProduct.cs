using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeApplicantShop
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            ComboBox.ObjectCollection collection = this.comboBox1.Items;
            collection.Add("Light Bulb");
            collection.Add("Washing Machine");
            collection.Add("Table");

            //set this collection

            this.comboBox1.Text = "Choose Product";
        }

        private void tbBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBrightness_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbWattage_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSmart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filename = "light_bulb.txt";
            // get input value
            string id = tbId.Text;
            string brand = tbBrand.Text;
            string model = tbModel.Text;
            string price = tbPrice.Text;

            String brightness = tbBrightness.Text;
            String wattage = tbWattage.Text;
            Boolean isSmart = cbSmart.Checked;

            // check if the input field is empty
            if (tbBrightness.Text == "")
            {
                MessageBox.Show("brightness Cannot be Empty", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbWattage.Text == "")
            {
                MessageBox.Show("Wattage Cannot be empty", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // create Light Bulb instance
                LightBulb lb = new LightBulb(id, brand, model, price, brightness, wattage, isSmart);

                // store to the file

                if (!File.Exists(filename))
                {
                    FileStream fs = File.Create(filename);
                    fs.Close();
                }

                if (File.Exists(filename))
                {
                    using (StreamWriter sw = File.AppendText(filename))
                    {
                        sw.WriteLine($"{lb.id};{lb.brand};{lb.model};{lb.price};{lb.brightness};{lb.wattage};{lb.isSmart}");
                        MessageBox.Show("New LightBulb Added.");
                    }

                }
                tbId.Clear();
                tbBrand.Clear();
                tbModel.Clear();
                tbPrice.Clear();
                tbBrightness.Clear();
                tbWattage.Clear();
                cbSmart.Checked = false;
                lightbox.Enabled = false;
                washingbox.Enabled = false;
                tablebox.Enabled = false;
                this.comboBox1.Text = "Choose Product";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "washing_machine.txt";
            // get input value
            string id = tbId.Text;
            string brand = tbBrand.Text;
            string model = tbModel.Text;
            string price = tbPrice.Text;

            String color = tbColor.Text;
            String capacity = tbCapacity.Text;
            Boolean isPortable = cbPortable.Checked;

            // check if the input field is empty
            if (string.IsNullOrEmpty(color))//this another way statement instead ""
            {
                MessageBox.Show("Color Cannot Be Empty", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            else if (tbCapacity.Text==string.Empty)//this another way as well instead "" and string.IsNullOrEmpty(color)
            {
                MessageBox.Show("Capacity Cannot be Empty", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            else
            {
                // create Washing Machine instance
                WashingMachine wm = new WashingMachine(id, brand, model, price, color, capacity, isPortable);

                // store to the file

                if (!File.Exists(filename))
                {
                    FileStream fs = File.Create(filename);
                    fs.Close();
                }

                if (File.Exists(filename))
                {
                    using (StreamWriter sw = File.AppendText(filename))
                    {
                        sw.WriteLine($"{wm.id};{wm.brand};{wm.model};{wm.price};{wm.color};{wm.capacity};{wm.isPortable}");
                        MessageBox.Show("new Washing Machine Added.");
                    }

                }
                tbId.Clear();
                tbBrand.Clear();
                tbModel.Clear();
                tbPrice.Clear();
                tbCapacity.Clear();
                tbColor.Clear();
                cbPortable.Checked = false;
                lightbox.Enabled = false;
                washingbox.Enabled = false;
                tablebox.Enabled = false;
                this.comboBox1.Text = "Choose Product";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                MessageBox.Show("The ID Cannot be Empty", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbModel.Text == "")
            {
                MessageBox.Show("The Model Cannot be Empty", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbBrand.Text == "")
            {
                MessageBox.Show("The Brand Cannot be Empty", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPrice.Text == "")
            {
                MessageBox.Show("Please Input The Price", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text == "Choose Product")
            {
                MessageBox.Show("Please Select Product Types", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text == "Light Bulb")
            {
                lightbox.Enabled = true;
                washingbox.Enabled = false;
                tablebox.Enabled = false;
            }
            else if (comboBox1.Text == "Washing Machine")
            {
                lightbox.Enabled = false;
                washingbox.Enabled = true;
                tablebox.Enabled = false;
            }
            else if (comboBox1.Text == "Table")
            {
                lightbox.Enabled = false;
                washingbox.Enabled = false;
                tablebox.Enabled = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenu = new MainMenu();
            MainMenu.ShowDialog();
            this.Close();
        }

        private void btnSmartphone_Click(object sender, EventArgs e)
        {
            string filename = "table.txt";
            // get input value
            string id = tbId.Text;
            string brand = tbBrand.Text;
            string model = tbModel.Text;
            string price = tbPrice.Text;

            String material = tbMaterial.Text;
            String height = tbHeight.Text;
            Boolean isSecond = cbSecond.Checked;

            // check if the input field is empty
            if (tbMaterial.Text == "")
            {
                MessageBox.Show("Table Material Cannot be Empty", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbHeight.Text == "")
            {
                MessageBox.Show("Table Height Cannot be empty", "Failed to Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // create Table instance
                Table tb = new Table(id, brand, model, price, material, height, isSecond);

                // store to the file

                if (!File.Exists(filename))
                {
                    FileStream fs = File.Create(filename);
                    fs.Close();
                }

                if (File.Exists(filename))
                {
                    using (StreamWriter sw = File.AppendText(filename))
                    {
                        sw.WriteLine($"{tb.id};{tb.brand};{tb.model};{tb.price};{tb.material};{tb.height};{tb.isSecond}");
                        MessageBox.Show("New Table Added.");
                    }

                }
                tbId.Clear();
                tbBrand.Clear();
                tbModel.Clear();
                tbPrice.Clear();
                tbMaterial.Clear();
                tbHeight.Clear();
                cbSecond.Checked = false;
                lightbox.Enabled = false;
                washingbox.Enabled = false;
                tablebox.Enabled = false;
                this.comboBox1.Text = "Choose Product";

            }
        }
    }
}
