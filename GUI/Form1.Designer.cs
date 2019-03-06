namespace GUI
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textPw = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbody = new System.Windows.Forms.RichTextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtdestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtattachment = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupboxCompo = new System.Windows.Forms.GroupBox();
            this.stopTimerBtn = new System.Windows.Forms.Button();
            this.timerSetBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timerSetTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.timerBtn = new System.Windows.Forms.Button();
            this.timerTxt = new System.Windows.Forms.Label();
            this.EmailListBox = new System.Windows.Forms.ListBox();
            this.groupboxGrid = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvUserData = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailAppDataSet1 = new GUI.emailAppDataSet1();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emailAppDataSet2 = new GUI.emailAppDataSet2();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.emailAppDataSet = new GUI.emailAppDataSet();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTableAdapter = new GUI.emailAppDataSetTableAdapters.addressTableAdapter();
            this.contractTableAdapter = new GUI.emailAppDataSet1TableAdapters.contractTableAdapter();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.mailTimer = new System.Windows.Forms.Timer(this.components);
            this.contractTableAdapter1 = new GUI.emailAppDataSet2TableAdapters.contractTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxLog.SuspendLayout();
            this.groupboxCompo.SuspendLayout();
            this.groupboxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAppDataSet2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1417, 26);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1358, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1330, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1387, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 330);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(11, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Automatic E-mail";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.btnLogout);
            this.groupBoxLog.Controls.Add(this.btnLogin);
            this.groupBoxLog.Controls.Add(this.textPw);
            this.groupBoxLog.Controls.Add(this.textEmail);
            this.groupBoxLog.Controls.Add(this.label8);
            this.groupBoxLog.Controls.Add(this.label6);
            this.groupBoxLog.Location = new System.Drawing.Point(47, 64);
            this.groupBoxLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLog.Size = new System.Drawing.Size(441, 171);
            this.groupBoxLog.TabIndex = 17;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Login";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(157, 118);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(67, 28);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(57, 118);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(67, 28);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textPw
            // 
            this.textPw.Location = new System.Drawing.Point(89, 75);
            this.textPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPw.Name = "textPw";
            this.textPw.Size = new System.Drawing.Size(172, 25);
            this.textPw.TabIndex = 20;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(89, 34);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(172, 25);
            this.textEmail.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "E-mail:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(218, 306);
            this.txtbody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(513, 200);
            this.txtbody.TabIndex = 0;
            this.txtbody.Text = "";
            this.txtbody.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(216, 221);
            this.txtsubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(247, 25);
            this.txtsubject.TabIndex = 3;
            // 
            // txtdestination
            // 
            this.txtdestination.Location = new System.Drawing.Point(216, 180);
            this.txtdestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdestination.Name = "txtdestination";
            this.txtdestination.Size = new System.Drawing.Size(247, 25);
            this.txtdestination.TabIndex = 4;
            this.txtdestination.TextChanged += new System.EventHandler(this.destination_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "To:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Attachment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(467, 259);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(89, 26);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(862, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 16;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtattachment
            // 
            this.txtattachment.Location = new System.Drawing.Point(216, 264);
            this.txtattachment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtattachment.Name = "txtattachment";
            this.txtattachment.Size = new System.Drawing.Size(247, 25);
            this.txtattachment.TabIndex = 2;
            this.txtattachment.TextChanged += new System.EventHandler(this.txtattachment_TextChanged);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(216, 526);
            this.btnsend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(80, 36);
            this.btnsend.TabIndex = 10;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(314, 526);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(78, 36);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // groupboxCompo
            // 
            this.groupboxCompo.Controls.Add(this.stopTimerBtn);
            this.groupboxCompo.Controls.Add(this.timerSetBtn);
            this.groupboxCompo.Controls.Add(this.label13);
            this.groupboxCompo.Controls.Add(this.label12);
            this.groupboxCompo.Controls.Add(this.timerSetTextBox);
            this.groupboxCompo.Controls.Add(this.button5);
            this.groupboxCompo.Controls.Add(this.timerBtn);
            this.groupboxCompo.Controls.Add(this.timerTxt);
            this.groupboxCompo.Controls.Add(this.EmailListBox);
            this.groupboxCompo.Controls.Add(this.txtbody);
            this.groupboxCompo.Controls.Add(this.btncancel);
            this.groupboxCompo.Controls.Add(this.btnBrowse);
            this.groupboxCompo.Controls.Add(this.btnsend);
            this.groupboxCompo.Controls.Add(this.label2);
            this.groupboxCompo.Controls.Add(this.txtattachment);
            this.groupboxCompo.Controls.Add(this.txtsubject);
            this.groupboxCompo.Controls.Add(this.label1);
            this.groupboxCompo.Controls.Add(this.label3);
            this.groupboxCompo.Controls.Add(this.txtdestination);
            this.groupboxCompo.Location = new System.Drawing.Point(614, 64);
            this.groupboxCompo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxCompo.Name = "groupboxCompo";
            this.groupboxCompo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxCompo.Size = new System.Drawing.Size(758, 581);
            this.groupboxCompo.TabIndex = 18;
            this.groupboxCompo.TabStop = false;
            this.groupboxCompo.Text = "Compose";
            this.groupboxCompo.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // stopTimerBtn
            // 
            this.stopTimerBtn.Location = new System.Drawing.Point(668, 260);
            this.stopTimerBtn.Name = "stopTimerBtn";
            this.stopTimerBtn.Size = new System.Drawing.Size(75, 23);
            this.stopTimerBtn.TabIndex = 26;
            this.stopTimerBtn.Text = "stop";
            this.stopTimerBtn.UseVisualStyleBackColor = true;
            this.stopTimerBtn.Click += new System.EventHandler(this.stopTimerBtn_Click);
            // 
            // timerSetBtn
            // 
            this.timerSetBtn.Location = new System.Drawing.Point(668, 182);
            this.timerSetBtn.Name = "timerSetBtn";
            this.timerSetBtn.Size = new System.Drawing.Size(75, 23);
            this.timerSetBtn.TabIndex = 25;
            this.timerSetBtn.Text = "SET";
            this.timerSetBtn.UseVisualStyleBackColor = true;
            this.timerSetBtn.Click += new System.EventHandler(this.timerSetBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(470, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Timer Set";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Mutlple sending Group:";
            // 
            // timerSetTextBox
            // 
            this.timerSetTextBox.Location = new System.Drawing.Point(551, 180);
            this.timerSetTextBox.Name = "timerSetTextBox";
            this.timerSetTextBox.Size = new System.Drawing.Size(100, 25);
            this.timerSetTextBox.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(421, 526);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 11;
            this.button5.Text = "sendTest";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // timerBtn
            // 
            this.timerBtn.Location = new System.Drawing.Point(668, 223);
            this.timerBtn.Name = "timerBtn";
            this.timerBtn.Size = new System.Drawing.Size(75, 23);
            this.timerBtn.TabIndex = 22;
            this.timerBtn.Text = "start";
            this.timerBtn.UseVisualStyleBackColor = true;
            this.timerBtn.Click += new System.EventHandler(this.timerBtn_Click);
            // 
            // timerTxt
            // 
            this.timerTxt.AutoSize = true;
            this.timerTxt.Location = new System.Drawing.Point(559, 227);
            this.timerTxt.Name = "timerTxt";
            this.timerTxt.Size = new System.Drawing.Size(44, 15);
            this.timerTxt.TabIndex = 21;
            this.timerTxt.Text = "--:--";
            // 
            // EmailListBox
            // 
            this.EmailListBox.FormattingEnabled = true;
            this.EmailListBox.ItemHeight = 15;
            this.EmailListBox.Location = new System.Drawing.Point(218, 34);
            this.EmailListBox.Name = "EmailListBox";
            this.EmailListBox.Size = new System.Drawing.Size(513, 124);
            this.EmailListBox.TabIndex = 21;
            this.EmailListBox.DoubleClick += new System.EventHandler(this.Mouse);
            this.EmailListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MouseDoubleClick);
            // 
            // groupboxGrid
            // 
            this.groupboxGrid.Controls.Add(this.btnSearch);
            this.groupboxGrid.Controls.Add(this.dgvUserData);
            this.groupboxGrid.Controls.Add(this.btnEdit);
            this.groupboxGrid.Controls.Add(this.btnRemove);
            this.groupboxGrid.Controls.Add(this.btnAddEmail);
            this.groupboxGrid.Controls.Add(this.txtEmailAdd);
            this.groupboxGrid.Controls.Add(this.txtNameAdd);
            this.groupboxGrid.Controls.Add(this.label5);
            this.groupboxGrid.Controls.Add(this.txtName);
            this.groupboxGrid.Location = new System.Drawing.Point(6, 21);
            this.groupboxGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxGrid.Name = "groupboxGrid";
            this.groupboxGrid.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxGrid.Size = new System.Drawing.Size(441, 328);
            this.groupboxGrid.TabIndex = 19;
            this.groupboxGrid.TabStop = false;
            this.groupboxGrid.Text = "Groups";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(278, 94);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 26);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dgvUserData
            // 
            this.dgvUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserData.Location = new System.Drawing.Point(17, 130);
            this.dgvUserData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUserData.Name = "dgvUserData";
            this.dgvUserData.RowTemplate.Height = 28;
            this.dgvUserData.Size = new System.Drawing.Size(408, 172);
            this.dgvUserData.TabIndex = 20;
            this.dgvUserData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(113, 94);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 26);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(185, 94);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 26);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Location = new System.Drawing.Point(34, 94);
            this.btnAddEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(67, 26);
            this.btnAddEmail.TabIndex = 17;
            this.btnAddEmail.Text = "Add";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Location = new System.Drawing.Point(89, 58);
            this.txtEmailAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(172, 25);
            this.txtEmailAdd.TabIndex = 16;
            this.txtEmailAdd.TextChanged += new System.EventHandler(this.textEmailAdd_TextChanged);
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(89, 26);
            this.txtNameAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(172, 25);
            this.txtNameAdd.TabIndex = 15;
            this.txtNameAdd.TextChanged += new System.EventHandler(this.txtNameAdd_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "E-mail:";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(30, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(48, 15);
            this.txtName.TabIndex = 13;
            this.txtName.Text = "Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(29, 253);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 385);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(451, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Group 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(441, 328);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Groups";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Id";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource1, "id", true));
            this.IdTextBox.Location = new System.Drawing.Point(350, 54);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(70, 25);
            this.IdTextBox.TabIndex = 22;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "contract";
            this.contractBindingSource.DataSource = this.emailAppDataSet1;
            // 
            // emailAppDataSet1
            // 
            this.emailAppDataSet1.DataSetName = "emailAppDataSet1";
            this.emailAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.contractBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 20);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(435, 27);
            this.bindingNavigator1.TabIndex = 21;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "새로 추가";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(33, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "전체 항목 수";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "처음으로 이동";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "이전으로 이동";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "위치";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "현재 위치";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "다음으로 이동";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "마지막으로 이동";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.name,
            this.userEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contractBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 152);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(426, 172);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "userEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "userEmail";
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            // 
            // contractBindingSource1
            // 
            this.contractBindingSource1.DataMember = "contract";
            this.contractBindingSource1.DataSource = this.emailAppDataSet2;
            // 
            // emailAppDataSet2
            // 
            this.emailAppDataSet2.DataSetName = "emailAppDataSet2";
            this.emailAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(153, 122);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(67, 26);
            this.EditButton.TabIndex = 19;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(225, 122);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(88, 26);
            this.DeleteBtn.TabIndex = 18;
            this.DeleteBtn.Text = "Remove";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 26);
            this.button4.TabIndex = 17;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "userEmail", true));
            this.EmailTextBox.Location = new System.Drawing.Point(129, 86);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(172, 25);
            this.EmailTextBox.TabIndex = 16;
            // 
            // NameTextBox
            // 
            this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "name", true));
            this.NameTextBox.Location = new System.Drawing.Point(129, 54);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(172, 25);
            this.NameTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Name:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupboxGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(451, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Group 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // emailAppDataSet
            // 
            this.emailAppDataSet.DataSetName = "emailAppDataSet";
            this.emailAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "address";
            this.addressBindingSource.DataSource = this.emailAppDataSet;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // mailTimer
            // 
            this.mailTimer.Interval = 1000;
            this.mailTimer.Tick += new System.EventHandler(this.mailTimer_Tick);
            // 
            // contractTableAdapter1
            // 
            this.contractTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1417, 793);
            this.Controls.Add(this.groupBoxLog);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupboxCompo);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxLog.ResumeLayout(false);
            this.groupBoxLog.PerformLayout();
            this.groupboxCompo.ResumeLayout(false);
            this.groupboxCompo.PerformLayout();
            this.groupboxGrid.ResumeLayout(false);
            this.groupboxGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAppDataSet2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emailAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textPw;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtbody;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.TextBox txtdestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtattachment;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.GroupBox groupboxCompo;
        private System.Windows.Forms.GroupBox groupboxGrid;
        private System.Windows.Forms.DataGridView dgvUserData;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private emailAppDataSet emailAppDataSet;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private emailAppDataSetTableAdapters.addressTableAdapter addressTableAdapter;
        private emailAppDataSet1 emailAppDataSet1;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private emailAppDataSet1TableAdapters.contractTableAdapter contractTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox EmailListBox;
        private System.Windows.Forms.Label label12;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Timer mailTimer;
        private System.Windows.Forms.Label timerTxt;
        private System.Windows.Forms.Button timerBtn;
        private System.Windows.Forms.TextBox timerSetTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button timerSetBtn;
        private System.Windows.Forms.Button stopTimerBtn;
        private emailAppDataSet2 emailAppDataSet2;
        private System.Windows.Forms.BindingSource contractBindingSource1;
        private emailAppDataSet2TableAdapters.contractTableAdapter contractTableAdapter1;
    }
}

