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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            lblEnt.Visible = true;
            b2_ent.Visible = false;
            lblInput.Visible = false;
            btn1_0.Visible = true;
            btn3_0.Visible = true;
            lblnext.Visible = false;
            lblprev.Visible = false;
            lbluser1.Visible = false;
            lbluser2.Visible = false;
            lbluser3.Visible = false;
            lbluser4.Visible = false;
            lbluser5.Visible = false;
            lblinfo1.Visible = false;
            lblinfo2.Visible = false;
            lblinfo3.Visible = false;
            lblinfo4.Visible = false;
            lblinfo5.Visible = false;
            lblbal.Visible = false;
            lblexit.Visible = false;
        }

        private void b_ent_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblEnt.Visible = false;
            b2_ent.Visible = true;
            lblInput.Visible = true;
            btn1_0.Visible = false;
            btn3_0.Visible = false;
            btn1_5.Visible = false;
            btn3_5.Visible = false;
            btn1_4.Visible = false;
            btn3_4.Visible = false;
            btn1_3.Visible = false;
            btn3_3.Visible = false;
            btn1_2.Visible = false;
            btn3_2.Visible = false;
            btn1.Visible = true;
            btn3.Visible = true;
            lblnext.Visible = true;
            lblprev.Visible = true;
            lbluser1.Visible = true;
            lbluser2.Visible = false;
            lbluser3.Visible = false;
            lbluser4.Visible = false;
            lbluser5.Visible = false;
            lblinfo1.Visible = true;
            lblinfo2.Visible = false;
            lblinfo3.Visible = false;
            lblinfo4.Visible = false;
            lblinfo5.Visible = false;
            lblbal.Visible = true;
            lblexit.Visible = true;
            lblInput.Text = String.Empty;
            lblInput.Text = lblInput.Text + "Savings:  " + Balance.bal_s1 + "\nCheckings:  " + Balance.bal_c1;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblEnt.Visible = false;
            b2_ent.Visible = true;
            lblInput.Visible = true;
            btn1_0.Visible = false;
            btn3_0.Visible = false;
            btn1_5.Visible = false;
            btn3_5.Visible = false;
            btn1_4.Visible = false;
            btn3_4.Visible = false;
            btn1_3.Visible = false;
            btn3_3.Visible = false;
            btn1_2.Visible = true;
            btn3_2.Visible = true;
            btn1.Visible = false;
            btn3.Visible = false;
            lblnext.Visible = true;
            lblprev.Visible = true;
            lbluser1.Visible = false;
            lbluser2.Visible = true;
            lbluser3.Visible = false;
            lbluser4.Visible = false;
            lbluser5.Visible = false;
            lblinfo1.Visible = false;
            lblinfo2.Visible = true;
            lblinfo3.Visible = false;
            lblinfo4.Visible = false;
            lblinfo5.Visible = false;
            lblbal.Visible = true;
            lblexit.Visible = true;
            lblInput.Text = String.Empty;
            lblInput.Text = lblInput.Text + "Savings:  " + Balance.bal_s2 + "\nCheckings:  " + Balance.bal_c2;
        }

        private void btn3_2_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblEnt.Visible = false;
            b2_ent.Visible = true;
            lblInput.Visible = true;
            btn1_0.Visible = false;
            btn3_0.Visible = false;
            btn1_5.Visible = false;
            btn3_5.Visible = false;
            btn1_4.Visible = false;
            btn3_4.Visible = false;
            btn1_3.Visible = true;
            btn3_3.Visible = true;
            btn1_2.Visible = false;
            btn3_2.Visible = false;
            btn1.Visible = false;
            btn3.Visible = false;
            lblnext.Visible = true;
            lblprev.Visible = true;
            lbluser1.Visible = false;
            lbluser2.Visible = false;
            lbluser3.Visible = true;
            lbluser4.Visible = false;
            lbluser5.Visible = false;
            lblinfo1.Visible = false;
            lblinfo2.Visible = false;
            lblinfo3.Visible = true;
            lblinfo4.Visible = false;
            lblinfo5.Visible = false;
            lblbal.Visible = true;
            lblexit.Visible = true;
            lblInput.Text = String.Empty;
            lblInput.Text = lblInput.Text + "Savings:  " + Balance.bal_s3 + "\nCheckings:  " + Balance.bal_c3;
        }

        private void btn3_3_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblEnt.Visible = false;
            b2_ent.Visible = true;
            lblInput.Visible = true;
            btn1_0.Visible = false;
            btn3_0.Visible = false;
            btn1_5.Visible = false;
            btn3_5.Visible = false;
            btn1_4.Visible = true;
            btn3_4.Visible = true;
            btn1_3.Visible = false;
            btn3_3.Visible = false;
            btn1_2.Visible = false;
            btn3_2.Visible = false;
            btn1.Visible = false;
            btn3.Visible = false;
            lblnext.Visible = true;
            lblprev.Visible = true;
            lbluser1.Visible = false;
            lbluser2.Visible = false;
            lbluser3.Visible = false;
            lbluser4.Visible = true;
            lbluser5.Visible = false;
            lblinfo1.Visible = false;
            lblinfo2.Visible = false;
            lblinfo3.Visible = false;
            lblinfo4.Visible = true;
            lblinfo5.Visible = false;
            lblbal.Visible = true;
            lblexit.Visible = true;
            lblInput.Text = String.Empty;
            lblInput.Text = lblInput.Text + "Savings:  " + Balance.bal_s4 + "\nCheckings:  " + Balance.bal_c4;
        }

        private void btn3_4_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblEnt.Visible = false;
            b2_ent.Visible = true;
            lblInput.Visible = true;
            btn1_0.Visible = false;
            btn3_0.Visible = false;
            btn1_5.Visible = true;
            btn3_5.Visible = true;
            btn1_4.Visible = false;
            btn3_4.Visible = false;
            btn1_3.Visible = false;
            btn3_3.Visible = false;
            btn1_2.Visible = false;
            btn3_2.Visible = false;
            btn1.Visible = false;
            btn3.Visible = false;
            lblnext.Visible = true;
            lblprev.Visible = true;
            lbluser1.Visible = false;
            lbluser2.Visible = false;
            lbluser3.Visible = false;
            lbluser4.Visible = false;
            lbluser5.Visible = true;
            lblinfo1.Visible = false;
            lblinfo2.Visible = false;
            lblinfo3.Visible = false;
            lblinfo4.Visible = false;
            lblinfo5.Visible = true;
            lblbal.Visible = true;
            lblexit.Visible = true;
            lblInput.Text = String.Empty;
            lblInput.Text = lblInput.Text + "Savings:  " + Balance.bal_s5 + "\nCheckings:  " + Balance.bal_c5;
        }

        private void btn3_5_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblEnt.Visible = false;
            b2_ent.Visible = true;
            lblInput.Visible = true;
            btn1_0.Visible = false;
            btn3_0.Visible = false;
            btn1_5.Visible = false;
            btn3_5.Visible = false;
            btn1_4.Visible = false;
            btn3_4.Visible = false;
            btn1_3.Visible = false;
            btn3_3.Visible = false;
            btn1_2.Visible = false;
            btn3_2.Visible = false;
            btn1.Visible = true;
            btn3.Visible = true;
            lblnext.Visible = true;
            lblprev.Visible = true;
            lbluser1.Visible = true;
            lbluser2.Visible = false;
            lbluser3.Visible = false;
            lbluser4.Visible = false;
            lbluser5.Visible = false;
            lblinfo1.Visible = true;
            lblinfo2.Visible = false;
            lblinfo3.Visible = false;
            lblinfo4.Visible = false;
            lblinfo5.Visible = false;
            lblbal.Visible = true;
            lblexit.Visible = true;
            lblInput.Text = String.Empty;
            lblInput.Text = lblInput.Text + "Savings:  " + Balance.bal_s1 + "\nCheckings:  " + Balance.bal_c1;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblEnt.Visible = false;
            b2_ent.Visible = true;
            lblInput.Visible = true;
            btn1_0.Visible = false;
            btn3_0.Visible = false;
            btn1_5.Visible = true;
            btn3_5.Visible = true;
            btn1_4.Visible = false;
            btn3_4.Visible = false;
            btn1_3.Visible = false;
            btn3_3.Visible = false;
            btn1_2.Visible = false;
            btn3_2.Visible = false;
            btn1.Visible = false;
            btn3.Visible = false;
            lblnext.Visible = true;
            lblprev.Visible = true;
            lbluser1.Visible = false;
            lbluser2.Visible = false;
            lbluser3.Visible = false;
            lbluser4.Visible = false;
            lbluser5.Visible = true;
            lblinfo1.Visible = false;
            lblinfo2.Visible = false;
            lblinfo3.Visible = false;
            lblinfo4.Visible = false;
            lblinfo5.Visible = true;
            lblbal.Visible = true;
            lblexit.Visible = true;
            lblInput.Text = String.Empty;
            lblInput.Text = lblInput.Text + "Savings:  " + Balance.bal_s5 + "\nCheckings:  " + Balance.bal_c5;
        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblEnt.Visible = false;
            b2_ent.Visible = true;
            lblInput.Visible = true;
            btn1_0.Visible = false;
            btn3_0.Visible = false;
            btn1_5.Visible = false;
            btn3_5.Visible = false;
            btn1_4.Visible = false;
            btn3_4.Visible = false;
            btn1_3.Visible = false;
            btn3_3.Visible = false;
            btn1_2.Visible = false;
            btn3_2.Visible = false;
            btn1.Visible = true;
            btn3.Visible = true;
            lblnext.Visible = true;
            lblprev.Visible = true;
            lbluser1.Visible = true;
            lbluser2.Visible = false;
            lbluser3.Visible = false;
            lbluser4.Visible = false;
            lbluser5.Visible = false;
            lblinfo1.Visible = true;
            lblinfo2.Visible = false;
            lblinfo3.Visible = false;
            lblinfo4.Visible = false;
            lblinfo5.Visible = false;
            lblbal.Visible = true;
            lblexit.Visible = true;
            lblInput.Text = String.Empty;
            lblInput.Text = lblInput.Text + "Savings:  " + Balance.bal_s1 + "\nCheckings:  " + Balance.bal_c1;
        }

        private void btn1_3_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblEnt.Visible = false;
            b2_ent.Visible = true;
            lblInput.Visible = true;
            btn1_0.Visible = false;
            btn3_0.Visible = false;
            btn1_5.Visible = false;
            btn3_5.Visible = false;
            btn1_4.Visible = false;
            btn3_4.Visible = false;
            btn1_3.Visible = false;
            btn3_3.Visible = false;
            btn1_2.Visible = true;
            btn3_2.Visible = true;
            btn1.Visible = false;
            btn3.Visible = false;
            lblnext.Visible = true;
            lblprev.Visible = true;
            lbluser1.Visible = false;
            lbluser2.Visible = true;
            lbluser3.Visible = false;
            lbluser4.Visible = false;
            lbluser5.Visible = false;
            lblinfo1.Visible = false;
            lblinfo2.Visible = true;
            lblinfo3.Visible = false;
            lblinfo4.Visible = false;
            lblinfo5.Visible = false;
            lblbal.Visible = true;
            lblexit.Visible = true;
            lblInput.Text = String.Empty;
            lblInput.Text = lblInput.Text + "Savings:  " + Balance.bal_s2 + "\nCheckings:  " + Balance.bal_c2;
        }

        private void btn1_4_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblEnt.Visible = false;
            b2_ent.Visible = true;
            lblInput.Visible = true;
            btn1_0.Visible = false;
            btn3_0.Visible = false;
            btn1_5.Visible = false;
            btn3_5.Visible = false;
            btn1_4.Visible = false;
            btn3_4.Visible = false;
            btn1_3.Visible = true;
            btn3_3.Visible = true;
            btn1_2.Visible = false;
            btn3_2.Visible = false;
            btn1.Visible = false;
            btn3.Visible = false;
            lblnext.Visible = true;
            lblprev.Visible = true;
            lbluser1.Visible = false;
            lbluser2.Visible = false;
            lbluser3.Visible = true;
            lbluser4.Visible = false;
            lbluser5.Visible = false;
            lblinfo1.Visible = false;
            lblinfo2.Visible = false;
            lblinfo3.Visible = true;
            lblinfo4.Visible = false;
            lblinfo5.Visible = false;
            lblbal.Visible = true;
            lblexit.Visible = true;
            lblInput.Text = String.Empty;
            lblInput.Text = lblInput.Text + "Savings:  " + Balance.bal_s3 + "\nCheckings:  " + Balance.bal_c3;
        }

        private void btn1_5_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblEnt.Visible = false;
            b2_ent.Visible = true;
            lblInput.Visible = true;
            btn1_0.Visible = false;
            btn3_0.Visible = false;
            btn1_5.Visible = false;
            btn3_5.Visible = false;
            btn1_4.Visible = true;
            btn3_4.Visible = true;
            btn1_3.Visible = false;
            btn3_3.Visible = false;
            btn1_2.Visible = false;
            btn3_2.Visible = false;
            btn1.Visible = false;
            btn3.Visible = false;
            lblnext.Visible = true;
            lblprev.Visible = true;
            lbluser1.Visible = false;
            lbluser2.Visible = false;
            lbluser3.Visible = false;
            lbluser4.Visible = true;
            lbluser5.Visible = false;
            lblinfo1.Visible = false;
            lblinfo2.Visible = false;
            lblinfo3.Visible = false;
            lblinfo4.Visible = true;
            lblinfo5.Visible = false;
            lblbal.Visible = true;
            lblexit.Visible = true;
            lblInput.Text = String.Empty;
            lblInput.Text = lblInput.Text + "Savings:  " + Balance.bal_s4 + "\nCheckings:  " + Balance.bal_c4;
        }

        private void b2_ent_Click(object sender, EventArgs e)
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
    }
}
