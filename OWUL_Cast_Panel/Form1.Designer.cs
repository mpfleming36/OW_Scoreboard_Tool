namespace OWUL_Cast_Panel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private object[] heroList = new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"};

        private object[] mapList = new object[] {
            "",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King's Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"};

        private object[] roleList = new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"};

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Match_1 = new System.Windows.Forms.TabPage();
            this.m1t2p6Role = new System.Windows.Forms.ComboBox();
            this.m1t2p5Role = new System.Windows.Forms.ComboBox();
            this.m1t2p4Role = new System.Windows.Forms.ComboBox();
            this.m1t2p3Role = new System.Windows.Forms.ComboBox();
            this.m1t2p2Role = new System.Windows.Forms.ComboBox();
            this.m1t2p1Role = new System.Windows.Forms.ComboBox();
            this.m1t1p6Role = new System.Windows.Forms.ComboBox();
            this.m1t1p5Role = new System.Windows.Forms.ComboBox();
            this.m1t1p4Role = new System.Windows.Forms.ComboBox();
            this.m1t1p3Role = new System.Windows.Forms.ComboBox();
            this.m1t1p2Role = new System.Windows.Forms.ComboBox();
            this.m1t1p1Role = new System.Windows.Forms.ComboBox();
            this.m1m5t2Score = new System.Windows.Forms.NumericUpDown();
            this.m1m5t1Score = new System.Windows.Forms.NumericUpDown();
            this.m1m4t2Score = new System.Windows.Forms.NumericUpDown();
            this.m1m4t1Score = new System.Windows.Forms.NumericUpDown();
            this.m1m3t2Score = new System.Windows.Forms.NumericUpDown();
            this.m1m3t1Score = new System.Windows.Forms.NumericUpDown();
            this.m1m2t2Score = new System.Windows.Forms.NumericUpDown();
            this.m1m2t1Score = new System.Windows.Forms.NumericUpDown();
            this.m1m1t2Score = new System.Windows.Forms.NumericUpDown();
            this.m1m1t1Score = new System.Windows.Forms.NumericUpDown();
            this.m1m5Map = new System.Windows.Forms.ComboBox();
            this.m1m4Map = new System.Windows.Forms.ComboBox();
            this.m1m3Map = new System.Windows.Forms.ComboBox();
            this.m1m2Map = new System.Windows.Forms.ComboBox();
            this.m1m1Map = new System.Windows.Forms.ComboBox();
            this.m1m3Label = new System.Windows.Forms.Label();
            this.m1m4Label = new System.Windows.Forms.Label();
            this.m1m5Label = new System.Windows.Forms.Label();
            this.m1m2Label = new System.Windows.Forms.Label();
            this.m1m1Label = new System.Windows.Forms.Label();
            this.m1t2Side = new System.Windows.Forms.GroupBox();
            this.m1t2Defend = new System.Windows.Forms.RadioButton();
            this.m1t2Attack = new System.Windows.Forms.RadioButton();
            this.m1t2Neutral = new System.Windows.Forms.RadioButton();
            this.m1t1Side = new System.Windows.Forms.GroupBox();
            this.m1t1Attack = new System.Windows.Forms.RadioButton();
            this.m1t1Defend = new System.Windows.Forms.RadioButton();
            this.m1t1Neutral = new System.Windows.Forms.RadioButton();
            this.m1DivisionLabel = new System.Windows.Forms.Label();
            this.m1DivisionNumber = new System.Windows.Forms.TextBox();
            this.m1MessageLabel = new System.Windows.Forms.Label();
            this.m1MessageBox = new System.Windows.Forms.TextBox();
            this.m1currentCheck = new System.Windows.Forms.CheckBox();
            this.m1UpdateButton = new System.Windows.Forms.Button();
            this.m1t2p6Hero = new System.Windows.Forms.ComboBox();
            this.m1t2p5Hero = new System.Windows.Forms.ComboBox();
            this.m1t2p4Hero = new System.Windows.Forms.ComboBox();
            this.m1t2p3Hero = new System.Windows.Forms.ComboBox();
            this.m1t2p2Hero = new System.Windows.Forms.ComboBox();
            this.m1t2p1Hero = new System.Windows.Forms.ComboBox();
            this.m1t1p6Hero = new System.Windows.Forms.ComboBox();
            this.m1t1p5Hero = new System.Windows.Forms.ComboBox();
            this.m1t1p4Hero = new System.Windows.Forms.ComboBox();
            this.m1t1p3Hero = new System.Windows.Forms.ComboBox();
            this.m1t1p2Hero = new System.Windows.Forms.ComboBox();
            this.m1t1p1Hero = new System.Windows.Forms.ComboBox();
            this.m1ResetButton = new System.Windows.Forms.Button();
            this.m1SwapButton = new System.Windows.Forms.Button();
            this.m1t2p6Name = new System.Windows.Forms.TextBox();
            this.m1t2p6Label = new System.Windows.Forms.Label();
            this.m1t2p5Name = new System.Windows.Forms.TextBox();
            this.m1t2p5Label = new System.Windows.Forms.Label();
            this.m1t2p4Name = new System.Windows.Forms.TextBox();
            this.m1t2p4Label = new System.Windows.Forms.Label();
            this.m1t2p3Name = new System.Windows.Forms.TextBox();
            this.m1t2p3Label = new System.Windows.Forms.Label();
            this.m1t2p2Name = new System.Windows.Forms.TextBox();
            this.m1t2p2Label = new System.Windows.Forms.Label();
            this.m1t2p1Name = new System.Windows.Forms.TextBox();
            this.m1t2p1Label = new System.Windows.Forms.Label();
            this.m1t1p6Name = new System.Windows.Forms.TextBox();
            this.m1t1p6Label = new System.Windows.Forms.Label();
            this.m1t1p5Name = new System.Windows.Forms.TextBox();
            this.m1t1p5Label = new System.Windows.Forms.Label();
            this.m1t1p4Name = new System.Windows.Forms.TextBox();
            this.m1t1p4Label = new System.Windows.Forms.Label();
            this.m1t1p3Name = new System.Windows.Forms.TextBox();
            this.m1t1p3Label = new System.Windows.Forms.Label();
            this.m1t1p2Name = new System.Windows.Forms.TextBox();
            this.m1t1p2Label = new System.Windows.Forms.Label();
            this.m1t1p1Name = new System.Windows.Forms.TextBox();
            this.m1t1p1Label = new System.Windows.Forms.Label();
            this.m1t2Score = new System.Windows.Forms.NumericUpDown();
            this.m1t1Score = new System.Windows.Forms.NumericUpDown();
            this.m1t2ScoreLabel = new System.Windows.Forms.Label();
            this.m1t1ScoreLabel = new System.Windows.Forms.Label();
            this.m1t2Name = new System.Windows.Forms.TextBox();
            this.m1t2Label = new System.Windows.Forms.Label();
            this.m1t1Name = new System.Windows.Forms.TextBox();
            this.m1t1Label = new System.Windows.Forms.Label();
            this.Match_2 = new System.Windows.Forms.TabPage();
            this.m2t2p6Role = new System.Windows.Forms.ComboBox();
            this.m2t2p5Role = new System.Windows.Forms.ComboBox();
            this.m2t2p4Role = new System.Windows.Forms.ComboBox();
            this.m2t2p3Role = new System.Windows.Forms.ComboBox();
            this.m2t2p2Role = new System.Windows.Forms.ComboBox();
            this.m2t2p1Role = new System.Windows.Forms.ComboBox();
            this.m2t1p6Role = new System.Windows.Forms.ComboBox();
            this.m2t1p5Role = new System.Windows.Forms.ComboBox();
            this.m2t1p4Role = new System.Windows.Forms.ComboBox();
            this.m2t1p3Role = new System.Windows.Forms.ComboBox();
            this.m2t1p2Role = new System.Windows.Forms.ComboBox();
            this.m2t1p1Role = new System.Windows.Forms.ComboBox();
            this.m2m5t2Score = new System.Windows.Forms.NumericUpDown();
            this.m2m5t1Score = new System.Windows.Forms.NumericUpDown();
            this.m2m4t2Score = new System.Windows.Forms.NumericUpDown();
            this.m2m4t1Score = new System.Windows.Forms.NumericUpDown();
            this.m2m3t2Score = new System.Windows.Forms.NumericUpDown();
            this.m2m3t1Score = new System.Windows.Forms.NumericUpDown();
            this.m2m2t2Score = new System.Windows.Forms.NumericUpDown();
            this.m2m2t1Score = new System.Windows.Forms.NumericUpDown();
            this.m2m1t2Score = new System.Windows.Forms.NumericUpDown();
            this.m2m1t1Score = new System.Windows.Forms.NumericUpDown();
            this.m2m5Map = new System.Windows.Forms.ComboBox();
            this.m2m4Map = new System.Windows.Forms.ComboBox();
            this.m2m3Map = new System.Windows.Forms.ComboBox();
            this.m2m2Map = new System.Windows.Forms.ComboBox();
            this.m2m1Map = new System.Windows.Forms.ComboBox();
            this.m2m3Label = new System.Windows.Forms.Label();
            this.m2m4Label = new System.Windows.Forms.Label();
            this.m2m5Label = new System.Windows.Forms.Label();
            this.m2m2Label = new System.Windows.Forms.Label();
            this.m2m1Label = new System.Windows.Forms.Label();
            this.m2t2Side = new System.Windows.Forms.GroupBox();
            this.m2t2Defend = new System.Windows.Forms.RadioButton();
            this.m2t2Attack = new System.Windows.Forms.RadioButton();
            this.m2t2Neutral = new System.Windows.Forms.RadioButton();
            this.m2t1Side = new System.Windows.Forms.GroupBox();
            this.m2t1Defend = new System.Windows.Forms.RadioButton();
            this.m2t1Attack = new System.Windows.Forms.RadioButton();
            this.m2t1Neutral = new System.Windows.Forms.RadioButton();
            this.m2DivisionLabel = new System.Windows.Forms.Label();
            this.m2DivisionNumber = new System.Windows.Forms.TextBox();
            this.m2MessageLabel = new System.Windows.Forms.Label();
            this.m2MessageBox = new System.Windows.Forms.TextBox();
            this.m2currentCheck = new System.Windows.Forms.CheckBox();
            this.m2UpdateButton = new System.Windows.Forms.Button();
            this.m2t2p6Hero = new System.Windows.Forms.ComboBox();
            this.m2t2p5Hero = new System.Windows.Forms.ComboBox();
            this.m2t2p4Hero = new System.Windows.Forms.ComboBox();
            this.m2t2p3Hero = new System.Windows.Forms.ComboBox();
            this.m2t2p2Hero = new System.Windows.Forms.ComboBox();
            this.m2t2p1Hero = new System.Windows.Forms.ComboBox();
            this.m2t1p6Hero = new System.Windows.Forms.ComboBox();
            this.m2t1p5Hero = new System.Windows.Forms.ComboBox();
            this.m2t1p4Hero = new System.Windows.Forms.ComboBox();
            this.m2t1p3Hero = new System.Windows.Forms.ComboBox();
            this.m2t1p2Hero = new System.Windows.Forms.ComboBox();
            this.m2t1p1Hero = new System.Windows.Forms.ComboBox();
            this.m2ResetButton = new System.Windows.Forms.Button();
            this.m2SwapButton = new System.Windows.Forms.Button();
            this.m2t2p6Name = new System.Windows.Forms.TextBox();
            this.m2t2p6Label = new System.Windows.Forms.Label();
            this.m2t2p5Name = new System.Windows.Forms.TextBox();
            this.m2t2p5Label = new System.Windows.Forms.Label();
            this.m2t2p4Name = new System.Windows.Forms.TextBox();
            this.m2t2p4Label = new System.Windows.Forms.Label();
            this.m2t2p3Name = new System.Windows.Forms.TextBox();
            this.m2t2p3Label = new System.Windows.Forms.Label();
            this.m2t2p2Name = new System.Windows.Forms.TextBox();
            this.m2t2p2Label = new System.Windows.Forms.Label();
            this.m2t2p1Name = new System.Windows.Forms.TextBox();
            this.m2t2p1Label = new System.Windows.Forms.Label();
            this.m2t1p6Name = new System.Windows.Forms.TextBox();
            this.m2t1p6Label = new System.Windows.Forms.Label();
            this.m2t1p5Name = new System.Windows.Forms.TextBox();
            this.m2t1p5Label = new System.Windows.Forms.Label();
            this.m2t1p4Name = new System.Windows.Forms.TextBox();
            this.m2t1p4Label = new System.Windows.Forms.Label();
            this.m2t1p3Name = new System.Windows.Forms.TextBox();
            this.m2t1p3Label = new System.Windows.Forms.Label();
            this.m2t1p2Name = new System.Windows.Forms.TextBox();
            this.m2t1p2Label = new System.Windows.Forms.Label();
            this.m2t1p1Name = new System.Windows.Forms.TextBox();
            this.m2t1p1Label = new System.Windows.Forms.Label();
            this.m2t2Score = new System.Windows.Forms.NumericUpDown();
            this.m2t1Score = new System.Windows.Forms.NumericUpDown();
            this.m2t2ScoreLabel = new System.Windows.Forms.Label();
            this.m2t1ScoreLabel = new System.Windows.Forms.Label();
            this.m2t2Name = new System.Windows.Forms.TextBox();
            this.m2t2Label = new System.Windows.Forms.Label();
            this.m2t1Name = new System.Windows.Forms.TextBox();
            this.m2t1Label = new System.Windows.Forms.Label();
            this.Match_3 = new System.Windows.Forms.TabPage();
            this.m3t2p6Role = new System.Windows.Forms.ComboBox();
            this.m3t2p5Role = new System.Windows.Forms.ComboBox();
            this.m3t2p4Role = new System.Windows.Forms.ComboBox();
            this.m3t2p3Role = new System.Windows.Forms.ComboBox();
            this.m3t2p2Role = new System.Windows.Forms.ComboBox();
            this.m3t2p1Role = new System.Windows.Forms.ComboBox();
            this.m3t1p6Role = new System.Windows.Forms.ComboBox();
            this.m3t1p5Role = new System.Windows.Forms.ComboBox();
            this.m3t1p4Role = new System.Windows.Forms.ComboBox();
            this.m3t1p3Role = new System.Windows.Forms.ComboBox();
            this.m3t1p2Role = new System.Windows.Forms.ComboBox();
            this.m3t1p1Role = new System.Windows.Forms.ComboBox();
            this.m3m5t2Score = new System.Windows.Forms.NumericUpDown();
            this.m3m5t1Score = new System.Windows.Forms.NumericUpDown();
            this.m3m4t2Score = new System.Windows.Forms.NumericUpDown();
            this.m3m4t1Score = new System.Windows.Forms.NumericUpDown();
            this.m3m3t2Score = new System.Windows.Forms.NumericUpDown();
            this.m3m3t1Score = new System.Windows.Forms.NumericUpDown();
            this.m3m2t2Score = new System.Windows.Forms.NumericUpDown();
            this.m3m2t1Score = new System.Windows.Forms.NumericUpDown();
            this.m3m1t2Score = new System.Windows.Forms.NumericUpDown();
            this.m3m1t1Score = new System.Windows.Forms.NumericUpDown();
            this.m3m5Map = new System.Windows.Forms.ComboBox();
            this.m3m4Map = new System.Windows.Forms.ComboBox();
            this.m3m3Map = new System.Windows.Forms.ComboBox();
            this.m3m2Map = new System.Windows.Forms.ComboBox();
            this.m3m1Map = new System.Windows.Forms.ComboBox();
            this.m3m3Label = new System.Windows.Forms.Label();
            this.m3m4Label = new System.Windows.Forms.Label();
            this.m3m5Label = new System.Windows.Forms.Label();
            this.m3m2Label = new System.Windows.Forms.Label();
            this.m3m1Label = new System.Windows.Forms.Label();
            this.m3t2Side = new System.Windows.Forms.GroupBox();
            this.m3t2Attack = new System.Windows.Forms.RadioButton();
            this.m3t2Defend = new System.Windows.Forms.RadioButton();
            this.m3t2Neutral = new System.Windows.Forms.RadioButton();
            this.m3t1Side = new System.Windows.Forms.GroupBox();
            this.m3t1Attack = new System.Windows.Forms.RadioButton();
            this.m3t1Defend = new System.Windows.Forms.RadioButton();
            this.m3t1Neutral = new System.Windows.Forms.RadioButton();
            this.m3DivisionLabel = new System.Windows.Forms.Label();
            this.m3DivisionNumber = new System.Windows.Forms.TextBox();
            this.m3MessageLabel = new System.Windows.Forms.Label();
            this.m3MessageBox = new System.Windows.Forms.TextBox();
            this.m3currentCheck = new System.Windows.Forms.CheckBox();
            this.m3UpdateButton = new System.Windows.Forms.Button();
            this.m3t2p6Hero = new System.Windows.Forms.ComboBox();
            this.m3t2p5Hero = new System.Windows.Forms.ComboBox();
            this.m3t2p4Hero = new System.Windows.Forms.ComboBox();
            this.m3t2p3Hero = new System.Windows.Forms.ComboBox();
            this.m3t2p2Hero = new System.Windows.Forms.ComboBox();
            this.m3t2p1Hero = new System.Windows.Forms.ComboBox();
            this.m3t1p6Hero = new System.Windows.Forms.ComboBox();
            this.m3t1p5Hero = new System.Windows.Forms.ComboBox();
            this.m3t1p4Hero = new System.Windows.Forms.ComboBox();
            this.m3t1p3Hero = new System.Windows.Forms.ComboBox();
            this.m3t1p2Hero = new System.Windows.Forms.ComboBox();
            this.m3t1p1Hero = new System.Windows.Forms.ComboBox();
            this.m3ResetButton = new System.Windows.Forms.Button();
            this.m3SwapButton = new System.Windows.Forms.Button();
            this.m3t2p6Name = new System.Windows.Forms.TextBox();
            this.m3t2p6Label = new System.Windows.Forms.Label();
            this.m3t2p5Name = new System.Windows.Forms.TextBox();
            this.m3t2p5Label = new System.Windows.Forms.Label();
            this.m3t2p4Name = new System.Windows.Forms.TextBox();
            this.m3t2p4Label = new System.Windows.Forms.Label();
            this.m3t2p3Name = new System.Windows.Forms.TextBox();
            this.m3t2p3Label = new System.Windows.Forms.Label();
            this.m3t2p2Name = new System.Windows.Forms.TextBox();
            this.m3t2p2Label = new System.Windows.Forms.Label();
            this.m3t2p1Name = new System.Windows.Forms.TextBox();
            this.m3t2p1Label = new System.Windows.Forms.Label();
            this.m3t1p6Name = new System.Windows.Forms.TextBox();
            this.m3t1p6Label = new System.Windows.Forms.Label();
            this.m3t1p5Name = new System.Windows.Forms.TextBox();
            this.m3t1p5Label = new System.Windows.Forms.Label();
            this.m3t1p4Name = new System.Windows.Forms.TextBox();
            this.m3t1p4Label = new System.Windows.Forms.Label();
            this.m3t1p3Name = new System.Windows.Forms.TextBox();
            this.m3t1p3Label = new System.Windows.Forms.Label();
            this.m3t1p2Name = new System.Windows.Forms.TextBox();
            this.m3t1p2Label = new System.Windows.Forms.Label();
            this.m3t1p1Name = new System.Windows.Forms.TextBox();
            this.m3t1p1Label = new System.Windows.Forms.Label();
            this.m3t2Score = new System.Windows.Forms.NumericUpDown();
            this.m3t1Score = new System.Windows.Forms.NumericUpDown();
            this.m3t2ScoreLabel = new System.Windows.Forms.Label();
            this.m3t1ScoreLabel = new System.Windows.Forms.Label();
            this.m3t2Name = new System.Windows.Forms.TextBox();
            this.m3t2Label = new System.Windows.Forms.Label();
            this.m3t1Name = new System.Windows.Forms.TextBox();
            this.m3t1Label = new System.Windows.Forms.Label();
            this.General_Info = new System.Windows.Forms.TabPage();
            this.m1t1SR = new System.Windows.Forms.TextBox();
            this.m1t2SR = new System.Windows.Forms.TextBox();
            this.m2t2SR = new System.Windows.Forms.TextBox();
            this.m2t1SR = new System.Windows.Forms.TextBox();
            this.m3t2SR = new System.Windows.Forms.TextBox();
            this.m3t1SR = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Match_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m1m5t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m5t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m4t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m4t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m3t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m3t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m2t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m2t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m1t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m1t1Score)).BeginInit();
            this.m1t2Side.SuspendLayout();
            this.m1t1Side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m1t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1t1Score)).BeginInit();
            this.Match_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m2m5t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m5t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m4t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m4t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m3t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m3t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m2t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m2t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m1t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m1t1Score)).BeginInit();
            this.m2t2Side.SuspendLayout();
            this.m2t1Side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m2t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2t1Score)).BeginInit();
            this.Match_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m3m5t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m5t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m4t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m4t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m3t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m3t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m2t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m2t1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m1t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m1t1Score)).BeginInit();
            this.m3t2Side.SuspendLayout();
            this.m3t1Side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m3t2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3t1Score)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Match_1);
            this.tabControl1.Controls.Add(this.Match_2);
            this.tabControl1.Controls.Add(this.Match_3);
            this.tabControl1.Controls.Add(this.General_Info);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 440);
            this.tabControl1.TabIndex = 0;
            // 
            // Match_1
            // 
            this.Match_1.Controls.Add(this.m1t2SR);
            this.Match_1.Controls.Add(this.m1t1SR);
            this.Match_1.Controls.Add(this.m1t2p6Role);
            this.Match_1.Controls.Add(this.m1t2p5Role);
            this.Match_1.Controls.Add(this.m1t2p4Role);
            this.Match_1.Controls.Add(this.m1t2p3Role);
            this.Match_1.Controls.Add(this.m1t2p2Role);
            this.Match_1.Controls.Add(this.m1t2p1Role);
            this.Match_1.Controls.Add(this.m1t1p6Role);
            this.Match_1.Controls.Add(this.m1t1p5Role);
            this.Match_1.Controls.Add(this.m1t1p4Role);
            this.Match_1.Controls.Add(this.m1t1p3Role);
            this.Match_1.Controls.Add(this.m1t1p2Role);
            this.Match_1.Controls.Add(this.m1t1p1Role);
            this.Match_1.Controls.Add(this.m1m5t2Score);
            this.Match_1.Controls.Add(this.m1m5t1Score);
            this.Match_1.Controls.Add(this.m1m4t2Score);
            this.Match_1.Controls.Add(this.m1m4t1Score);
            this.Match_1.Controls.Add(this.m1m3t2Score);
            this.Match_1.Controls.Add(this.m1m3t1Score);
            this.Match_1.Controls.Add(this.m1m2t2Score);
            this.Match_1.Controls.Add(this.m1m2t1Score);
            this.Match_1.Controls.Add(this.m1m1t2Score);
            this.Match_1.Controls.Add(this.m1m1t1Score);
            this.Match_1.Controls.Add(this.m1m5Map);
            this.Match_1.Controls.Add(this.m1m4Map);
            this.Match_1.Controls.Add(this.m1m3Map);
            this.Match_1.Controls.Add(this.m1m2Map);
            this.Match_1.Controls.Add(this.m1m1Map);
            this.Match_1.Controls.Add(this.m1m3Label);
            this.Match_1.Controls.Add(this.m1m4Label);
            this.Match_1.Controls.Add(this.m1m5Label);
            this.Match_1.Controls.Add(this.m1m2Label);
            this.Match_1.Controls.Add(this.m1m1Label);
            this.Match_1.Controls.Add(this.m1t2Side);
            this.Match_1.Controls.Add(this.m1t1Side);
            this.Match_1.Controls.Add(this.m1DivisionLabel);
            this.Match_1.Controls.Add(this.m1DivisionNumber);
            this.Match_1.Controls.Add(this.m1MessageLabel);
            this.Match_1.Controls.Add(this.m1MessageBox);
            this.Match_1.Controls.Add(this.m1currentCheck);
            this.Match_1.Controls.Add(this.m1UpdateButton);
            this.Match_1.Controls.Add(this.m1t2p6Hero);
            this.Match_1.Controls.Add(this.m1t2p5Hero);
            this.Match_1.Controls.Add(this.m1t2p4Hero);
            this.Match_1.Controls.Add(this.m1t2p3Hero);
            this.Match_1.Controls.Add(this.m1t2p2Hero);
            this.Match_1.Controls.Add(this.m1t2p1Hero);
            this.Match_1.Controls.Add(this.m1t1p6Hero);
            this.Match_1.Controls.Add(this.m1t1p5Hero);
            this.Match_1.Controls.Add(this.m1t1p4Hero);
            this.Match_1.Controls.Add(this.m1t1p3Hero);
            this.Match_1.Controls.Add(this.m1t1p2Hero);
            this.Match_1.Controls.Add(this.m1t1p1Hero);
            this.Match_1.Controls.Add(this.m1ResetButton);
            this.Match_1.Controls.Add(this.m1SwapButton);
            this.Match_1.Controls.Add(this.m1t2p6Name);
            this.Match_1.Controls.Add(this.m1t2p6Label);
            this.Match_1.Controls.Add(this.m1t2p5Name);
            this.Match_1.Controls.Add(this.m1t2p5Label);
            this.Match_1.Controls.Add(this.m1t2p4Name);
            this.Match_1.Controls.Add(this.m1t2p4Label);
            this.Match_1.Controls.Add(this.m1t2p3Name);
            this.Match_1.Controls.Add(this.m1t2p3Label);
            this.Match_1.Controls.Add(this.m1t2p2Name);
            this.Match_1.Controls.Add(this.m1t2p2Label);
            this.Match_1.Controls.Add(this.m1t2p1Name);
            this.Match_1.Controls.Add(this.m1t2p1Label);
            this.Match_1.Controls.Add(this.m1t1p6Name);
            this.Match_1.Controls.Add(this.m1t1p6Label);
            this.Match_1.Controls.Add(this.m1t1p5Name);
            this.Match_1.Controls.Add(this.m1t1p5Label);
            this.Match_1.Controls.Add(this.m1t1p4Name);
            this.Match_1.Controls.Add(this.m1t1p4Label);
            this.Match_1.Controls.Add(this.m1t1p3Name);
            this.Match_1.Controls.Add(this.m1t1p3Label);
            this.Match_1.Controls.Add(this.m1t1p2Name);
            this.Match_1.Controls.Add(this.m1t1p2Label);
            this.Match_1.Controls.Add(this.m1t1p1Name);
            this.Match_1.Controls.Add(this.m1t1p1Label);
            this.Match_1.Controls.Add(this.m1t2Score);
            this.Match_1.Controls.Add(this.m1t1Score);
            this.Match_1.Controls.Add(this.m1t2ScoreLabel);
            this.Match_1.Controls.Add(this.m1t1ScoreLabel);
            this.Match_1.Controls.Add(this.m1t2Name);
            this.Match_1.Controls.Add(this.m1t2Label);
            this.Match_1.Controls.Add(this.m1t1Name);
            this.Match_1.Controls.Add(this.m1t1Label);
            this.Match_1.Location = new System.Drawing.Point(4, 22);
            this.Match_1.Name = "Match_1";
            this.Match_1.Padding = new System.Windows.Forms.Padding(3);
            this.Match_1.Size = new System.Drawing.Size(659, 414);
            this.Match_1.TabIndex = 0;
            this.Match_1.Text = "Match 1";
            this.Match_1.UseVisualStyleBackColor = true;
            // 
            // m1t2p6Role
            // 
            this.m1t2p6Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p6Role.FormattingEnabled = true;
            this.m1t2p6Role.Location = new System.Drawing.Point(337, 315);
            this.m1t2p6Role.Name = "m1t2p6Role";
            this.m1t2p6Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m1t2p6Role.Size = new System.Drawing.Size(82, 21);
            this.m1t2p6Role.TabIndex = 131;
            this.m1t2p6Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1t2p5Role
            // 
            this.m1t2p5Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p5Role.FormattingEnabled = true;
            this.m1t2p5Role.Location = new System.Drawing.Point(337, 275);
            this.m1t2p5Role.Name = "m1t2p5Role";
            this.m1t2p5Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m1t2p5Role.Size = new System.Drawing.Size(82, 21);
            this.m1t2p5Role.TabIndex = 130;
            this.m1t2p5Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1t2p4Role
            // 
            this.m1t2p4Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p4Role.FormattingEnabled = true;
            this.m1t2p4Role.Location = new System.Drawing.Point(337, 236);
            this.m1t2p4Role.Name = "m1t2p4Role";
            this.m1t2p4Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m1t2p4Role.Size = new System.Drawing.Size(82, 21);
            this.m1t2p4Role.TabIndex = 129;
            this.m1t2p4Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1t2p3Role
            // 
            this.m1t2p3Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p3Role.FormattingEnabled = true;
            this.m1t2p3Role.Location = new System.Drawing.Point(337, 198);
            this.m1t2p3Role.Name = "m1t2p3Role";
            this.m1t2p3Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m1t2p3Role.Size = new System.Drawing.Size(82, 21);
            this.m1t2p3Role.TabIndex = 128;
            this.m1t2p3Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1t2p2Role
            // 
            this.m1t2p2Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p2Role.FormattingEnabled = true;
            this.m1t2p2Role.Location = new System.Drawing.Point(337, 158);
            this.m1t2p2Role.Name = "m1t2p2Role";
            this.m1t2p2Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m1t2p2Role.Size = new System.Drawing.Size(82, 21);
            this.m1t2p2Role.TabIndex = 127;
            this.m1t2p2Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1t2p1Role
            // 
            this.m1t2p1Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p1Role.FormattingEnabled = true;
            this.m1t2p1Role.Location = new System.Drawing.Point(337, 119);
            this.m1t2p1Role.Name = "m1t2p1Role";
            this.m1t2p1Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m1t2p1Role.Size = new System.Drawing.Size(82, 21);
            this.m1t2p1Role.TabIndex = 126;
            this.m1t2p1Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1t1p6Role
            // 
            this.m1t1p6Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p6Role.FormattingEnabled = true;
            this.m1t1p6Role.Location = new System.Drawing.Point(240, 314);
            this.m1t1p6Role.Name = "m1t1p6Role";
            this.m1t1p6Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t1p6Role.Size = new System.Drawing.Size(82, 21);
            this.m1t1p6Role.TabIndex = 125;
            this.m1t1p6Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1t1p5Role
            // 
            this.m1t1p5Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p5Role.FormattingEnabled = true;
            this.m1t1p5Role.Location = new System.Drawing.Point(240, 275);
            this.m1t1p5Role.Name = "m1t1p5Role";
            this.m1t1p5Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t1p5Role.Size = new System.Drawing.Size(82, 21);
            this.m1t1p5Role.TabIndex = 124;
            this.m1t1p5Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1t1p4Role
            // 
            this.m1t1p4Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p4Role.FormattingEnabled = true;
            this.m1t1p4Role.Location = new System.Drawing.Point(240, 236);
            this.m1t1p4Role.Name = "m1t1p4Role";
            this.m1t1p4Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t1p4Role.Size = new System.Drawing.Size(82, 21);
            this.m1t1p4Role.TabIndex = 123;
            this.m1t1p4Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1t1p3Role
            // 
            this.m1t1p3Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p3Role.FormattingEnabled = true;
            this.m1t1p3Role.Location = new System.Drawing.Point(240, 197);
            this.m1t1p3Role.Name = "m1t1p3Role";
            this.m1t1p3Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t1p3Role.Size = new System.Drawing.Size(82, 21);
            this.m1t1p3Role.TabIndex = 122;
            this.m1t1p3Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1t1p2Role
            // 
            this.m1t1p2Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p2Role.FormattingEnabled = true;
            this.m1t1p2Role.Location = new System.Drawing.Point(240, 158);
            this.m1t1p2Role.Name = "m1t1p2Role";
            this.m1t1p2Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t1p2Role.Size = new System.Drawing.Size(82, 21);
            this.m1t1p2Role.TabIndex = 121;
            this.m1t1p2Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1t1p1Role
            // 
            this.m1t1p1Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p1Role.FormattingEnabled = true;
            this.m1t1p1Role.Location = new System.Drawing.Point(240, 119);
            this.m1t1p1Role.Name = "m1t1p1Role";
            this.m1t1p1Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t1p1Role.Size = new System.Drawing.Size(82, 21);
            this.m1t1p1Role.TabIndex = 120;
            this.m1t1p1Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m1m5t2Score
            // 
            this.m1m5t2Score.Location = new System.Drawing.Point(614, 381);
            this.m1m5t2Score.Name = "m1m5t2Score";
            this.m1m5t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1m5t2Score.Size = new System.Drawing.Size(36, 20);
            this.m1m5t2Score.TabIndex = 119;
            // 
            // m1m5t1Score
            // 
            this.m1m5t1Score.Location = new System.Drawing.Point(567, 381);
            this.m1m5t1Score.Name = "m1m5t1Score";
            this.m1m5t1Score.Size = new System.Drawing.Size(36, 20);
            this.m1m5t1Score.TabIndex = 118;
            // 
            // m1m4t2Score
            // 
            this.m1m4t2Score.Location = new System.Drawing.Point(471, 381);
            this.m1m4t2Score.Name = "m1m4t2Score";
            this.m1m4t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1m4t2Score.Size = new System.Drawing.Size(36, 20);
            this.m1m4t2Score.TabIndex = 117;
            // 
            // m1m4t1Score
            // 
            this.m1m4t1Score.Location = new System.Drawing.Point(424, 381);
            this.m1m4t1Score.Name = "m1m4t1Score";
            this.m1m4t1Score.Size = new System.Drawing.Size(36, 20);
            this.m1m4t1Score.TabIndex = 116;
            // 
            // m1m3t2Score
            // 
            this.m1m3t2Score.Location = new System.Drawing.Point(334, 381);
            this.m1m3t2Score.Name = "m1m3t2Score";
            this.m1m3t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1m3t2Score.Size = new System.Drawing.Size(36, 20);
            this.m1m3t2Score.TabIndex = 115;
            // 
            // m1m3t1Score
            // 
            this.m1m3t1Score.Location = new System.Drawing.Point(287, 381);
            this.m1m3t1Score.Name = "m1m3t1Score";
            this.m1m3t1Score.Size = new System.Drawing.Size(36, 20);
            this.m1m3t1Score.TabIndex = 114;
            // 
            // m1m2t2Score
            // 
            this.m1m2t2Score.Location = new System.Drawing.Point(196, 381);
            this.m1m2t2Score.Name = "m1m2t2Score";
            this.m1m2t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1m2t2Score.Size = new System.Drawing.Size(36, 20);
            this.m1m2t2Score.TabIndex = 113;
            // 
            // m1m2t1Score
            // 
            this.m1m2t1Score.Location = new System.Drawing.Point(149, 381);
            this.m1m2t1Score.Name = "m1m2t1Score";
            this.m1m2t1Score.Size = new System.Drawing.Size(36, 20);
            this.m1m2t1Score.TabIndex = 112;
            // 
            // m1m1t2Score
            // 
            this.m1m1t2Score.Location = new System.Drawing.Point(52, 381);
            this.m1m1t2Score.Name = "m1m1t2Score";
            this.m1m1t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1m1t2Score.Size = new System.Drawing.Size(36, 20);
            this.m1m1t2Score.TabIndex = 111;
            // 
            // m1m1t1Score
            // 
            this.m1m1t1Score.Location = new System.Drawing.Point(5, 381);
            this.m1m1t1Score.Name = "m1m1t1Score";
            this.m1m1t1Score.Size = new System.Drawing.Size(36, 20);
            this.m1m1t1Score.TabIndex = 110;
            // 
            // m1m5Map
            // 
            this.m1m5Map.FormattingEnabled = true;
            this.m1m5Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m1m5Map.Location = new System.Drawing.Point(567, 354);
            this.m1m5Map.Name = "m1m5Map";
            this.m1m5Map.Size = new System.Drawing.Size(83, 21);
            this.m1m5Map.TabIndex = 109;
            // 
            // m1m4Map
            // 
            this.m1m4Map.FormattingEnabled = true;
            this.m1m4Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m1m4Map.Location = new System.Drawing.Point(424, 354);
            this.m1m4Map.Name = "m1m4Map";
            this.m1m4Map.Size = new System.Drawing.Size(83, 21);
            this.m1m4Map.TabIndex = 108;
            // 
            // m1m3Map
            // 
            this.m1m3Map.FormattingEnabled = true;
            this.m1m3Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m1m3Map.Location = new System.Drawing.Point(287, 354);
            this.m1m3Map.Name = "m1m3Map";
            this.m1m3Map.Size = new System.Drawing.Size(83, 21);
            this.m1m3Map.TabIndex = 107;
            // 
            // m1m2Map
            // 
            this.m1m2Map.FormattingEnabled = true;
            this.m1m2Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m1m2Map.Location = new System.Drawing.Point(149, 354);
            this.m1m2Map.Name = "m1m2Map";
            this.m1m2Map.Size = new System.Drawing.Size(83, 21);
            this.m1m2Map.TabIndex = 106;
            // 
            // m1m1Map
            // 
            this.m1m1Map.FormattingEnabled = true;
            this.m1m1Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m1m1Map.Location = new System.Drawing.Point(5, 354);
            this.m1m1Map.Name = "m1m1Map";
            this.m1m1Map.Size = new System.Drawing.Size(83, 21);
            this.m1m1Map.TabIndex = 105;
            // 
            // m1m3Label
            // 
            this.m1m3Label.AutoSize = true;
            this.m1m3Label.Location = new System.Drawing.Point(309, 337);
            this.m1m3Label.Name = "m1m3Label";
            this.m1m3Label.Size = new System.Drawing.Size(37, 13);
            this.m1m3Label.TabIndex = 104;
            this.m1m3Label.Text = "Map 3";
            // 
            // m1m4Label
            // 
            this.m1m4Label.AutoSize = true;
            this.m1m4Label.Location = new System.Drawing.Point(455, 337);
            this.m1m4Label.Name = "m1m4Label";
            this.m1m4Label.Size = new System.Drawing.Size(37, 13);
            this.m1m4Label.TabIndex = 103;
            this.m1m4Label.Text = "Map 4";
            // 
            // m1m5Label
            // 
            this.m1m5Label.AutoSize = true;
            this.m1m5Label.Location = new System.Drawing.Point(608, 337);
            this.m1m5Label.Name = "m1m5Label";
            this.m1m5Label.Size = new System.Drawing.Size(37, 13);
            this.m1m5Label.TabIndex = 102;
            this.m1m5Label.Text = "Map 5";
            // 
            // m1m2Label
            // 
            this.m1m2Label.AutoSize = true;
            this.m1m2Label.Location = new System.Drawing.Point(167, 337);
            this.m1m2Label.Name = "m1m2Label";
            this.m1m2Label.Size = new System.Drawing.Size(37, 13);
            this.m1m2Label.TabIndex = 101;
            this.m1m2Label.Text = "Map 2";
            // 
            // m1m1Label
            // 
            this.m1m1Label.AutoSize = true;
            this.m1m1Label.Location = new System.Drawing.Point(14, 337);
            this.m1m1Label.Name = "m1m1Label";
            this.m1m1Label.Size = new System.Drawing.Size(37, 13);
            this.m1m1Label.TabIndex = 100;
            this.m1m1Label.Text = "Map 1";
            // 
            // m1t2Side
            // 
            this.m1t2Side.Controls.Add(this.m1t2Defend);
            this.m1t2Side.Controls.Add(this.m1t2Attack);
            this.m1t2Side.Controls.Add(this.m1t2Neutral);
            this.m1t2Side.Location = new System.Drawing.Point(449, 41);
            this.m1t2Side.Name = "m1t2Side";
            this.m1t2Side.Size = new System.Drawing.Size(120, 30);
            this.m1t2Side.TabIndex = 73;
            this.m1t2Side.TabStop = false;
            // 
            // m1t2Defend
            // 
            this.m1t2Defend.AutoSize = true;
            this.m1t2Defend.Location = new System.Drawing.Point(49, 9);
            this.m1t2Defend.Name = "m1t2Defend";
            this.m1t2Defend.Size = new System.Drawing.Size(33, 17);
            this.m1t2Defend.TabIndex = 70;
            this.m1t2Defend.Text = "D";
            this.m1t2Defend.UseVisualStyleBackColor = true;
            // 
            // m1t2Attack
            // 
            this.m1t2Attack.AutoSize = true;
            this.m1t2Attack.Location = new System.Drawing.Point(11, 9);
            this.m1t2Attack.Name = "m1t2Attack";
            this.m1t2Attack.Size = new System.Drawing.Size(32, 17);
            this.m1t2Attack.TabIndex = 69;
            this.m1t2Attack.Text = "A";
            this.m1t2Attack.UseVisualStyleBackColor = true;
            // 
            // m1t2Neutral
            // 
            this.m1t2Neutral.AutoSize = true;
            this.m1t2Neutral.Checked = true;
            this.m1t2Neutral.Location = new System.Drawing.Point(87, 9);
            this.m1t2Neutral.Name = "m1t2Neutral";
            this.m1t2Neutral.Size = new System.Drawing.Size(33, 17);
            this.m1t2Neutral.TabIndex = 71;
            this.m1t2Neutral.TabStop = true;
            this.m1t2Neutral.Text = "N";
            this.m1t2Neutral.UseVisualStyleBackColor = true;
            // 
            // m1t1Side
            // 
            this.m1t1Side.Controls.Add(this.m1t1Attack);
            this.m1t1Side.Controls.Add(this.m1t1Defend);
            this.m1t1Side.Controls.Add(this.m1t1Neutral);
            this.m1t1Side.Location = new System.Drawing.Point(90, 41);
            this.m1t1Side.Name = "m1t1Side";
            this.m1t1Side.Size = new System.Drawing.Size(120, 30);
            this.m1t1Side.TabIndex = 72;
            this.m1t1Side.TabStop = false;
            // 
            // m1t1Attack
            // 
            this.m1t1Attack.AutoSize = true;
            this.m1t1Attack.Location = new System.Drawing.Point(6, 9);
            this.m1t1Attack.Name = "m1t1Attack";
            this.m1t1Attack.Size = new System.Drawing.Size(32, 17);
            this.m1t1Attack.TabIndex = 66;
            this.m1t1Attack.Text = "A";
            this.m1t1Attack.UseVisualStyleBackColor = true;
            // 
            // m1t1Defend
            // 
            this.m1t1Defend.AutoSize = true;
            this.m1t1Defend.Location = new System.Drawing.Point(44, 9);
            this.m1t1Defend.Name = "m1t1Defend";
            this.m1t1Defend.Size = new System.Drawing.Size(33, 17);
            this.m1t1Defend.TabIndex = 67;
            this.m1t1Defend.Text = "D";
            this.m1t1Defend.UseVisualStyleBackColor = true;
            // 
            // m1t1Neutral
            // 
            this.m1t1Neutral.AutoSize = true;
            this.m1t1Neutral.Checked = true;
            this.m1t1Neutral.Location = new System.Drawing.Point(82, 9);
            this.m1t1Neutral.Name = "m1t1Neutral";
            this.m1t1Neutral.Size = new System.Drawing.Size(33, 17);
            this.m1t1Neutral.TabIndex = 68;
            this.m1t1Neutral.TabStop = true;
            this.m1t1Neutral.Text = "N";
            this.m1t1Neutral.UseVisualStyleBackColor = true;
            // 
            // m1DivisionLabel
            // 
            this.m1DivisionLabel.AutoSize = true;
            this.m1DivisionLabel.Location = new System.Drawing.Point(110, 79);
            this.m1DivisionLabel.Name = "m1DivisionLabel";
            this.m1DivisionLabel.Size = new System.Drawing.Size(44, 13);
            this.m1DivisionLabel.TabIndex = 65;
            this.m1DivisionLabel.Text = "Division";
            // 
            // m1DivisionNumber
            // 
            this.m1DivisionNumber.Location = new System.Drawing.Point(7, 76);
            this.m1DivisionNumber.Name = "m1DivisionNumber";
            this.m1DivisionNumber.Size = new System.Drawing.Size(100, 20);
            this.m1DivisionNumber.TabIndex = 64;
            // 
            // m1MessageLabel
            // 
            this.m1MessageLabel.AutoSize = true;
            this.m1MessageLabel.Location = new System.Drawing.Point(450, 78);
            this.m1MessageLabel.Name = "m1MessageLabel";
            this.m1MessageLabel.Size = new System.Drawing.Size(50, 13);
            this.m1MessageLabel.TabIndex = 63;
            this.m1MessageLabel.Text = "Message";
            // 
            // m1MessageBox
            // 
            this.m1MessageBox.Location = new System.Drawing.Point(506, 76);
            this.m1MessageBox.Name = "m1MessageBox";
            this.m1MessageBox.Size = new System.Drawing.Size(146, 20);
            this.m1MessageBox.TabIndex = 62;
            // 
            // m1currentCheck
            // 
            this.m1currentCheck.AutoSize = true;
            this.m1currentCheck.Location = new System.Drawing.Point(168, 78);
            this.m1currentCheck.Name = "m1currentCheck";
            this.m1currentCheck.Size = new System.Drawing.Size(60, 17);
            this.m1currentCheck.TabIndex = 61;
            this.m1currentCheck.Text = "Current";
            this.m1currentCheck.UseVisualStyleBackColor = true;
            // 
            // m1UpdateButton
            // 
            this.m1UpdateButton.Location = new System.Drawing.Point(292, 77);
            this.m1UpdateButton.Name = "m1UpdateButton";
            this.m1UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.m1UpdateButton.TabIndex = 57;
            this.m1UpdateButton.Text = "Update";
            this.m1UpdateButton.UseVisualStyleBackColor = true;
            this.m1UpdateButton.Click += new System.EventHandler(this.m1UpdateButton_Click);
            // 
            // m1t2p6Hero
            // 
            this.m1t2p6Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p6Hero.FormattingEnabled = true;
            this.m1t2p6Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t2p6Hero.Location = new System.Drawing.Point(426, 314);
            this.m1t2p6Hero.Name = "m1t2p6Hero";
            this.m1t2p6Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t2p6Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t2p6Hero.TabIndex = 54;
            // 
            // m1t2p5Hero
            // 
            this.m1t2p5Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p5Hero.FormattingEnabled = true;
            this.m1t2p5Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t2p5Hero.Location = new System.Drawing.Point(426, 275);
            this.m1t2p5Hero.Name = "m1t2p5Hero";
            this.m1t2p5Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t2p5Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t2p5Hero.TabIndex = 53;
            // 
            // m1t2p4Hero
            // 
            this.m1t2p4Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p4Hero.FormattingEnabled = true;
            this.m1t2p4Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t2p4Hero.Location = new System.Drawing.Point(426, 236);
            this.m1t2p4Hero.Name = "m1t2p4Hero";
            this.m1t2p4Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t2p4Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t2p4Hero.TabIndex = 52;
            // 
            // m1t2p3Hero
            // 
            this.m1t2p3Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p3Hero.FormattingEnabled = true;
            this.m1t2p3Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t2p3Hero.Location = new System.Drawing.Point(426, 197);
            this.m1t2p3Hero.Name = "m1t2p3Hero";
            this.m1t2p3Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t2p3Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t2p3Hero.TabIndex = 51;
            // 
            // m1t2p2Hero
            // 
            this.m1t2p2Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p2Hero.FormattingEnabled = true;
            this.m1t2p2Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t2p2Hero.Location = new System.Drawing.Point(426, 158);
            this.m1t2p2Hero.Name = "m1t2p2Hero";
            this.m1t2p2Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t2p2Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t2p2Hero.TabIndex = 50;
            // 
            // m1t2p1Hero
            // 
            this.m1t2p1Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t2p1Hero.FormattingEnabled = true;
            this.m1t2p1Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t2p1Hero.Location = new System.Drawing.Point(426, 119);
            this.m1t2p1Hero.Name = "m1t2p1Hero";
            this.m1t2p1Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t2p1Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t2p1Hero.TabIndex = 49;
            // 
            // m1t1p6Hero
            // 
            this.m1t1p6Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p6Hero.FormattingEnabled = true;
            this.m1t1p6Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t1p6Hero.Location = new System.Drawing.Point(113, 314);
            this.m1t1p6Hero.Name = "m1t1p6Hero";
            this.m1t1p6Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t1p6Hero.TabIndex = 46;
            // 
            // m1t1p5Hero
            // 
            this.m1t1p5Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p5Hero.FormattingEnabled = true;
            this.m1t1p5Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t1p5Hero.Location = new System.Drawing.Point(113, 275);
            this.m1t1p5Hero.Name = "m1t1p5Hero";
            this.m1t1p5Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t1p5Hero.TabIndex = 45;
            // 
            // m1t1p4Hero
            // 
            this.m1t1p4Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p4Hero.FormattingEnabled = true;
            this.m1t1p4Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t1p4Hero.Location = new System.Drawing.Point(113, 236);
            this.m1t1p4Hero.Name = "m1t1p4Hero";
            this.m1t1p4Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t1p4Hero.TabIndex = 44;
            // 
            // m1t1p3Hero
            // 
            this.m1t1p3Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p3Hero.FormattingEnabled = true;
            this.m1t1p3Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t1p3Hero.Location = new System.Drawing.Point(113, 197);
            this.m1t1p3Hero.Name = "m1t1p3Hero";
            this.m1t1p3Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t1p3Hero.TabIndex = 43;
            // 
            // m1t1p2Hero
            // 
            this.m1t1p2Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p2Hero.FormattingEnabled = true;
            this.m1t1p2Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t1p2Hero.Location = new System.Drawing.Point(113, 158);
            this.m1t1p2Hero.Name = "m1t1p2Hero";
            this.m1t1p2Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t1p2Hero.TabIndex = 42;
            // 
            // m1t1p1Hero
            // 
            this.m1t1p1Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m1t1p1Hero.FormattingEnabled = true;
            this.m1t1p1Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m1t1p1Hero.Location = new System.Drawing.Point(113, 119);
            this.m1t1p1Hero.Name = "m1t1p1Hero";
            this.m1t1p1Hero.Size = new System.Drawing.Size(121, 21);
            this.m1t1p1Hero.TabIndex = 41;
            // 
            // m1ResetButton
            // 
            this.m1ResetButton.Location = new System.Drawing.Point(292, 49);
            this.m1ResetButton.Name = "m1ResetButton";
            this.m1ResetButton.Size = new System.Drawing.Size(75, 23);
            this.m1ResetButton.TabIndex = 40;
            this.m1ResetButton.Text = "Reset";
            this.m1ResetButton.UseVisualStyleBackColor = true;
            this.m1ResetButton.Click += new System.EventHandler(this.m1ResetButton_Click);
            // 
            // m1SwapButton
            // 
            this.m1SwapButton.Location = new System.Drawing.Point(292, 21);
            this.m1SwapButton.Name = "m1SwapButton";
            this.m1SwapButton.Size = new System.Drawing.Size(75, 23);
            this.m1SwapButton.TabIndex = 39;
            this.m1SwapButton.Text = "Swap";
            this.m1SwapButton.UseVisualStyleBackColor = true;
            this.m1SwapButton.Click += new System.EventHandler(this.m1SwapButton_Click);
            // 
            // m1t2p6Name
            // 
            this.m1t2p6Name.Location = new System.Drawing.Point(552, 314);
            this.m1t2p6Name.Name = "m1t2p6Name";
            this.m1t2p6Name.Size = new System.Drawing.Size(100, 20);
            this.m1t2p6Name.TabIndex = 33;
            // 
            // m1t2p6Label
            // 
            this.m1t2p6Label.AutoSize = true;
            this.m1t2p6Label.Location = new System.Drawing.Point(608, 298);
            this.m1t2p6Label.Name = "m1t2p6Label";
            this.m1t2p6Label.Size = new System.Drawing.Size(45, 13);
            this.m1t2p6Label.TabIndex = 34;
            this.m1t2p6Label.Text = "Player 6";
            // 
            // m1t2p5Name
            // 
            this.m1t2p5Name.Location = new System.Drawing.Point(552, 275);
            this.m1t2p5Name.Name = "m1t2p5Name";
            this.m1t2p5Name.Size = new System.Drawing.Size(100, 20);
            this.m1t2p5Name.TabIndex = 31;
            // 
            // m1t2p5Label
            // 
            this.m1t2p5Label.AutoSize = true;
            this.m1t2p5Label.Location = new System.Drawing.Point(608, 259);
            this.m1t2p5Label.Name = "m1t2p5Label";
            this.m1t2p5Label.Size = new System.Drawing.Size(45, 13);
            this.m1t2p5Label.TabIndex = 32;
            this.m1t2p5Label.Text = "Player 5";
            // 
            // m1t2p4Name
            // 
            this.m1t2p4Name.Location = new System.Drawing.Point(553, 236);
            this.m1t2p4Name.Name = "m1t2p4Name";
            this.m1t2p4Name.Size = new System.Drawing.Size(100, 20);
            this.m1t2p4Name.TabIndex = 29;
            // 
            // m1t2p4Label
            // 
            this.m1t2p4Label.AutoSize = true;
            this.m1t2p4Label.Location = new System.Drawing.Point(608, 220);
            this.m1t2p4Label.Name = "m1t2p4Label";
            this.m1t2p4Label.Size = new System.Drawing.Size(45, 13);
            this.m1t2p4Label.TabIndex = 30;
            this.m1t2p4Label.Text = "Player 4";
            // 
            // m1t2p3Name
            // 
            this.m1t2p3Name.Location = new System.Drawing.Point(553, 197);
            this.m1t2p3Name.Name = "m1t2p3Name";
            this.m1t2p3Name.Size = new System.Drawing.Size(100, 20);
            this.m1t2p3Name.TabIndex = 27;
            // 
            // m1t2p3Label
            // 
            this.m1t2p3Label.AutoSize = true;
            this.m1t2p3Label.Location = new System.Drawing.Point(608, 181);
            this.m1t2p3Label.Name = "m1t2p3Label";
            this.m1t2p3Label.Size = new System.Drawing.Size(45, 13);
            this.m1t2p3Label.TabIndex = 28;
            this.m1t2p3Label.Text = "Player 3";
            // 
            // m1t2p2Name
            // 
            this.m1t2p2Name.Location = new System.Drawing.Point(553, 158);
            this.m1t2p2Name.Name = "m1t2p2Name";
            this.m1t2p2Name.Size = new System.Drawing.Size(100, 20);
            this.m1t2p2Name.TabIndex = 25;
            // 
            // m1t2p2Label
            // 
            this.m1t2p2Label.AutoSize = true;
            this.m1t2p2Label.Location = new System.Drawing.Point(608, 142);
            this.m1t2p2Label.Name = "m1t2p2Label";
            this.m1t2p2Label.Size = new System.Drawing.Size(45, 13);
            this.m1t2p2Label.TabIndex = 26;
            this.m1t2p2Label.Text = "Player 2";
            // 
            // m1t2p1Name
            // 
            this.m1t2p1Name.Location = new System.Drawing.Point(553, 119);
            this.m1t2p1Name.Name = "m1t2p1Name";
            this.m1t2p1Name.Size = new System.Drawing.Size(100, 20);
            this.m1t2p1Name.TabIndex = 23;
            // 
            // m1t2p1Label
            // 
            this.m1t2p1Label.AutoSize = true;
            this.m1t2p1Label.Location = new System.Drawing.Point(608, 103);
            this.m1t2p1Label.Name = "m1t2p1Label";
            this.m1t2p1Label.Size = new System.Drawing.Size(45, 13);
            this.m1t2p1Label.TabIndex = 24;
            this.m1t2p1Label.Text = "Player 1";
            // 
            // m1t1p6Name
            // 
            this.m1t1p6Name.Location = new System.Drawing.Point(6, 314);
            this.m1t1p6Name.Name = "m1t1p6Name";
            this.m1t1p6Name.Size = new System.Drawing.Size(100, 20);
            this.m1t1p6Name.TabIndex = 17;
            // 
            // m1t1p6Label
            // 
            this.m1t1p6Label.AutoSize = true;
            this.m1t1p6Label.Location = new System.Drawing.Point(6, 298);
            this.m1t1p6Label.Name = "m1t1p6Label";
            this.m1t1p6Label.Size = new System.Drawing.Size(45, 13);
            this.m1t1p6Label.TabIndex = 18;
            this.m1t1p6Label.Text = "Player 6";
            // 
            // m1t1p5Name
            // 
            this.m1t1p5Name.Location = new System.Drawing.Point(6, 275);
            this.m1t1p5Name.Name = "m1t1p5Name";
            this.m1t1p5Name.Size = new System.Drawing.Size(100, 20);
            this.m1t1p5Name.TabIndex = 15;
            // 
            // m1t1p5Label
            // 
            this.m1t1p5Label.AutoSize = true;
            this.m1t1p5Label.Location = new System.Drawing.Point(6, 259);
            this.m1t1p5Label.Name = "m1t1p5Label";
            this.m1t1p5Label.Size = new System.Drawing.Size(45, 13);
            this.m1t1p5Label.TabIndex = 16;
            this.m1t1p5Label.Text = "Player 5";
            // 
            // m1t1p4Name
            // 
            this.m1t1p4Name.Location = new System.Drawing.Point(7, 236);
            this.m1t1p4Name.Name = "m1t1p4Name";
            this.m1t1p4Name.Size = new System.Drawing.Size(100, 20);
            this.m1t1p4Name.TabIndex = 13;
            // 
            // m1t1p4Label
            // 
            this.m1t1p4Label.AutoSize = true;
            this.m1t1p4Label.Location = new System.Drawing.Point(7, 220);
            this.m1t1p4Label.Name = "m1t1p4Label";
            this.m1t1p4Label.Size = new System.Drawing.Size(45, 13);
            this.m1t1p4Label.TabIndex = 14;
            this.m1t1p4Label.Text = "Player 4";
            // 
            // m1t1p3Name
            // 
            this.m1t1p3Name.Location = new System.Drawing.Point(7, 197);
            this.m1t1p3Name.Name = "m1t1p3Name";
            this.m1t1p3Name.Size = new System.Drawing.Size(100, 20);
            this.m1t1p3Name.TabIndex = 11;
            // 
            // m1t1p3Label
            // 
            this.m1t1p3Label.AutoSize = true;
            this.m1t1p3Label.Location = new System.Drawing.Point(7, 181);
            this.m1t1p3Label.Name = "m1t1p3Label";
            this.m1t1p3Label.Size = new System.Drawing.Size(45, 13);
            this.m1t1p3Label.TabIndex = 12;
            this.m1t1p3Label.Text = "Player 3";
            // 
            // m1t1p2Name
            // 
            this.m1t1p2Name.Location = new System.Drawing.Point(7, 158);
            this.m1t1p2Name.Name = "m1t1p2Name";
            this.m1t1p2Name.Size = new System.Drawing.Size(100, 20);
            this.m1t1p2Name.TabIndex = 9;
            // 
            // m1t1p2Label
            // 
            this.m1t1p2Label.AutoSize = true;
            this.m1t1p2Label.Location = new System.Drawing.Point(7, 142);
            this.m1t1p2Label.Name = "m1t1p2Label";
            this.m1t1p2Label.Size = new System.Drawing.Size(45, 13);
            this.m1t1p2Label.TabIndex = 10;
            this.m1t1p2Label.Text = "Player 2";
            // 
            // m1t1p1Name
            // 
            this.m1t1p1Name.Location = new System.Drawing.Point(7, 119);
            this.m1t1p1Name.Name = "m1t1p1Name";
            this.m1t1p1Name.Size = new System.Drawing.Size(100, 20);
            this.m1t1p1Name.TabIndex = 7;
            // 
            // m1t1p1Label
            // 
            this.m1t1p1Label.AutoSize = true;
            this.m1t1p1Label.Location = new System.Drawing.Point(7, 103);
            this.m1t1p1Label.Name = "m1t1p1Label";
            this.m1t1p1Label.Size = new System.Drawing.Size(45, 13);
            this.m1t1p1Label.TabIndex = 8;
            this.m1t1p1Label.Text = "Player 1";
            // 
            // m1t2Score
            // 
            this.m1t2Score.Location = new System.Drawing.Point(575, 47);
            this.m1t2Score.Name = "m1t2Score";
            this.m1t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m1t2Score.Size = new System.Drawing.Size(36, 20);
            this.m1t2Score.TabIndex = 6;
            // 
            // m1t1Score
            // 
            this.m1t1Score.Location = new System.Drawing.Point(48, 47);
            this.m1t1Score.Name = "m1t1Score";
            this.m1t1Score.Size = new System.Drawing.Size(36, 20);
            this.m1t1Score.TabIndex = 5;
            // 
            // m1t2ScoreLabel
            // 
            this.m1t2ScoreLabel.AutoSize = true;
            this.m1t2ScoreLabel.Location = new System.Drawing.Point(617, 49);
            this.m1t2ScoreLabel.Name = "m1t2ScoreLabel";
            this.m1t2ScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.m1t2ScoreLabel.TabIndex = 4;
            this.m1t2ScoreLabel.Text = "Score";
            // 
            // m1t1ScoreLabel
            // 
            this.m1t1ScoreLabel.AutoSize = true;
            this.m1t1ScoreLabel.Location = new System.Drawing.Point(7, 49);
            this.m1t1ScoreLabel.Name = "m1t1ScoreLabel";
            this.m1t1ScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.m1t1ScoreLabel.TabIndex = 3;
            this.m1t1ScoreLabel.Text = "Score";
            // 
            // m1t2Name
            // 
            this.m1t2Name.Location = new System.Drawing.Point(474, 21);
            this.m1t2Name.Name = "m1t2Name";
            this.m1t2Name.Size = new System.Drawing.Size(178, 20);
            this.m1t2Name.TabIndex = 1;
            // 
            // m1t2Label
            // 
            this.m1t2Label.AutoSize = true;
            this.m1t2Label.Location = new System.Drawing.Point(610, 3);
            this.m1t2Label.Name = "m1t2Label";
            this.m1t2Label.Size = new System.Drawing.Size(43, 13);
            this.m1t2Label.TabIndex = 2;
            this.m1t2Label.Text = "Team 2";
            // 
            // m1t1Name
            // 
            this.m1t1Name.Location = new System.Drawing.Point(6, 21);
            this.m1t1Name.Name = "m1t1Name";
            this.m1t1Name.Size = new System.Drawing.Size(178, 20);
            this.m1t1Name.TabIndex = 0;
            // 
            // m1t1Label
            // 
            this.m1t1Label.AutoSize = true;
            this.m1t1Label.Location = new System.Drawing.Point(6, 5);
            this.m1t1Label.Name = "m1t1Label";
            this.m1t1Label.Size = new System.Drawing.Size(43, 13);
            this.m1t1Label.TabIndex = 0;
            this.m1t1Label.Text = "Team 1";
            // 
            // Match_2
            // 
            this.Match_2.Controls.Add(this.m2t2SR);
            this.Match_2.Controls.Add(this.m2t1SR);
            this.Match_2.Controls.Add(this.m2t2p6Role);
            this.Match_2.Controls.Add(this.m2t2p5Role);
            this.Match_2.Controls.Add(this.m2t2p4Role);
            this.Match_2.Controls.Add(this.m2t2p3Role);
            this.Match_2.Controls.Add(this.m2t2p2Role);
            this.Match_2.Controls.Add(this.m2t2p1Role);
            this.Match_2.Controls.Add(this.m2t1p6Role);
            this.Match_2.Controls.Add(this.m2t1p5Role);
            this.Match_2.Controls.Add(this.m2t1p4Role);
            this.Match_2.Controls.Add(this.m2t1p3Role);
            this.Match_2.Controls.Add(this.m2t1p2Role);
            this.Match_2.Controls.Add(this.m2t1p1Role);
            this.Match_2.Controls.Add(this.m2m5t2Score);
            this.Match_2.Controls.Add(this.m2m5t1Score);
            this.Match_2.Controls.Add(this.m2m4t2Score);
            this.Match_2.Controls.Add(this.m2m4t1Score);
            this.Match_2.Controls.Add(this.m2m3t2Score);
            this.Match_2.Controls.Add(this.m2m3t1Score);
            this.Match_2.Controls.Add(this.m2m2t2Score);
            this.Match_2.Controls.Add(this.m2m2t1Score);
            this.Match_2.Controls.Add(this.m2m1t2Score);
            this.Match_2.Controls.Add(this.m2m1t1Score);
            this.Match_2.Controls.Add(this.m2m5Map);
            this.Match_2.Controls.Add(this.m2m4Map);
            this.Match_2.Controls.Add(this.m2m3Map);
            this.Match_2.Controls.Add(this.m2m2Map);
            this.Match_2.Controls.Add(this.m2m1Map);
            this.Match_2.Controls.Add(this.m2m3Label);
            this.Match_2.Controls.Add(this.m2m4Label);
            this.Match_2.Controls.Add(this.m2m5Label);
            this.Match_2.Controls.Add(this.m2m2Label);
            this.Match_2.Controls.Add(this.m2m1Label);
            this.Match_2.Controls.Add(this.m2t2Side);
            this.Match_2.Controls.Add(this.m2t1Side);
            this.Match_2.Controls.Add(this.m2DivisionLabel);
            this.Match_2.Controls.Add(this.m2DivisionNumber);
            this.Match_2.Controls.Add(this.m2MessageLabel);
            this.Match_2.Controls.Add(this.m2MessageBox);
            this.Match_2.Controls.Add(this.m2currentCheck);
            this.Match_2.Controls.Add(this.m2UpdateButton);
            this.Match_2.Controls.Add(this.m2t2p6Hero);
            this.Match_2.Controls.Add(this.m2t2p5Hero);
            this.Match_2.Controls.Add(this.m2t2p4Hero);
            this.Match_2.Controls.Add(this.m2t2p3Hero);
            this.Match_2.Controls.Add(this.m2t2p2Hero);
            this.Match_2.Controls.Add(this.m2t2p1Hero);
            this.Match_2.Controls.Add(this.m2t1p6Hero);
            this.Match_2.Controls.Add(this.m2t1p5Hero);
            this.Match_2.Controls.Add(this.m2t1p4Hero);
            this.Match_2.Controls.Add(this.m2t1p3Hero);
            this.Match_2.Controls.Add(this.m2t1p2Hero);
            this.Match_2.Controls.Add(this.m2t1p1Hero);
            this.Match_2.Controls.Add(this.m2ResetButton);
            this.Match_2.Controls.Add(this.m2SwapButton);
            this.Match_2.Controls.Add(this.m2t2p6Name);
            this.Match_2.Controls.Add(this.m2t2p6Label);
            this.Match_2.Controls.Add(this.m2t2p5Name);
            this.Match_2.Controls.Add(this.m2t2p5Label);
            this.Match_2.Controls.Add(this.m2t2p4Name);
            this.Match_2.Controls.Add(this.m2t2p4Label);
            this.Match_2.Controls.Add(this.m2t2p3Name);
            this.Match_2.Controls.Add(this.m2t2p3Label);
            this.Match_2.Controls.Add(this.m2t2p2Name);
            this.Match_2.Controls.Add(this.m2t2p2Label);
            this.Match_2.Controls.Add(this.m2t2p1Name);
            this.Match_2.Controls.Add(this.m2t2p1Label);
            this.Match_2.Controls.Add(this.m2t1p6Name);
            this.Match_2.Controls.Add(this.m2t1p6Label);
            this.Match_2.Controls.Add(this.m2t1p5Name);
            this.Match_2.Controls.Add(this.m2t1p5Label);
            this.Match_2.Controls.Add(this.m2t1p4Name);
            this.Match_2.Controls.Add(this.m2t1p4Label);
            this.Match_2.Controls.Add(this.m2t1p3Name);
            this.Match_2.Controls.Add(this.m2t1p3Label);
            this.Match_2.Controls.Add(this.m2t1p2Name);
            this.Match_2.Controls.Add(this.m2t1p2Label);
            this.Match_2.Controls.Add(this.m2t1p1Name);
            this.Match_2.Controls.Add(this.m2t1p1Label);
            this.Match_2.Controls.Add(this.m2t2Score);
            this.Match_2.Controls.Add(this.m2t1Score);
            this.Match_2.Controls.Add(this.m2t2ScoreLabel);
            this.Match_2.Controls.Add(this.m2t1ScoreLabel);
            this.Match_2.Controls.Add(this.m2t2Name);
            this.Match_2.Controls.Add(this.m2t2Label);
            this.Match_2.Controls.Add(this.m2t1Name);
            this.Match_2.Controls.Add(this.m2t1Label);
            this.Match_2.Location = new System.Drawing.Point(4, 22);
            this.Match_2.Name = "Match_2";
            this.Match_2.Padding = new System.Windows.Forms.Padding(3);
            this.Match_2.Size = new System.Drawing.Size(659, 414);
            this.Match_2.TabIndex = 0;
            this.Match_2.Text = "Match 2";
            this.Match_2.UseVisualStyleBackColor = true;
            // 
            // m2t2p6Role
            // 
            this.m2t2p6Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p6Role.FormattingEnabled = true;
            this.m2t2p6Role.Location = new System.Drawing.Point(337, 315);
            this.m2t2p6Role.Name = "m2t2p6Role";
            this.m2t2p6Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m2t2p6Role.Size = new System.Drawing.Size(82, 21);
            this.m2t2p6Role.TabIndex = 143;
            this.m2t2p6Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2t2p5Role
            // 
            this.m2t2p5Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p5Role.FormattingEnabled = true;
            this.m2t2p5Role.Location = new System.Drawing.Point(337, 275);
            this.m2t2p5Role.Name = "m2t2p5Role";
            this.m2t2p5Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m2t2p5Role.Size = new System.Drawing.Size(82, 21);
            this.m2t2p5Role.TabIndex = 142;
            this.m2t2p5Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2t2p4Role
            // 
            this.m2t2p4Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p4Role.FormattingEnabled = true;
            this.m2t2p4Role.Location = new System.Drawing.Point(337, 236);
            this.m2t2p4Role.Name = "m2t2p4Role";
            this.m2t2p4Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m2t2p4Role.Size = new System.Drawing.Size(82, 21);
            this.m2t2p4Role.TabIndex = 141;
            this.m2t2p4Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2t2p3Role
            // 
            this.m2t2p3Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p3Role.FormattingEnabled = true;
            this.m2t2p3Role.Location = new System.Drawing.Point(337, 198);
            this.m2t2p3Role.Name = "m2t2p3Role";
            this.m2t2p3Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m2t2p3Role.Size = new System.Drawing.Size(82, 21);
            this.m2t2p3Role.TabIndex = 140;
            this.m2t2p3Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2t2p2Role
            // 
            this.m2t2p2Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p2Role.FormattingEnabled = true;
            this.m2t2p2Role.Location = new System.Drawing.Point(337, 158);
            this.m2t2p2Role.Name = "m2t2p2Role";
            this.m2t2p2Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m2t2p2Role.Size = new System.Drawing.Size(82, 21);
            this.m2t2p2Role.TabIndex = 139;
            this.m2t2p2Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2t2p1Role
            // 
            this.m2t2p1Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p1Role.FormattingEnabled = true;
            this.m2t2p1Role.Location = new System.Drawing.Point(337, 119);
            this.m2t2p1Role.Name = "m2t2p1Role";
            this.m2t2p1Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m2t2p1Role.Size = new System.Drawing.Size(82, 21);
            this.m2t2p1Role.TabIndex = 138;
            this.m2t2p1Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2t1p6Role
            // 
            this.m2t1p6Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p6Role.FormattingEnabled = true;
            this.m2t1p6Role.Location = new System.Drawing.Point(240, 314);
            this.m2t1p6Role.Name = "m2t1p6Role";
            this.m2t1p6Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t1p6Role.Size = new System.Drawing.Size(82, 21);
            this.m2t1p6Role.TabIndex = 137;
            this.m2t1p6Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2t1p5Role
            // 
            this.m2t1p5Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p5Role.FormattingEnabled = true;
            this.m2t1p5Role.Location = new System.Drawing.Point(240, 275);
            this.m2t1p5Role.Name = "m2t1p5Role";
            this.m2t1p5Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t1p5Role.Size = new System.Drawing.Size(82, 21);
            this.m2t1p5Role.TabIndex = 136;
            this.m2t1p5Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2t1p4Role
            // 
            this.m2t1p4Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p4Role.FormattingEnabled = true;
            this.m2t1p4Role.Location = new System.Drawing.Point(240, 236);
            this.m2t1p4Role.Name = "m2t1p4Role";
            this.m2t1p4Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t1p4Role.Size = new System.Drawing.Size(82, 21);
            this.m2t1p4Role.TabIndex = 135;
            this.m2t1p4Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2t1p3Role
            // 
            this.m2t1p3Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p3Role.FormattingEnabled = true;
            this.m2t1p3Role.Location = new System.Drawing.Point(240, 197);
            this.m2t1p3Role.Name = "m2t1p3Role";
            this.m2t1p3Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t1p3Role.Size = new System.Drawing.Size(82, 21);
            this.m2t1p3Role.TabIndex = 134;
            this.m2t1p3Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2t1p2Role
            // 
            this.m2t1p2Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p2Role.FormattingEnabled = true;
            this.m2t1p2Role.Location = new System.Drawing.Point(240, 158);
            this.m2t1p2Role.Name = "m2t1p2Role";
            this.m2t1p2Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t1p2Role.Size = new System.Drawing.Size(82, 21);
            this.m2t1p2Role.TabIndex = 133;
            this.m2t1p2Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2t1p1Role
            // 
            this.m2t1p1Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p1Role.FormattingEnabled = true;
            this.m2t1p1Role.Location = new System.Drawing.Point(240, 119);
            this.m2t1p1Role.Name = "m2t1p1Role";
            this.m2t1p1Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t1p1Role.Size = new System.Drawing.Size(82, 21);
            this.m2t1p1Role.TabIndex = 132;
            this.m2t1p1Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m2m5t2Score
            // 
            this.m2m5t2Score.Location = new System.Drawing.Point(614, 381);
            this.m2m5t2Score.Name = "m2m5t2Score";
            this.m2m5t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2m5t2Score.Size = new System.Drawing.Size(36, 20);
            this.m2m5t2Score.TabIndex = 99;
            // 
            // m2m5t1Score
            // 
            this.m2m5t1Score.Location = new System.Drawing.Point(567, 381);
            this.m2m5t1Score.Name = "m2m5t1Score";
            this.m2m5t1Score.Size = new System.Drawing.Size(36, 20);
            this.m2m5t1Score.TabIndex = 98;
            // 
            // m2m4t2Score
            // 
            this.m2m4t2Score.Location = new System.Drawing.Point(471, 381);
            this.m2m4t2Score.Name = "m2m4t2Score";
            this.m2m4t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2m4t2Score.Size = new System.Drawing.Size(36, 20);
            this.m2m4t2Score.TabIndex = 97;
            // 
            // m2m4t1Score
            // 
            this.m2m4t1Score.Location = new System.Drawing.Point(424, 381);
            this.m2m4t1Score.Name = "m2m4t1Score";
            this.m2m4t1Score.Size = new System.Drawing.Size(36, 20);
            this.m2m4t1Score.TabIndex = 96;
            // 
            // m2m3t2Score
            // 
            this.m2m3t2Score.Location = new System.Drawing.Point(334, 381);
            this.m2m3t2Score.Name = "m2m3t2Score";
            this.m2m3t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2m3t2Score.Size = new System.Drawing.Size(36, 20);
            this.m2m3t2Score.TabIndex = 95;
            // 
            // m2m3t1Score
            // 
            this.m2m3t1Score.Location = new System.Drawing.Point(287, 381);
            this.m2m3t1Score.Name = "m2m3t1Score";
            this.m2m3t1Score.Size = new System.Drawing.Size(36, 20);
            this.m2m3t1Score.TabIndex = 94;
            // 
            // m2m2t2Score
            // 
            this.m2m2t2Score.Location = new System.Drawing.Point(196, 381);
            this.m2m2t2Score.Name = "m2m2t2Score";
            this.m2m2t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2m2t2Score.Size = new System.Drawing.Size(36, 20);
            this.m2m2t2Score.TabIndex = 93;
            // 
            // m2m2t1Score
            // 
            this.m2m2t1Score.Location = new System.Drawing.Point(149, 381);
            this.m2m2t1Score.Name = "m2m2t1Score";
            this.m2m2t1Score.Size = new System.Drawing.Size(36, 20);
            this.m2m2t1Score.TabIndex = 92;
            // 
            // m2m1t2Score
            // 
            this.m2m1t2Score.Location = new System.Drawing.Point(52, 381);
            this.m2m1t2Score.Name = "m2m1t2Score";
            this.m2m1t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2m1t2Score.Size = new System.Drawing.Size(36, 20);
            this.m2m1t2Score.TabIndex = 91;
            // 
            // m2m1t1Score
            // 
            this.m2m1t1Score.Location = new System.Drawing.Point(5, 381);
            this.m2m1t1Score.Name = "m2m1t1Score";
            this.m2m1t1Score.Size = new System.Drawing.Size(36, 20);
            this.m2m1t1Score.TabIndex = 90;
            // 
            // m2m5Map
            // 
            this.m2m5Map.FormattingEnabled = true;
            this.m2m5Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m2m5Map.Location = new System.Drawing.Point(567, 354);
            this.m2m5Map.Name = "m2m5Map";
            this.m2m5Map.Size = new System.Drawing.Size(83, 21);
            this.m2m5Map.TabIndex = 89;
            // 
            // m2m4Map
            // 
            this.m2m4Map.FormattingEnabled = true;
            this.m2m4Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m2m4Map.Location = new System.Drawing.Point(424, 354);
            this.m2m4Map.Name = "m2m4Map";
            this.m2m4Map.Size = new System.Drawing.Size(83, 21);
            this.m2m4Map.TabIndex = 88;
            // 
            // m2m3Map
            // 
            this.m2m3Map.FormattingEnabled = true;
            this.m2m3Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m2m3Map.Location = new System.Drawing.Point(287, 354);
            this.m2m3Map.Name = "m2m3Map";
            this.m2m3Map.Size = new System.Drawing.Size(83, 21);
            this.m2m3Map.TabIndex = 87;
            // 
            // m2m2Map
            // 
            this.m2m2Map.FormattingEnabled = true;
            this.m2m2Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m2m2Map.Location = new System.Drawing.Point(149, 354);
            this.m2m2Map.Name = "m2m2Map";
            this.m2m2Map.Size = new System.Drawing.Size(83, 21);
            this.m2m2Map.TabIndex = 86;
            // 
            // m2m1Map
            // 
            this.m2m1Map.FormattingEnabled = true;
            this.m2m1Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m2m1Map.Location = new System.Drawing.Point(5, 354);
            this.m2m1Map.Name = "m2m1Map";
            this.m2m1Map.Size = new System.Drawing.Size(83, 21);
            this.m2m1Map.TabIndex = 85;
            // 
            // m2m3Label
            // 
            this.m2m3Label.AutoSize = true;
            this.m2m3Label.Location = new System.Drawing.Point(309, 337);
            this.m2m3Label.Name = "m2m3Label";
            this.m2m3Label.Size = new System.Drawing.Size(37, 13);
            this.m2m3Label.TabIndex = 84;
            this.m2m3Label.Text = "Map 3";
            // 
            // m2m4Label
            // 
            this.m2m4Label.AutoSize = true;
            this.m2m4Label.Location = new System.Drawing.Point(455, 337);
            this.m2m4Label.Name = "m2m4Label";
            this.m2m4Label.Size = new System.Drawing.Size(37, 13);
            this.m2m4Label.TabIndex = 83;
            this.m2m4Label.Text = "Map 4";
            // 
            // m2m5Label
            // 
            this.m2m5Label.AutoSize = true;
            this.m2m5Label.Location = new System.Drawing.Point(608, 337);
            this.m2m5Label.Name = "m2m5Label";
            this.m2m5Label.Size = new System.Drawing.Size(37, 13);
            this.m2m5Label.TabIndex = 82;
            this.m2m5Label.Text = "Map 5";
            // 
            // m2m2Label
            // 
            this.m2m2Label.AutoSize = true;
            this.m2m2Label.Location = new System.Drawing.Point(167, 337);
            this.m2m2Label.Name = "m2m2Label";
            this.m2m2Label.Size = new System.Drawing.Size(37, 13);
            this.m2m2Label.TabIndex = 81;
            this.m2m2Label.Text = "Map 2";
            // 
            // m2m1Label
            // 
            this.m2m1Label.AutoSize = true;
            this.m2m1Label.Location = new System.Drawing.Point(14, 337);
            this.m2m1Label.Name = "m2m1Label";
            this.m2m1Label.Size = new System.Drawing.Size(37, 13);
            this.m2m1Label.TabIndex = 80;
            this.m2m1Label.Text = "Map 1";
            // 
            // m2t2Side
            // 
            this.m2t2Side.Controls.Add(this.m2t2Defend);
            this.m2t2Side.Controls.Add(this.m2t2Attack);
            this.m2t2Side.Controls.Add(this.m2t2Neutral);
            this.m2t2Side.Location = new System.Drawing.Point(449, 41);
            this.m2t2Side.Name = "m2t2Side";
            this.m2t2Side.Size = new System.Drawing.Size(120, 30);
            this.m2t2Side.TabIndex = 79;
            this.m2t2Side.TabStop = false;
            // 
            // m2t2Defend
            // 
            this.m2t2Defend.AutoSize = true;
            this.m2t2Defend.Location = new System.Drawing.Point(49, 9);
            this.m2t2Defend.Name = "m2t2Defend";
            this.m2t2Defend.Size = new System.Drawing.Size(33, 17);
            this.m2t2Defend.TabIndex = 76;
            this.m2t2Defend.Text = "D";
            this.m2t2Defend.UseVisualStyleBackColor = true;
            // 
            // m2t2Attack
            // 
            this.m2t2Attack.AutoSize = true;
            this.m2t2Attack.Location = new System.Drawing.Point(11, 9);
            this.m2t2Attack.Name = "m2t2Attack";
            this.m2t2Attack.Size = new System.Drawing.Size(32, 17);
            this.m2t2Attack.TabIndex = 75;
            this.m2t2Attack.Text = "A";
            this.m2t2Attack.UseVisualStyleBackColor = true;
            // 
            // m2t2Neutral
            // 
            this.m2t2Neutral.AutoSize = true;
            this.m2t2Neutral.Checked = true;
            this.m2t2Neutral.Location = new System.Drawing.Point(87, 9);
            this.m2t2Neutral.Name = "m2t2Neutral";
            this.m2t2Neutral.Size = new System.Drawing.Size(33, 17);
            this.m2t2Neutral.TabIndex = 77;
            this.m2t2Neutral.TabStop = true;
            this.m2t2Neutral.Text = "N";
            this.m2t2Neutral.UseVisualStyleBackColor = true;
            // 
            // m2t1Side
            // 
            this.m2t1Side.Controls.Add(this.m2t1Defend);
            this.m2t1Side.Controls.Add(this.m2t1Attack);
            this.m2t1Side.Controls.Add(this.m2t1Neutral);
            this.m2t1Side.Location = new System.Drawing.Point(90, 41);
            this.m2t1Side.Name = "m2t1Side";
            this.m2t1Side.Size = new System.Drawing.Size(120, 30);
            this.m2t1Side.TabIndex = 78;
            this.m2t1Side.TabStop = false;
            // 
            // m2t1Defend
            // 
            this.m2t1Defend.AutoSize = true;
            this.m2t1Defend.Location = new System.Drawing.Point(44, 9);
            this.m2t1Defend.Name = "m2t1Defend";
            this.m2t1Defend.Size = new System.Drawing.Size(33, 17);
            this.m2t1Defend.TabIndex = 73;
            this.m2t1Defend.Text = "D";
            this.m2t1Defend.UseVisualStyleBackColor = true;
            // 
            // m2t1Attack
            // 
            this.m2t1Attack.AutoSize = true;
            this.m2t1Attack.Location = new System.Drawing.Point(6, 9);
            this.m2t1Attack.Name = "m2t1Attack";
            this.m2t1Attack.Size = new System.Drawing.Size(32, 17);
            this.m2t1Attack.TabIndex = 72;
            this.m2t1Attack.Text = "A";
            this.m2t1Attack.UseVisualStyleBackColor = true;
            // 
            // m2t1Neutral
            // 
            this.m2t1Neutral.AutoSize = true;
            this.m2t1Neutral.Checked = true;
            this.m2t1Neutral.Location = new System.Drawing.Point(82, 9);
            this.m2t1Neutral.Name = "m2t1Neutral";
            this.m2t1Neutral.Size = new System.Drawing.Size(33, 17);
            this.m2t1Neutral.TabIndex = 74;
            this.m2t1Neutral.TabStop = true;
            this.m2t1Neutral.Text = "N";
            this.m2t1Neutral.UseVisualStyleBackColor = true;
            // 
            // m2DivisionLabel
            // 
            this.m2DivisionLabel.AutoSize = true;
            this.m2DivisionLabel.Location = new System.Drawing.Point(110, 79);
            this.m2DivisionLabel.Name = "m2DivisionLabel";
            this.m2DivisionLabel.Size = new System.Drawing.Size(44, 13);
            this.m2DivisionLabel.TabIndex = 65;
            this.m2DivisionLabel.Text = "Division";
            // 
            // m2DivisionNumber
            // 
            this.m2DivisionNumber.Location = new System.Drawing.Point(7, 76);
            this.m2DivisionNumber.Name = "m2DivisionNumber";
            this.m2DivisionNumber.Size = new System.Drawing.Size(100, 20);
            this.m2DivisionNumber.TabIndex = 64;
            // 
            // m2MessageLabel
            // 
            this.m2MessageLabel.AutoSize = true;
            this.m2MessageLabel.Location = new System.Drawing.Point(450, 78);
            this.m2MessageLabel.Name = "m2MessageLabel";
            this.m2MessageLabel.Size = new System.Drawing.Size(50, 13);
            this.m2MessageLabel.TabIndex = 63;
            this.m2MessageLabel.Text = "Message";
            // 
            // m2MessageBox
            // 
            this.m2MessageBox.Location = new System.Drawing.Point(506, 76);
            this.m2MessageBox.Name = "m2MessageBox";
            this.m2MessageBox.Size = new System.Drawing.Size(146, 20);
            this.m2MessageBox.TabIndex = 62;
            // 
            // m2currentCheck
            // 
            this.m2currentCheck.AutoSize = true;
            this.m2currentCheck.Location = new System.Drawing.Point(168, 78);
            this.m2currentCheck.Name = "m2currentCheck";
            this.m2currentCheck.Size = new System.Drawing.Size(60, 17);
            this.m2currentCheck.TabIndex = 61;
            this.m2currentCheck.Text = "Current";
            this.m2currentCheck.UseVisualStyleBackColor = true;
            // 
            // m2UpdateButton
            // 
            this.m2UpdateButton.Location = new System.Drawing.Point(292, 77);
            this.m2UpdateButton.Name = "m2UpdateButton";
            this.m2UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.m2UpdateButton.TabIndex = 57;
            this.m2UpdateButton.Text = "Update";
            this.m2UpdateButton.UseVisualStyleBackColor = true;
            this.m2UpdateButton.Click += new System.EventHandler(this.m2UpdateButton_Click);
            // 
            // m2t2p6Hero
            // 
            this.m2t2p6Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p6Hero.FormattingEnabled = true;
            this.m2t2p6Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t2p6Hero.Location = new System.Drawing.Point(426, 314);
            this.m2t2p6Hero.Name = "m2t2p6Hero";
            this.m2t2p6Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t2p6Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t2p6Hero.TabIndex = 54;
            // 
            // m2t2p5Hero
            // 
            this.m2t2p5Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p5Hero.FormattingEnabled = true;
            this.m2t2p5Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t2p5Hero.Location = new System.Drawing.Point(426, 275);
            this.m2t2p5Hero.Name = "m2t2p5Hero";
            this.m2t2p5Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t2p5Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t2p5Hero.TabIndex = 53;
            // 
            // m2t2p4Hero
            // 
            this.m2t2p4Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p4Hero.FormattingEnabled = true;
            this.m2t2p4Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t2p4Hero.Location = new System.Drawing.Point(426, 236);
            this.m2t2p4Hero.Name = "m2t2p4Hero";
            this.m2t2p4Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t2p4Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t2p4Hero.TabIndex = 52;
            // 
            // m2t2p3Hero
            // 
            this.m2t2p3Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p3Hero.FormattingEnabled = true;
            this.m2t2p3Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t2p3Hero.Location = new System.Drawing.Point(426, 197);
            this.m2t2p3Hero.Name = "m2t2p3Hero";
            this.m2t2p3Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t2p3Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t2p3Hero.TabIndex = 51;
            // 
            // m2t2p2Hero
            // 
            this.m2t2p2Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p2Hero.FormattingEnabled = true;
            this.m2t2p2Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t2p2Hero.Location = new System.Drawing.Point(426, 158);
            this.m2t2p2Hero.Name = "m2t2p2Hero";
            this.m2t2p2Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t2p2Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t2p2Hero.TabIndex = 50;
            // 
            // m2t2p1Hero
            // 
            this.m2t2p1Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t2p1Hero.FormattingEnabled = true;
            this.m2t2p1Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t2p1Hero.Location = new System.Drawing.Point(426, 119);
            this.m2t2p1Hero.Name = "m2t2p1Hero";
            this.m2t2p1Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t2p1Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t2p1Hero.TabIndex = 49;
            // 
            // m2t1p6Hero
            // 
            this.m2t1p6Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p6Hero.FormattingEnabled = true;
            this.m2t1p6Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t1p6Hero.Location = new System.Drawing.Point(113, 314);
            this.m2t1p6Hero.Name = "m2t1p6Hero";
            this.m2t1p6Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t1p6Hero.TabIndex = 46;
            // 
            // m2t1p5Hero
            // 
            this.m2t1p5Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p5Hero.FormattingEnabled = true;
            this.m2t1p5Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t1p5Hero.Location = new System.Drawing.Point(113, 275);
            this.m2t1p5Hero.Name = "m2t1p5Hero";
            this.m2t1p5Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t1p5Hero.TabIndex = 45;
            // 
            // m2t1p4Hero
            // 
            this.m2t1p4Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p4Hero.FormattingEnabled = true;
            this.m2t1p4Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t1p4Hero.Location = new System.Drawing.Point(113, 236);
            this.m2t1p4Hero.Name = "m2t1p4Hero";
            this.m2t1p4Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t1p4Hero.TabIndex = 44;
            // 
            // m2t1p3Hero
            // 
            this.m2t1p3Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p3Hero.FormattingEnabled = true;
            this.m2t1p3Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t1p3Hero.Location = new System.Drawing.Point(113, 197);
            this.m2t1p3Hero.Name = "m2t1p3Hero";
            this.m2t1p3Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t1p3Hero.TabIndex = 43;
            // 
            // m2t1p2Hero
            // 
            this.m2t1p2Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p2Hero.FormattingEnabled = true;
            this.m2t1p2Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t1p2Hero.Location = new System.Drawing.Point(113, 158);
            this.m2t1p2Hero.Name = "m2t1p2Hero";
            this.m2t1p2Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t1p2Hero.TabIndex = 42;
            // 
            // m2t1p1Hero
            // 
            this.m2t1p1Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m2t1p1Hero.FormattingEnabled = true;
            this.m2t1p1Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m2t1p1Hero.Location = new System.Drawing.Point(113, 119);
            this.m2t1p1Hero.Name = "m2t1p1Hero";
            this.m2t1p1Hero.Size = new System.Drawing.Size(121, 21);
            this.m2t1p1Hero.TabIndex = 41;
            // 
            // m2ResetButton
            // 
            this.m2ResetButton.Location = new System.Drawing.Point(292, 49);
            this.m2ResetButton.Name = "m2ResetButton";
            this.m2ResetButton.Size = new System.Drawing.Size(75, 23);
            this.m2ResetButton.TabIndex = 40;
            this.m2ResetButton.Text = "Reset";
            this.m2ResetButton.UseVisualStyleBackColor = true;
            this.m2ResetButton.Click += new System.EventHandler(this.m2ResetButton_Click);
            // 
            // m2SwapButton
            // 
            this.m2SwapButton.Location = new System.Drawing.Point(292, 21);
            this.m2SwapButton.Name = "m2SwapButton";
            this.m2SwapButton.Size = new System.Drawing.Size(75, 23);
            this.m2SwapButton.TabIndex = 39;
            this.m2SwapButton.Text = "Swap";
            this.m2SwapButton.UseVisualStyleBackColor = true;
            this.m2SwapButton.Click += new System.EventHandler(this.m2SwapButton_Click);
            // 
            // m2t2p6Name
            // 
            this.m2t2p6Name.Location = new System.Drawing.Point(552, 314);
            this.m2t2p6Name.Name = "m2t2p6Name";
            this.m2t2p6Name.Size = new System.Drawing.Size(100, 20);
            this.m2t2p6Name.TabIndex = 33;
            // 
            // m2t2p6Label
            // 
            this.m2t2p6Label.AutoSize = true;
            this.m2t2p6Label.Location = new System.Drawing.Point(608, 298);
            this.m2t2p6Label.Name = "m2t2p6Label";
            this.m2t2p6Label.Size = new System.Drawing.Size(45, 13);
            this.m2t2p6Label.TabIndex = 34;
            this.m2t2p6Label.Text = "Player 6";
            // 
            // m2t2p5Name
            // 
            this.m2t2p5Name.Location = new System.Drawing.Point(552, 275);
            this.m2t2p5Name.Name = "m2t2p5Name";
            this.m2t2p5Name.Size = new System.Drawing.Size(100, 20);
            this.m2t2p5Name.TabIndex = 31;
            // 
            // m2t2p5Label
            // 
            this.m2t2p5Label.AutoSize = true;
            this.m2t2p5Label.Location = new System.Drawing.Point(608, 259);
            this.m2t2p5Label.Name = "m2t2p5Label";
            this.m2t2p5Label.Size = new System.Drawing.Size(45, 13);
            this.m2t2p5Label.TabIndex = 32;
            this.m2t2p5Label.Text = "Player 5";
            // 
            // m2t2p4Name
            // 
            this.m2t2p4Name.Location = new System.Drawing.Point(553, 236);
            this.m2t2p4Name.Name = "m2t2p4Name";
            this.m2t2p4Name.Size = new System.Drawing.Size(100, 20);
            this.m2t2p4Name.TabIndex = 29;
            // 
            // m2t2p4Label
            // 
            this.m2t2p4Label.AutoSize = true;
            this.m2t2p4Label.Location = new System.Drawing.Point(608, 220);
            this.m2t2p4Label.Name = "m2t2p4Label";
            this.m2t2p4Label.Size = new System.Drawing.Size(45, 13);
            this.m2t2p4Label.TabIndex = 30;
            this.m2t2p4Label.Text = "Player 4";
            // 
            // m2t2p3Name
            // 
            this.m2t2p3Name.Location = new System.Drawing.Point(553, 197);
            this.m2t2p3Name.Name = "m2t2p3Name";
            this.m2t2p3Name.Size = new System.Drawing.Size(100, 20);
            this.m2t2p3Name.TabIndex = 27;
            // 
            // m2t2p3Label
            // 
            this.m2t2p3Label.AutoSize = true;
            this.m2t2p3Label.Location = new System.Drawing.Point(608, 181);
            this.m2t2p3Label.Name = "m2t2p3Label";
            this.m2t2p3Label.Size = new System.Drawing.Size(45, 13);
            this.m2t2p3Label.TabIndex = 28;
            this.m2t2p3Label.Text = "Player 3";
            // 
            // m2t2p2Name
            // 
            this.m2t2p2Name.Location = new System.Drawing.Point(553, 158);
            this.m2t2p2Name.Name = "m2t2p2Name";
            this.m2t2p2Name.Size = new System.Drawing.Size(100, 20);
            this.m2t2p2Name.TabIndex = 25;
            // 
            // m2t2p2Label
            // 
            this.m2t2p2Label.AutoSize = true;
            this.m2t2p2Label.Location = new System.Drawing.Point(608, 142);
            this.m2t2p2Label.Name = "m2t2p2Label";
            this.m2t2p2Label.Size = new System.Drawing.Size(45, 13);
            this.m2t2p2Label.TabIndex = 26;
            this.m2t2p2Label.Text = "Player 2";
            // 
            // m2t2p1Name
            // 
            this.m2t2p1Name.Location = new System.Drawing.Point(553, 119);
            this.m2t2p1Name.Name = "m2t2p1Name";
            this.m2t2p1Name.Size = new System.Drawing.Size(100, 20);
            this.m2t2p1Name.TabIndex = 23;
            // 
            // m2t2p1Label
            // 
            this.m2t2p1Label.AutoSize = true;
            this.m2t2p1Label.Location = new System.Drawing.Point(608, 103);
            this.m2t2p1Label.Name = "m2t2p1Label";
            this.m2t2p1Label.Size = new System.Drawing.Size(45, 13);
            this.m2t2p1Label.TabIndex = 24;
            this.m2t2p1Label.Text = "Player 1";
            // 
            // m2t1p6Name
            // 
            this.m2t1p6Name.Location = new System.Drawing.Point(6, 314);
            this.m2t1p6Name.Name = "m2t1p6Name";
            this.m2t1p6Name.Size = new System.Drawing.Size(100, 20);
            this.m2t1p6Name.TabIndex = 17;
            // 
            // m2t1p6Label
            // 
            this.m2t1p6Label.AutoSize = true;
            this.m2t1p6Label.Location = new System.Drawing.Point(6, 298);
            this.m2t1p6Label.Name = "m2t1p6Label";
            this.m2t1p6Label.Size = new System.Drawing.Size(45, 13);
            this.m2t1p6Label.TabIndex = 18;
            this.m2t1p6Label.Text = "Player 6";
            // 
            // m2t1p5Name
            // 
            this.m2t1p5Name.Location = new System.Drawing.Point(6, 275);
            this.m2t1p5Name.Name = "m2t1p5Name";
            this.m2t1p5Name.Size = new System.Drawing.Size(100, 20);
            this.m2t1p5Name.TabIndex = 15;
            // 
            // m2t1p5Label
            // 
            this.m2t1p5Label.AutoSize = true;
            this.m2t1p5Label.Location = new System.Drawing.Point(6, 259);
            this.m2t1p5Label.Name = "m2t1p5Label";
            this.m2t1p5Label.Size = new System.Drawing.Size(45, 13);
            this.m2t1p5Label.TabIndex = 16;
            this.m2t1p5Label.Text = "Player 5";
            // 
            // m2t1p4Name
            // 
            this.m2t1p4Name.Location = new System.Drawing.Point(7, 236);
            this.m2t1p4Name.Name = "m2t1p4Name";
            this.m2t1p4Name.Size = new System.Drawing.Size(100, 20);
            this.m2t1p4Name.TabIndex = 13;
            // 
            // m2t1p4Label
            // 
            this.m2t1p4Label.AutoSize = true;
            this.m2t1p4Label.Location = new System.Drawing.Point(7, 220);
            this.m2t1p4Label.Name = "m2t1p4Label";
            this.m2t1p4Label.Size = new System.Drawing.Size(45, 13);
            this.m2t1p4Label.TabIndex = 14;
            this.m2t1p4Label.Text = "Player 4";
            // 
            // m2t1p3Name
            // 
            this.m2t1p3Name.Location = new System.Drawing.Point(7, 197);
            this.m2t1p3Name.Name = "m2t1p3Name";
            this.m2t1p3Name.Size = new System.Drawing.Size(100, 20);
            this.m2t1p3Name.TabIndex = 11;
            // 
            // m2t1p3Label
            // 
            this.m2t1p3Label.AutoSize = true;
            this.m2t1p3Label.Location = new System.Drawing.Point(7, 181);
            this.m2t1p3Label.Name = "m2t1p3Label";
            this.m2t1p3Label.Size = new System.Drawing.Size(45, 13);
            this.m2t1p3Label.TabIndex = 12;
            this.m2t1p3Label.Text = "Player 3";
            // 
            // m2t1p2Name
            // 
            this.m2t1p2Name.Location = new System.Drawing.Point(7, 158);
            this.m2t1p2Name.Name = "m2t1p2Name";
            this.m2t1p2Name.Size = new System.Drawing.Size(100, 20);
            this.m2t1p2Name.TabIndex = 9;
            // 
            // m2t1p2Label
            // 
            this.m2t1p2Label.AutoSize = true;
            this.m2t1p2Label.Location = new System.Drawing.Point(7, 142);
            this.m2t1p2Label.Name = "m2t1p2Label";
            this.m2t1p2Label.Size = new System.Drawing.Size(45, 13);
            this.m2t1p2Label.TabIndex = 10;
            this.m2t1p2Label.Text = "Player 2";
            // 
            // m2t1p1Name
            // 
            this.m2t1p1Name.Location = new System.Drawing.Point(7, 119);
            this.m2t1p1Name.Name = "m2t1p1Name";
            this.m2t1p1Name.Size = new System.Drawing.Size(100, 20);
            this.m2t1p1Name.TabIndex = 7;
            // 
            // m2t1p1Label
            // 
            this.m2t1p1Label.AutoSize = true;
            this.m2t1p1Label.Location = new System.Drawing.Point(7, 103);
            this.m2t1p1Label.Name = "m2t1p1Label";
            this.m2t1p1Label.Size = new System.Drawing.Size(45, 13);
            this.m2t1p1Label.TabIndex = 8;
            this.m2t1p1Label.Text = "Player 1";
            // 
            // m2t2Score
            // 
            this.m2t2Score.Location = new System.Drawing.Point(575, 47);
            this.m2t2Score.Name = "m2t2Score";
            this.m2t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m2t2Score.Size = new System.Drawing.Size(36, 20);
            this.m2t2Score.TabIndex = 6;
            // 
            // m2t1Score
            // 
            this.m2t1Score.Location = new System.Drawing.Point(48, 47);
            this.m2t1Score.Name = "m2t1Score";
            this.m2t1Score.Size = new System.Drawing.Size(36, 20);
            this.m2t1Score.TabIndex = 5;
            // 
            // m2t2ScoreLabel
            // 
            this.m2t2ScoreLabel.AutoSize = true;
            this.m2t2ScoreLabel.Location = new System.Drawing.Point(617, 49);
            this.m2t2ScoreLabel.Name = "m2t2ScoreLabel";
            this.m2t2ScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.m2t2ScoreLabel.TabIndex = 4;
            this.m2t2ScoreLabel.Text = "Score";
            // 
            // m2t1ScoreLabel
            // 
            this.m2t1ScoreLabel.AutoSize = true;
            this.m2t1ScoreLabel.Location = new System.Drawing.Point(7, 49);
            this.m2t1ScoreLabel.Name = "m2t1ScoreLabel";
            this.m2t1ScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.m2t1ScoreLabel.TabIndex = 3;
            this.m2t1ScoreLabel.Text = "Score";
            // 
            // m2t2Name
            // 
            this.m2t2Name.Location = new System.Drawing.Point(474, 21);
            this.m2t2Name.Name = "m2t2Name";
            this.m2t2Name.Size = new System.Drawing.Size(178, 20);
            this.m2t2Name.TabIndex = 1;
            // 
            // m2t2Label
            // 
            this.m2t2Label.AutoSize = true;
            this.m2t2Label.Location = new System.Drawing.Point(610, 3);
            this.m2t2Label.Name = "m2t2Label";
            this.m2t2Label.Size = new System.Drawing.Size(43, 13);
            this.m2t2Label.TabIndex = 2;
            this.m2t2Label.Text = "Team 2";
            // 
            // m2t1Name
            // 
            this.m2t1Name.Location = new System.Drawing.Point(6, 21);
            this.m2t1Name.Name = "m2t1Name";
            this.m2t1Name.Size = new System.Drawing.Size(178, 20);
            this.m2t1Name.TabIndex = 0;
            // 
            // m2t1Label
            // 
            this.m2t1Label.AutoSize = true;
            this.m2t1Label.Location = new System.Drawing.Point(6, 5);
            this.m2t1Label.Name = "m2t1Label";
            this.m2t1Label.Size = new System.Drawing.Size(43, 13);
            this.m2t1Label.TabIndex = 0;
            this.m2t1Label.Text = "Team 1";
            // 
            // Match_3
            // 
            this.Match_3.Controls.Add(this.m3t2SR);
            this.Match_3.Controls.Add(this.m3t1SR);
            this.Match_3.Controls.Add(this.m3t2p6Role);
            this.Match_3.Controls.Add(this.m3t2p5Role);
            this.Match_3.Controls.Add(this.m3t2p4Role);
            this.Match_3.Controls.Add(this.m3t2p3Role);
            this.Match_3.Controls.Add(this.m3t2p2Role);
            this.Match_3.Controls.Add(this.m3t2p1Role);
            this.Match_3.Controls.Add(this.m3t1p6Role);
            this.Match_3.Controls.Add(this.m3t1p5Role);
            this.Match_3.Controls.Add(this.m3t1p4Role);
            this.Match_3.Controls.Add(this.m3t1p3Role);
            this.Match_3.Controls.Add(this.m3t1p2Role);
            this.Match_3.Controls.Add(this.m3t1p1Role);
            this.Match_3.Controls.Add(this.m3m5t2Score);
            this.Match_3.Controls.Add(this.m3m5t1Score);
            this.Match_3.Controls.Add(this.m3m4t2Score);
            this.Match_3.Controls.Add(this.m3m4t1Score);
            this.Match_3.Controls.Add(this.m3m3t2Score);
            this.Match_3.Controls.Add(this.m3m3t1Score);
            this.Match_3.Controls.Add(this.m3m2t2Score);
            this.Match_3.Controls.Add(this.m3m2t1Score);
            this.Match_3.Controls.Add(this.m3m1t2Score);
            this.Match_3.Controls.Add(this.m3m1t1Score);
            this.Match_3.Controls.Add(this.m3m5Map);
            this.Match_3.Controls.Add(this.m3m4Map);
            this.Match_3.Controls.Add(this.m3m3Map);
            this.Match_3.Controls.Add(this.m3m2Map);
            this.Match_3.Controls.Add(this.m3m1Map);
            this.Match_3.Controls.Add(this.m3m3Label);
            this.Match_3.Controls.Add(this.m3m4Label);
            this.Match_3.Controls.Add(this.m3m5Label);
            this.Match_3.Controls.Add(this.m3m2Label);
            this.Match_3.Controls.Add(this.m3m1Label);
            this.Match_3.Controls.Add(this.m3t2Side);
            this.Match_3.Controls.Add(this.m3t1Side);
            this.Match_3.Controls.Add(this.m3DivisionLabel);
            this.Match_3.Controls.Add(this.m3DivisionNumber);
            this.Match_3.Controls.Add(this.m3MessageLabel);
            this.Match_3.Controls.Add(this.m3MessageBox);
            this.Match_3.Controls.Add(this.m3currentCheck);
            this.Match_3.Controls.Add(this.m3UpdateButton);
            this.Match_3.Controls.Add(this.m3t2p6Hero);
            this.Match_3.Controls.Add(this.m3t2p5Hero);
            this.Match_3.Controls.Add(this.m3t2p4Hero);
            this.Match_3.Controls.Add(this.m3t2p3Hero);
            this.Match_3.Controls.Add(this.m3t2p2Hero);
            this.Match_3.Controls.Add(this.m3t2p1Hero);
            this.Match_3.Controls.Add(this.m3t1p6Hero);
            this.Match_3.Controls.Add(this.m3t1p5Hero);
            this.Match_3.Controls.Add(this.m3t1p4Hero);
            this.Match_3.Controls.Add(this.m3t1p3Hero);
            this.Match_3.Controls.Add(this.m3t1p2Hero);
            this.Match_3.Controls.Add(this.m3t1p1Hero);
            this.Match_3.Controls.Add(this.m3ResetButton);
            this.Match_3.Controls.Add(this.m3SwapButton);
            this.Match_3.Controls.Add(this.m3t2p6Name);
            this.Match_3.Controls.Add(this.m3t2p6Label);
            this.Match_3.Controls.Add(this.m3t2p5Name);
            this.Match_3.Controls.Add(this.m3t2p5Label);
            this.Match_3.Controls.Add(this.m3t2p4Name);
            this.Match_3.Controls.Add(this.m3t2p4Label);
            this.Match_3.Controls.Add(this.m3t2p3Name);
            this.Match_3.Controls.Add(this.m3t2p3Label);
            this.Match_3.Controls.Add(this.m3t2p2Name);
            this.Match_3.Controls.Add(this.m3t2p2Label);
            this.Match_3.Controls.Add(this.m3t2p1Name);
            this.Match_3.Controls.Add(this.m3t2p1Label);
            this.Match_3.Controls.Add(this.m3t1p6Name);
            this.Match_3.Controls.Add(this.m3t1p6Label);
            this.Match_3.Controls.Add(this.m3t1p5Name);
            this.Match_3.Controls.Add(this.m3t1p5Label);
            this.Match_3.Controls.Add(this.m3t1p4Name);
            this.Match_3.Controls.Add(this.m3t1p4Label);
            this.Match_3.Controls.Add(this.m3t1p3Name);
            this.Match_3.Controls.Add(this.m3t1p3Label);
            this.Match_3.Controls.Add(this.m3t1p2Name);
            this.Match_3.Controls.Add(this.m3t1p2Label);
            this.Match_3.Controls.Add(this.m3t1p1Name);
            this.Match_3.Controls.Add(this.m3t1p1Label);
            this.Match_3.Controls.Add(this.m3t2Score);
            this.Match_3.Controls.Add(this.m3t1Score);
            this.Match_3.Controls.Add(this.m3t2ScoreLabel);
            this.Match_3.Controls.Add(this.m3t1ScoreLabel);
            this.Match_3.Controls.Add(this.m3t2Name);
            this.Match_3.Controls.Add(this.m3t2Label);
            this.Match_3.Controls.Add(this.m3t1Name);
            this.Match_3.Controls.Add(this.m3t1Label);
            this.Match_3.Location = new System.Drawing.Point(4, 22);
            this.Match_3.Name = "Match_3";
            this.Match_3.Padding = new System.Windows.Forms.Padding(3);
            this.Match_3.Size = new System.Drawing.Size(659, 414);
            this.Match_3.TabIndex = 0;
            this.Match_3.Text = "Match 3";
            this.Match_3.UseVisualStyleBackColor = true;
            // 
            // m3t2p6Role
            // 
            this.m3t2p6Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p6Role.FormattingEnabled = true;
            this.m3t2p6Role.Location = new System.Drawing.Point(337, 315);
            this.m3t2p6Role.Name = "m3t2p6Role";
            this.m3t2p6Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m3t2p6Role.Size = new System.Drawing.Size(82, 21);
            this.m3t2p6Role.TabIndex = 143;
            this.m3t2p6Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3t2p5Role
            // 
            this.m3t2p5Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p5Role.FormattingEnabled = true;
            this.m3t2p5Role.Location = new System.Drawing.Point(337, 275);
            this.m3t2p5Role.Name = "m3t2p5Role";
            this.m3t2p5Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m3t2p5Role.Size = new System.Drawing.Size(82, 21);
            this.m3t2p5Role.TabIndex = 142;
            this.m3t2p5Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3t2p4Role
            // 
            this.m3t2p4Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p4Role.FormattingEnabled = true;
            this.m3t2p4Role.Location = new System.Drawing.Point(337, 236);
            this.m3t2p4Role.Name = "m3t2p4Role";
            this.m3t2p4Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m3t2p4Role.Size = new System.Drawing.Size(82, 21);
            this.m3t2p4Role.TabIndex = 141;
            this.m3t2p4Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3t2p3Role
            // 
            this.m3t2p3Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p3Role.FormattingEnabled = true;
            this.m3t2p3Role.Location = new System.Drawing.Point(337, 198);
            this.m3t2p3Role.Name = "m3t2p3Role";
            this.m3t2p3Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m3t2p3Role.Size = new System.Drawing.Size(82, 21);
            this.m3t2p3Role.TabIndex = 140;
            this.m3t2p3Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3t2p2Role
            // 
            this.m3t2p2Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p2Role.FormattingEnabled = true;
            this.m3t2p2Role.Location = new System.Drawing.Point(337, 158);
            this.m3t2p2Role.Name = "m3t2p2Role";
            this.m3t2p2Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m3t2p2Role.Size = new System.Drawing.Size(82, 21);
            this.m3t2p2Role.TabIndex = 139;
            this.m3t2p2Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3t2p1Role
            // 
            this.m3t2p1Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p1Role.FormattingEnabled = true;
            this.m3t2p1Role.Location = new System.Drawing.Point(337, 119);
            this.m3t2p1Role.Name = "m3t2p1Role";
            this.m3t2p1Role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m3t2p1Role.Size = new System.Drawing.Size(82, 21);
            this.m3t2p1Role.TabIndex = 138;
            this.m3t2p1Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3t1p6Role
            // 
            this.m3t1p6Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p6Role.FormattingEnabled = true;
            this.m3t1p6Role.Location = new System.Drawing.Point(240, 314);
            this.m3t1p6Role.Name = "m3t1p6Role";
            this.m3t1p6Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t1p6Role.Size = new System.Drawing.Size(82, 21);
            this.m3t1p6Role.TabIndex = 137;
            this.m3t1p6Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3t1p5Role
            // 
            this.m3t1p5Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p5Role.FormattingEnabled = true;
            this.m3t1p5Role.Location = new System.Drawing.Point(240, 275);
            this.m3t1p5Role.Name = "m3t1p5Role";
            this.m3t1p5Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t1p5Role.Size = new System.Drawing.Size(82, 21);
            this.m3t1p5Role.TabIndex = 136;
            this.m3t1p5Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3t1p4Role
            // 
            this.m3t1p4Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p4Role.FormattingEnabled = true;
            this.m3t1p4Role.Location = new System.Drawing.Point(240, 236);
            this.m3t1p4Role.Name = "m3t1p4Role";
            this.m3t1p4Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t1p4Role.Size = new System.Drawing.Size(82, 21);
            this.m3t1p4Role.TabIndex = 135;
            this.m3t1p4Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3t1p3Role
            // 
            this.m3t1p3Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p3Role.FormattingEnabled = true;
            this.m3t1p3Role.Location = new System.Drawing.Point(240, 197);
            this.m3t1p3Role.Name = "m3t1p3Role";
            this.m3t1p3Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t1p3Role.Size = new System.Drawing.Size(82, 21);
            this.m3t1p3Role.TabIndex = 134;
            this.m3t1p3Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3t1p2Role
            // 
            this.m3t1p2Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p2Role.FormattingEnabled = true;
            this.m3t1p2Role.Location = new System.Drawing.Point(240, 158);
            this.m3t1p2Role.Name = "m3t1p2Role";
            this.m3t1p2Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t1p2Role.Size = new System.Drawing.Size(82, 21);
            this.m3t1p2Role.TabIndex = 133;
            this.m3t1p2Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3t1p1Role
            // 
            this.m3t1p1Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p1Role.FormattingEnabled = true;
            this.m3t1p1Role.Location = new System.Drawing.Point(240, 119);
            this.m3t1p1Role.Name = "m3t1p1Role";
            this.m3t1p1Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t1p1Role.Size = new System.Drawing.Size(82, 21);
            this.m3t1p1Role.TabIndex = 132;
            this.m3t1p1Role.Items.AddRange(new object[] {
            "",
            "DPS",
            "Flex",
            "Supp",
            "Tank"});
            // 
            // m3m5t2Score
            // 
            this.m3m5t2Score.Location = new System.Drawing.Point(614, 381);
            this.m3m5t2Score.Name = "m3m5t2Score";
            this.m3m5t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3m5t2Score.Size = new System.Drawing.Size(36, 20);
            this.m3m5t2Score.TabIndex = 119;
            // 
            // m3m5t1Score
            // 
            this.m3m5t1Score.Location = new System.Drawing.Point(567, 381);
            this.m3m5t1Score.Name = "m3m5t1Score";
            this.m3m5t1Score.Size = new System.Drawing.Size(36, 20);
            this.m3m5t1Score.TabIndex = 118;
            // 
            // m3m4t2Score
            // 
            this.m3m4t2Score.Location = new System.Drawing.Point(471, 381);
            this.m3m4t2Score.Name = "m3m4t2Score";
            this.m3m4t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3m4t2Score.Size = new System.Drawing.Size(36, 20);
            this.m3m4t2Score.TabIndex = 117;
            // 
            // m3m4t1Score
            // 
            this.m3m4t1Score.Location = new System.Drawing.Point(424, 381);
            this.m3m4t1Score.Name = "m3m4t1Score";
            this.m3m4t1Score.Size = new System.Drawing.Size(36, 20);
            this.m3m4t1Score.TabIndex = 116;
            // 
            // m3m3t2Score
            // 
            this.m3m3t2Score.Location = new System.Drawing.Point(334, 381);
            this.m3m3t2Score.Name = "m3m3t2Score";
            this.m3m3t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3m3t2Score.Size = new System.Drawing.Size(36, 20);
            this.m3m3t2Score.TabIndex = 115;
            // 
            // m3m3t1Score
            // 
            this.m3m3t1Score.Location = new System.Drawing.Point(287, 381);
            this.m3m3t1Score.Name = "m3m3t1Score";
            this.m3m3t1Score.Size = new System.Drawing.Size(36, 20);
            this.m3m3t1Score.TabIndex = 114;
            // 
            // m3m2t2Score
            // 
            this.m3m2t2Score.Location = new System.Drawing.Point(196, 381);
            this.m3m2t2Score.Name = "m3m2t2Score";
            this.m3m2t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3m2t2Score.Size = new System.Drawing.Size(36, 20);
            this.m3m2t2Score.TabIndex = 113;
            // 
            // m3m2t1Score
            // 
            this.m3m2t1Score.Location = new System.Drawing.Point(149, 381);
            this.m3m2t1Score.Name = "m3m2t1Score";
            this.m3m2t1Score.Size = new System.Drawing.Size(36, 20);
            this.m3m2t1Score.TabIndex = 112;
            // 
            // m3m1t2Score
            // 
            this.m3m1t2Score.Location = new System.Drawing.Point(52, 381);
            this.m3m1t2Score.Name = "m3m1t2Score";
            this.m3m1t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3m1t2Score.Size = new System.Drawing.Size(36, 20);
            this.m3m1t2Score.TabIndex = 111;
            // 
            // m3m1t1Score
            // 
            this.m3m1t1Score.Location = new System.Drawing.Point(5, 381);
            this.m3m1t1Score.Name = "m3m1t1Score";
            this.m3m1t1Score.Size = new System.Drawing.Size(36, 20);
            this.m3m1t1Score.TabIndex = 110;
            // 
            // m3m5Map
            // 
            this.m3m5Map.FormattingEnabled = true;
            this.m3m5Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m3m5Map.Location = new System.Drawing.Point(567, 354);
            this.m3m5Map.Name = "m3m5Map";
            this.m3m5Map.Size = new System.Drawing.Size(83, 21);
            this.m3m5Map.TabIndex = 109;
            // 
            // m3m4Map
            // 
            this.m3m4Map.FormattingEnabled = true;
            this.m3m4Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m3m4Map.Location = new System.Drawing.Point(424, 354);
            this.m3m4Map.Name = "m3m4Map";
            this.m3m4Map.Size = new System.Drawing.Size(83, 21);
            this.m3m4Map.TabIndex = 108;
            // 
            // m3m3Map
            // 
            this.m3m3Map.FormattingEnabled = true;
            this.m3m3Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m3m3Map.Location = new System.Drawing.Point(287, 354);
            this.m3m3Map.Name = "m3m3Map";
            this.m3m3Map.Size = new System.Drawing.Size(83, 21);
            this.m3m3Map.TabIndex = 107;
            // 
            // m3m2Map
            // 
            this.m3m2Map.FormattingEnabled = true;
            this.m3m2Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m3m2Map.Location = new System.Drawing.Point(149, 354);
            this.m3m2Map.Name = "m3m2Map";
            this.m3m2Map.Size = new System.Drawing.Size(83, 21);
            this.m3m2Map.TabIndex = 106;
            // 
            // m3m1Map
            // 
            this.m3m1Map.FormattingEnabled = true;
            this.m3m1Map.Items.AddRange(new object[] {
            "",
            "Assault",
            "Escort",
            "Hybrid",
            "Control",
            "Hanamura",
            "Horizon Lunar Colony",
            "Temple of Anubis",
            "Volskaya Industries",
            "Dorado",
            "Junkertown",
            "Route 66",
            "Watchpoint: Gibraltar",
            "Eichenwalde",
            "Hollywood",
            "King\'s Row",
            "Numbani",
            "Ilios",
            "Lijiang Tower",
            "Nepal",
            "Oasis"});
            this.m3m1Map.Location = new System.Drawing.Point(5, 354);
            this.m3m1Map.Name = "m3m1Map";
            this.m3m1Map.Size = new System.Drawing.Size(83, 21);
            this.m3m1Map.TabIndex = 105;
            // 
            // m3m3Label
            // 
            this.m3m3Label.AutoSize = true;
            this.m3m3Label.Location = new System.Drawing.Point(309, 337);
            this.m3m3Label.Name = "m3m3Label";
            this.m3m3Label.Size = new System.Drawing.Size(37, 13);
            this.m3m3Label.TabIndex = 104;
            this.m3m3Label.Text = "Map 3";
            // 
            // m3m4Label
            // 
            this.m3m4Label.AutoSize = true;
            this.m3m4Label.Location = new System.Drawing.Point(455, 337);
            this.m3m4Label.Name = "m3m4Label";
            this.m3m4Label.Size = new System.Drawing.Size(37, 13);
            this.m3m4Label.TabIndex = 103;
            this.m3m4Label.Text = "Map 4";
            // 
            // m3m5Label
            // 
            this.m3m5Label.AutoSize = true;
            this.m3m5Label.Location = new System.Drawing.Point(608, 337);
            this.m3m5Label.Name = "m3m5Label";
            this.m3m5Label.Size = new System.Drawing.Size(37, 13);
            this.m3m5Label.TabIndex = 102;
            this.m3m5Label.Text = "Map 5";
            // 
            // m3m2Label
            // 
            this.m3m2Label.AutoSize = true;
            this.m3m2Label.Location = new System.Drawing.Point(167, 337);
            this.m3m2Label.Name = "m3m2Label";
            this.m3m2Label.Size = new System.Drawing.Size(37, 13);
            this.m3m2Label.TabIndex = 101;
            this.m3m2Label.Text = "Map 2";
            // 
            // m3m1Label
            // 
            this.m3m1Label.AutoSize = true;
            this.m3m1Label.Location = new System.Drawing.Point(14, 337);
            this.m3m1Label.Name = "m3m1Label";
            this.m3m1Label.Size = new System.Drawing.Size(37, 13);
            this.m3m1Label.TabIndex = 100;
            this.m3m1Label.Text = "Map 1";
            // 
            // m3t2Side
            // 
            this.m3t2Side.Controls.Add(this.m3t2Attack);
            this.m3t2Side.Controls.Add(this.m3t2Defend);
            this.m3t2Side.Controls.Add(this.m3t2Neutral);
            this.m3t2Side.Location = new System.Drawing.Point(449, 41);
            this.m3t2Side.Name = "m3t2Side";
            this.m3t2Side.Size = new System.Drawing.Size(120, 30);
            this.m3t2Side.TabIndex = 85;
            this.m3t2Side.TabStop = false;
            // 
            // m3t2Attack
            // 
            this.m3t2Attack.AutoSize = true;
            this.m3t2Attack.Location = new System.Drawing.Point(11, 9);
            this.m3t2Attack.Name = "m3t2Attack";
            this.m3t2Attack.Size = new System.Drawing.Size(32, 17);
            this.m3t2Attack.TabIndex = 81;
            this.m3t2Attack.Text = "A";
            this.m3t2Attack.UseVisualStyleBackColor = true;
            // 
            // m3t2Defend
            // 
            this.m3t2Defend.AutoSize = true;
            this.m3t2Defend.Location = new System.Drawing.Point(49, 9);
            this.m3t2Defend.Name = "m3t2Defend";
            this.m3t2Defend.Size = new System.Drawing.Size(33, 17);
            this.m3t2Defend.TabIndex = 82;
            this.m3t2Defend.Text = "D";
            this.m3t2Defend.UseVisualStyleBackColor = true;
            // 
            // m3t2Neutral
            // 
            this.m3t2Neutral.AutoSize = true;
            this.m3t2Neutral.Checked = true;
            this.m3t2Neutral.Location = new System.Drawing.Point(87, 9);
            this.m3t2Neutral.Name = "m3t2Neutral";
            this.m3t2Neutral.Size = new System.Drawing.Size(33, 17);
            this.m3t2Neutral.TabIndex = 83;
            this.m3t2Neutral.TabStop = true;
            this.m3t2Neutral.Text = "N";
            this.m3t2Neutral.UseVisualStyleBackColor = true;
            // 
            // m3t1Side
            // 
            this.m3t1Side.Controls.Add(this.m3t1Attack);
            this.m3t1Side.Controls.Add(this.m3t1Defend);
            this.m3t1Side.Controls.Add(this.m3t1Neutral);
            this.m3t1Side.Location = new System.Drawing.Point(90, 41);
            this.m3t1Side.Name = "m3t1Side";
            this.m3t1Side.Size = new System.Drawing.Size(120, 30);
            this.m3t1Side.TabIndex = 84;
            this.m3t1Side.TabStop = false;
            // 
            // m3t1Attack
            // 
            this.m3t1Attack.AutoSize = true;
            this.m3t1Attack.Location = new System.Drawing.Point(6, 9);
            this.m3t1Attack.Name = "m3t1Attack";
            this.m3t1Attack.Size = new System.Drawing.Size(32, 17);
            this.m3t1Attack.TabIndex = 78;
            this.m3t1Attack.Text = "A";
            this.m3t1Attack.UseVisualStyleBackColor = true;
            // 
            // m3t1Defend
            // 
            this.m3t1Defend.AutoSize = true;
            this.m3t1Defend.Location = new System.Drawing.Point(44, 9);
            this.m3t1Defend.Name = "m3t1Defend";
            this.m3t1Defend.Size = new System.Drawing.Size(33, 17);
            this.m3t1Defend.TabIndex = 79;
            this.m3t1Defend.Text = "D";
            this.m3t1Defend.UseVisualStyleBackColor = true;
            // 
            // m3t1Neutral
            // 
            this.m3t1Neutral.AutoSize = true;
            this.m3t1Neutral.Checked = true;
            this.m3t1Neutral.Location = new System.Drawing.Point(82, 9);
            this.m3t1Neutral.Name = "m3t1Neutral";
            this.m3t1Neutral.Size = new System.Drawing.Size(33, 17);
            this.m3t1Neutral.TabIndex = 80;
            this.m3t1Neutral.TabStop = true;
            this.m3t1Neutral.Text = "N";
            this.m3t1Neutral.UseVisualStyleBackColor = true;
            // 
            // m3DivisionLabel
            // 
            this.m3DivisionLabel.AutoSize = true;
            this.m3DivisionLabel.Location = new System.Drawing.Point(110, 79);
            this.m3DivisionLabel.Name = "m3DivisionLabel";
            this.m3DivisionLabel.Size = new System.Drawing.Size(44, 13);
            this.m3DivisionLabel.TabIndex = 65;
            this.m3DivisionLabel.Text = "Division";
            // 
            // m3DivisionNumber
            // 
            this.m3DivisionNumber.Location = new System.Drawing.Point(7, 76);
            this.m3DivisionNumber.Name = "m3DivisionNumber";
            this.m3DivisionNumber.Size = new System.Drawing.Size(100, 20);
            this.m3DivisionNumber.TabIndex = 64;
            // 
            // m3MessageLabel
            // 
            this.m3MessageLabel.AutoSize = true;
            this.m3MessageLabel.Location = new System.Drawing.Point(450, 78);
            this.m3MessageLabel.Name = "m3MessageLabel";
            this.m3MessageLabel.Size = new System.Drawing.Size(50, 13);
            this.m3MessageLabel.TabIndex = 63;
            this.m3MessageLabel.Text = "Message";
            // 
            // m3MessageBox
            // 
            this.m3MessageBox.Location = new System.Drawing.Point(506, 76);
            this.m3MessageBox.Name = "m3MessageBox";
            this.m3MessageBox.Size = new System.Drawing.Size(146, 20);
            this.m3MessageBox.TabIndex = 62;
            // 
            // m3currentCheck
            // 
            this.m3currentCheck.AutoSize = true;
            this.m3currentCheck.Location = new System.Drawing.Point(168, 78);
            this.m3currentCheck.Name = "m3currentCheck";
            this.m3currentCheck.Size = new System.Drawing.Size(60, 17);
            this.m3currentCheck.TabIndex = 61;
            this.m3currentCheck.Text = "Current";
            this.m3currentCheck.UseVisualStyleBackColor = true;
            // 
            // m3UpdateButton
            // 
            this.m3UpdateButton.Location = new System.Drawing.Point(292, 77);
            this.m3UpdateButton.Name = "m3UpdateButton";
            this.m3UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.m3UpdateButton.TabIndex = 57;
            this.m3UpdateButton.Text = "Update";
            this.m3UpdateButton.UseVisualStyleBackColor = true;
            this.m3UpdateButton.Click += new System.EventHandler(this.m3UpdateButton_Click);
            // 
            // m3t2p6Hero
            // 
            this.m3t2p6Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p6Hero.FormattingEnabled = true;
            this.m3t2p6Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t2p6Hero.Location = new System.Drawing.Point(426, 314);
            this.m3t2p6Hero.Name = "m3t2p6Hero";
            this.m3t2p6Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t2p6Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t2p6Hero.TabIndex = 54;
            // 
            // m3t2p5Hero
            // 
            this.m3t2p5Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p5Hero.FormattingEnabled = true;
            this.m3t2p5Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t2p5Hero.Location = new System.Drawing.Point(426, 275);
            this.m3t2p5Hero.Name = "m3t2p5Hero";
            this.m3t2p5Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t2p5Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t2p5Hero.TabIndex = 53;
            // 
            // m3t2p4Hero
            // 
            this.m3t2p4Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p4Hero.FormattingEnabled = true;
            this.m3t2p4Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t2p4Hero.Location = new System.Drawing.Point(426, 236);
            this.m3t2p4Hero.Name = "m3t2p4Hero";
            this.m3t2p4Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t2p4Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t2p4Hero.TabIndex = 52;
            // 
            // m3t2p3Hero
            // 
            this.m3t2p3Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p3Hero.FormattingEnabled = true;
            this.m3t2p3Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t2p3Hero.Location = new System.Drawing.Point(426, 197);
            this.m3t2p3Hero.Name = "m3t2p3Hero";
            this.m3t2p3Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t2p3Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t2p3Hero.TabIndex = 51;
            // 
            // m3t2p2Hero
            // 
            this.m3t2p2Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p2Hero.FormattingEnabled = true;
            this.m3t2p2Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t2p2Hero.Location = new System.Drawing.Point(426, 158);
            this.m3t2p2Hero.Name = "m3t2p2Hero";
            this.m3t2p2Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t2p2Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t2p2Hero.TabIndex = 50;
            // 
            // m3t2p1Hero
            // 
            this.m3t2p1Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t2p1Hero.FormattingEnabled = true;
            this.m3t2p1Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t2p1Hero.Location = new System.Drawing.Point(426, 119);
            this.m3t2p1Hero.Name = "m3t2p1Hero";
            this.m3t2p1Hero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t2p1Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t2p1Hero.TabIndex = 49;
            // 
            // m3t1p6Hero
            // 
            this.m3t1p6Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p6Hero.FormattingEnabled = true;
            this.m3t1p6Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t1p6Hero.Location = new System.Drawing.Point(113, 314);
            this.m3t1p6Hero.Name = "m3t1p6Hero";
            this.m3t1p6Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t1p6Hero.TabIndex = 46;
            // 
            // m3t1p5Hero
            // 
            this.m3t1p5Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p5Hero.FormattingEnabled = true;
            this.m3t1p5Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t1p5Hero.Location = new System.Drawing.Point(113, 275);
            this.m3t1p5Hero.Name = "m3t1p5Hero";
            this.m3t1p5Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t1p5Hero.TabIndex = 45;
            // 
            // m3t1p4Hero
            // 
            this.m3t1p4Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p4Hero.FormattingEnabled = true;
            this.m3t1p4Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t1p4Hero.Location = new System.Drawing.Point(113, 236);
            this.m3t1p4Hero.Name = "m3t1p4Hero";
            this.m3t1p4Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t1p4Hero.TabIndex = 44;
            // 
            // m3t1p3Hero
            // 
            this.m3t1p3Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p3Hero.FormattingEnabled = true;
            this.m3t1p3Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t1p3Hero.Location = new System.Drawing.Point(113, 197);
            this.m3t1p3Hero.Name = "m3t1p3Hero";
            this.m3t1p3Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t1p3Hero.TabIndex = 43;
            // 
            // m3t1p2Hero
            // 
            this.m3t1p2Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p2Hero.FormattingEnabled = true;
            this.m3t1p2Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t1p2Hero.Location = new System.Drawing.Point(113, 158);
            this.m3t1p2Hero.Name = "m3t1p2Hero";
            this.m3t1p2Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t1p2Hero.TabIndex = 42;
            // 
            // m3t1p1Hero
            // 
            this.m3t1p1Hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m3t1p1Hero.FormattingEnabled = true;
            this.m3t1p1Hero.Items.AddRange(new object[] {
            "",
            "Doomfist",
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D.Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.m3t1p1Hero.Location = new System.Drawing.Point(113, 119);
            this.m3t1p1Hero.Name = "m3t1p1Hero";
            this.m3t1p1Hero.Size = new System.Drawing.Size(121, 21);
            this.m3t1p1Hero.TabIndex = 41;
            // 
            // m3ResetButton
            // 
            this.m3ResetButton.Location = new System.Drawing.Point(292, 49);
            this.m3ResetButton.Name = "m3ResetButton";
            this.m3ResetButton.Size = new System.Drawing.Size(75, 23);
            this.m3ResetButton.TabIndex = 40;
            this.m3ResetButton.Text = "Reset";
            this.m3ResetButton.UseVisualStyleBackColor = true;
            this.m3ResetButton.Click += new System.EventHandler(this.m3ResetButton_Click);
            // 
            // m3SwapButton
            // 
            this.m3SwapButton.Location = new System.Drawing.Point(292, 21);
            this.m3SwapButton.Name = "m3SwapButton";
            this.m3SwapButton.Size = new System.Drawing.Size(75, 23);
            this.m3SwapButton.TabIndex = 39;
            this.m3SwapButton.Text = "Swap";
            this.m3SwapButton.UseVisualStyleBackColor = true;
            this.m3SwapButton.Click += new System.EventHandler(this.m3SwapButton_Click);
            // 
            // m3t2p6Name
            // 
            this.m3t2p6Name.Location = new System.Drawing.Point(552, 314);
            this.m3t2p6Name.Name = "m3t2p6Name";
            this.m3t2p6Name.Size = new System.Drawing.Size(100, 20);
            this.m3t2p6Name.TabIndex = 33;
            // 
            // m3t2p6Label
            // 
            this.m3t2p6Label.AutoSize = true;
            this.m3t2p6Label.Location = new System.Drawing.Point(608, 298);
            this.m3t2p6Label.Name = "m3t2p6Label";
            this.m3t2p6Label.Size = new System.Drawing.Size(45, 13);
            this.m3t2p6Label.TabIndex = 34;
            this.m3t2p6Label.Text = "Player 6";
            // 
            // m3t2p5Name
            // 
            this.m3t2p5Name.Location = new System.Drawing.Point(552, 275);
            this.m3t2p5Name.Name = "m3t2p5Name";
            this.m3t2p5Name.Size = new System.Drawing.Size(100, 20);
            this.m3t2p5Name.TabIndex = 31;
            // 
            // m3t2p5Label
            // 
            this.m3t2p5Label.AutoSize = true;
            this.m3t2p5Label.Location = new System.Drawing.Point(608, 259);
            this.m3t2p5Label.Name = "m3t2p5Label";
            this.m3t2p5Label.Size = new System.Drawing.Size(45, 13);
            this.m3t2p5Label.TabIndex = 32;
            this.m3t2p5Label.Text = "Player 5";
            // 
            // m3t2p4Name
            // 
            this.m3t2p4Name.Location = new System.Drawing.Point(553, 236);
            this.m3t2p4Name.Name = "m3t2p4Name";
            this.m3t2p4Name.Size = new System.Drawing.Size(100, 20);
            this.m3t2p4Name.TabIndex = 29;
            // 
            // m3t2p4Label
            // 
            this.m3t2p4Label.AutoSize = true;
            this.m3t2p4Label.Location = new System.Drawing.Point(608, 220);
            this.m3t2p4Label.Name = "m3t2p4Label";
            this.m3t2p4Label.Size = new System.Drawing.Size(45, 13);
            this.m3t2p4Label.TabIndex = 30;
            this.m3t2p4Label.Text = "Player 4";
            // 
            // m3t2p3Name
            // 
            this.m3t2p3Name.Location = new System.Drawing.Point(553, 197);
            this.m3t2p3Name.Name = "m3t2p3Name";
            this.m3t2p3Name.Size = new System.Drawing.Size(100, 20);
            this.m3t2p3Name.TabIndex = 27;
            // 
            // m3t2p3Label
            // 
            this.m3t2p3Label.AutoSize = true;
            this.m3t2p3Label.Location = new System.Drawing.Point(608, 181);
            this.m3t2p3Label.Name = "m3t2p3Label";
            this.m3t2p3Label.Size = new System.Drawing.Size(45, 13);
            this.m3t2p3Label.TabIndex = 28;
            this.m3t2p3Label.Text = "Player 3";
            // 
            // m3t2p2Name
            // 
            this.m3t2p2Name.Location = new System.Drawing.Point(553, 158);
            this.m3t2p2Name.Name = "m3t2p2Name";
            this.m3t2p2Name.Size = new System.Drawing.Size(100, 20);
            this.m3t2p2Name.TabIndex = 25;
            // 
            // m3t2p2Label
            // 
            this.m3t2p2Label.AutoSize = true;
            this.m3t2p2Label.Location = new System.Drawing.Point(608, 142);
            this.m3t2p2Label.Name = "m3t2p2Label";
            this.m3t2p2Label.Size = new System.Drawing.Size(45, 13);
            this.m3t2p2Label.TabIndex = 26;
            this.m3t2p2Label.Text = "Player 2";
            // 
            // m3t2p1Name
            // 
            this.m3t2p1Name.Location = new System.Drawing.Point(553, 119);
            this.m3t2p1Name.Name = "m3t2p1Name";
            this.m3t2p1Name.Size = new System.Drawing.Size(100, 20);
            this.m3t2p1Name.TabIndex = 23;
            // 
            // m3t2p1Label
            // 
            this.m3t2p1Label.AutoSize = true;
            this.m3t2p1Label.Location = new System.Drawing.Point(608, 103);
            this.m3t2p1Label.Name = "m3t2p1Label";
            this.m3t2p1Label.Size = new System.Drawing.Size(45, 13);
            this.m3t2p1Label.TabIndex = 24;
            this.m3t2p1Label.Text = "Player 1";
            // 
            // m3t1p6Name
            // 
            this.m3t1p6Name.Location = new System.Drawing.Point(6, 314);
            this.m3t1p6Name.Name = "m3t1p6Name";
            this.m3t1p6Name.Size = new System.Drawing.Size(100, 20);
            this.m3t1p6Name.TabIndex = 17;
            // 
            // m3t1p6Label
            // 
            this.m3t1p6Label.AutoSize = true;
            this.m3t1p6Label.Location = new System.Drawing.Point(6, 298);
            this.m3t1p6Label.Name = "m3t1p6Label";
            this.m3t1p6Label.Size = new System.Drawing.Size(45, 13);
            this.m3t1p6Label.TabIndex = 18;
            this.m3t1p6Label.Text = "Player 6";
            // 
            // m3t1p5Name
            // 
            this.m3t1p5Name.Location = new System.Drawing.Point(6, 275);
            this.m3t1p5Name.Name = "m3t1p5Name";
            this.m3t1p5Name.Size = new System.Drawing.Size(100, 20);
            this.m3t1p5Name.TabIndex = 15;
            // 
            // m3t1p5Label
            // 
            this.m3t1p5Label.AutoSize = true;
            this.m3t1p5Label.Location = new System.Drawing.Point(6, 259);
            this.m3t1p5Label.Name = "m3t1p5Label";
            this.m3t1p5Label.Size = new System.Drawing.Size(45, 13);
            this.m3t1p5Label.TabIndex = 16;
            this.m3t1p5Label.Text = "Player 5";
            // 
            // m3t1p4Name
            // 
            this.m3t1p4Name.Location = new System.Drawing.Point(7, 236);
            this.m3t1p4Name.Name = "m3t1p4Name";
            this.m3t1p4Name.Size = new System.Drawing.Size(100, 20);
            this.m3t1p4Name.TabIndex = 13;
            // 
            // m3t1p4Label
            // 
            this.m3t1p4Label.AutoSize = true;
            this.m3t1p4Label.Location = new System.Drawing.Point(7, 220);
            this.m3t1p4Label.Name = "m3t1p4Label";
            this.m3t1p4Label.Size = new System.Drawing.Size(45, 13);
            this.m3t1p4Label.TabIndex = 14;
            this.m3t1p4Label.Text = "Player 4";
            // 
            // m3t1p3Name
            // 
            this.m3t1p3Name.Location = new System.Drawing.Point(7, 197);
            this.m3t1p3Name.Name = "m3t1p3Name";
            this.m3t1p3Name.Size = new System.Drawing.Size(100, 20);
            this.m3t1p3Name.TabIndex = 11;
            // 
            // m3t1p3Label
            // 
            this.m3t1p3Label.AutoSize = true;
            this.m3t1p3Label.Location = new System.Drawing.Point(7, 181);
            this.m3t1p3Label.Name = "m3t1p3Label";
            this.m3t1p3Label.Size = new System.Drawing.Size(45, 13);
            this.m3t1p3Label.TabIndex = 12;
            this.m3t1p3Label.Text = "Player 3";
            // 
            // m3t1p2Name
            // 
            this.m3t1p2Name.Location = new System.Drawing.Point(7, 158);
            this.m3t1p2Name.Name = "m3t1p2Name";
            this.m3t1p2Name.Size = new System.Drawing.Size(100, 20);
            this.m3t1p2Name.TabIndex = 9;
            // 
            // m3t1p2Label
            // 
            this.m3t1p2Label.AutoSize = true;
            this.m3t1p2Label.Location = new System.Drawing.Point(7, 142);
            this.m3t1p2Label.Name = "m3t1p2Label";
            this.m3t1p2Label.Size = new System.Drawing.Size(45, 13);
            this.m3t1p2Label.TabIndex = 10;
            this.m3t1p2Label.Text = "Player 2";
            // 
            // m3t1p1Name
            // 
            this.m3t1p1Name.Location = new System.Drawing.Point(7, 119);
            this.m3t1p1Name.Name = "m3t1p1Name";
            this.m3t1p1Name.Size = new System.Drawing.Size(100, 20);
            this.m3t1p1Name.TabIndex = 7;
            // 
            // m3t1p1Label
            // 
            this.m3t1p1Label.AutoSize = true;
            this.m3t1p1Label.Location = new System.Drawing.Point(7, 103);
            this.m3t1p1Label.Name = "m3t1p1Label";
            this.m3t1p1Label.Size = new System.Drawing.Size(45, 13);
            this.m3t1p1Label.TabIndex = 8;
            this.m3t1p1Label.Text = "Player 1";
            // 
            // m3t2Score
            // 
            this.m3t2Score.Location = new System.Drawing.Point(575, 47);
            this.m3t2Score.Name = "m3t2Score";
            this.m3t2Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m3t2Score.Size = new System.Drawing.Size(36, 20);
            this.m3t2Score.TabIndex = 6;
            // 
            // m3t1Score
            // 
            this.m3t1Score.Location = new System.Drawing.Point(48, 47);
            this.m3t1Score.Name = "m3t1Score";
            this.m3t1Score.Size = new System.Drawing.Size(36, 20);
            this.m3t1Score.TabIndex = 5;
            // 
            // m3t2ScoreLabel
            // 
            this.m3t2ScoreLabel.AutoSize = true;
            this.m3t2ScoreLabel.Location = new System.Drawing.Point(617, 49);
            this.m3t2ScoreLabel.Name = "m3t2ScoreLabel";
            this.m3t2ScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.m3t2ScoreLabel.TabIndex = 4;
            this.m3t2ScoreLabel.Text = "Score";
            // 
            // m3t1ScoreLabel
            // 
            this.m3t1ScoreLabel.AutoSize = true;
            this.m3t1ScoreLabel.Location = new System.Drawing.Point(7, 49);
            this.m3t1ScoreLabel.Name = "m3t1ScoreLabel";
            this.m3t1ScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.m3t1ScoreLabel.TabIndex = 3;
            this.m3t1ScoreLabel.Text = "Score";
            // 
            // m3t2Name
            // 
            this.m3t2Name.Location = new System.Drawing.Point(474, 21);
            this.m3t2Name.Name = "m3t2Name";
            this.m3t2Name.Size = new System.Drawing.Size(178, 20);
            this.m3t2Name.TabIndex = 1;
            // 
            // m3t2Label
            // 
            this.m3t2Label.AutoSize = true;
            this.m3t2Label.Location = new System.Drawing.Point(610, 3);
            this.m3t2Label.Name = "m3t2Label";
            this.m3t2Label.Size = new System.Drawing.Size(43, 13);
            this.m3t2Label.TabIndex = 2;
            this.m3t2Label.Text = "Team 2";
            // 
            // m3t1Name
            // 
            this.m3t1Name.Location = new System.Drawing.Point(6, 21);
            this.m3t1Name.Name = "m3t1Name";
            this.m3t1Name.Size = new System.Drawing.Size(178, 20);
            this.m3t1Name.TabIndex = 0;
            // 
            // m3t1Label
            // 
            this.m3t1Label.AutoSize = true;
            this.m3t1Label.Location = new System.Drawing.Point(6, 5);
            this.m3t1Label.Name = "m3t1Label";
            this.m3t1Label.Size = new System.Drawing.Size(43, 13);
            this.m3t1Label.TabIndex = 0;
            this.m3t1Label.Text = "Team 1";
            // 
            // General_Info
            // 
            this.General_Info.Location = new System.Drawing.Point(4, 22);
            this.General_Info.Name = "General_Info";
            this.General_Info.Padding = new System.Windows.Forms.Padding(3);
            this.General_Info.Size = new System.Drawing.Size(659, 414);
            this.General_Info.TabIndex = 1;
            this.General_Info.Text = "General";
            this.General_Info.UseVisualStyleBackColor = true;
            // 
            // m1t1SR
            // 
            this.m1t1SR.Location = new System.Drawing.Point(190, 21);
            this.m1t1SR.Name = "m1t1SR";
            this.m1t1SR.Size = new System.Drawing.Size(97, 20);
            this.m1t1SR.TabIndex = 132;
            // 
            // m1t2SR
            // 
            this.m1t2SR.Location = new System.Drawing.Point(371, 21);
            this.m1t2SR.Name = "m1t2SR";
            this.m1t2SR.Size = new System.Drawing.Size(97, 20);
            this.m1t2SR.TabIndex = 133;
            // 
            // m2t2SR
            // 
            this.m2t2SR.Location = new System.Drawing.Point(371, 21);
            this.m2t2SR.Name = "m2t2SR";
            this.m2t2SR.Size = new System.Drawing.Size(97, 20);
            this.m2t2SR.TabIndex = 145;
            // 
            // m2t1SR
            // 
            this.m2t1SR.Location = new System.Drawing.Point(190, 21);
            this.m2t1SR.Name = "m2t1SR";
            this.m2t1SR.Size = new System.Drawing.Size(97, 20);
            this.m2t1SR.TabIndex = 144;
            // 
            // m3t2SR
            // 
            this.m3t2SR.Location = new System.Drawing.Point(371, 21);
            this.m3t2SR.Name = "m3t2SR";
            this.m3t2SR.Size = new System.Drawing.Size(97, 20);
            this.m3t2SR.TabIndex = 145;
            // 
            // m3t1SR
            // 
            this.m3t1SR.Location = new System.Drawing.Point(190, 21);
            this.m3t1SR.Name = "m3t1SR";
            this.m3t1SR.Size = new System.Drawing.Size(97, 20);
            this.m3t1SR.TabIndex = 144;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 465);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Overwatch Scoreboard Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Match_1.ResumeLayout(false);
            this.Match_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m1m5t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m5t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m4t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m4t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m3t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m3t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m2t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m2t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m1t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1m1t1Score)).EndInit();
            this.m1t2Side.ResumeLayout(false);
            this.m1t2Side.PerformLayout();
            this.m1t1Side.ResumeLayout(false);
            this.m1t1Side.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m1t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1t1Score)).EndInit();
            this.Match_2.ResumeLayout(false);
            this.Match_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m2m5t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m5t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m4t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m4t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m3t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m3t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m2t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m2t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m1t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2m1t1Score)).EndInit();
            this.m2t2Side.ResumeLayout(false);
            this.m2t2Side.PerformLayout();
            this.m2t1Side.ResumeLayout(false);
            this.m2t1Side.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m2t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2t1Score)).EndInit();
            this.Match_3.ResumeLayout(false);
            this.Match_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m3m5t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m5t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m4t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m4t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m3t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m3t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m2t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m2t1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m1t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3m1t1Score)).EndInit();
            this.m3t2Side.ResumeLayout(false);
            this.m3t2Side.PerformLayout();
            this.m3t1Side.ResumeLayout(false);
            this.m3t1Side.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m3t2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3t1Score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        #region 
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Match_1;
        private System.Windows.Forms.TextBox m1t1Name;
        private System.Windows.Forms.Label m1t1Label;
        private System.Windows.Forms.TextBox m1t2Name;
        private System.Windows.Forms.Label m1t2Label;
        private System.Windows.Forms.Label m1t2ScoreLabel;
        private System.Windows.Forms.Label m1t1ScoreLabel;
        private System.Windows.Forms.NumericUpDown m1t2Score;
        private System.Windows.Forms.NumericUpDown m1t1Score;
        private System.Windows.Forms.TextBox m1t1p1Name;
        private System.Windows.Forms.Label m1t1p1Label;
        private System.Windows.Forms.TextBox m1t2p6Name;
        private System.Windows.Forms.Label m1t2p6Label;
        private System.Windows.Forms.TextBox m1t2p5Name;
        private System.Windows.Forms.Label m1t2p5Label;
        private System.Windows.Forms.TextBox m1t2p4Name;
        private System.Windows.Forms.Label m1t2p4Label;
        private System.Windows.Forms.TextBox m1t2p3Name;
        private System.Windows.Forms.Label m1t2p3Label;
        private System.Windows.Forms.TextBox m1t2p2Name;
        private System.Windows.Forms.Label m1t2p2Label;
        private System.Windows.Forms.TextBox m1t2p1Name;
        private System.Windows.Forms.Label m1t2p1Label;
        private System.Windows.Forms.TextBox m1t1p6Name;
        private System.Windows.Forms.Label m1t1p6Label;
        private System.Windows.Forms.TextBox m1t1p5Name;
        private System.Windows.Forms.Label m1t1p5Label;
        private System.Windows.Forms.TextBox m1t1p4Name;
        private System.Windows.Forms.Label m1t1p4Label;
        private System.Windows.Forms.TextBox m1t1p3Name;
        private System.Windows.Forms.Label m1t1p3Label;
        private System.Windows.Forms.TextBox m1t1p2Name;
        private System.Windows.Forms.Label m1t1p2Label;
        private System.Windows.Forms.Button m1ResetButton;
        private System.Windows.Forms.Button m1SwapButton;
        private System.Windows.Forms.ComboBox m1t1p6Hero;
        private System.Windows.Forms.ComboBox m1t1p5Hero;
        private System.Windows.Forms.ComboBox m1t1p4Hero;
        private System.Windows.Forms.ComboBox m1t1p3Hero;
        private System.Windows.Forms.ComboBox m1t1p2Hero;
        private System.Windows.Forms.ComboBox m1t1p1Hero;
        private System.Windows.Forms.ComboBox m1t2p6Hero;
        private System.Windows.Forms.ComboBox m1t2p5Hero;
        private System.Windows.Forms.ComboBox m1t2p4Hero;
        private System.Windows.Forms.ComboBox m1t2p3Hero;
        private System.Windows.Forms.ComboBox m1t2p2Hero;
        private System.Windows.Forms.ComboBox m1t2p1Hero;
        private System.Windows.Forms.Button m1UpdateButton;
        private System.Windows.Forms.Label m1DivisionLabel;
        private System.Windows.Forms.TextBox m1DivisionNumber;
        private System.Windows.Forms.Label m1MessageLabel;
        private System.Windows.Forms.TextBox m1MessageBox;
        private System.Windows.Forms.CheckBox m1currentCheck;

        private System.Windows.Forms.TabPage Match_2;
        private System.Windows.Forms.TextBox m2t1Name;
        private System.Windows.Forms.Label m2t1Label;
        private System.Windows.Forms.TextBox m2t2Name;
        private System.Windows.Forms.Label m2t2Label;
        private System.Windows.Forms.Label m2t2ScoreLabel;
        private System.Windows.Forms.Label m2t1ScoreLabel;
        private System.Windows.Forms.NumericUpDown m2t2Score;
        private System.Windows.Forms.NumericUpDown m2t1Score;
        private System.Windows.Forms.TextBox m2t1p1Name;
        private System.Windows.Forms.Label m2t1p1Label;
        private System.Windows.Forms.TextBox m2t2p6Name;
        private System.Windows.Forms.Label m2t2p6Label;
        private System.Windows.Forms.TextBox m2t2p5Name;
        private System.Windows.Forms.Label m2t2p5Label;
        private System.Windows.Forms.TextBox m2t2p4Name;
        private System.Windows.Forms.Label m2t2p4Label;
        private System.Windows.Forms.TextBox m2t2p3Name;
        private System.Windows.Forms.Label m2t2p3Label;
        private System.Windows.Forms.TextBox m2t2p2Name;
        private System.Windows.Forms.Label m2t2p2Label;
        private System.Windows.Forms.TextBox m2t2p1Name;
        private System.Windows.Forms.Label m2t2p1Label;
        private System.Windows.Forms.TextBox m2t1p6Name;
        private System.Windows.Forms.Label m2t1p6Label;
        private System.Windows.Forms.TextBox m2t1p5Name;
        private System.Windows.Forms.Label m2t1p5Label;
        private System.Windows.Forms.TextBox m2t1p4Name;
        private System.Windows.Forms.Label m2t1p4Label;
        private System.Windows.Forms.TextBox m2t1p3Name;
        private System.Windows.Forms.Label m2t1p3Label;
        private System.Windows.Forms.TextBox m2t1p2Name;
        private System.Windows.Forms.Label m2t1p2Label;
        private System.Windows.Forms.Button m2ResetButton;
        private System.Windows.Forms.Button m2SwapButton;
        private System.Windows.Forms.ComboBox m2t1p6Hero;
        private System.Windows.Forms.ComboBox m2t1p5Hero;
        private System.Windows.Forms.ComboBox m2t1p4Hero;
        private System.Windows.Forms.ComboBox m2t1p3Hero;
        private System.Windows.Forms.ComboBox m2t1p2Hero;
        private System.Windows.Forms.ComboBox m2t1p1Hero;
        private System.Windows.Forms.ComboBox m2t2p6Hero;
        private System.Windows.Forms.ComboBox m2t2p5Hero;
        private System.Windows.Forms.ComboBox m2t2p4Hero;
        private System.Windows.Forms.ComboBox m2t2p3Hero;
        private System.Windows.Forms.ComboBox m2t2p2Hero;
        private System.Windows.Forms.ComboBox m2t2p1Hero;
        private System.Windows.Forms.Button m2UpdateButton;
        private System.Windows.Forms.Label m2DivisionLabel;
        private System.Windows.Forms.TextBox m2DivisionNumber;
        private System.Windows.Forms.Label m2MessageLabel;
        private System.Windows.Forms.TextBox m2MessageBox;
        private System.Windows.Forms.CheckBox m2currentCheck;

        private System.Windows.Forms.TabPage Match_3;
        private System.Windows.Forms.TextBox m3t1Name;
        private System.Windows.Forms.Label m3t1Label;
        private System.Windows.Forms.TextBox m3t2Name;
        private System.Windows.Forms.Label m3t2Label;
        private System.Windows.Forms.Label m3t2ScoreLabel;
        private System.Windows.Forms.Label m3t1ScoreLabel;
        private System.Windows.Forms.NumericUpDown m3t2Score;
        private System.Windows.Forms.NumericUpDown m3t1Score;
        private System.Windows.Forms.TextBox m3t1p1Name;
        private System.Windows.Forms.Label m3t1p1Label;
        private System.Windows.Forms.TextBox m3t2p6Name;
        private System.Windows.Forms.Label m3t2p6Label;
        private System.Windows.Forms.TextBox m3t2p5Name;
        private System.Windows.Forms.Label m3t2p5Label;
        private System.Windows.Forms.TextBox m3t2p4Name;
        private System.Windows.Forms.Label m3t2p4Label;
        private System.Windows.Forms.TextBox m3t2p3Name;
        private System.Windows.Forms.Label m3t2p3Label;
        private System.Windows.Forms.TextBox m3t2p2Name;
        private System.Windows.Forms.Label m3t2p2Label;
        private System.Windows.Forms.TextBox m3t2p1Name;
        private System.Windows.Forms.Label m3t2p1Label;
        private System.Windows.Forms.TextBox m3t1p6Name;
        private System.Windows.Forms.Label m3t1p6Label;
        private System.Windows.Forms.TextBox m3t1p5Name;
        private System.Windows.Forms.Label m3t1p5Label;
        private System.Windows.Forms.TextBox m3t1p4Name;
        private System.Windows.Forms.Label m3t1p4Label;
        private System.Windows.Forms.TextBox m3t1p3Name;
        private System.Windows.Forms.Label m3t1p3Label;
        private System.Windows.Forms.TextBox m3t1p2Name;
        private System.Windows.Forms.Label m3t1p2Label;
        private System.Windows.Forms.Button m3ResetButton;
        private System.Windows.Forms.Button m3SwapButton;
        private System.Windows.Forms.ComboBox m3t1p6Hero;
        private System.Windows.Forms.ComboBox m3t1p5Hero;
        private System.Windows.Forms.ComboBox m3t1p4Hero;
        private System.Windows.Forms.ComboBox m3t1p3Hero;
        private System.Windows.Forms.ComboBox m3t1p2Hero;
        private System.Windows.Forms.ComboBox m3t1p1Hero;
        private System.Windows.Forms.ComboBox m3t2p6Hero;
        private System.Windows.Forms.ComboBox m3t2p5Hero;
        private System.Windows.Forms.ComboBox m3t2p4Hero;
        private System.Windows.Forms.ComboBox m3t2p3Hero;
        private System.Windows.Forms.ComboBox m3t2p2Hero;
        private System.Windows.Forms.ComboBox m3t2p1Hero;
        private System.Windows.Forms.Button m3UpdateButton;
        private System.Windows.Forms.Label m3DivisionLabel;
        private System.Windows.Forms.TextBox m3DivisionNumber;
        private System.Windows.Forms.Label m3MessageLabel;
        private System.Windows.Forms.TextBox m3MessageBox;
        private System.Windows.Forms.CheckBox m3currentCheck;
        #endregion

        private System.Windows.Forms.TabPage General_Info;
        private System.Windows.Forms.RadioButton m1t1Neutral;
        private System.Windows.Forms.RadioButton m1t1Defend;
        private System.Windows.Forms.RadioButton m1t1Attack;
        private System.Windows.Forms.RadioButton m1t2Neutral;
        private System.Windows.Forms.RadioButton m1t2Defend;
        private System.Windows.Forms.RadioButton m1t2Attack;
        private System.Windows.Forms.RadioButton m2t2Neutral;
        private System.Windows.Forms.RadioButton m2t2Defend;
        private System.Windows.Forms.RadioButton m2t2Attack;
        private System.Windows.Forms.RadioButton m2t1Neutral;
        private System.Windows.Forms.RadioButton m2t1Defend;
        private System.Windows.Forms.RadioButton m2t1Attack;
        private System.Windows.Forms.RadioButton m3t2Neutral;
        private System.Windows.Forms.RadioButton m3t2Defend;
        private System.Windows.Forms.RadioButton m3t2Attack;
        private System.Windows.Forms.RadioButton m3t1Neutral;
        private System.Windows.Forms.RadioButton m3t1Defend;
        private System.Windows.Forms.RadioButton m3t1Attack;
        private System.Windows.Forms.GroupBox m1t1Side;
        private System.Windows.Forms.GroupBox m1t2Side;
        private System.Windows.Forms.GroupBox m2t2Side;
        private System.Windows.Forms.GroupBox m2t1Side;
        private System.Windows.Forms.GroupBox m3t2Side;
        private System.Windows.Forms.GroupBox m3t1Side;
        private System.Windows.Forms.NumericUpDown m1m5t2Score;
        private System.Windows.Forms.NumericUpDown m1m5t1Score;
        private System.Windows.Forms.NumericUpDown m1m4t2Score;
        private System.Windows.Forms.NumericUpDown m1m4t1Score;
        private System.Windows.Forms.NumericUpDown m1m3t2Score;
        private System.Windows.Forms.NumericUpDown m1m3t1Score;
        private System.Windows.Forms.NumericUpDown m1m2t2Score;
        private System.Windows.Forms.NumericUpDown m1m2t1Score;
        private System.Windows.Forms.NumericUpDown m1m1t2Score;
        private System.Windows.Forms.NumericUpDown m1m1t1Score;
        private System.Windows.Forms.ComboBox m1m5Map;
        private System.Windows.Forms.ComboBox m1m4Map;
        private System.Windows.Forms.ComboBox m1m3Map;
        private System.Windows.Forms.ComboBox m1m2Map;
        private System.Windows.Forms.ComboBox m1m1Map;
        private System.Windows.Forms.Label m1m3Label;
        private System.Windows.Forms.Label m1m4Label;
        private System.Windows.Forms.Label m1m5Label;
        private System.Windows.Forms.Label m1m2Label;
        private System.Windows.Forms.Label m1m1Label;
        private System.Windows.Forms.NumericUpDown m2m5t2Score;
        private System.Windows.Forms.NumericUpDown m2m5t1Score;
        private System.Windows.Forms.NumericUpDown m2m4t2Score;
        private System.Windows.Forms.NumericUpDown m2m4t1Score;
        private System.Windows.Forms.NumericUpDown m2m3t2Score;
        private System.Windows.Forms.NumericUpDown m2m3t1Score;
        private System.Windows.Forms.NumericUpDown m2m2t2Score;
        private System.Windows.Forms.NumericUpDown m2m2t1Score;
        private System.Windows.Forms.NumericUpDown m2m1t2Score;
        private System.Windows.Forms.NumericUpDown m2m1t1Score;
        private System.Windows.Forms.ComboBox m2m5Map;
        private System.Windows.Forms.ComboBox m2m4Map;
        private System.Windows.Forms.ComboBox m2m3Map;
        private System.Windows.Forms.ComboBox m2m2Map;
        private System.Windows.Forms.ComboBox m2m1Map;
        private System.Windows.Forms.Label m2m3Label;
        private System.Windows.Forms.Label m2m4Label;
        private System.Windows.Forms.Label m2m5Label;
        private System.Windows.Forms.Label m2m2Label;
        private System.Windows.Forms.Label m2m1Label;
        private System.Windows.Forms.NumericUpDown m3m5t2Score;
        private System.Windows.Forms.NumericUpDown m3m5t1Score;
        private System.Windows.Forms.NumericUpDown m3m4t2Score;
        private System.Windows.Forms.NumericUpDown m3m4t1Score;
        private System.Windows.Forms.NumericUpDown m3m3t2Score;
        private System.Windows.Forms.NumericUpDown m3m3t1Score;
        private System.Windows.Forms.NumericUpDown m3m2t2Score;
        private System.Windows.Forms.NumericUpDown m3m2t1Score;
        private System.Windows.Forms.NumericUpDown m3m1t2Score;
        private System.Windows.Forms.NumericUpDown m3m1t1Score;
        private System.Windows.Forms.ComboBox m3m5Map;
        private System.Windows.Forms.ComboBox m3m4Map;
        private System.Windows.Forms.ComboBox m3m3Map;
        private System.Windows.Forms.ComboBox m3m2Map;
        private System.Windows.Forms.ComboBox m3m1Map;
        private System.Windows.Forms.Label m3m3Label;
        private System.Windows.Forms.Label m3m4Label;
        private System.Windows.Forms.Label m3m5Label;
        private System.Windows.Forms.Label m3m2Label;
        private System.Windows.Forms.Label m3m1Label;
        private System.Windows.Forms.ComboBox m1t1p4Role;
        private System.Windows.Forms.ComboBox m1t1p3Role;
        private System.Windows.Forms.ComboBox m1t1p2Role;
        private System.Windows.Forms.ComboBox m1t1p1Role;
        private System.Windows.Forms.ComboBox m1t2p6Role;
        private System.Windows.Forms.ComboBox m1t2p5Role;
        private System.Windows.Forms.ComboBox m1t2p4Role;
        private System.Windows.Forms.ComboBox m1t2p3Role;
        private System.Windows.Forms.ComboBox m1t2p2Role;
        private System.Windows.Forms.ComboBox m1t2p1Role;
        private System.Windows.Forms.ComboBox m1t1p6Role;
        private System.Windows.Forms.ComboBox m1t1p5Role;
        private System.Windows.Forms.ComboBox m2t2p6Role;
        private System.Windows.Forms.ComboBox m2t2p5Role;
        private System.Windows.Forms.ComboBox m2t2p4Role;
        private System.Windows.Forms.ComboBox m2t2p3Role;
        private System.Windows.Forms.ComboBox m2t2p2Role;
        private System.Windows.Forms.ComboBox m2t2p1Role;
        private System.Windows.Forms.ComboBox m2t1p6Role;
        private System.Windows.Forms.ComboBox m2t1p5Role;
        private System.Windows.Forms.ComboBox m2t1p4Role;
        private System.Windows.Forms.ComboBox m2t1p3Role;
        private System.Windows.Forms.ComboBox m2t1p2Role;
        private System.Windows.Forms.ComboBox m2t1p1Role;
        private System.Windows.Forms.ComboBox m3t2p6Role;
        private System.Windows.Forms.ComboBox m3t2p5Role;
        private System.Windows.Forms.ComboBox m3t2p4Role;
        private System.Windows.Forms.ComboBox m3t2p3Role;
        private System.Windows.Forms.ComboBox m3t2p2Role;
        private System.Windows.Forms.ComboBox m3t2p1Role;
        private System.Windows.Forms.ComboBox m3t1p6Role;
        private System.Windows.Forms.ComboBox m3t1p5Role;
        private System.Windows.Forms.ComboBox m3t1p4Role;
        private System.Windows.Forms.ComboBox m3t1p3Role;
        private System.Windows.Forms.ComboBox m3t1p2Role;
        private System.Windows.Forms.ComboBox m3t1p1Role;
        private System.Windows.Forms.TextBox m1t2SR;
        private System.Windows.Forms.TextBox m1t1SR;
        private System.Windows.Forms.TextBox m2t2SR;
        private System.Windows.Forms.TextBox m2t1SR;
        private System.Windows.Forms.TextBox m3t2SR;
        private System.Windows.Forms.TextBox m3t1SR;
    }
}

