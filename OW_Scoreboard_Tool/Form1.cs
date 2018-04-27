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
using System.Runtime.InteropServices;

namespace OW_Scoreboard_Tool
{
    public partial class Form1 : Form
    {
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string main = "\\Replay";
        string playlist = "\\Playlist";
        const int Bytes_TO_READ = sizeof(Int64);

        //for global hotkeys
        public const int NOMOD = 0x0000;
        public const int ALT = 0x0001;
	    public const int CTRL = 0x0002;
	    public const int SHIFT = 0x0004;
	    public const int WIN = 0x0008;

        int cycleSidesHotKeyId = 0;
        int swapTeamsHotKeyId = 1;
        int updateHotKeyId = 2;
        int t1UpHotKeyId = 3;
        int t1DownHotKeyId = 4;
        int t2UpHotKeyId = 5;
        int t2DownHotKeyId = 6;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(IntPtr hwnd, int id);

        public Form1()
        {
            InitializeComponent();
            CreateFileWatcher(path + main);
        }

        //for global hotkeys
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                if (id == cycleSidesHotKeyId)
                {
                    if (m1Attack.Checked == true)
                    {
                        m1Defend.PerformClick();
                    }
                    else if (m1Defend.Checked == true)
                    {
                        m1Neutral.PerformClick();
                    }
                    else if (m1Neutral.Checked == true)
                    {
                        m1Attack.PerformClick();
                    }
                }

                if (id == swapTeamsHotKeyId)
                {
                    m1SwapButton.PerformClick();
                }

                if (id == updateHotKeyId)
                {
                    m1UpdateButton.PerformClick();
                }

                if (id == t1UpHotKeyId)
                {
                    m1t1Score.UpButton();
                }

                if (id == t1DownHotKeyId)
                {
                    m1t1Score.DownButton();
                }

                if (id == t2UpHotKeyId)
                {
                    m1t2Score.UpButton();
                }

                if (id == t2DownHotKeyId)
                {
                    m1t2Score.DownButton();
                }
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

            loadScore(m1m1t1Score, "Match1", "m1t1Score");
            loadScore(m1m2t1Score, "Match1", "m2t1Score");
            loadScore(m1m3t1Score, "Match1", "m3t1Score");
            loadScore(m1m4t1Score, "Match1", "m4t1Score");
            loadScore(m1m5t1Score, "Match1", "m5t1Score");
            loadScore(m1m6t1Score, "Match1", "m6t1Score");
            loadScore(m1m7t1Score, "Match1", "m7t1Score");

            loadScore(m1m1t2Score, "Match1", "m1t2Score");
            loadScore(m1m2t2Score, "Match1", "m2t2Score");
            loadScore(m1m3t2Score, "Match1", "m3t2Score");
            loadScore(m1m4t2Score, "Match1", "m4t2Score");
            loadScore(m1m5t2Score, "Match1", "m5t2Score");
            loadScore(m1m6t2Score, "Match1", "m6t2Score");
            loadScore(m1m7t2Score, "Match1", "m7t2Score");

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

            loadCombo(m1t1p1Hero, "Match1", "t1p1Hero");
            loadCombo(m1t1p2Hero, "Match1", "t1p2Hero");
            loadCombo(m1t1p3Hero, "Match1", "t1p3Hero");
            loadCombo(m1t1p4Hero, "Match1", "t1p4Hero");
            loadCombo(m1t1p5Hero, "Match1", "t1p5Hero");
            loadCombo(m1t1p6Hero, "Match1", "t1p6Hero");

            loadCombo(m1t2p1Hero, "Match1", "t2p1Hero");
            loadCombo(m1t2p2Hero, "Match1", "t2p2Hero");
            loadCombo(m1t2p3Hero, "Match1", "t2p3Hero");
            loadCombo(m1t2p4Hero, "Match1", "t2p4Hero");
            loadCombo(m1t2p5Hero, "Match1", "t2p5Hero");
            loadCombo(m1t2p6Hero, "Match1", "t2p6Hero");

            loadCombo(m1t1p1Role, "Match1", "t1p1Role");
            loadCombo(m1t1p2Role, "Match1", "t1p2Role");
            loadCombo(m1t1p3Role, "Match1", "t1p3Role");
            loadCombo(m1t1p4Role, "Match1", "t1p4Role");
            loadCombo(m1t1p5Role, "Match1", "t1p5Role");
            loadCombo(m1t1p6Role, "Match1", "t1p6Role");

            loadCombo(m1t2p1Role, "Match1", "t2p1Role");
            loadCombo(m1t2p2Role, "Match1", "t2p2Role");
            loadCombo(m1t2p3Role, "Match1", "t2p3Role");
            loadCombo(m1t2p4Role, "Match1", "t2p4Role");
            loadCombo(m1t2p5Role, "Match1", "t2p5Role");
            loadCombo(m1t2p6Role, "Match1", "t2p6Role");

            loadCombo(m1m1Map, "Match1", "m1Map");
            loadCombo(m1m2Map, "Match1", "m2Map");
            loadCombo(m1m3Map, "Match1", "m3Map");
            loadCombo(m1m4Map, "Match1", "m4Map");
            loadCombo(m1m5Map, "Match1", "m5Map");
            loadCombo(m1m6Map, "Match1", "m6Map");
            loadCombo(m1m7Map, "Match1", "m7Map");

            loadHotKey(cycleSidesHotKeyId, "Settings", "cycleSides", comboBoxCycleSidesMod, comboBoxCycleSidesKey, useCycleSidesHotKey);
            loadHotKey(swapTeamsHotKeyId, "Settings", "swapTeams", comboBoxSwapTeamsMod, comboBoxSwapTeamsKey, useSwapTeamsHotKey);
            loadHotKey(updateHotKeyId, "Settings", "update", comboBoxUpdateMod, comboBoxUpdateKey, useUpdateHotKey);
            loadHotKey(t1UpHotKeyId, "Settings", "t1Up", comboBoxT1UpMod, comboBoxT1UpKey, useT1UpHotKey);
            loadHotKey(t1DownHotKeyId, "Settings", "t1Down", comboBoxT1DownMod, comboBoxT1DownKey, useT1DownHotKey);
            loadHotKey(t2UpHotKeyId, "Settings", "t2Up", comboBoxT2UpMod, comboBoxT2UpKey, useT2UpHotKey);
            loadHotKey(t2DownHotKeyId, "Settings", "t2Down", comboBoxT2DownMod, comboBoxT2DownKey, useT2DownHotKey);
        }

