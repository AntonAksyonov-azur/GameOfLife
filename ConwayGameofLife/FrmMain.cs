using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConwayGameofLife.com.andaforce.arazect.life;
using ConwayGameofLife.com.andaforce.arazect.visual;
using ConwayGameofLife.com.andaforce.arazect.visual.winforms;

namespace ConwayGameofLife
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private World _gameWorld;
        private GraphicalPresentation _presentation;

        private void Form1_Load(object sender, EventArgs e)
        {
            _gameWorld = new World(640, 480);
            _presentation = new GraphicalPresentation(ShapeType.Rectangle, Color.Red, 1);
        }

        private void btnGenerateNew_Click(object sender, EventArgs e)
        {
            _gameWorld.RandomFilling(100);
            pBox.Refresh();
        }

        private void pBox_Paint(object sender, PaintEventArgs e)
        {
            _presentation.DrawWorld(e.Graphics, _gameWorld);
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            _gameWorld.PerformNextStep();
            pBox.Refresh();
        }
    }
}
