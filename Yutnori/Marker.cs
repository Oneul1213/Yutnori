using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Yutnori {
    [Serializable] 
    public class Marker {
        public int playerNum { get; set; }      // 플레이어 고유번호(1P, 2P, 3P, 4P)
        public int index { get; set; }          // 말의 고유번호(말은 플레이어 당 4개까지니까 1, 2, 3, 4)
        public int position { get; set; }       // 몇 번째 칸에 있는가?
        public bool isFinished { get; set; }    // 말이 골인하였는가?
        public bool isSelected { get; set; }    // 말이 선택되었는가?
        public PictureBox pb { get; set; }      // 말의 PictureBox

        public Marker(int playerNum, int index, PictureBox pb)
        {
            this.playerNum = playerNum;
            this.index = index;
            this.position = 0;
            this.isFinished = false;
            this.pb = pb;
        }

        // 말의 position을 받아서 좌표를 반환하는 함수
        public Point getPoint(int step_index)
        {
            switch (step_index) {
                case 1:
                    return new Point(341, 238);
                case 2:
                    return new Point(341, 186);
                case 3:
                    return new Point(341, 134);
                case 4:
                    return new Point(341, 81);
                case 5:
                case 105:
                    return new Point(341, 29);
                case 6:
                    return new Point(285, 29);
                case 7:
                    return new Point(231, 29);
                case 8:
                    return new Point(175, 29);
                case 9:
                    return new Point(121, 29);
                case 10:
                case 210:
                    return new Point(66, 29);
                case 11:
                    return new Point(66, 81);
                case 12:
                    return new Point(66, 134);
                case 13:
                    return new Point(66, 186);
                case 14:
                    return new Point(66, 238);
                case 15:
                case 111:
                    return new Point(66, 290);
                case 16:
                case 112:
                    return new Point(121, 290);
                case 17:
                case 113:
                    return new Point(175, 290);
                case 18:
                case 114:
                    return new Point(231, 290);
                case 19:
                case 115:
                    return new Point(285, 290);
                case 20:
                case 116:
                case 216:
                    return new Point(341, 290);

                case 211:
                    return new Point(115, 75);
                case 212:
                    return new Point(154, 114);
                case 213:
                case 108:
                    return new Point(204, 160);
                case 214:
                    return new Point(252, 206);
                case 215:
                    return new Point(292, 244);

                case 106:
                    return new Point(292, 75);
                case 107:
                    return new Point(252, 114);
                case 109:
                    return new Point(154, 206);
                case 110:
                    return new Point(115, 244);
                default:
                    break;
            }

            return new Point(0, 0);
        }

        // 말을 움직이는 멤버 함수
        public void moveMarker(Yut yut)
        {
            int amount = (int)yut;

            // 방향을 바꾸는 부분
            switch(position) {
                case 5:
                    position += (100 + amount);
                    break;
                case 10:
                    position += (200 + amount);
                    break;
                case 108:
                    position += (105 + amount);
                    break;
                default:
                    position += amount;
                    break;
            }

            // 기본적으로는, 칸수만큼 움직인다.
            //position += amount;

            // 움직였는데, 골인인 경우
            if((position >= 21 && position <= 25) ||
               (position >= 117 && position <= 121) ||
               (position >= 217)) {
                isFinished = true;
            }
        }
    }
}
