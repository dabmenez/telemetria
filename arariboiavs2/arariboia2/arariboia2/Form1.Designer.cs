namespace arariboia2
{
    partial class arduinoArariboia
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.onButton = new MetroFramework.Controls.MetroButton();
            this.offButton = new MetroFramework.Controls.MetroButton();
            this.ServoAngle = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.RedVal = new System.Windows.Forms.TrackBar();
            this.SendRedVal = new MetroFramework.Controls.MetroButton();
            this.textBox2 = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new MetroFramework.Controls.MetroTextBox();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.GreenVal = new System.Windows.Forms.TrackBar();
            this.YellowVal = new System.Windows.Forms.TrackBar();
            this.SendGreenVal = new MetroFramework.Controls.MetroButton();
            this.SendYellowVal = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.circularProgress = new CircularProgressBar.CircularProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowVal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // onButton
            // 
            this.onButton.Location = new System.Drawing.Point(691, 32);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(75, 23);
            this.onButton.TabIndex = 0;
            this.onButton.Text = "turn on";
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // offButton
            // 
            this.offButton.Location = new System.Drawing.Point(790, 32);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(75, 23);
            this.offButton.TabIndex = 1;
            this.offButton.Text = "turn off";
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // ServoAngle
            // 
            this.ServoAngle.Location = new System.Drawing.Point(111, 45);
            this.ServoAngle.Name = "ServoAngle";
            this.ServoAngle.Size = new System.Drawing.Size(114, 23);
            this.ServoAngle.TabIndex = 2;
            this.ServoAngle.Text = "Send Angle";
            this.ServoAngle.Click += new System.EventHandler(this.ServoAngle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 23);
            this.textBox1.TabIndex = 3;
            // 
            // RedVal
            // 
            this.RedVal.Location = new System.Drawing.Point(9, 15);
            this.RedVal.Maximum = 255;
            this.RedVal.Name = "RedVal";
            this.RedVal.Size = new System.Drawing.Size(174, 56);
            this.RedVal.TabIndex = 4;
            this.RedVal.TickFrequency = 10;
            this.RedVal.Scroll += new System.EventHandler(this.RedVal_Scroll);
            // 
            // SendRedVal
            // 
            this.SendRedVal.Location = new System.Drawing.Point(199, 15);
            this.SendRedVal.Name = "SendRedVal";
            this.SendRedVal.Size = new System.Drawing.Size(107, 34);
            this.SendRedVal.Style = MetroFramework.MetroColorStyle.Red;
            this.SendRedVal.TabIndex = 5;
            this.SendRedVal.Text = "Send Red Value";
            this.SendRedVal.UseWaitCursor = true;
            this.SendRedVal.Click += new System.EventHandler(this.SendRedVal_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 23);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(167, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "BOTÃO";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 23);
            this.textBox3.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(64, 180);
            this.progressBar1.Maximum = 1023;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(181, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // GreenVal
            // 
            this.GreenVal.Location = new System.Drawing.Point(9, 66);
            this.GreenVal.Maximum = 255;
            this.GreenVal.Name = "GreenVal";
            this.GreenVal.Size = new System.Drawing.Size(174, 56);
            this.GreenVal.TabIndex = 10;
            this.GreenVal.TickFrequency = 10;
            this.GreenVal.Scroll += new System.EventHandler(this.GreenVal_Scroll);
            // 
            // YellowVal
            // 
            this.YellowVal.Location = new System.Drawing.Point(9, 117);
            this.YellowVal.Maximum = 255;
            this.YellowVal.Name = "YellowVal";
            this.YellowVal.Size = new System.Drawing.Size(174, 56);
            this.YellowVal.TabIndex = 11;
            this.YellowVal.TickFrequency = 10;
            this.YellowVal.Scroll += new System.EventHandler(this.YellowVal_Scroll);
            // 
            // SendGreenVal
            // 
            this.SendGreenVal.Location = new System.Drawing.Point(199, 66);
            this.SendGreenVal.Name = "SendGreenVal";
            this.SendGreenVal.Size = new System.Drawing.Size(107, 34);
            this.SendGreenVal.Style = MetroFramework.MetroColorStyle.Green;
            this.SendGreenVal.TabIndex = 12;
            this.SendGreenVal.Text = "Send Green Val";
            this.SendGreenVal.Click += new System.EventHandler(this.SendGreenVal_Click);
            // 
            // SendYellowVal
            // 
            this.SendYellowVal.Location = new System.Drawing.Point(199, 117);
            this.SendYellowVal.Name = "SendYellowVal";
            this.SendYellowVal.Size = new System.Drawing.Size(107, 34);
            this.SendYellowVal.Style = MetroFramework.MetroColorStyle.Yellow;
            this.SendYellowVal.TabIndex = 13;
            this.SendYellowVal.Text = "Send Yellow Val";
            this.SendYellowVal.Click += new System.EventHandler(this.SendYellowVal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(207, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "DASHBOARD";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.SendRedVal);
            this.panel3.Controls.Add(this.RedVal);
            this.panel3.Controls.Add(this.GreenVal);
            this.panel3.Controls.Add(this.SendYellowVal);
            this.panel3.Controls.Add(this.YellowVal);
            this.panel3.Controls.Add(this.SendGreenVal);
            this.panel3.Location = new System.Drawing.Point(213, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 177);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.ServoAngle);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(580, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 85);
            this.panel4.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(580, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(318, 85);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.circularProgress);
            this.panel6.Controls.Add(this.progressBar1);
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Location = new System.Drawing.Point(213, 306);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 259);
            this.panel6.TabIndex = 19;
            // 
            // circularProgress
            // 
            this.circularProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgress.AnimationSpeed = 500;
            this.circularProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.circularProgress.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgress.ForeColor = System.Drawing.Color.Silver;
            this.circularProgress.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.circularProgress.InnerMargin = 2;
            this.circularProgress.InnerWidth = -1;
            this.circularProgress.Location = new System.Drawing.Point(80, 9);
            this.circularProgress.MarqueeAnimationSpeed = 2000;
            this.circularProgress.Maximum = 1023;
            this.circularProgress.Name = "circularProgress";
            this.circularProgress.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.circularProgress.OuterMargin = -25;
            this.circularProgress.OuterWidth = 26;
            this.circularProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(249)))));
            this.circularProgress.ProgressWidth = 7;
            this.circularProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgress.Size = new System.Drawing.Size(150, 150);
            this.circularProgress.StartAngle = 270;
            this.circularProgress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgress.SubscriptText = "";
            this.circularProgress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgress.SuperscriptText = "";
            this.circularProgress.TabIndex = 0;
            this.circularProgress.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.circularProgress.Value = 68;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(897, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = global::arariboia2.Properties.Resources.apda;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::arariboia2.Properties.Resources.f5fa9180700861_Y3JvcCw3NDYsNTg0LDMxMCw5NA;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // arduinoArariboia
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.onButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "arduinoArariboia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.RedVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowVal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.IO.Ports.SerialPort serialPort;
        private MetroFramework.Controls.MetroButton onButton;
        private MetroFramework.Controls.MetroButton offButton;
        private MetroFramework.Controls.MetroButton ServoAngle;
        private MetroFramework.Controls.MetroTextBox textBox1;
        private System.Windows.Forms.TrackBar RedVal;
        private MetroFramework.Controls.MetroButton SendRedVal;
        private MetroFramework.Controls.MetroTextBox textBox2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox textBox3;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private System.Windows.Forms.TrackBar GreenVal;
        private System.Windows.Forms.TrackBar YellowVal;
        private MetroFramework.Controls.MetroButton SendGreenVal;
        private MetroFramework.Controls.MetroButton SendYellowVal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private CircularProgressBar.CircularProgressBar circularProgress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

