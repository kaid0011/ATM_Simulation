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
    public partial class Deposit : Form
    {
        int ch;
        int account = PickTransact.acc;
        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            lblEntAmt.Visible = false;
            lblInput.Visible = false;
            lblEnt.Visible = false;
            b2_0.Visible = true;
            b2_1.Visible = true;
            b2_2.Visible = true;
            b2_3.Visible = true;
            b2_4.Visible = true;
            b2_5.Visible = true;
            b2_6.Visible = true;
            b2_7.Visible = true;
            b2_8.Visible = true;
            b2_9.Visible = true;
            b2_ent.Visible = true;
            b2_clr.Visible = true;
            btn1_2.Visible = false;
            btn3_2.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblEntAmt.Visible = true;
            lblInput.Visible = true;
            lblEnt.Visible = false;
            lblSavings.Visible = false;
            lblCheck.Visible = false;
            b2_0.Visible = false;
            b2_1.Visible = false;
            b2_2.Visible = false;
            b2_3.Visible = false;
            b2_4.Visible = false;
            b2_5.Visible = false;
            b2_6.Visible = false;
            b2_7.Visible = false;
            b2_8.Visible = false;
            b2_9.Visible = false;
            b2_ent.Visible = false;
            b2_clr.Visible = false;
            btn1_2.Visible = true;
            btn3_2.Visible = true;

            ch = 1;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblEntAmt.Visible = true;
            lblInput.Visible = true;
            lblEnt.Visible = false;
            lblSavings.Visible = false;
            lblCheck.Visible = false;
            b2_0.Visible = false;
            b2_1.Visible = false;
            b2_2.Visible = false;
            b2_3.Visible = false;
            b2_4.Visible = false;
            b2_5.Visible = false;
            b2_6.Visible = false;
            b2_7.Visible = false;
            b2_8.Visible = false;
            b2_9.Visible = false;
            b2_ent.Visible = false;
            b2_clr.Visible = false;
            btn1_2.Visible = true;
            btn3_2.Visible = true;

            ch = 2;
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "1";
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "2";
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "3";
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "4";
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "5";
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "6";
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "7";
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "8";
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "9";
        }

        private void b_0_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "0";
        }

        private void b_clr_Click(object sender, EventArgs e)
        {
            if (lblInput.Text.Length > 0)
            {
                lblInput.Text = lblInput.Text.Remove(lblInput.Text.Length - 1, 1);
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
            int x = Int32.Parse(lblInput.Text);

            if ((x % 20 == 0) || (x % 50 == 0))
            {
                if (account == 1)
                {
                    if (ch == 1)
                    {
                        Balance.bal_s1 = Balance.bal_s1 + x;

                        DialogResult iCont;

                        iCont = MessageBox.Show("Transaction successful.\nYour new balance is " + Balance.bal_s1 + "\n\nDo you have another transaction?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    else if (ch == 2)
                    {
                        Balance.bal_c1 = Balance.bal_c1 + x;

                        DialogResult iCont;

                        iCont = MessageBox.Show("Transaction successful.\nYour new balance is " + Balance.bal_c1 + "\n\nDo you have another transaction?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                }
                if (account == 2)
                {
                    if (ch == 1)
                    {
                        Balance.bal_s2 = Balance.bal_s2 + x;

                        DialogResult iCont;

                        iCont = MessageBox.Show("Transaction successful.\nYour new balance is " + Balance.bal_s2 + "\n\nDo you have another transaction?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    else if (ch == 2)
                    {
                        Balance.bal_c2 = Balance.bal_c2 + x;

                        DialogResult iCont;

                        iCont = MessageBox.Show("Transaction successful.\nYour new balance is " + Balance.bal_c2 + "\n\nDo you have another transaction?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                }
                if (account == 3)
                {
                    if (ch == 1)
                    {
                        Balance.bal_s3 = Balance.bal_s3 + x;

                        DialogResult iCont;

                        iCont = MessageBox.Show("Transaction successful.\nYour new balance is " + Balance.bal_s3 + "\n\nDo you have another transaction?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    else if (ch == 2)
                    {
                        Balance.bal_c3 = Balance.bal_c3 + x;

                        DialogResult iCont;

                        iCont = MessageBox.Show("Transaction successful.\nYour new balance is " + Balance.bal_c3 + "\n\nDo you have another transaction?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                }
                if (account == 4)
                {
                    if (ch == 1)
                    {
                        Balance.bal_s4 = Balance.bal_s4 + x;

                        DialogResult iCont;

                        iCont = MessageBox.Show("Transaction successful.\nYour new balance is " + Balance.bal_s4 + "\n\nDo you have another transaction?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    else if (ch == 2)
                    {
                        Balance.bal_c4 = Balance.bal_c4 + x;

                        DialogResult iCont;

                        iCont = MessageBox.Show("Transaction successful.\nYour new balance is " + Balance.bal_c4 + "\n\nDo you have another transaction?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                }
                if (account == 5)
                {
                    if (ch == 1)
                    {
                        Balance.bal_s5 = Balance.bal_s5 + x;

                        DialogResult iCont;

                        iCont = MessageBox.Show("Transaction successful.\nYour new balance is " + Balance.bal_s5 + "\n\nDo you have another transaction?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    else if (ch == 2)
                    {
                        Balance.bal_c5 = Balance.bal_c5 + x;

                        DialogResult iCont;

                        iCont = MessageBox.Show("Transaction successful.\nYour new balance is " + Balance.bal_c5 + "\n\nDo you have another transaction?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                }
            }
            else
            {
                DialogResult iCont;

                iCont = MessageBox.Show("This ATM machine\ncan only accept bills\n\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iCont == DialogResult.Yes)
                {
                    lblInput.Text = "";
                }
                else if (iCont == DialogResult.No)
                {
                    MessageBox.Show("Thank you for banking with us.", "Thank You");
                    this.Hide();
                    PickTransact f_pick = new PickTransact();
                    f_pick.ShowDialog();
                }
            }
        }
    }
}
