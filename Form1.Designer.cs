namespace RankChaser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내역불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.긑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankChaserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpoint = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStrength = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbWeakness = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.내역불러오기ToolStripMenuItem,
            this.긑ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 내역불러오기ToolStripMenuItem
            // 
            this.내역불러오기ToolStripMenuItem.Name = "내역불러오기ToolStripMenuItem";
            this.내역불러오기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.내역불러오기ToolStripMenuItem.Text = "내역 불러오기";
            this.내역불러오기ToolStripMenuItem.Click += new System.EventHandler(this.내역불러오기ToolStripMenuItem_Click_1);
            // 
            // 긑ToolStripMenuItem
            // 
            this.긑ToolStripMenuItem.Name = "긑ToolStripMenuItem";
            this.긑ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.긑ToolStripMenuItem.Text = "끝내기";
            this.긑ToolStripMenuItem.Click += new System.EventHandler(this.긑ToolStripMenuItem_Click);
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rankChaserToolStripMenuItem});
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // rankChaserToolStripMenuItem
            // 
            this.rankChaserToolStripMenuItem.Name = "rankChaserToolStripMenuItem";
            this.rankChaserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rankChaserToolStripMenuItem.Text = "RankChaser 정보";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "생년월일을 입력하세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "성별을 골라주세요";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "당신의 강한 포지션을 골라주세요";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "당신의 약한 포지션을 골라주세요";
            // 
            // tbpoint
            // 
            this.tbpoint.Location = new System.Drawing.Point(69, 407);
            this.tbpoint.Name = "tbpoint";
            this.tbpoint.Size = new System.Drawing.Size(182, 21);
            this.tbpoint.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "당신의 매력 포인트를 1가지 적어주세요";
            // 
            // cbStrength
            // 
            this.cbStrength.FormattingEnabled = true;
            this.cbStrength.Items.AddRange(new object[] {
            "보컬",
            "댄스",
            "랩",
            "올라운더",
            "비주얼",
            "예능"});
            this.cbStrength.Location = new System.Drawing.Point(69, 299);
            this.cbStrength.Name = "cbStrength";
            this.cbStrength.Size = new System.Drawing.Size(183, 20);
            this.cbStrength.TabIndex = 12;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "여자",
            "남자"});
            this.cbGender.Location = new System.Drawing.Point(71, 220);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(180, 20);
            this.cbGender.TabIndex = 13;
            // 
            // cbWeakness
            // 
            this.cbWeakness.FormattingEnabled = true;
            this.cbWeakness.Items.AddRange(new object[] {
            "보컬",
            "댄스",
            "랩",
            "올라운더",
            "비주얼",
            "예능"});
            this.cbWeakness.Location = new System.Drawing.Point(69, 355);
            this.cbWeakness.Name = "cbWeakness";
            this.cbWeakness.Size = new System.Drawing.Size(183, 20);
            this.cbWeakness.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "결과 보기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 40F);
            this.label6.Location = new System.Drawing.Point(92, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 54);
            this.label6.TabIndex = 16;
            this.label6.Text = "운명의 시작";
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(72, 165);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(179, 21);
            this.dtBirth.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "이름을 입력하세요";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(293, 165);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(126, 21);
            this.tbUser.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 536);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbWeakness);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbStrength);
            this.Controls.Add(this.tbpoint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Fate: 운명의 시작";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내역불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 긑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankChaserToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbpoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStrength;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbWeakness;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUser;
    }
}

