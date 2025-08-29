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
using System.Xml.Linq;

namespace RankChaser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserData trainee = new UserData
            {
                Name = tbUser.Text,   
                BirthDate = dtBirth.Value,
                Gender = cbGender.SelectedItem.ToString(),
                StrongPosition = cbStrength.SelectedItem.ToString(),
                WeakPosition = cbWeakness.SelectedItem.ToString(),
                CharmPoint = tbpoint.Text,
                SimulationDate = DateTime.Now
            };

            // UserData 객체를 그대로 전달
            SaveHistory(trainee);

        }

        // 내역 저장 메서드
        private void SaveHistory(UserData trainee)
        {
            try
            {
                string filename = "history.csv";
             
                // CSV로 한 줄 만들기 (각 속성을 |로 구분)
                string line = $"{trainee.Name}|{trainee.BirthDate:yyyy-MM-dd}|{trainee.Gender}|{trainee.StrongPosition}|{trainee.WeakPosition}|{trainee.CharmPoint}|{trainee.SimulationDate:yyyy-MM-dd HH:mm:ss}";

                File.AppendAllText(filename, line + Environment.NewLine);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없습니다. \n{ex.Message}", "권한 오류!");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다. \n{ex.Message}", "알 수 없는 오류!");
            }
        }

        // 사용자 데이터 클래스
        public class UserData
        {
            public string Name { get; set; }
            public DateTime BirthDate { get; set; }
            public string Gender { get; set; }
            public string StrongPosition { get; set; }
            public string WeakPosition { get; set; }
            public string CharmPoint { get; set; }
            public DateTime SimulationDate { get; set; }
            public int Age => DateTime.Now.Year - BirthDate.Year;
        }

        // 전략 데이터
        public class StrategyData
        {
            public string Score { get; set; }
            public string Character { get; set; }
            public string Strategies { get; set; }
            public string Icons { get; set; }
        }

    }
}
