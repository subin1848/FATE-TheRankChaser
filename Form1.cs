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
            // 입력 검증
            if (!ValidateInputs())
                return;

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

            // 결과 폼 생성
            var resultForm = new ResultForm(GetUserData());
            resultForm.ShowDialog();
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

        // 입력 검증 메서드
        private bool ValidateInputs()
        {
            if (cbGender.SelectedIndex == -1)
            {
                MessageBox.Show("성별을 선택해주세요! 👤", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbStrength.SelectedIndex == -1)
            {
                MessageBox.Show("강한 포지션을 선택해주세요! 💪", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbWeakness.SelectedIndex == -1)
            {
                MessageBox.Show("약한 포지션을 선택해주세요! 😅", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbStrength.SelectedIndex == cbWeakness.SelectedIndex)
            {
                MessageBox.Show("강한 포지션과 약한 포지션은 달라야 해요! 🤔", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbpoint.Text))
            {
                MessageBox.Show("매력 포인트를 입력해주세요! ✨", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public List<StrategyData> LoadStrategyCsv(string path)
        {
            var list = new List<StrategyData>();

            // 실행 파일 경로 기준으로 CSV 찾기
            string fullPath = Path.Combine(Application.StartupPath, path);

            foreach (var line in File.ReadAllLines(fullPath).Skip(1))
            {
                var parts = line.Split(',');

                if (parts.Length < 8) continue; // 안전하게 8개 컬럼 이상인지 확인

                list.Add(new StrategyData
                {
                    Score = parts[0],
                    Character = parts[1],
                    Strategies = $"{parts[2]}\r\n{parts[3]}\r\n{parts[4]}\r\n{parts[5]}\r\n{parts[6]}",
                    Icons = parts[7]
                });
            }

            return list;
        }

        // UserData 객체 생성 메서드
        private UserData GetUserData()
        {
            return new UserData
            {
                Name = tbUser.Text,
                BirthDate = dtBirth.Value,
                Gender = cbGender.SelectedItem.ToString(),
                StrongPosition = cbStrength.SelectedItem.ToString(),
                WeakPosition = cbWeakness.SelectedItem.ToString(),
                CharmPoint = tbpoint.Text,
                SimulationDate = DateTime.Now
            };
        }

        // 종료 메뉴 클릭 이벤트
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 종료하시겠습니까? 🥺", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
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

        // 종료 메뉴 클릭 이벤트
        private void 긑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 종료하시겠습니까? 🥺", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // 정보 메뉴 클릭 이벤트
        private void rankChaserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        // 내역 불러오기 메뉴 클릭 이벤트
        private void 내역불러오기ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                form = new FormHistory(this);
                form.Show();
            }
        }
        // 내역 불러오기 메서드
        internal void LoadHistory(string history)
        {
            if (string.IsNullOrWhiteSpace(history))
                return;

            var parts = history.Split('|');
            if (parts.Length < 3)
                return; // 형식이 잘못되었으면 그냥 리턴

            var datetimePart = parts[0].Split(' ');
            string birthday = datetimePart.Length > 0 ? datetimePart[0] : "";
            string birthtime = datetimePart.Length > 1 ? datetimePart[1] : "";
            string saju = parts[1];
            string message = parts[2];

        }

    }
}
