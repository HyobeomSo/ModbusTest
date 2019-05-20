using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<KeyValuePair<int, string>> readList = new List<KeyValuePair<int, string>>();
        SerialPort sp = new SerialPort();

        byte[] crc_table = new byte[512] { 0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x1,
            0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x1,0xC0,0x80,0x41,0x0,0xC1,
            0x81,0x40,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x1,0xC0,0x80,
            0x41,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,
            0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x0,0xC1,0x81,0x40,0x1,
            0xC0,0x80,0x41,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x0,0xC1,
            0x81,0x40,0x1,0xC0,0x80,0x41,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,
            0x41,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x0,0xC1,0x81,0x40,
            0x1,0xC0,0x80,0x41,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x0,
            0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x1,0xC0,0x80,0x41,0x0,0xC1,
            0x81,0x40,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x1,0xC0,0x80,
            0x41,0x0,0xC1,0x81,0x40,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x1,0xC0,0x80,0x41,
            0x1,0xC0,0x80,0x41,0x0,0xC1,0x81,0x40,0x0,0xC0,0xC1,0x1,0xC3,0x3,0x2,0xC2,0xC6,0x6,0x7,0xC7,0x5,0xC5,
            0xC4,0x4,0xCC,0xC,0xD,0xCD,0xF,0xCF,0xCE,0xE,0xA,0xCA,0xCB,0xB,0xC9,0x9,0x8,0xC8,0xD8,0x18,0x19,0xD9,
            0x1B,0xDB,0xDA,0x1A,0x1E,0xDE,0xDF,0x1F,0xDD,0x1D,0x1C,0xDC,0x14,0xD4,0xD5,0x15,0xD7,0x17,0x16,0xD6,
            0xD2,0x12,0x13,0xD3,0x11,0xD1,0xD0,0x10,0xF0,0x30,0x31,0xF1,0x33,0xF3,0xF2,0x32,0x36,0xF6,0xF7,0x37,
            0xF5,0x35,0x34,0xF4,0x3C,0xFC,0xFD,0x3D,0xFF,0x3F,0x3E,0xFE,0xFA,0x3A,0x3B,0xFB,0x39,0xF9,0xF8,0x38,
            0x28,0xE8,0xE9,0x29,0xEB,0x2B,0x2A,0xEA,0xEE,0x2E,0x2F,0xEF,0x2D,0xED,0xEC,0x2C,0xE4,0x24,0x25,0xE5,
            0x27,0xE7,0xE6,0x26,0x22,0xE2,0xE3,0x23,0xE1,0x21,0x20,0xE0,0xA0,0x60,0x61,0xA1,0x63,0xA3,0xA2,0x62,
            0x66,0xA6,0xA7,0x67,0xA5,0x65,0x64,0xA4,0x6C,0xAC,0xAD,0x6D,0xAF,0x6F,0x6E,0xAE,0xAA,0x6A,0x6B,0xAB,
            0x69,0xA9,0xA8,0x68,0x78,0xB8,0xB9,0x79,0xBB,0x7B,0x7A,0xBA,0xBE,0x7E,0x7F,0xBF,0x7D,0xBD,0xBC,0x7C,
            0xB4,0x74,0x75,0xB5,0x77,0xB7,0xB6,0x76,0x72,0xB2,0xB3,0x73,0xB1,0x71,0x70,0xB0,0x50,0x90,0x91,0x51,
            0x93,0x53,0x52,0x92,0x96,0x56,0x57,0x97,0x55,0x95,0x94,0x54,0x9C,0x5C,0x5D,0x9D,0x5F,0x9F,0x9E,0x5E,
            0x5A,0x9A,0x9B,0x5B,0x99,0x59,0x58,0x98,0x88,0x48,0x49,0x89,0x4B,0x8B,0x8A,0x4A,0x4E,0x8E,0x8F,0x4F,
            0x8D,0x4D,0x4C,0x8C,0x44,0x84,0x85,0x45,0x87,0x47,0x46,0x86,0x82,0x42,0x43,0x83,0x41,0x81,0x80,0x40
            };

        public int crc16(byte[] modbusframe, int Length)
        {
            int i;
            int index;
            int crc_Low = 0xFF;
            int crc_High = 0xFF;

            for (i = 0; i < Length; i++)
            {
                index = crc_High ^ (char)modbusframe[i];
                crc_High = crc_Low ^ crc_table[index];
                crc_Low = (byte)crc_table[index + 256];
            }

            return crc_High * 256 + crc_Low;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CellImage.Load("../../EssImages/ess.png");
            CellImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            sp.Close();
            sp.PortName = PortName.Text;
            sp.BaudRate = Convert.ToInt32(BaudRate.Text);
            sp.DataBits = Convert.ToInt32(DataBits.Text);
            int temp = Convert.ToInt32(StopBits.Text);
            if (temp == 1)
            {
                sp.StopBits = System.IO.Ports.StopBits.One;
            }
            else
            {
                sp.StopBits = System.IO.Ports.StopBits.Two;
            }
            String s = ParityBits.Text;
            if (s == "Even")
            {
                sp.Parity = Parity.Even;
            }
            else if (s == "Odd")
            {
                sp.Parity = Parity.Odd;
            }
            else
            {
                sp.Parity = Parity.None;
            }

            sp.DataReceived += SP_DataReceive;
            sp.Open();
        }

        static int addr;
        private void SP_DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            int dataSize = sp.BytesToRead;
            string data;
            string temp;

            this.Invoke(new Action(delegate ()
                {
                    if (M_Function.SelectedIndex + 1 == 4)
                        addr = 30000;
                    else
                        addr = 40000;
                }));

            if (dataSize != 0)
            {
                data = "";
                byte[] buff = new byte[dataSize];
                sp.Read(buff, 0, dataSize);
                string lrcChk = "";
                int idx;
                for (idx = 1; idx < dataSize - 4; idx++)
                {
                    lrcChk += Convert.ToChar(buff[idx]);
                }
                string lrc = "";
                for (; idx < dataSize - 2; idx++)
                {
                    lrc += Convert.ToChar(buff[idx]);
                }
                if (Lrc_Calc(lrcChk) != lrc)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        ReceiveTextBox.AppendText("LRC Error\n");
                    }));
                    return;
                }
                if (AsciiBtn.Checked)
                {
                    for (int i = 1; i < 7; i++)
                        data += Convert.ToChar(buff[i]);
                    for (int i = 7; i < dataSize - 4; i += 4)
                    {
                        temp = "";
                        temp += Convert.ToChar(buff[i]);
                        temp += Convert.ToChar(buff[i + 1]);
                        temp += Convert.ToChar(buff[i + 2]);
                        temp += Convert.ToChar(buff[i + 3]);
                        readList.Add(new KeyValuePair<int, string>(addr, temp));
                        addr++;
                    }
                    DataType_Switching();
                }
                else
                {
                    foreach (int bData in buff)
                    {
                        data += bData.ToString("X").PadLeft(2, '0');
                    }
                }
                this.Invoke(new Action(delegate ()
                {
                    ReceiveTextBox.AppendText("[수신] " + lrcChk + lrc + "\n");
                    ReceiveTextBox.ScrollToCaret();
                }));
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("Not Connected");
                return;
            }
            if (AsciiBtn.Checked)
            {
                sp.Write(":" + SendText.Text + "\r\n");
            }
            else
            {
                string msg = SendText.Text;
                byte[] temp = new byte[msg.Length / 2];
                for (int i = 0; i < SendText.Text.Length; i += 2)
                {
                    temp[i / 2] = byte.Parse("" + msg[i] + msg[i + 1], System.Globalization.NumberStyles.HexNumber);
                }
                sp.Write(temp, 0, temp.Length);

            }
            ReceiveTextBox.AppendText("[송신] " + SendText.Text + '\n');
            ReceiveTextBox.ScrollToCaret();
            SendText.Clear();
            readList.Clear();
        }

        private void SendText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendBtn_Click(sender, e);
            }
        }

        private String Lrc_Calc(String s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i += 2)
            {
                sum += int.Parse("" + s[i] + s[i + 1], System.Globalization.NumberStyles.HexNumber);
                if (sum > 0xFF)
                {
                    sum -= 0x100;
                }
            }
            sum ^= 0xFF;
            sum += 1;
            return sum.ToString("X");
        }
        private void ModbusGen(object sender, EventArgs e)
        {
            if (AsciiBtn.Checked)
            {
                int id = Convert.ToInt32(M_SlaveID.Text);
                int ofs = Convert.ToInt32(M_Offset.Text);
                int len = Convert.ToInt32(M_Length.Text);
                string s = (id.ToString("X").PadLeft(2, '0')) +
                    (M_Function.SelectedIndex + 1).ToString().PadLeft(2, '0') +
                    (ofs <= 256 ? (ofs).ToString("X").PadLeft(4, '0') : (ofs).ToString("X").PadLeft(4, '0')) +
                    (len <= 255 ? len.ToString("X").PadLeft(4, '0') : len.ToString("X").PadLeft(4, '0'));
                string lrc = Lrc_Calc(s);
                SendText.Text = s + lrc;
            }
            else
            {
                int id = Convert.ToInt32(M_SlaveID.Text);
                string str_modid = id.ToString("X").PadLeft(2, '0');
                string str_function = (M_Function.SelectedIndex + 1).ToString().PadLeft(2, '0');
                int int_offset = Convert.ToInt32(M_Offset.Text) - 1;
                string str_modoff = String.Format("{0:X4}", int_offset);
                int int_len = Convert.ToInt32(M_Length.Text);
                string str_len = string.Format("{0:X4}", int_len);
                string str_modbus1 = str_modid + str_function + str_modoff + str_len;
                string str_modbus2 = bytetostr(str_modbus1, "1");
                byte[] bStrByte = Encoding.UTF8.GetBytes(str_modbus2);
                int crc_16 = crc16(bStrByte, bStrByte.Length);
                string str_crc = crc_16.ToString("X");
                SendText.Text = str_modbus1 + str_crc;
            }
        }
        string hex_str;
        string bstrbyte2;
        private string bytetostr(string strtxt, string str_num)
        {

            int i;
            int ii = strtxt.Length / 2;
            int iii = ii - 1;
            int[] aa = new int[ii];
            bstrbyte2 = null;

            for (i = 0; i <= iii; i++)
            {
                int a = Convert.ToInt32(strtxt.Substring(i * 2, 2), 16);// hex to int
                aa[i] = a;
            }

            foreach (int int_str in aa)
            {
                char b = (char)int_str;
                string c = string.Format("{0:X2}", b);


                bstrbyte2 += c;
            }

            if (str_num == "0") // 1=crc, 0=crc아님
            {
                hex_str = bstrbyte2;
            }


            return bstrbyte2;
        }

        private void Change_DataType(object sender, EventArgs e)
        {
            if (readList.Count != 0)
            {
                switch (SelectDataType.SelectedIndex)
                {
                    case 0:
                        {
                            DataView.Items.Clear();
                            for (int i = 0; i < readList.Count; i++)
                            {
                                DataView.Items.Add(readList[i].Key.ToString());
                                DataView.Items[i].SubItems.Add(readList[i].Value);
                            }
                            break;
                        }
                    case 1:
                        {
                            DataView.Items.Clear();
                            for (int i = 0; i < readList.Count; i++)
                            {
                                DataView.Items.Add(readList[i].Key.ToString());
                                DataView.Items[i].SubItems.Add(int.Parse(readList[i].Value, System.Globalization.NumberStyles.HexNumber).ToString());
                            }
                            break;
                        }
                    case 2:
                        {
                            DataView.Items.Clear();
                            for (int i = 0; i < readList.Count; i++)
                            {
                                string tem = readList[i].Value;
                                DataView.Items.Add(readList[i].Key.ToString());
                                DataView.Items[i].SubItems.Add(tem.Insert(2, "."));
                            }
                            break;
                        }
                }
            }
        }
        private void DataType_Switching()
        {
            this.Invoke(new Action(delegate ()
            {
                switch (SelectDataType.SelectedIndex)
                {
                    case 0:
                        {
                            DataView.Items.Clear();
                            for (int i = 0; i < readList.Count; i++)
                            {
                                DataView.Items.Add(readList[i].Key.ToString());
                                DataView.Items[i].SubItems.Add(readList[i].Value);
                            }
                            break;
                        }
                    case 1:
                        {
                            DataView.Items.Clear();
                            for (int i = 0; i < readList.Count; i++)
                            {
                                DataView.Items.Add(readList[i].Key.ToString());
                                DataView.Items[i].SubItems.Add(int.Parse(readList[i].Value, System.Globalization.NumberStyles.HexNumber).ToString());
                            }
                            break;
                        }
                    case 2:
                        {
                            DataView.Items.Clear();
                            for (int i = 0; i < readList.Count; i++)
                            {
                                string tem = readList[i].Value;
                                DataView.Items.Add(readList[i].Key.ToString());
                                DataView.Items[i].SubItems.Add(tem.Insert(2, "."));
                            }
                            break;
                        }
                }
            }
            ));
        }
    }
}
