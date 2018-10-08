using System;

namespace SICKLMS511_reader
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
            this.textIPAddress = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.butConnect = new System.Windows.Forms.Button();
            this.butGetData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.processDataBtn = new System.Windows.Forms.Button();
            this.graphPicBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textIPAddress
            // 
            this.textIPAddress.BackColor = System.Drawing.Color.LimeGreen;
            this.textIPAddress.Location = new System.Drawing.Point(6, 41);
            this.textIPAddress.Name = "textIPAddress";
            this.textIPAddress.Size = new System.Drawing.Size(100, 20);
            this.textIPAddress.TabIndex = 0;
            this.textIPAddress.Text = "192.168.1.1";
            this.textIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textIPAddress.TextChanged += new System.EventHandler(this.textIPAddress_TextChanged);
            // 
            // textPort
            // 
            this.textPort.BackColor = System.Drawing.Color.LimeGreen;
            this.textPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPort.Location = new System.Drawing.Point(137, 41);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(83, 20);
            this.textPort.TabIndex = 1;
            this.textPort.Text = "2111";
            this.textPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butConnect
            // 
            this.butConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butConnect.Location = new System.Drawing.Point(310, 38);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(75, 23);
            this.butConnect.TabIndex = 2;
            this.butConnect.Text = "Connect";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // butGetData
            // 
            this.butGetData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butGetData.Location = new System.Drawing.Point(404, 38);
            this.butGetData.Name = "butGetData";
            this.butGetData.Size = new System.Drawing.Size(75, 23);
            this.butGetData.TabIndex = 3;
            this.butGetData.Text = "Get Data";
            this.butGetData.UseVisualStyleBackColor = true;
            this.butGetData.Click += new System.EventHandler(this.butGetData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Laser IP Address: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butGetData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butConnect);
            this.groupBox1.Controls.Add(this.textIPAddress);
            this.groupBox1.Controls.Add(this.textPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Laser Port: ";
            // 
            // textData
            // 
            this.textData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textData.Location = new System.Drawing.Point(12, 92);
            this.textData.Multiline = true;
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(486, 258);
            this.textData.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.processDataBtn);
            this.groupBox2.Location = new System.Drawing.Point(504, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 73);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // processDataBtn
            // 
            this.processDataBtn.Location = new System.Drawing.Point(6, 38);
            this.processDataBtn.Name = "processDataBtn";
            this.processDataBtn.Size = new System.Drawing.Size(119, 23);
            this.processDataBtn.TabIndex = 0;
            this.processDataBtn.Text = "Process Data";
            this.processDataBtn.UseVisualStyleBackColor = true;
            this.processDataBtn.Click += new System.EventHandler(this.processDataBtn_Click);
            // 
            // graphPicBox
            // 
            this.graphPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.graphPicBox.Location = new System.Drawing.Point(504, 92);
            this.graphPicBox.Name = "graphPicBox";
            this.graphPicBox.Size = new System.Drawing.Size(368, 258);
            this.graphPicBox.TabIndex = 8;
            this.graphPicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 362);
            this.Controls.Add(this.graphPicBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(526, 400);
            this.Name = "Form1";
            this.Text = "LMS511 Reader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textIPAddress;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button butGetData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button processDataBtn;
        private System.Windows.Forms.PictureBox graphPicBox;
    }
}

