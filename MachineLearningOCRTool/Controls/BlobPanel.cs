using System;
using System.Drawing;
using System.Windows.Forms;

namespace MachineLearningOCRTool.Controls
{
    public partial class BlobPanel : UserControl
    {
        #region Members

        public event EventHandler SelectedChanged;
        public event EventHandler DeleteRequest;

        private bool m_resize;
        private string m_description;

        #endregion

        #region Properties
        
        public bool Selected { get; set; }
        public int RowIndex { get; set; }
        public string Title { get; set; }
        public string Description
        {
            get { return m_description; }
            set 
            {
                m_description = value;
                toolTip1.SetToolTip(this, m_description);
            }
        }

        #endregion

        public BlobPanel()
        {
            InitializeComponent();

            // Use double-buffering for flicker-free updating:
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void BlobPanel_Load(object sender, EventArgs e)
        {
            // Set some properties.
            BackColor = Color.Transparent;
            ForeColor = Color.Red;
            BorderStyle = BorderStyle.None;
            Selected = false;

            // Register to events.
            MouseLeave += BlobPanel_MouseLeave;
            MouseMove += BlobPanel_MouseMove;
            MouseDown += BlobPanel_MouseDown;
            MouseUp += BlobPanel_MouseUp;
            Paint += BlobPanel_Paint;
        }

        #region Methods

        /// <summary>
        /// Checks whether the given location is on the edge of the panel (i.e the resizing zone).
        /// </summary>
        private EdgeEnum IsOnEdge(Point location)
        {
            if (location.X <= 2)
            {
                return EdgeEnum.Left;
            }
            if (Math.Abs(location.X - Width) <= 2)
            {
                return EdgeEnum.Right;
            }
            if (location.Y <= 2)
            {
                return EdgeEnum.Top;
            }
            if (Math.Abs(location.Y - Height) <= 2)
            {
                return EdgeEnum.Bottom;
            }

            return EdgeEnum.None;
        }

        /// <summary>
        /// Resizes the panel.
        /// </summary>
        public void Resize(int width, int height)
        {
            int wDiff = width - Width;
            int hDiff = height - Height;

            Width += wDiff;
            Height += hDiff;
            Location = new Point(Location.X - wDiff / 2, Location.Y - hDiff/2);
        }

        /// <summary>
        /// Raises the SelectedChanged event.
        /// </summary>
        protected virtual void OnSelectedChanged(EventArgs args)
        {
            if (SelectedChanged != null)
                SelectedChanged(this, args);
        }

        /// <summary>
        /// Raises the DeleteRequest event.
        /// </summary>
        protected virtual void OnDeleteRequest(EventArgs args)
        {
            if (DeleteRequest != null)
                DeleteRequest(this, args);
        }

        #endregion

        #region EventHandlers

        private void BlobPanel_Paint(object sender, PaintEventArgs e)
        {
            // Get the border width.
            int size = 1;
            if (Selected)
                size = 2;

            // Draw the border only.
            e.Graphics.DrawRectangle(new Pen(ForeColor, size), Rectangle.Inflate(ClientRectangle, -1*size, -1*size));
        }

        private void BlobPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // We care only for right-click.
            if (e.Button != MouseButtons.Left)
                return;

            // Check on what edge we are clicked.
            EdgeEnum edge = IsOnEdge(e.Location);
            
            // If we are not on any edge it means we should select this blob.
            if (edge == EdgeEnum.None)
            {
                // Flip the selection flag on the Panel and raise event.
                Selected = !Selected;
                OnSelectedChanged(EventArgs.Empty);
                Invalidate();

                return;
            }

            // We are on some edge, activate the resizing.
            m_resize = true;
        }

        private void BlobPanel_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop resizing.
            m_resize = false;
        }

        private void BlobPanel_MouseMove(object sender, MouseEventArgs e)
        {
            // Get what edge we are on.
            EdgeEnum edge = IsOnEdge(e.Location);

            switch (edge)
            {
                case EdgeEnum.Left:
                    // Set the resize cursor
                    Cursor = Cursors.SizeWE;
                    
                    // If resizing update location and width.
                    if (m_resize)
                    {
                        // Since we are resizing the left border we need to move the entire panel, so first we move it.
                        Location = new Point(Location.X + e.X, Location.Y);
                        
                        // Since we moved the panel we need now to extend (or shrink) it accordingly.
                        Width += -1*e.X;
                        Invalidate();
                    }
                    break;
                case EdgeEnum.Right:
                    // Set the resize cursor
                    Cursor = Cursors.SizeWE;

                    // If resizing update location and width.
                    if (m_resize)
                    {
                        // We move the right panel, so all we do is update the width accordingly (no need to move the panel).
                        Width = e.X;
                        Invalidate();
                    }
                    break;
                case EdgeEnum.Top:
                    // Set the resize cursor
                    Cursor = Cursors.SizeNS;

                    // If resizing update location and width.
                    if (m_resize)
                    {
                        // Since we are resizing the top border we need to move the entire panel, so first we move it.
                        Location = new Point(Location.X, Location.Y + e.Y);

                        // Since we moved the panel we need now to extend (or shrink) it accordingly.
                        Height += -1*e.Y;
                        Invalidate();
                    }
                    break;
                case EdgeEnum.Bottom:
                    // Set the resize cursor
                    Cursor = Cursors.SizeNS;

                    // If resizing update location and width.
                    if (m_resize)
                    {
                        // We move the bottom panel, so all we do is update the height accordingly (no need to move the panel).
                        Height = e.Y;
                        Invalidate();
                    }
                    break;
                default:
                    // Set the select cursor
                    Cursor = Cursors.Hand;
                    break;
            }
        }

        private void BlobPanel_MouseLeave(object sender, EventArgs e)
        {
            // Reset the cursor when we leave the panel.
            Cursor = Cursors.Default;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hide the context menu and raise the delete event.
            contextMenuStrip1.Hide();
            OnDeleteRequest(EventArgs.Empty);
        }

        private void BlobPanel_MouseClick(object sender, MouseEventArgs e)
        {
            // Shoe context menu on right-click.
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(PointToScreen(e.Location));
        }

        #endregion
    }
}
