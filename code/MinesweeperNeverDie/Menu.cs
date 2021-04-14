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

namespace MinesweeperNeverDie
{
    public partial class Menu : Form
    {
        Timer timer1;
        int time = 0;
        public delegate void TriggerGameOver(int nhanPham);
        public delegate int GetNhanPham();
        public delegate void SetNhanPham(int nhanPham);
        private int nhanPham;
        bool playing = false;
        string playMode = "";
        static string filePath;

        public Menu()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            TriggerGameOver triggerGameOver = new TriggerGameOver(TriggerGameOverNe);
            GetNhanPham getNhanPham = new GetNhanPham(GetNhanPhamNe);
            SetNhanPham setNhanPham = new SetNhanPham(SetNhanPhamNe);
            label_NhanPham.Text = nhanPham.ToString();
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filePath = filePath + @"\MineSweeperNhanPhamSave.txt";

            if (File.Exists(filePath))
            {
                string readText = File.ReadAllText(filePath);
                nhanPham = Int32.Parse(readText);
                label_NhanPham.Text = nhanPham.ToString();
            }
            else
            {
                nhanPham = 102;
                SaveNhanPham(nhanPham);
                label_NhanPham.Text = nhanPham.ToString();
            }
        }
        public void SaveNhanPham(int _nhanPham)
        {
            string[] __np = {_nhanPham.ToString()};
            File.WriteAllLines(filePath, __np);
        }
        public void TriggerGameOverNe(int _nhanPham)
        {
            if (playMode == "custom") _nhanPham = 0;
            if (playMode == "intermediate") _nhanPham *= 2;
            if (playMode == "expert") _nhanPham *= 3;
            nhanPham += _nhanPham;
            SaveNhanPham(nhanPham);//save to file
            timer1.Enabled = false;
            if (_nhanPham == 0) label_Status.Text = ($"GameOver");
            else label_Status.Text = ($"You win (+{_nhanPham})");
            playing = false;
            label_NhanPham.Text = nhanPham.ToString();
        }
        public int GetNhanPhamNe()
        {
            return nhanPham;
        }
        public void SetNhanPhamNe(int _nhanPham)//nhanPham - 100
        {
            if (playMode == "custom") return;
            label_Status.Text = ($"You lost (-{nhanPham - _nhanPham})");
            nhanPham = _nhanPham;
            SaveNhanPham(nhanPham);
            label_NhanPham.Text = nhanPham.ToString();
        }
        private void btn_PlayEasy_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                playMode = "easy";
                label_Status.Text = "Start game";
                playing = true;
                time = 0;
                timer1.Enabled = true;
                Game game = new Game();
                game.Start(9, 9, 10, TriggerGameOverNe, GetNhanPhamNe, SetNhanPhamNe, 530, 450);
            }
            else
            {
                MessageBox.Show("Bạn đang chơi");
            }
        }
        private void btn_PlayIntermediate_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                playMode = "intermediate";
                time = 0;
                timer1.Enabled = true;
                Game game = new Game();
                game.Start(16, 16, 40, TriggerGameOverNe, GetNhanPhamNe, SetNhanPhamNe, 810, 740);
            }
            else
            {
                MessageBox.Show("Bạn đang chơi");
            }
        }

        private void btn_PlayExpert_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                playMode = "expert";
                time = 0;
                timer1.Enabled = true;
                Game game = new Game();
                game.Start(30, 16, 99, TriggerGameOverNe, GetNhanPhamNe, SetNhanPhamNe, 1380, 720);
            }
            else
            {
                MessageBox.Show("Bạn đang chơi");
            }
        }

        private void btn_PlayCustom_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                playMode = "custom";
                try
                {
                    time = 0;
                    timer1.Enabled = true;
                    Game game = new Game();
                    if (int.Parse(text_Row.Text) < 5 || int.Parse(text_Col.Text) < 5 || int.Parse(text_Mine.Text) < 1)
                        throw new ArithmeticException();
                    game.Start(int.Parse(text_Row.Text), int.Parse(text_Col.Text), int.Parse(text_Mine.Text), TriggerGameOverNe, GetNhanPhamNe, SetNhanPhamNe, 1280, 1024);
                }
                catch
                {
                    MessageBox.Show("Row và Col phải >= 5.\nMine >= 1");
                }
            }
            else
            {
                MessageBox.Show("Bạn đang chơi");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = time.ToString() + 's';
        }

        private void btn_ShowNhanPham_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng điểm nhân phẩm:\n " +
                "- Mỗi lượt chơi thắng bạn sẽ nhận được một số điểm ngẫu nhiên từ 1 -> 50 và quy thành NhanPham\n" +
                "- Ở mỗi độ khó bạn sẽ được x1, x2 hoặc x3 số điểm có được (Beginner x1, Intermediate x2, Expert x3, Custom x0)\n" +
                "- Khi nhân phẩm của bạn cao hơn 100, mỗi lần đạp trúng mình sẽ không thua mà bị trừ -100 = NhanPham");
        }
    }
}
