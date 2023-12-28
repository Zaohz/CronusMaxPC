namespace CronusMaxPC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ManageInputs = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReloadNacDelay = new System.Windows.Forms.TextBox();
            this.ReloadNacKey = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EnablePresets = new System.Windows.Forms.CheckBox();
            this.bruh = new System.Windows.Forms.TabPage();
            this.EnableSequence = new System.Windows.Forms.CheckBox();
            this.Delay1 = new System.Windows.Forms.TextBox();
            this.Action1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LoadKeyBinds = new System.Windows.Forms.Button();
            this.SaveKeyBinds = new System.Windows.Forms.Button();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.Tacticalkey = new System.Windows.Forms.ComboBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.Lethalkey = new System.Windows.Forms.ComboBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.Shootkey = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.AimKey = new System.Windows.Forms.ComboBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.RightKey = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.LeftKey = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.BackwardKey = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.ForwardKey = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.MeleeKey = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.SprintKey = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.JumpKey = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CrouchKey = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SwapWeaponKey = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReloadKey = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetMaxFPSMW2 = new System.Windows.Forms.Button();
            this.MW2MaxFPSVal = new System.Windows.Forms.TextBox();
            this.ManageCustomInputs = new System.Windows.Forms.Timer(this.components);
            this.Action2 = new System.Windows.Forms.ComboBox();
            this.ActionBind = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.bruh.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageInputs
            // 
            this.ManageInputs.Interval = 1;
            this.ManageInputs.Tick += new System.EventHandler(this.ManageInputs_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReloadNacDelay);
            this.groupBox2.Controls.Add(this.ReloadNacKey);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reload Nac";
            // 
            // ReloadNacDelay
            // 
            this.ReloadNacDelay.Location = new System.Drawing.Point(6, 46);
            this.ReloadNacDelay.Name = "ReloadNacDelay";
            this.ReloadNacDelay.Size = new System.Drawing.Size(104, 20);
            this.ReloadNacDelay.TabIndex = 1;
            this.ReloadNacDelay.Text = "Delay In MS";
            // 
            // ReloadNacKey
            // 
            this.ReloadNacKey.FormattingEnabled = true;
            this.ReloadNacKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "VK_LBUTTON",
            "VK_RBUTTON",
            "VK_MBUTTON",
            "VK_XBUTTON1",
            "VK_XBUTTON2",
            "***FUNCTION KEYS***",
            "VK_F1",
            "VK_F2",
            "VK_F3",
            "VK_F4",
            "VK_F5",
            "VK_F6",
            "VK_F7",
            "VK_F8",
            "VK_F9",
            "VK_F10",
            "VK_F11",
            "VK_F12",
            "***ALPHABETIC KEYS***",
            "VK_A",
            "VK_B",
            "VK_C",
            "VK_D",
            "VK_E",
            "VK_F",
            "VK_G",
            "VK_H",
            "VK_I",
            "VK_J",
            "VK_K",
            "VK_L",
            "VK_M",
            "VK_N",
            "VK_O",
            "VK_P",
            "VK_Q",
            "VK_R",
            "VK_S",
            "VK_T",
            "VK_U",
            "VK_V",
            "VK_W",
            "VK_X",
            "VK_Y",
            "VK_Z",
            "***MODIFIER KEYS***",
            "VK_LEFT",
            "VK_UP",
            "VK_RIGHT",
            "VK_DOWN",
            "VK_HOME",
            "VK_END",
            "VK_PRIOR",
            "VK_NEXT",
            "VK_INSERT",
            "VK_DELETE",
            "***SPECIAL KEYS***",
            "VK_ESCAPE",
            "VK_SPACE",
            "VK_RETURN",
            "VK_TAB",
            "VK_BACK",
            "***NUMERIC KEYPAD***",
            "VK_NUMLOCK",
            "VK_DIVIDE",
            "VK_MULTIPLY",
            "VK_SUBTRACT",
            "VK_ADD",
            "VK_DECIMAL",
            "VK_NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VK_VOLUME_MUTE",
            "VK_VOLUME_DOWN",
            "VK_VOLUME_UP",
            "VK_MEDIA_NEXT_TRACK",
            "VK_MEDIA_PREV_TRACK",
            "VK_MEDIA_STOP",
            "VK_MEDIA_PLAY_PAUSE"});
            this.ReloadNacKey.Location = new System.Drawing.Point(6, 19);
            this.ReloadNacKey.Name = "ReloadNacKey";
            this.ReloadNacKey.Size = new System.Drawing.Size(104, 21);
            this.ReloadNacKey.TabIndex = 1;
            this.ReloadNacKey.Text = "Select a Key";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.bruh);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-5, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 455);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.EnablePresets);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Presets";
            // 
            // EnablePresets
            // 
            this.EnablePresets.AutoSize = true;
            this.EnablePresets.Location = new System.Drawing.Point(699, 409);
            this.EnablePresets.Name = "EnablePresets";
            this.EnablePresets.Size = new System.Drawing.Size(97, 17);
            this.EnablePresets.TabIndex = 3;
            this.EnablePresets.Text = "Enable Presets";
            this.EnablePresets.UseVisualStyleBackColor = true;
            this.EnablePresets.CheckedChanged += new System.EventHandler(this.EnablePresets_CheckedChanged);
            // 
            // bruh
            // 
            this.bruh.BackColor = System.Drawing.Color.DimGray;
            this.bruh.Controls.Add(this.ActionBind);
            this.bruh.Controls.Add(this.Action2);
            this.bruh.Controls.Add(this.EnableSequence);
            this.bruh.Controls.Add(this.Delay1);
            this.bruh.Controls.Add(this.Action1);
            this.bruh.Location = new System.Drawing.Point(4, 22);
            this.bruh.Name = "bruh";
            this.bruh.Padding = new System.Windows.Forms.Padding(3);
            this.bruh.Size = new System.Drawing.Size(802, 429);
            this.bruh.TabIndex = 1;
            this.bruh.Text = "Sequence";
            // 
            // EnableSequence
            // 
            this.EnableSequence.AutoSize = true;
            this.EnableSequence.Location = new System.Drawing.Point(691, 409);
            this.EnableSequence.Name = "EnableSequence";
            this.EnableSequence.Size = new System.Drawing.Size(111, 17);
            this.EnableSequence.TabIndex = 5;
            this.EnableSequence.Text = "Enable Sequence";
            this.EnableSequence.UseVisualStyleBackColor = true;
            this.EnableSequence.CheckedChanged += new System.EventHandler(this.EnableSequence_CheckedChanged);
            // 
            // Delay1
            // 
            this.Delay1.Location = new System.Drawing.Point(6, 33);
            this.Delay1.Name = "Delay1";
            this.Delay1.Size = new System.Drawing.Size(104, 20);
            this.Delay1.TabIndex = 4;
            this.Delay1.Text = "Delay In MS";
            // 
            // Action1
            // 
            this.Action1.FormattingEnabled = true;
            this.Action1.Items.AddRange(new object[] {
            "Reload",
            "SwapWeapon",
            "Crouch",
            "Jump",
            "Lethal",
            "Tactical",
            "Forward",
            "Backward",
            "Left",
            "Right",
            "Sprint",
            "Melee",
            "Shoot",
            "Aim"});
            this.Action1.Location = new System.Drawing.Point(6, 6);
            this.Action1.Name = "Action1";
            this.Action1.Size = new System.Drawing.Size(104, 21);
            this.Action1.TabIndex = 2;
            this.Action1.Text = "Select Action";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.LoadKeyBinds);
            this.tabPage3.Controls.Add(this.SaveKeyBinds);
            this.tabPage3.Controls.Add(this.groupBox16);
            this.tabPage3.Controls.Add(this.groupBox15);
            this.tabPage3.Controls.Add(this.groupBox14);
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Controls.Add(this.groupBox12);
            this.tabPage3.Controls.Add(this.groupBox11);
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(802, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "KeyBinds";
            // 
            // LoadKeyBinds
            // 
            this.LoadKeyBinds.Location = new System.Drawing.Point(94, 398);
            this.LoadKeyBinds.Name = "LoadKeyBinds";
            this.LoadKeyBinds.Size = new System.Drawing.Size(75, 25);
            this.LoadKeyBinds.TabIndex = 11;
            this.LoadKeyBinds.Text = "Load Binds";
            this.LoadKeyBinds.UseVisualStyleBackColor = true;
            // 
            // SaveKeyBinds
            // 
            this.SaveKeyBinds.Location = new System.Drawing.Point(13, 398);
            this.SaveKeyBinds.Name = "SaveKeyBinds";
            this.SaveKeyBinds.Size = new System.Drawing.Size(75, 25);
            this.SaveKeyBinds.TabIndex = 10;
            this.SaveKeyBinds.Text = "Save Binds";
            this.SaveKeyBinds.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.Tacticalkey);
            this.groupBox16.Location = new System.Drawing.Point(129, 118);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(117, 50);
            this.groupBox16.TabIndex = 6;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Tactical";
            // 
            // Tacticalkey
            // 
            this.Tacticalkey.FormattingEnabled = true;
            this.Tacticalkey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.Tacticalkey.Location = new System.Drawing.Point(6, 19);
            this.Tacticalkey.Name = "Tacticalkey";
            this.Tacticalkey.Size = new System.Drawing.Size(104, 21);
            this.Tacticalkey.TabIndex = 1;
            this.Tacticalkey.Text = "Q";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.Lethalkey);
            this.groupBox15.Location = new System.Drawing.Point(6, 118);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(117, 50);
            this.groupBox15.TabIndex = 5;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Lethal";
            // 
            // Lethalkey
            // 
            this.Lethalkey.FormattingEnabled = true;
            this.Lethalkey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.Lethalkey.Location = new System.Drawing.Point(6, 19);
            this.Lethalkey.Name = "Lethalkey";
            this.Lethalkey.Size = new System.Drawing.Size(104, 21);
            this.Lethalkey.TabIndex = 1;
            this.Lethalkey.Text = "G";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.Shootkey);
            this.groupBox14.Location = new System.Drawing.Point(498, 62);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(117, 50);
            this.groupBox14.TabIndex = 9;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Shoot";
            // 
            // Shootkey
            // 
            this.Shootkey.FormattingEnabled = true;
            this.Shootkey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.Shootkey.Location = new System.Drawing.Point(6, 19);
            this.Shootkey.Name = "Shootkey";
            this.Shootkey.Size = new System.Drawing.Size(104, 21);
            this.Shootkey.TabIndex = 1;
            this.Shootkey.Text = "LBUTTON";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.AimKey);
            this.groupBox13.Location = new System.Drawing.Point(621, 62);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(117, 50);
            this.groupBox13.TabIndex = 8;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Aim";
            // 
            // AimKey
            // 
            this.AimKey.FormattingEnabled = true;
            this.AimKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.AimKey.Location = new System.Drawing.Point(6, 19);
            this.AimKey.Name = "AimKey";
            this.AimKey.Size = new System.Drawing.Size(104, 21);
            this.AimKey.TabIndex = 1;
            this.AimKey.Text = "RBUTTON";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.RightKey);
            this.groupBox12.Location = new System.Drawing.Point(375, 62);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(117, 50);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Right";
            // 
            // RightKey
            // 
            this.RightKey.FormattingEnabled = true;
            this.RightKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.RightKey.Location = new System.Drawing.Point(6, 19);
            this.RightKey.Name = "RightKey";
            this.RightKey.Size = new System.Drawing.Size(104, 21);
            this.RightKey.TabIndex = 1;
            this.RightKey.Text = "D";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.LeftKey);
            this.groupBox11.Location = new System.Drawing.Point(252, 62);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(117, 50);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Left";
            // 
            // LeftKey
            // 
            this.LeftKey.FormattingEnabled = true;
            this.LeftKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.LeftKey.Location = new System.Drawing.Point(6, 19);
            this.LeftKey.Name = "LeftKey";
            this.LeftKey.Size = new System.Drawing.Size(104, 21);
            this.LeftKey.TabIndex = 1;
            this.LeftKey.Text = "A";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.BackwardKey);
            this.groupBox10.Location = new System.Drawing.Point(129, 62);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(117, 50);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Backward";
            // 
            // BackwardKey
            // 
            this.BackwardKey.FormattingEnabled = true;
            this.BackwardKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.BackwardKey.Location = new System.Drawing.Point(6, 19);
            this.BackwardKey.Name = "BackwardKey";
            this.BackwardKey.Size = new System.Drawing.Size(104, 21);
            this.BackwardKey.TabIndex = 1;
            this.BackwardKey.Text = "S";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.ForwardKey);
            this.groupBox9.Location = new System.Drawing.Point(6, 62);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(117, 50);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Forward";
            // 
            // ForwardKey
            // 
            this.ForwardKey.FormattingEnabled = true;
            this.ForwardKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.ForwardKey.Location = new System.Drawing.Point(6, 19);
            this.ForwardKey.Name = "ForwardKey";
            this.ForwardKey.Size = new System.Drawing.Size(104, 21);
            this.ForwardKey.TabIndex = 1;
            this.ForwardKey.Text = "W";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.MeleeKey);
            this.groupBox8.Location = new System.Drawing.Point(621, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(117, 50);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Melee";
            // 
            // MeleeKey
            // 
            this.MeleeKey.FormattingEnabled = true;
            this.MeleeKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.MeleeKey.Location = new System.Drawing.Point(6, 19);
            this.MeleeKey.Name = "MeleeKey";
            this.MeleeKey.Size = new System.Drawing.Size(104, 21);
            this.MeleeKey.TabIndex = 1;
            this.MeleeKey.Text = "E";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.SprintKey);
            this.groupBox7.Location = new System.Drawing.Point(498, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(117, 50);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sprint";
            // 
            // SprintKey
            // 
            this.SprintKey.FormattingEnabled = true;
            this.SprintKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.SprintKey.Location = new System.Drawing.Point(6, 19);
            this.SprintKey.Name = "SprintKey";
            this.SprintKey.Size = new System.Drawing.Size(104, 21);
            this.SprintKey.TabIndex = 1;
            this.SprintKey.Text = "LSHIFT";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.JumpKey);
            this.groupBox6.Location = new System.Drawing.Point(375, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(117, 50);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Jump";
            // 
            // JumpKey
            // 
            this.JumpKey.FormattingEnabled = true;
            this.JumpKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.JumpKey.Location = new System.Drawing.Point(6, 19);
            this.JumpKey.Name = "JumpKey";
            this.JumpKey.Size = new System.Drawing.Size(104, 21);
            this.JumpKey.TabIndex = 1;
            this.JumpKey.Text = "SPACE";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CrouchKey);
            this.groupBox5.Location = new System.Drawing.Point(252, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(117, 50);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Crouch";
            // 
            // CrouchKey
            // 
            this.CrouchKey.FormattingEnabled = true;
            this.CrouchKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.CrouchKey.Location = new System.Drawing.Point(6, 19);
            this.CrouchKey.Name = "CrouchKey";
            this.CrouchKey.Size = new System.Drawing.Size(104, 21);
            this.CrouchKey.TabIndex = 1;
            this.CrouchKey.Text = "C";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SwapWeaponKey);
            this.groupBox4.Location = new System.Drawing.Point(129, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 50);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Swap Weapon";
            // 
            // SwapWeaponKey
            // 
            this.SwapWeaponKey.FormattingEnabled = true;
            this.SwapWeaponKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.SwapWeaponKey.Location = new System.Drawing.Point(6, 19);
            this.SwapWeaponKey.Name = "SwapWeaponKey";
            this.SwapWeaponKey.Size = new System.Drawing.Size(104, 21);
            this.SwapWeaponKey.TabIndex = 1;
            this.SwapWeaponKey.Text = "1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReloadKey);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reload";
            // 
            // ReloadKey
            // 
            this.ReloadKey.FormattingEnabled = true;
            this.ReloadKey.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "LBUTTON",
            "RBUTTON",
            "MBUTTON",
            "XBUTTON1",
            "XBUTTON2",
            "***FUNCTION KEYS***",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "***ALPHABETIC KEYS***",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "***MODIFIER KEYS***",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "HOME",
            "END",
            "PRIOR",
            "NEXT",
            "INSERT",
            "DELETE",
            "***SPECIAL KEYS***",
            "ESCAPE",
            "SPACE",
            "RETURN",
            "TAB",
            "BACK",
            "LSHIFT",
            "***NUMERIC KEYPAD***",
            "NUMLOCK",
            "DIVIDE",
            "MULTIPLY",
            "SUBTRACT",
            "ADD",
            "DECIMAL",
            "NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VOLUME_MUTE",
            "VOLUME_DOWN",
            "VOLUME_UP",
            "MEDIA_NEXT_TRACK",
            "MEDIA_PREV_TRACK",
            "MEDIA_STOP",
            "MEDIA_PLAY_PAUSE"});
            this.ReloadKey.Location = new System.Drawing.Point(6, 19);
            this.ReloadKey.Name = "ReloadKey";
            this.ReloadKey.Size = new System.Drawing.Size(104, 21);
            this.ReloadKey.TabIndex = 1;
            this.ReloadKey.Text = "R";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DimGray;
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(802, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "FPS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetMaxFPSMW2);
            this.groupBox1.Controls.Add(this.MW2MaxFPSVal);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MW2";
            // 
            // SetMaxFPSMW2
            // 
            this.SetMaxFPSMW2.Location = new System.Drawing.Point(7, 45);
            this.SetMaxFPSMW2.Name = "SetMaxFPSMW2";
            this.SetMaxFPSMW2.Size = new System.Drawing.Size(75, 25);
            this.SetMaxFPSMW2.TabIndex = 1;
            this.SetMaxFPSMW2.Text = "Set FPS";
            this.SetMaxFPSMW2.UseVisualStyleBackColor = true;
            this.SetMaxFPSMW2.Click += new System.EventHandler(this.SetMaxFPSMW2_Click);
            // 
            // MW2MaxFPSVal
            // 
            this.MW2MaxFPSVal.Location = new System.Drawing.Point(7, 19);
            this.MW2MaxFPSVal.Name = "MW2MaxFPSVal";
            this.MW2MaxFPSVal.Size = new System.Drawing.Size(75, 20);
            this.MW2MaxFPSVal.TabIndex = 1;
            // 
            // ManageCustomInputs
            // 
            this.ManageCustomInputs.Interval = 1;
            this.ManageCustomInputs.Tick += new System.EventHandler(this.ManageCustomInputs_Tick);
            // 
            // Action2
            // 
            this.Action2.FormattingEnabled = true;
            this.Action2.Items.AddRange(new object[] {
            "Reload",
            "SwapWeapon",
            "Crouch",
            "Jump",
            "Lethal",
            "Tactical",
            "Forward",
            "Backward",
            "Left",
            "Right",
            "Sprint",
            "Melee",
            "Shoot",
            "Aim"});
            this.Action2.Location = new System.Drawing.Point(6, 59);
            this.Action2.Name = "Action2";
            this.Action2.Size = new System.Drawing.Size(104, 21);
            this.Action2.TabIndex = 6;
            this.Action2.Text = "Select Action";
            // 
            // ActionBind
            // 
            this.ActionBind.FormattingEnabled = true;
            this.ActionBind.Items.AddRange(new object[] {
            "***MOUSE BUTTONS***",
            "VK_LBUTTON",
            "VK_RBUTTON",
            "VK_MBUTTON",
            "VK_XBUTTON1",
            "VK_XBUTTON2",
            "***FUNCTION KEYS***",
            "VK_F1",
            "VK_F2",
            "VK_F3",
            "VK_F4",
            "VK_F5",
            "VK_F6",
            "VK_F7",
            "VK_F8",
            "VK_F9",
            "VK_F10",
            "VK_F11",
            "VK_F12",
            "***ALPHABETIC KEYS***",
            "VK_A",
            "VK_B",
            "VK_C",
            "VK_D",
            "VK_E",
            "VK_F",
            "VK_G",
            "VK_H",
            "VK_I",
            "VK_J",
            "VK_K",
            "VK_L",
            "VK_M",
            "VK_N",
            "VK_O",
            "VK_P",
            "VK_Q",
            "VK_R",
            "VK_S",
            "VK_T",
            "VK_U",
            "VK_V",
            "VK_W",
            "VK_X",
            "VK_Y",
            "VK_Z",
            "***MODIFIER KEYS***",
            "VK_LEFT",
            "VK_UP",
            "VK_RIGHT",
            "VK_DOWN",
            "VK_HOME",
            "VK_END",
            "VK_PRIOR",
            "VK_NEXT",
            "VK_INSERT",
            "VK_DELETE",
            "***SPECIAL KEYS***",
            "VK_ESCAPE",
            "VK_SPACE",
            "VK_RETURN",
            "VK_TAB",
            "VK_BACK",
            "***NUMERIC KEYPAD***",
            "VK_NUMLOCK",
            "VK_DIVIDE",
            "VK_MULTIPLY",
            "VK_SUBTRACT",
            "VK_ADD",
            "VK_DECIMAL",
            "VK_NUMPAD_ENTER",
            "***MEDIA KEYS***",
            "VK_VOLUME_MUTE",
            "VK_VOLUME_DOWN",
            "VK_VOLUME_UP",
            "VK_MEDIA_NEXT_TRACK",
            "VK_MEDIA_PREV_TRACK",
            "VK_MEDIA_STOP",
            "VK_MEDIA_PLAY_PAUSE"});
            this.ActionBind.Location = new System.Drawing.Point(691, 382);
            this.ActionBind.Name = "ActionBind";
            this.ActionBind.Size = new System.Drawing.Size(105, 21);
            this.ActionBind.TabIndex = 7;
            this.ActionBind.Text = "Select Bind";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CronusMaximus for PC by Zaoh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.bruh.ResumeLayout(false);
            this.bruh.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer ManageInputs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ReloadNacDelay;
        private System.Windows.Forms.ComboBox ReloadNacKey;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage bruh;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetMaxFPSMW2;
        private System.Windows.Forms.TextBox MW2MaxFPSVal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ReloadKey;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox SwapWeaponKey;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox CrouchKey;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox SprintKey;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox JumpKey;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox MeleeKey;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox ForwardKey;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox AimKey;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ComboBox RightKey;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox LeftKey;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox BackwardKey;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ComboBox Shootkey;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.ComboBox Lethalkey;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ComboBox Tacticalkey;
        private System.Windows.Forms.Button LoadKeyBinds;
        private System.Windows.Forms.Button SaveKeyBinds;
        private System.Windows.Forms.ComboBox Action1;
        private System.Windows.Forms.TextBox Delay1;
        private System.Windows.Forms.CheckBox EnablePresets;
        private System.Windows.Forms.CheckBox EnableSequence;
        private System.Windows.Forms.Timer ManageCustomInputs;
        private System.Windows.Forms.ComboBox Action2;
        private System.Windows.Forms.ComboBox ActionBind;
    }
}

