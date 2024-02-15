using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace teleporter
{
    public class PS3
    {
        public static uint processID;
        public static uint[] processIDs;
        private static Boolean connection;
        public static int Init()
        {
            processID = GetProcessID();
            return 0;
        }
        private static uint GetProcessID()
        {
            uint[] numArray;
            PS3TMAPI.GetProcessList(0, out numArray);
            return numArray[0];
        }
        public static void InitConnection()
        {
            if (!connection)
            {
                ConnectAttach();
                connection = true;
            }
            else if (connection)
            {
                DialogResult result = MessageBox.Show("PS3 Already Connected and Attached!\nDo you want to Reconnect?", "Reconnect?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ConnectAttach();
                }
            }
            else
            {
                MessageBox.Show("PS3 Connection or Process Attach Failed!", "PS3 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection = false;
            }
        }
        public static void ConnectAttach()
        {
            PS3TMAPI.InitTargetComms();
            PS3TMAPI.Connect(0, null);
            PS3TMAPI.GetProcessList(0, out processIDs);
            ulong uProcess = processIDs[0];
            processID = Convert.ToUInt32(uProcess);
            PS3TMAPI.ProcessAttach(0, PS3TMAPI.UnitType.PPU, processID);
            PS3TMAPI.ProcessContinue(0, processID);
            Init();
        }
        public static void SetMemory(uint address, byte[] memory)
        {
            PS3TMAPI.ProcessSetMemory(0, PS3TMAPI.UnitType.PPU, processID, 0L, (ulong)address, memory);
        }
        public static byte[] GetMemory(uint address, byte[] length)
        {
            byte[] buffer = length;
            PS3TMAPI.ProcessGetMemory(0, PS3TMAPI.UnitType.PPU, processID, 0L, (ulong)address, ref buffer);
            return buffer;
        }
        public static byte[] GetMemoryInt(uint address, int length)
        {
            byte[] buffer = new byte[length];
            PS3TMAPI.ProcessGetMemory(0, PS3TMAPI.UnitType.PPU, processID, 0L, (ulong)address, ref buffer);
            return buffer;
        }
    }
}
