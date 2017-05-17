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

namespace OWUL_Cast_Panel
{
    public partial class Form1 : Form
    {
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        Image ana = Properties.Resources.Icon_ana;
        Image bastion = Properties.Resources.Icon_bastion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadText(m1MessageBox, "Match1", "MessageBox");
            loadText(m1DivisionNumber, "Match1", "DivisionNumber");
            loadScore(m1t1Score, "Match1", "t1Score");
            loadText(m1t1Name, "Match1", "t1Name");
            loadText(m1t1p1Name, "Match1", "t1p1Name");
            loadText(m1t1p2Name, "Match1", "t1p2Name");
            loadText(m1t1p3Name, "Match1", "t1p3Name");
            loadText(m1t1p4Name, "Match1", "t1p4Name");
            loadText(m1t1p5Name, "Match1", "t1p5Name");
            loadText(m1t1p6Name, "Match1", "t1p6Name");
            loadText(m1t1p7Name, "Match1", "t1p7Name");
            loadText(m1t1p8Name, "Match1", "t1p8Name");
            loadScore(m1t2Score, "Match1", "t2Score");
            loadText(m1t2Name, "Match1", "t2Name");
            loadText(m1t2p1Name, "Match1", "t2p1Name");
            loadText(m1t2p2Name, "Match1", "t2p2Name");
            loadText(m1t2p3Name, "Match1", "t2p3Name");
            loadText(m1t2p4Name, "Match1", "t2p4Name");
            loadText(m1t2p5Name, "Match1", "t2p5Name");
            loadText(m1t2p6Name, "Match1", "t2p6Name");
            loadText(m1t2p7Name, "Match1", "t2p7Name");
            loadText(m1t2p8Name, "Match1", "t2p8Name");

            loadText(m2MessageBox, "Match2", "MessageBox");
            loadText(m2DivisionNumber, "Match2", "DivisionNumber");
            loadScore(m2t1Score, "Match2", "t1Score");
            loadText(m2t1Name, "Match2", "t1Name");
            loadText(m2t1p1Name, "Match2", "t1p1Name");
            loadText(m2t1p2Name, "Match2", "t1p2Name");
            loadText(m2t1p3Name, "Match2", "t1p3Name");
            loadText(m2t1p4Name, "Match2", "t1p4Name");
            loadText(m2t1p5Name, "Match2", "t1p5Name");
            loadText(m2t1p6Name, "Match2", "t1p6Name");
            loadText(m2t1p7Name, "Match2", "t1p7Name");
            loadText(m2t1p8Name, "Match2", "t1p8Name");
            loadScore(m2t2Score, "Match2", "t2Score");
            loadText(m2t2Name, "Match2", "t2Name");
            loadText(m2t2p1Name, "Match2", "t2p1Name");
            loadText(m2t2p2Name, "Match2", "t2p2Name");
            loadText(m2t2p3Name, "Match2", "t2p3Name");
            loadText(m2t2p4Name, "Match2", "t2p4Name");
            loadText(m2t2p5Name, "Match2", "t2p5Name");
            loadText(m2t2p6Name, "Match2", "t2p6Name");
            loadText(m2t2p7Name, "Match2", "t2p7Name");
            loadText(m2t2p8Name, "Match2", "t2p8Name");

        }

        private void m1SwapButton_Click(object sender, EventArgs e)
        {

            String temp;
            temp = m1t1Name.Text;
            m1t1Name.Text = m1t2Name.Text;
            m1t2Name.Text = temp;
            temp = "";
            decimal tempoary;
            tempoary = m1t1Score.Value;
            m1t1Score.Value = m1t2Score.Value;
            m1t2Score.Value = tempoary;
            tempoary = 0;

        }

        private void m2SwapButton_Click(object sender, EventArgs e)
        {

            String temp;
            temp = m2t1Name.Text;
            m2t1Name.Text = m2t2Name.Text;
            m2t2Name.Text = temp;
            temp = "";
            decimal tempoary;
            tempoary = m2t1Score.Value;
            m2t1Score.Value = m2t2Score.Value;
            m2t2Score.Value = tempoary;
            tempoary = 0;

        }

