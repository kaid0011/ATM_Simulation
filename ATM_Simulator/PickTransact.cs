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
    public partial class PickTransact : Form
    {
        public static int acc;
        
        public PickTransact()
        {
            InitializeComponent();
        }

        private void CheckOutputLength()
        {
            if (lblInput2.Text.Length == 4)
            {
                String pin1 = String.Format(lblInput2.Text);
                String pin2 = String.Format(lblInput2.Text);
                String pin3 = String.Format(lblInput2.Text);
                String pin4 = String.Format(lblInput2.Text);
                String pin5 = String.Format(lblInput2.Text);

                if (acc == 1 && pin1 == "1234")
                {
                    lblEntPin.Visible = false;
                    lblEntAcc.Visible = false;

                    this.Hide();
                    Transact f_transact = new Transact();
                    f_transact.ShowDialog();
                }
                else if (acc == 2 && pin2 == "2345")
                {
                    lblEntPin.Visible = false;
                    lblEntAcc.Visible = false;

                    this.Hide();
                    Transact f_transact = new Transact();
                    f_transact.ShowDialog();
                }
                else if (acc == 3 && pin3 == "3456")
                {
                    lblEntPin.Visible = false;
                    lblEntAcc.Visible = false;

                    this.Hide();
                    Transact f_transact = new Transact();
                    f_transact.ShowDialog();
                }
                else if (acc == 4 && pin4 == "4567")
                {
                    lblEntPin.Visible = false;
                    lblEntAcc.Visible = false;

                    this.Hide();
                    Transact f_transact = new Transact();
                    f_transact.ShowDialog();
                }
                else if (acc == 5 && pin5 == "5678")
                {
                    lblEntPin.Visible = false;
                    lblEntAcc.Visible = false;

                    this.Hide();
                    Transact f_transact = new Transact();
                    f_transact.ShowDialog();
                }
                else if (acc == 0 && pin5 == "0000")
                {
                    lblEntPin.Visible = false;
                    lblEntAcc.Visible = false;

                    this.Hide();
                    admin f_Admin = new admin();
                    f_Admin.ShowDialog();
                }
                else
                {
                    DialogResult iCont;

                    iCont = MessageBox.Show("Wrong pin.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iCont == DialogResult.Yes)
                    {
                        lblInput2.Text = "";
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
                if(iExit == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for banking with us.", "Thank You");
                this.Hide();
                PickTransact f_pick = new PickTransact();
                f_pick.ShowDialog();
            }
        }

        private void PickTransact_Load(object sender, EventArgs e)
        {
            b2_1.Visible = false;
            b2_2.Visible = false;
            b2_3.Visible = false;
            b2_4.Visible = false;
            b2_5.Visible = false;
            b2_6.Visible = false;
            b2_7.Visible = false;
            b2_8.Visible = false;
            b2_9.Visible = false;
            b2_0.Visible = false;
            b2_clr.Visible = false;
            b_Enter2.Visible = false;
            lblInput2.Visible = false;
            lblEntPin.Visible = false;
            lblEntAcc.Visible = true;
        }

        private void b_ent_Click(object sender, EventArgs e)
        {
            String acc1 = String.Format(lblInput.Text);
            String acc2 = String.Format(lblInput.Text);
            String acc3 = String.Format(lblInput.Text);
            String acc4 = String.Format(lblInput.Text);
            String acc5 = String.Format(lblInput.Text);

            if (acc1 == "00001")
            {
                acc = 1;
                b2_1.Visible = true;
                b2_2.Visible = true;
                b2_3.Visible = true;
                b2_4.Visible = true;
                b2_5.Visible = true;
                b2_6.Visible = true;
                b2_7.Visible = true;
                b2_8.Visible = true;
                b2_9.Visible = true;
                b2_0.Visible = true;
                b2_clr.Visible = true;
                b_Enter2.Visible = true;
                lblInput2.Visible = true;
                lblEntPin.Visible = true;
                lblEntAcc.Visible = false;
                lblInput.Visible = false;
            }
            else if (acc2 == "00002")
            {
                acc = 2;
                b2_1.Visible = true;
                b2_2.Visible = true;
                b2_3.Visible = true;
                b2_4.Visible = true;
                b2_5.Visible = true;
                b2_6.Visible = true;
                b2_7.Visible = true;
                b2_8.Visible = true;
                b2_9.Visible = true;
                b2_0.Visible = true;
                b2_clr.Visible = true;
                b_Enter2.Visible = true;
                lblInput2.Visible = true;
                lblEntPin.Visible = true;
                lblEntAcc.Visible = false;
                lblInput.Visible = false;
            }
            else if (acc3 == "00003")
            {
                acc = 3;
                b2_1.Visible = true;
                b2_2.Visible = true;
                b2_3.Visible = true;
                b2_4.Visible = true;
                b2_5.Visible = true;
                b2_6.Visible = true;
                b2_7.Visible = true;
                b2_8.Visible = true;
                b2_9.Visible = true;
                b2_0.Visible = true;
                b2_clr.Visible = true;
                b_Enter2.Visible = true;
                lblInput2.Visible = true;
                lblEntPin.Visible = true;
                lblEntAcc.Visible = false;
                lblInput.Visible = false;
            }
            else if (acc4 == "00004")
            {
                acc = 4;
                b2_1.Visible = true;
                b2_2.Visible = true;
                b2_3.Visible = true;
                b2_4.Visible = true;
                b2_5.Visible = true;
                b2_6.Visible = true;
                b2_7.Visible = true;
                b2_8.Visible = true;
                b2_9.Visible = true;
                b2_0.Visible = true;
                b2_clr.Visible = true;
                b_Enter2.Visible = true;
                lblInput2.Visible = true;
                lblEntPin.Visible = true;
                lblEntAcc.Visible = false;
                lblInput.Visible = false;
            }
            else if (acc5 == "00005")
            {
                acc = 5;
                b2_1.Visible = true;
                b2_2.Visible = true;
                b2_3.Visible = true;
                b2_4.Visible = true;
                b2_5.Visible = true;
                b2_6.Visible = true;
                b2_7.Visible = true;
                b2_8.Visible = true;
                b2_9.Visible = true;
                b2_0.Visible = true;
                b2_clr.Visible = true;
                b_Enter2.Visible = true;
                lblInput2.Visible = true;
                lblEntPin.Visible = true;
                lblEntAcc.Visible = false;
                lblInput.Visible = false;
            }
            else if (acc5 == "12345")
            {
                acc = 0;
                b2_1.Visible = true;
                b2_2.Visible = true;
                b2_3.Visible = true;
                b2_4.Visible = true;
                b2_5.Visible = true;
                b2_6.Visible = true;
                b2_7.Visible = true;
                b2_8.Visible = true;
                b2_9.Visible = true;
                b2_0.Visible = true;
                b2_clr.Visible = true;
                b_Enter2.Visible = true;
                lblInput2.Visible = true;
                lblEntPin.Visible = true;
                lblEntAcc.Visible = false;
                lblInput.Visible = false;
            }
            else
            {
                DialogResult iCont;

                iCont = MessageBox.Show("Account Number does not exist.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void b2_1_Click(object sender, EventArgs e)
        {
            lblInput2.Text = lblInput2.Text + "1";
            CheckOutputLength();
        }

        private void b2_2_Click(object sender, EventArgs e)
        {
            lblInput2.Text = lblInput2.Text + "2";
            CheckOutputLength();
        }

        private void b2_3_Click(object sender, EventArgs e)
        {
            lblInput2.Text = lblInput2.Text + "3";
            CheckOutputLength();
        }

        private void b2_4_Click(object sender, EventArgs e)
        {
            lblInput2.Text = lblInput2.Text + "4";
            CheckOutputLength();
        }

        private void b2_5_Click(object sender, EventArgs e)
        {
            lblInput2.Text = lblInput2.Text + "5";
            CheckOutputLength();
        }

        private void b2_6_Click(object sender, EventArgs e)
        {
            lblInput2.Text = lblInput2.Text + "6";
            CheckOutputLength();
        }

        private void b2_7_Click(object sender, EventArgs e)
        {
            lblInput2.Text = lblInput2.Text + "7";
            CheckOutputLength();
        }

        private void b2_8_Click(object sender, EventArgs e)
        {
            lblInput2.Text = lblInput2.Text + "8";
            CheckOutputLength();
        }

        private void b2_9_Click(object sender, EventArgs e)
        {
            lblInput2.Text = lblInput2.Text + "9";
            CheckOutputLength();
        }

        private void b2_0_Click(object sender, EventArgs e)
        {
            lblInput2.Text = lblInput2.Text + "0";
            CheckOutputLength();
        }

        private void b2_clr_Click(object sender, EventArgs e)
        {
            if (lblInput2.Text.Length > 0)
            {
                lblInput2.Text = lblInput2.Text.Remove(lblInput2.Text.Length - 1, 1);
            }
        }

        private void b_Enter2_Click(object sender, EventArgs e)
        {
            
        }

        private void grpKeys_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
