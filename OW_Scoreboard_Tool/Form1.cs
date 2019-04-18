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
        string xmlVersion = "0.2";
        const int Bytes_TO_READ = sizeof(Int64);
        Series Match1 = new Series();

        List<Replay> Replays = new List<Replay>();
        BindingList<Team> BracketTeams = new BindingList<Team>();
        FileSystemWatcher replayWatcher = new FileSystemWatcher();

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
        List<string> ReplayFiles;
        List<string> BracketFiles;

        int[] customColors = new int[]
            {
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#8cba11")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#ff9c00")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#202224")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#C80013")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#D45800")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#D47900")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#FFD700")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#FFFF00")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#CCFF00")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#00AB84")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#00FFFF")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#27AAE1")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#800080")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#523FFF")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#FF00FF")),
                ColorTranslator.ToOle(ColorTranslator.FromHtml("#FF6EC7"))
            };

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
            colorThemeDialog1.CustomColors = customColors;
            colorThemeDialog2.CustomColors = customColors;
            colorThemeDialog3.CustomColors = customColors;
            m1t1Color.CustomColors = customColors;
            m1t2Color.CustomColors = customColors;


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

            loadText(m1t1p1Info, "Match1", "t1p1Info");
            loadText(m1t1p2Info, "Match1", "t1p2Info");
            loadText(m1t1p3Info, "Match1", "t1p3Info");
            loadText(m1t1p4Info, "Match1", "t1p4Info");
            loadText(m1t1p5Info, "Match1", "t1p5Info");
            loadText(m1t1p6Info, "Match1", "t1p6Info");
            
            loadText(m1t2p1Info, "Match1", "t2p1Info");
            loadText(m1t2p2Info, "Match1", "t2p2Info");
            loadText(m1t2p3Info, "Match1", "t2p3Info");
            loadText(m1t2p4Info, "Match1", "t2p4Info");
            loadText(m1t2p5Info, "Match1", "t2p5Info");
            loadText(m1t2p6Info, "Match1", "t2p6Info");

            loadText(m1t1p1Image, "Match1", "t1p1Image");
            loadText(m1t1p2Image, "Match1", "t1p2Image");
            loadText(m1t1p3Image, "Match1", "t1p3Image");
            loadText(m1t1p4Image, "Match1", "t1p4Image");
            loadText(m1t1p5Image, "Match1", "t1p5Image");
            loadText(m1t1p6Image, "Match1", "t1p6Image");
            
            loadText(m1t2p1Image, "Match1", "t2p1Image");
            loadText(m1t2p2Image, "Match1", "t2p2Image");
            loadText(m1t2p3Image, "Match1", "t2p3Image");
            loadText(m1t2p4Image, "Match1", "t2p4Image");
            loadText(m1t2p5Image, "Match1", "t2p5Image");
            loadText(m1t2p6Image, "Match1", "t2p6Image");

            loadCombo(m1m1Map, "Match1", "m1Map");
            loadCombo(m1m2Map, "Match1", "m2Map");
            loadCombo(m1m3Map, "Match1", "m3Map");
            loadCombo(m1m4Map, "Match1", "m4Map");
            loadCombo(m1m5Map, "Match1", "m5Map");
            loadCombo(m1m6Map, "Match1", "m6Map");
            loadCombo(m1m7Map, "Match1", "m7Map");

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
            loadText(utility9, "General", "utility9");
            loadText(utility10, "General", "utility10");
            loadText(utility11, "General", "utility11");
            loadText(utility12, "General", "utility12");
            loadText(utility13, "General", "utility13");
            loadText(utility14, "General", "utility14");
            loadText(utility15, "General", "utility15");
            loadText(utility16, "General", "utility16");
            loadText(utility17, "General", "utility17");
            loadText(utility18, "General", "utility18");
            loadText(utility19, "General", "utility19");
            loadText(utility20, "General", "utility20");
            loadText(utility21, "General", "utility21");
            loadText(utility22, "General", "utility22");

            loadButton(imageButton1, "General", GeneralFiles[59].Replace(".png", ""));
            loadButton(imageButton2, "General", GeneralFiles[60].Replace(".png", ""));
            loadButton(imageButton3, "General", GeneralFiles[61].Replace(".png", ""));
            loadButton(imageButton4, "General", GeneralFiles[62].Replace(".png", ""));
            loadButton(imageButton5, "General", GeneralFiles[63].Replace(".png", ""));
            loadButton(imageButton6, "General", GeneralFiles[64].Replace(".png", ""));
            loadButton(imageButton7, "General", GeneralFiles[65].Replace(".png", ""));
            loadButton(imageButton8, "General", GeneralFiles[66].Replace(".png", ""));
            loadButton(imageButton9, "General", GeneralFiles[67].Replace(".png", ""));
            loadButton(imageButton10, "General", GeneralFiles[68].Replace(".png", ""));
            loadButton(imageButton11, "General", GeneralFiles[69].Replace(".png", ""));
            loadButton(imageButton12, "General", GeneralFiles[70].Replace(".png", ""));
            loadButton(imageButton13, "General", GeneralFiles[71].Replace(".png", ""));
            loadButton(imageButton14, "General", GeneralFiles[72].Replace(".png", ""));
            loadButton(imageButton15, "General", GeneralFiles[73].Replace(".png", ""));
            loadButton(imageButton16, "General", GeneralFiles[74].Replace(".png", ""));
            loadButton(imageButton17, "General", GeneralFiles[75].Replace(".png", ""));
            loadButton(imageButton18, "General", GeneralFiles[76].Replace(".png", ""));
            loadButton(imageButton19, "General", GeneralFiles[77].Replace(".png", ""));
            loadButton(imageButton20, "General", GeneralFiles[78].Replace(".png", ""));
            loadButton(imageButton21, "General", GeneralFiles[79].Replace(".png", ""));
            loadButton(imageButton22, "General", GeneralFiles[80].Replace(".png", ""));
            loadButton(imageButton23, "General", GeneralFiles[81].Replace(".png", ""));
            loadButton(imageButton24, "General", GeneralFiles[82].Replace(".png", ""));
            loadButton(imageButton25, "General", GeneralFiles[83].Replace(".png", ""));
            loadButton(imageButton26, "General", GeneralFiles[84].Replace(".png", ""));
            loadButton(imageButton27, "General", GeneralFiles[85].Replace(".png", ""));
            loadButton(imageButton28, "General", GeneralFiles[86].Replace(".png", ""));

            loadColor(colorThemeDialog1, colorThemeButton1, "General", "colorTheme1");
            loadColor(colorThemeDialog2, colorThemeButton2, "General", "colorTheme2");
            loadColor(colorThemeDialog3, colorThemeButton3, "General", "colorTheme3");

            loadText(playerBox, "Player", "player");
            loadText(playerSRBox, "Player", "sr");
            loadText(playerImagePath, "Player", "image");
            loadText(playerTeamBox, "Player", "team");
            loadText(playerTeamInfoBox, "Player", "info");
            loadText(playerTeamLogoBox, "Player", "logo");

            loadCombo(playerHeroBox1, "Player", "hero1");
            loadCombo(playerHeroBox2, "Player", "hero2");
            loadCombo(playerHeroBox3, "Player", "hero3");
            loadCombo(playerRoleBox, "Player", "role");

            loadBracket();

            linkBracketToTeams();

            updateSeries();

            updateReplayPage();
            updateList();
        }

        private void Changed(object sender, FileSystemEventArgs e)
        {
            BeginInvoke(new Action(() => updateList()));
        }

        private void updateList()
        {
            replayListView.Items.Clear();
            replayImageList.Images.Clear();
            Replays.Clear();
            var di = new DirectoryInfo(path+FolderList[5]);
            int imageIndex = 0;
            foreach (FileInfo fi in di.GetFiles())
            {
                ShellFile shellFile = ShellFile.FromFilePath(fi.FullName);
                Bitmap shellThumb = shellFile.Thumbnail.Bitmap;
                replayImageList.Images.Add(shellThumb);
                ListViewItem item = new ListViewItem();
                item.Text = fi.Name;
                item.ImageIndex = imageIndex;
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add(fi.CreationTime.ToShortTimeString());
                replayListView.Items.Add(item);
                Replays.Add(new Replay());
                Replays[imageIndex].Players = new List<Player>();
                Replays[imageIndex].ReplayPath = fi.FullName;
                Replays[imageIndex].Name = fi.Name;
                Replays[imageIndex].Created = fi.CreationTime;
                Replays[imageIndex].Thumbnail = shellThumb;
                imageIndex++;
            }
        }

        private void updateReplayPage()
        {
            replayTeamComboBox.Items.Clear();
            replayMapComboBox.Items.Clear();

            replayTeamComboBox.Items.Add("");
            replayTeamComboBox.Items.Add(Match1.Home.Name);
            replayTeamComboBox.Items.Add(Match1.Away.Name);

            replayMapComboBox.Items.Add("");
            replayMapComboBox.Items.Add(Match1.Games[0].Map.Name);
            replayMapComboBox.Items.Add(Match1.Games[1].Map.Name);
            replayMapComboBox.Items.Add(Match1.Games[2].Map.Name);
            replayMapComboBox.Items.Add(Match1.Games[3].Map.Name);
            replayMapComboBox.Items.Add(Match1.Games[4].Map.Name);
            replayMapComboBox.Items.Add(Match1.Games[5].Map.Name);
            replayMapComboBox.Items.Add(Match1.Games[6].Map.Name);
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

            temp = m1t1p1Info.Text;
            m1t1p1Info.Text = m1t2p1Info.Text;
            m1t2p1Info.Text = temp;
            temp = "";

            temp = m1t1p2Info.Text;
            m1t1p2Info.Text = m1t2p2Info.Text;
            m1t2p2Info.Text = temp;
            temp = "";

            temp = m1t1p3Info.Text;
            m1t1p3Info.Text = m1t2p3Info.Text;
            m1t2p3Info.Text = temp;
            temp = "";

            temp = m1t1p4Info.Text;
            m1t1p4Info.Text = m1t2p4Info.Text;
            m1t2p4Info.Text = temp;
            temp = "";

            temp = m1t1p5Info.Text;
            m1t1p5Info.Text = m1t2p5Info.Text;
            m1t2p5Info.Text = temp;
            temp = "";

            temp = m1t1p6Info.Text;
            m1t1p6Info.Text = m1t2p6Info.Text;
            m1t2p6Info.Text = temp;
            temp = "";

            temp = m1t1p1Image.Text;
            m1t1p1Image.Text = m1t2p1Image.Text;
            m1t2p1Image.Text = temp;
            temp = "";

            temp = m1t1p2Image.Text;
            m1t1p2Image.Text = m1t2p2Image.Text;
            m1t2p2Image.Text = temp;
            temp = "";

            temp = m1t1p3Image.Text;
            m1t1p3Image.Text = m1t2p3Image.Text;
            m1t2p3Image.Text = temp;
            temp = "";

            temp = m1t1p4Image.Text;
            m1t1p4Image.Text = m1t2p4Image.Text;
            m1t2p4Image.Text = temp;
            temp = "";

            temp = m1t1p5Image.Text;
            m1t1p5Image.Text = m1t2p5Image.Text;
            m1t2p5Image.Text = temp;
            temp = "";

            temp = m1t1p6Image.Text;
            m1t1p6Image.Text = m1t2p6Image.Text;
            m1t2p6Image.Text = temp;
            temp = "";

            Color tempColor = new Color();
            tempColor = m1t1Color.Color;
            m1t1Color.Color = m1t2Color.Color;
            m1t1ColorButton.BackColor = m1t1Color.Color;
            m1t2Color.Color = tempColor;
            m1t2ColorButton.BackColor = m1t2Color.Color;

            updateReplayPage();

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

                resetText(m1t1p1Info);
                resetText(m1t1p2Info);
                resetText(m1t1p3Info);
                resetText(m1t1p4Info);
                resetText(m1t1p5Info);
                resetText(m1t1p6Info);

                resetText(m1t2p1Info);
                resetText(m1t2p2Info);
                resetText(m1t2p3Info);
                resetText(m1t2p4Info);
                resetText(m1t2p5Info);
                resetText(m1t2p6Info);

                resetText(m1t1p1Image);
                resetText(m1t1p2Image);
                resetText(m1t1p3Image);
                resetText(m1t1p4Image);
                resetText(m1t1p5Image);
                resetText(m1t1p6Image);
                
                resetText(m1t2p1Image);
                resetText(m1t2p2Image);
                resetText(m1t2p3Image);
                resetText(m1t2p4Image);
                resetText(m1t2p5Image);
                resetText(m1t2p6Image);

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
                resetText(utility9);
                resetText(utility10);
                resetText(utility11);
                resetText(utility12);
                resetText(utility13);
                resetText(utility14);
                resetText(utility15);
                resetText(utility16);
                resetText(utility17);
                resetText(utility18);
                resetText(utility19);
                resetText(utility20);
                resetText(utility21);
                resetText(utility22);
                resetColor(colorThemeDialog1, colorThemeButton1);
                resetColor(colorThemeDialog2, colorThemeButton2);
                resetColor(colorThemeDialog3, colorThemeButton3);
                resetButton(imageButton1);
                resetButton(imageButton2);
                resetButton(imageButton3);
                resetButton(imageButton4);
                resetButton(imageButton5);
                resetButton(imageButton6);
                resetButton(imageButton7);
                resetButton(imageButton8);
                resetButton(imageButton9);
                resetButton(imageButton10);
                resetButton(imageButton11);
                resetButton(imageButton12);
                resetButton(imageButton13);
                resetButton(imageButton14);
                resetButton(imageButton15);
                resetButton(imageButton16);
                resetButton(imageButton17);
                resetButton(imageButton18);
                resetButton(imageButton19);
                resetButton(imageButton20);
                resetButton(imageButton21);
                resetButton(imageButton22);
                resetButton(imageButton23);
                resetButton(imageButton24);
                resetButton(imageButton25);
                resetButton(imageButton26);
                resetButton(imageButton27);
                resetButton(imageButton28);
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

            updateText(m1t1p1Info, "Match1", "t1p1Info");
            updateText(m1t1p2Info, "Match1", "t1p2Info");
            updateText(m1t1p3Info, "Match1", "t1p3Info");
            updateText(m1t1p4Info, "Match1", "t1p4Info");
            updateText(m1t1p5Info, "Match1", "t1p5Info");
            updateText(m1t1p6Info, "Match1", "t1p6Info");
            
            updateText(m1t2p1Info, "Match1", "t2p1Info");
            updateText(m1t2p2Info, "Match1", "t2p2Info");
            updateText(m1t2p3Info, "Match1", "t2p3Info");
            updateText(m1t2p4Info, "Match1", "t2p4Info");
            updateText(m1t2p5Info, "Match1", "t2p5Info");
            updateText(m1t2p6Info, "Match1", "t2p6Info");

            updateLogos(m1t1p1Image, "Match1", "t1p1Image");
            updateLogos(m1t1p2Image, "Match1", "t1p2Image");
            updateLogos(m1t1p3Image, "Match1", "t1p3Image");
            updateLogos(m1t1p4Image, "Match1", "t1p4Image");
            updateLogos(m1t1p5Image, "Match1", "t1p5Image");
            updateLogos(m1t1p6Image, "Match1", "t1p6Image");

            updateLogos(m1t2p1Image, "Match1", "t2p1Image");
            updateLogos(m1t2p2Image, "Match1", "t2p2Image");
            updateLogos(m1t2p3Image, "Match1", "t2p3Image");
            updateLogos(m1t2p4Image, "Match1", "t2p4Image");
            updateLogos(m1t2p5Image, "Match1", "t2p5Image");
            updateLogos(m1t2p6Image, "Match1", "t2p6Image");

            updateText(m1t1p1Image, "Match1", "t1p1Image");
            updateText(m1t1p2Image, "Match1", "t1p2Image");
            updateText(m1t1p3Image, "Match1", "t1p3Image");
            updateText(m1t1p4Image, "Match1", "t1p4Image");
            updateText(m1t1p5Image, "Match1", "t1p5Image");
            updateText(m1t1p6Image, "Match1", "t1p6Image");
            
            updateText(m1t2p1Image, "Match1", "t2p1Image");
            updateText(m1t2p2Image, "Match1", "t2p2Image");
            updateText(m1t2p3Image, "Match1", "t2p3Image");
            updateText(m1t2p4Image, "Match1", "t2p4Image");
            updateText(m1t2p5Image, "Match1", "t2p5Image");
            updateText(m1t2p6Image, "Match1", "t2p6Image");

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
            updateReplayPage();
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
            updateText(utility9, "General", "utility9");
            updateText(utility10, "General", "utility10");
            updateText(utility11, "General", "utility11");
            updateText(utility12, "General", "utility12");
            updateText(utility13, "General", "utility13");
            updateText(utility14, "General", "utility14");
            updateText(utility15, "General", "utility15");
            updateText(utility16, "General", "utility16");
            updateText(utility17, "General", "utility17");
            updateText(utility18, "General", "utility18");
            updateText(utility19, "General", "utility19");
            updateText(utility20, "General", "utility20");
            updateText(utility21, "General", "utility21");
            updateText(utility22, "General", "utility22");

            updateButton(imageButton1, "General", GeneralFiles[59].Replace(".png", ""));
            updateButton(imageButton2, "General", GeneralFiles[60].Replace(".png", ""));
            updateButton(imageButton3, "General", GeneralFiles[61].Replace(".png", ""));
            updateButton(imageButton4, "General", GeneralFiles[62].Replace(".png", ""));
            updateButton(imageButton5, "General", GeneralFiles[63].Replace(".png", ""));
            updateButton(imageButton6, "General", GeneralFiles[64].Replace(".png", ""));
            updateButton(imageButton7, "General", GeneralFiles[65].Replace(".png", ""));
            updateButton(imageButton8, "General", GeneralFiles[66].Replace(".png", ""));
            updateButton(imageButton9, "General", GeneralFiles[67].Replace(".png", ""));
            updateButton(imageButton10, "General", GeneralFiles[68].Replace(".png", ""));
            updateButton(imageButton11, "General", GeneralFiles[69].Replace(".png", ""));
            updateButton(imageButton12, "General", GeneralFiles[70].Replace(".png", ""));
            updateButton(imageButton13, "General", GeneralFiles[71].Replace(".png", ""));
            updateButton(imageButton14, "General", GeneralFiles[72].Replace(".png", ""));
            updateButton(imageButton15, "General", GeneralFiles[73].Replace(".png", ""));
            updateButton(imageButton16, "General", GeneralFiles[74].Replace(".png", ""));
            updateButton(imageButton17, "General", GeneralFiles[75].Replace(".png", ""));
            updateButton(imageButton18, "General", GeneralFiles[76].Replace(".png", ""));
            updateButton(imageButton19, "General", GeneralFiles[77].Replace(".png", ""));
            updateButton(imageButton20, "General", GeneralFiles[78].Replace(".png", ""));
            updateButton(imageButton21, "General", GeneralFiles[79].Replace(".png", ""));
            updateButton(imageButton22, "General", GeneralFiles[80].Replace(".png", ""));
            updateButton(imageButton23, "General", GeneralFiles[81].Replace(".png", ""));
            updateButton(imageButton24, "General", GeneralFiles[82].Replace(".png", ""));
            updateButton(imageButton25, "General", GeneralFiles[83].Replace(".png", ""));
            updateButton(imageButton26, "General", GeneralFiles[84].Replace(".png", ""));
            updateButton(imageButton27, "General", GeneralFiles[85].Replace(".png", ""));
            updateButton(imageButton28, "General", GeneralFiles[86].Replace(".png", ""));


            updateColor(colorThemeDialog1, "General", "colorTheme1");
            updateColor(colorThemeDialog2, "General", "colorTheme2");
            updateColor(colorThemeDialog3, "General", "colorTheme3");
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
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove all replays?", "Reset Replay Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(path + FolderList[5]);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                updateList();
            }
            else if(dialogResult == DialogResult.No)
            {
                //do nothing
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
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove all player data?", "Reset Player Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                resetText(playerBox);
                resetText(playerSRBox);
                resetText(playerImagePath);
                resetText(playerTeamBox);
                resetText(playerTeamInfoBox);
                resetText(playerTeamLogoBox);

                resetHero(playerHeroBox1);
                resetHero(playerHeroBox2);
                resetHero(playerHeroBox3);
                resetRole(playerRoleBox);
            }
            else if(dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        /// <summary>
        /// Button to update the player of the match information
        /// </summary>
        private void playerUpdate_Click(object sender, EventArgs e)
        {
            updateText(playerBox, "Player", "player");
            updateText(playerSRBox, "Player", "sr");
            updateText(playerTeamBox, "Player", "team");
            updateText(playerTeamInfoBox, "Player", "info");

            updateHero(playerHeroBox1, playerHeroPortrait1, playerHeroIcon1, playerHero3D1, "Player", "hero1");
            updateHero(playerHeroBox2, playerHeroPortrait2, playerHeroIcon2, playerHero3D2, "Player", "hero2");
            updateHero(playerHeroBox3, playerHeroPortrait3, playerHeroIcon3, playerHero3D3, "Player", "hero3");

            updateRole(playerRoleBox, "Player", "role");

            updateLogos(playerImagePath, "Player", "image");
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
        /// Button to get player image for the player of the match
        /// </summary>
        private void playerImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(playerImagePath);
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
        private void updateLogos(TextBox field, String folder, String file)
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

        private void updateButton(Button field, String folder, String file)
        {
            if (field.AccessibleDescription != null)
            {
                using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + "Path" + ".txt"))
                {

                    sw.WriteLine(field.AccessibleDescription.Trim());


                }

                if (field.AccessibleDescription != "")
                {
                    try
                    {
                        Bitmap logo = new Bitmap(field.AccessibleDescription);
                        logo.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("The path \"" + path + "\\" + folder + "\\" + file + ".png" + "\" does not exist!");
                        field.AccessibleDescription = "";
                        Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + ".png");
                    }
                }
                else
                {
                    Properties.Resources.Icon_none.Save(path + "\\" + folder + "\\" + file + ".png");
                }
            }
        }

        /// <summary>
        /// Method for updating the Series of the form
        /// </summary>
        private void updateSeries()
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
        private List<Player> updatePlayers(string side)
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
        private Team updateTeams(string side)
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
        private List<Game> updateMapPool()
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
                field.Text = loadingText.Trim();
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

        private void loadButton (Button field, String folder, String file)
        {
            if (File.Exists(path + "\\" + folder + "\\" + file + "Path" + ".txt"))
            {
                string loadingText = File.ReadAllText(path + "\\" + folder + "\\" + file + "Path" + ".txt");
                field.AccessibleDescription = loadingText.Trim();
            }
            else
            {
                File.Create(path + "\\" + folder + "\\" + file + "Path" + ".txt");
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

        private void resetButton(Button field)
        {
            field.AccessibleDescription = "";
        }

        private void resetCombo(ComboBox field)
        {
            field.SelectedIndex = 0;
        }
        #endregion

        #region Savers
        /// <summary>
        /// Method for exporting series information to an XML
        /// </summary>
        private void exportSeries()
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
        private void ExportTeam(string side)
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
        private void CheckFolders()
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
        private void CheckFiles()
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

            foreach (var file in ReplayFiles)
            {
                if (!File.Exists(path + FolderList[4] + "\\" + file))
                {
                    File.Create(path + FolderList[4] + "\\" + file).Close();
                }
            }

            foreach (var file in BracketFiles)
            {
                if (!File.Exists(path + FolderList[9] + "\\" + file))
                {
                    File.Create(path + FolderList[9] + "\\" + file).Close();
                }
            }

        }

        /// <summary>
        /// Method that checks if too files are equal
        /// </summary>
        /// <param name="first">File 1's info</param>
        /// <param name="second">File 2's info</param>
        /// <returns>Boolean</returns>
        private bool IsFileEqual(FileInfo first, FileInfo second)
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
        private void CreateFileWatcher(String path)
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
        private void OnChanged(object source, FileSystemEventArgs e)
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
                        BeginInvoke(new Action(() => addReplay(copiedFullPath)));
                    }
                }
                else
                {
                    Thread.Sleep(1000);
                    File.Copy(e.FullPath, copiedFullPath);
                    BeginInvoke(new Action(() => addReplay(copiedFullPath)));
                }
            }
        }

        private void addReplay(string path)
        {
            FileInfo fi = new FileInfo(path);
            ShellFile shellFile = ShellFile.FromFilePath(fi.FullName);
            Bitmap shellThumb = shellFile.Thumbnail.ExtraLargeBitmap;
            Replay replay = new Replay();
            replay.Players = new List<Player>();
            replay.ReplayPath = fi.FullName;
            replay.Name = fi.Name;
            replay.Thumbnail = shellThumb;
            Replays.Add(replay);
            replayImageList.Images.Add(shellThumb);
            ListViewItem item = new ListViewItem();
            item.Text = fi.Name;
            item.ImageIndex = replayImageList.Images.Count - 1;
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add(fi.CreationTime.ToShortTimeString());
            replayListView.Items.Add(item);
            replayListView.Refresh();
        }

        /// <summary>
        /// Gets the logo for the team
        /// </summary>
        /// <param name="field">Text box being read from for file path</param>
        private void GetLogoFile(TextBox field)
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
        private void GetLogoForButton(Button field)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; )|*.png";
            open.InitialDirectory = path + FolderList[8];
            DialogResult res = open.ShowDialog();
            if (res == DialogResult.OK)
            {
                field.AccessibleDescription = open.FileName;
            }
        }

        private void GetImageForButton(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; )|*.png";
            open.InitialDirectory = path + FolderList[1];
            DialogResult res = open.ShowDialog();
            if (res == DialogResult.OK)
            {
                ((Button)sender).AccessibleDescription = open.FileName;
            }
        }

        #region Generators
        /// <summary>
        /// Generates the Roles;
        /// </summary>
        private void GenerateRoles()
        {
            RoleList.Add(new Role("DPS", Properties.Resources.Icon_offense));
            RoleList.Add(new Role("Flex", Properties.Resources.Icon_flex));
            RoleList.Add(new Role("Support", Properties.Resources.Icon_support));
            RoleList.Add(new Role("Tank", Properties.Resources.Icon_tank));
        }

        /// <summary>
        /// Generates the Heroes
        /// </summary>
        private void GenerateHeroes()
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
        private void GenerateGametypes()
        {
            GametypeList.Add(new Gametype("Assault", Properties.Resources.Icon_assault));
            GametypeList.Add(new Gametype("Control", Properties.Resources.Icon_control));
            GametypeList.Add(new Gametype("Escort", Properties.Resources.Icon_escort));
            GametypeList.Add(new Gametype("Hybrid", Properties.Resources.Icon_hybrid));
        }

        /// <summary>
        /// Generates the Maps
        /// </summary>
        private void GenerateMaps()
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
                "t2p5Image.png",
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
                "message.txt",
                "host.txt",
                "caster1.txt",
                "caster2.txt",
                "analyst1.txt",
                "analyst2.txt",
                "utility1.txt", //6
                "utility2.txt",
                "utility3.txt",
                "utility4.txt",
                "utility5.txt",
                "utility6.txt",
                "utility7.txt",
                "utility8.txt",
                "utility9.txt",
                "utility10.txt",
                "utility11.txt",
                "utility12.txt",
                "utility13.txt",
                "utility14.txt",
                "utility15.txt",
                "utility16.txt",
                "utility17.txt",
                "utility18.txt",
                "utility19.txt",
                "utility20.txt",
                "utility21.txt",
                "utility22.txt",
                "image1Path.png", //28
                "image2Path.png",
                "image3Path.png",
                "image4Path.png",
                "image5Path.png",
                "image6Path.png",
                "image7Path.png",
                "image8Path.png",
                "image9Path.png",
                "image10Path.png",
                "image11Path.png",
                "image12Path.png",
                "image13Path.png",
                "image14Path.png",
                "image15Path.png",
                "image16Path.png",
                "image17Path.png",
                "image18Path.png",
                "image19Path.png",
                "image20Path.png",
                "image21Path.png",
                "image22Path.png",
                "image23Path.png",
                "image24Path.png",
                "image25Path.png",
                "image26Path.png",
                "image27Path.png",
                "image28Path.png",
                "colorTheme1.txt", //56
                "colorTheme2.txt",
                "colorTheme3.txt",
                "image1.png", //59
                "image2.png",
                "image3.png",
                "image4.png",
                "image5.png",
                "image6.png",
                "image7.png",
                "image8.png",
                "image9.png",
                "image10.png",
                "image11.png",
                "image12.png",
                "image13.png",
                "image14.png",
                "image15.png",
                "image16.png",
                "image17.png",
                "image18.png",
                "image19.png",
                "image20.png",
                "image21.png",
                "image22.png",
                "image23.png",
                "image24.png",
                "image25.png",
                "image26.png",
                "image27.png",
                "image28.png",
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
                "image.png",
                "image.txt",
                "player.txt",
                "role.png",
                "role.txt",
                "sr.txt",
                "team.txt",
                "info.txt"
            };

            ReplayFiles = new List<string>
            {
                "Replay Replay.mp4",
                "Desk Replay.mp4",
                "ReplayPath.txt"
            };

            SettingFiles = new List<string>
            {

            };

            BracketFiles = new List<string>
            {
                "bracketTeam1.txt",
                "bracketTeam2.txt",
                "bracketTeam3.txt",
                "bracketTeam4.txt",
                "bracketTeam5.txt",
                "bracketTeam6.txt",
                "bracketTeam7.txt",
                "bracketTeam8.txt",
                "bracketTeam9.txt",
                "bracketTeam10.txt",
                "bracketTeam11.txt",
                "bracketTeam12.txt",
                "bracketTeam13.txt",
                "bracketTeam14.txt",
                "bracketTeam15.txt",
                "bracketTeam16.txt",
                "bracketTeam1.png",
                "bracketTeam2.png",
                "bracketTeam3.png",
                "bracketTeam4.png",
                "bracketTeam5.png",
                "bracketTeam6.png",
                "bracketTeam7.png",
                "bracketTeam8.png",
                "bracketTeam9.png",
                "bracketTeam10.png",
                "bracketTeam11.png",
                "bracketTeam12.png",
                "bracketTeam13.png",
                "bracketTeam14.png",
                "bracketTeam15.png",
                "bracketTeam16.png",
                "bracketR1M1Team1.txt",
                "bracketR1M1Team2.txt",
                "bracketR1M2Team1.txt",
                "bracketR1M2Team2.txt",
                "bracketR1M3Team1.txt",
                "bracketR1M3Team2.txt",
                "bracketR1M4Team1.txt",
                "bracketR1M4Team2.txt",
                "bracketR1M5Team1.txt",
                "bracketR1M5Team2.txt",
                "bracketR1M6Team1.txt",
                "bracketR1M6Team2.txt",
                "bracketR1M7Team1.txt",
                "bracketR1M7Team2.txt",
                "bracketR1M8Team1.txt",
                "bracketR1M8Team2.txt",
                "bracketQFM1Team1.txt",
                "bracketQFM1Team2.txt",
                "bracketQFM2Team1.txt",
                "bracketQFM2Team2.txt",
                "bracketQFM3Team1.txt",
                "bracketQFM3Team2.txt",
                "bracketQFM4Team1.txt",
                "bracketQFM4Team2.txt",
                "bracketSFM1Team1.txt",
                "bracketSFM1Team2.txt",
                "bracketSFM2Team1.txt",
                "bracketSFM2Team2.txt",
                "bracketWFM1Team1.txt",
                "bracketWFM1Team2.txt",
                "bracketLR1M1Team1.txt",
                "bracketLR1M1Team2.txt",
                "bracketLR1M2Team1.txt",
                "bracketLR1M2Team2.txt",
                "bracketLR1M3Team1.txt",
                "bracketLR1M3Team2.txt",
                "bracketLR1M4Team1.txt",
                "bracketLR1M4Team2.txt",
                "bracketLR2M1Team1.txt",
                "bracketLR2M1Team2.txt",
                "bracketLR2M2Team1.txt",
                "bracketLR2M2Team2.txt",
                "bracketLR2M3Team1.txt",
                "bracketLR2M3Team2.txt",
                "bracketLR2M4Team1.txt",
                "bracketLR2M4Team2.txt",
                "bracketLR3M1Team1.txt",
                "bracketLR3M1Team2.txt",
                "bracketLR3M2Team1.txt",
                "bracketLR3M2Team2.txt",
                "bracketLR4M1Team1.txt",
                "bracketLR4M1Team2.txt",
                "bracketLR4M2Team1.txt",
                "bracketLR4M2Team2.txt",
                "bracketLSFM1Team1.txt",
                "bracketLSFM1Team2.txt",
                "bracketLFM1Team1.txt",
                "bracketLFM1Team2.txt",
                "bracketGF1M1Team1.txt",
                "bracketGF1M1Team2.txt",
                "bracketGF2M1Team1.txt",
                "bracketGF2M1Team2.txt",
                "bracketTPM1Team1.txt",
                "bracketTPM1Team2.txt",
                "bracketR1M1Score1.txt",
                "bracketR1M1Score2.txt",
                "bracketR1M2Score1.txt",
                "bracketR1M2Score2.txt",
                "bracketR1M3Score1.txt",
                "bracketR1M3Score2.txt",
                "bracketR1M4Score1.txt",
                "bracketR1M4Score2.txt",
                "bracketR1M5Score1.txt",
                "bracketR1M6Score2.txt",
                "bracketR1M7Score1.txt",
                "bracketR1M7Score2.txt",
                "bracketR1M8Score1.txt",
                "bracketR1M8Score2.txt",
                "bracketQFM1Score1.txt",
                "bracketQFM1Score2.txt",
                "bracketQFM2Score1.txt",
                "bracketQFM2Score2.txt",
                "bracketQFM3Score1.txt",
                "bracketQFM3Score2.txt",
                "bracketQFM4Score1.txt",
                "bracketQFM4Score2.txt",
                "bracketSFM1Score1.txt",
                "bracketSFM1Score2.txt",
                "bracketSFM2Score1.txt",
                "bracketSFM2Score2.txt",
                "bracketWFM1Score1.txt",
                "bracketWFM1Score2.txt",
                "bracketLR1M1Score1.txt",
                "bracketLR1M1Score2.txt",
                "bracketLR1M2Score1.txt",
                "bracketLR1M2Score2.txt",
                "bracketLR1M3Score1.txt",
                "bracketLR1M3Score2.txt",
                "bracketLR1M4Score1.txt",
                "bracketLR1M4Score2.txt",
                "bracketLR2M1Score1.txt",
                "bracketLR2M1Score2.txt",
                "bracketLR2M2Score1.txt",
                "bracketLR2M2Score2.txt",
                "bracketLR2M3Score1.txt",
                "bracketLR2M3Score2.txt",
                "bracketLR2M4Score1.txt",
                "bracketLR2M4Score2.txt",
                "bracketLR3M1Score1.txt",
                "bracketLR3M1Score2.txt",
                "bracketLR3M2Score1.txt",
                "bracketLR3M2Score2.txt",
                "bracketLR4M1Score1.txt",
                "bracketLR4M1Score2.txt",
                "bracketLR4M2Score1.txt",
                "bracketLR4M2Score2.txt",
                "bracketLSFM1Score1.txt",
                "bracketLSFM1Score2.txt",
                "bracketLFM1Score1.txt",
                "bracketLFM1Score2.txt",
                "bracketGF1M1Score1.txt",
                "bracketGF1M1Score2.txt",
                "bracketGF2M1Score1.txt",
                "bracketGF2M1Score2.txt",
                "bracketTPM1Score1.txt",
                "bracketTPM1Score2.txt",
                "bracketTeam1Path.txt",
                "bracketTeam2Path.txt",
                "bracketTeam3Path.txt",
                "bracketTeam4Path.txt",
                "bracketTeam5Path.txt",
                "bracketTeam6Path.txt",
                "bracketTeam7Path.txt",
                "bracketTeam8Path.txt",
                "bracketTeam9Path.txt",
                "bracketTeam10Path.txt",
                "bracketTeam11Path.txt",
                "bracketTeam12Path.txt",
                "bracketTeam13Path.txt",
                "bracketTeam14Path.txt",
                "bracketTeam15Path.txt",
                "bracketTeam16Path.txt",
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
                "\\Temp",
                "\\Bracket"
            };
        }

        #endregion

        private void replayTeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            replayPlayersCheckedListBox.Items.Clear();

            if (replayTeamComboBox.SelectedIndex == 1)
            {
                foreach (Player player in Match1.Home.Players)
                {
                    replayPlayersCheckedListBox.Items.Insert(0, player.Name);
                }
            }
            else if (replayTeamComboBox.SelectedIndex == 2)
            {
                foreach (Player player in Match1.Away.Players)
                {
                    replayPlayersCheckedListBox.Items.Insert(0, player.Name);
                }
            }
            else
            {
                foreach (Player player in Match1.Home.Players)
                {
                    replayPlayersCheckedListBox.Items.Insert(0, player.Name);
                }
                foreach (Player player in Match1.Away.Players)
                {
                    replayPlayersCheckedListBox.Items.Insert(0, player.Name);
                }
            }
            if (replayListView.SelectedItems.Count > 0)
            {
                Replay selctedReplay = Replays[replayListView.SelectedItems[0].Index];
                if (replayTeamComboBox.Text == Match1.Home.Name)
                {
                    selctedReplay.Team = Match1.Home;
                }
                else if(replayTeamComboBox.Text == Match1.Away.Name)
                {
                    selctedReplay.Team = Match1.Away;
                }
                else
                {
                    selctedReplay.Team = new Team();
                }
                
                replayListView.SelectedItems[0].SubItems[1].Text = replayTeamComboBox.Text;

            }
        }

        private void replayMapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (replayListView.SelectedItems.Count > 0)
            {
                Replay selctedReplay = Replays[replayListView.SelectedItems[0].Index];

                if (replayMapComboBox.Text == Match1.Games[0].Map.Name)
                {
                    selctedReplay.Map = Match1.Games[0].Map;
                }
                else if (replayMapComboBox.Text == Match1.Games[1].Map.Name)
                {
                    selctedReplay.Map = Match1.Games[1].Map;
                }
                else if (replayMapComboBox.Text == Match1.Games[1].Map.Name)
                {
                    selctedReplay.Map = Match1.Games[1].Map;
                }
                else if (replayMapComboBox.Text == Match1.Games[2].Map.Name)
                {
                    selctedReplay.Map = Match1.Games[2].Map;
                }
                else if (replayMapComboBox.Text == Match1.Games[3].Map.Name)
                {
                    selctedReplay.Map = Match1.Games[3].Map;
                }
                else if (replayMapComboBox.Text == Match1.Games[4].Map.Name)
                {
                    selctedReplay.Map = Match1.Games[4].Map;
                }
                else if (replayMapComboBox.Text == Match1.Games[5].Map.Name)
                {
                    selctedReplay.Map = Match1.Games[5].Map;
                }
                else if (replayMapComboBox.Text == Match1.Games[6].Map.Name)
                {
                    selctedReplay.Map = Match1.Games[6].Map;
                }
                else
                {
                    selctedReplay.Map = new Map();
                }
                replayListView.SelectedItems[0].SubItems[2].Text = replayMapComboBox.Text;
            }
        }

        private void replayRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (replayListView.SelectedItems.Count > 0)
            {
                Replay selctedReplay = Replays[replayListView.SelectedItems[0].Index];
                selctedReplay.Description = replayRichTextBox.Text;
                replayListView.SelectedItems[0].SubItems[3].Text = replayRichTextBox.Text;
            }
        }

        private void playersCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (replayListView.SelectedItems.Count > 0)
            {
                Replays[replayListView.SelectedItems[0].Index].Players.Clear();
                if (replayTeamComboBox.SelectedIndex == 1)
                {
                    foreach (Player player in Match1.Home.Players)
                    {
                        if (replayPlayersCheckedListBox.CheckedItems.Contains(player.Name.Trim()))
                        {
                            Replays[replayListView.SelectedItems[0].Index].Players.Add(player);
                        }
                    }
                }
                else if (replayTeamComboBox.SelectedIndex == 2)
                {
                    foreach (Player player in Match1.Away.Players)
                    {
                        if (replayPlayersCheckedListBox.CheckedItems.Contains(player.Name.Trim()))
                        {
                            Replays[replayListView.SelectedItems[0].Index].Players.Add(player);
                        }
                    }
                }
                else
                {
                    foreach (Player player in Match1.Home.Players)
                    {
                        if (replayPlayersCheckedListBox.CheckedItems.Contains(player.Name.Trim()))
                        {
                            Replays[replayListView.SelectedItems[0].Index].Players.Add(player);
                        }
                    }
                    foreach (Player player in Match1.Away.Players)
                    {
                        if (replayPlayersCheckedListBox.CheckedItems.Contains(player.Name.Trim()))
                        {
                            Replays[replayListView.SelectedItems[0].Index].Players.Add(player);
                        }
                    }
                }
            }
        }

        private void replayListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (replayListView.SelectedItems.Count > 0)
            {
                Replay selctedReplay = Replays[replayListView.SelectedItems[0].Index];

                if (selctedReplay.Description != null)
                {
                    replayRichTextBox.Text = selctedReplay.Description;
                }
                else
                {
                    replayRichTextBox.Text = "";
                }
                if (selctedReplay.Team != null)
                {
                    replayTeamComboBox.SelectedIndex = replayTeamComboBox.FindStringExact(selctedReplay.Team.Name);
                }
                else
                {
                    replayTeamComboBox.SelectedIndex = 0;
                }
                if (selctedReplay.Map != null)
                {
                    replayMapComboBox.SelectedIndex = replayMapComboBox.FindStringExact(selctedReplay.Map.Name);
                }
                else
                {
                    replayMapComboBox.SelectedIndex = 0;
                }
                if(selctedReplay.Players.Count != 0)
                {
                    foreach(Player player in selctedReplay.Players)
                    {
                        if (replayPlayersCheckedListBox.Items.Contains(player.Name))
                        {
                            replayPlayersCheckedListBox.SetItemCheckState(replayPlayersCheckedListBox.Items.IndexOf(player.Name), CheckState.Checked);
                        }
                    }
                }
                else
                {
                    foreach(int i in replayPlayersCheckedListBox.CheckedIndices)
                    {
                        replayPlayersCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
                    }
                    
                }
                
            }
        }
        private void replayCopyDetailsButton_Click(object sender, EventArgs e)
        {
            if (replayListView.SelectedItems.Count > 0)
            {
                Replay selctedReplay = Replays[replayListView.SelectedItems[0].Index];
                string team = "";
                string map = "";
                string description = "";
                if (selctedReplay.Description != null)
                {
                    description = selctedReplay.Description;
                }
                if (selctedReplay.Team != null)
                {
                    team = selctedReplay.Team.Name;
                }
                if (selctedReplay.Map != null)
                {
                    map = selctedReplay.Map.Name;
                }
                string players = "";
                foreach(Player player in selctedReplay.Players)
                {
                    players += player.Name + " ";
                }

                MessageBox.Show("Team: " + team + 
                "\nPlayers: " + players +
                "\nMap: " + map +
                "\nDescription: " + description
                    );

                Clipboard.SetText("Team: " + team + 
                    "\nPlayers: " + players +
                    "\nMap: " + map +
                    "\nDescription: " + description
                    );
            }
        }

        private void replaySetButton_Click(object sender, EventArgs e)
        {
            if (replayListView.SelectedItems.Count > 0)
            {
                using (StreamWriter sw = File.CreateText(path + FolderList[4] + "\\" + ReplayFiles[2]))
                {
                    sw.WriteLine(Replays[replayListView.SelectedItems[0].Index].Name);
                }
            } 
        }

        private void replaySaveButton_Click(object sender, EventArgs e)
        {
            if (replayListView.SelectedItems.Count > 0)
            {
                File.Copy(path + FolderList[5] + "\\" + Replays[replayListView.SelectedItems[0].Index].Name, path + FolderList[4] + "\\" + ReplayFiles[1], true);
            }
        }

        private void replayClearButton_Click(object sender, EventArgs e)
        {

        }

        private void colorThemeButton1_Click(object sender, EventArgs e)
        {
            if (colorThemeDialog1.ShowDialog() == DialogResult.OK)
            {
                colorThemeButton1.BackColor = colorThemeDialog1.Color;
            }
        }

        private void colorThemeButton2_Click(object sender, EventArgs e)
        {
            if (colorThemeDialog2.ShowDialog() == DialogResult.OK)
            {
                colorThemeButton2.BackColor = colorThemeDialog2.Color;
            }
        }

        private void colorThemeButton3_Click(object sender, EventArgs e)
        {
            if (colorThemeDialog3.ShowDialog() == DialogResult.OK)
            {
                colorThemeButton3.BackColor = colorThemeDialog3.Color;
            }
        }

        private void m1t1p1ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t1p1Image);
        }

        private void m1t1p2ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t1p2Image);
        }

        private void m1t1p3ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t1p3Image);
        }

        private void m1t1p4ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t1p4Image);
        }

        private void m1t1p5ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t1p5Image);
        }

        private void m1t1p6ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t1p6Image);
        }

        private void m1t2p1ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t2p1Image);
        }

        private void m1t2p2ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t2p2Image);
        }

        private void m1t2p3ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t2p3Image);
        }

        private void m1t2p4ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t2p4Image);
        }

        private void m1t2p5ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t2p5Image);
        }

        private void m1t2p6ImageButton_Click(object sender, EventArgs e)
        {
            GetLogoFile(m1t2p6Image);
        }

        private void bracketImage1_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage1);
        }

        private void bracketImage2_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage2);
        }

        private void bracketImage3_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage3);
        }

        private void bracketImage4_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage4);
        }

        private void bracketImage5_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage5);
        }

        private void bracketImage6_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage6);
        }

        private void bracketImage7_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage7);
        }

        private void bracketImage8_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage8);
        }

        private void bracketImage9_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage9);
        }

        private void bracketImage10_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage10);
        }

        private void bracketImage11_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage11);
        }

        private void bracketImage12_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage12);
        }

        private void bracketImage13_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage13);
        }

        private void bracketImage14_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage14);
        }

        private void bracketImage15_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage15);
        }

        private void bracketImage16_Click(object sender, EventArgs e)
        {
            GetLogoForButton(bracketImage16);
        }

        private void bracketTeamsReset_Click(object sender, EventArgs e)
        {
            resetText(bracketTeam1);
            resetText(bracketTeam2);
            resetText(bracketTeam3);
            resetText(bracketTeam4);
            resetText(bracketTeam5);
            resetText(bracketTeam6);
            resetText(bracketTeam7);
            resetText(bracketTeam8);
            resetText(bracketTeam9);
            resetText(bracketTeam10);
            resetText(bracketTeam11);
            resetText(bracketTeam12);
            resetText(bracketTeam13);
            resetText(bracketTeam14);
            resetText(bracketTeam15);
            resetText(bracketTeam16);

            resetButton(bracketImage1);
            resetButton(bracketImage2);
            resetButton(bracketImage3);
            resetButton(bracketImage4);
            resetButton(bracketImage5);
            resetButton(bracketImage6);
            resetButton(bracketImage7);
            resetButton(bracketImage8);
            resetButton(bracketImage9);
            resetButton(bracketImage10);
            resetButton(bracketImage11);
            resetButton(bracketImage12);
            resetButton(bracketImage13);
            resetButton(bracketImage14);
            resetButton(bracketImage15);
            resetButton(bracketImage16);

            BracketTeams.Clear();

        }

        private void bracketTeamsUpdate_Click(object sender, EventArgs e)
        {
            updateText(bracketTeam1, FolderList[9].Replace("\\", ""), BracketFiles[0].Replace(".txt", ""));
            updateText(bracketTeam2, FolderList[9].Replace("\\", ""), BracketFiles[1].Replace(".txt", ""));
            updateText(bracketTeam3, FolderList[9].Replace("\\", ""), BracketFiles[2].Replace(".txt", ""));
            updateText(bracketTeam4, FolderList[9].Replace("\\", ""), BracketFiles[3].Replace(".txt", ""));
            updateText(bracketTeam5, FolderList[9].Replace("\\", ""), BracketFiles[4].Replace(".txt", ""));
            updateText(bracketTeam6, FolderList[9].Replace("\\", ""), BracketFiles[5].Replace(".txt", ""));
            updateText(bracketTeam7, FolderList[9].Replace("\\", ""), BracketFiles[6].Replace(".txt", ""));
            updateText(bracketTeam8, FolderList[9].Replace("\\", ""), BracketFiles[7].Replace(".txt", ""));
            updateText(bracketTeam9, FolderList[9].Replace("\\", ""), BracketFiles[8].Replace(".txt", ""));
            updateText(bracketTeam10, FolderList[9].Replace("\\", ""), BracketFiles[9].Replace(".txt", ""));
            updateText(bracketTeam11, FolderList[9].Replace("\\", ""), BracketFiles[10].Replace(".txt", ""));
            updateText(bracketTeam12, FolderList[9].Replace("\\", ""), BracketFiles[11].Replace(".txt", ""));
            updateText(bracketTeam13, FolderList[9].Replace("\\", ""), BracketFiles[12].Replace(".txt", ""));
            updateText(bracketTeam14, FolderList[9].Replace("\\", ""), BracketFiles[13].Replace(".txt", ""));
            updateText(bracketTeam15, FolderList[9].Replace("\\", ""), BracketFiles[14].Replace(".txt", ""));
            updateText(bracketTeam16, FolderList[9].Replace("\\", ""), BracketFiles[15].Replace(".txt", ""));

            updateButton(bracketImage1, FolderList[9].Replace("\\", ""), BracketFiles[16].Replace(".png", ""));
            updateButton(bracketImage2, FolderList[9].Replace("\\", ""), BracketFiles[17].Replace(".png", ""));
            updateButton(bracketImage3, FolderList[9].Replace("\\", ""), BracketFiles[18].Replace(".png", ""));
            updateButton(bracketImage4, FolderList[9].Replace("\\", ""), BracketFiles[19].Replace(".png", ""));
            updateButton(bracketImage5, FolderList[9].Replace("\\", ""), BracketFiles[20].Replace(".png", ""));
            updateButton(bracketImage6, FolderList[9].Replace("\\", ""), BracketFiles[21].Replace(".png", ""));
            updateButton(bracketImage7, FolderList[9].Replace("\\", ""), BracketFiles[22].Replace(".png", ""));
            updateButton(bracketImage8, FolderList[9].Replace("\\", ""), BracketFiles[23].Replace(".png", ""));
            updateButton(bracketImage9, FolderList[9].Replace("\\", ""), BracketFiles[24].Replace(".png", ""));
            updateButton(bracketImage10, FolderList[9].Replace("\\", ""), BracketFiles[25].Replace(".png", ""));
            updateButton(bracketImage11, FolderList[9].Replace("\\", ""), BracketFiles[26].Replace(".png", ""));
            updateButton(bracketImage12, FolderList[9].Replace("\\", ""), BracketFiles[27].Replace(".png", ""));
            updateButton(bracketImage13, FolderList[9].Replace("\\", ""), BracketFiles[28].Replace(".png", ""));
            updateButton(bracketImage14, FolderList[9].Replace("\\", ""), BracketFiles[29].Replace(".png", ""));
            updateButton(bracketImage15, FolderList[9].Replace("\\", ""), BracketFiles[30].Replace(".png", ""));
            updateButton(bracketImage16, FolderList[9].Replace("\\", ""), BracketFiles[31].Replace(".png", ""));

            setBracketTeams();

        }

        private void bracketReset_Click(object sender, EventArgs e)
        {
            resetCombo(bracketR1M1Team1); 
            resetCombo(bracketR1M1Team2);
            resetCombo(bracketR1M2Team1);
            resetCombo(bracketR1M2Team2);
            resetCombo(bracketR1M3Team1);
            resetCombo(bracketR1M3Team2);
            resetCombo(bracketR1M4Team1);
            resetCombo(bracketR1M4Team2);
            resetCombo(bracketR1M5Team1);
            resetCombo(bracketR1M5Team2);
            resetCombo(bracketR1M6Team1);
            resetCombo(bracketR1M6Team2);
            resetCombo(bracketR1M7Team1);
            resetCombo(bracketR1M7Team2);
            resetCombo(bracketR1M8Team1);
            resetCombo(bracketR1M8Team2);
            resetCombo(bracketQFM1Team1);
            resetCombo(bracketQFM1Team2);
            resetCombo(bracketQFM2Team1);
            resetCombo(bracketQFM2Team2);
            resetCombo(bracketQFM3Team1);
            resetCombo(bracketQFM3Team2);
            resetCombo(bracketQFM4Team1);
            resetCombo(bracketQFM4Team2);
            resetCombo(bracketSFM1Team1);
            resetCombo(bracketSFM1Team2);
            resetCombo(bracketSFM2Team1);
            resetCombo(bracketSFM2Team2);
            resetCombo(bracketWFM1Team1);
            resetCombo(bracketWFM1Team2);
            resetCombo(bracketLR1M1Team1);
            resetCombo(bracketLR1M1Team2);
            resetCombo(bracketLR1M2Team1);
            resetCombo(bracketLR1M2Team2);
            resetCombo(bracketLR1M3Team1);
            resetCombo(bracketLR1M3Team2);
            resetCombo(bracketLR1M4Team1);
            resetCombo(bracketLR1M4Team2);
            resetCombo(bracketLR2M1Team1);
            resetCombo(bracketLR2M1Team2);
            resetCombo(bracketLR2M2Team1);
            resetCombo(bracketLR2M2Team2);
            resetCombo(bracketLR2M3Team1);
            resetCombo(bracketLR2M3Team2);
            resetCombo(bracketLR2M4Team1);
            resetCombo(bracketLR2M4Team2);
            resetCombo(bracketLR3M1Team1);
            resetCombo(bracketLR3M1Team2);
            resetCombo(bracketLR3M2Team1);
            resetCombo(bracketLR3M2Team2);
            resetCombo(bracketLR4M1Team1);
            resetCombo(bracketLR4M1Team2);
            resetCombo(bracketLR4M2Team1);
            resetCombo(bracketLR4M2Team2);
            resetCombo(bracketLSFM1Team1);
            resetCombo(bracketLSFM1Team2);
            resetCombo(bracketLFM1Team1);
            resetCombo(bracketLFM1Team2);
            resetCombo(bracketGF1M1Team1);
            resetCombo(bracketGF1M1Team2);
            resetCombo(bracketGF2M1Team1);
            resetCombo(bracketGF2M1Team2);
            resetCombo(bracketTPM1Team1);
            resetCombo(bracketTPM1Team2);

            resetScore(bracketR1M1Score1);
            resetScore(bracketR1M1Score2);
            resetScore(bracketR1M2Score1);
            resetScore(bracketR1M2Score2);
            resetScore(bracketR1M3Score1);
            resetScore(bracketR1M3Score2);
            resetScore(bracketR1M4Score1);
            resetScore(bracketR1M4Score2);
            resetScore(bracketR1M5Score1);
            resetScore(bracketR1M5Score2);
            resetScore(bracketR1M6Score1);
            resetScore(bracketR1M6Score2);
            resetScore(bracketR1M7Score1);
            resetScore(bracketR1M7Score2);
            resetScore(bracketR1M8Score1);
            resetScore(bracketR1M8Score2);
            resetScore(bracketQFM1Score1);
            resetScore(bracketQFM1Score2);
            resetScore(bracketQFM2Score1);
            resetScore(bracketQFM2Score2);
            resetScore(bracketQFM3Score1);
            resetScore(bracketQFM3Score2);
            resetScore(bracketQFM4Score1);
            resetScore(bracketQFM4Score2);
            resetScore(bracketSFM1Score1);
            resetScore(bracketSFM1Score2);
            resetScore(bracketSFM2Score1);
            resetScore(bracketSFM2Score2);
            resetScore(bracketWFM1Score1);
            resetScore(bracketWFM1Score2);
            resetScore(bracketLR1M1Score1);
            resetScore(bracketLR1M1Score2);
            resetScore(bracketLR1M2Score1);
            resetScore(bracketLR1M2Score2);
            resetScore(bracketLR1M3Score1);
            resetScore(bracketLR1M3Score2);
            resetScore(bracketLR1M4Score1);
            resetScore(bracketLR1M4Score2);
            resetScore(bracketLR2M1Score1);
            resetScore(bracketLR2M1Score2);
            resetScore(bracketLR2M2Score1);
            resetScore(bracketLR2M2Score2);
            resetScore(bracketLR2M3Score1);
            resetScore(bracketLR2M3Score2);
            resetScore(bracketLR2M4Score1);
            resetScore(bracketLR2M4Score2);
            resetScore(bracketLR3M1Score1);
            resetScore(bracketLR3M1Score2);
            resetScore(bracketLR3M2Score1);
            resetScore(bracketLR3M2Score2);
            resetScore(bracketLR4M1Score1);
            resetScore(bracketLR4M1Score2);
            resetScore(bracketLR4M2Score1);
            resetScore(bracketLR4M2Score2);
            resetScore(bracketLSFM1Score1);
            resetScore(bracketLSFM1Score2);
            resetScore(bracketLFM1Score1);
            resetScore(bracketLFM1Score2);
            resetScore(bracketGF1M1Score1);
            resetScore(bracketGF1M1Score2);
            resetScore(bracketGF2M1Score1);
            resetScore(bracketGF2M1Score2);
            resetScore(bracketTPM1Score1);
            resetScore(bracketTPM1Score2);
        }

        private void bracketUpdate_Click(object sender, EventArgs e)
        {
            updateCombo(bracketR1M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[32].Replace(".txt", ""));
            updateCombo(bracketR1M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[33].Replace(".txt", ""));
            updateCombo(bracketR1M2Team1, FolderList[9].Replace("\\", ""), BracketFiles[34].Replace(".txt", ""));
            updateCombo(bracketR1M2Team2, FolderList[9].Replace("\\", ""), BracketFiles[35].Replace(".txt", ""));
            updateCombo(bracketR1M3Team1, FolderList[9].Replace("\\", ""), BracketFiles[36].Replace(".txt", ""));
            updateCombo(bracketR1M3Team2, FolderList[9].Replace("\\", ""), BracketFiles[37].Replace(".txt", ""));
            updateCombo(bracketR1M4Team1, FolderList[9].Replace("\\", ""), BracketFiles[38].Replace(".txt", ""));
            updateCombo(bracketR1M4Team2, FolderList[9].Replace("\\", ""), BracketFiles[39].Replace(".txt", ""));
            updateCombo(bracketR1M5Team1, FolderList[9].Replace("\\", ""), BracketFiles[40].Replace(".txt", ""));
            updateCombo(bracketR1M5Team2, FolderList[9].Replace("\\", ""), BracketFiles[41].Replace(".txt", ""));
            updateCombo(bracketR1M6Team1, FolderList[9].Replace("\\", ""), BracketFiles[42].Replace(".txt", ""));
            updateCombo(bracketR1M6Team2, FolderList[9].Replace("\\", ""), BracketFiles[43].Replace(".txt", ""));
            updateCombo(bracketR1M7Team1, FolderList[9].Replace("\\", ""), BracketFiles[44].Replace(".txt", ""));
            updateCombo(bracketR1M7Team2, FolderList[9].Replace("\\", ""), BracketFiles[45].Replace(".txt", ""));
            updateCombo(bracketR1M8Team1, FolderList[9].Replace("\\", ""), BracketFiles[46].Replace(".txt", ""));
            updateCombo(bracketR1M8Team2, FolderList[9].Replace("\\", ""), BracketFiles[47].Replace(".txt", ""));
            updateCombo(bracketQFM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[48].Replace(".txt", ""));
            updateCombo(bracketQFM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[49].Replace(".txt", ""));
            updateCombo(bracketQFM2Team1, FolderList[9].Replace("\\", ""), BracketFiles[50].Replace(".txt", ""));
            updateCombo(bracketQFM2Team2, FolderList[9].Replace("\\", ""), BracketFiles[51].Replace(".txt", ""));
            updateCombo(bracketQFM3Team1, FolderList[9].Replace("\\", ""), BracketFiles[52].Replace(".txt", ""));
            updateCombo(bracketQFM3Team2, FolderList[9].Replace("\\", ""), BracketFiles[53].Replace(".txt", ""));
            updateCombo(bracketQFM4Team1, FolderList[9].Replace("\\", ""), BracketFiles[54].Replace(".txt", ""));
            updateCombo(bracketQFM4Team2, FolderList[9].Replace("\\", ""), BracketFiles[55].Replace(".txt", ""));
            updateCombo(bracketSFM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[56].Replace(".txt", ""));
            updateCombo(bracketSFM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[57].Replace(".txt", ""));
            updateCombo(bracketSFM2Team1, FolderList[9].Replace("\\", ""), BracketFiles[58].Replace(".txt", ""));
            updateCombo(bracketSFM2Team2, FolderList[9].Replace("\\", ""), BracketFiles[59].Replace(".txt", ""));
            updateCombo(bracketWFM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[60].Replace(".txt", ""));
            updateCombo(bracketWFM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[61].Replace(".txt", ""));
            updateCombo(bracketLR1M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[62].Replace(".txt", ""));
            updateCombo(bracketLR1M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[63].Replace(".txt", ""));
            updateCombo(bracketLR1M2Team1, FolderList[9].Replace("\\", ""), BracketFiles[64].Replace(".txt", ""));
            updateCombo(bracketLR1M2Team2, FolderList[9].Replace("\\", ""), BracketFiles[65].Replace(".txt", ""));
            updateCombo(bracketLR1M3Team1, FolderList[9].Replace("\\", ""), BracketFiles[66].Replace(".txt", ""));
            updateCombo(bracketLR1M3Team2, FolderList[9].Replace("\\", ""), BracketFiles[67].Replace(".txt", ""));
            updateCombo(bracketLR1M4Team1, FolderList[9].Replace("\\", ""), BracketFiles[68].Replace(".txt", ""));
            updateCombo(bracketLR1M4Team2, FolderList[9].Replace("\\", ""), BracketFiles[69].Replace(".txt", ""));
            updateCombo(bracketLR2M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[70].Replace(".txt", ""));
            updateCombo(bracketLR2M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[71].Replace(".txt", ""));
            updateCombo(bracketLR2M2Team1, FolderList[9].Replace("\\", ""), BracketFiles[72].Replace(".txt", ""));
            updateCombo(bracketLR2M2Team2, FolderList[9].Replace("\\", ""), BracketFiles[73].Replace(".txt", ""));
            updateCombo(bracketLR2M3Team1, FolderList[9].Replace("\\", ""), BracketFiles[74].Replace(".txt", ""));
            updateCombo(bracketLR2M3Team2, FolderList[9].Replace("\\", ""), BracketFiles[75].Replace(".txt", ""));
            updateCombo(bracketLR2M4Team1, FolderList[9].Replace("\\", ""), BracketFiles[76].Replace(".txt", ""));
            updateCombo(bracketLR2M4Team2, FolderList[9].Replace("\\", ""), BracketFiles[77].Replace(".txt", ""));
            updateCombo(bracketLR3M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[78].Replace(".txt", ""));
            updateCombo(bracketLR3M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[79].Replace(".txt", ""));
            updateCombo(bracketLR3M2Team1, FolderList[9].Replace("\\", ""), BracketFiles[80].Replace(".txt", ""));
            updateCombo(bracketLR3M2Team2, FolderList[9].Replace("\\", ""), BracketFiles[81].Replace(".txt", ""));
            updateCombo(bracketLR4M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[82].Replace(".txt", ""));
            updateCombo(bracketLR4M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[83].Replace(".txt", ""));
            updateCombo(bracketLR4M2Team1, FolderList[9].Replace("\\", ""), BracketFiles[84].Replace(".txt", ""));
            updateCombo(bracketLR4M2Team2, FolderList[9].Replace("\\", ""), BracketFiles[85].Replace(".txt", ""));
            updateCombo(bracketLSFM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[86].Replace(".txt", ""));
            updateCombo(bracketLSFM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[87].Replace(".txt", ""));
            updateCombo(bracketLFM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[88].Replace(".txt", ""));
            updateCombo(bracketLFM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[89].Replace(".txt", ""));
            updateCombo(bracketGF1M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[90].Replace(".txt", ""));
            updateCombo(bracketGF1M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[91].Replace(".txt", ""));
            updateCombo(bracketGF2M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[92].Replace(".txt", ""));
            updateCombo(bracketGF2M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[93].Replace(".txt", ""));
            updateCombo(bracketTPM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[94].Replace(".txt", ""));
            updateCombo(bracketTPM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[95].Replace(".txt", ""));

            updateScore(bracketR1M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[96].Replace(".txt", ""));
            updateScore(bracketR1M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[97].Replace(".txt", ""));
            updateScore(bracketR1M2Score1, FolderList[9].Replace("\\", ""), BracketFiles[98].Replace(".txt", ""));
            updateScore(bracketR1M2Score2, FolderList[9].Replace("\\", ""), BracketFiles[99].Replace(".txt", ""));
            updateScore(bracketR1M3Score1, FolderList[9].Replace("\\", ""), BracketFiles[100].Replace(".txt", ""));
            updateScore(bracketR1M3Score2, FolderList[9].Replace("\\", ""), BracketFiles[101].Replace(".txt", ""));
            updateScore(bracketR1M4Score1, FolderList[9].Replace("\\", ""), BracketFiles[102].Replace(".txt", ""));
            updateScore(bracketR1M4Score2, FolderList[9].Replace("\\", ""), BracketFiles[103].Replace(".txt", ""));
            updateScore(bracketR1M5Score1, FolderList[9].Replace("\\", ""), BracketFiles[104].Replace(".txt", ""));
            updateScore(bracketR1M5Score2, FolderList[9].Replace("\\", ""), BracketFiles[105].Replace(".txt", ""));
            updateScore(bracketR1M6Score1, FolderList[9].Replace("\\", ""), BracketFiles[106].Replace(".txt", ""));
            updateScore(bracketR1M6Score2, FolderList[9].Replace("\\", ""), BracketFiles[107].Replace(".txt", ""));
            updateScore(bracketR1M7Score1, FolderList[9].Replace("\\", ""), BracketFiles[108].Replace(".txt", ""));
            updateScore(bracketR1M7Score2, FolderList[9].Replace("\\", ""), BracketFiles[109].Replace(".txt", ""));
            updateScore(bracketR1M8Score1, FolderList[9].Replace("\\", ""), BracketFiles[110].Replace(".txt", ""));
            updateScore(bracketR1M8Score2, FolderList[9].Replace("\\", ""), BracketFiles[111].Replace(".txt", ""));
            updateScore(bracketQFM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[112].Replace(".txt", ""));
            updateScore(bracketQFM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[113].Replace(".txt", ""));
            updateScore(bracketQFM2Score1, FolderList[9].Replace("\\", ""), BracketFiles[114].Replace(".txt", ""));
            updateScore(bracketQFM2Score2, FolderList[9].Replace("\\", ""), BracketFiles[115].Replace(".txt", ""));
            updateScore(bracketQFM3Score1, FolderList[9].Replace("\\", ""), BracketFiles[116].Replace(".txt", ""));
            updateScore(bracketQFM3Score2, FolderList[9].Replace("\\", ""), BracketFiles[117].Replace(".txt", ""));
            updateScore(bracketQFM4Score1, FolderList[9].Replace("\\", ""), BracketFiles[118].Replace(".txt", ""));
            updateScore(bracketQFM4Score2, FolderList[9].Replace("\\", ""), BracketFiles[119].Replace(".txt", ""));
            updateScore(bracketSFM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[120].Replace(".txt", ""));
            updateScore(bracketSFM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[121].Replace(".txt", ""));
            updateScore(bracketSFM2Score1, FolderList[9].Replace("\\", ""), BracketFiles[122].Replace(".txt", ""));
            updateScore(bracketSFM2Score2, FolderList[9].Replace("\\", ""), BracketFiles[123].Replace(".txt", ""));
            updateScore(bracketWFM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[124].Replace(".txt", ""));
            updateScore(bracketWFM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[125].Replace(".txt", ""));
            updateScore(bracketLR1M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[126].Replace(".txt", ""));
            updateScore(bracketLR1M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[127].Replace(".txt", ""));
            updateScore(bracketLR1M2Score1, FolderList[9].Replace("\\", ""), BracketFiles[128].Replace(".txt", ""));
            updateScore(bracketLR1M2Score2, FolderList[9].Replace("\\", ""), BracketFiles[129].Replace(".txt", ""));
            updateScore(bracketLR1M3Score1, FolderList[9].Replace("\\", ""), BracketFiles[130].Replace(".txt", ""));
            updateScore(bracketLR1M3Score2, FolderList[9].Replace("\\", ""), BracketFiles[131].Replace(".txt", ""));
            updateScore(bracketLR1M4Score1, FolderList[9].Replace("\\", ""), BracketFiles[132].Replace(".txt", ""));
            updateScore(bracketLR1M4Score2, FolderList[9].Replace("\\", ""), BracketFiles[133].Replace(".txt", ""));
            updateScore(bracketLR2M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[134].Replace(".txt", ""));
            updateScore(bracketLR2M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[135].Replace(".txt", ""));
            updateScore(bracketLR2M2Score1, FolderList[9].Replace("\\", ""), BracketFiles[136].Replace(".txt", ""));
            updateScore(bracketLR2M2Score2, FolderList[9].Replace("\\", ""), BracketFiles[137].Replace(".txt", ""));
            updateScore(bracketLR2M3Score1, FolderList[9].Replace("\\", ""), BracketFiles[138].Replace(".txt", ""));
            updateScore(bracketLR2M3Score2, FolderList[9].Replace("\\", ""), BracketFiles[139].Replace(".txt", ""));
            updateScore(bracketLR2M4Score1, FolderList[9].Replace("\\", ""), BracketFiles[140].Replace(".txt", ""));
            updateScore(bracketLR2M4Score2, FolderList[9].Replace("\\", ""), BracketFiles[141].Replace(".txt", ""));
            updateScore(bracketLR3M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[142].Replace(".txt", ""));
            updateScore(bracketLR3M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[143].Replace(".txt", ""));
            updateScore(bracketLR3M2Score1, FolderList[9].Replace("\\", ""), BracketFiles[144].Replace(".txt", ""));
            updateScore(bracketLR3M2Score2, FolderList[9].Replace("\\", ""), BracketFiles[145].Replace(".txt", ""));
            updateScore(bracketLR4M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[146].Replace(".txt", ""));
            updateScore(bracketLR4M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[147].Replace(".txt", ""));
            updateScore(bracketLR4M2Score1, FolderList[9].Replace("\\", ""), BracketFiles[148].Replace(".txt", ""));
            updateScore(bracketLR4M2Score2, FolderList[9].Replace("\\", ""), BracketFiles[149].Replace(".txt", ""));
            updateScore(bracketLSFM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[150].Replace(".txt", ""));
            updateScore(bracketLSFM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[151].Replace(".txt", ""));
            updateScore(bracketLFM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[152].Replace(".txt", ""));
            updateScore(bracketLFM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[153].Replace(".txt", ""));
            updateScore(bracketGF1M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[154].Replace(".txt", ""));
            updateScore(bracketGF1M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[155].Replace(".txt", ""));
            updateScore(bracketGF2M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[156].Replace(".txt", ""));
            updateScore(bracketGF2M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[157].Replace(".txt", ""));
            updateScore(bracketTPM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[158].Replace(".txt", ""));
            updateScore(bracketTPM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[159].Replace(".txt", ""));
        }

        private void linkBracketToTeams()
        {
            bracketR1M1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M2Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M2Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M3Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M3Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M4Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M4Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M5Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M5Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M6Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M6Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M7Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M7Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M8Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketR1M8Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketQFM1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketQFM1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketQFM2Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketQFM2Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketQFM3Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketQFM3Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketQFM4Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketQFM4Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketSFM1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketSFM1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketSFM2Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketSFM2Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketWFM1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketWFM1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR1M1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR1M1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR1M2Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR1M2Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR1M3Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR1M3Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR1M4Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR1M4Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR2M1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR2M1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR2M2Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR2M2Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR2M3Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR2M3Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR2M4Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR2M4Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR3M1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR3M1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR3M2Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR3M2Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR4M1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR4M1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR4M2Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLR4M2Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLSFM1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLSFM1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLFM1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketLFM1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketGF1M1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketGF1M1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketGF2M1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketGF2M1Team2.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketTPM1Team1.DataSource = new BindingSource { DataSource = BracketTeams };
            bracketTPM1Team2.DataSource = new BindingSource { DataSource = BracketTeams };

            bracketR1M1Team1.DisplayMember = "Name";
            bracketR1M1Team2.DisplayMember = "Name";
            bracketR1M2Team1.DisplayMember = "Name";
            bracketR1M2Team2.DisplayMember = "Name";
            bracketR1M3Team1.DisplayMember = "Name";
            bracketR1M3Team2.DisplayMember = "Name";
            bracketR1M4Team1.DisplayMember = "Name";
            bracketR1M4Team2.DisplayMember = "Name";
            bracketR1M5Team1.DisplayMember = "Name";
            bracketR1M5Team2.DisplayMember = "Name";
            bracketR1M6Team1.DisplayMember = "Name";
            bracketR1M6Team2.DisplayMember = "Name";
            bracketR1M7Team1.DisplayMember = "Name";
            bracketR1M7Team2.DisplayMember = "Name";
            bracketR1M8Team1.DisplayMember = "Name";
            bracketR1M8Team2.DisplayMember = "Name";
            bracketQFM1Team1.DisplayMember = "Name";
            bracketQFM1Team2.DisplayMember = "Name";
            bracketQFM2Team1.DisplayMember = "Name";
            bracketQFM2Team2.DisplayMember = "Name";
            bracketQFM3Team1.DisplayMember = "Name";
            bracketQFM3Team2.DisplayMember = "Name";
            bracketQFM4Team1.DisplayMember = "Name";
            bracketQFM4Team2.DisplayMember = "Name";
            bracketSFM1Team1.DisplayMember = "Name";
            bracketSFM1Team2.DisplayMember = "Name";
            bracketSFM2Team1.DisplayMember = "Name";
            bracketSFM2Team2.DisplayMember = "Name";
            bracketWFM1Team1.DisplayMember = "Name";
            bracketWFM1Team2.DisplayMember = "Name";
            bracketLR1M1Team1.DisplayMember = "Name";
            bracketLR1M1Team2.DisplayMember = "Name";
            bracketLR1M2Team1.DisplayMember = "Name";
            bracketLR1M2Team2.DisplayMember = "Name";
            bracketLR1M3Team1.DisplayMember = "Name";
            bracketLR1M3Team2.DisplayMember = "Name";
            bracketLR1M4Team1.DisplayMember = "Name";
            bracketLR1M4Team2.DisplayMember = "Name";
            bracketLR2M1Team1.DisplayMember = "Name";
            bracketLR2M1Team2.DisplayMember = "Name";
            bracketLR2M2Team1.DisplayMember = "Name";
            bracketLR2M2Team2.DisplayMember = "Name";
            bracketLR2M3Team1.DisplayMember = "Name";
            bracketLR2M3Team2.DisplayMember = "Name";
            bracketLR2M4Team1.DisplayMember = "Name";
            bracketLR2M4Team2.DisplayMember = "Name";
            bracketLR3M1Team1.DisplayMember = "Name";
            bracketLR3M1Team2.DisplayMember = "Name";
            bracketLR3M2Team1.DisplayMember = "Name";
            bracketLR3M2Team2.DisplayMember = "Name";
            bracketLR4M1Team1.DisplayMember = "Name";
            bracketLR4M1Team2.DisplayMember = "Name";
            bracketLR4M2Team1.DisplayMember = "Name";
            bracketLR4M2Team2.DisplayMember = "Name";
            bracketLSFM1Team1.DisplayMember = "Name";
            bracketLSFM1Team2.DisplayMember = "Name";
            bracketLFM1Team1.DisplayMember = "Name";
            bracketLFM1Team2.DisplayMember = "Name";
            bracketGF1M1Team1.DisplayMember = "Name";
            bracketGF1M1Team2.DisplayMember = "Name";
            bracketGF2M1Team1.DisplayMember = "Name";
            bracketGF2M1Team2.DisplayMember = "Name";
            bracketTPM1Team1.DisplayMember = "Name";
            bracketTPM1Team2.DisplayMember = "Name";

        }

        private void setBracketTeams()
        {
            BracketTeams.Clear();
            BracketTeams.Add(new Team());
            BracketTeams.Add(new Team(bracketTeam1.Text, path + FolderList[9] + BracketFiles[16]));
            BracketTeams.Add(new Team(bracketTeam2.Text, path + FolderList[9] + BracketFiles[17]));
            BracketTeams.Add(new Team(bracketTeam3.Text, path + FolderList[9] + BracketFiles[18]));
            BracketTeams.Add(new Team(bracketTeam4.Text, path + FolderList[9] + BracketFiles[19]));
            BracketTeams.Add(new Team(bracketTeam5.Text, path + FolderList[9] + BracketFiles[20]));
            BracketTeams.Add(new Team(bracketTeam6.Text, path + FolderList[9] + BracketFiles[21]));
            BracketTeams.Add(new Team(bracketTeam7.Text, path + FolderList[9] + BracketFiles[22]));
            BracketTeams.Add(new Team(bracketTeam8.Text, path + FolderList[9] + BracketFiles[23]));
            BracketTeams.Add(new Team(bracketTeam9.Text, path + FolderList[9] + BracketFiles[24]));
            BracketTeams.Add(new Team(bracketTeam10.Text, path + FolderList[9] + BracketFiles[25]));
            BracketTeams.Add(new Team(bracketTeam11.Text, path + FolderList[9] + BracketFiles[26]));
            BracketTeams.Add(new Team(bracketTeam12.Text, path + FolderList[9] + BracketFiles[27]));
            BracketTeams.Add(new Team(bracketTeam13.Text, path + FolderList[9] + BracketFiles[28]));
            BracketTeams.Add(new Team(bracketTeam14.Text, path + FolderList[9] + BracketFiles[29]));
            BracketTeams.Add(new Team(bracketTeam15.Text, path + FolderList[9] + BracketFiles[30]));
            BracketTeams.Add(new Team(bracketTeam16.Text, path + FolderList[9] + BracketFiles[31]));
        }

        private void loadBracket()
        {
            loadText(bracketTeam1, FolderList[9].Replace("\\", ""), BracketFiles[0].Replace(".txt", ""));
            loadText(bracketTeam2, FolderList[9].Replace("\\", ""), BracketFiles[1].Replace(".txt", ""));
            loadText(bracketTeam3, FolderList[9].Replace("\\", ""), BracketFiles[2].Replace(".txt", ""));
            loadText(bracketTeam4, FolderList[9].Replace("\\", ""), BracketFiles[3].Replace(".txt", ""));
            loadText(bracketTeam5, FolderList[9].Replace("\\", ""), BracketFiles[4].Replace(".txt", ""));
            loadText(bracketTeam6, FolderList[9].Replace("\\", ""), BracketFiles[5].Replace(".txt", ""));
            loadText(bracketTeam7, FolderList[9].Replace("\\", ""), BracketFiles[6].Replace(".txt", ""));
            loadText(bracketTeam8, FolderList[9].Replace("\\", ""), BracketFiles[7].Replace(".txt", ""));
            loadText(bracketTeam9, FolderList[9].Replace("\\", ""), BracketFiles[8].Replace(".txt", ""));
            loadText(bracketTeam10, FolderList[9].Replace("\\", ""), BracketFiles[9].Replace(".txt", ""));
            loadText(bracketTeam11, FolderList[9].Replace("\\", ""), BracketFiles[10].Replace(".txt", ""));
            loadText(bracketTeam12, FolderList[9].Replace("\\", ""), BracketFiles[11].Replace(".txt", ""));
            loadText(bracketTeam13, FolderList[9].Replace("\\", ""), BracketFiles[12].Replace(".txt", ""));
            loadText(bracketTeam14, FolderList[9].Replace("\\", ""), BracketFiles[13].Replace(".txt", ""));
            loadText(bracketTeam15, FolderList[9].Replace("\\", ""), BracketFiles[14].Replace(".txt", ""));
            loadText(bracketTeam16, FolderList[9].Replace("\\", ""), BracketFiles[15].Replace(".txt", ""));

            loadButton(bracketImage1, FolderList[9].Replace("\\", ""), BracketFiles[16].Replace(".png", ""));
            loadButton(bracketImage2, FolderList[9].Replace("\\", ""), BracketFiles[17].Replace(".png", ""));
            loadButton(bracketImage3, FolderList[9].Replace("\\", ""), BracketFiles[18].Replace(".png", ""));
            loadButton(bracketImage4, FolderList[9].Replace("\\", ""), BracketFiles[19].Replace(".png", ""));
            loadButton(bracketImage5, FolderList[9].Replace("\\", ""), BracketFiles[20].Replace(".png", ""));
            loadButton(bracketImage6, FolderList[9].Replace("\\", ""), BracketFiles[21].Replace(".png", ""));
            loadButton(bracketImage7, FolderList[9].Replace("\\", ""), BracketFiles[22].Replace(".png", ""));
            loadButton(bracketImage8, FolderList[9].Replace("\\", ""), BracketFiles[23].Replace(".png", ""));
            loadButton(bracketImage9, FolderList[9].Replace("\\", ""), BracketFiles[24].Replace(".png", ""));
            loadButton(bracketImage10, FolderList[9].Replace("\\", ""), BracketFiles[25].Replace(".png", ""));
            loadButton(bracketImage11, FolderList[9].Replace("\\", ""), BracketFiles[26].Replace(".png", ""));
            loadButton(bracketImage12, FolderList[9].Replace("\\", ""), BracketFiles[27].Replace(".png", ""));
            loadButton(bracketImage13, FolderList[9].Replace("\\", ""), BracketFiles[28].Replace(".png", ""));
            loadButton(bracketImage14, FolderList[9].Replace("\\", ""), BracketFiles[29].Replace(".png", ""));
            loadButton(bracketImage15, FolderList[9].Replace("\\", ""), BracketFiles[30].Replace(".png", ""));
            loadButton(bracketImage16, FolderList[9].Replace("\\", ""), BracketFiles[31].Replace(".png", ""));

            loadCombo(bracketR1M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[32].Replace(".txt", ""));
            loadCombo(bracketR1M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[33].Replace(".txt", ""));
            loadCombo(bracketR1M2Team1, FolderList[9].Replace("\\", ""), BracketFiles[34].Replace(".txt", ""));
            loadCombo(bracketR1M2Team2, FolderList[9].Replace("\\", ""), BracketFiles[35].Replace(".txt", ""));
            loadCombo(bracketR1M3Team1, FolderList[9].Replace("\\", ""), BracketFiles[36].Replace(".txt", ""));
            loadCombo(bracketR1M3Team2, FolderList[9].Replace("\\", ""), BracketFiles[37].Replace(".txt", ""));
            loadCombo(bracketR1M4Team1, FolderList[9].Replace("\\", ""), BracketFiles[38].Replace(".txt", ""));
            loadCombo(bracketR1M4Team2, FolderList[9].Replace("\\", ""), BracketFiles[39].Replace(".txt", ""));
            loadCombo(bracketR1M5Team1, FolderList[9].Replace("\\", ""), BracketFiles[40].Replace(".txt", ""));
            loadCombo(bracketR1M5Team2, FolderList[9].Replace("\\", ""), BracketFiles[41].Replace(".txt", ""));
            loadCombo(bracketR1M6Team1, FolderList[9].Replace("\\", ""), BracketFiles[42].Replace(".txt", ""));
            loadCombo(bracketR1M6Team2, FolderList[9].Replace("\\", ""), BracketFiles[43].Replace(".txt", ""));
            loadCombo(bracketR1M7Team1, FolderList[9].Replace("\\", ""), BracketFiles[44].Replace(".txt", ""));
            loadCombo(bracketR1M7Team2, FolderList[9].Replace("\\", ""), BracketFiles[45].Replace(".txt", ""));
            loadCombo(bracketR1M8Team1, FolderList[9].Replace("\\", ""), BracketFiles[46].Replace(".txt", ""));
            loadCombo(bracketR1M8Team2, FolderList[9].Replace("\\", ""), BracketFiles[47].Replace(".txt", ""));
            loadCombo(bracketQFM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[48].Replace(".txt", ""));
            loadCombo(bracketQFM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[49].Replace(".txt", ""));
            loadCombo(bracketQFM2Team1, FolderList[9].Replace("\\", ""), BracketFiles[50].Replace(".txt", ""));
            loadCombo(bracketQFM2Team2, FolderList[9].Replace("\\", ""), BracketFiles[51].Replace(".txt", ""));
            loadCombo(bracketQFM3Team1, FolderList[9].Replace("\\", ""), BracketFiles[52].Replace(".txt", ""));
            loadCombo(bracketQFM3Team2, FolderList[9].Replace("\\", ""), BracketFiles[53].Replace(".txt", ""));
            loadCombo(bracketQFM4Team1, FolderList[9].Replace("\\", ""), BracketFiles[54].Replace(".txt", ""));
            loadCombo(bracketQFM4Team2, FolderList[9].Replace("\\", ""), BracketFiles[55].Replace(".txt", ""));
            loadCombo(bracketSFM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[56].Replace(".txt", ""));
            loadCombo(bracketSFM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[57].Replace(".txt", ""));
            loadCombo(bracketSFM2Team1, FolderList[9].Replace("\\", ""), BracketFiles[58].Replace(".txt", ""));
            loadCombo(bracketSFM2Team2, FolderList[9].Replace("\\", ""), BracketFiles[59].Replace(".txt", ""));
            loadCombo(bracketWFM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[60].Replace(".txt", ""));
            loadCombo(bracketWFM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[61].Replace(".txt", ""));
            loadCombo(bracketLR1M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[62].Replace(".txt", ""));
            loadCombo(bracketLR1M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[63].Replace(".txt", ""));
            loadCombo(bracketLR1M2Team1, FolderList[9].Replace("\\", ""), BracketFiles[64].Replace(".txt", ""));
            loadCombo(bracketLR1M2Team2, FolderList[9].Replace("\\", ""), BracketFiles[65].Replace(".txt", ""));
            loadCombo(bracketLR1M3Team1, FolderList[9].Replace("\\", ""), BracketFiles[66].Replace(".txt", ""));
            loadCombo(bracketLR1M3Team2, FolderList[9].Replace("\\", ""), BracketFiles[67].Replace(".txt", ""));
            loadCombo(bracketLR1M4Team1, FolderList[9].Replace("\\", ""), BracketFiles[68].Replace(".txt", ""));
            loadCombo(bracketLR1M4Team2, FolderList[9].Replace("\\", ""), BracketFiles[69].Replace(".txt", ""));
            loadCombo(bracketLR2M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[70].Replace(".txt", ""));
            loadCombo(bracketLR2M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[71].Replace(".txt", ""));
            loadCombo(bracketLR2M2Team1, FolderList[9].Replace("\\", ""), BracketFiles[72].Replace(".txt", ""));
            loadCombo(bracketLR2M2Team2, FolderList[9].Replace("\\", ""), BracketFiles[73].Replace(".txt", ""));
            loadCombo(bracketLR2M3Team1, FolderList[9].Replace("\\", ""), BracketFiles[74].Replace(".txt", ""));
            loadCombo(bracketLR2M3Team2, FolderList[9].Replace("\\", ""), BracketFiles[75].Replace(".txt", ""));
            loadCombo(bracketLR2M4Team1, FolderList[9].Replace("\\", ""), BracketFiles[76].Replace(".txt", ""));
            loadCombo(bracketLR2M4Team2, FolderList[9].Replace("\\", ""), BracketFiles[77].Replace(".txt", ""));
            loadCombo(bracketLR3M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[78].Replace(".txt", ""));
            loadCombo(bracketLR3M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[79].Replace(".txt", ""));
            loadCombo(bracketLR3M2Team1, FolderList[9].Replace("\\", ""), BracketFiles[80].Replace(".txt", ""));
            loadCombo(bracketLR3M2Team2, FolderList[9].Replace("\\", ""), BracketFiles[81].Replace(".txt", ""));
            loadCombo(bracketLR4M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[82].Replace(".txt", ""));
            loadCombo(bracketLR4M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[83].Replace(".txt", ""));
            loadCombo(bracketLR4M2Team1, FolderList[9].Replace("\\", ""), BracketFiles[84].Replace(".txt", ""));
            loadCombo(bracketLR4M2Team2, FolderList[9].Replace("\\", ""), BracketFiles[85].Replace(".txt", ""));
            loadCombo(bracketLSFM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[86].Replace(".txt", ""));
            loadCombo(bracketLSFM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[87].Replace(".txt", ""));
            loadCombo(bracketLFM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[88].Replace(".txt", ""));
            loadCombo(bracketLFM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[89].Replace(".txt", ""));
            loadCombo(bracketGF1M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[90].Replace(".txt", ""));
            loadCombo(bracketGF1M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[91].Replace(".txt", ""));
            loadCombo(bracketGF2M1Team1, FolderList[9].Replace("\\", ""), BracketFiles[92].Replace(".txt", ""));
            loadCombo(bracketGF2M1Team2, FolderList[9].Replace("\\", ""), BracketFiles[93].Replace(".txt", ""));
            loadCombo(bracketTPM1Team1, FolderList[9].Replace("\\", ""), BracketFiles[94].Replace(".txt", ""));
            loadCombo(bracketTPM1Team2, FolderList[9].Replace("\\", ""), BracketFiles[95].Replace(".txt", ""));

            loadScore(bracketR1M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[96].Replace(".txt", ""));
            loadScore(bracketR1M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[97].Replace(".txt", ""));
            loadScore(bracketR1M2Score1, FolderList[9].Replace("\\", ""), BracketFiles[98].Replace(".txt", ""));
            loadScore(bracketR1M2Score2, FolderList[9].Replace("\\", ""), BracketFiles[99].Replace(".txt", ""));
            loadScore(bracketR1M3Score1, FolderList[9].Replace("\\", ""), BracketFiles[100].Replace(".txt", ""));
            loadScore(bracketR1M3Score2, FolderList[9].Replace("\\", ""), BracketFiles[101].Replace(".txt", ""));
            loadScore(bracketR1M4Score1, FolderList[9].Replace("\\", ""), BracketFiles[102].Replace(".txt", ""));
            loadScore(bracketR1M4Score2, FolderList[9].Replace("\\", ""), BracketFiles[103].Replace(".txt", ""));
            loadScore(bracketR1M5Score1, FolderList[9].Replace("\\", ""), BracketFiles[104].Replace(".txt", ""));
            loadScore(bracketR1M5Score2, FolderList[9].Replace("\\", ""), BracketFiles[105].Replace(".txt", ""));
            loadScore(bracketR1M6Score1, FolderList[9].Replace("\\", ""), BracketFiles[106].Replace(".txt", ""));
            loadScore(bracketR1M6Score2, FolderList[9].Replace("\\", ""), BracketFiles[107].Replace(".txt", ""));
            loadScore(bracketR1M7Score1, FolderList[9].Replace("\\", ""), BracketFiles[108].Replace(".txt", ""));
            loadScore(bracketR1M7Score2, FolderList[9].Replace("\\", ""), BracketFiles[109].Replace(".txt", ""));
            loadScore(bracketR1M8Score1, FolderList[9].Replace("\\", ""), BracketFiles[110].Replace(".txt", ""));
            loadScore(bracketR1M8Score2, FolderList[9].Replace("\\", ""), BracketFiles[111].Replace(".txt", ""));
            loadScore(bracketQFM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[112].Replace(".txt", ""));
            loadScore(bracketQFM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[113].Replace(".txt", ""));
            loadScore(bracketQFM2Score1, FolderList[9].Replace("\\", ""), BracketFiles[114].Replace(".txt", ""));
            loadScore(bracketQFM2Score2, FolderList[9].Replace("\\", ""), BracketFiles[115].Replace(".txt", ""));
            loadScore(bracketQFM3Score1, FolderList[9].Replace("\\", ""), BracketFiles[116].Replace(".txt", ""));
            loadScore(bracketQFM3Score2, FolderList[9].Replace("\\", ""), BracketFiles[117].Replace(".txt", ""));
            loadScore(bracketQFM4Score1, FolderList[9].Replace("\\", ""), BracketFiles[118].Replace(".txt", ""));
            loadScore(bracketQFM4Score2, FolderList[9].Replace("\\", ""), BracketFiles[119].Replace(".txt", ""));
            loadScore(bracketSFM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[120].Replace(".txt", ""));
            loadScore(bracketSFM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[121].Replace(".txt", ""));
            loadScore(bracketSFM2Score1, FolderList[9].Replace("\\", ""), BracketFiles[122].Replace(".txt", ""));
            loadScore(bracketSFM2Score2, FolderList[9].Replace("\\", ""), BracketFiles[123].Replace(".txt", ""));
            loadScore(bracketWFM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[124].Replace(".txt", ""));
            loadScore(bracketWFM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[125].Replace(".txt", ""));
            loadScore(bracketLR1M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[126].Replace(".txt", ""));
            loadScore(bracketLR1M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[127].Replace(".txt", ""));
            loadScore(bracketLR1M2Score1, FolderList[9].Replace("\\", ""), BracketFiles[128].Replace(".txt", ""));
            loadScore(bracketLR1M2Score2, FolderList[9].Replace("\\", ""), BracketFiles[129].Replace(".txt", ""));
            loadScore(bracketLR1M3Score1, FolderList[9].Replace("\\", ""), BracketFiles[130].Replace(".txt", ""));
            loadScore(bracketLR1M3Score2, FolderList[9].Replace("\\", ""), BracketFiles[131].Replace(".txt", ""));
            loadScore(bracketLR1M4Score1, FolderList[9].Replace("\\", ""), BracketFiles[132].Replace(".txt", ""));
            loadScore(bracketLR1M4Score2, FolderList[9].Replace("\\", ""), BracketFiles[133].Replace(".txt", ""));
            loadScore(bracketLR2M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[134].Replace(".txt", ""));
            loadScore(bracketLR2M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[135].Replace(".txt", ""));
            loadScore(bracketLR2M2Score1, FolderList[9].Replace("\\", ""), BracketFiles[136].Replace(".txt", ""));
            loadScore(bracketLR2M2Score2, FolderList[9].Replace("\\", ""), BracketFiles[137].Replace(".txt", ""));
            loadScore(bracketLR2M3Score1, FolderList[9].Replace("\\", ""), BracketFiles[138].Replace(".txt", ""));
            loadScore(bracketLR2M3Score2, FolderList[9].Replace("\\", ""), BracketFiles[139].Replace(".txt", ""));
            loadScore(bracketLR2M4Score1, FolderList[9].Replace("\\", ""), BracketFiles[140].Replace(".txt", ""));
            loadScore(bracketLR2M4Score2, FolderList[9].Replace("\\", ""), BracketFiles[141].Replace(".txt", ""));
            loadScore(bracketLR3M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[142].Replace(".txt", ""));
            loadScore(bracketLR3M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[143].Replace(".txt", ""));
            loadScore(bracketLR3M2Score1, FolderList[9].Replace("\\", ""), BracketFiles[144].Replace(".txt", ""));
            loadScore(bracketLR3M2Score2, FolderList[9].Replace("\\", ""), BracketFiles[145].Replace(".txt", ""));
            loadScore(bracketLR4M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[146].Replace(".txt", ""));
            loadScore(bracketLR4M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[147].Replace(".txt", ""));
            loadScore(bracketLR4M2Score1, FolderList[9].Replace("\\", ""), BracketFiles[148].Replace(".txt", ""));
            loadScore(bracketLR4M2Score2, FolderList[9].Replace("\\", ""), BracketFiles[149].Replace(".txt", ""));
            loadScore(bracketLSFM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[150].Replace(".txt", ""));
            loadScore(bracketLSFM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[151].Replace(".txt", ""));
            loadScore(bracketLFM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[152].Replace(".txt", ""));
            loadScore(bracketLFM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[153].Replace(".txt", ""));
            loadScore(bracketGF1M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[154].Replace(".txt", ""));
            loadScore(bracketGF1M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[155].Replace(".txt", ""));
            loadScore(bracketGF2M1Score1, FolderList[9].Replace("\\", ""), BracketFiles[156].Replace(".txt", ""));
            loadScore(bracketGF2M1Score2, FolderList[9].Replace("\\", ""), BracketFiles[157].Replace(".txt", ""));
            loadScore(bracketTPM1Score1, FolderList[9].Replace("\\", ""), BracketFiles[158].Replace(".txt", ""));
            loadScore(bracketTPM1Score2, FolderList[9].Replace("\\", ""), BracketFiles[159].Replace(".txt", ""));

            setBracketTeams();
        }

        private void updateCombo(ComboBox field, string folder, string file)
        {
            using (StreamWriter sw = File.CreateText(path + "\\" + folder + "\\" + file + ".txt"))
            {
                sw.WriteLine(((Team)field.SelectedItem).Name);
            }
        }

        private void preventMouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void ToolTipMouseHover(object sender, EventArgs e)
        {
            ButtonToolTip.SetToolTip(((Button)sender), ((Button)sender).AccessibleDescription);
        }


    }
}
