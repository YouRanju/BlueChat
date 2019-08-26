namespace BlueChat
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.chattitle = new System.Windows.Forms.Label();
            this.onandoffbtn = new System.Windows.Forms.Button();
            this.chstlist = new System.Windows.Forms.ListBox();
            this.inputtxt = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.settingbtn = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // chattitle
            // 
            this.chattitle.AutoSize = true;
            this.chattitle.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chattitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chattitle.Location = new System.Drawing.Point(21, 32);
            this.chattitle.Name = "chattitle";
            this.chattitle.Size = new System.Drawing.Size(65, 32);
            this.chattitle.TabIndex = 0;
            this.chattitle.Text = "Title";
            // 
            // onandoffbtn
            // 
            this.onandoffbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.onandoffbtn.FlatAppearance.BorderSize = 0;
            this.onandoffbtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.onandoffbtn.Location = new System.Drawing.Point(234, 43);
            this.onandoffbtn.Name = "onandoffbtn";
            this.onandoffbtn.Size = new System.Drawing.Size(58, 28);
            this.onandoffbtn.TabIndex = 1;
            this.onandoffbtn.Text = "ON";
            this.onandoffbtn.UseVisualStyleBackColor = false;
            // 
            // chstlist
            // 
            this.chstlist.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chstlist.FormattingEnabled = true;
            this.chstlist.ItemHeight = 15;
            this.chstlist.Location = new System.Drawing.Point(12, 77);
            this.chstlist.Name = "chstlist";
            this.chstlist.Size = new System.Drawing.Size(280, 319);
            this.chstlist.TabIndex = 3;
            // 
            // inputtxt
            // 
            this.inputtxt.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputtxt.Location = new System.Drawing.Point(12, 406);
            this.inputtxt.Name = "inputtxt";
            this.inputtxt.Size = new System.Drawing.Size(215, 23);
            this.inputtxt.TabIndex = 4;
            // 
            // sendbtn
            // 
            this.sendbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.sendbtn.FlatAppearance.BorderSize = 0;
            this.sendbtn.ImageIndex = 0;
            this.sendbtn.ImageList = this.imageList1;
            this.sendbtn.Location = new System.Drawing.Point(234, 403);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(58, 27);
            this.sendbtn.TabIndex = 5;
            this.sendbtn.UseVisualStyleBackColor = false;
            // 
            // settingbtn
            // 
            this.settingbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingbtn.BackgroundImage")));
            this.settingbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingbtn.Location = new System.Drawing.Point(268, 12);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Size = new System.Drawing.Size(24, 24);
            this.settingbtn.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "up.png");
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.settingbtn);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.inputtxt);
            this.Controls.Add(this.chstlist);
            this.Controls.Add(this.onandoffbtn);
            this.Controls.Add(this.chattitle);
            this.Name = "Server";
            this.Text = "BlueChat_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chattitle;
        private System.Windows.Forms.Button onandoffbtn;
        private System.Windows.Forms.ListBox chstlist;
        private System.Windows.Forms.TextBox inputtxt;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Panel settingbtn;
        private System.Windows.Forms.ImageList imageList1;
    }
}