        private void m3SwapButton_Click(object sender, EventArgs e)
        {

            String temp;
            temp = m1t1Name.Text;
            m3t1Name.Text = m3t2Name.Text;
            m3t2Name.Text = temp;
            temp = "";
            decimal tempoary;
            tempoary = m3t1Score.Value;
            m3t1Score.Value = m3t2Score.Value;
            m3t2Score.Value = tempoary;
            tempoary = 0;

        }

        private void m1ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove all match data?", "Reset Match Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                resetText(m1MessageBox);
                resetText(m1DivisionNumber);

                resetScore(m1t1Score);
                resetText(m1t1Name);
                resetText(m1t1p1Name);
                resetText(m1t1p2Name);
                resetText(m1t1p3Name);
                resetText(m1t1p4Name);
                resetText(m1t1p5Name);
                resetText(m1t1p6Name);
                resetText(m1t1p7Name);
                resetText(m1t1p8Name);

                resetScore(m1t2Score);
                resetText(m1t2Name);
                resetText(m1t2p1Name);
                resetText(m1t2p2Name);
                resetText(m1t2p3Name);
                resetText(m1t2p4Name);
                resetText(m1t2p5Name);
                resetText(m1t2p6Name);
                resetText(m1t2p7Name);
                resetText(m1t2p8Name);

                resetHero(m1t1p1Hero);
                resetHero(m1t1p2Hero);
                resetHero(m1t1p3Hero);
                resetHero(m1t1p4Hero);
                resetHero(m1t1p5Hero);
                resetHero(m1t1p6Hero);
                resetHero(m1t1p7Hero);
                resetHero(m1t1p8Hero);

                resetHero(m1t2p1Hero);
                resetHero(m1t2p2Hero);
                resetHero(m1t2p3Hero);
                resetHero(m1t2p4Hero);
                resetHero(m1t2p5Hero);
                resetHero(m1t2p6Hero);
                resetHero(m1t2p7Hero);
                resetHero(m1t2p8Hero);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void m2ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove all match data?", "Reset Match Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                resetText(m2MessageBox);
                resetText(m2DivisionNumber);

                resetScore(m2t1Score);
                resetText(m2t1Name);
                resetText(m2t1p1Name);
                resetText(m2t1p2Name);
                resetText(m2t1p3Name);
                resetText(m2t1p4Name);
                resetText(m2t1p5Name);
                resetText(m2t1p6Name);
                resetText(m2t1p7Name);
                resetText(m2t1p8Name);

                resetScore(m2t2Score);
                resetText(m2t2Name);
                resetText(m2t2p1Name);
                resetText(m2t2p2Name);
                resetText(m2t2p3Name);
                resetText(m2t2p4Name);
                resetText(m2t2p5Name);
                resetText(m2t2p6Name);
                resetText(m2t2p7Name);
                resetText(m2t2p8Name);

                resetHero(m2t1p1Hero);
                resetHero(m2t1p2Hero);
                resetHero(m2t1p3Hero);
                resetHero(m2t1p4Hero);
                resetHero(m2t1p5Hero);
                resetHero(m2t1p6Hero);
                resetHero(m2t1p7Hero);
                resetHero(m2t1p8Hero);

                resetHero(m2t2p1Hero);
                resetHero(m2t2p2Hero);
                resetHero(m2t2p3Hero);
                resetHero(m2t2p4Hero);
                resetHero(m2t2p5Hero);
                resetHero(m2t2p6Hero);
                resetHero(m2t2p7Hero);
                resetHero(m2t2p8Hero);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void m3ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove all match data?", "Reset Match Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                resetText(m3MessageBox);
                resetText(m3DivisionNumber);

                resetScore(m3t1Score);
                resetText(m3t1Name);
                resetText(m3t1p1Name);
                resetText(m3t1p2Name);
                resetText(m3t1p3Name);
                resetText(m3t1p4Name);
                resetText(m3t1p5Name);
                resetText(m3t1p6Name);
                resetText(m3t1p7Name);
                resetText(m3t1p8Name);

