
using System.IO.Ports;
using static stm32F4_programmer.STM32F4Programmer;
using System.Net;
namespace stm32F4_programmer
{
    public partial class STM32F4Programmer : Form
    {
        SerialPort serialPort;
        List<byte> receivedData = new List<byte>();
        public STM32F4Programmer()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.DataReceived += serialPort_DataReceived;
            groupBoxcommand.Enabled = false;
        }
        public enum bootLoaderCommand : byte
        {
            getHelp = 0x00,
            getVersion = 0x01,
            getID = 0x02,
            readMemory = 0x11,
            go = 0x21,
            writeMemory = 0x31,
            erase = 0x43,
            writeProtect = 0x63,
            readoutProtect = 0x82,
            getCheckSum = 0xA1,
            reset = 0x89

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LBLCOMPORT_Click(object sender, EventArgs e)
        {

        }

        private void LBLSTOPBITS_Click(object sender, EventArgs e)
        {

        }

        private void STM32F4Programmer_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            COMBOXCOMPORT.Items.AddRange(ports);
            BTNCONNECT.Enabled = true;
            BTNDISCONNECT.Enabled = false;
        }

        private void LBLCONNECTIONSTATUS_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTNCONNECT_Click(object sender, EventArgs e)
        {
            serialPort.PortName = COMBOXCOMPORT.Text;
            serialPort.BaudRate = Int32.Parse(COMBOXBAUDRATE.Text);
            serialPort.DataBits = 8;
            serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), COMBOXPARITYBIT.Text);
            serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), COMBOXSTOPBITS.Text);

            groupBoxcommand.Enabled = true;

            try
            {
                serialPort.Open();
                BTNCONNECT.Enabled = false;
                BTNDISCONNECT.Enabled = true;
                COMBOXCOMPORT.Enabled = false;
                LBLCONNECTIONSTATUS.Text = "Successful";
                PRGBARCONNECTIONSTATUS.Value = 100;
                txtrecievemessage.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BTNCONNECT.Enabled = true;
                BTNDISCONNECT.Enabled = false;
                LBLCONNECTIONSTATUS.Text = "Unsuccessful";
            }
        }

        private void BTNDISCONNECT_Click(object sender, EventArgs e)
        {
            groupBoxcommand.Enabled = false;
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                BTNCONNECT.Enabled = true;
                BTNDISCONNECT.Enabled = false;
                COMBOXCOMPORT.Enabled = true;
                LBLCONNECTIONSTATUS.Text = "Unsuccessful";
                PRGBARCONNECTIONSTATUS.Value = 0;
                txtrecievemessage.Text = string.Empty;

            }
        }

        byte calculateCRC(byte[] data)
        {
            byte crc = 0x00;
            foreach (byte b in data)
            {
                crc ^= b;
            }
            return crc;
        }

        private void sendBootloaderCommand(byte cmd, byte[] data)
        {
            List<byte> packet = new List<byte>();
            packet.Add(0x7F); // BOOTLOADER HEADER
            packet.Add((byte)(1 + data.Length)); // len = cmd + data
            packet.Add(cmd); // cmd
            packet.AddRange(data);
            byte[] crcInput = packet.Skip(1).ToArray();
            byte crc = calculateCRC(crcInput);
            packet.Add(crc); // crc

            if (serialPort.IsOpen)
            {
                serialPort.Write(packet.ToArray(), 0, packet.Count);
                serialPort.Write("\r");
                serialPort.Write("\n");
            }

        }

        private void BTNGETVERSION_Click(object sender, EventArgs e)
        {
            byte cmd = (byte)bootLoaderCommand.getVersion;
            sendBootloaderCommand(cmd, new byte[0]);
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int bytesToRead = serialPort.BytesToRead;
                byte[] buffer = new byte[bytesToRead];
                serialPort.Read(buffer, 0, bytesToRead);

                receivedData.AddRange(buffer);

                string hexoutput = BitConverter.ToString(buffer).Replace("-", " ");

                this.Invoke(new Action(() =>
                {
                    txtrecievemessage.AppendText(hexoutput + Environment.NewLine);
                    txtrecievemessage.SelectionStart = txtrecievemessage.TextLength;
                    txtrecievemessage.ScrollToCaret();
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtrecievemessage.Text = string.Empty;
        }

        private void BTNGETHELP_Click(object sender, EventArgs e)
        {
            byte cmd = (byte)bootLoaderCommand.getHelp;
            sendBootloaderCommand(cmd, new byte[0]);
        }

        private void btngetid_Click(object sender, EventArgs e)
        {
            byte cmd = (byte)bootLoaderCommand.getID;
            sendBootloaderCommand(cmd, new byte[0]);
        }

        private void sendReadMemoryData(uint address, byte length)
        {
            byte[] data = new byte[7];
            // address -> msb to lsb
            data[0] = (byte)((address >> 24) & 0xFF); // MSB
            data[1] = (byte)((address >> 16) & 0xFF);
            data[2] = (byte)((address >> 8) & 0xFF);
            data[3] = (byte)(address & 0xFF);

            byte addressCheckSum = (byte)(data[0] ^ data[1] ^ data[2] ^ data[3]);
            data[4] = addressCheckSum; // addresss checksum
            data[5] = (byte)(length - 1); //length
            data[6] = (byte)~(length - 1);

            byte cmd = (byte)bootLoaderCommand.readMemory;
            sendBootloaderCommand(cmd, data);


        }
        private void label1_Click(object sender, EventArgs e)
        {
            // boþ kalsa bile yeterli
        }

        private void btnreadmemory_Click(object sender, EventArgs e)
        {

            if (txtaddress.Text == "" || txtlength.Text == "")
            {
                MessageBox.Show("please enter the address and length values", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string addressText = txtaddress.Text.Trim();

                if (addressText.StartsWith("0x"))
                {
                    addressText = addressText.Substring(2);
                }
                uint address = Convert.ToUInt32(addressText, 16);
                byte length = byte.Parse(txtlength.Text);

                if (length > 255)
                {
                    MessageBox.Show("maximum 256  byte (0-256)", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                sendReadMemoryData(address, length);

            }
            catch (Exception ex)
            {
                MessageBox.Show("error -> " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            if (receivedData == null || receivedData.Count == 0)
            {
                MessageBox.Show("No data received to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Binary files (*.bin)|*.bin";
                saveFileDialog.Title = "Save Binary File";
                saveFileDialog.FileName = "output.bin";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] dataToSave = receivedData.Skip(1).ToArray();
                        File.WriteAllBytes(saveFileDialog.FileName, dataToSave);
                        MessageBox.Show("Data saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        receivedData.Clear();
                        txtrecievemessage.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void sendGoAddressData(uint address)
        {
            byte[] data = new byte[5];
            // address -> msb to lsb
            data[0] = (byte)((address >> 24) & 0xFF); // MSB
            data[1] = (byte)((address >> 16) & 0xFF);
            data[2] = (byte)((address >> 8) & 0xFF);
            data[3] = (byte)(address & 0xFF);

            byte addressCheckSum = (byte)(data[0] ^ data[1] ^ data[2] ^ data[3]);
            data[4] = addressCheckSum; // addresss checksum

            byte cmd = (byte)bootLoaderCommand.go;
            sendBootloaderCommand(cmd, data);


        }

        private void btngoaddress_Click(object sender, EventArgs e)
        {
            if (txtgoaddress.Text == "")
            {
                MessageBox.Show("Please enter the address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string addressText = txtgoaddress.Text.Trim();

                if (addressText.StartsWith("0x"))
                {
                    addressText = addressText.Substring(2);
                }
                uint address = Convert.ToUInt32(addressText, 16);

                sendGoAddressData(address);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string binFilePath;
        byte[] binData;
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary files (*.bin)|*.bin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtbrowsefile.Text = openFileDialog.FileName;
                binFilePath = txtbrowsefile.Text;
                binData = File.ReadAllBytes(binFilePath);
            }
        }

        private void sendWriteMemoryData(uint address)
        {
            byte[] data = new byte[9];

            byte[] lengthBytes = new byte[4];
            int length = binData.Length;

            // length-> msb to lsb
            lengthBytes[0] = (byte)((length >> 24) & 0xFF);
            lengthBytes[1] = (byte)((length >> 16) & 0xFF);
            lengthBytes[2] = (byte)((length >> 8) & 0xFF);
            lengthBytes[3] = (byte)(length & 0xFF);


            // address-> msb to lsb
            data[0] = (byte)((address >> 24) & 0xFF);
            data[1] = (byte)((address >> 16) & 0xFF);
            data[2] = (byte)((address >> 8) & 0xFF);
            data[3] = (byte)(address & 0xFF);

            byte adddressCheckSum = (byte)(data[0] ^ data[1] ^ data[2] ^ data[3]);
            data[4] = adddressCheckSum; //address checksum

            data[5] = lengthBytes[0];
            data[6] = lengthBytes[1];
            data[7] = lengthBytes[2];
            data[8] = lengthBytes[3];

            byte cmd = (byte)bootLoaderCommand.writeMemory;
            sendBootloaderCommand(cmd, data);


            sendDataBlocks(address);

        }
        private void sendDataBlocks(uint startAddress)
        {
            int offset = 0;
            //int blockSize = 256;

            while (offset < binData.Length)
            {

                int remaining = binData.Length - offset;
                int currentBlockSize = remaining > 256 ? 256 : remaining;

                byte N = (byte)(currentBlockSize - 1);
                byte[] packet = new byte[currentBlockSize + 2];
                packet[0] = N;

                Array.Copy(binData, offset, packet, 1, currentBlockSize);

                byte checkSum = N;
                for (int i = 1; i <= currentBlockSize; i++)
                {
                    checkSum ^= packet[i];
                }

                packet[packet.Length - 1] = checkSum;

                sendBytesToSTM32(packet);

                offset += currentBlockSize;
                startAddress += (uint)currentBlockSize;
                System.Threading.Thread.Sleep(10);
            }

        }

        private void sendBytesToSTM32(byte[] data)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(data, 0, data.Length);
            }
            else
            {
                MessageBox.Show("Serial Port is not Open!");
            }

        }

        private void btnwritememory_Click(object sender, EventArgs e)
        {
            if (txtwritememoryaddress.Text == "" || txtbrowsefile.Text == "")
            {
                MessageBox.Show("Please enter the address and bin file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string addressText = txtwritememoryaddress.Text.Trim();

                if (addressText.StartsWith("0x"))
                {
                    addressText = addressText.Substring(2);
                }
                uint address = Convert.ToUInt32(addressText, 16);

                sendWriteMemoryData(address);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void chBoxSel0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sendEraseData()
        {
            byte[] data = new byte[258];
            int index = 0;

            List<byte> selectedSectors = new List<byte>();
            if (chBoxSel0.Checked) selectedSectors.Add(0x00);
            if (chBoxSel1.Checked) selectedSectors.Add(0x01);
            if (chBoxSel2.Checked) selectedSectors.Add(0x02);
            if (chBoxSel3.Checked) selectedSectors.Add(0x03);
            if (chBoxSel4.Checked) selectedSectors.Add(0x04);
            if (chBoxSel5.Checked) selectedSectors.Add(0x05);
            if (chBoxSel6.Checked) selectedSectors.Add(0x06);
            if (chBoxSel7.Checked) selectedSectors.Add(0x07);

            if (chBoxSelMassErase.Checked)
            {
                data[0] = 0xFF;
                data[1] = (byte)(data[0] ^ 0x00);
                index = 2;
            }
            else
            {
                if (selectedSectors.Count == 0)
                {
                    MessageBox.Show("Please select sector or sectors.");
                }

                byte N = (byte)(selectedSectors.Count - 1);
                byte checkSum = N;
                data[0] = N;
                index = 1;
                for (int i = 0; i < selectedSectors.Count; i++)
                {
                    data[index] = selectedSectors[i];
                    checkSum ^= selectedSectors[i];
                    index++;
                }
                data[index] = checkSum;
                index++;
            }

            byte[] finalData = new byte[index];
            Array.Copy(data, finalData, index);
            byte cmd = (byte)bootLoaderCommand.erase;
            sendBootloaderCommand(cmd, finalData);
        }

        private void btnerase_Click(object sender, EventArgs e)
        {
            sendEraseData();
        }

        private void txtbrowsefile_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendReadOutProtectionData();
        }

        private void sendWriteProUnProData()
        {
            List<byte> sectorsToProtect = new List<byte>();

            if (checkBox1.Checked) sectorsToProtect.Add(0x00);
            if (checkBox2.Checked) sectorsToProtect.Add(0x01);
            if (checkBox3.Checked) sectorsToProtect.Add(0x02);
            if (checkBox6.Checked) sectorsToProtect.Add(0x03);
            if (checkBox5.Checked) sectorsToProtect.Add(0x04);
            if (checkBox4.Checked) sectorsToProtect.Add(0x05);
            if (checkBox9.Checked) sectorsToProtect.Add(0x06);
            if (checkBox8.Checked) sectorsToProtect.Add(0x07);

            if (sectorsToProtect.Count > 0)
            {
                byte N = (byte)(sectorsToProtect.Count - 1);
                List<byte> payload = new List<byte> { N };
                payload.AddRange(sectorsToProtect);

                byte cmd = (byte)bootLoaderCommand.writeProtect;
                sendBootloaderCommand(cmd, payload.ToArray());

                MessageBox.Show("Checked sectors have been write-protected. The others are unprotected.");
            }
            else
            {
                byte N = (byte)(sectorsToProtect.Count - 1);
                List<byte> payload = new List<byte> { N };
                payload.AddRange(sectorsToProtect);

                byte cmd = (byte)bootLoaderCommand.writeProtect;
                sendBootloaderCommand(cmd, payload.ToArray());
                MessageBox.Show("All sectors have been set to unprotected.");
            }
        }

        private void btnWriteProUnPro_Click(object sender, EventArgs e)
        {
            sendWriteProUnProData();
        }

        private void sendReadOutProtectionData()
        {
            byte rdpLevel = 0xAA;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    rdpLevel = 0xAA;
                    break;
                case 1:
                    rdpLevel = 0xBB;
                    break;
                case 2:
                    rdpLevel = 0xCC;
                    break;
                default:
                    MessageBox.Show("Invalid Selection");
                    return;
            }

            byte[] payload = new byte[] { rdpLevel };
            byte cmd = (byte)bootLoaderCommand.readoutProtect;
            sendBootloaderCommand(cmd, payload);

            MessageBox.Show($"Selected RDP Level:{comboBox1.SelectedItem}");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PRGBARCONNECTIONSTATUS_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            byte cmd = (byte)bootLoaderCommand.reset;
            sendBootloaderCommand(cmd, new byte[0]);
        }

        private void btnexitboot_Click(object sender, EventArgs e)
        {
            uint defaultAddress = 0x08008000;
            sendGoAddressData(defaultAddress);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            COMBOXCOMPORT.Items.Clear();
            String[] ports = SerialPort.GetPortNames();
            COMBOXCOMPORT.Items.AddRange(ports);
        }
    }
}
