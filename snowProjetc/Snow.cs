using System;
using System.Drawing;

namespace snowProjetc {
    internal class Snow {
        private double x;
        private double y;

        private double vx;
        private double vy;

        private SnowWorld snowWorld;

        public Snow(double x, double y, SnowWorld snowWorld) {
            this.x = x;
            this.y = y;
            this.snowWorld = snowWorld;
        }

        public void Update() {
            y = y + 0.1;
        }

        public void Render() {
            Pen pen = new Pen(Brushes.White);
            GDIBuffer.Instance().GetGraphics().DrawEllipse(pen, (int)x, (int)y, 2, 2);
            pen.Dispose();
        }
    }
}