                resetScore(m3t2Score);
                resetText(m3t2Name);
                resetText(m3t2p1Name);
                resetText(m3t2p2Name);
                resetText(m3t2p3Name);
                resetText(m3t2p4Name);
                resetText(m3t2p5Name);
                resetText(m3t2p6Name);
                resetText(m3t2p7Name);
                resetText(m3t2p8Name);

                resetHero(m3t1p1Hero);
                resetHero(m3t1p2Hero);
                resetHero(m3t1p3Hero);
                resetHero(m3t1p4Hero);
                resetHero(m3t1p5Hero);
                resetHero(m3t1p6Hero);
                resetHero(m3t1p7Hero);
                resetHero(m3t1p8Hero);

                resetHero(m3t2p1Hero);
                resetHero(m3t2p2Hero);
                resetHero(m3t2p3Hero);
                resetHero(m3t2p4Hero);
                resetHero(m3t2p5Hero);
                resetHero(m3t2p6Hero);
                resetHero(m3t2p7Hero);
                resetHero(m3t2p8Hero);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void m1UpdateButton_Click(object sender, EventArgs e)
        {

            updateText(m1MessageBox, "Match1", "MessageBox");
            updateText(m1DivisionNumber, "Match1", "DivisionNumber");

            updateScore(m1t1Score, "Match1", "t1Score");
            updateText(m1t1Name, "Match1", "t1Name");
            updateText(m1t1p1Name, "Match1", "t1p1Name");
            updateText(m1t1p2Name, "Match1", "t1p2Name");
            updateText(m1t1p3Name, "Match1", "t1p3Name");
            updateText(m1t1p4Name, "Match1", "t1p4Name");
            updateText(m1t1p5Name, "Match1", "t1p5Name");
            updateText(m1t1p6Name, "Match1", "t1p6Name");
            updateText(m1t1p7Name, "Match1", "t1p7Name");
            updateText(m1t1p8Name, "Match1", "t1p8Name");

            updateScore(m1t2Score, "Match1", "t2Score");
            updateText(m1t2Name, "Match1", "t2Name");
            updateText(m1t2p1Name, "Match1", "t2p1Name");
            updateText(m1t2p2Name, "Match1", "t2p2Name");
            updateText(m1t2p3Name, "Match1", "t2p3Name");
            updateText(m1t2p4Name, "Match1", "t2p4Name");
            updateText(m1t2p5Name, "Match1", "t2p5Name");
            updateText(m1t2p6Name, "Match1", "t2p6Name");
            updateText(m1t2p7Name, "Match1", "t2p7Name");
            updateText(m1t2p8Name, "Match1", "t2p8Name");

            updateHero(m1t1p1Hero, "Match1", "t1p1Hero");
            updateHero(m1t1p2Hero, "Match1", "t1p2Hero");
            updateHero(m1t1p3Hero, "Match1", "t1p3Hero");
            updateHero(m1t1p4Hero, "Match1", "t1p4Hero");
            updateHero(m1t1p5Hero, "Match1", "t1p5Hero");
            updateHero(m1t1p6Hero, "Match1", "t1p6Hero");
            updateHero(m1t1p7Hero, "Match1", "t1p7Hero");
            updateHero(m1t1p8Hero, "Match1", "t1p8Hero");

            updateHero(m1t2p1Hero, "Match1", "t2p1Hero");
            updateHero(m1t2p2Hero, "Match1", "t2p2Hero");
            updateHero(m1t2p3Hero, "Match1", "t2p3Hero");
            updateHero(m1t2p4Hero, "Match1", "t2p4Hero");
            updateHero(m1t2p5Hero, "Match1", "t2p5Hero");
            updateHero(m1t2p6Hero, "Match1", "t2p6Hero");
            updateHero(m1t2p7Hero, "Match1", "t2p7Hero");
            updateHero(m1t2p8Hero, "Match1", "t2p8Hero");


            if (m1currentCheck.Checked == true)
            {
                updateText(m1MessageBox, "Current", "MessageBox");
                updateText(m1DivisionNumber, "Current", "DivisionNumber");

                updateScore(m1t1Score, "Current", "t1Score");
                updateText(m1t1Name, "Current", "t1Name");
                updateText(m1t1p1Name, "Current", "t1p1Name");
                updateText(m1t1p2Name, "Current", "t1p2Name");
                updateText(m1t1p3Name, "Current", "t1p3Name");
                updateText(m1t1p4Name, "Current", "t1p4Name");
                updateText(m1t1p5Name, "Current", "t1p5Name");
                updateText(m1t1p6Name, "Current", "t1p6Name");
                updateText(m1t1p7Name, "Current", "t1p7Name");
                updateText(m1t1p8Name, "Current", "t1p8Name");

                updateScore(m1t2Score, "Current", "t2Score");
                updateText(m1t2Name, "Current", "t2Name");
                updateText(m1t2p1Name, "Current", "t2p1Name");
                updateText(m1t2p2Name, "Current", "t2p2Name");
                updateText(m1t2p3Name, "Current", "t2p3Name");
                updateText(m1t2p4Name, "Current", "t2p4Name");
                updateText(m1t2p5Name, "Current", "t2p5Name");
                updateText(m1t2p6Name, "Current", "t2p6Name");
                updateText(m1t2p7Name, "Current", "t2p7Name");
                updateText(m1t2p8Name, "Current", "t2p8Name");

                updateHero(m1t1p1Hero, "Current", "t1p1Hero");
                updateHero(m1t1p2Hero, "Current", "t1p2Hero");
                updateHero(m1t1p3Hero, "Current", "t1p3Hero");
                updateHero(m1t1p4Hero, "Current", "t1p4Hero");
                updateHero(m1t1p5Hero, "Current", "t1p5Hero");
                updateHero(m1t1p6Hero, "Current", "t1p6Hero");
                updateHero(m1t1p7Hero, "Current", "t1p7Hero");
                updateHero(m1t1p8Hero, "Current", "t1p8Hero");

                updateHero(m1t2p1Hero, "Current", "t2p1Hero");
                updateHero(m1t2p2Hero, "Current", "t2p2Hero");
                updateHero(m1t2p3Hero, "Current", "t2p3Hero");
                updateHero(m1t2p4Hero, "Current", "t2p4Hero");
                updateHero(m1t2p5Hero, "Current", "t2p5Hero");
                updateHero(m1t2p6Hero, "Current", "t2p6Hero");
                updateHero(m1t2p7Hero, "Current", "t2p7Hero");
                updateHero(m1t2p8Hero, "Current", "t2p8Hero");
            }
        }

