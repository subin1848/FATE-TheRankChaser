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
            ShowStrategy();
        }

        private void ShowTraineeInfo()
        {
            txtTraineeInfo.Text =
                $"이름: {trainee.Name}\r\n" +
                $"나이: {trainee.Age}세\r\n" +
                $"특기: {trainee.StrongPosition}\r\n" +
                $"약점: {trainee.WeakPosition}\r\n" +
                $"매력 포인트: {trainee.CharmPoint}";
        }
        // CSV 불러오기
        private List<StrategyData> LoadStrategyData(string path)
        {
            string fullPath = Path.Combine(Application.StartupPath, path);
            var list = new List<StrategyData>();

            foreach (var line in File.ReadAllLines(fullPath).Skip(1))
            {
                var parts = line.Split('|').Select(p => p.Trim()).ToArray();

                if (parts.Length < 6) continue;

                list.Add(new StrategyData
                {
                    Name = parts[0],
                    Type = parts[1],
                    Feature = parts[2],
                    Weakness = parts[3],
                    Strength = parts[4],
                    DebutRate = parts[5]
                });
            }

            return list;
        }

        // 생존 전략 보여주기
        private void ShowStrategy()
        {
            var strategies = LoadStrategyData("survive.csv");

            // 사용자 강점이나 매력포인트 기준으로 필터링
            var filtered = strategies.Where(s =>
                trainee.StrongPosition.Split(' ', ',', '|')    // 강점 여러 단어 가능
                    .Any(keyword => !string.IsNullOrEmpty(keyword) &&
                                    (s.Feature.Contains(keyword) || s.Strength.Contains(keyword) || s.Weakness.Contains(keyword))) ||
                trainee.CharmPoint.Split(' ', ',', '|')        // 매력포인트도 동일 처리
                    .Any(keyword => !string.IsNullOrEmpty(keyword) &&
                                    (s.Feature.Contains(keyword) || s.Strength.Contains(keyword) || s.Weakness.Contains(keyword)))
            ).ToList();

            if (filtered.Count == 0)
                filtered = strategies; // 없으면 전체에서 랜덤 선택

            Random rand = new Random();
            var selected = filtered[rand.Next(filtered.Count)];

            tbSurvive.Text =
                $"특징: {selected.Feature}\r\n" +
                $"강점/성장 포인트: {selected.Strength}\r\n" +
                $"약점: {selected.Weakness}\r\n" +
                $"데뷔 확률: {selected.DebutRate}";

            FillProbabilityListBox(selected);
            ShowFinalRank(selected);
        }

        // 데뷔 확률 ListBox 채우기
        private void FillProbabilityListBox(StrategyData selected)
        {
            var boxes = new List<ListBox> { lbDedut, lbFullEdit, lbBadEdit };
            foreach (var box in boxes)
            {
                box.Items.Clear();
            }

            // DebutRate만 CSV에서 가져오기
            int debut = 0;
            int.TryParse(selected.DebutRate.Replace("%", ""), out debut);

            // 통편집과 악편은 랜덤으로 계산
            Random rand = new Random();
            int pass = rand.Next(0, 101 - debut);  // 데뷔 확률 합쳐서 최대 100
            int bad = 100 - debut - pass;

            // ListBox에 아이템 반복 추가 (예: ▓)
            for (int i = 0; i < debut; i++) lbDedut.Items.Add("데뷔 ▓");
            for (int i = 0; i < pass; i++) lbFullEdit.Items.Add("통편집 ▓");
            for (int i = 0; i < bad; i++) lbBadEdit.Items.Add("악편 ▓");

            lblDedutRate.Text = $"{debut}%";
            lblFullEditRate.Text = $"{pass}%";
            lblBadEditRate.Text = $"{bad}%";

        }
        // 최종 순위 계산 및 표시
        private void ShowFinalRank(StrategyData selected)
        {
            // DebutRate를 숫자로 변환
            int debutRate = 0;
            int.TryParse(selected.DebutRate.Replace("%", ""), out debutRate);

            Random rand = new Random();

            // 순위를 DebutRate 기반으로 계산 (높을수록 순위 높음)
            int baseRank = 100 - debutRate;

            // 약간의 랜덤 오차를 줌
            int minRank = Math.Max(1, baseRank - 10);
            int maxRank = Math.Min(100, baseRank + 10);

            int finalRank = rand.Next(minRank, maxRank + 1);
            lblFinalRank.Text = $"{finalRank}위";
        }

        // 결과 저장 버튼 클릭
        private void btnResult_Click(object sender, EventArgs e)
        {
            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // 날짜/시간 기반 파일 이름
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string filePath = Path.Combine(desktopPath, $"시뮬레이션결과_{timestamp}.png");

                bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("결과 화면이 바탕화면에 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 생존 전략 데이터 클래스
        public class StrategyData
        {
            public string Name { get; set; }
            public string Type { get; set; }       // 보컬, 댄스 등
            public string Feature { get; set; }    // 특징
            public string Weakness { get; set; }   // 약점
            public string Strength { get; set; }   // 강점/성장 포인트
            public string DebutRate { get; set; }  // 데뷔 확률
        }

        // 연습생 캐릭터 데이터 클래스
        public class TraineeCharacter
        {
            public string Type { get; set; }        // 보컬, 댄스 등
            public string Feature { get; set; }     // 특징
            public string Weakness { get; set; }    // 약점
            public string Strength { get; set; }    // 강점/성장 포인트
            public string DebutRate { get; set; }   // 데뷔 확률

            // 사용자의 강점/약점 포지션과 매칭 체크
            public bool MatchesUser(string strongPosition, string weakPosition)
            {
                return Type.Contains(strongPosition) || Type.Contains(weakPosition);
            }

            // 그룹박스나 TextBox에 보여주기 위한 문자열
            public string GetDisplayText()
            {
                return $"특징: {Feature}\r\n" +
                       $"강점/성장 포인트: {Strength}\r\n" +
                       $"약점: {Weakness}\r\n" +
                       $"데뷔 확률: {DebutRate}";
            }
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
