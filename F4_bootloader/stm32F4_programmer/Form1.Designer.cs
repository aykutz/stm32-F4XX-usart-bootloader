namespace stm32F4_programmer
{
    partial class STM32F4Programmer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STM32F4Programmer));
            groupBoxConnection = new GroupBox();
            btnrefresh = new Button();
            PRGBARCONNECTIONSTATUS = new ProgressBar();
            LBLCONNECTIONSTATUS = new Label();
            BTNDISCONNECT = new Button();
            BTNCONNECT = new Button();
            COMBOXPARITYBIT = new ComboBox();
            COMBOXSTOPBITS = new ComboBox();
            LBLPARITYBIT = new Label();
            LBLSTOPBITS = new Label();
            COMBOXBAUDRATE = new ComboBox();
            LBLBOUDRATE = new Label();
            COMBOXCOMPORT = new ComboBox();
            LBLCOMPORT = new Label();
            btnreset = new Button();
            groupBoxcommand = new GroupBox();
            btnexitboot = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            btnreadout = new Button();
            checkBox8 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            btnWriteProUnPro = new Button();
            chBoxSelMassErase = new CheckBox();
            chBoxSel7 = new CheckBox();
            chBoxSel6 = new CheckBox();
            chBoxSel5 = new CheckBox();
            chBoxSel4 = new CheckBox();
            chBoxSel3 = new CheckBox();
            chBoxSel2 = new CheckBox();
            chBoxSel1 = new CheckBox();
            chBoxSel0 = new CheckBox();
            btnerase = new Button();
            btnbrowse = new Button();
            txtbrowsefile = new TextBox();
            label2 = new Label();
            txtwritememoryaddress = new TextBox();
            btnwritememory = new Button();
            txtgoaddress = new TextBox();
            label1 = new Label();
            btngoaddress = new Button();
            BTNSAVE = new Button();
            txtlength = new TextBox();
            txtaddress = new TextBox();
            lbladdresslenght = new Label();
            LBLADDRESS = new Label();
            btnreadmemory = new Button();
            btngetid = new Button();
            btnclear = new Button();
            txtrecievemessage = new TextBox();
            BTNGETVERSION = new Button();
            BTNGETHELP = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            groupBoxConnection.SuspendLayout();
            groupBoxcommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxConnection
            // 
            groupBoxConnection.Controls.Add(btnrefresh);
            groupBoxConnection.Controls.Add(PRGBARCONNECTIONSTATUS);
            groupBoxConnection.Controls.Add(LBLCONNECTIONSTATUS);
            groupBoxConnection.Controls.Add(BTNDISCONNECT);
            groupBoxConnection.Controls.Add(BTNCONNECT);
            groupBoxConnection.Controls.Add(COMBOXPARITYBIT);
            groupBoxConnection.Controls.Add(COMBOXSTOPBITS);
            groupBoxConnection.Controls.Add(LBLPARITYBIT);
            groupBoxConnection.Controls.Add(LBLSTOPBITS);
            groupBoxConnection.Controls.Add(COMBOXBAUDRATE);
            groupBoxConnection.Controls.Add(LBLBOUDRATE);
            groupBoxConnection.Controls.Add(COMBOXCOMPORT);
            groupBoxConnection.Controls.Add(LBLCOMPORT);
            groupBoxConnection.Location = new Point(12, 12);
            groupBoxConnection.Name = "groupBoxConnection";
            groupBoxConnection.Size = new Size(254, 235);
            groupBoxConnection.TabIndex = 0;
            groupBoxConnection.TabStop = false;
            groupBoxConnection.Text = "connection";
            groupBoxConnection.Enter += groupBox1_Enter;
            // 
            // btnrefresh
            // 
            btnrefresh.BackgroundImage = (Image)resources.GetObject("btnrefresh.BackgroundImage");
            btnrefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnrefresh.Location = new Point(225, 28);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(26, 21);
            btnrefresh.TabIndex = 55;
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // PRGBARCONNECTIONSTATUS
            // 
            PRGBARCONNECTIONSTATUS.Location = new Point(98, 202);
            PRGBARCONNECTIONSTATUS.Name = "PRGBARCONNECTIONSTATUS";
            PRGBARCONNECTIONSTATUS.Size = new Size(121, 23);
            PRGBARCONNECTIONSTATUS.TabIndex = 11;
            PRGBARCONNECTIONSTATUS.Click += PRGBARCONNECTIONSTATUS_Click;
            // 
            // LBLCONNECTIONSTATUS
            // 
            LBLCONNECTIONSTATUS.AutoSize = true;
            LBLCONNECTIONSTATUS.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LBLCONNECTIONSTATUS.Location = new Point(106, 174);
            LBLCONNECTIONSTATUS.Name = "LBLCONNECTIONSTATUS";
            LBLCONNECTIONSTATUS.Size = new Size(100, 20);
            LBLCONNECTIONSTATUS.TabIndex = 10;
            LBLCONNECTIONSTATUS.Text = "Unsuccessful";
            LBLCONNECTIONSTATUS.Click += LBLCONNECTIONSTATUS_Click;
            // 
            // BTNDISCONNECT
            // 
            BTNDISCONNECT.Location = new Point(6, 202);
            BTNDISCONNECT.Name = "BTNDISCONNECT";
            BTNDISCONNECT.Size = new Size(75, 23);
            BTNDISCONNECT.TabIndex = 9;
            BTNDISCONNECT.Text = "disconnect";
            BTNDISCONNECT.UseVisualStyleBackColor = true;
            BTNDISCONNECT.Click += BTNDISCONNECT_Click;
            // 
            // BTNCONNECT
            // 
            BTNCONNECT.Location = new Point(6, 173);
            BTNCONNECT.Name = "BTNCONNECT";
            BTNCONNECT.Size = new Size(75, 23);
            BTNCONNECT.TabIndex = 8;
            BTNCONNECT.Text = "connect";
            BTNCONNECT.UseVisualStyleBackColor = true;
            BTNCONNECT.Click += BTNCONNECT_Click;
            // 
            // COMBOXPARITYBIT
            // 
            COMBOXPARITYBIT.FormattingEnabled = true;
            COMBOXPARITYBIT.Items.AddRange(new object[] { "None", "Even", "Odd" });
            COMBOXPARITYBIT.Location = new Point(98, 134);
            COMBOXPARITYBIT.Name = "COMBOXPARITYBIT";
            COMBOXPARITYBIT.Size = new Size(121, 23);
            COMBOXPARITYBIT.TabIndex = 7;
            COMBOXPARITYBIT.Text = "None";
            // 
            // COMBOXSTOPBITS
            // 
            COMBOXSTOPBITS.FormattingEnabled = true;
            COMBOXSTOPBITS.Items.AddRange(new object[] { "One", "Two" });
            COMBOXSTOPBITS.Location = new Point(98, 98);
            COMBOXSTOPBITS.Name = "COMBOXSTOPBITS";
            COMBOXSTOPBITS.Size = new Size(121, 23);
            COMBOXSTOPBITS.TabIndex = 6;
            COMBOXSTOPBITS.Text = "One";
            // 
            // LBLPARITYBIT
            // 
            LBLPARITYBIT.AutoSize = true;
            LBLPARITYBIT.Location = new Point(6, 138);
            LBLPARITYBIT.Name = "LBLPARITYBIT";
            LBLPARITYBIT.Size = new Size(84, 15);
            LBLPARITYBIT.TabIndex = 5;
            LBLPARITYBIT.Text = "PARITY BIT -> ";
            // 
            // LBLSTOPBITS
            // 
            LBLSTOPBITS.AutoSize = true;
            LBLSTOPBITS.Location = new Point(6, 102);
            LBLSTOPBITS.Name = "LBLSTOPBITS";
            LBLSTOPBITS.Size = new Size(80, 15);
            LBLSTOPBITS.TabIndex = 4;
            LBLSTOPBITS.Text = "STOP BITS -> ";
            LBLSTOPBITS.Click += LBLSTOPBITS_Click;
            // 
            // COMBOXBAUDRATE
            // 
            COMBOXBAUDRATE.FormattingEnabled = true;
            COMBOXBAUDRATE.Items.AddRange(new object[] { "115200", "9600", "1200" });
            COMBOXBAUDRATE.Location = new Point(98, 62);
            COMBOXBAUDRATE.Name = "COMBOXBAUDRATE";
            COMBOXBAUDRATE.Size = new Size(121, 23);
            COMBOXBAUDRATE.TabIndex = 3;
            COMBOXBAUDRATE.Text = "115200";
            // 
            // LBLBOUDRATE
            // 
            LBLBOUDRATE.AutoSize = true;
            LBLBOUDRATE.Location = new Point(6, 66);
            LBLBOUDRATE.Name = "LBLBOUDRATE";
            LBLBOUDRATE.Size = new Size(84, 15);
            LBLBOUDRATE.TabIndex = 2;
            LBLBOUDRATE.Text = "BAUDRATE -> ";
            // 
            // COMBOXCOMPORT
            // 
            COMBOXCOMPORT.FormattingEnabled = true;
            COMBOXCOMPORT.Location = new Point(98, 26);
            COMBOXCOMPORT.Name = "COMBOXCOMPORT";
            COMBOXCOMPORT.Size = new Size(121, 23);
            COMBOXCOMPORT.TabIndex = 1;
            COMBOXCOMPORT.Text = "COM1";
            // 
            // LBLCOMPORT
            // 
            LBLCOMPORT.AutoSize = true;
            LBLCOMPORT.Location = new Point(6, 30);
            LBLCOMPORT.Name = "LBLCOMPORT";
            LBLCOMPORT.Size = new Size(86, 15);
            LBLCOMPORT.TabIndex = 0;
            LBLCOMPORT.Text = "COM PORT -> ";
            LBLCOMPORT.Click += LBLCOMPORT_Click;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(497, 428);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(75, 23);
            btnreset.TabIndex = 12;
            btnreset.Text = "reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // groupBoxcommand
            // 
            groupBoxcommand.Controls.Add(btnexitboot);
            groupBoxcommand.Controls.Add(btnreset);
            groupBoxcommand.Controls.Add(label3);
            groupBoxcommand.Controls.Add(comboBox1);
            groupBoxcommand.Controls.Add(btnreadout);
            groupBoxcommand.Controls.Add(checkBox8);
            groupBoxcommand.Controls.Add(checkBox4);
            groupBoxcommand.Controls.Add(checkBox9);
            groupBoxcommand.Controls.Add(checkBox5);
            groupBoxcommand.Controls.Add(checkBox6);
            groupBoxcommand.Controls.Add(checkBox3);
            groupBoxcommand.Controls.Add(checkBox2);
            groupBoxcommand.Controls.Add(checkBox1);
            groupBoxcommand.Controls.Add(btnWriteProUnPro);
            groupBoxcommand.Controls.Add(chBoxSelMassErase);
            groupBoxcommand.Controls.Add(chBoxSel7);
            groupBoxcommand.Controls.Add(chBoxSel6);
            groupBoxcommand.Controls.Add(chBoxSel5);
            groupBoxcommand.Controls.Add(chBoxSel4);
            groupBoxcommand.Controls.Add(chBoxSel3);
            groupBoxcommand.Controls.Add(chBoxSel2);
            groupBoxcommand.Controls.Add(chBoxSel1);
            groupBoxcommand.Controls.Add(chBoxSel0);
            groupBoxcommand.Controls.Add(btnerase);
            groupBoxcommand.Controls.Add(btnbrowse);
            groupBoxcommand.Controls.Add(txtbrowsefile);
            groupBoxcommand.Controls.Add(label2);
            groupBoxcommand.Controls.Add(txtwritememoryaddress);
            groupBoxcommand.Controls.Add(btnwritememory);
            groupBoxcommand.Controls.Add(txtgoaddress);
            groupBoxcommand.Controls.Add(label1);
            groupBoxcommand.Controls.Add(btngoaddress);
            groupBoxcommand.Controls.Add(BTNSAVE);
            groupBoxcommand.Controls.Add(txtlength);
            groupBoxcommand.Controls.Add(txtaddress);
            groupBoxcommand.Controls.Add(lbladdresslenght);
            groupBoxcommand.Controls.Add(LBLADDRESS);
            groupBoxcommand.Controls.Add(btnreadmemory);
            groupBoxcommand.Controls.Add(btngetid);
            groupBoxcommand.Controls.Add(btnclear);
            groupBoxcommand.Controls.Add(txtrecievemessage);
            groupBoxcommand.Controls.Add(BTNGETVERSION);
            groupBoxcommand.Controls.Add(BTNGETHELP);
            groupBoxcommand.Location = new Point(272, 12);
            groupBoxcommand.Name = "groupBoxcommand";
            groupBoxcommand.Size = new Size(580, 465);
            groupBoxcommand.TabIndex = 1;
            groupBoxcommand.TabStop = false;
            groupBoxcommand.Text = "commands";
            // 
            // btnexitboot
            // 
            btnexitboot.Location = new Point(416, 429);
            btnexitboot.Name = "btnexitboot";
            btnexitboot.Size = new Size(75, 23);
            btnexitboot.TabIndex = 54;
            btnexitboot.Text = "exit boot";
            btnexitboot.UseVisualStyleBackColor = true;
            btnexitboot.Click += btnexitboot_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 261);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 52;
            label3.Text = "file path";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "level 0 (no protection)", "level 1 (read protection)", "level 2 (chip lock - irreversible)" });
            comboBox1.Location = new Point(91, 429);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 23);
            comboBox1.TabIndex = 51;
            comboBox1.Text = "level 0 (no protection)";
            // 
            // btnreadout
            // 
            btnreadout.Location = new Point(7, 429);
            btnreadout.Name = "btnreadout";
            btnreadout.Size = new Size(75, 23);
            btnreadout.TabIndex = 50;
            btnreadout.Text = "readout_lvl";
            btnreadout.UseVisualStyleBackColor = true;
            btnreadout.Click += button1_Click;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(518, 389);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(52, 19);
            checkBox8.TabIndex = 48;
            checkBox8.Text = "wrp7";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(396, 389);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(52, 19);
            checkBox4.TabIndex = 49;
            checkBox4.Text = "wrp5";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(457, 389);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(52, 19);
            checkBox9.TabIndex = 47;
            checkBox9.Text = "wrp6";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(335, 389);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(52, 19);
            checkBox5.TabIndex = 48;
            checkBox5.Text = "wrp4";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(274, 389);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(52, 19);
            checkBox6.TabIndex = 47;
            checkBox6.Text = "wrp3";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(213, 389);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(52, 19);
            checkBox3.TabIndex = 46;
            checkBox3.Text = "wrp2";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(152, 389);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(52, 19);
            checkBox2.TabIndex = 45;
            checkBox2.Text = "wrp1";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(92, 389);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(52, 19);
            checkBox1.TabIndex = 44;
            checkBox1.Text = "wrp0";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnWriteProUnPro
            // 
            btnWriteProUnPro.Location = new Point(7, 387);
            btnWriteProUnPro.Name = "btnWriteProUnPro";
            btnWriteProUnPro.Size = new Size(75, 23);
            btnWriteProUnPro.TabIndex = 43;
            btnWriteProUnPro.Text = "write_p/up";
            btnWriteProUnPro.UseVisualStyleBackColor = true;
            btnWriteProUnPro.Click += btnWriteProUnPro_Click;
            // 
            // chBoxSelMassErase
            // 
            chBoxSelMassErase.AutoSize = true;
            chBoxSelMassErase.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            chBoxSelMassErase.Location = new Point(91, 327);
            chBoxSelMassErase.Name = "chBoxSelMassErase";
            chBoxSelMassErase.Size = new Size(105, 19);
            chBoxSelMassErase.TabIndex = 42;
            chBoxSelMassErase.Text = "full chip erase";
            chBoxSelMassErase.UseVisualStyleBackColor = true;
            chBoxSelMassErase.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // chBoxSel7
            // 
            chBoxSel7.AutoSize = true;
            chBoxSel7.Location = new Point(437, 353);
            chBoxSel7.Name = "chBoxSel7";
            chBoxSel7.Size = new Size(67, 19);
            chBoxSel7.TabIndex = 41;
            chBoxSel7.Text = "sector 7";
            chBoxSel7.UseVisualStyleBackColor = true;
            // 
            // chBoxSel6
            // 
            chBoxSel6.AutoSize = true;
            chBoxSel6.Location = new Point(360, 353);
            chBoxSel6.Name = "chBoxSel6";
            chBoxSel6.Size = new Size(67, 19);
            chBoxSel6.TabIndex = 40;
            chBoxSel6.Text = "sector 6";
            chBoxSel6.UseVisualStyleBackColor = true;
            // 
            // chBoxSel5
            // 
            chBoxSel5.AutoSize = true;
            chBoxSel5.Location = new Point(283, 353);
            chBoxSel5.Name = "chBoxSel5";
            chBoxSel5.Size = new Size(67, 19);
            chBoxSel5.TabIndex = 39;
            chBoxSel5.Text = "sector 5";
            chBoxSel5.UseVisualStyleBackColor = true;
            // 
            // chBoxSel4
            // 
            chBoxSel4.AutoSize = true;
            chBoxSel4.Location = new Point(206, 353);
            chBoxSel4.Name = "chBoxSel4";
            chBoxSel4.Size = new Size(67, 19);
            chBoxSel4.TabIndex = 38;
            chBoxSel4.Text = "sector 4";
            chBoxSel4.UseVisualStyleBackColor = true;
            // 
            // chBoxSel3
            // 
            chBoxSel3.AutoSize = true;
            chBoxSel3.Location = new Point(437, 327);
            chBoxSel3.Name = "chBoxSel3";
            chBoxSel3.Size = new Size(67, 19);
            chBoxSel3.TabIndex = 35;
            chBoxSel3.Text = "sector 3";
            chBoxSel3.UseVisualStyleBackColor = true;
            // 
            // chBoxSel2
            // 
            chBoxSel2.AutoSize = true;
            chBoxSel2.Location = new Point(360, 327);
            chBoxSel2.Name = "chBoxSel2";
            chBoxSel2.Size = new Size(67, 19);
            chBoxSel2.TabIndex = 34;
            chBoxSel2.Text = "sector 2";
            chBoxSel2.UseVisualStyleBackColor = true;
            // 
            // chBoxSel1
            // 
            chBoxSel1.AutoSize = true;
            chBoxSel1.Location = new Point(283, 327);
            chBoxSel1.Name = "chBoxSel1";
            chBoxSel1.Size = new Size(67, 19);
            chBoxSel1.TabIndex = 33;
            chBoxSel1.Text = "sector 1";
            chBoxSel1.UseVisualStyleBackColor = true;
            // 
            // chBoxSel0
            // 
            chBoxSel0.AutoSize = true;
            chBoxSel0.Location = new Point(206, 327);
            chBoxSel0.Name = "chBoxSel0";
            chBoxSel0.Size = new Size(67, 19);
            chBoxSel0.TabIndex = 32;
            chBoxSel0.Text = "sector 0";
            chBoxSel0.UseVisualStyleBackColor = true;
            chBoxSel0.CheckedChanged += chBoxSel0_CheckedChanged;
            // 
            // btnerase
            // 
            btnerase.Location = new Point(7, 324);
            btnerase.Name = "btnerase";
            btnerase.Size = new Size(75, 23);
            btnerase.TabIndex = 31;
            btnerase.Text = "erase";
            btnerase.UseVisualStyleBackColor = true;
            btnerase.Click += btnerase_Click;
            // 
            // btnbrowse
            // 
            btnbrowse.Location = new Point(435, 279);
            btnbrowse.Name = "btnbrowse";
            btnbrowse.Size = new Size(75, 23);
            btnbrowse.TabIndex = 30;
            btnbrowse.Text = "browse";
            btnbrowse.UseVisualStyleBackColor = true;
            btnbrowse.Click += btnbrowse_Click;
            // 
            // txtbrowsefile
            // 
            txtbrowsefile.Location = new Point(200, 279);
            txtbrowsefile.Name = "txtbrowsefile";
            txtbrowsefile.Size = new Size(227, 23);
            txtbrowsefile.TabIndex = 29;
            txtbrowsefile.TextChanged += txtbrowsefile_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 261);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 28;
            label2.Text = "address";
            // 
            // txtwritememoryaddress
            // 
            txtwritememoryaddress.Location = new Point(92, 279);
            txtwritememoryaddress.Name = "txtwritememoryaddress";
            txtwritememoryaddress.Size = new Size(100, 23);
            txtwritememoryaddress.TabIndex = 27;
            // 
            // btnwritememory
            // 
            btnwritememory.Location = new Point(7, 279);
            btnwritememory.Name = "btnwritememory";
            btnwritememory.Size = new Size(75, 23);
            btnwritememory.TabIndex = 26;
            btnwritememory.Text = "write_mem";
            btnwritememory.UseVisualStyleBackColor = true;
            btnwritememory.Click += btnwritememory_Click;
            // 
            // txtgoaddress
            // 
            txtgoaddress.Location = new Point(92, 224);
            txtgoaddress.Name = "txtgoaddress";
            txtgoaddress.Size = new Size(100, 23);
            txtgoaddress.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 206);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 24;
            label1.Text = "address";
            // 
            // btngoaddress
            // 
            btngoaddress.Location = new Point(7, 224);
            btngoaddress.Name = "btngoaddress";
            btngoaddress.Size = new Size(75, 23);
            btngoaddress.TabIndex = 23;
            btngoaddress.Text = "go_address";
            btngoaddress.UseVisualStyleBackColor = true;
            btngoaddress.Click += btngoaddress_Click;
            // 
            // BTNSAVE
            // 
            BTNSAVE.Location = new Point(306, 171);
            BTNSAVE.Name = "BTNSAVE";
            BTNSAVE.Size = new Size(75, 23);
            BTNSAVE.TabIndex = 22;
            BTNSAVE.Text = "save";
            BTNSAVE.UseVisualStyleBackColor = true;
            BTNSAVE.Click += BTNSAVE_Click;
            // 
            // txtlength
            // 
            txtlength.Location = new Point(200, 172);
            txtlength.Name = "txtlength";
            txtlength.Size = new Size(100, 23);
            txtlength.TabIndex = 21;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(92, 172);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(100, 23);
            txtaddress.TabIndex = 20;
            // 
            // lbladdresslenght
            // 
            lbladdresslenght.AutoSize = true;
            lbladdresslenght.Location = new Point(222, 154);
            lbladdresslenght.Name = "lbladdresslenght";
            lbladdresslenght.Size = new Size(41, 15);
            lbladdresslenght.TabIndex = 19;
            lbladdresslenght.Text = "length";
            // 
            // LBLADDRESS
            // 
            LBLADDRESS.AutoSize = true;
            LBLADDRESS.Location = new Point(115, 154);
            LBLADDRESS.Name = "LBLADDRESS";
            LBLADDRESS.Size = new Size(47, 15);
            LBLADDRESS.TabIndex = 18;
            LBLADDRESS.Text = "address";
            LBLADDRESS.Click += label1_Click;
            // 
            // btnreadmemory
            // 
            btnreadmemory.Location = new Point(7, 172);
            btnreadmemory.Name = "btnreadmemory";
            btnreadmemory.Size = new Size(75, 23);
            btnreadmemory.TabIndex = 17;
            btnreadmemory.Text = "read_mem";
            btnreadmemory.UseVisualStyleBackColor = true;
            btnreadmemory.Click += btnreadmemory_Click;
            // 
            // btngetid
            // 
            btngetid.Location = new Point(6, 84);
            btngetid.Name = "btngetid";
            btngetid.Size = new Size(75, 23);
            btngetid.TabIndex = 16;
            btngetid.Text = "get_ID";
            btngetid.UseVisualStyleBackColor = true;
            btngetid.Click += btngetid_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(496, 145);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 23);
            btnclear.TabIndex = 15;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // txtrecievemessage
            // 
            txtrecievemessage.Location = new Point(85, 22);
            txtrecievemessage.Multiline = true;
            txtrecievemessage.Name = "txtrecievemessage";
            txtrecievemessage.Size = new Size(484, 112);
            txtrecievemessage.TabIndex = 14;
            // 
            // BTNGETVERSION
            // 
            BTNGETVERSION.Location = new Point(6, 55);
            BTNGETVERSION.Name = "BTNGETVERSION";
            BTNGETVERSION.Size = new Size(75, 23);
            BTNGETVERSION.TabIndex = 13;
            BTNGETVERSION.Text = "get_verison";
            BTNGETVERSION.UseVisualStyleBackColor = true;
            BTNGETVERSION.Click += BTNGETVERSION_Click;
            // 
            // BTNGETHELP
            // 
            BTNGETHELP.Location = new Point(6, 26);
            BTNGETHELP.Name = "BTNGETHELP";
            BTNGETHELP.Size = new Size(75, 23);
            BTNGETHELP.TabIndex = 12;
            BTNGETHELP.Text = "get_help";
            BTNGETHELP.UseVisualStyleBackColor = true;
            BTNGETHELP.Click += BTNGETHELP_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.channels4_profile;
            pictureBox1.Location = new Point(58, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Edwardian Script ITC", 19F, FontStyle.Bold);
            label4.Location = new Point(6, 437);
            label4.Name = "label4";
            label4.Size = new Size(260, 31);
            label4.TabIndex = 53;
            label4.Text = "Developed by Huseyin Aykut";
            label4.Click += label4_Click;
            // 
            // STM32F4Programmer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(864, 481);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxcommand);
            Controls.Add(groupBoxConnection);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "STM32F4Programmer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "STM32F4Programmer";
            Load += STM32F4Programmer_Load;
            groupBoxConnection.ResumeLayout(false);
            groupBoxConnection.PerformLayout();
            groupBoxcommand.ResumeLayout(false);
            groupBoxcommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxConnection;
        private ComboBox COMBOXCOMPORT;
        private Label LBLCOMPORT;
        private Label LBLBOUDRATE;
        private ComboBox COMBOXSTOPBITS;
        private Label LBLPARITYBIT;
        private Label LBLSTOPBITS;
        private ComboBox COMBOXBAUDRATE;
        private ComboBox COMBOXPARITYBIT;
        private Button BTNDISCONNECT;
        private Button BTNCONNECT;
        private ProgressBar PRGBARCONNECTIONSTATUS;
        private Label LBLCONNECTIONSTATUS;
        private GroupBox groupBoxcommand;
        private Button btnclear;
        private TextBox txtrecievemessage;
        private Button BTNGETVERSION;
        private Button BTNGETHELP;
        private Button btngetid;
        private Button btnreadmemory;
        private Label LBLADDRESS;
        private TextBox txtlength;
        private TextBox txtaddress;
        private Label lbladdresslenght;
        private Button BTNSAVE;
        private TextBox txtgoaddress;
        private Label label1;
        private Button btngoaddress;
        private Label label2;
        private TextBox txtwritememoryaddress;
        private Button btnwritememory;
        private Button btnbrowse;
        private TextBox txtbrowsefile;
        private OpenFileDialog openFileDialog1;
        private CheckBox chBoxSel7;
        private CheckBox chBoxSel6;
        private CheckBox chBoxSel5;
        private CheckBox chBoxSel4;
        private CheckBox chBoxSel3;
        private CheckBox chBoxSel2;
        private CheckBox chBoxSel1;
        private CheckBox chBoxSel0;
        private Button btnerase;
        private CheckBox chBoxSelMassErase;
        private CheckBox checkBox8;
        private CheckBox checkBox4;
        private CheckBox checkBox9;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button btnWriteProUnPro;
        private Button btnreadout;
        private ComboBox comboBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnreset;
        private Button btnexitboot;
        private Button btnrefresh;
    }
}
