using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yutnori
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.AppendText("게임 시작하기 전의 유의할점 \n");
            textBox1.AppendText("1.모든 유저가 준비를 눌러야만 게임 start \n");
            textBox1.AppendText("2.player 1->player 2->player 3->player 4->player 1순서로 게임진행 \n");
            textBox1.AppendText("3.닉네임은 채팅할때 보임 \n");

            textBox1.AppendText("윷놀이 규칙\n");
            textBox1.AppendText("1.윷이나 모가 나오면 한 번 더 던진다.\n");
            textBox1.AppendText("2.앞서가는 말을 잡을 수 있으며, 상대편 말을 잡으면 한 번 더 던진다.\n");

            textBox1.AppendText("윷의 등급\n");
            textBox1.AppendText("1.도(돼지) : 1칸 이동\n");
            textBox1.AppendText("2.개(개)   : 2칸 이동\n");
            textBox1.AppendText("3.걸(염소) : 3칸 이동\n");
            textBox1.AppendText("4.윷(소)   : 4칸 이동\n");
            textBox1.AppendText("5.모(말)   : 5칸 이동\n");
            textBox1.AppendText("6.검은 빽도: 뒤로 1칸 이동\n");
            textBox1.AppendText("7.빨간 빽도: 뒤로 1칸 이동\n");
            textBox1.AppendText("※만약 한번에 빽도 두개가 나오면 낙으로 처리되어 효과를 얻을 수 없다.");
        }
    }
}
