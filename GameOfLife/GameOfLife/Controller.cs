using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameOfLife {
    class Controller {
        public Controller() {
            
        }
        static Bitmap bm = new Bitmap(8 * 100, 8 * 100);
        Graphics g = Graphics.FromImage(bm);
        static Graphics CreateGraphics();

        // e.g. a chessbord has size 8 (8*8 = 64 cells, 8 rows, 8 columns)
        Graphics board = CreateGraphics();
        
        public void drawBoard(int boardSize) {
            int counter = 1;
            for (int x = 1; x < boardSize; x++) {
                for (int y = 1; y < boardSize; y++) {
                    if ((counter % 2) == 1) {
                        board.FillRectangle(new SolidBrush(Color.White), 100 + x * 20, 50 + y * 20, 20, 20);
                    }
                    else {
                        board.FillRectangle(new SolidBrush(Color.Black), 100 + x * 20, 50 + y * 20, 20, 20);
                    }
                    counter++;
                }
                counter++;
            }
        }

        public void drawCell() {

        }
    }
}