        private void m2UpdateButton_Click(object sender, EventArgs e)
        {

            updateText(m2MessageBox, "Match2", "MessageBox");
            updateText(m2DivisionNumber, "Match2", "DivisionNumber");

            updateScore(m2t1Score, "Match2", "t1Score");
            updateText(m2t1Name, "Match2", "t1Name");
            updateText(m2t1p1Name, "Match2", "t1p1Name");
            updateText(m2t1p2Name, "Match2", "t1p2Name");
            updateText(m2t1p3Name, "Match2", "t1p3Name");
            updateText(m2t1p4Name, "Match2", "t1p4Name");
            updateText(m2t1p5Name, "Match2", "t1p5Name");
            updateText(m2t1p6Name, "Match2", "t1p6Name");
            updateText(m2t1p7Name, "Match2", "t1p7Name");
            updateText(m2t1p8Name, "Match2", "t1p8Name");

            updateScore(m2t2Score, "Match2", "t2Score");
            updateText(m2t2Name, "Match2", "t2Name");
            updateText(m2t2p1Name, "Match2", "t2p1Name");
            updateText(m2t2p2Name, "Match2", "t2p2Name");
            updateText(m2t2p3Name, "Match2", "t2p3Name");
            updateText(m2t2p4Name, "Match2", "t2p4Name");
            updateText(m2t2p5Name, "Match2", "t2p5Name");
            updateText(m2t2p6Name, "Match2", "t2p6Name");
            updateText(m2t2p7Name, "Match2", "t2p7Name");
            updateText(m2t2p8Name, "Match2", "t2p8Name");

            updateHero(m2t1p1Hero, "Match2", "t1p1Hero");
            updateHero(m2t1p2Hero, "Match2", "t1p2Hero");
            updateHero(m2t1p3Hero, "Match2", "t1p3Hero");
            updateHero(m2t1p4Hero, "Match2", "t1p4Hero");
            updateHero(m2t1p5Hero, "Match2", "t1p5Hero");
            updateHero(m2t1p6Hero, "Match2", "t1p6Hero");
            updateHero(m2t1p7Hero, "Match2", "t1p7Hero");
            updateHero(m2t1p8Hero, "Match2", "t1p8Hero");

            updateHero(m2t2p1Hero, "Match2", "t2p1Hero");
            updateHero(m2t2p2Hero, "Match2", "t2p2Hero");
            updateHero(m2t2p3Hero, "Match2", "t2p3Hero");
            updateHero(m2t2p4Hero, "Match2", "t2p4Hero");
            updateHero(m2t2p5Hero, "Match2", "t2p5Hero");
            updateHero(m2t2p6Hero, "Match2", "t2p6Hero");
            updateHero(m2t2p7Hero, "Match2", "t2p7Hero");
            updateHero(m2t2p8Hero, "Match2", "t2p8Hero");


            if (m2currentCheck.Checked == true)
            {
                updateText(m2MessageBox, "Current", "MessageBox");
                updateText(m2DivisionNumber, "Current", "DivisionNumber");

                updateScore(m2t1Score, "Current", "t1Score");
                updateText(m2t1Name, "Current", "t1Name");
                updateText(m2t1p1Name, "Current", "t1p1Name");
                updateText(m2t1p2Name, "Current", "t1p2Name");
                updateText(m2t1p3Name, "Current", "t1p3Name");
                updateText(m2t1p4Name, "Current", "t1p4Name");
                updateText(m2t1p5Name, "Current", "t1p5Name");
                updateText(m2t1p6Name, "Current", "t1p6Name");
                updateText(m2t1p7Name, "Current", "t1p7Name");
                updateText(m2t1p8Name, "Current", "t1p8Name");

                updateScore(m2t2Score, "Current", "t2Score");
                updateText(m2t2Name, "Current", "t2Name");
                updateText(m2t2p1Name, "Current", "t2p1Name");
                updateText(m2t2p2Name, "Current", "t2p2Name");
                updateText(m2t2p3Name, "Current", "t2p3Name");
                updateText(m2t2p4Name, "Current", "t2p4Name");
                updateText(m2t2p5Name, "Current", "t2p5Name");
                updateText(m2t2p6Name, "Current", "t2p6Name");
                updateText(m2t2p7Name, "Current", "t2p7Name");
                updateText(m2t2p8Name, "Current", "t2p8Name");

                updateHero(m2t1p1Hero, "Current", "t1p1Hero");
                updateHero(m2t1p2Hero, "Current", "t1p2Hero");
                updateHero(m2t1p3Hero, "Current", "t1p3Hero");
                updateHero(m2t1p4Hero, "Current", "t1p4Hero");
                updateHero(m2t1p5Hero, "Current", "t1p5Hero");
                updateHero(m2t1p6Hero, "Current", "t1p6Hero");
                updateHero(m2t1p7Hero, "Current", "t1p7Hero");
                updateHero(m2t1p8Hero, "Current", "t1p8Hero");

                updateHero(m2t2p1Hero, "Current", "t2p1Hero");
                updateHero(m2t2p2Hero, "Current", "t2p2Hero");
                updateHero(m2t2p3Hero, "Current", "t2p3Hero");
                updateHero(m2t2p4Hero, "Current", "t2p4Hero");
                updateHero(m2t2p5Hero, "Current", "t2p5Hero");
                updateHero(m2t2p6Hero, "Current", "t2p6Hero");
                updateHero(m2t2p7Hero, "Current", "t2p7Hero");
                updateHero(m2t2p8Hero, "Current", "t2p8Hero");
            }
        }

