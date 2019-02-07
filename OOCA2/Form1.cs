using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOCA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picbx_blueCar.Visible = false;
            picbx_blueShirt.Visible = false;
            picbx_blueShoe.Visible = false;
            picbx_redCar.Visible = false;
            picbx_redShirt.Visible = false;
            picBx_redShoe.Visible = false;
            picbx_yellowShirt.Visible = false;
            picbx_yellowShoe.Visible = false;
            picbx_yellowCar.Visible = false;
            lbl_date.Visible = false;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            picbx_blueCar.Visible = false;
            picbx_blueShirt.Visible = false;
            picbx_blueShoe.Visible = false;
            picbx_redCar.Visible = false;
            picbx_redShirt.Visible = false;
            picBx_redShoe.Visible = false;
            picbx_yellowShirt.Visible = false;
            picbx_yellowShoe.Visible = false;
            picbx_yellowCar.Visible = false;
            lbl_date.Visible = false;
            lbl_name.Text = "";
            if (rdobtn_red.Checked && lstbx_inventory.GetSelected(0))
            {
                picBx_redShoe.Visible = true;
            }
            else if (rdobtn_red.Checked && lstbx_inventory.GetSelected(1))
            {
                picbx_redShirt.Visible = true;
            }
            else if (rdobtn_red.Checked && lstbx_inventory.GetSelected(2))
            {
                picbx_redCar.Visible = true;
            }
            else if (rdobtn_Blue.Checked && lstbx_inventory.GetSelected(0))
            {
                picbx_blueShoe.Visible = true;
            }
            else if (rdobtn_Blue.Checked && lstbx_inventory.GetSelected(2))
            {
                picbx_blueCar.Visible = true;
            }
            else if (rdobtn_Blue.Checked && lstbx_inventory.GetSelected(1))
            {
                picbx_blueShirt.Visible = true;
            }
            else if (rdobtn_yellow.Checked && lstbx_inventory.GetSelected(0))
            {
                picbx_yellowShoe.Visible = true;
            }
            else if (rdobtn_yellow.Checked && lstbx_inventory.GetSelected(2))
            {
                picbx_yellowCar.Visible = true;
            }
            else if (rdobtn_yellow.Checked && lstbx_inventory.GetSelected(1))
            {
                picbx_yellowShirt.Visible = true;
            }

            if (chbx_name.Checked && rdobtn_red.Checked && lstbx_inventory.GetSelected(0))
            {
                lbl_name.Text = "Red Shoe";
            }
            else if (chbx_name.Checked && rdobtn_red.Checked && lstbx_inventory.GetSelected(1))
            {
                lbl_name.Text = "Red Shirt";
            }
            else if (chbx_name.Checked && rdobtn_red.Checked && lstbx_inventory.GetSelected(2))
            {
                lbl_name.Text = "Red Car";
            }
            else if (chbx_name.Checked && rdobtn_Blue.Checked && lstbx_inventory.GetSelected(0))
            {
                lbl_name.Text = "Blue Shoe";
            }
            else if (chbx_name.Checked && rdobtn_Blue.Checked && lstbx_inventory.GetSelected(1))
            {
                lbl_name.Text = "Blue Shirt";
            }
            else if (chbx_name.Checked && rdobtn_Blue.Checked && lstbx_inventory.GetSelected(2))
            {
                lbl_name.Text = "Blue Car";
            }
            else if(chbx_name.Checked && rdobtn_yellow.Checked && lstbx_inventory.GetSelected(0))
            {
                lbl_name.Text = "Yellow Shoe";
            }
            else if(chbx_name.Checked && rdobtn_yellow.Checked && lstbx_inventory.GetSelected(1))
            {
                lbl_name.Text = "Yellow Shirt";
            }
            else if(chbx_name.Checked && rdobtn_yellow.Checked && lstbx_inventory.GetSelected(2))
            {
                lbl_name.Text = "Yellow Car";
            }
            if (chbx_date.Checked)
            {
                lbl_date.Visible = true;
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            picbx_blueCar.Visible = false;
            picbx_blueShirt.Visible = false;
            picbx_blueShoe.Visible = false;
            picbx_redCar.Visible = false;
            picbx_redShirt.Visible = false;
            picBx_redShoe.Visible = false;
            picbx_yellowShirt.Visible = false;
            picbx_yellowShoe.Visible = false;
            picbx_yellowCar.Visible = false;
            lbl_date.Visible = false;
            lbl_name.Text = "";
        }
    }
}
