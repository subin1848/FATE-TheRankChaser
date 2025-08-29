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

namespace RankChaser
{
    public partial class FormHistory : Form
    {
        List<string> history;
        Form1 form1;

        public FormHistory(Form1 form)
        {
            this.form1 = form;
            InitializeComponent();
            UpdateHistory();
        }

        // 내역 불러오기 메서드
        private void LoadHistory()
        {
            try
            {
                string filename = "history.csv";
                history = File.ReadAllLines(filename).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일이 존재하지 않습니다. \n{ex.Message}", "파일이 없는 오류!");
            }

            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없습니다. \n{ex.Message}", "파일 권한 오류!");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다. \n{ex.Message}", "알 수 없는 오류!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 새로고침 버튼 클릭 이벤트 핸들러
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateHistory();
        }

        // 내역 삭제 버튼 클릭 이벤트 핸들러
        private void UpdateHistory()
        {
            LoadHistory();
            lbHistory.Items.Clear();
            lbHistory.Items.AddRange(history.ToArray());
        }

        // 내역 삭제 버튼 클릭 이벤트 핸들러
        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = history[lbHistory.SelectedIndex];
            form1.LoadHistory(message);
        }
    }
}
