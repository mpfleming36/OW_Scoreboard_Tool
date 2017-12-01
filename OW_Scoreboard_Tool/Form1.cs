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

namespace OW_Scoreboard_Tool
{
    public partial class Form1 : Form
    {
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

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
            loadText(m1t1SR, "Match1", "t1SR");
            loadText(m1t1p1Name, "Match1", "t1p1Name");
            loadText(m1t1p2Name, "Match1", "t1p2Name");
            loadText(m1t1p3Name, "Match1", "t1p3Name");
            loadText(m1t1p4Name, "Match1", "t1p4Name");
            loadText(m1t1p5Name, "Match1", "t1p5Name");
            loadText(m1t1p6Name, "Match1", "t1p6Name");
            loadScore(m1t2Score, "Match1", "t2Score");
            loadText(m1t2Name, "Match1", "t2Name");
            loadText(m1t2SR, "Match1", "t2SR");
            loadText(m1t2p1Name, "Match1", "t2p1Name");
            loadText(m1t2p2Name, "Match1", "t2p2Name");
            loadText(m1t2p3Name, "Match1", "t2p3Name");
            loadText(m1t2p4Name, "Match1", "t2p4Name");
            loadText(m1t2p5Name, "Match1", "t2p5Name");
            loadText(m1t2p6Name, "Match1", "t2p6Name");

            loadText(m2MessageBox, "Match2", "MessageBox");
            loadText(m2DivisionNumber, "Match2", "DivisionNumber");
            loadScore(m2t1Score, "Match2", "t1Score");
            loadText(m2t1Name, "Match2", "t1Name");
            loadText(m2t1SR, "Match2", "t1SR");
            loadText(m2t1p1Name, "Match2", "t1p1Name");
            loadText(m2t1p2Name, "Match2", "t1p2Name");
            loadText(m2t1p3Name, "Match2", "t1p3Name");
            loadText(m2t1p4Name, "Match2", "t1p4Name");
            loadText(m2t1p5Name, "Match2", "t1p5Name");
            loadText(m2t1p6Name, "Match2", "t1p6Name");
            loadScore(m2t2Score, "Match2", "t2Score");
            loadText(m2t2Name, "Match2", "t2Name");
            loadText(m2t2SR, "Match2", "t2SR");
            loadText(m2t2p1Name, "Match2", "t2p1Name");
            loadText(m2t2p2Name, "Match2", "t2p2Name");
            loadText(m2t2p3Name, "Match2", "t2p3Name");
            loadText(m2t2p4Name, "Match2", "t2p4Name");
            loadText(m2t2p5Name, "Match2", "t2p5Name");
            loadText(m2t2p6Name, "Match2", "t2p6Name");

            loadText(m3MessageBox, "Match3", "MessageBox");
            loadText(m3DivisionNumber, "Match3", "DivisionNumber");
            loadScore(m3t1Score, "Match3", "t1Score");
            loadText(m3t1Name, "Match3", "t1Name");
            loadText(m3t1SR, "Match3", "t1SR");
            loadText(m3t1p1Name, "Match3", "t1p1Name");
            loadText(m3t1p2Name, "Match3", "t1p2Name");
            loadText(m3t1p3Name, "Match3", "t1p3Name");
            loadText(m3t1p4Name, "Match3", "t1p4Name");
            loadText(m3t1p5Name, "Match3", "t1p5Name");
            loadText(m3t1p6Name, "Match3", "t1p6Name");
            loadScore(m3t2Score, "Match3", "t2Score");
            loadText(m3t2Name, "Match3", "t2Name");
            loadText(m3t2SR, "Match3", "t2SR");
            loadText(m3t2p1Name, "Match3", "t2p1Name");
            loadText(m3t2p2Name, "Match3", "t2p2Name");
            loadText(m3t2p3Name, "Match3", "t2p3Name");
            loadText(m3t2p4Name, "Match3", "t2p4Name");
            loadText(m3t2p5Name, "Match3", "t2p5Name");
            loadText(m3t2p6Name, "Match3", "t2p6Name");

            loadText(message, "General", "message");
            loadText(host, "General", "host");
            loadText(analyst1, "General", "analyst1");
            loadText(analyst2, "General", "analyst2");
            loadText(caster1, "General", "caster1");
            loadText(caster2, "General", "caster2");
            loadText(utility1, "General", "utility1");
            loadText(utility2, "General", "utility2");
            loadText(utility3, "General", "utility3");
            loadText(utility4, "General", "utility4");
            loadText(utility5, "General", "utility5");
            loadText(utility6, "General", "utility6");
            loadText(utility7, "General", "utility7");
            loadText(utility8, "General", "utility8");

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

            tempoary = m1m1t1Score.Value;
            m1m1t1Score.Value = m1m1t2Score.Value;
            m1m1t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m1m2t1Score.Value;
            m1m2t1Score.Value = m1m2t2Score.Value;
            m1m2t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m1m3t1Score.Value;
            m1m3t1Score.Value = m1m3t2Score.Value;
            m1m3t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m1m4t1Score.Value;
            m1m4t1Score.Value = m1m4t2Score.Value;
            m1m4t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m1m5t1Score.Value;
            m1m5t1Score.Value = m1m5t2Score.Value;
            m1m5t2Score.Value = tempoary;
            tempoary = 0;

            temp = m1t1SR.Text;
            m1t1SR.Text = m1t2SR.Text;
            m1t2SR.Text = temp;
            temp = "";

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

            tempoary = m2m1t1Score.Value;
            m2m1t1Score.Value = m2m1t2Score.Value;
            m2m1t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m2m2t1Score.Value;
            m2m2t1Score.Value = m2m2t2Score.Value;
            m2m2t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m2m3t1Score.Value;
            m2m3t1Score.Value = m2m3t2Score.Value;
            m2m3t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m2m4t1Score.Value;
            m2m4t1Score.Value = m2m4t2Score.Value;
            m2m4t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m2m5t1Score.Value;
            m2m5t1Score.Value = m2m5t2Score.Value;
            m2m5t2Score.Value = tempoary;
            tempoary = 0;

