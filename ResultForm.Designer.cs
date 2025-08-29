namespace RankChaser
{
    partial class ResultForm
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
            this.headerP = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listP = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rank = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBadEdit = new System.Windows.Forms.ListBox();
            this.lbFullEdit = new System.Windows.Forms.ListBox();
            this.lbDedut = new System.Windows.Forms.ListBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTraineeInfo = new System.Windows.Forms.TextBox();
            this.tbSurvive = new System.Windows.Forms.TextBox();
            this.lblBadEditRate = new System.Windows.Forms.Label();
            this.lblFullEditRate = new System.Windows.Forms.Label();
            this.lblDedutRate = new System.Windows.Forms.Label();
            this.lblFinalRank = new System.Windows.Forms.Label();
            this.headerP.SuspendLayout();
            this.listP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerP
            // 
            this.headerP.Controls.Add(this.label1);
            this.headerP.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerP.Location = new System.Drawing.Point(0, 0);
            this.headerP.Name = "headerP";
            this.headerP.Size = new System.Drawing.Size(487, 71);
            this.headerP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("궁서", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "🎉시뮬레이션 결과🎉";
            // 
            // listP
            // 
            this.listP.Controls.Add(this.btnClose);
            this.listP.Controls.Add(this.btnResult);
            this.listP.Controls.Add(this.groupBox3);
            this.listP.Controls.Add(this.groupBox2);
            this.listP.Controls.Add(this.groupBox1);
            this.listP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listP.Location = new System.Drawing.Point(0, 71);
            this.listP.Name = "listP";
            this.listP.Size = new System.Drawing.Size(487, 465);
            this.listP.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTraineeInfo);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "👤연습생 정보";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFinalRank);
            this.groupBox2.Controls.Add(this.lblDedutRate);
            this.groupBox2.Controls.Add(this.lblFullEditRate);
            this.groupBox2.Controls.Add(this.lblBadEditRate);
            this.groupBox2.Controls.Add(this.lbDedut);
            this.groupBox2.Controls.Add(this.lbFullEdit);
            this.groupBox2.Controls.Add(this.lbBadEdit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rank);
            this.groupBox2.Location = new System.Drawing.Point(22, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "📈서바이벌 결과";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSurvive);
            this.groupBox3.Location = new System.Drawing.Point(22, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "🎯생존 결과";
            // 
            // rank
            // 
            this.rank.AutoSize = true;
            this.rank.Location = new System.Drawing.Point(10, 27);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(57, 12);
            this.rank.TabIndex = 0;
            this.rank.Text = "최종 순위";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "통편집 확률";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "악편 확률";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "데뷔 확률";
            // 
            // lbBadEdit
            // 
            this.lbBadEdit.FormattingEnabled = true;
            this.lbBadEdit.ItemHeight = 12;
            this.lbBadEdit.Location = new System.Drawing.Point(79, 54);
            this.lbBadEdit.Name = "lbBadEdit";
            this.lbBadEdit.Size = new System.Drawing.Size(267, 4);
            this.lbBadEdit.TabIndex = 4;
            // 
            // lbFullEdit
            // 
            this.lbFullEdit.FormattingEnabled = true;
            this.lbFullEdit.ItemHeight = 12;
            this.lbFullEdit.Location = new System.Drawing.Point(91, 73);
            this.lbFullEdit.Name = "lbFullEdit";
            this.lbFullEdit.Size = new System.Drawing.Size(255, 4);
            this.lbFullEdit.TabIndex = 5;
            // 
            // lbDedut
            // 
            this.lbDedut.FormattingEnabled = true;
            this.lbDedut.ItemHeight = 12;
            this.lbDedut.Location = new System.Drawing.Point(79, 97);
            this.lbDedut.Name = "lbDedut";
            this.lbDedut.Size = new System.Drawing.Size(267, 4);
            this.lbDedut.TabIndex = 6;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(22, 415);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(207, 31);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "결과 저장";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(257, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(207, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTraineeInfo
            // 
            this.txtTraineeInfo.Location = new System.Drawing.Point(14, 22);
            this.txtTraineeInfo.Multiline = true;
            this.txtTraineeInfo.Name = "txtTraineeInfo";
            this.txtTraineeInfo.ReadOnly = true;
            this.txtTraineeInfo.Size = new System.Drawing.Size(416, 75);
            this.txtTraineeInfo.TabIndex = 0;
            // 
            // tbSurvive
            // 
            this.tbSurvive.Location = new System.Drawing.Point(12, 20);
            this.tbSurvive.Multiline = true;
            this.tbSurvive.Name = "tbSurvive";
            this.tbSurvive.ReadOnly = true;
            this.tbSurvive.Size = new System.Drawing.Size(416, 75);
            this.tbSurvive.TabIndex = 1;
            this.tbSurvive.TextChanged += new System.EventHandler(this.tbSurvive_TextChanged);
            // 
            // lblBadEditRate
            // 
            this.lblBadEditRate.AutoSize = true;
            this.lblBadEditRate.Location = new System.Drawing.Point(375, 51);
            this.lblBadEditRate.Name = "lblBadEditRate";
            this.lblBadEditRate.Size = new System.Drawing.Size(38, 12);
            this.lblBadEditRate.TabIndex = 7;
            this.lblBadEditRate.Text = "label5";
            // 
            // lblFullEditRate
            // 
            this.lblFullEditRate.AutoSize = true;
            this.lblFullEditRate.Location = new System.Drawing.Point(375, 70);
            this.lblFullEditRate.Name = "lblFullEditRate";
            this.lblFullEditRate.Size = new System.Drawing.Size(38, 12);
            this.lblFullEditRate.TabIndex = 8;
            this.lblFullEditRate.Text = "label6";
            // 
            // lblDedutRate
            // 
            this.lblDedutRate.AutoSize = true;
            this.lblDedutRate.Location = new System.Drawing.Point(375, 94);
            this.lblDedutRate.Name = "lblDedutRate";
            this.lblDedutRate.Size = new System.Drawing.Size(38, 12);
            this.lblDedutRate.TabIndex = 9;
            this.lblDedutRate.Text = "label7";
            // 
            // lblFinalRank
            // 
            this.lblFinalRank.AutoSize = true;
            this.lblFinalRank.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFinalRank.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFinalRank.Location = new System.Drawing.Point(77, 25);
            this.lblFinalRank.Name = "lblFinalRank";
            this.lblFinalRank.Size = new System.Drawing.Size(45, 15);
            this.lblFinalRank.TabIndex = 10;
            this.lblFinalRank.Text = "label5";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 536);
            this.Controls.Add(this.listP);
            this.Controls.Add(this.headerP);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.headerP.ResumeLayout(false);
            this.headerP.PerformLayout();
            this.listP.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel listP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbBadEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rank;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.ListBox lbDedut;
        private System.Windows.Forms.ListBox lbFullEdit;
        private System.Windows.Forms.TextBox txtTraineeInfo;
        private System.Windows.Forms.TextBox tbSurvive;
        private System.Windows.Forms.Label lblFinalRank;
        private System.Windows.Forms.Label lblDedutRate;
        private System.Windows.Forms.Label lblFullEditRate;
        private System.Windows.Forms.Label lblBadEditRate;
    }
}