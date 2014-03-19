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
        private Color _gridColor;

        private void Form1_Load(object sender, EventArgs e)
        {
            _gameWorld = new World((int) nudWorldWidth.Value, (int) nudWorldHeight.Value);
            _presentation =
                new GraphicalPresentation(
                    ShapeType.Rectangle,
                    Color.Red,
                    (int) nudPixelSize.Value);

            _gridColor = Color.FromArgb(128, Color.White);
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
            _presentation.DrawGrid(e.Graphics, _gridColor, _gameWorld);
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

        private void pBox_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void pBox_MouseMove(object sender, MouseEventArgs e)
        {
            var point = _presentation.ScreenToWorldPoint(e.X, e.Y);
            tsslMouseCoordinates.Text =
                String.Format("Mouse coordinates = {0}:{1}", point.X, point.Y);
        }
    }
}