namespace BusinesLog
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBox_UserID = new System.Windows.Forms.RichTextBox();
            this.TextBox_UserPW = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TextBox_UserID
            // 
            this.TextBox_UserID.AccessibleDescription = "";
            this.TextBox_UserID.AccessibleName = "";
            this.TextBox_UserID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_UserID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox_UserID.Location = new System.Drawing.Point(40, 178);
            this.TextBox_UserID.Multiline = false;
            this.TextBox_UserID.Name = "TextBox_UserID";
            this.TextBox_UserID.Size = new System.Drawing.Size(297, 35);
            this.TextBox_UserID.TabIndex = 3;
            this.TextBox_UserID.Tag = "";
            this.TextBox_UserID.Text = "아이디";
            this.TextBox_UserID.WordWrap = false;
            this.TextBox_UserID.Click += new System.EventHandler(this.ID_TextBox_Click);
            this.TextBox_UserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_TextBox_KeyDown);
            this.TextBox_UserID.Leave += new System.EventHandler(this.ID_TextBox_FocusLeave);
            // 
            // TextBox_UserPW
            // 
            this.TextBox_UserPW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_UserPW.Location = new System.Drawing.Point(40, 221);
            this.TextBox_UserPW.Multiline = false;
            this.TextBox_UserPW.Name = "TextBox_UserPW";
            this.TextBox_UserPW.Size = new System.Drawing.Size(297, 35);
            this.TextBox_UserPW.TabIndex = 4;
            this.TextBox_UserPW.Text = "비밀번호";
            this.TextBox_UserPW.WordWrap = false;
            this.TextBox_UserPW.Click += new System.EventHandler(this.PW_TextBox_Click);
            this.TextBox_UserPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PW_TextBox_KeyDown);
            this.TextBox_UserPW.Leave += new System.EventHandler(this.PW_TextBox_FocusLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "로 그 인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox_UserPW);
            this.Controls.Add(this.TextBox_UserID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "UNITECH Buisines Log";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox TextBox_UserID;
        private System.Windows.Forms.RichTextBox TextBox_UserPW;
        private System.Windows.Forms.Button button1;
    }
}