            temp = m2t1SR.Text;
            m2t1SR.Text = m2t2SR.Text;
            m2t2SR.Text = temp;
            temp = "";

        }

        private void m3SwapButton_Click(object sender, EventArgs e)
        {

            String temp;
            temp = m3t1Name.Text;
            m3t1Name.Text = m3t2Name.Text;
            m3t2Name.Text = temp;
            temp = "";
            decimal tempoary;
            tempoary = m3t1Score.Value;
            m3t1Score.Value = m3t2Score.Value;
            m3t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m3m1t1Score.Value;
            m3m1t1Score.Value = m3m1t2Score.Value;
            m3m1t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m3m2t1Score.Value;
            m3m2t1Score.Value = m3m2t2Score.Value;
            m3m2t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m3m3t1Score.Value;
            m3m3t1Score.Value = m3m3t2Score.Value;
            m3m3t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m3m4t1Score.Value;
            m3m4t1Score.Value = m3m4t2Score.Value;
            m3m4t2Score.Value = tempoary;
            tempoary = 0;

            tempoary = m3m5t1Score.Value;
            m3m5t1Score.Value = m3m5t2Score.Value;
            m3m5t2Score.Value = tempoary;
            tempoary = 0;

            temp = m3t1SR.Text;
            m3t1SR.Text = m3t2SR.Text;
            m3t2SR.Text = temp;
            temp = "";

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
                resetText(m1t1SR);
                resetText(m1t1p1Name);
                resetText(m1t1p2Name);
                resetText(m1t1p3Name);
                resetText(m1t1p4Name);
                resetText(m1t1p5Name);
                resetText(m1t1p6Name);

                resetScore(m1t2Score);
                resetText(m1t2Name);
                resetText(m1t2SR);
                resetText(m1t2p1Name);
                resetText(m1t2p2Name);
                resetText(m1t2p3Name);
                resetText(m1t2p4Name);
                resetText(m1t2p5Name);
                resetText(m1t2p6Name);

                resetHero(m1t1p1Hero);
                resetHero(m1t1p2Hero);
                resetHero(m1t1p3Hero);
                resetHero(m1t1p4Hero);
                resetHero(m1t1p5Hero);
                resetHero(m1t1p6Hero);

                resetHero(m1t2p1Hero);
                resetHero(m1t2p2Hero);
                resetHero(m1t2p3Hero);
                resetHero(m1t2p4Hero);
                resetHero(m1t2p5Hero);
                resetHero(m1t2p6Hero);

                resetRole(m1t1p1Role);
                resetRole(m1t1p2Role);
                resetRole(m1t1p3Role);
                resetRole(m1t1p4Role);
                resetRole(m1t1p5Role);
                resetRole(m1t1p6Role);

                resetRole(m1t2p1Role);
                resetRole(m1t2p2Role);
                resetRole(m1t2p3Role);
                resetRole(m1t2p4Role);
                resetRole(m1t2p5Role);
                resetRole(m1t2p6Role);

                resetSide(m1Neutral);

                resetMap(m1m1Map);
                resetMap(m1m2Map);
                resetMap(m1m3Map);
                resetMap(m1m4Map);
                resetMap(m1m5Map);

                resetScore(m1m1t1Score);
                resetScore(m1m1t2Score);
                resetScore(m1m2t1Score);
                resetScore(m1m2t2Score);
                resetScore(m1m3t1Score);
                resetScore(m1m3t2Score);
                resetScore(m1m4t1Score);
                resetScore(m1m4t2Score);
                resetScore(m1m5t1Score);
                resetScore(m1m5t2Score);
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
                resetText(m2t1SR);
                resetText(m2t1p1Name);
                resetText(m2t1p2Name);
                resetText(m2t1p3Name);
                resetText(m2t1p4Name);
                resetText(m2t1p5Name);
                resetText(m2t1p6Name);

                resetScore(m2t2Score);
                resetText(m2t2Name);
                resetText(m2t2SR);
                resetText(m2t2p1Name);
                resetText(m2t2p2Name);
                resetText(m2t2p3Name);
                resetText(m2t2p4Name);
                resetText(m2t2p5Name);
                resetText(m2t2p6Name);

                resetHero(m2t1p1Hero);
                resetHero(m2t1p2Hero);
                resetHero(m2t1p3Hero);
                resetHero(m2t1p4Hero);
                resetHero(m2t1p5Hero);
                resetHero(m2t1p6Hero);

                resetHero(m2t2p1Hero);
                resetHero(m2t2p2Hero);
                resetHero(m2t2p3Hero);
                resetHero(m2t2p4Hero);
                resetHero(m2t2p5Hero);
                resetHero(m2t2p6Hero);

                resetRole(m2t1p1Role);
                resetRole(m2t1p2Role);
                resetRole(m2t1p3Role);
                resetRole(m2t1p4Role);
                resetRole(m2t1p5Role);
                resetRole(m2t1p6Role);

                resetRole(m2t2p1Role);
                resetRole(m2t2p2Role);
                resetRole(m2t2p3Role);
                resetRole(m2t2p4Role);
                resetRole(m2t2p5Role);
                resetRole(m2t2p6Role);

                resetSide(m2Neutral);

                resetMap(m2m1Map);
                resetMap(m2m2Map);
                resetMap(m2m3Map);
                resetMap(m2m4Map);
                resetMap(m2m5Map);

                resetScore(m2m1t1Score);
                resetScore(m2m1t2Score);
                resetScore(m2m2t1Score);
                resetScore(m2m2t2Score);
                resetScore(m2m3t1Score);
                resetScore(m2m3t2Score);
                resetScore(m2m4t1Score);
                resetScore(m2m4t2Score);
                resetScore(m2m5t1Score);
                resetScore(m2m5t2Score);
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
                resetText(m3t1SR);
                resetText(m3t1p1Name);
                resetText(m3t1p2Name);
                resetText(m3t1p3Name);
                resetText(m3t1p4Name);
                resetText(m3t1p5Name);
                resetText(m3t1p6Name);

                resetScore(m3t2Score);
                resetText(m3t2Name);
                resetText(m3t2SR);
                resetText(m3t2p1Name);
                resetText(m3t2p2Name);
                resetText(m3t2p3Name);
                resetText(m3t2p4Name);
                resetText(m3t2p5Name);
                resetText(m3t2p6Name);

                resetHero(m3t1p1Hero);
                resetHero(m3t1p2Hero);
                resetHero(m3t1p3Hero);
                resetHero(m3t1p4Hero);
                resetHero(m3t1p5Hero);
                resetHero(m3t1p6Hero);

                resetHero(m3t2p1Hero);
                resetHero(m3t2p2Hero);
                resetHero(m3t2p3Hero);
                resetHero(m3t2p4Hero);
                resetHero(m3t2p5Hero);
                resetHero(m3t2p6Hero);

                resetRole(m3t1p1Role);
                resetRole(m3t1p2Role);
                resetRole(m3t1p3Role);
                resetRole(m3t1p4Role);
                resetRole(m3t1p5Role);
                resetRole(m3t1p6Role);

                resetRole(m3t2p1Role);
                resetRole(m3t2p2Role);
                resetRole(m3t2p3Role);
                resetRole(m3t2p4Role);
                resetRole(m3t2p5Role);
                resetRole(m3t2p6Role);

                resetSide(m3Neutral);

                resetMap(m3m1Map);
                resetMap(m3m2Map);
                resetMap(m3m3Map);
                resetMap(m3m4Map);
                resetMap(m3m5Map);

                resetScore(m3m1t1Score);
                resetScore(m3m1t2Score);
                resetScore(m3m2t1Score);
                resetScore(m3m2t2Score);
                resetScore(m3m3t1Score);
                resetScore(m3m3t2Score);
                resetScore(m3m4t1Score);
                resetScore(m3m4t2Score);
                resetScore(m3m5t1Score);
                resetScore(m3m5t2Score);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void generalResetButton_Click(object sender, EventArgs e)
        { DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove all match data?", "Reset General Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                resetText(message);
                resetText(host);
                resetText(analyst1);
                resetText(analyst2);
                resetText(caster1);
                resetText(caster2);
                resetText(utility1);
                resetText(utility2);
                resetText(utility3);
                resetText(utility4);
                resetText(utility5);
                resetText(utility6);
                resetText(utility7);
                resetText(utility8);
            }
            else if(dialogResult == DialogResult.No)
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
            updateText(m1t1SR, "Match1", "t1SR");
            updateText(m1t1p1Name, "Match1", "t1p1Name");
            updateText(m1t1p2Name, "Match1", "t1p2Name");
            updateText(m1t1p3Name, "Match1", "t1p3Name");
            updateText(m1t1p4Name, "Match1", "t1p4Name");
            updateText(m1t1p5Name, "Match1", "t1p5Name");
            updateText(m1t1p6Name, "Match1", "t1p6Name");

            updateScore(m1t2Score, "Match1", "t2Score");
            updateText(m1t2Name, "Match1", "t2Name");
            updateText(m1t2SR, "Match1", "t2SR");
            updateText(m1t2p1Name, "Match1", "t2p1Name");
            updateText(m1t2p2Name, "Match1", "t2p2Name");
            updateText(m1t2p3Name, "Match1", "t2p3Name");
            updateText(m1t2p4Name, "Match1", "t2p4Name");
            updateText(m1t2p5Name, "Match1", "t2p5Name");
            updateText(m1t2p6Name, "Match1", "t2p6Name");

            updateHero(m1t1p1Hero, "Match1", "t1p1Hero");
            updateHero(m1t1p2Hero, "Match1", "t1p2Hero");
            updateHero(m1t1p3Hero, "Match1", "t1p3Hero");
            updateHero(m1t1p4Hero, "Match1", "t1p4Hero");
            updateHero(m1t1p5Hero, "Match1", "t1p5Hero");
            updateHero(m1t1p6Hero, "Match1", "t1p6Hero");

            updateHero(m1t2p1Hero, "Match1", "t2p1Hero");
            updateHero(m1t2p2Hero, "Match1", "t2p2Hero");
            updateHero(m1t2p3Hero, "Match1", "t2p3Hero");
            updateHero(m1t2p4Hero, "Match1", "t2p4Hero");
            updateHero(m1t2p5Hero, "Match1", "t2p5Hero");
            updateHero(m1t2p6Hero, "Match1", "t2p6Hero");

            updateRole(m1t1p1Role, "Match1", "t1p1Role");
            updateRole(m1t1p2Role, "Match1", "t1p2Role");
            updateRole(m1t1p3Role, "Match1", "t1p3Role");
            updateRole(m1t1p4Role, "Match1", "t1p4Role");
            updateRole(m1t1p5Role, "Match1", "t1p5Role");
            updateRole(m1t1p6Role, "Match1", "t1p6Role");

            updateRole(m1t2p1Role, "Match1", "t2p1Role");
            updateRole(m1t2p2Role, "Match1", "t2p2Role");
            updateRole(m1t2p3Role, "Match1", "t2p3Role");
            updateRole(m1t2p4Role, "Match1", "t2p4Role");
            updateRole(m1t2p5Role, "Match1", "t2p5Role");
            updateRole(m1t2p6Role, "Match1", "t2p6Role");

            updateSide(m1Attack, "Match1", "t1Side", "t2Side");
            updateSide(m1Defend, "Match1", "t1Side", "t2Side");
            updateSide(m1Neutral, "Match1", "t1Side", "t2Side");

            updateMap(m1m1Map, "Match1", "m1Map");
            updateMap(m1m2Map, "Match1", "m2Map");
            updateMap(m1m3Map, "Match1", "m3Map");
            updateMap(m1m4Map, "Match1", "m4Map");
            updateMap(m1m5Map, "Match1", "m5Map");

            updateScore(m1m1t1Score, "Match1", "m1t1Score");
            updateScore(m1m1t2Score, "Match1", "m1t2Score");
            updateScore(m1m2t1Score, "Match1", "m2t1Score");
            updateScore(m1m2t2Score, "Match1", "m2t2Score");
            updateScore(m1m3t1Score, "Match1", "m3t1Score");
            updateScore(m1m3t2Score, "Match1", "m3t2Score");
            updateScore(m1m4t1Score, "Match1", "m4t1Score");
            updateScore(m1m4t2Score, "Match1", "m4t2Score");
            updateScore(m1m5t1Score, "Match1", "m5t1Score");
            updateScore(m1m5t2Score, "Match1", "m5t2Score");


            if (m1currentCheck.Checked == true)
            {
                updateText(m1MessageBox, "Current", "MessageBox");
                updateText(m1DivisionNumber, "Current", "DivisionNumber");

                updateScore(m1t1Score, "Current", "t1Score");
                updateText(m1t1Name, "Current", "t1Name");
                updateText(m1t1SR, "Current", "t1SR");
                updateText(m1t1p1Name, "Current", "t1p1Name");
                updateText(m1t1p2Name, "Current", "t1p2Name");
                updateText(m1t1p3Name, "Current", "t1p3Name");
                updateText(m1t1p4Name, "Current", "t1p4Name");
                updateText(m1t1p5Name, "Current", "t1p5Name");
                updateText(m1t1p6Name, "Current", "t1p6Name");

                updateScore(m1t2Score, "Current", "t2Score");
                updateText(m1t2Name, "Current", "t2Name");
                updateText(m1t2SR, "Current", "t2SR");
                updateText(m1t2p1Name, "Current", "t2p1Name");
                updateText(m1t2p2Name, "Current", "t2p2Name");
                updateText(m1t2p3Name, "Current", "t2p3Name");
                updateText(m1t2p4Name, "Current", "t2p4Name");
                updateText(m1t2p5Name, "Current", "t2p5Name");
                updateText(m1t2p6Name, "Current", "t2p6Name");

                updateHero(m1t1p1Hero, "Current", "t1p1Hero");
                updateHero(m1t1p2Hero, "Current", "t1p2Hero");
                updateHero(m1t1p3Hero, "Current", "t1p3Hero");
                updateHero(m1t1p4Hero, "Current", "t1p4Hero");
                updateHero(m1t1p5Hero, "Current", "t1p5Hero");
                updateHero(m1t1p6Hero, "Current", "t1p6Hero");

                updateHero(m1t2p1Hero, "Current", "t2p1Hero");
                updateHero(m1t2p2Hero, "Current", "t2p2Hero");
                updateHero(m1t2p3Hero, "Current", "t2p3Hero");
                updateHero(m1t2p4Hero, "Current", "t2p4Hero");
                updateHero(m1t2p5Hero, "Current", "t2p5Hero");
                updateHero(m1t2p6Hero, "Current", "t2p6Hero");

                updateRole(m1t1p1Role, "Current", "t1p1Role");
                updateRole(m1t1p2Role, "Current", "t1p2Role");
                updateRole(m1t1p3Role, "Current", "t1p3Role");
                updateRole(m1t1p4Role, "Current", "t1p4Role");
                updateRole(m1t1p5Role, "Current", "t1p5Role");
                updateRole(m1t1p6Role, "Current", "t1p6Role");

                updateRole(m1t2p1Role, "Current", "t2p1Role");
                updateRole(m1t2p2Role, "Current", "t2p2Role");
                updateRole(m1t2p3Role, "Current", "t2p3Role");
                updateRole(m1t2p4Role, "Current", "t2p4Role");
                updateRole(m1t2p5Role, "Current", "t2p5Role");
                updateRole(m1t2p6Role, "Current", "t2p6Role");

                updateSide(m1Attack, "Current", "t1Side", "t2Side");
                updateSide(m1Defend, "Current", "t1Side", "t2Side");
                updateSide(m1Neutral, "Current", "t1Side", "t2Side");


                updateMap(m1m1Map, "Current", "m1Map");
                updateMap(m1m2Map, "Current", "m2Map");
                updateMap(m1m3Map, "Current", "m3Map");
                updateMap(m1m4Map, "Current", "m4Map");
                updateMap(m1m5Map, "Current", "m5Map");

                updateScore(m1m1t1Score, "Current", "m1t1Score");
                updateScore(m1m1t2Score, "Current", "m1t2Score");
                updateScore(m1m2t1Score, "Current", "m2t1Score");
                updateScore(m1m2t2Score, "Current", "m2t2Score");
                updateScore(m1m3t1Score, "Current", "m3t1Score");
                updateScore(m1m3t2Score, "Current", "m3t2Score");
                updateScore(m1m4t1Score, "Current", "m4t1Score");
                updateScore(m1m4t2Score, "Current", "m4t2Score");
                updateScore(m1m5t1Score, "Current", "m5t1Score");
                updateScore(m1m5t2Score, "Current", "m5t2Score");
            }
        }

