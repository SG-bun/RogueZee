namespace RogueZee
{
    partial class DiceBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceBox));
            this.pnlDice = new System.Windows.Forms.Panel();
            this.pnlSource = new System.Windows.Forms.Panel();
            this.diceValueTimer = new System.Windows.Forms.Timer(this.components);
            this.rollDurationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlDice
            // 
            this.pnlDice.Location = new System.Drawing.Point(0, 0);
            this.pnlDice.Name = "pnlDice";
            this.pnlDice.Size = new System.Drawing.Size(56, 56);
            this.pnlDice.TabIndex = 1;
            this.pnlDice.Click += new System.EventHandler(this.pnlDice_Click);
            this.pnlDice.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDice_Paint);
            // 
            // pnlSource
            // 
            this.pnlSource.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSource.BackgroundImage")));
            this.pnlSource.Location = new System.Drawing.Point(75, 75);
            this.pnlSource.Name = "pnlSource";
            this.pnlSource.Size = new System.Drawing.Size(56, 336);
            this.pnlSource.TabIndex = 2;
            this.pnlSource.Visible = false;
            // 
            // diceValueTimer
            // 
            this.diceValueTimer.Tick += new System.EventHandler(this.diceValueTimer_Tick);
            // 
            // rollDurationTimer
            // 
            this.rollDurationTimer.Interval = 800;
            this.rollDurationTimer.Tick += new System.EventHandler(this.rollDurationTimer_Tick);
            // 
            // DiceBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSource);
            this.Controls.Add(this.pnlDice);
            this.Name = "DiceBox";
            this.Size = new System.Drawing.Size(56, 56);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel pnlSource;
        internal System.Windows.Forms.Panel pnlDice;
        private System.Windows.Forms.Timer diceValueTimer;
        public System.Windows.Forms.Timer rollDurationTimer;
    }
}
