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
    public partial class ViewMenu : Form
    {
        List<WashingMachine> wmList = new List<WashingMachine>();
        List<LightBulb> lbList = new List<LightBulb>();
        List<Table> tblist = new List<Table>();
        int selectedType = 0;

        public ViewMenu()
        {
            InitializeComponent();
            selectType.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            selectedType = selectType.SelectedIndex;

            if (selectedType == 0)
            {
                string filename = "washing_machine.txt";

                if (!File.Exists(filename))
                {
                    FileStream fs = File.Create(filename);
                    fs.Close();
                }

                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] data = line.Split(';');
                    WashingMachine wm = new WashingMachine(data[0], data[1], data[2], data[3], data[4], data[5], Convert.ToBoolean(data[6]));
                    wmList.Add(wm);
                    listBox1.Items.Add(wm.display());
                }
            }
            else if (selectedType == 1)
            {
                string filename = "light_bulb.txt";

                if (!File.Exists(filename))
                {
                    FileStream fs = File.Create(filename);
                    fs.Close();
                }

                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] data = line.Split(';');
                    LightBulb lb = new LightBulb(data[0], data[1], data[2], data[3], data[4], data[5], Convert.ToBoolean(data[6]));
                    lbList.Add(lb);
                    listBox1.Items.Add(lb.display());
                }

            }
            else if (selectedType == 2)
            {
                string filename = "table.txt";

                if (!File.Exists(filename))
                {
                    FileStream fs = File.Create(filename);
                    fs.Close();
                }

                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] data = line.Split(';');
                    Table tb = new Table(data[0], data[1], data[2], data[3], data[4], data[5], Convert.ToBoolean(data[6]));
                    tblist.Add(tb);
                    listBox1.Items.Add(tb.display());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if(selectedIndex >= 0)
            {
                if (selectedType == 0)
                {
                    WashingMachine wm = wmList[selectedIndex];

                    label5.Text = "Color:";
                    label6.Text = "Capacity:";
                    label7.Text = "Portable:";

                    val1.Text = wm.id;
                    val2.Text = wm.brand;
                    val3.Text = wm.model;
                    val4.Text = wm.price;
                    hasil5.Text = wm.color;
                    hasil6.Text = wm.capacity;
                    hasil7.Text = wm.isPortable.ToString();

                }
                else if (selectedType == 1)
                {
                    LightBulb lb = lbList[selectedIndex];

                    label5.Text = "Brightness:";
                    label6.Text = "Wattage:";
                    label7.Text = "Smart:";

                    val1.Text = lb.id;
                    val2.Text = lb.brand;
                    val3.Text = lb.model;
                    val4.Text = lb.price;
                    hasil5.Text = lb.brightness;
                    hasil6.Text = lb.wattage;
                    hasil7.Text = lb.isSmart.ToString();
                }
                else if (selectedType == 2)
                {
                    Table tb = tblist[selectedIndex];

                    label5.Text = "Material:";
                    label6.Text = "Height (cm):";
                    label7.Text = "Second Hand:";

                    val1.Text = tb.id;
                    val2.Text = tb.brand;
                    val3.Text = tb.model;
                    val4.Text = tb.price;
                    hasil5.Text = tb.material;
                    hasil6.Text = tb.height;
                    hasil7.Text = tb.isSecond.ToString();
                }

                groupBox1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void selectType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hasil5_Click(object sender, EventArgs e)
        {

        }
    }
}
