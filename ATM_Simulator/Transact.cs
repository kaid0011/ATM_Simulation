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
    public partial class Transact : Form
    {
        public Transact()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw f_withdraw = new Withdraw();
            f_withdraw.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balance f_balance = new Balance();
            f_balance.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit f_deposit = new Deposit();
            f_deposit.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer f_transfer = new Transfer();
            f_transfer.ShowDialog();
        }

        private void Transact_Load(object sender, EventArgs e)
        {

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

        private void b_clr_Click(object sender, EventArgs e)
        {

        }
    }
}