        private void m2UpdateButton_Click(object sender, EventArgs e)
        {

            updateText(m2MessageBox, "Match2", "MessageBox");
            updateText(m2DivisionNumber, "Match2", "DivisionNumber");

            updateScore(m2t1Score, "Match2", "t1Score");
            updateText(m2t1Name, "Match2", "t1Name");
            updateText(m2t1SR, "Match2", "t1SR");
            updateText(m2t1p1Name, "Match2", "t1p1Name");
            updateText(m2t1p2Name, "Match2", "t1p2Name");
            updateText(m2t1p3Name, "Match2", "t1p3Name");
            updateText(m2t1p4Name, "Match2", "t1p4Name");
            updateText(m2t1p5Name, "Match2", "t1p5Name");
            updateText(m2t1p6Name, "Match2", "t1p6Name");

            updateScore(m2t2Score, "Match2", "t2Score");
            updateText(m2t2Name, "Match2", "t2Name");
            updateText(m2t2SR, "Match2", "t2SR");
            updateText(m2t2p1Name, "Match2", "t2p1Name");
            updateText(m2t2p2Name, "Match2", "t2p2Name");
            updateText(m2t2p3Name, "Match2", "t2p3Name");
            updateText(m2t2p4Name, "Match2", "t2p4Name");
            updateText(m2t2p5Name, "Match2", "t2p5Name");
            updateText(m2t2p6Name, "Match2", "t2p6Name");

            updateHero(m2t1p1Hero, "Match2", "t1p1Hero");
            updateHero(m2t1p2Hero, "Match2", "t1p2Hero");
            updateHero(m2t1p3Hero, "Match2", "t1p3Hero");
            updateHero(m2t1p4Hero, "Match2", "t1p4Hero");
            updateHero(m2t1p5Hero, "Match2", "t1p5Hero");
            updateHero(m2t1p6Hero, "Match2", "t1p6Hero");

            updateHero(m2t2p1Hero, "Match2", "t2p1Hero");
            updateHero(m2t2p2Hero, "Match2", "t2p2Hero");
            updateHero(m2t2p3Hero, "Match2", "t2p3Hero");
            updateHero(m2t2p4Hero, "Match2", "t2p4Hero");
            updateHero(m2t2p5Hero, "Match2", "t2p5Hero");
            updateHero(m2t2p6Hero, "Match2", "t2p6Hero");

            updateRole(m2t1p1Role, "Match2", "t1p1Role");
            updateRole(m2t1p2Role, "Match2", "t1p2Role");
            updateRole(m2t1p3Role, "Match2", "t1p3Role");
            updateRole(m2t1p4Role, "Match2", "t1p4Role");
            updateRole(m2t1p5Role, "Match2", "t1p5Role");
            updateRole(m2t1p6Role, "Match2", "t1p6Role");

            updateRole(m2t2p1Role, "Match2", "t2p1Role");
            updateRole(m2t2p2Role, "Match2", "t2p2Role");
            updateRole(m2t2p3Role, "Match2", "t2p3Role");
            updateRole(m2t2p4Role, "Match2", "t2p4Role");
            updateRole(m2t2p5Role, "Match2", "t2p5Role");
            updateRole(m2t2p6Role, "Match2", "t2p6Role");

            updateSide(m2Attack, "Match2", "t1Side", "t2Side");
            updateSide(m2Defend, "Match2", "t1Side", "t2Side");
            updateSide(m2Neutral, "Match2", "t1Side", "t2Side");


            updateMap(m2m1Map, "Match2", "m1Map");
            updateMap(m2m2Map, "Match2", "m2Map");
            updateMap(m2m3Map, "Match2", "m3Map");
            updateMap(m2m4Map, "Match2", "m4Map");
            updateMap(m2m5Map, "Match2", "m5Map");

            updateScore(m2m1t1Score, "Match2", "m1t1Score");
            updateScore(m2m1t2Score, "Match2", "m1t2Score");
            updateScore(m2m2t1Score, "Match2", "m2t1Score");
            updateScore(m2m2t2Score, "Match2", "m2t2Score");
            updateScore(m2m3t1Score, "Match2", "m3t1Score");
            updateScore(m2m3t2Score, "Match2", "m3t2Score");
            updateScore(m2m4t1Score, "Match2", "m4t1Score");
            updateScore(m2m4t2Score, "Match2", "m4t2Score");
            updateScore(m2m5t1Score, "Match2", "m5t1Score");
            updateScore(m2m5t2Score, "Match2", "m5t2Score");

            if (m2currentCheck.Checked == true)
            {
                updateText(m2MessageBox, "Current", "MessageBox");
                updateText(m2DivisionNumber, "Current", "DivisionNumber");

                updateScore(m2t1Score, "Current", "t1Score");
                updateText(m2t1Name, "Current", "t1Name");
                updateText(m2t1SR, "Current", "t1SR");
                updateText(m2t1p1Name, "Current", "t1p1Name");
                updateText(m2t1p2Name, "Current", "t1p2Name");
                updateText(m2t1p3Name, "Current", "t1p3Name");
                updateText(m2t1p4Name, "Current", "t1p4Name");
                updateText(m2t1p5Name, "Current", "t1p5Name");
                updateText(m2t1p6Name, "Current", "t1p6Name");

                updateScore(m2t2Score, "Current", "t2Score");
                updateText(m2t2Name, "Current", "t2Name");
                updateText(m2t2SR, "Current", "t2SR");
                updateText(m2t2p1Name, "Current", "t2p1Name");
                updateText(m2t2p2Name, "Current", "t2p2Name");
                updateText(m2t2p3Name, "Current", "t2p3Name");
                updateText(m2t2p4Name, "Current", "t2p4Name");
                updateText(m2t2p5Name, "Current", "t2p5Name");
                updateText(m2t2p6Name, "Current", "t2p6Name");

                updateHero(m2t1p1Hero, "Current", "t1p1Hero");
                updateHero(m2t1p2Hero, "Current", "t1p2Hero");
                updateHero(m2t1p3Hero, "Current", "t1p3Hero");
                updateHero(m2t1p4Hero, "Current", "t1p4Hero");
                updateHero(m2t1p5Hero, "Current", "t1p5Hero");
                updateHero(m2t1p6Hero, "Current", "t1p6Hero");

                updateHero(m2t2p1Hero, "Current", "t2p1Hero");
                updateHero(m2t2p2Hero, "Current", "t2p2Hero");
                updateHero(m2t2p3Hero, "Current", "t2p3Hero");
                updateHero(m2t2p4Hero, "Current", "t2p4Hero");
                updateHero(m2t2p5Hero, "Current", "t2p5Hero");
                updateHero(m2t2p6Hero, "Current", "t2p6Hero");

                updateRole(m2t1p1Role, "Current", "t1p1Role");
                updateRole(m2t1p2Role, "Current", "t1p2Role");
                updateRole(m2t1p3Role, "Current", "t1p3Role");
                updateRole(m2t1p4Role, "Current", "t1p4Role");
                updateRole(m2t1p5Role, "Current", "t1p5Role");
                updateRole(m2t1p6Role, "Current", "t1p6Role");

                updateRole(m2t2p1Role, "Current", "t2p1Role");
                updateRole(m2t2p2Role, "Current", "t2p2Role");
                updateRole(m2t2p3Role, "Current", "t2p3Role");
                updateRole(m2t2p4Role, "Current", "t2p4Role");
                updateRole(m2t2p5Role, "Current", "t2p5Role");
                updateRole(m2t2p6Role, "Current", "t2p6Role");

                updateSide(m2Attack, "Current", "t1Side", "t2Side");
                updateSide(m2Defend, "Current", "t1Side", "t2Side");
                updateSide(m2Neutral, "Current", "t1Side", "t2Side");

                updateMap(m2m1Map, "Current", "m1Map");
                updateMap(m2m2Map, "Current", "m2Map");
                updateMap(m2m3Map, "Current", "m3Map");
                updateMap(m2m4Map, "Current", "m4Map");
                updateMap(m2m5Map, "Current", "m5Map");

                updateScore(m2m1t1Score, "Current", "m1t1Score");
                updateScore(m2m1t2Score, "Current", "m1t2Score");
                updateScore(m2m2t1Score, "Current", "m2t1Score");
                updateScore(m2m2t2Score, "Current", "m2t2Score");
                updateScore(m2m3t1Score, "Current", "m3t1Score");
                updateScore(m2m3t2Score, "Current", "m3t2Score");
                updateScore(m2m4t1Score, "Current", "m4t1Score");
                updateScore(m2m4t2Score, "Current", "m4t2Score");
                updateScore(m2m5t1Score, "Current", "m5t1Score");
                updateScore(m2m5t2Score, "Current", "m5t2Score");
            }
        }

