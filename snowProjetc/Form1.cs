using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snowProjetc {
    public partial class Form1 : Form {        
        private Timer mTimer = null;
        SnowWorld mSnowWorld = null;


        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            mTimer = new Timer();
            mTimer.Enabled = true;
            mTimer.Interval = 30;
            mTimer.Tick += new EventHandler(tm_Tick);

            mSnowWorld = new SnowWorld(this.Width, this.Height);

            GDIBuffer.Instance(this.Width, this.Height);
        }

        private void tm_Tick(object sender, EventArgs e) {
            FrameUpdate();
            FrameRender();
        }

        private void FrameUpdate() {
            mSnowWorld.Update();
        }

        private void FrameRender() {
            mSnowWorld.Render();

            Graphics g = CreateGraphics();
            g.DrawImage(GDIBuffer.Instance().GetImage, new Point(0, 0));
            g.Dispose();
        }
    }
}
