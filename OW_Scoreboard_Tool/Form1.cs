using Microsoft.WindowsAPICodePack.Shell;
using OW_Scoreboard_Tool.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace OW_Scoreboard_Tool
{
    public partial class Form1 : Form
    {
        #region Inital Properties
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string main = "\\Replay";
        string playlist = "\\Playlist";
        string xmlVersion = "0.2";
        const int Bytes_TO_READ = sizeof(Int64);
        Series Match1 = new Series();


        List<Role> RoleList = new List<Role>
        {
            new Role()
        };
        List<Hero> HeroList = new List<Hero>
        {
            new Hero()
        };
        List<Gametype> GametypeList = new List<Gametype>
        {
            new Gametype()
        };
        List<Map> MapList = new List<Map>
        {
            new Map()
        };

        List<string> FolderList;
        List<string> Match1Files;
        List<string> GeneralFiles;
        List<string> PlayerFiles;
        List<string> SettingFiles;

        #endregion

        public Form1()
        {
            InitializeComponent();

            GenerateRoles();
            GenerateHeroes();
            GenerateGametypes();
            GenerateMaps();
            GenerateFolderList();
            GenerateFileList();

            CheckFolders();
            CheckFiles();

            CreateFileWatcher(path + FolderList[4]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadText(m1MutualInfo, "Match1", "DivisionNumber");

            loadScore(m1t1Score, "Match1", "t1Score");
            loadText(m1t1Name, "Match1", "t1Name");
            loadText(m1t1SR, "Match1", "t1SR");
            loadText(m1t1p1Name, "Match1", "t1p1Name");
            loadText(m1t1p2Name, "Match1", "t1p2Name");
            loadText(m1t1p3Name, "Match1", "t1p3Name");
            loadText(m1t1p4Name, "Match1", "t1p4Name");
            loadText(m1t1p5Name, "Match1", "t1p5Name");
            loadText(m1t1p6Name, "Match1", "t1p6Name");
            loadText(m1t1Logo, "Match1", "t1Logo");
            loadColor(m1t1Color, m1t1ColorButton, "Match1", "t1Color");

            loadScore(m1t2Score, "Match1", "t2Score");
            loadText(m1t2Name, "Match1", "t2Name");
            loadText(m1t2SR, "Match1", "t2SR");
            loadText(m1t2p1Name, "Match1", "t2p1Name");
            loadText(m1t2p2Name, "Match1", "t2p2Name");
            loadText(m1t2p3Name, "Match1", "t2p3Name");
            loadText(m1t2p4Name, "Match1", "t2p4Name");
            loadText(m1t2p5Name, "Match1", "t2p5Name");
            loadText(m1t2p6Name, "Match1", "t2p6Name");
            loadText(m1t2Logo, "Match1", "t2Logo");
            loadColor(m1t2Color, m1t2ColorButton, "Match1", "t2Color");

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

            loadText(playerBox, "Player", "player");
            loadText(playerTeamBox, "Player", "team");
            loadText(playerTeamLogoBox, "Player", "logo");
            loadText(playerSRBox, "Player", "sr");

            loadCombo(playerHeroBox1, "Player", "hero1");
            loadCombo(playerHeroBox2, "Player", "hero2");
            loadCombo(playerHeroBox3, "Player", "hero3");
            loadCombo(playerRoleBox, "Player", "role");

            updateSeries();

            //FileSystemWatcher watcher = new FileSystemWatcher();

            //watcher.Path = path + FolderList[5];
            //watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.Size;
            //watcher.EnableRaisingEvents = true;
            //watcher.Changed += new FileSystemEventHandler(Changed);

            //updateList();
        }

        private void Changed(object sender, FileSystemEventArgs e)
        {
            updateList();
        }

        private void updateList()
        {
            listView1.Clear();
            var di = new DirectoryInfo(path+FolderList[5]);
            int imageIndex = 0;
            foreach (FileInfo fi in di.GetFiles())
            {
                ShellFile shellFile = ShellFile.FromFilePath(fi.FullName);
                Bitmap shellThumb = shellFile.Thumbnail.Bitmap;
                imageList1.Images.Add(shellThumb);
                ListViewItem item = new ListViewItem();
                item.Text = fi.Name;
                item.ImageIndex = imageIndex;
                listView1.Items.Add(item);
                imageIndex++;
            }
        }

        #region Button Actions
        /// <summary>
        /// Button to swap team information
        /// </summary>
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

            Color tempColor = new Color();
            tempColor = m1t1Color.Color;
            m1t1Color.Color = m1t2Color.Color;
            m1t1ColorButton.BackColor = m1t1Color.Color;
            m1t2Color.Color = tempColor;
            m1t2ColorButton.BackColor = m1t2Color.Color;
        }

        /// <summary>
        /// Button to reset series information
        /// </summary>
        private void m1ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove all match data?", "Reset Match Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                resetText(m1MutualInfo);

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

                resetColor(m1t1Color, m1t1ColorButton);
                resetColor(m1t2Color, m1t2ColorButton);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        /// <summary>
        /// Button to reset general information
        /// </summary>
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

        /// <summary>
        /// Button to update series information
        /// </summary>
        private void m1UpdateButton_Click(object sender, EventArgs e)
        {
            updateText(m1MutualInfo, "Match1", "DivisionNumber");

            updateScore(m1t1Score, "Match1", "t1Score");
            updateText(m1t1Name, "Match1", "t1Name");
            updateText(m1t1SR, "Match1", "t1SR");
            updateText(m1t1p1Name, "Match1", "t1p1Name");
            updateText(m1t1p2Name, "Match1", "t1p2Name");
            updateText(m1t1p3Name, "Match1", "t1p3Name");
            updateText(m1t1p4Name, "Match1", "t1p4Name");
            updateText(m1t1p5Name, "Match1", "t1p5Name");
            updateText(m1t1p6Name, "Match1", "t1p6Name");
            updateColor(m1t1Color, "Match1", "t1Color");

            updateScore(m1t2Score, "Match1", "t2Score");
            updateText(m1t2Name, "Match1", "t2Name");
            updateText(m1t2SR, "Match1", "t2SR");
            updateText(m1t2p1Name, "Match1", "t2p1Name");
            updateText(m1t2p2Name, "Match1", "t2p2Name");
            updateText(m1t2p3Name, "Match1", "t2p3Name");
            updateText(m1t2p4Name, "Match1", "t2p4Name");
            updateText(m1t2p5Name, "Match1", "t2p5Name");
            updateText(m1t2p6Name, "Match1", "t2p6Name");
            updateColor(m1t2Color, "Match1", "t2Color");

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

            updateCompleted(m1m1Completed, m1t1Name, m1t2Name, m1m1t1Score, m1m1t2Score, "Match1", "m1MapWin", m1t1Logo, m1t2Logo);
            updateCompleted(m1m2Completed, m1t1Name, m1t2Name, m1m2t1Score, m1m2t2Score, "Match1", "m2MapWin", m1t1Logo, m1t2Logo);
            updateCompleted(m1m3Completed, m1t1Name, m1t2Name, m1m3t1Score, m1m3t2Score, "Match1", "m3MapWin", m1t1Logo, m1t2Logo);
            updateCompleted(m1m4Completed, m1t1Name, m1t2Name, m1m4t1Score, m1m4t2Score, "Match1", "m4MapWin", m1t1Logo, m1t2Logo);
            updateCompleted(m1m5Completed, m1t1Name, m1t2Name, m1m5t1Score, m1m5t2Score, "Match1", "m5MapWin", m1t1Logo, m1t2Logo);
            updateCompleted(m1m6Completed, m1t1Name, m1t2Name, m1m6t1Score, m1m6t2Score, "Match1", "m6MapWin", m1t1Logo, m1t2Logo);
            updateCompleted(m1m7Completed, m1t1Name, m1t2Name, m1m7t1Score, m1m7t2Score, "Match1", "m7MapWin", m1t1Logo, m1t2Logo);

            updateLogos(m1t1Logo, "Match1", "t1Logo");
            updateLogos(m1t2Logo, "Match1", "t2Logo");
            updateText(m1t1Logo, "Match1", "t1Logo");
            updateText(m1t2Logo, "Match1", "t2Logo");

            updateSeries();

            //Match1.printAll();

        }

        /// <summary>
        /// Button to update general information
        /// </summary>
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

        /// <summary>
        /// Toolbar option to export series information
        /// </summary>
        private void exportSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportSeries();
        }

        /// <summary>
        /// Toolbar option to import series information
        /// </summary>
        private void importSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importSeries();
        }

        /// <summary>
        /// Toolbar option to import home team information
        /// </summary>
        private void importHomeTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importTeam("h");
        }

        /// <summary>
        /// Toolbar option to import away team information
        /// </summary>
        private void importAwayTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importTeam("a");
        }

        /// <summary>
        /// Toolbar option to export home team information
        /// </summary>
        private void exportHomeTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTeam("h");
        }

        /// <summary>
        /// Toolbar option to export away team information
        /// </summary>
        private void exportAwayTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTeam("a");
        }

        /// <summary>
        /// Button to reset the replay playlist folder
        /// </summary>
        private void replayReset_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(path + FolderList[5]);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

        /// <summary>
        /// Button to clean dirty files from the replay playlist folder
        /// </summary>
        private void replayClean_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(path + FolderList[5]);
            foreach (FileInfo file in di.GetFiles())
            {

                if (file.Length < 1000000 || file.Length == 0)
                {
                    file.Delete();
                }
            }
        }

        /// <summary>
        /// Button to get the home team logo
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t1Logo);
        }

        /// <summary>
        /// Button to get the away team logo
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t2Logo);
        }

        /// <summary>
        /// Button to set the home team color
        /// </summary>
        private void m1t1ColorButton_Click(object sender, EventArgs e)
        {
            if (m1t1Color.ShowDialog() == DialogResult.OK)
            {
                Match1.Home.Color = ColorTranslator.ToHtml(Color.FromArgb(m1t1Color.Color.ToArgb()));
                m1t1ColorButton.BackColor = m1t1Color.Color;
            }
        }

        /// <summary>
        /// Button to set the away team color
        /// </summary>
        private void m1t2ColorButton_Click(object sender, EventArgs e)
        {
            if (m1t2Color.ShowDialog() == DialogResult.OK)
            {
                Match1.Away.Color = ColorTranslator.ToHtml(Color.FromArgb(m1t2Color.Color.ToArgb()));
                m1t2ColorButton.BackColor = m1t2Color.Color;
            }
        }

        /// <summary>
        /// Button to reset the player of the match information
        /// </summary>
        private void playerReset_Click(object sender, EventArgs e)
        {
            resetText(playerBox);
            resetText(playerTeamBox);
            resetText(playerTeamLogoBox);
            resetText(playerSRBox);

            resetHero(playerHeroBox1);
            resetHero(playerHeroBox2);
            resetHero(playerHeroBox3);
            resetRole(playerRoleBox);
        }

        /// <summary>
        /// Button to update the player of the match information
        /// </summary>
        private void playerUpdate_Click(object sender, EventArgs e)
        {
            updateText(playerBox, "Player", "player");
            updateText(playerTeamBox, "Player", "team");
            updateText(playerSRBox, "Player", "sr");

            updateHero(playerHeroBox1, playerHeroPortrait1, playerHeroIcon1, playerHero3D1, "Player", "hero1");
            updateHero(playerHeroBox2, playerHeroPortrait2, playerHeroIcon2, playerHero3D2, "Player", "hero2");
            updateHero(playerHeroBox3, playerHeroPortrait3, playerHeroIcon3, playerHero3D3, "Player", "hero3");

            updateRole(playerRoleBox, "Player", "role");

            updateLogos(playerTeamLogoBox, "Player", "logo");
        }

        /// <summary>
        /// Button to get the team logo for the player of the match
        /// </summary>
        private void playerTeamLogoButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(playerTeamLogoBox);
        }

        /// <summary>
        /// Opens the About window
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
        #endregion

        #region Updaters
        /// <summary>
        /// Method for writing to the text file for the text box
        /// </summary>
        /// <param name="field">The text box that is being read from</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
        private void updateText(TextBox field, String folder, String file)
        {
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(field.Text.Trim());
            }
        }

        /// <summary>
        /// Method for writing to the text file for the NumericUpDown used for score recording
        /// </summary>
        /// <param name="field">The NumericUpDown that is being read from</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
        private void updateScore(NumericUpDown field, String folder, String file)
        {
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(field.Value.ToString().Trim());
            }
        }

        /// <summary>
        /// Method for writing to the text file for the combobox text and overwriting the image of the hero in that text
        /// </summary>
        /// <param name="field">The Combobox that is being read from</param>
        /// <param name="radio1">Image style, portrait</param>
        /// <param name="radio2">Image style, icon</param>
        /// <param name="radio3">Image style, 3D</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
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
                else if (field.SelectedItem.ToString().Equals("Ashe"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_Ashe.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Ashe.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Ashe.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else if (field.SelectedItem.ToString().Equals("Baptiste"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_Baptiste.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_Baptiste.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Baptiste.Save(path + "\\" + folder + "\\" + file + ".png");
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
                        Properties.Resources.Reinhardt.Save(path + "\\" + folder + "\\" + file + ".png");
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
                        Properties.Resources.Symmetra.Save(path + "\\" + folder + "\\" + file + ".png");
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
                else if (field.SelectedItem.ToString().Equals("Wrecking Ball"))
                {
                    if (radio2.Checked == true)
                    {
                        Properties.Resources.Icon_Wrecking_Ball.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio3.Checked == true)
                    {
                        Properties.Resources._3D_WreckingBall.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.WreckingBall.Save(path + "\\" + folder + "\\" + file + ".png");
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

        /// <summary>
        /// Method for writing to the text file for the combobox text and overwriting the image of the role in that text
        /// </summary>
        /// <param name="field">The Combobox that is being read from</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
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

        /// <summary>
        /// Method for updating the image used for attack/defend
        /// </summary>
        /// <param name="field">RadioButton stating which side the home team is on</param>
        /// <param name="folder">The target folde</param>
        /// <param name="file1">The file name before the extension for the home team</param>
        /// <param name="file2">The file name before the extension for the away team</param>
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

        /// <summary>
        /// Method for writing to the text file for the combobox text and overwriting the image of the map in that text
        /// </summary>
        /// <param name="field">The Combobox that is being read from</param>
        /// <param name="check">Radio button checked if the map is the current selection</param>
        /// <param name="radio1">Image style, long</param>
        /// <param name="radio2">Image style, full</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
        private void updateMap(ComboBox field, RadioButton check, RadioButton radio1, RadioButton radio2, String folder, String file)
        {

            if (field.SelectedItem != null)
            {
                String gametype = "";
                if (field.Text == "Busan")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Busan.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_busan.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Busan.Save(path + "\\" + folder + "\\" + file + ".png");
                    }

                    Properties.Resources.Icon_control.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Control";
                }
                else if (field.Text == "Blizzard World")
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
                else if (field.Text == "Paris")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Paris.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_paris.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Paris.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_assault.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Assault";
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
                else if (field.Text == "Rialto")
                {
                    if (radio2.Checked == true && check.Checked == true)
                    {
                        Properties.Resources.Color_Rialto.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else if (radio1.Checked == true)
                    {
                        Properties.Resources.Icon_rialto.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    else
                    {
                        Properties.Resources.Desat_Rialto.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    Properties.Resources.Icon_escort.Save(path + "\\" + folder + "\\" + file + "Gametype" + ".png");
                    gametype = "Escort";
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

        /// <summary>
        /// Method for writing to the text file and overwriting the logo for the map winner
        /// </summary>
        /// <param name="field">Checkbox for if a map has been completed</param>
        /// <param name="team1">Home Team name</param>
        /// <param name="team2">Away Team name</param>
        /// <param name="score1">Home Team map score</param>
        /// <param name="score2">Away Team map score</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
        /// <param name="team1Logo">Team 1 logo</param>
        /// <param name="team2Logo">Team 2 logo</param>
        private void updateCompleted(CheckBox field, TextBox team1, TextBox team2, NumericUpDown score1, NumericUpDown score2, String folder, String file, TextBox team1Logo, TextBox team2Logo)
        {
            string winner = "";
            string winnerLogo = "";

            if (field.Checked == true)
            {
                if (score1.Value > score2.Value)
                {
                    winner = team1.Text;
                    winnerLogo = team1Logo.Text;
                    TextBox temp = new TextBox();
                    temp.Text = winnerLogo;
                    updateLogos(temp, folder, file);

                }
                else if (score2.Value > score1.Value)
                {
                    winner = team2.Text;
                    winnerLogo = team2Logo.Text;
                    TextBox temp = new TextBox();
                    temp.Text = winnerLogo;
                    updateLogos(temp, folder, file);
                }
                else
                {
                    winner = "DRAW";
                    Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + ".png");

                }

                using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
                {
                    sw.WriteLine(winner.Trim());
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
                {
                    sw.WriteLine(winner.Trim());
                }
                Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + ".png");
            }
        }

        /// <summary>
        /// Method for updating the logo of a team
        /// </summary>
        /// <param name="field">The text box that is being read from</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
        public void updateLogos(TextBox field, String folder, String file)
        {
            if (field.Text != "")
            {
                try
                {
                    Bitmap logo = new Bitmap(field.Text);
                    logo.Save(path + "\\" + folder + "\\" + file + ".png");
                }
                catch(Exception e)
                {
                    MessageBox.Show("The path \"" + path + "\\" + folder + "\\" + file + ".png" + "\" does not exist!");
                    field.Text = "";
                    Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + ".png");
                }
            }
            else
            {
                Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + ".png");
            }
        }

        /// <summary>
        /// Method for writing to the text file for the color dialog
        /// </summary>
        /// <param name="field">The color dialog that is being read from</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
        private void updateColor(ColorDialog field, String folder, String file)
        {
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(ColorTranslator.ToHtml(Color.FromArgb(field.Color.ToArgb())));
            }
        }

        /// <summary>
        /// Method for updating the Series of the form
        /// </summary>
        public void updateSeries()
        {
            Match1 = new Series("Match1", updateTeams("h"), updateTeams("a"), updateMapPool(), m1t1Score.Value.ToString(), m1t2Score.Value.ToString());
            Match1.Games[0].HomeScore = m1m1t1Score.Value.ToString();
            Match1.Games[0].AwayScore = m1m1t2Score.Value.ToString();
            Match1.Games[1].HomeScore = m1m2t1Score.Value.ToString();
            Match1.Games[1].AwayScore = m1m2t2Score.Value.ToString();
            Match1.Games[2].HomeScore = m1m3t1Score.Value.ToString();
            Match1.Games[2].AwayScore = m1m3t2Score.Value.ToString();
            Match1.Games[3].HomeScore = m1m4t1Score.Value.ToString();
            Match1.Games[3].AwayScore = m1m4t2Score.Value.ToString();
            Match1.Games[4].HomeScore = m1m5t1Score.Value.ToString();
            Match1.Games[4].AwayScore = m1m5t2Score.Value.ToString();
            Match1.Games[5].HomeScore = m1m6t1Score.Value.ToString();
            Match1.Games[5].AwayScore = m1m6t2Score.Value.ToString();
            Match1.Games[6].HomeScore = m1m7t1Score.Value.ToString();
            Match1.Games[6].AwayScore = m1m7t2Score.Value.ToString();
            Match1.Version = xmlVersion;
        }

        /// <summary>
        /// Method used for updating the players based on team side provided
        /// </summary>
        /// <param name="side">The side of the team</param>
        /// <returns>Lists of players</returns>
        public List<Player> updatePlayers(string side)
        {
            List<Player> players = new List<Player>();
            if (side.Equals("h"))
            {
                players.Add(new Player(m1t1p1Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t1p1Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t1p1Role.Text)));
                players.Add(new Player(m1t1p2Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t1p2Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t1p2Role.Text)));
                players.Add(new Player(m1t1p3Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t1p3Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t1p3Role.Text)));
                players.Add(new Player(m1t1p4Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t1p4Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t1p4Role.Text)));
                players.Add(new Player(m1t1p5Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t1p5Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t1p5Role.Text)));
                players.Add(new Player(m1t1p6Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t1p6Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t1p6Role.Text)));
            }
            else if(side.Equals("a"))
            {
                players.Add(new Player(m1t2p1Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t2p1Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t2p1Role.Text)));
                players.Add(new Player(m1t2p2Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t2p2Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t2p2Role.Text)));
                players.Add(new Player(m1t2p3Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t2p3Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t2p3Role.Text)));
                players.Add(new Player(m1t2p4Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t2p4Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t2p4Role.Text)));
                players.Add(new Player(m1t2p5Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t2p5Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t2p5Role.Text)));
                players.Add(new Player(m1t2p6Name.Text, new List<Hero> { HeroList.FirstOrDefault(s => s.Name == m1t2p6Hero.Text) }, RoleList.FirstOrDefault(s => s.Name == m1t2p6Role.Text)));
            }
            return players;

        }

        /// <summary>
        /// Method used for updating the team based on the team side provided
        /// </summary>
        /// <param name="side">The side of the team</param>
        /// <returns></returns>
        public Team updateTeams(string side)
        {
            Team team = new Team();
            if (side.Equals("h"))
            {
                team = new Team(m1t1Name.Text, m1t1SR.Text, m1t1Logo.Text, updatePlayers(side));
                if(Match1.Home == null)
                {
                    Match1.Home = team;
                }
            }
            else if (side.Equals("a"))
            {
                team = new Team(m1t2Name.Text, m1t2SR.Text, m1t2Logo.Text, updatePlayers(side));
                if (Match1.Away == null)
                {
                    Match1.Away = team;
                }
            }
            team.Version = xmlVersion;
            return team;

        }
        
        /// <summary>
        /// Method for updating the Map Pool of a series
        /// </summary>
        /// <returns>The list of all different games in the series</returns>
        public List<Game> updateMapPool()
        {
            List<Map> mapPerGame = new List<Map>
            {
                MapList.SingleOrDefault(s => s.Name == m1m1Map.Text),
                MapList.SingleOrDefault(s => s.Name == m1m2Map.Text),
                MapList.SingleOrDefault(s => s.Name == m1m3Map.Text),
                MapList.SingleOrDefault(s => s.Name == m1m4Map.Text),
                MapList.SingleOrDefault(s => s.Name == m1m5Map.Text),
                MapList.SingleOrDefault(s => s.Name == m1m6Map.Text),
                MapList.SingleOrDefault(s => s.Name == m1m7Map.Text)
            };

            List<Game> mapPool = new List<Game>();
            foreach(Map m in mapPerGame){
                mapPool.Add(new Game(m, false, false, "0", "0", new Team()));
            }

            return mapPool;
        }

        #endregion

        #region Loaders
        /// <summary>
        /// Method for loading the text box based on the file being read
        /// </summary>
        /// <param name="field">The text box that is being written to</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
        private void loadText(TextBox field, String folder, String file)
        {
            if (File.Exists(path + "\\" + folder + "\\" + file + ".txt"))
            {
                string loadingText = File.ReadAllText(path + "\\" + folder + "\\" + file + ".txt");
                field.Text = loadingText;
                field.Text.Trim();
            }
            else
            {
                File.Create(path + "\\" + folder + "\\" + file + ".txt");
            }

        }

        /// <summary>
        /// Method for loading the NumericUpDown text based on the file being reaad
        /// </summary>
        /// <param name="field">The NumericUpDown that is being written to</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
        private void loadScore(NumericUpDown field, String folder, String file)
        {
            if (File.Exists(path + "\\" + folder + "\\" + file + ".txt"))
            {
                string loadingText = File.ReadAllText(path + "\\" + folder + "\\" + file + ".txt");
                decimal number;
                Decimal.TryParse(loadingText, out number);
                field.Value = number;
            }
            else
            {
                File.Create(path + "\\" + folder + "\\" + file + ".txt");
            }

        }

        /// <summary>
        /// Method for loading the Combobox text based on the file being reaad
        /// </summary>
        /// <param name="field">The Combobox having its item set</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
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
            else
            {
                File.Create(path + "\\" + folder + "\\" + file + ".txt");
            }
        }

        /// <summary>
        /// Method for loading the text box based on the file being read
        /// </summary>
        /// <param name="field">The text box that is being written to</param>
        /// <param name="folder">The target folder</param>
        /// <param name="file">The file name before the extension</param>
        private void loadColor(ColorDialog field, Button button, String folder, String file)
        {
            if (File.Exists(path + "\\" + folder + "\\" + file + ".txt"))
            {
                string loadingText = File.ReadAllText(path + "\\" + folder + "\\" + file + ".txt");
                Color loadedColor = System.Drawing.ColorTranslator.FromHtml(loadingText.Trim());
                field.Color = loadedColor;
                button.BackColor = loadedColor;
            }
            else
            {
                File.Create(path + "\\" + folder + "\\" + file + ".txt");
            }

        }

        /// <summary>
        /// Method for importing a series from an XML
        /// </summary>
        private void importSeries()
        {
            var serializer = new XmlSerializer(typeof(Series));
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = path + FolderList[6];
            dialog.DefaultExt = "xml";
            dialog.Filter = "XML-File | *.xml";
            DialogResult res = dialog.ShowDialog();
            Series series = new Series();
            if (res == DialogResult.OK)
            {
                using (XmlReader reader = XmlReader.Create(dialog.FileName))
                {
                    try
                    {
                        series = (Series)serializer.Deserialize(reader);
                        if (Convert.ToDecimal(series.Version) < Convert.ToDecimal(xmlVersion))
                        {
                            MessageBox.Show("The series you are trying to load may be an older version, some data could be missing!");
                        }
                        else if (Convert.ToDecimal(series.Version) > Convert.ToDecimal(xmlVersion))
                        {
                            MessageBox.Show("The series you are trying to load may be a newer version, some data could be missing!");
                        }
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("There was an issue loading the series, some data could be missing!");
                    }
                    reader.Close();
                }

                Match1 = series;
                Match1.Name = Path.GetFileNameWithoutExtension(dialog.FileName);
                loadSeries();

            }
        }

        /// <summary>
        /// Methodd for loading the series of the form
        /// </summary>
        private void loadSeries()
        {
            loadTeams("h");
            loadTeams("a");
            loadMaps();
        }

        /// <summary>
        /// Method for importing a teaam from an XML
        /// </summary>
        /// <param name="side">Side of the team</param>
        private void importTeam(string side)
        {
            var serializer = new XmlSerializer(typeof(Team));
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = path + FolderList[7];
            dialog.DefaultExt = "xml";
            dialog.Filter = "XML-File | *.xml";
            DialogResult res = dialog.ShowDialog();
            Team team = new Team();
            if (res == DialogResult.OK)
            {
                using (XmlReader reader = XmlReader.Create(dialog.FileName))
                {
                    try
                    {
                        team = (Team)serializer.Deserialize(reader);
                        if (Convert.ToDecimal(team.Version) < Convert.ToDecimal(xmlVersion))
                        {
                            MessageBox.Show("The team you are trying to load may be an older version, some data could be missing!");
                        }
                        else if (Convert.ToDecimal(team.Version) > Convert.ToDecimal(xmlVersion))
                        {
                            MessageBox.Show("The team you are trying to load may be a newer version, some data could be missing!");
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("There was an issue loading the team, some data could be missing!");
                    }
                    reader.Close();
                }
                if(side == "h")
                {
                    Match1.Home = team;
                }
                else
                {
                    Match1.Away = team;
                }
                loadTeams(side);
            }
        }

        /// <summary>
        /// Method for loading the team based on side
        /// </summary>
        /// <param name="side">Side of the team</param>
        private void loadTeams(string side)
        {
            if (side == "h")
            {
                m1t1Name.Text = Match1.Home.Name;
                m1t1Score.Text = Match1.HomeScore;
                m1t1SR.Text = Match1.Home.Sr;
                m1t1Logo.Text = Match1.Home.LogoPath;

                m1t1p1Name.Text = Match1.Home.Players[0].Name;
                try
                {
                    m1t1p1Hero.SelectedIndex = m1t1p1Hero.FindStringExact(Match1.Home.Players[0].Heroes[0].Name);
                }
                catch
                {
                    m1t1p1Hero.SelectedIndex = m1t1p1Hero.FindStringExact("");
                }
                try
                {
                    m1t1p1Role.SelectedIndex = m1t1p1Role.FindStringExact(Match1.Home.Players[0].Role.Name);
                }
                catch
                {
                    m1t1p1Role.SelectedIndex = m1t1p1Role.FindStringExact("");
                }
                m1t1p2Name.Text = Match1.Home.Players[1].Name;
                try
                {
                    m1t1p2Hero.SelectedIndex = m1t1p2Hero.FindStringExact(Match1.Home.Players[1].Heroes[0].Name);
                }
                catch
                {
                    m1t1p2Hero.SelectedIndex = m1t1p2Hero.FindStringExact("");
                }
                try
                {
                    m1t1p2Role.SelectedIndex = m1t1p2Role.FindStringExact(Match1.Home.Players[1].Role.Name);
                }
                catch
                {
                    m1t1p2Role.SelectedIndex = m1t1p2Role.FindStringExact("");
                }
                m1t1p3Name.Text = Match1.Home.Players[2].Name;
                try
                {
                    m1t1p3Hero.SelectedIndex = m1t1p3Hero.FindStringExact(Match1.Home.Players[2].Heroes[0].Name);
                }
                catch
                {
                    m1t1p3Hero.SelectedIndex = m1t1p3Hero.FindStringExact("");
                }
                try
                {
                    m1t1p3Role.SelectedIndex = m1t1p3Role.FindStringExact(Match1.Home.Players[2].Role.Name);
                }
                catch
                {
                    m1t1p3Role.SelectedIndex = m1t1p3Role.FindStringExact("");
                }
                m1t1p4Name.Text = Match1.Home.Players[3].Name;
                try
                {
                    m1t1p4Hero.SelectedIndex = m1t1p4Hero.FindStringExact(Match1.Home.Players[3].Heroes[0].Name);
                }
                catch
                {
                    m1t1p4Hero.SelectedIndex = m1t1p4Hero.FindStringExact("");
                }
                try
                {
                    m1t1p4Role.SelectedIndex = m1t1p4Role.FindStringExact(Match1.Home.Players[3].Role.Name);
                }
                catch
                {
                    m1t1p4Role.SelectedIndex = m1t1p4Role.FindStringExact("");
                }
                m1t1p5Name.Text = Match1.Home.Players[4].Name;
                try
                {
                    m1t1p5Hero.SelectedIndex = m1t1p5Hero.FindStringExact(Match1.Home.Players[4].Heroes[0].Name);
                }
                catch
                {
                    m1t1p5Hero.SelectedIndex = m1t1p5Hero.FindStringExact("");
                }
                try
                {
                    m1t1p5Role.SelectedIndex = m1t1p5Role.FindStringExact(Match1.Home.Players[4].Role.Name);
                }
                catch
                {
                    m1t1p5Role.SelectedIndex = m1t1p5Role.FindStringExact("");
                }
                m1t1p6Name.Text = Match1.Home.Players[5].Name;
                try
                {
                    m1t1p6Hero.SelectedIndex = m1t1p6Hero.FindStringExact(Match1.Home.Players[5].Heroes[0].Name);
                }
                catch
                {
                    m1t1p6Hero.SelectedIndex = m1t1p6Hero.FindStringExact("");
                }
                try
                {
                    m1t1p6Role.SelectedIndex = m1t1p6Role.FindStringExact(Match1.Home.Players[5].Role.Name);
                }
                catch
                {
                    m1t1p6Role.SelectedIndex = m1t1p6Role.FindStringExact("");
                }
            }
            else
            {
                m1t2Name.Text = Match1.Away.Name;
                m1t2Score.Text = Match1.AwayScore;
                m1t2SR.Text = Match1.Away.Sr;
                m1t2Logo.Text = Match1.Away.LogoPath;

                m1t2p1Name.Text = Match1.Away.Players[0].Name;
                try
                {
                    m1t2p1Hero.SelectedIndex = m1t2p1Hero.FindStringExact(Match1.Away.Players[0].Heroes[0].Name);
                }
                catch
                {
                    m1t2p1Hero.SelectedIndex = m1t2p1Hero.FindStringExact("");
                }
                try
                {
                    m1t2p1Role.SelectedIndex = m1t2p1Role.FindStringExact(Match1.Away.Players[0].Role.Name);
                }
                catch
                {
                    m1t2p1Role.SelectedIndex = m1t2p1Role.FindStringExact("");
                }
                m1t2p2Name.Text = Match1.Away.Players[1].Name;
                try
                {
                    m1t2p2Hero.SelectedIndex = m1t2p2Hero.FindStringExact(Match1.Away.Players[1].Heroes[0].Name);
                }
                catch
                {
                    m1t2p2Hero.SelectedIndex = m1t2p2Hero.FindStringExact("");
                }
                try
                {
                    m1t2p2Role.SelectedIndex = m1t2p2Role.FindStringExact(Match1.Away.Players[1].Role.Name);
                }
                catch
                {
                    m1t2p2Role.SelectedIndex = m1t2p2Role.FindStringExact("");
                }
                m1t2p3Name.Text = Match1.Away.Players[2].Name;
                try
                {
                    m1t2p3Hero.SelectedIndex = m1t2p3Hero.FindStringExact(Match1.Away.Players[2].Heroes[0].Name);
                }
                catch
                {
                    m1t2p3Hero.SelectedIndex = m1t2p3Hero.FindStringExact("");
                }
                try
                {
                    m1t2p3Role.SelectedIndex = m1t2p3Role.FindStringExact(Match1.Away.Players[2].Role.Name);
                }
                catch
                {
                    m1t2p3Role.SelectedIndex = m1t2p3Role.FindStringExact("");
                }
                m1t2p4Name.Text = Match1.Away.Players[3].Name;
                try
                {
                    m1t2p4Hero.SelectedIndex = m1t2p4Hero.FindStringExact(Match1.Away.Players[3].Heroes[0].Name);
                }
                catch
                {
                    m1t2p4Hero.SelectedIndex = m1t2p4Hero.FindStringExact("");
                }
                try
                {
                    m1t2p4Role.SelectedIndex = m1t2p4Role.FindStringExact(Match1.Away.Players[3].Role.Name);
                }
                catch
                {
                    m1t2p4Role.SelectedIndex = m1t2p4Role.FindStringExact("");
                }
                m1t2p5Name.Text = Match1.Away.Players[4].Name;
                try
                {
                    m1t2p5Hero.SelectedIndex = m1t2p5Hero.FindStringExact(Match1.Away.Players[4].Heroes[0].Name);
                }
                catch
                {
                    m1t2p5Hero.SelectedIndex = m1t2p5Hero.FindStringExact("");
                }
                try
                {
                    m1t2p5Role.SelectedIndex = m1t2p5Role.FindStringExact(Match1.Away.Players[4].Role.Name);
                }
                catch
                {
                    m1t2p5Role.SelectedIndex = m1t2p5Role.FindStringExact("");
                }
                m1t2p6Name.Text = Match1.Away.Players[5].Name;
                try
                {
                    m1t2p6Hero.SelectedIndex = m1t2p6Hero.FindStringExact(Match1.Away.Players[5].Heroes[0].Name);
                }
                catch
                {
                    m1t2p6Hero.SelectedIndex = m1t2p6Hero.FindStringExact("");
                }
                try
                {
                    m1t2p6Role.SelectedIndex = m1t2p6Role.FindStringExact(Match1.Away.Players[5].Role.Name);
                }
                catch
                {
                    m1t2p6Role.SelectedIndex = m1t2p6Role.FindStringExact("");
                }
            }
        }

        /// <summary>
        /// Method for loading the games information from the series
        /// </summary>
        private void loadMaps()
        {
            decimal number;

            try
            {
                m1m1Map.SelectedIndex = m1m1Map.FindStringExact(Match1.Games[0].Map.Name);
                Decimal.TryParse(Match1.Games[0].HomeScore, out number);
                m1m1t1Score.Value = number;
                number = 0;
                Decimal.TryParse(Match1.Games[0].AwayScore, out number);
                m1m1t2Score.Value = number;
                number = 0;
                m1m1Completed.Checked = Match1.Games[0].Completed;
            }
            catch
            {
                m1m1Map.SelectedIndex = m1m1Map.FindStringExact("");
                m1m1t1Score.Value = 0;
                m1m1t2Score.Value = 0;
                m1m1Completed.Checked = false;
            }

            try
            {
                m1m2Map.SelectedIndex = m1m2Map.FindStringExact(Match1.Games[1].Map.Name);
                Decimal.TryParse(Match1.Games[1].HomeScore, out number);
                m1m2t1Score.Value = number;
                number = 0;
                Decimal.TryParse(Match1.Games[1].AwayScore, out number);
                m1m2t2Score.Value = number;
                number = 0;
                m1m2Completed.Checked = Match1.Games[0].Completed;
            }
            catch
            {
                m1m2Map.SelectedIndex = m1m2Map.FindStringExact("");
                m1m2t1Score.Value = 0;
                m1m2t2Score.Value = 0;
                m1m2Completed.Checked = false;
            }

            try
            {
                m1m3Map.SelectedIndex = m1m3Map.FindStringExact(Match1.Games[2].Map.Name);
                Decimal.TryParse(Match1.Games[2].HomeScore, out number);
                m1m3t1Score.Value = number;
                number = 0;
                Decimal.TryParse(Match1.Games[2].AwayScore, out number);
                m1m3t2Score.Value = number;
                number = 0;
                m1m3Completed.Checked = Match1.Games[0].Completed;
            }
            catch
            {
                m1m3Map.SelectedIndex = m1m3Map.FindStringExact("");
                m1m3t1Score.Value = 0;
                m1m3t2Score.Value = 0;
                m1m3Completed.Checked = false;
            }

            try
            {
                m1m4Map.SelectedIndex = m1m4Map.FindStringExact(Match1.Games[3].Map.Name);
                Decimal.TryParse(Match1.Games[3].HomeScore, out number);
                m1m4t1Score.Value = number;
                number = 0;
                Decimal.TryParse(Match1.Games[3].AwayScore, out number);
                m1m4t2Score.Value = number;
                number = 0;
                m1m4Completed.Checked = Match1.Games[0].Completed;
            }
            catch
            {
                m1m4Map.SelectedIndex = m1m4Map.FindStringExact("");
                m1m4t1Score.Value = 0;
                m1m4t2Score.Value = 0;
                m1m4Completed.Checked = false;
            }

            try
            {
                m1m5Map.SelectedIndex = m1m5Map.FindStringExact(Match1.Games[4].Map.Name);
                Decimal.TryParse(Match1.Games[4].HomeScore, out number);
                m1m5t1Score.Value = number;
                number = 0;
                Decimal.TryParse(Match1.Games[4].AwayScore, out number);
                m1m5t2Score.Value = number;
                number = 0;
                m1m5Completed.Checked = Match1.Games[0].Completed;
            }
            catch
            {
                m1m5Map.SelectedIndex = m1m5Map.FindStringExact("");
                m1m5t1Score.Value = 0;
                m1m5t2Score.Value = 0;
                m1m5Completed.Checked = false;
            }

            try
            {
                m1m6Map.SelectedIndex = m1m6Map.FindStringExact(Match1.Games[5].Map.Name);
                Decimal.TryParse(Match1.Games[5].HomeScore, out number);
                m1m6t1Score.Value = number;
                number = 0;
                Decimal.TryParse(Match1.Games[5].AwayScore, out number);
                m1m6t2Score.Value = number;
                number = 0;
                m1m6Completed.Checked = Match1.Games[0].Completed;
            }
            catch
            {
                m1m6Map.SelectedIndex = m1m6Map.FindStringExact("");
                m1m6t1Score.Value = 0;
                m1m6t2Score.Value = 0;
                m1m6Completed.Checked = false;
            }

            try
            {
                m1m7Map.SelectedIndex = m1m7Map.FindStringExact(Match1.Games[6].Map.Name);
                Decimal.TryParse(Match1.Games[6].HomeScore, out number);
                m1m7t1Score.Value = number;
                number = 0;
                Decimal.TryParse(Match1.Games[6].AwayScore, out number);
                m1m7t2Score.Value = number;
                number = 0;
                m1m7Completed.Checked = Match1.Games[0].Completed;
            }
            catch
            {
                m1m7Map.SelectedIndex = m1m7Map.FindStringExact("");
                m1m7t1Score.Value = 0;
                m1m7t2Score.Value = 0;
                m1m7Completed.Checked = false;
            }
        }
        #endregion

        #region Resetters
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

        private void resetColor(ColorDialog field, Button button)
        {
            field.Color = Color.Transparent;
            button.BackColor = Color.Transparent;
        }
        #endregion

        #region Savers
        /// <summary>
        /// Method for exporting series information to an XML
        /// </summary>
        public void exportSeries()
        {
            updateSeries();
            var serializer = new XmlSerializer(Match1.GetType());
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = path+FolderList[6];
            dialog.DefaultExt = "xml";
            dialog.Filter = "XML-File | *.xml";
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                using (var writer = XmlWriter.Create(dialog.FileName))
                {
                    Match1.Name = Path.GetFileNameWithoutExtension(dialog.FileName);
                    serializer.Serialize(writer, Match1);
                }
            }
        }

        /// <summary>
        /// Method for exporting a teams information to an XML
        /// </summary>
        /// <param name="side">Side of the team</param>
        public void ExportTeam(string side)
        {
            updateTeams(side);
            var serializer = new XmlSerializer(new Team().GetType());
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = path + FolderList[7];
            dialog.DefaultExt = "xml";
            dialog.Filter = "XML-File | *.xml";
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                using (var writer = XmlWriter.Create(dialog.FileName))
                {
                    if (side == "h")
                    {
                        serializer.Serialize(writer, Match1.Home);
                    }
                    else
                    {
                        serializer.Serialize(writer, Match1.Away);
                    }
                }
            }
        }
        #endregion

        #region Boolean Methods
        /// <summary>
        /// Method that creates folders if they are missing
        /// </summary>
        public void CheckFolders()
        {
            foreach (var folder in FolderList)
            {
                if (!Directory.Exists(path + folder))
                {
                    Directory.CreateDirectory(path + folder);
                }

            }
        }

        /// <summary>
        /// Method that creates files if they are missing
        /// </summary>
        public void CheckFiles()
        {

            foreach (var file in Match1Files)
            {
                if(!File.Exists(path + FolderList[0] + "\\" + file))
                {
                    File.Create(path + FolderList[0] + "\\" + file).Close();
                }
            }

            foreach (var file in GeneralFiles)
            {
                if (!File.Exists(path + FolderList[1] + "\\" + file))
                {
                    File.Create(path + FolderList[1] + "\\" + file).Close();
                }
            }
            foreach (var file in PlayerFiles)
            {
                if (!File.Exists(path + FolderList[2] + "\\" + file))
                {
                    File.Create(path + FolderList[2] + "\\" + file).Close();
                }
            }

            foreach (var file in SettingFiles)
            {
                if (!File.Exists(path + FolderList[3] + "\\" + file))
                {
                    File.Create(path + FolderList[3] + "\\" + file).Close();
                }
            }

        }

        /// <summary>
        /// Method that checks if too files are equal
        /// </summary>
        /// <param name="first">File 1's info</param>
        /// <param name="second">File 2's info</param>
        /// <returns>Boolean</returns>
        private static bool IsFileEqual(FileInfo first, FileInfo second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }

            if (string.Equals(first.FullName, second.FullName, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            int iterations = (int)Math.Ceiling((double)first.Length / Bytes_TO_READ);

            using (FileStream fs1 = first.OpenRead())
            using (FileStream fs2 = second.OpenRead())
            {
                byte[] one = new byte[Bytes_TO_READ];
                byte[] two = new byte[Bytes_TO_READ];

                for (int i = 0; i < iterations; i++)
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

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Watches the defined path to see if the replay file has been motified and kicks of en event if it has
        /// </summary>
        /// <param name="path">Path that contains file being watched</param>
        public void CreateFileWatcher(String path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "Replay Replay.mp4";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }

        /// <summary>
        /// Event handler that saves a copy of the most recent replay to the playlist folder
        /// </summary>
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
                    if (!IsFileEqual(new FileInfo(previousFullPath), new FileInfo(e.FullPath)))
                    {
                        Thread.Sleep(1000);
                        File.Copy(e.FullPath, copiedFullPath);
                    }  
                }
                else
                {
                    File.Copy(e.FullPath, copiedFullPath);
                }
            }
        } 
        
        /// <summary>
        /// Gets the logo for the team
        /// </summary>
        /// <param name="field">Text box being read from for file path</param>
        public void GetLogoFile(TextBox field)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; )|*.png";
            open.InitialDirectory = path + FolderList[8];
            DialogResult res = open.ShowDialog();
            if (res == DialogResult.OK)
            {
                field.Text = open.FileName;
            }
        }

        #region Generators
        /// <summary>
        /// Generates the Roles;
        /// </summary>
        public void GenerateRoles()
        {
            RoleList.Add(new Role("DPS", Properties.Resources.Icon_offense));
            RoleList.Add(new Role("Flex", Properties.Resources.Icon_flex));
            RoleList.Add(new Role("Support", Properties.Resources.Icon_support));
            RoleList.Add(new Role("Tank", Properties.Resources.Icon_tank));
        }

        /// <summary>
        /// Generates the Heroes
        /// </summary>
        public void GenerateHeroes()
        {
            HeroList.Add(new Hero("Ana", Properties.Resources.Icon_ana, Properties.Resources.Ana, Properties.Resources._3D_Ana, Properties.Resources.Ana_OWL));
            HeroList.Add(new Hero("Ashe", Properties.Resources.Icon_Ashe, Properties.Resources.Ashe, Properties.Resources._3D_Ashe, Properties.Resources.Ashe_OWL));
            HeroList.Add(new Hero("Baptiste", Properties.Resources.Icon_Baptiste, Properties.Resources.Baptiste, Properties.Resources._3D_Baptiste, Properties.Resources.Baptiste_OWL));
            HeroList.Add(new Hero("Bastion", Properties.Resources.Icon_bastion, Properties.Resources.Bastion, Properties.Resources._3D_Bastion, Properties.Resources.Bastion_OWL));
            HeroList.Add(new Hero("Brigitte", Properties.Resources.Icon_brigitte, Properties.Resources.Brigitte, Properties.Resources._3D_Brigitte, Properties.Resources.Brigitte_OWL));
            HeroList.Add(new Hero("D.Va", Properties.Resources.Icon_dva, Properties.Resources.Dva, Properties.Resources._3D_Dva, Properties.Resources.D_Va_OWL));
            HeroList.Add(new Hero("Doomfist", Properties.Resources.Icon_doomfist, Properties.Resources.Doomfist, Properties.Resources._3D_Doomfist, Properties.Resources.Doomfist_OWL));
            HeroList.Add(new Hero("Genji", Properties.Resources.Icon_genji, Properties.Resources.Genji, Properties.Resources._3D_Genji, Properties.Resources.Genji_OWL));
            HeroList.Add(new Hero("Hanzo", Properties.Resources.Icon_hanzo, Properties.Resources.Hanzo, Properties.Resources._3D_Hanzo, Properties.Resources.Hanzo_OWL));
            HeroList.Add(new Hero("Junkrat", Properties.Resources.Icon_junkrat, Properties.Resources.Junkrat, Properties.Resources._3D_Junkrat, Properties.Resources.Junkrat_OWL));
            HeroList.Add(new Hero("Lúcio", Properties.Resources.Icon_Lucio, Properties.Resources.Lucio, Properties.Resources._3D_Lucio, Properties.Resources.Lucio_OWL));
            HeroList.Add(new Hero("McCree", Properties.Resources.Icon_mccree, Properties.Resources.McCree, Properties.Resources._3D_McCree, Properties.Resources.McCree_OWL));
            HeroList.Add(new Hero("Mei", Properties.Resources.Icon_mei, Properties.Resources.Mei, Properties.Resources._3D_Mei, Properties.Resources.Mei_OWL));
            HeroList.Add(new Hero("Mercy", Properties.Resources.Icon_mercy, Properties.Resources.Mercy, Properties.Resources._3D_Mercy, Properties.Resources.Mercy_OWL));
            HeroList.Add(new Hero("Moira", Properties.Resources.Icon_moira, Properties.Resources.Moira, Properties.Resources._3D_Moira, Properties.Resources.Moira_OWL));
            HeroList.Add(new Hero("Orisa", Properties.Resources.Icon_orisa, Properties.Resources.Orisa, Properties.Resources._3D_Orisa, Properties.Resources.Orisa_OWL));
            HeroList.Add(new Hero("Pharah", Properties.Resources.Icon_pharah, Properties.Resources.Pharah, Properties.Resources._3D_Pharah, Properties.Resources.Pharah_OWL));
            HeroList.Add(new Hero("Reaper", Properties.Resources.Icon_reaper, Properties.Resources.Reaper, Properties.Resources._3D_Reaper, Properties.Resources.Reaper_OWL));
            HeroList.Add(new Hero("Reinhardt", Properties.Resources.Icon_reinhardt, Properties.Resources.Reinhardt, Properties.Resources._3D_Reinhardt, Properties.Resources.Reinhardt_OWL));
            HeroList.Add(new Hero("Roadhog", Properties.Resources.Icon_roadhog, Properties.Resources.Roadhog, Properties.Resources._3D_Roadhog, Properties.Resources.Roadhog_OWL));
            HeroList.Add(new Hero("Soldier: 76", Properties.Resources.Icon_soldier76, Properties.Resources.Soldier76, Properties.Resources._3D_Soldier76, Properties.Resources.Soldier__76_OWL));
            HeroList.Add(new Hero("Sombra", Properties.Resources.Icon_sombra, Properties.Resources.Sombra, Properties.Resources._3D_Sombra, Properties.Resources.Sombra_OWL));
            HeroList.Add(new Hero("Symmetra", Properties.Resources.Icon_symmetra, Properties.Resources.Symmetra, Properties.Resources._3D_Symmetra, Properties.Resources.Symmetra_OWL));
            HeroList.Add(new Hero("Torbjörn", Properties.Resources.Icon_torbjorn, Properties.Resources.Torbjorn, Properties.Resources._3D_Torbjorn, Properties.Resources.Torbjorn_OWL));
            HeroList.Add(new Hero("Tracer", Properties.Resources.Icon_tracer, Properties.Resources.Tracer, Properties.Resources._3D_Tracer, Properties.Resources.Tracer_OWL));
            HeroList.Add(new Hero("Widowmaker", Properties.Resources.Icon_widowmaker, Properties.Resources.Widowmaker, Properties.Resources._3D_Widowmaker, Properties.Resources.Widowmaker_OWL));
            HeroList.Add(new Hero("Winston", Properties.Resources.Icon_winston, Properties.Resources.Winston, Properties.Resources._3D_Winston, Properties.Resources.Winston_OWL));
            HeroList.Add(new Hero("Wrecking Ball", Properties.Resources.Icon_Wrecking_Ball, Properties.Resources.WreckingBall, Properties.Resources._3D_WreckingBall, Properties.Resources.Wrecking_Ball_OWL));
            HeroList.Add(new Hero("Zarya", Properties.Resources.Icon_zarya, Properties.Resources.Zarya, Properties.Resources._3D_Zarya, Properties.Resources.Zarya_OWL));
            HeroList.Add(new Hero("Zenyatta", Properties.Resources.Icon_zenyatta, Properties.Resources.Zenyatta, Properties.Resources._3D_Zenyatta, Properties.Resources.Zenyatta_OWL));
        }

        /// <summary>
        /// Generates the Gametypes
        /// </summary>
        public void GenerateGametypes()
        {
            GametypeList.Add(new Gametype("Assault", Properties.Resources.Icon_assault));
            GametypeList.Add(new Gametype("Control", Properties.Resources.Icon_control));
            GametypeList.Add(new Gametype("Escort", Properties.Resources.Icon_escort));
            GametypeList.Add(new Gametype("Hybrid", Properties.Resources.Icon_hybrid));
        }

        /// <summary>
        /// Generates the Maps
        /// </summary>
        public void GenerateMaps()
        {
            MapList.Add(new Map("Assault", GametypeList[1], Properties.Resources.Icon_assault_pool, Properties.Resources.Color_Assault, ""));
            MapList.Add(new Map("Control", GametypeList[2], Properties.Resources.Icon_control_pool, Properties.Resources.Color_Control, ""));
            MapList.Add(new Map("Escort", GametypeList[3], Properties.Resources.Icon_escort_pool, Properties.Resources.Color_Escort, ""));
            MapList.Add(new Map("Hybrid", GametypeList[4], Properties.Resources.Icon_hybrid_pool, Properties.Resources.Color_Hybrid, ""));
            MapList.Add(new Map("Busan", GametypeList[2], Properties.Resources.Icon_busan, Properties.Resources.Color_Busan, ""));
            MapList.Add(new Map("Blizzard World", GametypeList[4], Properties.Resources.Icon_blizzworld, Properties.Resources.Color_Blizzworld, ""));
            MapList.Add(new Map("Dorado", GametypeList[3], Properties.Resources.Icon_dorado, Properties.Resources.Color_Dorado, ""));
            MapList.Add(new Map("Eichenwalde", GametypeList[4], Properties.Resources.Icon_hybrid_pool, Properties.Resources.Color_Eichenwalde, ""));
            MapList.Add(new Map("Hanamura", GametypeList[1], Properties.Resources.Icon_hanamura, Properties.Resources.Color_Hanamura, ""));
            MapList.Add(new Map("Hollywood", GametypeList[4], Properties.Resources.Icon_hollywood, Properties.Resources.Color_Hollywood, ""));
            MapList.Add(new Map("Horizon Lunar Colony", GametypeList[1], Properties.Resources.Icon_horizon, Properties.Resources.Color_Horizon, ""));
            MapList.Add(new Map("Ilios", GametypeList[2], Properties.Resources.Icon_ilios, Properties.Resources.Color_Ilios, ""));
            MapList.Add(new Map("Junkertown", GametypeList[3], Properties.Resources.Icon_junkertown, Properties.Resources.Color_Junkertown, ""));
            MapList.Add(new Map("King\'s Row", GametypeList[4], Properties.Resources.Icon_kings, Properties.Resources.Color_King_s_Row, ""));
            MapList.Add(new Map("Lijiang Tower", GametypeList[2], Properties.Resources.Icon_lijiang, Properties.Resources.Color_Lijiang, ""));
            MapList.Add(new Map("Paris", GametypeList[1], Properties.Resources.Icon_paris, Properties.Resources.Color_Paris, ""));
            MapList.Add(new Map("Nepal", GametypeList[2], Properties.Resources.Icon_nepal, Properties.Resources.Color_Nepal, ""));
            MapList.Add(new Map("Numbani", GametypeList[4], Properties.Resources.Icon_numbani, Properties.Resources.Color_Numbani, ""));
            MapList.Add(new Map("Oasis", GametypeList[2], Properties.Resources.Icon_oasis, Properties.Resources.Color_Oasis, ""));
            MapList.Add(new Map("Rialto", GametypeList[3], Properties.Resources.Icon_rialto, Properties.Resources.Color_Rialto, ""));
            MapList.Add(new Map("Route 66", GametypeList[3], Properties.Resources.Icon_route, Properties.Resources.Color_Route66, ""));
            MapList.Add(new Map("Temple of Anubis", GametypeList[1], Properties.Resources.Icon_temple, Properties.Resources.Color_Anubis, ""));
            MapList.Add(new Map("Volskaya Industries", GametypeList[1], Properties.Resources.Icon_volskaya, Properties.Resources.Color_Volskaya, ""));
            MapList.Add(new Map("Watchpoint: Gibraltar", GametypeList[3], Properties.Resources.Icon_watchpoint, Properties.Resources.Color_Watchpoint, ""));

        }

        /// <summary>
        /// Generates a list of all files that exist
        /// </summary>
        private void GenerateFileList()
        {
            Match1Files = new List<string>
            {
                "DivisionNumber.txt",
                "m1Map.png",
                "m1Map.txt",
                "m1MapGametype.png",
                "m1MapGametype.txt",
                "m1MapWin.png",
                "m1MapWin.txt",
                "m1t1Score.txt",
                "m1t2Score.txt",
                "m2Map.png",
                "m2Map.txt",
                "m2MapGametype.png",
                "m2MapGametype.txt",
                "m2MapWin.png",
                "m2MapWin.txt",
                "m2t1Score.txt",
                "m2t2Score.txt",
                "m3Map.png",
                "m3Map.txt",
                "m3MapGametype.png",
                "m3MapGametype.txt",
                "m3MapWin.png",
                "m3MapWin.txt",
                "m3t1Score.txt",
                "m3t2Score.txt",
                "m4Map.png",
                "m4Map.txt",
                "m4MapGametype.png",
                "m4MapGametype.txt",
                "m4MapWin.png",
                "m4MapWin.txt",
                "m4t1Score.txt",
                "m4t2Score.txt",
                "m5Map.png",
                "m5Map.txt",
                "m5MapGametype.png",
                "m5MapGametype.txt",
                "m5MapWin.png",
                "m5MapWin.txt",
                "m5t1Score.txt",
                "m5t2Score.txt",
                "m6Map.png",
                "m6Map.txt",
                "m6MapGametype.png",
                "m6MapGametype.txt",
                "m6MapWin.png",
                "m6MapWin.txt",
                "m6t1Score.txt",
                "m6t2Score.txt",
                "m7Map.png",
                "m7Map.txt",
                "m7MapGametype.png",
                "m7MapGametype.txt",
                "m7MapWin.png",
                "m7MapWin.txt",
                "m7t1Score.txt",
                "m7t2Score.txt",
                "MessageBox.txt",
                "t1Logo.png",
                "t1Logo.txt",
                "t1Name.txt",
                "t1Color.txt",
                "t1p1Hero.png",
                "t1p1Hero.txt",
                "t1p1Name.txt",
                "t1p1Role.png",
                "t1p1Role.txt",
                "t1p1Info.txt",
                "t1p1Image.png",
                "t1p2Hero.png",
                "t1p2Hero.txt",
                "t1p2Name.txt",
                "t1p2Role.png",
                "t1p2Role.txt",
                "t1p2Info.txt",
                "t1p2Image.png",
                "t1p3Hero.png",
                "t1p3Hero.txt",
                "t1p3Name.txt",
                "t1p3Role.png",
                "t1p3Role.txt",
                "t1p3Info.txt",
                "t1p3Image.png",
                "t1p4Hero.png",
                "t1p4Hero.txt",
                "t1p4Name.txt",
                "t1p4Role.png",
                "t1p4Role.txt",
                "t1p4Info.txt",
                "t1p4Image.png",
                "t1p5Hero.png",
                "t1p5Hero.txt",
                "t1p5Name.txt",
                "t1p5Role.png",
                "t1p5Role.txt",
                "t1p5Info.txt",
                "t1p5Image.png",
                "t1p6Hero.png",
                "t1p6Hero.txt",
                "t1p6Name.txt",
                "t1p6Role.png",
                "t1p6Role.txt",
                "t1p6Info.txt",
                "t1p6Image.png",
                "t1Score.txt",
                "t1Side.png",
                "t1SR.txt",
                "t2Logo.txt",
                "t2Logo.png",
                "t2Name.txt",
                "t2Color.txt",
                "t2p1Hero.png",
                "t2p1Hero.txt",
                "t2p1Name.txt",
                "t2p1Role.png",
                "t2p1Role.txt",
                "t2p1Info.txt",
                "t2p1Image.png",
                "t2p2Hero.png",
                "t2p2Hero.txt",
                "t2p2Name.txt",
                "t2p2Role.png",
                "t2p2Role.txt",
                "t2p2Info.txt",
                "t2p2Image.png",
                "t2p3Hero.png",
                "t2p3Hero.txt",
                "t2p3Name.txt",
                "t2p3Role.png",
                "t2p3Role.txt",
                "t2p3Info.txt",
                "t2p3Image.png",
                "t2p4Hero.png",
                "t2p4Hero.txt",
                "t2p4Name.txt",
                "t2p4Role.png",
                "t2p4Role.txt",
                "t2p4Info.txt",
                "t2p4Image.png",
                "t2p5Hero.png",
                "t2p5Hero.txt",
                "t2p5Name.txt",
                "t2p5Role.png",
                "t2p5Role.txt",
                "t2p5Info.txt",
                "t2p5Image.pngt",
                "t2p6Hero.png",
                "t2p6Hero.txt",
                "t2p6Name.txt",
                "t2p6Role.png",
                "t2p6Role.txt",
                "t2p6Info.txt",
                "t2p6Image.png",
                "t2Score.txt",
                "t2Side.png",
                "t2SR.txt"
            };

            GeneralFiles = new List<string>
            {
                "analyst1.txt",
                "analyst2.txt",
                "caster1.txt",
                "caster2.txt",
                "host.txt",
                "message.txt",
                "utility1.txt",
                "utility2.txt",
                "utility3.txt",
                "utility4.txt",
                "utility5.txt",
                "utility6.txt",
                "utility7.txt",
                "utility8.txt"
            };

            PlayerFiles = new List<string>
            {
                "hero1.png",
                "hero1.txt",
                "hero2.png",
                "hero2.txt",
                "hero3.png",
                "hero3.txt",
                "logo.png",
                "logo.txt",
                "player.txt",
                "role.png",
                "role.txt",
                "sr.txt",
                "team.txt",
            };

            SettingFiles = new List<string>
            {

            };
        }

        /// <summary>
        /// 
        /// </summary>
        private void GenerateFolderList()
        {
            FolderList = new List<string>
            {
                "\\Match1",
                "\\General",
                "\\Player",
                "\\Settings",
                "\\Replay",
                "\\Replay\\Playlist",
                "\\Series",
                "\\Team",
                "\\Temp"
            };
        }

        #endregion
    }
}
