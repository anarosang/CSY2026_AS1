namespace Assignment1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntSend = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.remoteport = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remote IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remote port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Local port";
            // 
            // bntSend
            // 
            this.bntSend.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.bntSend.Location = new System.Drawing.Point(486, 372);
            this.bntSend.Name = "bntSend";
            this.bntSend.Size = new System.Drawing.Size(114, 25);
            this.bntSend.TabIndex = 3;
            this.bntSend.Text = "Send";
            this.bntSend.UseVisualStyleBackColor = true;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(574, 46);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(184, 20);
            this.address.TabIndex = 4;
            // 
            // remoteport
            // 
            this.remoteport.Location = new System.Drawing.Point(574, 96);
            this.remoteport.Name = "remoteport";
            this.remoteport.Size = new System.Drawing.Size(184, 20);
            this.remoteport.TabIndex = 5;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(574, 148);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(184, 20);
            this.port.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 342);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 58);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(13, 13);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(445, 310);
            this.textBox2.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "TcpServer",
            "TcpClient",
            "UdpServer",
            "UdpClient"});
            this.listBox1.Location = new System.Drawing.Point(472, 204);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 80);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnStart.Location = new System.Drawing.Point(626, 229);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 25);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 409);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.port);
            this.Controls.Add(this.remoteport);
            this.Controls.Add(this.address);
            this.Controls.Add(this.bntSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "C# Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntSend;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox remoteport;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnStart;
    }
}