        private void m1SwapButton_Click(object sender, EventArgs e)
        {

            String temp;
            temp = m1t1Name.Text;
            m1t1Name.Text = m1t2Name.Text;
            m1t2Name.Text = temp;
            temp = "";

            decimal temporary;
            temporary = m1t1Score.Value;
            m1t1Score.Value = m1t2Score.Value;
            m1t2Score.Value = temporary;
            temporary = 0;

            temporary = m1m1t1Score.Value;
            m1m1t1Score.Value = m1m1t2Score.Value;
            m1m1t2Score.Value = temporary;
            temporary = 0;

            temporary = m1m2t1Score.Value;
            m1m2t1Score.Value = m1m2t2Score.Value;
            m1m2t2Score.Value = temporary;
            temporary = 0;

            temporary = m1m3t1Score.Value;
            m1m3t1Score.Value = m1m3t2Score.Value;
            m1m3t2Score.Value = temporary;
            temporary = 0;

            temporary = m1m4t1Score.Value;
            m1m4t1Score.Value = m1m4t2Score.Value;
            m1m4t2Score.Value = temporary;
            temporary = 0;

            temporary = m1m5t1Score.Value;
            m1m5t1Score.Value = m1m5t2Score.Value;
            m1m5t2Score.Value = temporary;
            temporary = 0;

            temporary = m1m6t1Score.Value;
            m1m6t1Score.Value = m1m6t2Score.Value;
            m1m6t2Score.Value = temporary;
            temporary = 0;

            temporary = m1m7t1Score.Value;
            m1m7t1Score.Value = m1m7t2Score.Value;
            m1m7t2Score.Value = temporary;
            temporary = 0;

            temp = m1t1SR.Text;
            m1t1SR.Text = m1t2SR.Text;
            m1t2SR.Text = temp;
            temp = "";

            temp = m1t1Logo.Text;
            m1t1Logo.Text = m1t2Logo.Text;
            m1t2Logo.Text = temp;
            temp = "";

            temp = m1t1p1Name.Text;
            m1t1p1Name.Text = m1t2p1Name.Text;
            m1t2p1Name.Text = temp;
            temp = "";

            temp = m1t1p2Name.Text;
            m1t1p2Name.Text = m1t2p2Name.Text;
            m1t2p2Name.Text = temp;
            temp = "";

            temp = m1t1p3Name.Text;
            m1t1p3Name.Text = m1t2p3Name.Text;
            m1t2p3Name.Text = temp;
            temp = "";

            temp = m1t1p4Name.Text;
            m1t1p4Name.Text = m1t2p4Name.Text;
            m1t2p4Name.Text = temp;
            temp = "";

            temp = m1t1p5Name.Text;
            m1t1p5Name.Text = m1t2p5Name.Text;
            m1t2p5Name.Text = temp;
            temp = "";

            temp = m1t1p6Name.Text;
            m1t1p6Name.Text = m1t2p6Name.Text;
            m1t2p6Name.Text = temp;
            temp = "";

            int temps = 0;
            temps = m1t1p1Hero.SelectedIndex;
            m1t1p1Hero.SelectedIndex = m1t2p1Hero.SelectedIndex;
            m1t2p1Hero.SelectedIndex = temps;
            temps = 0;

            temps = m1t1p2Hero.SelectedIndex;
            m1t1p2Hero.SelectedIndex = m1t2p2Hero.SelectedIndex;
            m1t2p2Hero.SelectedIndex = temps;
            temps = 0;

            temps = m1t1p3Hero.SelectedIndex;
            m1t1p3Hero.SelectedIndex = m1t2p3Hero.SelectedIndex;
            m1t2p3Hero.SelectedIndex = temps;
            temps = 0;

            temps = m1t1p4Hero.SelectedIndex;
            m1t1p4Hero.SelectedIndex = m1t2p4Hero.SelectedIndex;
            m1t2p4Hero.SelectedIndex = temps;
            temps = 0;

            temps = m1t1p5Hero.SelectedIndex;
            m1t1p5Hero.SelectedIndex = m1t2p5Hero.SelectedIndex;
            m1t2p5Hero.SelectedIndex = temps;
            temps = 0;

            temps = m1t1p6Hero.SelectedIndex;
            m1t1p6Hero.SelectedIndex = m1t2p6Hero.SelectedIndex;
            m1t2p6Hero.SelectedIndex = temps;
            temps = 0;

            temps = m1t1p1Role.SelectedIndex;
            m1t1p1Role.SelectedIndex = m1t2p1Role.SelectedIndex;
            m1t2p1Role.SelectedIndex = temps;
            temps = 0;

            temps = m1t1p2Role.SelectedIndex;
            m1t1p2Role.SelectedIndex = m1t2p2Role.SelectedIndex;
            m1t2p2Role.SelectedIndex = temps;
            temps = 0;

            temps = m1t1p3Role.SelectedIndex;
            m1t1p3Role.SelectedIndex = m1t2p3Role.SelectedIndex;
            m1t2p3Role.SelectedIndex = temps;
            temps = 0;

            temps = m1t1p4Role.SelectedIndex;
            m1t1p4Role.SelectedIndex = m1t2p4Role.SelectedIndex;
            m1t2p4Role.SelectedIndex = temps;
            temps = 0;

            temps = m1t1p5Role.SelectedIndex;
            m1t1p5Role.SelectedIndex = m1t2p5Role.SelectedIndex;
            m1t2p5Role.SelectedIndex = temps;
            temps = 0;

            temps = m1t1p6Role.SelectedIndex;
            m1t1p6Role.SelectedIndex = m1t2p6Role.SelectedIndex;
            m1t2p6Role.SelectedIndex = temps;
            temps = 0;
        }

        private void m1ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove all match data?", "Reset Match Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
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
                resetMap(m1m6Map);
                resetMap(m1m7Map);

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
                resetScore(m1m6t1Score);
                resetScore(m1m6t2Score);
                resetScore(m1m7t1Score);
                resetScore(m1m7t2Score);

