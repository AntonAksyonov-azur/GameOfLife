using System;
using System.Drawing;
using System.Windows.Forms;
using ConwayGameofLife.com.andaforce.arazect.data;
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

        private GenericPoint<int> _currentPoint;
        private SolidBrush _highlightBrush;

        private bool _isDrawing;

        private const String EnableTimer = "EnableTimer";
        private const String DisableTimer = "DisableTimer";

        private void Form1_Load(object sender, EventArgs e)
        {
            _gameWorld = new World((int) nudWorldWidth.Value, (int) nudWorldHeight.Value);
            _presentation =
                new GraphicalPresentation(
                    ShapeType.Rectangle,
                    Color.Red,
                    Color.FromArgb(128, Color.White),
                    (int) nudPixelSize.Value);

            _highlightBrush = new SolidBrush(Color.FromArgb(128, Color.White));

            _currentPoint = new GenericPoint<int>();

            timerWorldGeneration.Interval = (int) nudTimerInterval.Value;
        }

        #region Buttons

        private void btnGenerateNew_Click(object sender, EventArgs e)
        {
            _gameWorld.RandomFilling(
                (int) nudRandomCount.Value,
                (int) nudWorldWidth.Value,
                (int) nudWorldHeight.Value);

            pBox.Refresh();
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            _gameWorld.ProceedToNextGeneration();
            lGeneration.Text = String.Format("Curent generation = {0}", _gameWorld.Generation);

            pBox.Refresh();
        }

        private void btnGenerateClean_Click(object sender, EventArgs e)
        {
            _gameWorld.Clear((int) nudWorldWidth.Value, (int) nudWorldHeight.Value);

            pBox.Refresh();
        }

        private void btnEnableDisableTimer_Click(object sender, EventArgs e)
        {
            timerWorldGeneration.Enabled = !timerWorldGeneration.Enabled;
            btnEnableDisableTimer.Text =
                timerWorldGeneration.Enabled
                    ? DisableTimer
                    : EnableTimer;
        }

        #region elementColor Selection

        private void btnSelectElementColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog() {FullOpen = true})
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _presentation.SetElementColor(colorDialog.Color);
                }
            }
            pBox.Refresh();
        }

        private void btnSelectGridColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog() {FullOpen = true})
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _presentation.SetGridColor(colorDialog.Color);
                }
            }
            pBox.Refresh();
        }

        private void btnSelectBackgroundColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog() {FullOpen = true})
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pBox.BackColor = colorDialog.Color;
                    _highlightBrush.Color =
                        Color.FromArgb(128,
                            255 - colorDialog.Color.R,
                            255 - colorDialog.Color.G,
                            255 - colorDialog.Color.B);
                }
            }
            pBox.Refresh();
        }

        #endregion

        #endregion

        #region Numeric Up/Down

        private void nudPixelSize_ValueChanged(object sender, EventArgs e)
        {
            _presentation.SetPixelSize((int) nudPixelSize.Value);

            pBox.Refresh();
        }

        private void nudTimerInterval_ValueChanged(object sender, EventArgs e)
        {
            timerWorldGeneration.Interval = (int) nudTimerInterval.Value;
        }

        #endregion

        #region Mouse on Picture box 

        private void pBox_MouseClick(object sender, MouseEventArgs e)
        {
            SetLiveState(e);
            pBox.Refresh();
        }

        private void SetLiveState(MouseEventArgs e)
        {
            _currentPoint = _presentation.ScreenToWorldPoint(e.X, e.Y);
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _gameWorld.SetCellAlive(_currentPoint.X, _currentPoint.Y);
                    break;
                case MouseButtons.Right:
                    _gameWorld.SetCellDead(_currentPoint.X, _currentPoint.Y);
                    break;
            }
        }

        private void pBox_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;
        }

        private void pBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;
        }

        private void pBox_MouseMove(object sender, MouseEventArgs e)
        {
            _currentPoint = _presentation.ScreenToWorldPoint(e.X, e.Y);
            tsslMouseCoordinates.Text =
                String.Format("Mouse coordinates = {0}:{1}", _currentPoint.X, _currentPoint.Y);

            if (_isDrawing)
            {
                SetLiveState(e);
            }

            pBox.Refresh();
        }

        #endregion

        private void pBox_Paint(object sender, PaintEventArgs e)
        {
            _presentation.DrawWorld(e.Graphics, _gameWorld);
            if (cbDrawGrid.Checked)
            {
                _presentation.DrawGrid(e.Graphics, _gameWorld);
            }

            e.Graphics.FillRectangle(
                _highlightBrush,
                _currentPoint.X * _presentation.PixelSize,
                _currentPoint.Y * _presentation.PixelSize,
                _presentation.PixelSize,
                _presentation.PixelSize);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btnNextGeneration.PerformClick();
        }
    }
}