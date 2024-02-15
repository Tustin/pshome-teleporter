using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using PS3Lib;
namespace teleporter
{
    public partial class Form1 : Form
    {
        CCAPI CCAPI = new CCAPI();
        uint address = 0;
        uint gravity = 0;
        string API = "";
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\PsHomeCentral\\";
        string name = "";
        public Form1()
        {
            InitializeComponent();
        }
        # region container
        byte[] infoOn = new byte[] 
        {
            0x4A, 0x65, 0x74, 0x50, 0x61, 0x63, 0x6B, 0x20, 0x3A, 0x3A, 0x20, 0x45, 0x4E, 0x41, 0x42, 0x4C, 0x45, 0x44, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x00, 0x00, 0x00, 0x00, 0x72, 0x73, 0x2E, 0x00, 0x00, 0x00, 0x43, 0x6F, 0x64, 0x65, 0x64, 0x20, 0x42, 0x79, 0x3A, 0x20, 0x54, 0x75, 0x73, 0x74, 0x69, 0x6E, 0x00, 0x00, 0x00, 0x00, 0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x41, 0x63, 0x74, 0x69, 0x76, 0x69, 0x74, 0x79, 0x20, 0x63, 0x68, 0x61, 0x6E, 0x6E, 0x65, 0x6C, 0x20, 0x68, 0x61, 0x73, 0x20, 0x25, 0x64, 0x20, 0x6D, 0x65, 0x6D, 0x62, 0x65, 0x72, 0x73, 0x2E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4F, 0x66, 0x66, 0x73, 0x65, 0x74, 0x73, 0x3A, 0x20, 0x78, 0x49, 0x43, 0x33, 0x44, 0x00, 0x00, 0x6E, 0x65, 0x6C, 0x20, 0x61, 0x76, 0x61, 0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x00, 0x00, 0x0A, 0x50, 0x73, 0x48, 0x6F, 0x6D, 0x65, 0x43, 0x65, 0x6E, 0x74, 0x72, 0x61, 0x6C, 0x2E, 0x6E, 0x65, 0x74, 0x00, 0x00, 0x20, 0x20, 0x6D, 0x62
        };
        byte[] infoOff = new byte[] 
        {
            0x4A, 0x65, 0x74, 0x50, 0x61, 0x63, 0x6B, 0x20, 0x3A, 0x3A, 0x20, 0x44, 0x49, 0x53, 0x41, 0x42, 0x4C, 0x45, 0x44, 0x00, 0x00, 0x00, 0x00, 0x00, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x2D, 0x00, 0x00, 0x00, 0x00, 0x72, 0x73, 0x2E, 0x00, 0x00, 0x00, 0x43, 0x6F, 0x64, 0x65, 0x64, 0x20, 0x42, 0x79, 0x3A, 0x20, 0x54, 0x75, 0x73, 0x74, 0x69, 0x6E, 0x00, 0x00, 0x00, 0x00, 0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x41, 0x63, 0x74, 0x69, 0x76, 0x69, 0x74, 0x79, 0x20, 0x63, 0x68, 0x61, 0x6E, 0x6E, 0x65, 0x6C, 0x20, 0x68, 0x61, 0x73, 0x20, 0x25, 0x64, 0x20, 0x6D, 0x65, 0x6D, 0x62, 0x65, 0x72, 0x73, 0x2E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4F, 0x66, 0x66, 0x73, 0x65, 0x74, 0x73, 0x3A, 0x20, 0x78, 0x49, 0x43, 0x33, 0x44, 0x00, 0x00, 0x6E, 0x65, 0x6C, 0x20, 0x61, 0x76, 0x61, 0x69, 0x6C, 0x61, 0x62, 0x6C, 0x65, 0x00, 0x00, 0x00, 0x0A, 0x50, 0x73, 0x48, 0x6F, 0x6D, 0x65, 0x43, 0x65, 0x6E, 0x74, 0x72, 0x61, 0x6C, 0x2E, 0x6E, 0x65, 0x74, 0x00, 0x00, 0x20, 0x20, 0x6D, 0x62
        };
        #endregion
        void FindAddress()
        {
            if (API == "TMAPI")
            {
                byte[] pointer = PS3.GetMemory(0x104F7320, new byte[4]);
                Array.Reverse(pointer);
                address = BitConverter.ToUInt32(pointer, 0) + 0x18C0;
            }
            else if (API == "CCAPI")
            {
                byte[] pointer = CCAPI.GetBytes(0x104F7320, 4);
                Array.Reverse(pointer);
                address = BitConverter.ToUInt32(pointer, 0) + 0x18C0;
            }
        }
        void XYZ()
        {
            if (API == "TMAPI")
            {
                if (address == 0)
                {
                    MessageBox.Show("Unable to grab coords\nError: Address is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    byte[] buffer = new byte[4];
                    // Getting X coordinate
                    byte[] x = PS3.GetMemory(address, buffer);
                    Array.Reverse(x);
                    float xcoord = BitConverter.ToSingle(x, 0);
                    xbox.Text = xcoord.ToString();
                    // Getting Y coordinate
                    byte[] y = PS3.GetMemory(address + 4, buffer);
                    Array.Reverse(y);
                    float ycoord = BitConverter.ToSingle(y, 0);
                    ybox.Text = ycoord.ToString();
                    // Getting Z coordinate
                    byte[] z = PS3.GetMemory(address + 8, buffer);
                    Array.Reverse(z);
                    float zcoord = BitConverter.ToSingle(z, 0);
                    zbox.Text = zcoord.ToString();
                }
            }
            else if (API == "CCAPI")
            {
                if (address == 0)
                {
                    MessageBox.Show("Unable to grab coords\nError: Address is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    uint buffer = 4;
                    // Getting X coordinate
                    byte[] x = CCAPI.GetBytes(address, buffer);
                    Array.Reverse(x);
                    float xcoord = BitConverter.ToSingle(x, 0);
                    xbox.Text = xcoord.ToString();
                    // Getting Y coordinate
                    byte[] y = CCAPI.GetBytes(address + 4, buffer);
                    Array.Reverse(y);
                    float ycoord = BitConverter.ToSingle(y, 0);
                    ybox.Text = ycoord.ToString();
                    // Getting Z coordinate
                    byte[] z = CCAPI.GetBytes(address + 8, buffer);
                    Array.Reverse(z);
                    float zcoord = BitConverter.ToSingle(z, 0);
                    zbox.Text = zcoord.ToString();
                }
            }

        }
        void SetCoords()
        {
            float x = Convert.ToSingle(xbox.Text);
            float y = Convert.ToSingle(ybox.Text);
            float z = Convert.ToSingle(zbox.Text);

            byte[] newx = BitConverter.GetBytes(x);
            Array.Reverse(newx);

            byte[] newy = BitConverter.GetBytes(y);
            Array.Reverse(newy);

            byte[] newz = BitConverter.GetBytes(z);
            Array.Reverse(newz);
            if (API == "TMAPI")
            {
                PS3.SetMemory(address, newx);
                PS3.SetMemory(address + 4, newy);
                PS3.SetMemory(address + 8, newz);
            }
            if (API == "CCAPI")
            {
                CCAPI.SetMemory(address, newx);
                CCAPI.SetMemory(address + 4, newy);
                CCAPI.SetMemory(address + 8, newz);
            }
        }
        void GetSever()
        {
            if (API == "TMAPI")
            {
                byte[] hexname = PS3.GetMemory(0x10155858, new byte[20]);
                string name = Encoding.UTF8.GetString(hexname);
                label1.Text = name;
            }
            else if (API == "CCAPI")
            {
                byte[] hexname = CCAPI.GetBytes(0x10155858, 20);
                string name = Encoding.UTF8.GetString(hexname);
                label1.Text = name;
            }
        }
        void WriteToXML()
        {
            if (File.Exists(path + "locations.xml"))
            {
                XmlDocument file = new XmlDocument();
                file.Load(File.ReadAllText(path + "locations.xml"));
                XmlNode Location = file.CreateElement("Location");
                XmlNode Tacos = file.CreateElement("Tacos");
                file.Save(path);
            }
            else
            {
                Directory.CreateDirectory(path);
                XmlTextWriter xml = new XmlTextWriter(path + "locations.xml", Encoding.UTF8);
                xml.Formatting = Formatting.Indented;
                xml.WriteStartElement("Locations");
                xml.WriteStartElement("Location");
                xml.WriteAttributeString("Server ID", label1.Text);
                xml.WriteAttributeString("Name", name);
                xml.WriteStartElement("XCoords");
                xml.WriteString(xbox.Value.ToString());
                xml.WriteEndElement();
                xml.WriteStartElement("YCoords");
                xml.WriteString(ybox.Value.ToString());
                xml.WriteEndElement();
                xml.WriteStartElement("ZCoords");
                xml.WriteString(zbox.Value.ToString());
                xml.WriteEndElement();
                xml.WriteEndElement();
                xml.WriteEndElement();
                xml.Close();
            }
        }
        void GetGravity()
        {
            if (API == "TMAPI")
            {
                byte[] pointer = PS3.GetMemory(0x104F7320, new byte[4]);
                Array.Reverse(pointer);
                gravity = BitConverter.ToUInt32(pointer, 0) + 0x1A8C;
            }
            if (API == "CCAPI")
            {
                byte[] pointer = CCAPI.GetBytes(0x104F7320, 4);
                Array.Reverse(pointer);
                gravity = BitConverter.ToUInt32(pointer, 0) + 0x1A8C;
            }

        }
        void Activate(bool active)
        {
            getcoords.Enabled = active;
            teleport.Enabled = active;
            auto.Enabled = active;
            jetpack.Enabled = active;
            slow.Enabled = active;
            xbox.Enabled = active;
            ybox.Enabled = active;
            zbox.Enabled = active;
        }
        private void nsButton1_Click(object sender, EventArgs e)
        {
            if (tm.Checked)
            {
                PS3.ConnectAttach();
                API = "TMAPI";
                FindAddress();
                GetGravity();
                Activate(true);
            }
            else if (cc.Checked)
            {
                string ip = Microsoft.VisualBasic.Interaction.InputBox("Enter your PS3 IP", "PS3 IP");
                if (ip == " " || ip == "")
                {
                    MessageBox.Show("Unable to connect/attach\nError: No IP entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CCAPI.ConnectTarget(ip);
                    CCAPI.AttachProcess();
                    API = "CCAPI";
                    FindAddress();
                    GetGravity();
                    Activate(true);
                }
            }
        }

        private void nsTheme1_Click(object sender, EventArgs e)
        {

        }

        private void nsButton3_Click(object sender, EventArgs e)
        {
            GetSever();
            XYZ();
        }

        private void nsButton2_Click(object sender, EventArgs e)
        {
            SetCoords();
        }

        private void nsButton4_Click(object sender, EventArgs e)
        {
            name = Microsoft.VisualBasic.Interaction.InputBox("Enter a name for your location:", "Name Input");
            WriteToXML();
        }

        private void nsCheckBox1_CheckedChanged(object sender)
        {
            if (auto.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            XYZ();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void nsCheckBox1_CheckedChanged_1(object sender)
        {
            if (API == "TMAPI")
            {
                if (jetpack.Checked)
                {
                    PS3.SetMemory(0x10636240, new byte[] { 0x04 });
                    PS3.SetMemory(0x100BA2CC, new byte[] { 0x38, 0x00, 0x00, 0x00 });
                    PS3.SetMemory(0x100BA820, infoOn);
                    PS3.SetMemory(gravity, new byte[] { 0x00, 0x00, 0x00, 0x02 });
                    timer2.Start();
                }
                else
                {
                    PS3.SetMemory(0x100BA820, infoOff);
                    PS3.SetMemory(gravity, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                    timer2.Stop();
                }
            }
            else if (API == "CCAPI")
            {
                if (jetpack.Checked)
                {
                    CCAPI.SetMemory(0x10636240, new byte[] { 0x04 });
                    CCAPI.SetMemory(0x100BA2CC, new byte[] { 0x38, 0x00, 0x00, 0x00 });
                    CCAPI.SetMemory(0x100BA820, infoOn);
                    CCAPI.SetMemory(gravity, new byte[] { 0x00, 0x00, 0x00, 0x02 });
                    timer2.Start();
                }
                else
                {
                    CCAPI.SetMemory(0x100BA820, infoOff);
                    CCAPI.SetMemory(gravity, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                    timer2.Stop();
                }
            }
        }

        private void xbox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (API == "TMAPI")
            {
                byte[] origin = PS3.GetMemoryInt(address + 0x4, 4);
                Array.Reverse(origin);
                float y = BitConverter.ToSingle(origin, 0);
                y += 1.0f;
                byte[] newZ = BitConverter.GetBytes(y);
                Array.Reverse(newZ);
                PS3.SetMemory(address + 0x4, newZ);
            }
            else if (API == "CCAPI")
            {
                byte[] origin = CCAPI.GetBytes(address + 0x4, 4);
                Array.Reverse(origin);
                float y = BitConverter.ToSingle(origin, 0);
                y += 1.0f;
                byte[] newZ = BitConverter.GetBytes(y);
                Array.Reverse(newZ);
                CCAPI.SetMemory(address + 0x4, newZ);
            }
        }

        private void nsCheckBox1_CheckedChanged_2(object sender)
        {
            if (API == "TMAPI")
            {
                if (slow.Checked)
                {
                    PS3.SetMemory(0x10636240, new byte[] { 0x04 });
                    PS3.SetMemory(0x100BA2CC, new byte[] { 0x38, 0x00, 0x00, 0x00 });
                    PS3.SetMemory(0x100BA820, infoOn);
                    PS3.SetMemory(gravity, new byte[] { 0x00, 0x00, 0x00, 0x02 });
                    timer3.Start();
                }
                else
                {
                    PS3.SetMemory(0x100BA820, infoOff);
                    PS3.SetMemory(gravity, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                    timer3.Stop();
                }
            }
            else if (API == "CCAPI")
            {
                if (slow.Checked)
                {
                    CCAPI.SetMemory(0x10636240, new byte[] { 0x04 });
                    CCAPI.SetMemory(0x100BA2CC, new byte[] { 0x38, 0x00, 0x00, 0x00 });
                    CCAPI.SetMemory(0x100BA820, infoOn);
                    CCAPI.SetMemory(gravity, new byte[] { 0x00, 0x00, 0x00, 0x02 });
                    timer3.Start();
                }
                else
                {
                    CCAPI.SetMemory(0x100BA820, infoOff);
                    CCAPI.SetMemory(gravity, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                    timer3.Stop();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (API == "TMAPI")
            {
                byte[] origin = PS3.GetMemoryInt(address + 0x4, 4);
                Array.Reverse(origin);
                float y = BitConverter.ToSingle(origin, 0);
                y += 0.3f;
                byte[] newZ = BitConverter.GetBytes(y);
                Array.Reverse(newZ);
                PS3.SetMemory(address + 0x4, newZ);
            }
            else if (API == "CCAPI")
            {
                byte[] origin = CCAPI.GetBytes(address + 0x4, 4);
                Array.Reverse(origin);
                float y = BitConverter.ToSingle(origin, 0);
                y += 0.3f;
                byte[] newZ = BitConverter.GetBytes(y);
                Array.Reverse(newZ);
                CCAPI.SetMemory(address + 0x4, newZ);
            }
        }
    }
}
