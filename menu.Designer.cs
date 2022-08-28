namespace Onixgn
{
    partial class menu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.timerPortScanner = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonInitIP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddy = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonTogglePortScanner = new System.Windows.Forms.Button();
            this.richTextBoxPortScanner = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaxPort = new System.Windows.Forms.TextBox();
            this.textBoxMinPort = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButtonUdp = new System.Windows.Forms.RadioButton();
            this.radioButtonTcp = new System.Windows.Forms.RadioButton();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonToggleSpammer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerPacketSpam = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPortScanner
            // 
            this.timerPortScanner.Interval = 15;
            this.timerPortScanner.Tick += new System.EventHandler(this.timerPortScanner_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 311);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonInitIP);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxAddy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonInitIP
            // 
            this.buttonInitIP.Location = new System.Drawing.Point(246, 140);
            this.buttonInitIP.Name = "buttonInitIP";
            this.buttonInitIP.Size = new System.Drawing.Size(75, 23);
            this.buttonInitIP.TabIndex = 6;
            this.buttonInitIP.Text = "Initiliaze";
            this.buttonInitIP.UseVisualStyleBackColor = true;
            this.buttonInitIP.Click += new System.EventHandler(this.buttonInitIP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter a valid IP Addres or hostname...";
            // 
            // textBoxAddy
            // 
            this.textBoxAddy.Location = new System.Drawing.Point(194, 95);
            this.textBoxAddy.Name = "textBoxAddy";
            this.textBoxAddy.Size = new System.Drawing.Size(198, 20);
            this.textBoxAddy.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonTogglePortScanner);
            this.tabPage2.Controls.Add(this.richTextBoxPortScanner);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxMaxPort);
            this.tabPage2.Controls.Add(this.textBoxMinPort);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Port Scanner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonTogglePortScanner
            // 
            this.buttonTogglePortScanner.Location = new System.Drawing.Point(75, 145);
            this.buttonTogglePortScanner.Name = "buttonTogglePortScanner";
            this.buttonTogglePortScanner.Size = new System.Drawing.Size(99, 23);
            this.buttonTogglePortScanner.TabIndex = 6;
            this.buttonTogglePortScanner.Text = "Start Scanner";
            this.buttonTogglePortScanner.UseVisualStyleBackColor = true;
            this.buttonTogglePortScanner.Click += new System.EventHandler(this.buttonTogglePortScanner_Click);
            // 
            // richTextBoxPortScanner
            // 
            this.richTextBoxPortScanner.BackColor = System.Drawing.Color.Black;
            this.richTextBoxPortScanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxPortScanner.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxPortScanner.ForeColor = System.Drawing.Color.DodgerBlue;
            this.richTextBoxPortScanner.Location = new System.Drawing.Point(248, 6);
            this.richTextBoxPortScanner.Name = "richTextBoxPortScanner";
            this.richTextBoxPortScanner.ReadOnly = true;
            this.richTextBoxPortScanner.Size = new System.Drawing.Size(342, 273);
            this.richTextBoxPortScanner.TabIndex = 5;
            this.richTextBoxPortScanner.Text = "[ONIXGN Port-Scanner Output]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Min Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // textBoxMaxPort
            // 
            this.textBoxMaxPort.Location = new System.Drawing.Point(140, 60);
            this.textBoxMaxPort.Name = "textBoxMaxPort";
            this.textBoxMaxPort.Size = new System.Drawing.Size(102, 20);
            this.textBoxMaxPort.TabIndex = 1;
            this.textBoxMaxPort.Text = "65535";
            this.textBoxMaxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMinPort
            // 
            this.textBoxMinPort.Location = new System.Drawing.Point(16, 60);
            this.textBoxMinPort.Name = "textBoxMinPort";
            this.textBoxMinPort.Size = new System.Drawing.Size(102, 20);
            this.textBoxMinPort.TabIndex = 0;
            this.textBoxMinPort.Text = "0";
            this.textBoxMinPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radioButtonUdp);
            this.tabPage3.Controls.Add(this.radioButtonTcp);
            this.tabPage3.Controls.Add(this.textBoxPort);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.buttonToggleSpammer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(596, 285);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Packet spam";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButtonUdp
            // 
            this.radioButtonUdp.AutoSize = true;
            this.radioButtonUdp.Location = new System.Drawing.Point(298, 169);
            this.radioButtonUdp.Name = "radioButtonUdp";
            this.radioButtonUdp.Size = new System.Drawing.Size(48, 17);
            this.radioButtonUdp.TabIndex = 12;
            this.radioButtonUdp.Text = "UDP";
            this.radioButtonUdp.UseVisualStyleBackColor = true;
            // 
            // radioButtonTcp
            // 
            this.radioButtonTcp.AutoSize = true;
            this.radioButtonTcp.Checked = true;
            this.radioButtonTcp.Location = new System.Drawing.Point(246, 169);
            this.radioButtonTcp.Name = "radioButtonTcp";
            this.radioButtonTcp.Size = new System.Drawing.Size(46, 17);
            this.radioButtonTcp.TabIndex = 11;
            this.radioButtonTcp.TabStop = true;
            this.radioButtonTcp.Text = "TCP";
            this.radioButtonTcp.UseVisualStyleBackColor = true;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(194, 95);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(198, 20);
            this.textBoxPort.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please enter a valid port...";
            // 
            // buttonToggleSpammer
            // 
            this.buttonToggleSpammer.Location = new System.Drawing.Point(246, 140);
            this.buttonToggleSpammer.Name = "buttonToggleSpammer";
            this.buttonToggleSpammer.Size = new System.Drawing.Size(99, 23);
            this.buttonToggleSpammer.TabIndex = 7;
            this.buttonToggleSpammer.Text = "Start Spammer";
            this.buttonToggleSpammer.UseVisualStyleBackColor = true;
            this.buttonToggleSpammer.Click += new System.EventHandler(this.buttonToggleSpammer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timerPacketSpam
            // 
            this.timerPacketSpam.Interval = 15;
            this.timerPacketSpam.Tick += new System.EventHandler(this.timerPacketSpam_Tick);
            // 
            // menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 421);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[version 1]";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerPortScanner;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonInitIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddy;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonTogglePortScanner;
        private System.Windows.Forms.RichTextBox richTextBoxPortScanner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaxPort;
        private System.Windows.Forms.TextBox textBoxMinPort;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerPacketSpam;
        private System.Windows.Forms.Button buttonToggleSpammer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.RadioButton radioButtonUdp;
        private System.Windows.Forms.RadioButton radioButtonTcp;
    }
}