        private void m3UpdateButton_Click(object sender, EventArgs e)
        {

            updateText(m3MessageBox, "Match3", "MessageBox");
            updateText(m3DivisionNumber, "Match3", "DivisionNumber");

            updateScore(m3t1Score, "Match3", "t1Score");
            updateText(m3t1Name, "Match3", "t1Name");
            updateText(m3t1SR, "Match3", "t1SR");
            updateText(m3t1p1Name, "Match3", "t1p1Name");
            updateText(m3t1p2Name, "Match3", "t1p2Name");
            updateText(m3t1p3Name, "Match3", "t1p3Name");
            updateText(m3t1p4Name, "Match3", "t1p4Name");
            updateText(m3t1p5Name, "Match3", "t1p5Name");
            updateText(m3t1p6Name, "Match3", "t1p6Name");

            updateScore(m3t2Score, "Match3", "t2Score");
            updateText(m3t2Name, "Match3", "t2Name");
            updateText(m3t2SR, "Match3", "t2SR");
            updateText(m3t2p1Name, "Match3", "t2p1Name");
            updateText(m3t2p2Name, "Match3", "t2p2Name");
            updateText(m3t2p3Name, "Match3", "t2p3Name");
            updateText(m3t2p4Name, "Match3", "t2p4Name");
            updateText(m3t2p5Name, "Match3", "t2p5Name");
            updateText(m3t2p6Name, "Match3", "t2p6Name");

            updateHero(m3t1p1Hero, "Match3", "t1p1Hero");
            updateHero(m3t1p2Hero, "Match3", "t1p2Hero");
            updateHero(m3t1p3Hero, "Match3", "t1p3Hero");
            updateHero(m3t1p4Hero, "Match3", "t1p4Hero");
            updateHero(m3t1p5Hero, "Match3", "t1p5Hero");
            updateHero(m3t1p6Hero, "Match3", "t1p6Hero");

            updateHero(m3t2p1Hero, "Match3", "t2p1Hero");
            updateHero(m3t2p2Hero, "Match3", "t2p2Hero");
            updateHero(m3t2p3Hero, "Match3", "t2p3Hero");
            updateHero(m3t2p4Hero, "Match3", "t2p4Hero");
            updateHero(m3t2p5Hero, "Match3", "t2p5Hero");
            updateHero(m3t2p6Hero, "Match3", "t2p6Hero");

            updateRole(m3t1p1Role, "Match3", "t1p1Role");
            updateRole(m3t1p2Role, "Match3", "t1p2Role");
            updateRole(m3t1p3Role, "Match3", "t1p3Role");
            updateRole(m3t1p4Role, "Match3", "t1p4Role");
            updateRole(m3t1p5Role, "Match3", "t1p5Role");
            updateRole(m3t1p6Role, "Match3", "t1p6Role");

            updateRole(m3t2p1Role, "Match3", "t2p1Role");
            updateRole(m3t2p2Role, "Match3", "t2p2Role");
            updateRole(m3t2p3Role, "Match3", "t2p3Role");
            updateRole(m3t2p4Role, "Match3", "t2p4Role");
            updateRole(m3t2p5Role, "Match3", "t2p5Role");
            updateRole(m3t2p6Role, "Match3", "t2p6Role");

            updateSide(m3Attack, "Match3", "t1Side", "t2Side");
            updateSide(m3Defend, "Match3", "t1Side", "t2Side");
            updateSide(m3Neutral, "Match3", "t1Side", "t2Side");

            updateMap(m3m1Map, "Match3", "m1Map");
            updateMap(m3m2Map, "Match3", "m2Map");
            updateMap(m3m3Map, "Match3", "m3Map");
            updateMap(m3m4Map, "Match3", "m4Map");
            updateMap(m3m5Map, "Match3", "m5Map");

            updateScore(m3m1t1Score, "Match3", "m1t1Score");
            updateScore(m3m1t2Score, "Match3", "m1t2Score");
            updateScore(m3m2t1Score, "Match3", "m2t1Score");
            updateScore(m3m2t2Score, "Match3", "m2t2Score");
            updateScore(m3m3t1Score, "Match3", "m3t1Score");
            updateScore(m3m3t2Score, "Match3", "m3t2Score");
            updateScore(m3m4t1Score, "Match3", "m4t1Score");
            updateScore(m3m4t2Score, "Match3", "m4t2Score");
            updateScore(m3m5t1Score, "Match3", "m5t1Score");
            updateScore(m3m5t2Score, "Match3", "m5t2Score");

            if (m3currentCheck.Checked == true)
            {
                updateText(m3MessageBox, "Current", "MessageBox");
                updateText(m3DivisionNumber, "Current", "DivisionNumber");

                updateScore(m3t1Score, "Current", "t1Score");
                updateText(m3t1Name, "Current", "t1Name");
                updateText(m3t1SR, "Current", "t1SR");
                updateText(m3t1p1Name, "Current", "t1p1Name");
                updateText(m3t1p2Name, "Current", "t1p2Name");
                updateText(m3t1p3Name, "Current", "t1p3Name");
                updateText(m3t1p4Name, "Current", "t1p4Name");
                updateText(m3t1p5Name, "Current", "t1p5Name");
                updateText(m3t1p6Name, "Current", "t1p6Name");

                updateScore(m3t2Score, "Current", "t2Score");
                updateText(m3t2Name, "Current", "t2Name");
                updateText(m3t2SR, "Current", "t2SR");
                updateText(m3t2p1Name, "Current", "t2p1Name");
                updateText(m3t2p2Name, "Current", "t2p2Name");
                updateText(m3t2p3Name, "Current", "t2p3Name");
                updateText(m3t2p4Name, "Current", "t2p4Name");
                updateText(m3t2p5Name, "Current", "t2p5Name");
                updateText(m3t2p6Name, "Current", "t2p6Name");

                updateHero(m3t1p1Hero, "Current", "t1p1Hero");
                updateHero(m3t1p2Hero, "Current", "t1p2Hero");
                updateHero(m3t1p3Hero, "Current", "t1p3Hero");
                updateHero(m3t1p4Hero, "Current", "t1p4Hero");
                updateHero(m3t1p5Hero, "Current", "t1p5Hero");
                updateHero(m3t1p6Hero, "Current", "t1p6Hero");

                updateHero(m3t2p1Hero, "Current", "t2p1Hero");
                updateHero(m3t2p2Hero, "Current", "t2p2Hero");
                updateHero(m3t2p3Hero, "Current", "t2p3Hero");
                updateHero(m3t2p4Hero, "Current", "t2p4Hero");
                updateHero(m3t2p5Hero, "Current", "t2p5Hero");
                updateHero(m3t2p6Hero, "Current", "t2p6Hero");

                updateRole(m3t1p1Role, "Current", "t1p1Role");
                updateRole(m3t1p2Role, "Current", "t1p2Role");
                updateRole(m3t1p3Role, "Current", "t1p3Role");
                updateRole(m3t1p4Role, "Current", "t1p4Role");
                updateRole(m3t1p5Role, "Current", "t1p5Role");
                updateRole(m3t1p6Role, "Current", "t1p6Role");

                updateRole(m3t2p1Role, "Current", "t2p1Role");
                updateRole(m3t2p2Role, "Current", "t2p2Role");
                updateRole(m3t2p3Role, "Current", "t2p3Role");
                updateRole(m3t2p4Role, "Current", "t2p4Role");
                updateRole(m3t2p5Role, "Current", "t2p5Role");
                updateRole(m3t2p6Role, "Current", "t2p6Role");

                updateSide(m3Attack, "Current", "t1Side", "t2Side");
                updateSide(m3Defend, "Current", "t1Side", "t2Side");
                updateSide(m3Neutral, "Current", "t1Side", "t2Side");


                updateMap(m3m1Map, "Current", "m1Map");
                updateMap(m3m2Map, "Current", "m2Map");
                updateMap(m3m3Map, "Current", "m3Map");
                updateMap(m3m4Map, "Current", "m4Map");
                updateMap(m3m5Map, "Current", "m5Map");

                updateScore(m3m1t1Score, "Current", "m1t1Score");
                updateScore(m3m1t2Score, "Current", "m1t2Score");
                updateScore(m3m2t1Score, "Current", "m2t1Score");
                updateScore(m3m2t2Score, "Current", "m2t2Score");
                updateScore(m3m3t1Score, "Current", "m3t1Score");
                updateScore(m3m3t2Score, "Current", "m3t2Score");
                updateScore(m3m4t1Score, "Current", "m4t1Score");
                updateScore(m3m4t2Score, "Current", "m4t2Score");
                updateScore(m3m5t1Score, "Current", "m5t1Score");
                updateScore(m3m5t2Score, "Current", "m5t2Score");
            }
        }