        private void m3UpdateButton_Click(object sender, EventArgs e)
        {

            updateText(m3MessageBox, "Match3", "MessageBox");
            updateText(m3DivisionNumber, "Match3", "DivisionNumber");

            updateScore(m3t1Score, "Match3", "t1Score");
            updateText(m3t1Name, "Match3", "t1Name");
            updateText(m3t1p1Name, "Match3", "t1p1Name");
            updateText(m3t1p2Name, "Match3", "t1p2Name");
            updateText(m3t1p3Name, "Match3", "t1p3Name");
            updateText(m3t1p4Name, "Match3", "t1p4Name");
            updateText(m3t1p5Name, "Match3", "t1p5Name");
            updateText(m3t1p6Name, "Match3", "t1p6Name");
            updateText(m3t1p7Name, "Match3", "t1p7Name");
            updateText(m3t1p8Name, "Match3", "t1p8Name");

            updateScore(m3t2Score, "Match3", "t2Score");
            updateText(m3t2Name, "Match3", "t2Name");
            updateText(m3t2p1Name, "Match3", "t2p1Name");
            updateText(m3t2p2Name, "Match3", "t2p2Name");
            updateText(m3t2p3Name, "Match3", "t2p3Name");
            updateText(m3t2p4Name, "Match3", "t2p4Name");
            updateText(m3t2p5Name, "Match3", "t2p5Name");
            updateText(m3t2p6Name, "Match3", "t2p6Name");
            updateText(m3t2p7Name, "Match3", "t2p7Name");
            updateText(m3t2p8Name, "Match3", "t2p8Name");

            updateHero(m3t1p1Hero, "Match3", "t1p1Hero");
            updateHero(m3t1p2Hero, "Match3", "t1p2Hero");
            updateHero(m3t1p3Hero, "Match3", "t1p3Hero");
            updateHero(m3t1p4Hero, "Match3", "t1p4Hero");
            updateHero(m3t1p5Hero, "Match3", "t1p5Hero");
            updateHero(m3t1p6Hero, "Match3", "t1p6Hero");
            updateHero(m3t1p7Hero, "Match3", "t1p7Hero");
            updateHero(m3t1p8Hero, "Match3", "t1p8Hero");

            updateHero(m3t2p1Hero, "Match3", "t2p1Hero");
            updateHero(m3t2p2Hero, "Match3", "t2p2Hero");
            updateHero(m3t2p3Hero, "Match3", "t2p3Hero");
            updateHero(m3t2p4Hero, "Match3", "t2p4Hero");
            updateHero(m3t2p5Hero, "Match3", "t2p5Hero");
            updateHero(m3t2p6Hero, "Match3", "t2p6Hero");
            updateHero(m3t2p7Hero, "Match3", "t2p7Hero");
            updateHero(m3t2p8Hero, "Match3", "t2p8Hero");


            if (m3currentCheck.Checked == true)
            {
                updateText(m3MessageBox, "Current", "MessageBox");
                updateText(m3DivisionNumber, "Current", "DivisionNumber");

                updateScore(m3t1Score, "Current", "t1Score");
                updateText(m3t1Name, "Current", "t1Name");
                updateText(m3t1p1Name, "Current", "t1p1Name");
                updateText(m3t1p2Name, "Current", "t1p2Name");
                updateText(m3t1p3Name, "Current", "t1p3Name");
                updateText(m3t1p4Name, "Current", "t1p4Name");
                updateText(m3t1p5Name, "Current", "t1p5Name");
                updateText(m3t1p6Name, "Current", "t1p6Name");
                updateText(m3t1p7Name, "Current", "t1p7Name");
                updateText(m3t1p8Name, "Current", "t1p8Name");

                updateScore(m3t2Score, "Current", "t2Score");
                updateText(m3t2Name, "Current", "t2Name");
                updateText(m3t2p1Name, "Current", "t2p1Name");
                updateText(m3t2p2Name, "Current", "t2p2Name");
                updateText(m3t2p3Name, "Current", "t2p3Name");
                updateText(m3t2p4Name, "Current", "t2p4Name");
                updateText(m3t2p5Name, "Current", "t2p5Name");
                updateText(m3t2p6Name, "Current", "t2p6Name");
                updateText(m3t2p7Name, "Current", "t2p7Name");
                updateText(m3t2p8Name, "Current", "t2p8Name");

                updateHero(m3t1p1Hero, "Current", "t1p1Hero");
                updateHero(m3t1p2Hero, "Current", "t1p2Hero");
                updateHero(m3t1p3Hero, "Current", "t1p3Hero");
                updateHero(m3t1p4Hero, "Current", "t1p4Hero");
                updateHero(m3t1p5Hero, "Current", "t1p5Hero");
                updateHero(m3t1p6Hero, "Current", "t1p6Hero");
                updateHero(m3t1p7Hero, "Current", "t1p7Hero");
                updateHero(m3t1p8Hero, "Current", "t1p8Hero");

                updateHero(m3t2p1Hero, "Current", "t2p1Hero");
                updateHero(m3t2p2Hero, "Current", "t2p2Hero");
                updateHero(m3t2p3Hero, "Current", "t2p3Hero");
                updateHero(m3t2p4Hero, "Current", "t2p4Hero");
                updateHero(m3t2p5Hero, "Current", "t2p5Hero");
                updateHero(m3t2p6Hero, "Current", "t2p6Hero");
                updateHero(m3t2p7Hero, "Current", "t2p7Hero");
                updateHero(m3t2p8Hero, "Current", "t2p8Hero");
            }
        }

