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
    public partial class Transfer : Form
    {
        int ch;
        int account = PickTransact.acc;
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            lblTo.Visible = false;
            lblInput_2.Visible = false;
            lblEnt.Visible = false;
            btn2_2.Visible = false;
            btn4_2.Visible = false;
            lblReceiver.Visible = false;
            lblInput.Visible = false;
            lblEntAmt.Visible = false;
            b3_0.Visible = true;
            b3_1.Visible = true;
            b3_2.Visible = true;
            b3_3.Visible = true;
            b3_4.Visible = true;
            b3_5.Visible = true;
            b3_6.Visible = true;
            b3_7.Visible = true;
            b3_8.Visible = true;
            b3_9.Visible = true;
            b3_ent.Visible = true;
            b3_clr.Visible = true;
            btn2_3.Visible = false;
            btn4_3.Visible = false;
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
            lblTo.Visible = false;
            lblInput_2.Visible = true;
            lblEnt.Visible = false;
            btn2_2.Visible = false;
            btn4_2.Visible = false;
            lblReceiver.Visible = true;
            lblInput.Visible = false;
            lblEntAmt.Visible = false;
            lblfrom.Visible = false;
            lblCheck.Visible = false;
            lblSavings.Visible = false;
            btn2.Visible = true;
            btn4.Visible = true;
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
            b2_ent.Visible = true;
            b3_0.Visible = false;
            b3_1.Visible = false;
            b3_2.Visible = false;
            b3_3.Visible = false;
            b3_4.Visible = false;
            b3_5.Visible = false;
            b3_6.Visible = false;
            b3_7.Visible = false;
            b3_8.Visible = false;
            b3_9.Visible = false;
            b3_ent.Visible = false;
            b3_clr.Visible = false;
            btn2_3.Visible = true;
            btn4_3.Visible = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblTo.Visible = false;
            lblInput_2.Visible = false;
            lblEnt.Visible = false;
            btn2_2.Visible = false;
            btn4_2.Visible = false;
            lblReceiver.Visible = false;
            lblInput.Visible = true;
            lblEntAmt.Visible = true;
            lblfrom.Visible = false;
            lblCheck.Visible = false;
            lblSavings.Visible = false;
            btn2.Visible = true;
            btn4.Visible = true;
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
            b2_ent.Visible = false;
            b3_0.Visible = false;
            b3_1.Visible = false;
            b3_2.Visible = false;
            b3_3.Visible = false;
            b3_4.Visible = false;
            b3_5.Visible = false;
            b3_6.Visible = false;
            b3_7.Visible = false;
            b3_8.Visible = false;
            b3_9.Visible = false;
            b3_ent.Visible = false;
            b3_clr.Visible = false;
            btn2_3.Visible = true;
            btn4_3.Visible = true;

            ch = 1;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblTo.Visible = false;
            lblInput_2.Visible = false;
            lblEnt.Visible = false;
            btn2_2.Visible = false;
            btn4_2.Visible = false;
            lblReceiver.Visible = false;
            lblInput.Visible = true;
            lblEntAmt.Visible = true;
            lblfrom.Visible = false;
            lblCheck.Visible = false;
            lblSavings.Visible = false;
            btn2.Visible = true;
            btn4.Visible = true;
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
            b2_ent.Visible = false;
            b3_0.Visible = false;
            b3_1.Visible = false;
            b3_2.Visible = false;
            b3_3.Visible = false;
            b3_4.Visible = false;
            b3_5.Visible = false;
            b3_6.Visible = false;
            b3_7.Visible = false;
            b3_8.Visible = false;
            b3_9.Visible = false;
            b3_ent.Visible = false;
            b3_clr.Visible = false;
            btn2_3.Visible = true;
            btn4_3.Visible = true;

            ch = 2;
        }

        private void b2_1_Click(object sender, EventArgs e)
        {
            lblInput_2.Text = lblInput_2.Text + "1";
        }

        private void b2_2_Click(object sender, EventArgs e)
        {
            lblInput_2.Text = lblInput_2.Text + "2";
        }

        private void b2_3_Click(object sender, EventArgs e)
        {
            lblInput_2.Text = lblInput_2.Text + "3";
        }

        private void b2_4_Click(object sender, EventArgs e)
        {
            lblInput_2.Text = lblInput_2.Text + "4";
        }

        private void b2_5_Click(object sender, EventArgs e)
        {
            lblInput_2.Text = lblInput_2.Text + "5";
        }

        private void b2_6_Click(object sender, EventArgs e)
        {
            lblInput_2.Text = lblInput_2.Text + "6";
        }

        private void b2_7_Click(object sender, EventArgs e)
        {
            lblInput_2.Text = lblInput_2.Text + "7";
        }

        private void b2_8_Click(object sender, EventArgs e)
        {
            lblInput_2.Text = lblInput_2.Text + "8";
        }

        private void b2_9_Click(object sender, EventArgs e)
        {
            lblInput_2.Text = lblInput_2.Text + "9";
        }

        private void b2_0_Click(object sender, EventArgs e)
        {
            lblInput_2.Text = lblInput_2.Text + "0";
        }

        private void b2_clr_Click(object sender, EventArgs e)
        {
            if (lblInput_2.Text.Length > 0)
            {
                lblInput_2.Text = lblInput_2.Text.Remove(lblInput_2.Text.Length - 1, 1);
            }
        }

        private void b2_ent_Click(object sender, EventArgs e)
        {
            lblTo.Visible = true;
            lblInput_2.Visible = false;
            lblEnt.Visible = false;
            btn2_2.Visible = true;
            btn4_2.Visible = true;
            lblReceiver.Visible = false;
            lblInput.Visible = false;
            lblEntAmt.Visible = false;
            lblfrom.Visible = false;
            lblCheck.Visible = true;
            lblSavings.Visible = true;
            btn2.Visible = false;
            btn4.Visible = false;
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
            b2_ent.Visible = false;
            b3_0.Visible = true;
            b3_1.Visible = true;
            b3_2.Visible = true;
            b3_3.Visible = true;
            b3_4.Visible = true;
            b3_5.Visible = true;
            b3_6.Visible = true;
            b3_7.Visible = true;
            b3_8.Visible = true;
            b3_9.Visible = true;
            b3_ent.Visible = true;
            b3_clr.Visible = true;
            btn2_3.Visible = false;
            btn4_3.Visible = false;
        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(lblInput.Text);
            int y = Int32.Parse(lblInput_2.Text);
            int limit = 500;

            
                if (account == 1)
                {
                    if (y == 00002)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s1 - x) >= limit)
                            {
                                Balance.bal_s1 = Balance.bal_s1 - x;
                                Balance.bal_s2 = Balance.bal_s2 + x;

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
                            else if ((Balance.bal_s1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c1 - x) >= limit)
                            {
                                Balance.bal_c1 = Balance.bal_c1 - x;
                                Balance.bal_s2 = Balance.bal_s2 + x;

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
                            else if ((Balance.bal_c1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00003)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s1 - x) >= limit)
                            {
                                Balance.bal_s1 = Balance.bal_s1 - x;
                                Balance.bal_s3 = Balance.bal_s3 + x;

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
                            else if ((Balance.bal_s1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c1 - x) >= limit)
                            {
                                Balance.bal_c1 = Balance.bal_c1 - x;
                                Balance.bal_s3 = Balance.bal_s3 + x;

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
                            else if ((Balance.bal_c1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00004)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s1 - x) >= limit)
                            {
                                Balance.bal_s1 = Balance.bal_s1 - x;
                                Balance.bal_s4 = Balance.bal_s4 + x;

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
                            else if ((Balance.bal_s1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c1 - x) >= limit)
                            {
                                Balance.bal_c1 = Balance.bal_c1 - x;
                                Balance.bal_s4 = Balance.bal_s4 + x;

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
                            else if ((Balance.bal_c1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00005)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s1 - x) >= limit)
                            {
                                Balance.bal_s1 = Balance.bal_s1 - x;
                                Balance.bal_s5 = Balance.bal_s5 + x;

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
                            else if ((Balance.bal_s1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c1 - x) >= limit)
                            {
                                Balance.bal_c1 = Balance.bal_c1 - x;
                                Balance.bal_s5 = Balance.bal_s5 + x;

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
                            else if ((Balance.bal_c1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (account == 2)
                {
                    if (y == 00001)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s2 - x) >= limit)
                            {
                                Balance.bal_s2 = Balance.bal_s2 - x;
                                Balance.bal_s1 = Balance.bal_s1 + x;

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
                            else if ((Balance.bal_s2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c2 - x) >= limit)
                            {
                                Balance.bal_c2 = Balance.bal_c2 - x;
                                Balance.bal_s1 = Balance.bal_s1 + x;

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
                            else if ((Balance.bal_c2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00003)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s2 - x) >= limit)
                            {
                                Balance.bal_s2 = Balance.bal_s2 - x;
                                Balance.bal_s3 = Balance.bal_s3 + x;

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
                            else if ((Balance.bal_s2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c2 - x) >= limit)
                            {
                                Balance.bal_c2 = Balance.bal_c2 - x;
                                Balance.bal_s3 = Balance.bal_s3 + x;

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
                            else if ((Balance.bal_c2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00004)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s2 - x) >= limit)
                            {
                                Balance.bal_s2 = Balance.bal_s2 - x;
                                Balance.bal_s4 = Balance.bal_s4 + x;

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
                            else if ((Balance.bal_s2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c2 - x) >= limit)
                            {
                                Balance.bal_c2 = Balance.bal_c2 - x;
                                Balance.bal_s4 = Balance.bal_s4 + x;

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
                            else if ((Balance.bal_c2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00005)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s2 - x) >= limit)
                            {
                                Balance.bal_s2 = Balance.bal_s2 - x;
                                Balance.bal_s5 = Balance.bal_s5 + x;

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
                            else if ((Balance.bal_s2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c2 - x) >= limit)
                            {
                                Balance.bal_c2 = Balance.bal_c2 - x;
                                Balance.bal_s5 = Balance.bal_s5 + x;

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
                            else if ((Balance.bal_c2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (account == 3)
                {
                    if (y == 00002)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s3 - x) >= limit)
                            {
                                Balance.bal_s3 = Balance.bal_s3 - x;
                                Balance.bal_s2 = Balance.bal_s2 + x;

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
                            else if ((Balance.bal_s3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c3 - x) >= limit)
                            {
                                Balance.bal_c3 = Balance.bal_c3 - x;
                                Balance.bal_s2 = Balance.bal_s2 + x;

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
                            else if ((Balance.bal_c3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00001)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s3 - x) >= limit)
                            {
                                Balance.bal_s3 = Balance.bal_s3 - x;
                                Balance.bal_s1 = Balance.bal_s1 + x;

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
                            else if ((Balance.bal_s3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c3 - x) >= limit)
                            {
                                Balance.bal_c3 = Balance.bal_c3 - x;
                                Balance.bal_s1 = Balance.bal_s1 + x;

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
                            else if ((Balance.bal_c3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00004)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s3 - x) >= limit)
                            {
                                Balance.bal_s3 = Balance.bal_s3 - x;
                                Balance.bal_s4 = Balance.bal_s4 + x;

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
                            else if ((Balance.bal_s3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c3 - x) >= limit)
                            {
                                Balance.bal_c3 = Balance.bal_c3 - x;
                                Balance.bal_s4 = Balance.bal_s4 + x;

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
                            else if ((Balance.bal_c3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00005)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s3 - x) >= limit)
                            {
                                Balance.bal_s3 = Balance.bal_s3 - x;
                                Balance.bal_s5 = Balance.bal_s5 + x;

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
                            else if ((Balance.bal_s3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c3 - x) >= limit)
                            {
                                Balance.bal_c3 = Balance.bal_c3 - x;
                                Balance.bal_s5 = Balance.bal_s5 + x;

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
                            else if ((Balance.bal_c3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (account == 4)
                {
                    if (y == 00002)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s4 - x) >= limit)
                            {
                                Balance.bal_s4 = Balance.bal_s4 - x;
                                Balance.bal_s2 = Balance.bal_s2 + x;

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
                            else if ((Balance.bal_s4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c4 - x) >= limit)
                            {
                                Balance.bal_c4 = Balance.bal_c4 - x;
                                Balance.bal_s2 = Balance.bal_s2 + x;

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
                            else if ((Balance.bal_c4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00003)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s4 - x) >= limit)
                            {
                                Balance.bal_s4 = Balance.bal_s4 - x;
                                Balance.bal_s3 = Balance.bal_s3 + x;

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
                            else if ((Balance.bal_s4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c4 - x) >= limit)
                            {
                                Balance.bal_c4 = Balance.bal_c4 - x;
                                Balance.bal_s3 = Balance.bal_s3 + x;

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
                            else if ((Balance.bal_c4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00001)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s4 - x) >= limit)
                            {
                                Balance.bal_s4 = Balance.bal_s4 - x;
                                Balance.bal_s1 = Balance.bal_s1 + x;

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
                            else if ((Balance.bal_s4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c4 - x) >= limit)
                            {
                                Balance.bal_c4 = Balance.bal_c4 - x;
                                Balance.bal_s1 = Balance.bal_s1 + x;

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
                            else if ((Balance.bal_c4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00005)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s4 - x) >= limit)
                            {
                                Balance.bal_s4 = Balance.bal_s4 - x;
                                Balance.bal_s5 = Balance.bal_s5 + x;

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
                            else if ((Balance.bal_s4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c4 - x) >= limit)
                            {
                                Balance.bal_c4 = Balance.bal_c4 - x;
                                Balance.bal_s5 = Balance.bal_s5 + x;

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
                            else if ((Balance.bal_c4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (account == 5)
                {
                    if (y == 00002)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s5 - x) >= limit)
                            {
                                Balance.bal_s5 = Balance.bal_s5 - x;
                                Balance.bal_s2 = Balance.bal_s2 + x;

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
                            else if ((Balance.bal_s5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c5 - x) >= limit)
                            {
                                Balance.bal_c5 = Balance.bal_c5 - x;
                                Balance.bal_s2 = Balance.bal_s2 + x;

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
                            else if ((Balance.bal_c5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00003)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s5 - x) >= limit)
                            {
                                Balance.bal_s5 = Balance.bal_s5 - x;
                                Balance.bal_s3 = Balance.bal_s3 + x;

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
                            else if ((Balance.bal_s5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c5 - x) >= limit)
                            {
                                Balance.bal_c5 = Balance.bal_c5 - x;
                                Balance.bal_s3 = Balance.bal_s3 + x;

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
                            else if ((Balance.bal_c5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00004)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s5 - x) >= limit)
                            {
                                Balance.bal_s5 = Balance.bal_s5 - x;
                                Balance.bal_s4 = Balance.bal_s4 + x;

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
                            else if ((Balance.bal_s5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c5 - x) >= limit)
                            {
                                Balance.bal_c5 = Balance.bal_c5 - x;
                                Balance.bal_s4 = Balance.bal_s4 + x;

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
                            else if ((Balance.bal_c5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00001)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s5 - x) >= limit)
                            {
                                Balance.bal_s5 = Balance.bal_s5 - x;
                                Balance.bal_s1 = Balance.bal_s1 + x;

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
                            else if ((Balance.bal_s5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c5 - x) >= limit)
                            {
                                Balance.bal_c5 = Balance.bal_c5 - x;
                                Balance.bal_s1 = Balance.bal_s1 + x;

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
                            else if ((Balance.bal_c5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        }

        private void btn4_2_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(lblInput.Text);
            int y = Int32.Parse(lblInput_2.Text);
            int limit = 500;

                if (account == 1)
                {
                    if (y == 00002)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s1 - x) >= limit)
                            {
                                Balance.bal_s1 = Balance.bal_s1 - x;
                                Balance.bal_c2 = Balance.bal_c2 + x;

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
                            else if ((Balance.bal_s1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c1 - x) >= limit)
                            {
                                Balance.bal_c1 = Balance.bal_c1 - x;
                                Balance.bal_c2 = Balance.bal_c2 + x;

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
                            else if ((Balance.bal_c1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00003)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s1 - x) >= limit)
                            {
                                Balance.bal_s1 = Balance.bal_s1 - x;
                                Balance.bal_c3 = Balance.bal_c3 + x;

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
                            else if ((Balance.bal_s1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c1 - x) >= limit)
                            {
                                Balance.bal_c1 = Balance.bal_c1 - x;
                                Balance.bal_c3 = Balance.bal_c3 + x;

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
                            else if ((Balance.bal_c1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00004)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s1 - x) >= limit)
                            {
                                Balance.bal_s1 = Balance.bal_s1 - x;
                                Balance.bal_c4 = Balance.bal_c4 + x;

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
                            else if ((Balance.bal_s1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c1 - x) >= limit)
                            {
                                Balance.bal_c1 = Balance.bal_c1 - x;
                                Balance.bal_c4 = Balance.bal_c4 + x;

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
                            else if ((Balance.bal_c1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00005)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s1 - x) >= limit)
                            {
                                Balance.bal_s1 = Balance.bal_s1 - x;
                                Balance.bal_c5 = Balance.bal_c5 + x;

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
                            else if ((Balance.bal_s1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c1 - x) >= limit)
                            {
                                Balance.bal_c1 = Balance.bal_c1 - x;
                                Balance.bal_c5 = Balance.bal_c5 + x;

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
                            else if ((Balance.bal_c1 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (account == 2)
                {
                    if (y == 00001)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s2 - x) >= limit)
                            {
                                Balance.bal_s2 = Balance.bal_s2 - x;
                                Balance.bal_c1 = Balance.bal_c1 + x;

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
                            else if ((Balance.bal_s2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c2 - x) >= limit)
                            {
                                Balance.bal_c2 = Balance.bal_c2 - x;
                                Balance.bal_c1 = Balance.bal_c1 + x;

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
                            else if ((Balance.bal_c2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00003)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s2 - x) >= limit)
                            {
                                Balance.bal_s2 = Balance.bal_s2 - x;
                                Balance.bal_c3 = Balance.bal_c3 + x;

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
                            else if ((Balance.bal_s2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c2 - x) >= limit)
                            {
                                Balance.bal_c2 = Balance.bal_c2 - x;
                                Balance.bal_c3 = Balance.bal_c3 + x;

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
                            else if ((Balance.bal_c2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00004)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s2 - x) >= limit)
                            {
                                Balance.bal_s2 = Balance.bal_s2 - x;
                                Balance.bal_c4 = Balance.bal_c4 + x;

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
                            else if ((Balance.bal_s2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c2 - x) >= limit)
                            {
                                Balance.bal_c2 = Balance.bal_c2 - x;
                                Balance.bal_c4 = Balance.bal_c4 + x;

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
                            else if ((Balance.bal_c2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00005)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s2 - x) >= limit)
                            {
                                Balance.bal_s2 = Balance.bal_s2 - x;
                                Balance.bal_c5 = Balance.bal_c5 + x;

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
                            else if ((Balance.bal_s2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c2 - x) >= limit)
                            {
                                Balance.bal_c2 = Balance.bal_c2 - x;
                                Balance.bal_c5 = Balance.bal_c5 + x;

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
                            else if ((Balance.bal_c2 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (account == 3)
                {
                    if (y == 00002)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s3 - x) >= limit)
                            {
                                Balance.bal_s3 = Balance.bal_s3 - x;
                                Balance.bal_c2 = Balance.bal_c2 + x;

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
                            else if ((Balance.bal_s3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c3 - x) >= limit)
                            {
                                Balance.bal_c3 = Balance.bal_c3 - x;
                                Balance.bal_c2 = Balance.bal_c2 + x;

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
                            else if ((Balance.bal_c3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00001)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s3 - x) >= limit)
                            {
                                Balance.bal_s3 = Balance.bal_s3 - x;
                                Balance.bal_c1 = Balance.bal_c1 + x;

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
                            else if ((Balance.bal_s3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c3 - x) >= limit)
                            {
                                Balance.bal_c3 = Balance.bal_c3 - x;
                                Balance.bal_c1 = Balance.bal_c1 + x;

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
                            else if ((Balance.bal_c3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00004)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s3 - x) >= limit)
                            {
                                Balance.bal_s3 = Balance.bal_s3 - x;
                                Balance.bal_c4 = Balance.bal_c4 + x;

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
                            else if ((Balance.bal_s3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c3 - x) >= limit)
                            {
                                Balance.bal_c3 = Balance.bal_c3 - x;
                                Balance.bal_c4 = Balance.bal_c4 + x;

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
                            else if ((Balance.bal_c3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00005)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s3 - x) >= limit)
                            {
                                Balance.bal_s3 = Balance.bal_s3 - x;
                                Balance.bal_c5 = Balance.bal_c5 + x;

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
                            else if ((Balance.bal_s3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c3 - x) >= limit)
                            {
                                Balance.bal_c3 = Balance.bal_c3 - x;
                                Balance.bal_c5 = Balance.bal_c5 + x;

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
                            else if ((Balance.bal_c3 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (account == 4)
                {
                    if (y == 00002)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s4 - x) >= limit)
                            {
                                Balance.bal_s4 = Balance.bal_s4 - x;
                                Balance.bal_c2 = Balance.bal_c2 + x;

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
                            else if ((Balance.bal_s4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c4 - x) >= limit)
                            {
                                Balance.bal_c4 = Balance.bal_c4 - x;
                                Balance.bal_c2 = Balance.bal_c2 + x;

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
                            else if ((Balance.bal_c4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00003)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s4 - x) >= limit)
                            {
                                Balance.bal_s4 = Balance.bal_s4 - x;
                                Balance.bal_c3 = Balance.bal_c3 + x;

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
                            else if ((Balance.bal_s4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c4 - x) >= limit)
                            {
                                Balance.bal_c4 = Balance.bal_c4 - x;
                                Balance.bal_c3 = Balance.bal_c3 + x;

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
                            else if ((Balance.bal_c4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00001)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s4 - x) >= limit)
                            {
                                Balance.bal_s4 = Balance.bal_s4 - x;
                                Balance.bal_c1 = Balance.bal_c1 + x;

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
                            else if ((Balance.bal_s4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c4 - x) >= limit)
                            {
                                Balance.bal_c4 = Balance.bal_c4 - x;
                                Balance.bal_c1 = Balance.bal_c1 + x;

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
                            else if ((Balance.bal_c4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00005)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s4 - x) >= limit)
                            {
                                Balance.bal_s4 = Balance.bal_s4 - x;
                                Balance.bal_c5 = Balance.bal_c5 + x;

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
                            else if ((Balance.bal_s4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c4 - x) >= limit)
                            {
                                Balance.bal_c4 = Balance.bal_c4 - x;
                                Balance.bal_c5 = Balance.bal_c5 + x;

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
                            else if ((Balance.bal_c4 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (account == 5)
                {
                    if (y == 00002)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s5 - x) >= limit)
                            {
                                Balance.bal_s5 = Balance.bal_s5 - x;
                                Balance.bal_c2 = Balance.bal_c2 + x;

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
                            else if ((Balance.bal_s5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c5 - x) >= limit)
                            {
                                Balance.bal_c5 = Balance.bal_c5 - x;
                                Balance.bal_c2 = Balance.bal_c2 + x;

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
                            else if ((Balance.bal_c5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00003)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s5 - x) >= limit)
                            {
                                Balance.bal_s5 = Balance.bal_s5 - x;
                                Balance.bal_c3 = Balance.bal_c3 + x;

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
                            else if ((Balance.bal_s5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c5 - x) >= limit)
                            {
                                Balance.bal_c5 = Balance.bal_c5 - x;
                                Balance.bal_c3 = Balance.bal_c3 + x;

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
                            else if ((Balance.bal_c5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00004)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s5 - x) >= limit)
                            {
                                Balance.bal_s5 = Balance.bal_s5 - x;
                                Balance.bal_c4 = Balance.bal_c4 + x;

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
                            else if ((Balance.bal_s5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c5 - x) >= limit)
                            {
                                Balance.bal_c5 = Balance.bal_c5 - x;
                                Balance.bal_c4 = Balance.bal_c4 + x;

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
                            else if ((Balance.bal_c5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if (y == 00001)
                    {
                        if (ch == 1)
                        {
                            if ((Balance.bal_s5 - x) >= limit)
                            {
                                Balance.bal_s5 = Balance.bal_s5 - x;
                                Balance.bal_c1 = Balance.bal_c1 + x;

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
                            else if ((Balance.bal_s5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        else if (ch == 2)
                        {
                            if ((Balance.bal_c5 - x) >= limit)
                            {
                                Balance.bal_c5 = Balance.bal_c5 - x;
                                Balance.bal_c1 = Balance.bal_c1 + x;

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
                            else if ((Balance.bal_c5 - x) < limit)
                            {
                                DialogResult iCont;

                                iCont = MessageBox.Show("Invalid Transaction.\n\nDo you want to try again?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        }

        private void lblEntAmt_Click(object sender, EventArgs e)
        {

        }

        private void lblInput_2_Click(object sender, EventArgs e)
        {

        }
    }
}