        private void generalUpdateButton_Click(object sender, EventArgs e)
        {
            updateText(message, "General", "message");
            updateText(host, "General", "host");
            updateText(analyst1, "General", "analyst1");
            updateText(analyst2, "General", "analyst2");
            updateText(caster1, "General", "caster1");
            updateText(caster2, "General", "caster2");
            updateText(utility1, "General", "utility1");
            updateText(utility2, "General", "utility2");
            updateText(utility3, "General", "utility3");
            updateText(utility4, "General", "utility4");
            updateText(utility5, "General", "utility5");
            updateText(utility6, "General", "utility6");
            updateText(utility7, "General", "utility7");
            updateText(utility8, "General", "utility8");
        }

        private void updateText(TextBox field, String folder, String file)
        {
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(field.Text.TrimEnd());
            }
        }

        private void updateScore(NumericUpDown field, String folder, String file)
        {
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(field.Value.ToString().TrimEnd());
            }
        }

        private void updateHero(ComboBox field, String folder, String file)
        {
            

            if (field.SelectedItem != null)
            {
                if (field.SelectedItem.ToString().Equals("Ana"))
                {
                    Properties.Resources.Ana.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Bastion"))
                {
                    Properties.Resources.Bastion.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Doomfist"))
                {
                    Properties.Resources.Doomfist.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("D.Va"))
                {
                    Properties.Resources.Dva.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Genji"))
                {
                    Properties.Resources.Genji.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Hanzo"))
                {
                    Properties.Resources.Hanzo.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Junkrat"))
                {
                    Properties.Resources.Junkrat.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Lúcio"))
                {
                    Properties.Resources.Lucio.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("McCree"))
                {
                    Properties.Resources.McCree.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Mei"))
                {
                    Properties.Resources.Mei.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Mercy"))
                {
                    Properties.Resources.Mercy.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Moira"))
                {
                    Properties.Resources.Moira.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Orisa"))
                {
                    Properties.Resources.Orisa.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Pharah"))
                {
                    Properties.Resources.Pharah.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Reaper"))
                {
                    Properties.Resources.Reaper.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Reinhardt"))
                {
                    Properties.Resources.Reinhart.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Roadhog"))
                {
                    Properties.Resources.Roadhog.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Soldier: 76"))
                {
                    Properties.Resources.Soldier76.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Sombra"))
                {
                    Properties.Resources.Sombra.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Symmetra"))
                {
                    Properties.Resources.Symetra.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Torbjörn"))
                {
                    Properties.Resources.Torbjorn.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Tracer"))
                {
                    Properties.Resources.Tracer.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Widowmaker"))
                {
                    Properties.Resources.Widowmaker.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Winston"))
                {
                    Properties.Resources.Winston.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Zarya"))
                {
                    Properties.Resources.Zarya.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Zenyatta"))
                {
                    Properties.Resources.Zenyatta.Save(path + "\\" + folder + "\\" + file + ".png");
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

        private void updateRole(ComboBox field, String folder, String file)
        {


            if (field.SelectedItem != null)
            {
                if (field.SelectedItem.ToString().Equals("DPS"))
                {
                    Properties.Resources.Icon_dps.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Flex"))
                {
                    Properties.Resources.Icon_flex.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Support"))
                {
                    Properties.Resources.Icon_support.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                else if (field.SelectedItem.ToString().Equals("Tank"))
                {
                    Properties.Resources.Icon_tank.Save(path + "\\" + folder + "\\" + file + ".png");
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

        private void updateSide(RadioButton field, String folder, String file1, String file2)
        {
            if (field.Checked == true)
            {
                if (field.Text == "A")
                {
                    Properties.Resources.Icon_offense.Save(path + "\\" + folder + "\\" + file1 + ".png");
                    Properties.Resources.Icon_defense.Save(path + "\\" + folder + "\\" + file2 + ".png");
                }
                else if(field.Text == "D")
                {
                    Properties.Resources.Icon_defense.Save(path + "\\" + folder + "\\" + file1 + ".png");
                    Properties.Resources.Icon_offense.Save(path + "\\" + folder + "\\" + file2 + ".png");
                }
                else
                {
                    Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file1 + ".png");
                    Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file2 + ".png");
                }

            }
        }

        private void updateMap(ComboBox field, String folder, String file)
        {
            if (field.SelectedItem != null)
            {
                String gametype = "";
                if (field.Text == "Dorado")
                {
                    Properties.Resources.Icon_dorado.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_escort.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Escort";
                }
                else if (field.Text == "Eichenwalde")
                {
                    Properties.Resources.Icon_eichenwalde.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_hybrid.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Hybrid";
                }
                else if (field.Text == "Hanamura")
                {
                    Properties.Resources.Icon_hanamura.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_assault.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Assault";
                }
                else if (field.Text == "Hollywood")
                {
                    Properties.Resources.Icon_hollywood.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_hybrid.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Hybrid";
                }
                else if (field.Text == "Horizon Lunar Colony")
                {
                    Properties.Resources.Icon_horizon.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_assault.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Assault";
                }
                else if (field.Text == "Ilios")
                {
                    Properties.Resources.Icon_ilios.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_control.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Control";
                }
                else if (field.Text == "Junkertown")
                {
                    Properties.Resources.Icon_junkertown.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_escort.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Escort";
                }
                else if (field.Text == "King's Row")
                {
                    Properties.Resources.Icon_kings.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_hybrid.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Hybrid";
                }
                else if (field.Text == "Lijiang Tower")
                {
                    Properties.Resources.Icon_lijiang.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_control.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Control";
                }
                else if (field.Text == "Nepal")
                {
                    Properties.Resources.Icon_nepal.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_control.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Control";
                }
                else if (field.Text == "Numbani")
                {
                    Properties.Resources.Icon_numbani.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_hybrid.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Hybrid";
                }
                else if (field.Text == "Oasis")
                {
                    Properties.Resources.Icon_oasis.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_control.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Control";
                }
                else if (field.Text == "Route 66")
                {
                    Properties.Resources.Icon_route.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_escort.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Escort";
                }
                else if (field.Text == "Temple of Anubis")
                {
                    Properties.Resources.Icon_temple.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_assault.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Assault";
                }
                else if (field.Text == "Volskaya Industries")
                {
                    Properties.Resources.Icon_volskaya.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_assault.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Assault";
                }
                else if (field.Text == "Watchpoint: Gibraltar")
                {
                    Properties.Resources.Icon_watchpoint.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_escort.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Escort";
                }
                else
                {
                    if (field.Text == "Assault")
                    {
                        Properties.Resources.Icon_assault.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                        gametype = "Assault";
                    }
                    else if (field.Text == "Escort")
                    {
                        Properties.Resources.Icon_escort.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                        gametype = "Escort";
                    }
                    else if (field.Text == "Hybrid")
                    {
                        Properties.Resources.Icon_hybrid.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                        gametype = "Hybrid";
                    }
                    else if (field.Text == "Control")
                    {
                        Properties.Resources.Icon_control.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                        gametype = "Control";
                    }
                    else
                    {
                        Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                        gametype = "";
                    }

                    Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
                {
                    if (field.Text == "Assault" || field.Text == "Escort" || field.Text == "Hybrid" || field.Text == "Control")
                    {
                        sw.WriteLine("?");
                    }
                    else
                    {
                        sw.WriteLine(field.Text.TrimEnd());
                    }
                }
                using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + "Gametype" + ".txt"))
                {
                    sw.WriteLine(gametype.TrimEnd());
                }
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

        private void resetRole(ComboBox field)
        {
            field.SelectedIndex = 0;
        }

        private void resetSide(RadioButton field)
        {
            field.Checked = true;
        }

        private void resetMap(ComboBox field)
        {
            field.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        /*private void loadHero(ComboBox field, String folder, String file)
        {
           
        } */

    }
}
