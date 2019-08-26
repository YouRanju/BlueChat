namespace BlueChat
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.exitbtn = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.serverbtn = new System.Windows.Forms.Button();
            this.joinbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "join.png");
            this.imageList1.Images.SetKeyName(1, "server.png");
            // 
            // exitbtn
            // 
            this.exitbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbtn.BackgroundImage")));
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitbtn.Location = new System.Drawing.Point(125, 350);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(62, 60);
            this.exitbtn.TabIndex = 8;
            this.exitbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exitbtn_MouseClick);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Location = new System.Drawing.Point(75, 53);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(168, 74);
            this.title.TabIndex = 7;
            this.title.Text = "BLUE";
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title2.Location = new System.Drawing.Point(119, 117);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(79, 32);
            this.title2.TabIndex = 6;
            this.title2.Text = "CHAT";
            // 
            // serverbtn
            // 
            this.serverbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.serverbtn.FlatAppearance.BorderSize = 0;
            this.serverbtn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.serverbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.serverbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serverbtn.ImageIndex = 1;
            this.serverbtn.ImageList = this.imageList1;
            this.serverbtn.Location = new System.Drawing.Point(63, 193);
            this.serverbtn.Name = "serverbtn";
            this.serverbtn.Size = new System.Drawing.Size(180, 41);
            this.serverbtn.TabIndex = 4;
            this.serverbtn.Text = "Create Server";
            this.serverbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serverbtn.UseVisualStyleBackColor = false;
            // 
            // joinbtn
            // 
            this.joinbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.joinbtn.FlatAppearance.BorderSize = 0;
            this.joinbtn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.joinbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.joinbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.joinbtn.ImageIndex = 0;
            this.joinbtn.ImageList = this.imageList1;
            this.joinbtn.Location = new System.Drawing.Point(63, 251);
            this.joinbtn.Name = "joinbtn";
            this.joinbtn.Size = new System.Drawing.Size(180, 41);
            this.joinbtn.TabIndex = 5;
            this.joinbtn.Text = "Joint Chat";
            this.joinbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.joinbtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.joinbtn);
            this.Controls.Add(this.serverbtn);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.exitbtn);
            this.Name = "Form1";
            this.Text = "BlueChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel exitbtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Button serverbtn;
        private System.Windows.Forms.Button joinbtn;
    }
}

