using System;
using System.Collections.Generic;

namespace snowProjetc {
    internal class SnowWorld {
        public int Width {
            get; set;
        }
        public int Height {
            get; set;
        }
        private List<Snow> mSnowList = new List<Snow>();
        Random objRandom = new Random();

        public SnowWorld(int width, int height) {
            this.Width = width;
            this.Height = height;

            for (int i = 0; i < 100; i++) {
                Snow snow = new Snow(objRandom.Next(width), objRandom.Next(height), this);
                mSnowList.Add(snow);
            }
        }

        public void Update() {
            foreach (Snow snow in mSnowList) {
                snow.Update();
            }
        }

        public void Render() {
            foreach (Snow snow in mSnowList) {
                snow.Render();
            }
        }
    }
}