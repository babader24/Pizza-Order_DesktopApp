using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Desktop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void updateSelectedSize()
        {
            updateTotalPrice();

            if (gpSize_Small.Checked)
            {
                os_Size.Text = "Small";
                return;
            }
            if (gpSize_Meduim.Checked)
            {
                os_Size.Text = "Meduim";
                return;
            }
            if (gpSize_Large.Checked)
            {
                os_Size.Text = "Large";
                return;
            }

        }

        void updateSelectedCrust()
        {
            updateTotalPrice();

            if (rd_Thin.Checked)
            {
                os_CurstType.Text = "Thin";
                return;
            }
            if (rd_Think.Checked)
            {
                os_CurstType.Text = "Think";
            }
        }

        void updateWhereToEat()
        {
            updateTotalPrice();

            if (rdIndide.Checked)
            {
                os_WhereToEat.Text = "Inside";
                return;
            }
            if (rdTakeAway.Checked)
            {
                os_WhereToEat.Text = "Take Away";
                return;
            }
        }

        void updateToppings()
        {
            updateTotalPrice();

            string toppings = "";
            if (toppings_ExtraChees.Checked)
            {
                toppings = "Extra Chees";
            }

            if (toppings_GreenPeppers.Checked)
            {
                toppings += ",Green Peppers";
            }

            if (toppings_Mushroom.Checked)
            {
                toppings += ",Mushroom";
            }

            if (toppings_Olives.Checked)
            {
                toppings += ",Olives";
            }

            if (toppings_Onion.Checked)
            {
                toppings += ",Onion";
            }

            if (toppings_Tomatos.Checked)
            {
                toppings += ",Tomatos";

            }

            if (toppings.StartsWith(","))
            {
                toppings.Substring(1, toppings.Length - 1).Trim();
            }
            if (toppings == "")
                toppings = "No Toppings";

            os_Toppings.Text = toppings;

        }

        void updateTotalPrice()
        {
            os_totalPrice.Text = "$" + CalcTotalPrice().ToString();
        }

        float CalcTotalPrice()
        {
            return GetSelectedSizePrice() + GetToppingsPrice() + GetSelectedCrustPrice();
        }

        float GetSelectedSizePrice()
        {
            if (gpSize_Small.Checked)
                return Convert.ToSingle(gpSize_Small.Tag);

            else if (gpSize_Meduim.Checked)
                return Convert.ToSingle(gpSize_Meduim.Tag);

            else
                return Convert.ToSingle(gpSize_Large.Tag);
        }

        float GetToppingsPrice()
        {
            float toppingsPrice = 0;

            if (toppings_ExtraChees.Checked)
            {
                toppingsPrice += Convert.ToSingle(toppings_ExtraChees.Tag);
            }

            if (toppings_GreenPeppers.Checked)
            {
                toppingsPrice += Convert.ToSingle(toppings_GreenPeppers.Tag);
            }

            if (toppings_Mushroom.Checked)
            {
                toppingsPrice += Convert.ToSingle(toppings_Mushroom.Tag);
            }

            if (toppings_Olives.Checked)
            {
                toppingsPrice += Convert.ToSingle(toppings_Olives.Tag);
            }

            if (toppings_Onion.Checked)
            {
                toppingsPrice += Convert.ToSingle(toppings_Onion.Tag);
            }

            if (toppings_Tomatos.Checked)
            {
                toppingsPrice += Convert.ToSingle(toppings_Tomatos.Tag);
            }
            return toppingsPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (rd_Thin.Checked)
                return Convert.ToSingle(rd_Thin.Tag);

            else
                return Convert.ToSingle(rd_Think.Tag);
        }

        void ResetForm()
        {
            gpSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gpWhereToEat.Enabled = true;
            button2.Enabled = true;

            gpSize_Meduim.Checked = true;

            toppings_ExtraChees.Checked = false;
            toppings_Tomatos.Checked = false;
            toppings_Onion.Checked = false;
            toppings_Olives.Checked = false;
            toppings_Mushroom.Checked = false;
            toppings_GreenPeppers.Checked = false;

            rdIndide.Checked = true;

            rd_Thin.Checked = true;

        }

        private void gpSize_Small_CheckedChanged(object sender, EventArgs e)
        {
            updateSelectedSize();
        }

        private void gpSize_Meduim_CheckedChanged(object sender, EventArgs e)
        {
            updateSelectedSize();
        }

        private void gpSize_Large_CheckedChanged(object sender, EventArgs e)
        {
            updateSelectedSize();
        }

        private void rd_Thin_CheckedChanged(object sender, EventArgs e)
        {
            updateSelectedCrust();
        }

        private void rd_Think_CheckedChanged(object sender, EventArgs e)
        {
            updateSelectedCrust();
        }

        private void toppings_ExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void toppings_Onion_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void toppings_Mushroom_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void toppings_Olives_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void toppings_Tomatos_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void toppings_GreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void rdTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        private void rdIndide_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Reset", MessageBoxButtons.OKCancel,
     MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Orded Succssfuly", "succss");

                gpSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gpWhereToEat.Enabled = false;
                button2.Enabled = false;
                os_totalPrice.Text = "$" + 0.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            updateSelectedCrust();
            updateSelectedSize();
            updateToppings();
            updateTotalPrice();
            updateWhereToEat();
        }
    }
}
