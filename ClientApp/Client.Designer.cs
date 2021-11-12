namespace ClientApp
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
            this.textPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statustxt = new System.Windows.Forms.TextBox();
            this.connectbtn = new System.Windows.Forms.Button();
            this.status2txt = new System.Windows.Forms.TextBox();
            this.Senbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(384, 44);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 20);
            this.textPort.TabIndex = 8;
            this.textPort.Text = "8910";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port";
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(142, 47);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(100, 20);
            this.txthost.TabIndex = 6;
            this.txthost.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = " Host";
            // 
            // statustxt
            // 
            this.statustxt.Location = new System.Drawing.Point(12, 83);
            this.statustxt.Multiline = true;
            this.statustxt.Name = "statustxt";
            this.statustxt.Size = new System.Drawing.Size(776, 144);
            this.statustxt.TabIndex = 9;
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(659, 41);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(78, 23);
            this.connectbtn.TabIndex = 10;
            this.connectbtn.Text = "Connessione";
            this.connectbtn.UseVisualStyleBackColor = true;
            // 
            // status2txt
            // 
            this.status2txt.Location = new System.Drawing.Point(12, 278);
            this.status2txt.Multiline = true;
            this.status2txt.Name = "status2txt";
            this.status2txt.Size = new System.Drawing.Size(776, 123);
            this.status2txt.TabIndex = 11;
            // 
            // Senbtn
            // 
            this.Senbtn.Location = new System.Drawing.Point(659, 249);
            this.Senbtn.Name = "Senbtn";
            this.Senbtn.Size = new System.Drawing.Size(78, 23);
            this.Senbtn.TabIndex = 12;
            this.Senbtn.Text = "Send";
            this.Senbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Senbtn);
            this.Controls.Add(this.status2txt);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthost);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox statustxt;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.TextBox status2txt;
        private System.Windows.Forms.Button Senbtn;
    }
}

