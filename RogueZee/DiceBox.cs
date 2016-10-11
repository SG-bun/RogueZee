using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using Engine;

namespace RogueZee
{
    public partial class DiceBox : UserControl
    {
        public DiceBox()
        {
            InitializeComponent();

            // Initializes dice to White with 1 pip (value 1)
            Value = 1;
            Color = Color.White;

        }

        public DiceBox(int initValue, Color initColor)
        {
            Value = initValue;
            Color = initColor;
        }
        
        // Holds value (pip count) of dice
        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                // Error checking
                if (value > 6)
                {
                    _value = value % 6;
                }
                else if (value < 0)
                {
                    _value = 1;
                }
                else
                {
                    _value = value;
                }
                this.Refresh();
            }
        }
        // Holds background color of dice
        private Color _color;
        public Color Color
        {
            get { return _color; }
            set { _color = value; this.Refresh(); }
        }

        // Used for clicking and un-clicking dice
        private bool Held { get; set; }

        // For specifying new dice position
        public void Hold(bool holdDice)
        {
            if (holdDice == true && Held == false)
            {
                // Moves dice down if not held
                this.Location = new Point(this.Location.X, this.Location.Y + 20);
                // Sets dice to held
                Held = true;
            }
            else if (holdDice == false && Held == true)
            {
                // Moves dice down if held
                this.Location = new Point(this.Location.X, this.Location.Y - 20);
                // Sets dice to not held
                Held = false;
            }
        }

        // For toggling dice position
        public void Hold()
        {
            if (Held == false)
            {
                // Moves dice down if not held
                this.Location = new Point(this.Location.X, this.Location.Y + 20);
                // Sets dice to held
                Held = true;
            }
            else if (Held == true)
            {
                // Moves dice down if not held
                this.Location = new Point(this.Location.X, this.Location.Y - 20);
                // Sets dice to held
                Held = false;
            }
        }

        public void RollDice()
        {
            // Only rolls dice if NOT held
            if (Held == false)
            {
                // Starts dice rolling
                diceValueTimer.Enabled = true;

                // Stops dice rolling after rollDurationTimer.Interval
                rollDurationTimer.Enabled = true;
            }
        }

        // Based on method by Tom DeJong
        private void pnlDice_Paint(object sender, PaintEventArgs e)
        {
            // Desired placement for new dice image
            RectangleF DstDimensions = new RectangleF(0, 0, 56, 56);
            // Location of desired dice image on source image
            RectangleF SrcDimensions = new RectangleF(0, (Value - 1) * 56, 56, 56);

            // Getting source image (all dice values)
            Bitmap SrcBitmap = new Bitmap(pnlSource.BackgroundImage);
            Graphics DstGraphics = pnlDice.CreateGraphics();

            // Drawing
            DstGraphics.DrawImage(SrcBitmap, DstDimensions, SrcDimensions, GraphicsUnit.Pixel);
            DstGraphics.Dispose();
            SrcBitmap.Dispose();

            // Setting dice color
            pnlDice.BackColor = Color;
        }

        private void pnlDice_Click(object sender, EventArgs e)
        {
            Hold();
        }

        private void diceValueTimer_Tick(object sender, EventArgs e)
        {
            Value = RandomNumberGenerator.NumberBetween(1, 6);
        }

        private void rollDurationTimer_Tick(object sender, EventArgs e)
        {
            // Turns rolling effect on/off
            diceValueTimer.Enabled = !(diceValueTimer.Enabled);
            // Turns off duration timer so roll action only occurs once
            rollDurationTimer.Enabled = false;
        }
    }
}
