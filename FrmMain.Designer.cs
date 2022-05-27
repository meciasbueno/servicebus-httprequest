namespace Servicebus.http
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtServicebusNamespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQueueNameOrTopicName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccessKeyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccessKey = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.mmMessage = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLinkGit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFormatXml = new System.Windows.Forms.RadioButton();
            this.rbFormatText = new System.Windows.Forms.RadioButton();
            this.rbFormatJson = new System.Windows.Forms.RadioButton();
            this.btLoadFromConnectionString = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServicebusNamespace
            // 
            this.txtServicebusNamespace.Location = new System.Drawing.Point(19, 126);
            this.txtServicebusNamespace.Name = "txtServicebusNamespace";
            this.txtServicebusNamespace.Size = new System.Drawing.Size(356, 20);
            this.txtServicebusNamespace.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servicebus Namespace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Queue name or Topic name";
            // 
            // txtQueueNameOrTopicName
            // 
            this.txtQueueNameOrTopicName.Location = new System.Drawing.Point(19, 171);
            this.txtQueueNameOrTopicName.Name = "txtQueueNameOrTopicName";
            this.txtQueueNameOrTopicName.Size = new System.Drawing.Size(356, 20);
            this.txtQueueNameOrTopicName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Access Key Name";
            // 
            // txtAccessKeyName
            // 
            this.txtAccessKeyName.Location = new System.Drawing.Point(19, 34);
            this.txtAccessKeyName.Name = "txtAccessKeyName";
            this.txtAccessKeyName.Size = new System.Drawing.Size(356, 20);
            this.txtAccessKeyName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Access Key";
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.Location = new System.Drawing.Point(19, 80);
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.Size = new System.Drawing.Size(356, 20);
            this.txtAccessKey.TabIndex = 1;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(300, 362);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 8;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // mmMessage
            // 
            this.mmMessage.Location = new System.Drawing.Point(19, 220);
            this.mmMessage.Name = "mmMessage";
            this.mmMessage.Size = new System.Drawing.Size(356, 131);
            this.mmMessage.TabIndex = 9;
            this.mmMessage.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Message";
            // 
            // txtLinkGit
            // 
            this.txtLinkGit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLinkGit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLinkGit.Location = new System.Drawing.Point(19, 416);
            this.txtLinkGit.Name = "txtLinkGit";
            this.txtLinkGit.Size = new System.Drawing.Size(330, 13);
            this.txtLinkGit.TabIndex = 12;
            this.txtLinkGit.Text = "Saiba mais: https://github.com/meciasbueno/servicebus-httprequest";
            this.txtLinkGit.Click += new System.EventHandler(this.txtLinkGit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFormatXml);
            this.panel1.Controls.Add(this.rbFormatText);
            this.panel1.Controls.Add(this.rbFormatJson);
            this.panel1.Location = new System.Drawing.Point(67, 200);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 18);
            this.panel1.TabIndex = 15;
            // 
            // rbFormatXml
            // 
            this.rbFormatXml.AutoSize = true;
            this.rbFormatXml.Location = new System.Drawing.Point(93, 2);
            this.rbFormatXml.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFormatXml.Name = "rbFormatXml";
            this.rbFormatXml.Size = new System.Drawing.Size(42, 17);
            this.rbFormatXml.TabIndex = 21;
            this.rbFormatXml.TabStop = true;
            this.rbFormatXml.Text = "Xml";
            this.rbFormatXml.UseVisualStyleBackColor = true;
            // 
            // rbFormatText
            // 
            this.rbFormatText.AutoSize = true;
            this.rbFormatText.Location = new System.Drawing.Point(47, 2);
            this.rbFormatText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFormatText.Name = "rbFormatText";
            this.rbFormatText.Size = new System.Drawing.Size(46, 17);
            this.rbFormatText.TabIndex = 20;
            this.rbFormatText.TabStop = true;
            this.rbFormatText.Text = "Text";
            this.rbFormatText.UseVisualStyleBackColor = true;
            // 
            // rbFormatJson
            // 
            this.rbFormatJson.AutoSize = true;
            this.rbFormatJson.Location = new System.Drawing.Point(3, 2);
            this.rbFormatJson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFormatJson.Name = "rbFormatJson";
            this.rbFormatJson.Size = new System.Drawing.Size(47, 17);
            this.rbFormatJson.TabIndex = 19;
            this.rbFormatJson.TabStop = true;
            this.rbFormatJson.Text = "Json";
            this.rbFormatJson.UseVisualStyleBackColor = true;
            // 
            // btLoadFromConnectionString
            // 
            this.btLoadFromConnectionString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadFromConnectionString.Location = new System.Drawing.Point(218, 4);
            this.btLoadFromConnectionString.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLoadFromConnectionString.Name = "btLoadFromConnectionString";
            this.btLoadFromConnectionString.Size = new System.Drawing.Size(155, 24);
            this.btLoadFromConnectionString.TabIndex = 16;
            this.btLoadFromConnectionString.Text = "Load from ConnectionString";
            this.btLoadFromConnectionString.UseVisualStyleBackColor = true;
            this.btLoadFromConnectionString.Visible = false;
            this.btLoadFromConnectionString.Click += new System.EventHandler(this.btLoadFromConnectionString_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 448);
            this.Controls.Add(this.btLoadFromConnectionString);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLinkGit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mmMessage);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAccessKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccessKeyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQueueNameOrTopicName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServicebusNamespace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Message To Servicebus from Http";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServicebusNamespace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQueueNameOrTopicName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccessKeyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccessKey;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.RichTextBox mmMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLinkGit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFormatXml;
        private System.Windows.Forms.RadioButton rbFormatText;
        private System.Windows.Forms.RadioButton rbFormatJson;
        private System.Windows.Forms.Button btLoadFromConnectionString;
    }
}