        private void updateText(TextBox field, String folder, String file)
        {
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(field.Text);
            }
        }

        private void updateScore(NumericUpDown field, String folder, String file)
        {
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(field.Value.ToString());
            }
        }

        private void updateHero(ComboBox field, String folder, String file)
        {
            

            if (field.SelectedItem != null)
            {
                if (field.SelectedItem.ToString().Equals("Ana"))
                {
                    Properties.Resources.Icon_ana.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Bastion"))
                {
                    Properties.Resources.Icon_bastion.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("D.Va"))
                {
                    Properties.Resources.Icon_dva.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Genji"))
                {
                    Properties.Resources.Icon_genji.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Hanzo"))
                {
                    Properties.Resources.Icon_hanzo.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Junkrat"))
                {
                    Properties.Resources.Icon_junkrat.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Lúcio"))
                {
                    Properties.Resources.Icon_Lucio.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("McCree"))
                {
                    Properties.Resources.Icon_mccree.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Mei"))
                {
                    Properties.Resources.Icon_mei.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Mercy"))
                {
                    Properties.Resources.Icon_mercy.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Orisa"))
                {
                    Properties.Resources.Icon_orisa.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Pharah"))
                {
                    Properties.Resources.Icon_pharah.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Reaper"))
                {
                    Properties.Resources.Icon_reaper.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Reinhardt"))
                {
                    Properties.Resources.Icon_reinhardt.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Roadhog"))
                {
                    Properties.Resources.Icon_roadhog.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Soldier: 76"))
                {
                    Properties.Resources.Icon_soldier76.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Sombra"))
                {
                    Properties.Resources.Icon_sombra.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Symmetra"))
                {
                    Properties.Resources.Icon_symmetra.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Torbjörn"))
                {
                    Properties.Resources.Icon_torbjorn.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Tracer"))
                {
                    Properties.Resources.Icon_tracer.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Widowmaker"))
                {
                    Properties.Resources.Icon_widowmaker.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Winston"))
                {
                    Properties.Resources.Icon_winston.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Zarya"))
                {
                    Properties.Resources.Icon_zarya.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Zenyatta"))
                {
                    Properties.Resources.Icon_zenyatta.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else
                {
                    Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + ".png");
                }
            }
            else
            {
                Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + ".png");
            }

        }

        private void loadText(TextBox field, String folder, String file)
        {
            string loadingText = File.ReadAllText(path + "\\" + folder + "\\" + file + ".txt");

            field.Text = loadingText;


        }

        private void loadScore(NumericUpDown field, String folder, String file)
        {
            string loadingText = File.ReadAllText(path + "\\" + folder + "\\" + file + ".txt");
            decimal number;
            Decimal.TryParse(loadingText, out number);
            field.Value = number; 


        }

        private void resetText(TextBox field)
        {
            field.Text = "";
        }

        private void resetScore(NumericUpDown field)
        {
            field.Value = 0;
        }

        private void resetHero(ComboBox field)
        {
            field.SelectedIndex = 0;
        }

        /*private void loadHero(ComboBox field, String folder, String file)
        {
           
        } */

    }
}
