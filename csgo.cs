using System;
using hazedumper;
using Memory32;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CSGO
{
    
    public class csgo
    {
        Process proc;
        IntPtr ModuleBase, lp_ptr;
        mem m = new mem();
        int health, crossId, flags;
        public void GetInformation()
        {
            proc = m.GetProcess("csgo");

            if(proc == null)
            {
                MessageBox.Show("Game not Open!");
                Application.Exit();
            }

            ModuleBase = m.GetModuleBase("client.dll");
            lp_ptr = m.ReadPointer(ModuleBase, hazedumper.signatures.dwLocalPlayer);

        }

        public void ReadHealth() 
        {
            health = BitConverter.ToInt32(m.ReadBytes(lp_ptr, hazedumper.netvars.m_iHealth, 4), 0);
            MessageBox.Show(Convert.ToString(health));
        }


        public void Triggerbot() 
        {
            crossId = BitConverter.ToInt32(m.ReadBytes(lp_ptr, hazedumper.netvars.m_iCrosshairId, 4), 0);

            if(crossId > 0) { m.WriteBytes(ModuleBase, hazedumper.signatures.dwForceAttack, BitConverter.GetBytes(6)); }
        }

        public void FovChanger(int Fov)
        {
            m.WriteBytes(lp_ptr, hazedumper.netvars.m_iDefaultFOV, BitConverter.GetBytes(Fov));
        }
        public void iFovChanger(int iFov)
        {
            m.WriteBytes(lp_ptr, hazedumper.netvars.m_iFOV, BitConverter.GetBytes(iFov));
        }

        public void EnableThirdPerson()
        {
            m.WriteBytes(lp_ptr, hazedumper.netvars.m_iObserverMode, BitConverter.GetBytes(1));
        }

        public void DisableThirdPerson()
        {
            m.WriteBytes(lp_ptr, hazedumper.netvars.m_iObserverMode, BitConverter.GetBytes(0));
        }

        public void Bhop()
        {
            flags = BitConverter.ToInt32(m.ReadBytes(lp_ptr, hazedumper.netvars.m_fFlags, 4), 0);

            if(flags == 257 || flags == 263)
            {
                m.WriteBytes(ModuleBase, hazedumper.signatures.dwForceJump, BitConverter.GetBytes(5));
                Thread.Sleep(1);
                m.WriteBytes(ModuleBase, hazedumper.signatures.dwForceJump, BitConverter.GetBytes(4));
            }
        }

        public void AntiFlash()
        {
            m.WriteBytes(lp_ptr, hazedumper.netvars.m_flFlashDuration, BitConverter.GetBytes(0));
        }
    }
}