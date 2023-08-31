using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_WFA
{
    public partial class Balance : Form
    {
        int account = PickTransact.acc;

        public static int bal_s1 = 5000;
        public static int bal_s2 = 5000;
        public static int bal_s3 = 5000;
        public static int bal_s4 = 5000;
        public static int bal_s5 = 5000;

        public static int bal_c1 = 5000;
        public static int bal_c2 = 5000;
        public static int bal_c3 = 5000;
        public static int bal_c4 = 5000;
        public static int bal_c5 = 5000;

        public Balance()
        {
            InitializeComponent();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            lblInput.Visible = false;
            lbl_sbal.Visible = false;
            lblEnt.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblSavings.Visible = false;
            lblCheck.Visible = false;
            lblInput.Visible = true;
            lbl_sbal.Visible = true;
            lblEnt.Visible = true;

            if (account == 1)
            {
                lblInput.Text = lblInput.Text + bal_s1;
            }
            else if (account == 2)
            {
                lblInput.Text = lblInput.Text + bal_s2;
            }
            else if (account == 3)
            {
                lblInput.Text = lblInput.Text + bal_s3;
            }
            else if (account == 4)
            {
                lblInput.Text = lblInput.Text + bal_s4;
            }
            else if (account == 5)
            {
                lblInput.Text = lblInput.Text + bal_s5;
            }
        }

        private void b_canc_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Are you sure you want to exit?", "ATM Bank Simulator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for banking with us.", "Thank You");
                this.Hide();
                PickTransact f_pick = new PickTransact();
                f_pick.ShowDialog();
            }
        }

        private void b_ent_Click(object sender, EventArgs e)
        {
            DialogResult iCont;

            iCont = MessageBox.Show("Do you have another transaction?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iCont == DialogResult.Yes)
            {
                this.Hide();
                Transact f_transact = new Transact();
                f_transact.ShowDialog();
            }
            else if (iCont == DialogResult.No)
            {
                MessageBox.Show("Thank you for banking with us.", "Thank You");
                this.Hide();
                PickTransact f_pick = new PickTransact();
                f_pick.ShowDialog();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblSavings.Visible = false;
            lblCheck.Visible = false;
            lblInput.Visible = true;
            lbl_sbal.Visible = true;
            lblEnt.Visible = true;

            if (account == 1)
            {
                lblInput.Text = lblInput.Text + bal_c1;
            }
            else if (account == 2)
            {
                lblInput.Text = lblInput.Text + bal_c2;
            }
            else if (account == 3)
            {
                lblInput.Text = lblInput.Text + bal_c3;
            }
            else if (account == 4)
            {
                lblInput.Text = lblInput.Text + bal_c4;
            }
            else if (account == 5)
            {
                lblInput.Text = lblInput.Text + bal_c5;
            }
        }

        private void lblCheck_Click(object sender, EventArgs e)
        {

        }

        private void b_7_Click(object sender, EventArgs e)
        {

        }

        private void b_8_Click(object sender, EventArgs e)
        {

        }

        private void b_9_Click(object sender, EventArgs e)
        {

        }

        private void b_clr_Click(object sender, EventArgs e)
        {

        }

        private void lblInput_Click(object sender, EventArgs e)
        {

        }
    }
}
