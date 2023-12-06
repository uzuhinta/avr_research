using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLed
{
    public partial class Form1 : Form
    {
        public byte[] data = new byte[] {0x00};
        //giá trị yêu cầu gửi phản hồi về//// nếu gửi 9 bit thì điều khiển đc 8 bóng
        public byte[] address = new byte[] { 0x80 };
        //biến gửi giá trị xuống
        byte temp = 0x00;
        //biến thực nhận (giá trị xác nhận)
        byte real;
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            cbPortName.Items.AddRange(port);
            btDisconnet.Enabled = false;
            cbPortBaud.SelectedIndex = 6;
            cbDataSize.SelectedIndex = 1;
            cbParity.SelectedIndex = 0;
            cbStopBits.SelectedIndex = 0;
            grStatus.Enabled = false;
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPortName.Text)
                || string.IsNullOrEmpty(cbPortBaud.Text)
                || string.IsNullOrEmpty(cbParity.Text)
                || string.IsNullOrEmpty(cbDataSize.Text)
                || string.IsNullOrEmpty(cbStopBits.Text)
                )
            {
                tbMessage.Text += "Please complete setting!" + Environment.NewLine;
            }
            else
            {
                try
                {
                    serialPort1.PortName = cbPortName.SelectedItem.ToString();
                    serialPort1.BaudRate = int.Parse(cbPortBaud.SelectedItem.ToString());
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbParity.SelectedItem.ToString(), true);
                    serialPort1.DataBits = int.Parse(cbDataSize.SelectedItem.ToString());
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.SelectedItem.ToString(), true);
                    // Set the read/write timeouts
                    serialPort1.ReadTimeout = 500;
                    serialPort1.WriteTimeout = 500;

                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        tbMessage.Text += "Open " + cbPortName.SelectedItem.ToString() + Environment.NewLine;
                        //Khởi tạo giá trị gửi đi và button theo trạng thái led gửi về.
                        try
                        {
                            serialPort1.Write(address, 0, 1);
                            address[0] = 0;
                        }
                        catch (TimeoutException)
                        {
                            tbMessage.Text += "Write timeout, FALSE" + Environment.NewLine;
                        }

                        cbPortName.Enabled = false;
                        cbPortBaud.Enabled = false;
                        cbDataSize.Enabled = false;
                        cbParity.Enabled = false;
                        cbStopBits.Enabled = false;
                        btDisconnet.Enabled = true;
                        btConnect.Enabled = false;
                        grStatus.Enabled = true;
                    }
                }
                catch (IOException ioe)
                {
                    tbMessage.Text += "Error " + ioe.ToString() + Environment.NewLine;
                }
            }
        }

        private void btDisconnet_Click(object sender, EventArgs e)
        {
            serialPort1.Close();

            tbMessage.Text += "Close " + cbPortName.SelectedItem.ToString() + Environment.NewLine;
           
            cbPortName.Enabled = true;
            cbPortBaud.Enabled = true;
            cbDataSize.Enabled = true;
            cbParity.Enabled = true;
            cbStopBits.Enabled = true;
            btConnect.Enabled = true;
            btDisconnet.Enabled = false;
            grStatus.Enabled = false;
        }

        private void btLed1On_MouseClick(object sender, MouseEventArgs e)
        {
             
        }

        private void btLed1On_Click(object sender, EventArgs e)
        {
            ledOn(0);
        }

        private void btLed2On_Click(object sender, EventArgs e)
        {
            ledOn(1);
        }

        private void btLed3On_Click(object sender, EventArgs e)
        {
            ledOn(2);
        }

        private void btLed4On_Click(object sender, EventArgs e)
        {
            ledOn(3);
        }

        private void btLed5On_Click(object sender, EventArgs e)
        {
            ledOn(4);
        }

        private void btLed6On_Click(object sender, EventArgs e)
        {
            ledOn(5);
        }

        private void btLed7On_Click(object sender, EventArgs e)
        {
            ledOn(6);
        }

        //private void btLed8On_Click(object sender, EventArgs e)
        //{
        //    ledOn(7);
        //}

        private void btLed1Off_Click(object sender, EventArgs e)
        {
            ledOff(0);
        }

        private void btLed2Off_Click(object sender, EventArgs e)
        {
            ledOff(1);
        }

        private void btLed3Off_Click(object sender, EventArgs e)
        {
            ledOff(2);
        }

        private void btLed4Off_Click(object sender, EventArgs e)
        {
            ledOff(3);
        }

        private void btLed5Off_Click(object sender, EventArgs e)
        {
            ledOff(4);
        }

        private void btLed6Off_Click(object sender, EventArgs e)
        {
            ledOff(5);
        }

        private void btLed7Off_Click(object sender, EventArgs e)
        {
            ledOff(6);
        }

        //private void btLed8Off_Click(object sender, EventArgs e)
        //{
        //    ledOff(7);
        //}

        //NHẬN DỮ LIỆU GỬI VỀ KHI TRẠNG THÁI TRƯỚC KHÁC HIỆN TẠI
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //int bytes = serialPort1.BytesToRead;
                byte[] buffer = new byte[1];
                serialPort1.Read(buffer, 0, 1);
               
                real = buffer[0];
                if (address[0] == 0) temp = real;
                
                tbMessage.Invoke(new Action(() => tbMessage.Text += "Success " + Environment.NewLine));

                statusLed(real);
            }
            catch (TimeoutException)
            {
                tbMessage.Text += "Read timeout" + Environment.NewLine;
            }
        }

        //HÀM BẬT LED
        private void ledOn(byte x)
        {
            if (serialPort1.IsOpen)
            {
                temp |= (byte)(1 << x);
                data[0] = temp;
                try
                {
                    serialPort1.Write(data, 0, 1);

                    //tbMessage.Text += "On led {0}" + (x + 1) + Environment.NewLine;
                }
                catch (TimeoutException)
                {
                    tbMessage.Text += "Write timeout, FALSE" +
                        "" + Environment.NewLine;
                    temp &= (byte)(~(1 << x));
                    data[0] = temp;
                }
            }
            else
            {
                tbMessage.Text += "COM isn't connecting" + Environment.NewLine;
            }
        }

        //HÀM TẮT LED
        private void ledOff(byte x)
        {
            temp &= (byte)(~(1 << x));
            data[0] = temp;
            try
            {
                serialPort1.Write(data, 0, 1);
            }
            catch(TimeoutException)
            {
                tbMessage.Text += "Write timeout, FALSE" + Environment.NewLine;
                //Khôi phục lại giá trị tạm thời
                temp &= (byte)(1 << x);
                data[0] = temp;
            }
        }

        //PHẢN HỒI TRẠNG THÁI TẠI NÚT
        private void statusLed(byte x)
        {
            //LED1
            if(IsBitSet(x, 0))
            {
                btLed1On.Invoke(new Action(() =>  btLed1On.Enabled = false));
                btLed1Off.Invoke(new Action(() => btLed1Off.Enabled = true));
            }
            if(!(IsBitSet(x, 0)))
            {
                btLed1On.Invoke(new Action(() => btLed1On.Enabled = true));
                btLed1Off.Invoke(new Action(() => btLed1Off.Enabled = false));
            }

            //LED2
            if (IsBitSet(x, 1))
            {
                btLed2On.Invoke(new Action(() => btLed2On.Enabled = false));
                btLed2Off.Invoke(new Action(() => btLed2Off.Enabled = true));
            }
            if (!(IsBitSet(x, 1)))
            {
                btLed2On.Invoke(new Action(() => btLed2On.Enabled = true));
                btLed2Off.Invoke(new Action(() => btLed2Off.Enabled = false));
            }

            //LED3
            if (IsBitSet(x, 2))
            {
                btLed3On.Invoke(new Action(() => btLed3On.Enabled = false));
                btLed3Off.Invoke(new Action(() => btLed3Off.Enabled = true));
            }
            if (!(IsBitSet(x, 2)))
            {
                btLed3On.Invoke(new Action(() => btLed3On.Enabled = true));
                btLed3Off.Invoke(new Action(() => btLed3Off.Enabled = false));
            }

            //LED4
            if (IsBitSet(x, 3))
            {
                btLed4On.Invoke(new Action(() => btLed4On.Enabled = false));
                btLed4Off.Invoke(new Action(() => btLed4Off.Enabled = true));
            }
            if (!(IsBitSet(x, 3)))
            {
                btLed4On.Invoke(new Action(() => btLed4On.Enabled = true));
                btLed4Off.Invoke(new Action(() => btLed4Off.Enabled = false));
            }

            //LED5
            if (IsBitSet(x, 4))
            {
                btLed5On.Invoke(new Action(() => btLed5On.Enabled = false));
                btLed5Off.Invoke(new Action(() => btLed5Off.Enabled = true));
            }
            if (!(IsBitSet(x, 4)))
            {
                btLed5On.Invoke(new Action(() => btLed5On.Enabled = true));
                btLed5Off.Invoke(new Action(() => btLed5Off.Enabled = false));
            }

            //LED6
            if (IsBitSet(x, 5))
            {
                btLed6On.Invoke(new Action(() => btLed6On.Enabled = false));
                btLed6Off.Invoke(new Action(() => btLed6Off.Enabled = true));
            }
            if (!(IsBitSet(x, 5)))
            {
                btLed6On.Invoke(new Action(() => btLed6On.Enabled = true));
                btLed6Off.Invoke(new Action(() => btLed6Off.Enabled = false));
            }

            //LED7
            if (IsBitSet(x, 6))
            {
                btLed7On.Invoke(new Action(() => btLed7On.Enabled = false));
                btLed7Off.Invoke(new Action(() => btLed7Off.Enabled = true));
            }
            if (!(IsBitSet(x, 6)))
            {
                btLed7On.Invoke(new Action(() => btLed7On.Enabled = true));
                btLed7Off.Invoke(new Action(() => btLed7Off.Enabled = false));
            }

            //LED8
            //if (IsBitSet(x, 7))
            //{
            //    btLed8On.Invoke(new Action(() => btLed8On.Enabled = false));
            //    btLed8Off.Invoke(new Action(() => btLed8Off.Enabled = true));
            //}
            //if (!(IsBitSet(x, 7)))
            //{
            //    btLed8On.Invoke(new Action(() => btLed8On.Enabled = true));
            //    btLed8Off.Invoke(new Action(() => btLed8Off.Enabled = false));
            //}
        }

        //LẤY GIÁ TRỊ BIT THỨ I
        public bool IsBitSet(byte value, int bitNumber)
        {
            if ((bitNumber < 0) || (bitNumber > 7))
            {
                throw new ArgumentOutOfRangeException("bitNumber", bitNumber, "bitNumber must be 0..7");
            }

            return ((value & (1 << bitNumber)) != 0);
        }

        //Scoll to end
        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            tbMessage.SelectionStart = tbMessage.Text.Length;
            tbMessage.ScrollToCaret();
        }
    }
}
//connect: gửi yêu cầu phía atmega gửi trạng thái các chân.