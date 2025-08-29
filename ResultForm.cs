using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RankChaser.Form1;

namespace RankChaser
{
    public partial class ResultForm : Form
    {
        private UserData trainee;
        public ResultForm(UserData data)
        {
            InitializeComponent();
            trainee = data;
            ShowTraineeInfo();
        }

        // 연습생 정보 보여주기
        private void ShowTraineeInfo()
        {
            txtTraineeInfo.Text =
                $"이름: {trainee.Name}\r\n" +
                $"나이: {trainee.Age}세\r\n" +
                $"특기: {trainee.StrongPosition}\r\n" +
                $"약점: {trainee.WeakPosition}\r\n" +
                $"매력 포인트: {trainee.CharmPoint}";
        }

        // 닫기 버튼 클릭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSurvive_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