                resetText(m1t1Logo);
                resetText(m1t2Logo);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void generalResetButton_Click(object sender, EventArgs e)
        { DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove all general data?", "Reset General Data?", MessageBoxButtons.YesNo);
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

            updateHero(m1t1p1Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t1p1Hero");
            updateHero(m1t1p2Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t1p2Hero");
            updateHero(m1t1p3Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t1p3Hero");
            updateHero(m1t1p4Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t1p4Hero");
            updateHero(m1t1p5Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t1p5Hero");
            updateHero(m1t1p6Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t1p6Hero");
                                                             
            updateHero(m1t2p1Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t2p1Hero");
            updateHero(m1t2p2Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t2p2Hero");
            updateHero(m1t2p3Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t2p3Hero");
            updateHero(m1t2p4Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t2p4Hero");
            updateHero(m1t2p5Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t2p5Hero");
            updateHero(m1t2p6Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Match1", "t2p6Hero");

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

            updateMap(m1m1Map, m1m1Selected, m1MapFull, m1MapLong, "Match1", "m1Map");
            updateMap(m1m2Map, m1m2Selected, m1MapFull, m1MapLong, "Match1", "m2Map");
            updateMap(m1m3Map, m1m3Selected, m1MapFull, m1MapLong, "Match1", "m3Map");
            updateMap(m1m4Map, m1m4Selected, m1MapFull, m1MapLong, "Match1", "m4Map");
            updateMap(m1m5Map, m1m5Selected, m1MapFull, m1MapLong, "Match1", "m5Map");
            updateMap(m1m6Map, m1m6Selected, m1MapFull, m1MapLong, "Match1", "m6Map");
            updateMap(m1m7Map, m1m7Selected, m1MapFull, m1MapLong, "Match1", "m7Map");

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
            updateScore(m1m6t1Score, "Match1", "m6t1Score");
            updateScore(m1m6t2Score, "Match1", "m6t2Score");
            updateScore(m1m7t1Score, "Match1", "m7t1Score");
            updateScore(m1m7t2Score, "Match1", "m7t2Score");

            updateCompleted(m1m1Completed, m1t1Name, m1t2Name, m1m1t1Score, m1m1t2Score, "Match1", "m1MapWin");
            updateCompleted(m1m2Completed, m1t1Name, m1t2Name, m1m2t1Score, m1m2t2Score, "Match1", "m2MapWin");
            updateCompleted(m1m3Completed, m1t1Name, m1t2Name, m1m3t1Score, m1m3t2Score, "Match1", "m3MapWin");
            updateCompleted(m1m4Completed, m1t1Name, m1t2Name, m1m4t1Score, m1m4t2Score, "Match1", "m4MapWin");
            updateCompleted(m1m5Completed, m1t1Name, m1t2Name, m1m5t1Score, m1m5t2Score, "Match1", "m5MapWin");
            updateCompleted(m1m6Completed, m1t1Name, m1t2Name, m1m6t1Score, m1m6t2Score, "Match1", "m6MapWin");
            updateCompleted(m1m7Completed, m1t1Name, m1t2Name, m1m7t1Score, m1m7t2Score, "Match1", "m7MapWin");

            updateLogos(m1t1Logo, "Match1", "t1Logo");
            updateLogos(m1t2Logo, "Match1", "t2Logo");

            if (m1currentCheck.Checked == true)
            {
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

                updateHero(m1t1p1Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t1p1Hero");
                updateHero(m1t1p2Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t1p2Hero");
                updateHero(m1t1p3Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t1p3Hero");
                updateHero(m1t1p4Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t1p4Hero");
                updateHero(m1t1p5Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t1p5Hero");
                updateHero(m1t1p6Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t1p6Hero");
                                                                   
                updateHero(m1t2p1Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t2p1Hero");
                updateHero(m1t2p2Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t2p2Hero");
                updateHero(m1t2p3Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t2p3Hero");
                updateHero(m1t2p4Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t2p4Hero");
                updateHero(m1t2p5Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t2p5Hero");
                updateHero(m1t2p6Hero, m1HeroPortrait, m1HeroIcon, m1Hero3D, "Current", "t2p6Hero");

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


                updateMap(m1m1Map, m1m1Selected, m1MapFull, m1MapLong, "Current", "m1Map");
                updateMap(m1m2Map, m1m2Selected, m1MapFull, m1MapLong, "Current", "m2Map");
                updateMap(m1m3Map, m1m3Selected, m1MapFull, m1MapLong, "Current", "m3Map");
                updateMap(m1m4Map, m1m4Selected, m1MapFull, m1MapLong, "Current", "m4Map");
                updateMap(m1m5Map, m1m5Selected, m1MapFull, m1MapLong, "Current", "m5Map");
                updateMap(m1m6Map, m1m6Selected, m1MapFull, m1MapLong, "Current", "m6Map");
                updateMap(m1m7Map, m1m7Selected, m1MapFull, m1MapLong, "Current", "m7Map");

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
                updateScore(m1m6t1Score, "Current", "m6t1Score");
                updateScore(m1m6t2Score, "Current", "m6t2Score");
                updateScore(m1m7t1Score, "Current", "m7t1Score");
                updateScore(m1m7t2Score, "Current", "m7t2Score");

                updateCompleted(m1m1Completed, m1t1Name, m1t2Name, m1m1t1Score, m1m1t2Score, "Current", "m1MapWin");
                updateCompleted(m1m2Completed, m1t1Name, m1t2Name, m1m2t1Score, m1m2t2Score, "Current", "m2MapWin");
                updateCompleted(m1m3Completed, m1t1Name, m1t2Name, m1m3t1Score, m1m3t2Score, "Current", "m3MapWin");
                updateCompleted(m1m4Completed, m1t1Name, m1t2Name, m1m4t1Score, m1m4t2Score, "Current", "m4MapWin");
                updateCompleted(m1m5Completed, m1t1Name, m1t2Name, m1m5t1Score, m1m5t2Score, "Current", "m5MapWin");
                updateCompleted(m1m6Completed, m1t1Name, m1t2Name, m1m6t1Score, m1m6t2Score, "Current", "m6MapWin");
                updateCompleted(m1m7Completed, m1t1Name, m1t2Name, m1m7t1Score, m1m7t2Score, "Current", "m7MapWin");

                updateLogos(m1t1Logo, "Current", "t1Logo");
                updateLogos(m1t2Logo, "Current", "t2Logo");
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
                sw.WriteLine(field.Text.Trim());
            }
        }

        private void updateScore(NumericUpDown field, String folder, String file)
        {
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(field.Value.ToString().Trim());
            }
        }

        private void updateHero(ComboBox field, RadioButton radio1, RadioButton radio2, RadioButton radio3, String folder, String file)
        {
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(field.SelectedItem.ToString());
            }


            if (field.SelectedItem != null)
            {
                if (field.SelectedItem.ToString().Equals("Ana"))
                {
                    if (radio2.Checked == true )
                    {
                        Properties.Resources.Icon_ana.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Ana.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Ana.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Bastion"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_bastion.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Bastion.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Bastion.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Brigitte"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_brigitte.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Brigitte.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Brigitte.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Doomfist"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_doomfist.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Doomfist.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Doomfist.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("D.Va"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_dva.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Dva.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Dva.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Genji"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_genji.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Genji.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Genji.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Hanzo"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_hanzo.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Hanzo.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Hanzo.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Junkrat"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_junkrat.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Junkrat.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Junkrat.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Lúcio"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_Lucio.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Lucio.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Lucio.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("McCree"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_mccree.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_McCree.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.McCree.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Mei"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_mei.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Mei.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Mei.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Mercy"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_mercy.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Mercy.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Mercy.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Moira"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_moira.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Moira.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Moira.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Orisa"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_orisa.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Orisa.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Orisa.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Pharah"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_pharah.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Pharah.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Pharah.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Reaper"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_reaper.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Reaper.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Reaper.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Reinhardt"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_reinhardt.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Reinhardt.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Reinhart.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Roadhog"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_roadhog.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Roadhog.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Roadhog.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Soldier: 76"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_soldier76.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Soldier76.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Soldier76.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Sombra"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_sombra.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Sombra.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Sombra.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Symmetra"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_symmetra.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Symmetra.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Symetra.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Torbjörn"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_torbjorn.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Torbjorn.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Torbjorn.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Tracer"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_tracer.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Tracer.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Tracer.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Widowmaker"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_widowmaker.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Widowmaker.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Widowmaker.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Winston"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_winston.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Winston.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Winston.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Zarya"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_zarya.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Zarya.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Zarya.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Zenyatta"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_zenyatta.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Zenyatta.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Zenyatta.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
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
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(field.SelectedItem.ToString());
            }

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

        private void updateMap(ComboBox field, RadioButton check, RadioButton radio1, RadioButton radio2, String folder, String file)
        {

            if (field.SelectedItem != null)
            {
                String gametype = "";
                if (field.Text == "Blizzard World")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Blizzworld.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_blizzworld.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Blizzworld.Save(path + "\\" + folder + "\\" + file + ".png");
                    }

                    Properties.Resources.Icon_hybrid.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Hybrid";
                }
                else if (field.Text == "Dorado")
                {   if(radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Dorado.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_dorado.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Dorado.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    
                    Properties.Resources.Icon_escort.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Escort";
                }
                else if (field.Text == "Eichenwalde")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Eichenwalde.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_eichenwalde.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Eichenwalde.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_hybrid.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Hybrid";
                }
                else if (field.Text == "Hanamura")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Hanamura.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_hanamura.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Hanamura.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_assault.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Assault";
                }
                else if (field.Text == "Hollywood")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Hollywood.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_hollywood.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Hollywood.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_hybrid.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Hybrid";
                }
                else if (field.Text == "Horizon Lunar Colony")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Horizon.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_horizon.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Horizon.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_assault.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Assault";
                }
                else if (field.Text == "Ilios")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Ilios.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_ilios.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Ilios.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_control.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Control";
                }
                else if (field.Text == "Junkertown")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Junkertown.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_junkertown.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Junkertown.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_escort.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Escort";
                }
                else if (field.Text == "King's Row")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_King_s_Row.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_kings.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_King_s_Row.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_hybrid.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Hybrid";
                }
                else if (field.Text == "Lijiang Tower")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Lijiang.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_lijiang.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Lijiang.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_control.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Control";
                }
                else if (field.Text == "Nepal")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Nepal.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_nepal.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Nepal.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_control.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Control";
                }
                else if (field.Text == "Numbani")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Numbani.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_numbani.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Numbani.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_hybrid.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Hybrid";
                }
                else if (field.Text == "Oasis")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Oasis.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_oasis.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Oasis.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_control.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Control";
                }
                else if (field.Text == "Route 66")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Route66.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_route.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Route66.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_escort.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Escort";
                }
                else if (field.Text == "Temple of Anubis")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Anubis.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_temple.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Anubis.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_assault.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Assault";
                }
                else if (field.Text == "Volskaya Industries")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Volskaya.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_volskaya.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Volskaya.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_assault.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Assault";
                }
                else if (field.Text == "Watchpoint: Gibraltar")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Watchpoint.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_watchpoint.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Watchpoint.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_escort.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Escort";
                }

                else if (field.Text == "Assault")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Assault.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_assault_pool.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Assault.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_assault.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Assault";
                }
                else if (field.Text == "Escort")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Escort.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_escort_pool.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Escort.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_escort.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Escort";
                }
                else if (field.Text == "Hybrid")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Hybrid.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_hybrid_pool.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Hybrid.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_hybrid.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Hybrid";
                }
                else if (field.Text == "Control")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Control.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_control_pool.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Control.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_control.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Control";
                }
                else
                {
                    Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + ".png");
                    Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "";

                }
                using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
                {
                    if (field.Text == "Assault" || field.Text == "Escort" || field.Text == "Hybrid" || field.Text == "Control")
                    {
                        sw.WriteLine("?");
                    }
                    else
                    {
                        sw.WriteLine(field.Text.Trim());
                    }
                }
                using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + "Gametype" + ".txt"))
                {
                    sw.WriteLine(gametype.Trim());
                }
            }
        }

        private void loadText(TextBox field, String folder, String file)
        {
            if (File.Exists(path + "\\" + folder + "\\" + file + ".txt"))
            {
                string loadingText = File.ReadAllText(path + "\\" + folder + "\\" + file + ".txt");
                field.Text = loadingText;
                field.Text.Trim();
            }

        }

        private void loadScore(NumericUpDown field, String folder, String file)
        {
            if (File.Exists(path + "\\" + folder + "\\" + file + ".txt"))
            {
                string loadingText = File.ReadAllText(path + "\\" + folder + "\\" + file + ".txt");
                decimal number;
                Decimal.TryParse(loadingText, out number);
                field.Value = number;
            }

        }

        private void loadCombo(ComboBox field, String folder, String file)
        {
            if (File.Exists(path + "\\" + folder + "\\" + file + ".txt"))
            {
                string loadingText = File.ReadAllText(path + "\\" + folder + "\\" + file + ".txt");
                if (loadingText.Trim() == "?" && file.Contains("Map"))
                {
                    loadingText = File.ReadAllText(path + "\\" + folder + "\\" + file + "Gametype" + ".txt");
                }
                field.SelectedIndex = field.FindString(loadingText.Trim());
            }
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

        public void CreateFileWatcher(String path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "Replay Replay.mp4";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            string filelessPath = Path.GetDirectoryName(e.FullPath);
            string copyPath = filelessPath + "\\Playlist";
            System.IO.DirectoryInfo di = new DirectoryInfo(copyPath);
            int count = di.GetFiles().Length;
            int prefix = count + 1;
            string previousfile = count.ToString() + "-" + e.Name;
            string copiedFile = prefix.ToString() + "-" + e.Name;
            string copiedFullPath = Path.Combine(copyPath, copiedFile);
            string previousFullPath = Path.Combine(copyPath, previousfile);

            if (!File.Exists(copiedFullPath))
            {
                if (count != 0)
                {
                    if (!FilesAreEqual(new FileInfo(previousFullPath), new FileInfo(e.FullPath)))
                    {
                        File.Copy(e.FullPath, copiedFullPath);
                    }
                    

                }
                else
                {
                    File.Copy(e.FullPath, copiedFullPath);
                }

            }

        }

        private static bool FilesAreEqual(FileInfo first, FileInfo second)
        {
            if(first.Length != second.Length)
            {
                return false;
            }

            if (string.Equals(first.FullName, second.FullName, StringComparison.OrdinalIgnoreCase)){
                return true;
            }

            int iterations = (int)Math.Ceiling((double)first.Length / Bytes_TO_READ);

            using (FileStream fs1 = first.OpenRead())
            using (FileStream fs2 = second.OpenRead())
            {
                byte[] one = new byte[Bytes_TO_READ];
                byte[] two = new byte[Bytes_TO_READ];

                for (int i=0; i < iterations; i++)
                {
                    fs1.Read(one, 0, Bytes_TO_READ);
                    fs2.Read(two, 0, Bytes_TO_READ);

                    if (BitConverter.ToInt64(one, 0) != BitConverter.ToInt64(two, 0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void replayReset_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(path + main + playlist);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

        private void replayClean_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(path + main + playlist);
            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Length < 1000000)
                {
                    file.Delete();
                }
            }
        }

        private void updateCompleted(CheckBox field, TextBox team1, TextBox team2, NumericUpDown score1, NumericUpDown score2, String folder, String file)
        {
            String winner = "";
            if(field.Checked == true)
            {
                if(score1.Value > score2.Value)
                {
                    winner = team1.Text;
                }
                else if(score2.Value > score1.Value)
                {
                    winner = team2.Text;
                }
                else
                {
                    winner = "DRAW";
                }

                using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
                {
                    sw.WriteLine(winner.Trim());
                }
            }
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(winner.Trim());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getFileName(m1t1Logo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getFileName(m1t2Logo);
        }

        public void getFileName(TextBox field)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; )|*.png";
            open.ShowDialog();

            field.Text = open.FileName;

        }

        public void updateLogos(TextBox field, String folder, String file)
        {
            
            if (field.Text != "")
            {
                Bitmap logo = new Bitmap(field.Text);
                logo.Save(path + "\\" + folder + "\\" + file + ".png");
            }
            else
            {
                Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + ".png");
            }
               
        }

        private void buttonUpdateHotkeys_Click(object sender, EventArgs e)
        {
            updateHotKey(cycleSidesHotKeyId, "cycleSides", comboBoxCycleSidesMod, comboBoxCycleSidesKey, useCycleSidesHotKey);
            updateHotKey(swapTeamsHotKeyId, "swapTeams", comboBoxSwapTeamsMod, comboBoxSwapTeamsKey, useSwapTeamsHotKey);
            updateHotKey(updateHotKeyId, "update", comboBoxUpdateMod, comboBoxUpdateKey, useUpdateHotKey);
            updateHotKey(t1UpHotKeyId, "t1Up", comboBoxT1UpMod, comboBoxT1UpKey, useT1UpHotKey);
            updateHotKey(t1DownHotKeyId, "t1Down", comboBoxT1DownMod, comboBoxT1DownKey, useT1DownHotKey);
            updateHotKey(t2UpHotKeyId, "t2Up", comboBoxT2UpMod, comboBoxT2UpKey, useT2UpHotKey);
            updateHotKey(t2DownHotKeyId, "t2Down", comboBoxT2DownMod, comboBoxT2DownKey, useT2DownHotKey);
        }

        private void updateHotKey(int hotKeyId, string hotKeyName, ComboBox modBox, ComboBox keyBox, CheckBox useBox)
        {
            int hotKeyMod = NOMOD;
            string hotKeyModRaw = modBox.SelectedItem.ToString();

            if (hotKeyModRaw == "ALT")
            {
                hotKeyMod = ALT;
            }
            else if (hotKeyModRaw == "CTRL")
            {
                hotKeyMod = CTRL;
            }
            else if (hotKeyModRaw == "SHIFT")
            {
                hotKeyMod = SHIFT;
            }
            else if (hotKeyModRaw == "WIN")
            {
                hotKeyMod = WIN;
            }

            int hotKeyCode = 0;
            string hotKeyCodeRaw = keyBox.SelectedItem.ToString();

            if (hotKeyCodeRaw == "0")
            {
                hotKeyCode = (int)Keys.D0;
            }
            else if (hotKeyCodeRaw == "1")
            {
                hotKeyCode = (int)Keys.D1;
            }
            else if (hotKeyCodeRaw == "2")
            {
                hotKeyCode = (int)Keys.D2;
            }
            else if (hotKeyCodeRaw == "3")
            {
                hotKeyCode = (int)Keys.D3;
            }
            else if (hotKeyCodeRaw == "4")
            {
                hotKeyCode = (int)Keys.D4;
            }
            else if (hotKeyCodeRaw == "5")
            {
                hotKeyCode = (int)Keys.D5;
            }
            else if (hotKeyCodeRaw == "6")
            {
                hotKeyCode = (int)Keys.D6;
            }
            else if (hotKeyCodeRaw == "7")
            {
                hotKeyCode = (int)Keys.D7;
            }
            else if (hotKeyCodeRaw == "8")
            {
                hotKeyCode = (int)Keys.D8;
            }
            else if (hotKeyCodeRaw == "9")
            {
                hotKeyCode = (int)Keys.D9;
            }
            else if (hotKeyCodeRaw == "A")
            {
                hotKeyCode = (int)Keys.A;
            }
            else if (hotKeyCodeRaw == "B")
            {
                hotKeyCode = (int)Keys.B;
            }
            else if (hotKeyCodeRaw == "C")
            {
                hotKeyCode = (int)Keys.C;
            }
            else if (hotKeyCodeRaw == "D")
            {
                hotKeyCode = (int)Keys.D;
            }
            else if (hotKeyCodeRaw == "E")
            {
                hotKeyCode = (int)Keys.E;
            }
            else if (hotKeyCodeRaw == "F")
            {
                hotKeyCode = (int)Keys.F;
            }
            else if (hotKeyCodeRaw == "G")
            {
                hotKeyCode = (int)Keys.G;
            }
            else if (hotKeyCodeRaw == "H")
            {
                hotKeyCode = (int)Keys.H;
            }
            else if (hotKeyCodeRaw == "I")
            {
                hotKeyCode = (int)Keys.I;
            }
            else if (hotKeyCodeRaw == "J")
            {
                hotKeyCode = (int)Keys.J;
            }
            else if (hotKeyCodeRaw == "K")
            {
                hotKeyCode = (int)Keys.K;
            }
            else if (hotKeyCodeRaw == "L")
            {
                hotKeyCode = (int)Keys.L;
            }
            else if (hotKeyCodeRaw == "M")
            {
                hotKeyCode = (int)Keys.M;
            }
            else if (hotKeyCodeRaw == "N")
            {
                hotKeyCode = (int)Keys.N;
            }
            else if (hotKeyCodeRaw == "O")
            {
                hotKeyCode = (int)Keys.O;
            }
            else if (hotKeyCodeRaw == "P")
            {
                hotKeyCode = (int)Keys.P;
            }
            else if (hotKeyCodeRaw == "Q")
            {
                hotKeyCode = (int)Keys.Q;
            }
            else if (hotKeyCodeRaw == "R")
            {
                hotKeyCode = (int)Keys.R;
            }
            else if (hotKeyCodeRaw == "S")
            {
                hotKeyCode = (int)Keys.S;
            }
            else if (hotKeyCodeRaw == "T")
            {
                hotKeyCode = (int)Keys.T;
            }
            else if (hotKeyCodeRaw == "U")
            {
                hotKeyCode = (int)Keys.U;
            }
            else if (hotKeyCodeRaw == "V")
            {
                hotKeyCode = (int)Keys.V;
            }
            else if (hotKeyCodeRaw == "W")
            {
                hotKeyCode = (int)Keys.W;
            }
            else if (hotKeyCodeRaw == "X")
            {
                hotKeyCode = (int)Keys.X;
            }
            else if (hotKeyCodeRaw == "Y")
            {
                hotKeyCode = (int)Keys.Y;
            }
            else if (hotKeyCodeRaw == "Z")
            {
                hotKeyCode = (int)Keys.Z;
            }
            else if (hotKeyCodeRaw == "Numlock")
            {
                hotKeyCode = (int)Keys.NumLock;
            }
            else if (hotKeyCodeRaw == "Numpad 0")
            {
                hotKeyCode = (int)Keys.NumPad0;
            }
            else if (hotKeyCodeRaw == "Numpad 1")
            {
                hotKeyCode = (int)Keys.NumPad1;
            }
            else if (hotKeyCodeRaw == "Numpad 2")
            {
                hotKeyCode = (int)Keys.NumPad2;
            }
            else if (hotKeyCodeRaw == "Numpad 3")
            {
                hotKeyCode = (int)Keys.NumPad3;
            }
            else if (hotKeyCodeRaw == "Numpad 4")
            {
                hotKeyCode = (int)Keys.NumPad4;
            }
            else if (hotKeyCodeRaw == "Numpad 5")
            {
                hotKeyCode = (int)Keys.NumPad5;
            }
            else if (hotKeyCodeRaw == "Numpad 6")
            {
                hotKeyCode = (int)Keys.NumPad6;
            }
            else if (hotKeyCodeRaw == "Numpad 7")
            {
                hotKeyCode = (int)Keys.NumPad7;
            }
            else if (hotKeyCodeRaw == "Numpad 8")
            {
                hotKeyCode = (int)Keys.NumPad8;
            }
            else if (hotKeyCodeRaw == "Numpad 9")
            {
                hotKeyCode = (int)Keys.NumPad9;
            }
            else if (hotKeyCodeRaw == "F1")
            {
                hotKeyCode = (int)Keys.F1;
            }
            else if (hotKeyCodeRaw == "F2")
            {
                hotKeyCode = (int)Keys.F2;
            }
            else if (hotKeyCodeRaw == "F3")
            {
                hotKeyCode = (int)Keys.F3;
            }
            else if (hotKeyCodeRaw == "F4")
            {
                hotKeyCode = (int)Keys.F4;
            }
            else if (hotKeyCodeRaw == "F5")
            {
                hotKeyCode = (int)Keys.F5;
            }
            else if (hotKeyCodeRaw == "F6")
            {
                hotKeyCode = (int)Keys.F6;
            }
            else if (hotKeyCodeRaw == "F7")
            {
                hotKeyCode = (int)Keys.F7;
            }
            else if (hotKeyCodeRaw == "F8")
            {
                hotKeyCode = (int)Keys.F8;
            }
            else if (hotKeyCodeRaw == "F9")
            {
                hotKeyCode = (int)Keys.F9;
            }
            else if (hotKeyCodeRaw == "F10")
            {
                hotKeyCode = (int)Keys.F10;
            }
            else if (hotKeyCodeRaw == "F11")
            {
                hotKeyCode = (int)Keys.F11;
            }
            else if (hotKeyCodeRaw == "F12")
            {
                hotKeyCode = (int)Keys.F12;
            }
            else if (hotKeyCodeRaw == "Backspace")
            {
                hotKeyCode = (int)Keys.Back;
            }
            else if (hotKeyCodeRaw == "Enter")
            {
                hotKeyCode = (int)Keys.Enter;
            }
            else if (hotKeyCodeRaw == "Tab")
            {
                hotKeyCode = (int)Keys.Tab;
            }
            else if (hotKeyCodeRaw == "Escape")
            {
                hotKeyCode = (int)Keys.Escape;
            }
            else if (hotKeyCodeRaw == "Space")
            {
                hotKeyCode = (int)Keys.Space;
            }
            else if (hotKeyCodeRaw == "Page Up")
            {
                hotKeyCode = (int)Keys.PageUp;
            }
            else if (hotKeyCodeRaw == "Page Down")
            {
                hotKeyCode = (int)Keys.PageDown;
            }
            else if (hotKeyCodeRaw == "End")
            {
                hotKeyCode = (int)Keys.End;
            }
            else if (hotKeyCodeRaw == "Home")
            {
                hotKeyCode = (int)Keys.Home;
            }
            else if (hotKeyCodeRaw == "Left")
            {
                hotKeyCode = (int)Keys.Left;
            }
            else if (hotKeyCodeRaw == "Right")
            {
                hotKeyCode = (int)Keys.Right;
            }
            else if (hotKeyCodeRaw == "Up")
            {
                hotKeyCode = (int)Keys.Up;
            }
            else if (hotKeyCodeRaw == "Down")
            {
                hotKeyCode = (int)Keys.Down;
            }
            else if (hotKeyCodeRaw == "Insert")
            {
                hotKeyCode = (int)Keys.Insert;
            }
            else if (hotKeyCodeRaw == "Delete")
            {
                hotKeyCode = (int)Keys.Delete;
            }

            UnregisterHotKey(this.Handle, hotKeyId);
            if (useBox.Checked)
            {
                File.WriteAllText(path + "\\Settings\\" + hotKeyName + "Mod.txt", hotKeyModRaw);
                File.WriteAllText(path + "\\Settings\\" + hotKeyName + "Key.txt", hotKeyCodeRaw);
                RegisterHotKey(this.Handle, hotKeyId, hotKeyMod, hotKeyCode);
            }
            else
            {
                File.WriteAllText(path + "\\Settings\\" + hotKeyName + "Mod.txt", "NO_USE");
            }
        }

        private void loadHotKey(int hotKeyId, string folder, string hotKeyName, ComboBox modBox, ComboBox keyBox, CheckBox useBox)
        {
            if (File.Exists(path + "\\" + folder + "\\" + hotKeyName + "Mod.txt") && File.Exists(path + "\\" + folder + "\\" + hotKeyName + "Key.txt"))
            {
                string loadingText = File.ReadAllText(path + "\\" + folder + "\\" + hotKeyName + "Mod.txt");
                modBox.SelectedIndex = modBox.FindString(loadingText.Trim());

                int hotKeyMod = NOMOD;
                if (loadingText == "ALT")
                {
                    hotKeyMod = ALT;
                }
                else if (loadingText == "CTRL")
                {
                    hotKeyMod = CTRL;
                }
                else if (loadingText == "SHIFT")
                {
                    hotKeyMod = SHIFT;
                }
                else if (loadingText == "WIN")
                {
                    hotKeyMod = WIN;
                }
                else if (loadingText == "NO_USE")
                {
                    return;
                }

                loadingText = File.ReadAllText(path + "\\" + folder + "\\" + hotKeyName + "Key.txt");
                keyBox.SelectedIndex = keyBox.FindString(loadingText.Trim());

                int hotKeyCode = 0;
                if (loadingText == "0")
                {
                    hotKeyCode = (int)Keys.D0;
                }
                else if (loadingText == "1")
                {
                    hotKeyCode = (int)Keys.D1;
                }
                else if (loadingText == "2")
                {
                    hotKeyCode = (int)Keys.D2;
                }
                else if (loadingText == "3")
                {
                    hotKeyCode = (int)Keys.D3;
                }
                else if (loadingText == "4")
                {
                    hotKeyCode = (int)Keys.D4;
                }
                else if (loadingText == "5")
                {
                    hotKeyCode = (int)Keys.D5;
                }
                else if (loadingText == "6")
                {
                    hotKeyCode = (int)Keys.D6;
                }
                else if (loadingText == "7")
                {
                    hotKeyCode = (int)Keys.D7;
                }
                else if (loadingText == "8")
                {
                    hotKeyCode = (int)Keys.D8;
                }
                else if (loadingText == "9")
                {
                    hotKeyCode = (int)Keys.D9;
                }
                else if (loadingText == "A")
                {
                    hotKeyCode = (int)Keys.A;
                }
                else if (loadingText == "B")
                {
                    hotKeyCode = (int)Keys.B;
                }
                else if (loadingText == "C")
                {
                    hotKeyCode = (int)Keys.C;
                }
                else if (loadingText == "D")
                {
                    hotKeyCode = (int)Keys.D;
                }
                else if (loadingText == "E")
                {
                    hotKeyCode = (int)Keys.E;
                }
                else if (loadingText == "F")
                {
                    hotKeyCode = (int)Keys.F;
                }
                else if (loadingText == "G")
                {
                    hotKeyCode = (int)Keys.G;
                }
                else if (loadingText == "H")
                {
                    hotKeyCode = (int)Keys.H;
                }
                else if (loadingText == "I")
                {
                    hotKeyCode = (int)Keys.I;
                }
                else if (loadingText == "J")
                {
                    hotKeyCode = (int)Keys.J;
                }
                else if (loadingText == "K")
                {
                    hotKeyCode = (int)Keys.K;
                }
                else if (loadingText == "L")
                {
                    hotKeyCode = (int)Keys.L;
                }
                else if (loadingText == "M")
                {
                    hotKeyCode = (int)Keys.M;
                }
                else if (loadingText == "N")
                {
                    hotKeyCode = (int)Keys.N;
                }
                else if (loadingText == "O")
                {
                    hotKeyCode = (int)Keys.O;
                }
                else if (loadingText == "P")
                {
                    hotKeyCode = (int)Keys.P;
                }
                else if (loadingText == "Q")
                {
                    hotKeyCode = (int)Keys.Q;
                }
                else if (loadingText == "R")
                {
                    hotKeyCode = (int)Keys.R;
                }
                else if (loadingText == "S")
                {
                    hotKeyCode = (int)Keys.S;
                }
                else if (loadingText == "T")
                {
                    hotKeyCode = (int)Keys.T;
                }
                else if (loadingText == "U")
                {
                    hotKeyCode = (int)Keys.U;
                }
                else if (loadingText == "V")
                {
                    hotKeyCode = (int)Keys.V;
                }
                else if (loadingText == "W")
                {
                    hotKeyCode = (int)Keys.W;
                }
                else if (loadingText == "X")
                {
                    hotKeyCode = (int)Keys.X;
                }
                else if (loadingText == "Y")
                {
                    hotKeyCode = (int)Keys.Y;
                }
                else if (loadingText == "Z")
                {
                    hotKeyCode = (int)Keys.Z;
                }
                else if (loadingText == "Numlock")
                {
                    hotKeyCode = (int)Keys.NumLock;
                }
                else if (loadingText == "Numpad 0")
                {
                    hotKeyCode = (int)Keys.NumPad0;
                }
                else if (loadingText == "Numpad 1")
                {
                    hotKeyCode = (int)Keys.NumPad1;
                }
                else if (loadingText == "Numpad 2")
                {
                    hotKeyCode = (int)Keys.NumPad2;
                }
                else if (loadingText == "Numpad 3")
                {
                    hotKeyCode = (int)Keys.NumPad3;
                }
                else if (loadingText == "Numpad 4")
                {
                    hotKeyCode = (int)Keys.NumPad4;
                }
                else if (loadingText == "Numpad 5")
                {
                    hotKeyCode = (int)Keys.NumPad5;
                }
                else if (loadingText == "Numpad 6")
                {
                    hotKeyCode = (int)Keys.NumPad6;
                }
                else if (loadingText == "Numpad 7")
                {
                    hotKeyCode = (int)Keys.NumPad7;
                }
                else if (loadingText == "Numpad 8")
                {
                    hotKeyCode = (int)Keys.NumPad8;
                }
                else if (loadingText == "Numpad 9")
                {
                    hotKeyCode = (int)Keys.NumPad9;
                }
                else if (loadingText == "F1")
                {
                    hotKeyCode = (int)Keys.F1;
                }
                else if (loadingText == "F2")
                {
                    hotKeyCode = (int)Keys.F2;
                }
                else if (loadingText == "F3")
                {
                    hotKeyCode = (int)Keys.F3;
                }
                else if (loadingText == "F4")
                {
                    hotKeyCode = (int)Keys.F4;
                }
                else if (loadingText == "F5")
                {
                    hotKeyCode = (int)Keys.F5;
                }
                else if (loadingText == "F6")
                {
                    hotKeyCode = (int)Keys.F6;
                }
                else if (loadingText == "F7")
                {
                    hotKeyCode = (int)Keys.F7;
                }
                else if (loadingText == "F8")
                {
                    hotKeyCode = (int)Keys.F8;
                }
                else if (loadingText == "F9")
                {
                    hotKeyCode = (int)Keys.F9;
                }
                else if (loadingText == "F10")
                {
                    hotKeyCode = (int)Keys.F10;
                }
                else if (loadingText == "F11")
                {
                    hotKeyCode = (int)Keys.F11;
                }
                else if (loadingText == "F12")
                {
                    hotKeyCode = (int)Keys.F12;
                }
                else if (loadingText == "Backspace")
                {
                    hotKeyCode = (int)Keys.Back;
                }
                else if (loadingText == "Enter")
                {
                    hotKeyCode = (int)Keys.Enter;
                }
                else if (loadingText == "Tab")
                {
                    hotKeyCode = (int)Keys.Tab;
                }
                else if (loadingText == "Escape")
                {
                    hotKeyCode = (int)Keys.Escape;
                }
                else if (loadingText == "Space")
                {
                    hotKeyCode = (int)Keys.Space;
                }
                else if (loadingText == "Page Up")
                {
                    hotKeyCode = (int)Keys.PageUp;
                }
                else if (loadingText == "Page Down")
                {
                    hotKeyCode = (int)Keys.PageDown;
                }
                else if (loadingText == "End")
                {
                    hotKeyCode = (int)Keys.End;
                }
                else if (loadingText == "Home")
                {
                    hotKeyCode = (int)Keys.Home;
                }
                else if (loadingText == "Left")
                {
                    hotKeyCode = (int)Keys.Left;
                }
                else if (loadingText == "Right")
                {
                    hotKeyCode = (int)Keys.Right;
                }
                else if (loadingText == "Up")
                {
                    hotKeyCode = (int)Keys.Up;
                }
                else if (loadingText == "Down")
                {
                    hotKeyCode = (int)Keys.Down;
                }
                else if (loadingText == "Insert")
                {
                    hotKeyCode = (int)Keys.Insert;
                }
                else if (loadingText == "Delete")
                {
                    hotKeyCode = (int)Keys.Delete;
                }

                RegisterHotKey(this.Handle, hotKeyId, hotKeyMod, hotKeyCode);
                useBox.Checked = true;
            }
        }
    }
}
