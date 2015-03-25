using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife {
    class Cell {
        public Cell(int x, int y) {
            this.x = x;
            this.y = y;
        }

        int id;
        int x;
        int y;
        int height;
        int width;
        bool dead;
        bool dying;
        bool spawning;

        # region getters and setters
        public void setID(int id) {
            this.id = id;
        }
        public int getID() {
            return this.id;
        }
        public void setX(int x) {
            this.x = x;
        }
        public int getX() {
            return this.x;
        }
        public void setY(int y) {
            this.y = y;
        }
        public int getY() {
            return this.y;
        }
        public void setHeight(int height) {
            this.height = height;
        }
        public int getHeight() {
            return this.height;
        }
        public void setWidth(int width) {
            this.width = width;
        }
        public int getWidth() {
            return this.width;
        }
        public void setDead(bool dead) {
            this.dead = dead;
        }
        public bool getDead() {
            return this.dead;
        }
        public void setDying(bool dying) {
            this.dying = dying;
        }
        public bool getDying() {
            return this.dying;
        }
        public void setSpawning(bool spawning) {
            this.spawning = spawning;
        }
        public bool getSpawning() {
            return this.spawning;
        }
        #endregion
    }
}
