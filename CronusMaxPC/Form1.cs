using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;
using System.Reflection;
using System.Net.NetworkInformation;
using Memory;

namespace CronusMaxPC
{
    public partial class Form1 : Form
    {
        InputSimulator key = new InputSimulator();
        Mem m = new Mem();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void ManageReload()
        {
            string getKey;
            getKey = ReloadNacKey.Text;
            int reloadDelay;
            if (int.TryParse(ReloadNacDelay.Text, out reloadDelay))
                if (Enum.TryParse(getKey, out VirtualKeyCode keyCode))
                {
                    var reloadNac = key.InputDeviceState.IsKeyDown(keyCode);
                    if (reloadNac)
                    {
                        SendKeys.Send(Reload);
                        Thread.Sleep(reloadDelay);
                        SendKeys.Send(SwapWeapon);
                    }
                }
        }

        string Reload;
        string SwapWeapon;
        string Crouch;
        string Jump;
        string Lethal;
        string Tactical;
        string Forward;
        string Backward;
        string Left;
        string Right;
        string Sprint;
     //   string Melee;
        string Shoot;
        string Aim;

        public void UpdateBinds()
        {
            Reload = ReloadKey.Text;
            SwapWeapon = SwapWeaponKey.Text;
            Crouch = CrouchKey.Text;
            Jump = JumpKey.Text;
            Sprint = SprintKey.Text;
           // Melee = MeleeKey.Text;
            Forward = ForwardKey.Text;
            Backward = BackwardKey.Text;
            Left = LeftKey.Text;
            Right = RightKey.Text;
            Aim = AimKey.Text;
            Shoot = Shootkey.Text;
            Lethal = Lethalkey.Text;
            Tactical = Tacticalkey.Text;
        }
        
        private void ManageInputs_Tick(object sender, EventArgs e)
        {
           ManageReload();

           UpdateBinds();
        }

        private void SetMaxFPSMW2_Click(object sender, EventArgs e)
        {
            m.OpenProcess("iw4mp.exe");
            Thread.Sleep(5);
            m.WriteMemory("1B90730,C", "Int", MW2MaxFPSVal.Text);
        }

        private void EnablePresets_CheckedChanged(object sender, EventArgs e)
        {
            if (EnablePresets.Checked)
            {
                ManageInputs.Start();
            }
            else
            {
                ManageInputs.Stop();
            }
        }

        private void EnableSequence_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableSequence.Checked)
            {
                ManageCustomInputs.Start();
            }
            else
            { 
                ManageCustomInputs.Stop();
            }
        }

        private void ManageSqnceBinds()
        {
            string getKey;
            getKey = ActionBind.Text;
            if (Enum.TryParse(getKey, out VirtualKeyCode keyCode))
                {
                    var startSequence = key.InputDeviceState.IsKeyDown(keyCode);
                    if (startSequence)
                    {
                        SendKeys.Send(Action1.Text);
                        Thread.Sleep(int.Parse(Delay1.Text));
                        SendKeys.Send(Action2.Text);
                    }
                }
        }

        private void ManageCustomInputs_Tick(object sender, EventArgs e)
        {
            UpdateBinds();

            ManageSqnceBinds();
        }
    }
}
