using System;
using System.Drawing;
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
            _gameWorld = new World((int) nudWorldWidth.Value, (int) nudWorldHeight.Value);
            _presentation =
                new GraphicalPresentation(
                    ShapeType.Rectangle,
                    Color.Red,
                    (int) nudPixelSize.Value);
        }

        private void btnGenerateNew_Click(object sender, EventArgs e)
        {
            _gameWorld.RandomFilling(
                _gameWorld.WorldWidth * _gameWorld.WorldHeight / 2,
                (int) nudWorldWidth.Value,
                (int) nudWorldHeight.Value);
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

        private void btnGenerateClean_Click(object sender, EventArgs e)
        {
            _gameWorld.Clear((int) nudWorldWidth.Value, (int) nudWorldHeight.Value);
            pBox.Refresh();
        }

        private void nudPixelSize_ValueChanged(object sender, EventArgs e)
        {
            _presentation.SetPixelSize((int) nudPixelSize.Value);
        }
    }
}