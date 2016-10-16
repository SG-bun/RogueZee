namespace RogueZee
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDice = new System.Windows.Forms.Panel();
            this.db4 = new RogueZee.DiceBox();
            this.db5 = new RogueZee.DiceBox();
            this.db3 = new RogueZee.DiceBox();
            this.db2 = new RogueZee.DiceBox();
            this.db1 = new RogueZee.DiceBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvDiceCombos = new System.Windows.Forms.DataGridView();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblLvl = new System.Windows.Forms.Label();
            this.lblXP = new System.Windows.Forms.Label();
            this.lblAtk = new System.Windows.Forms.Label();
            this.lblDef = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pnlDice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiceCombos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDice
            // 
            this.pnlDice.Controls.Add(this.db4);
            this.pnlDice.Controls.Add(this.db5);
            this.pnlDice.Controls.Add(this.db3);
            this.pnlDice.Controls.Add(this.db2);
            this.pnlDice.Controls.Add(this.db1);
            this.pnlDice.Location = new System.Drawing.Point(264, 312);
            this.pnlDice.Name = "pnlDice";
            this.pnlDice.Size = new System.Drawing.Size(328, 112);
            this.pnlDice.TabIndex = 1;
            // 
            // db4
            // 
            this.db4.Color = System.Drawing.Color.White;
            this.db4.Location = new System.Drawing.Point(200, 8);
            this.db4.Name = "db4";
            this.db4.Size = new System.Drawing.Size(56, 56);
            this.db4.TabIndex = 4;
            this.db4.Value = 1;
            // 
            // db5
            // 
            this.db5.Color = System.Drawing.Color.White;
            this.db5.Location = new System.Drawing.Point(264, 8);
            this.db5.Name = "db5";
            this.db5.Size = new System.Drawing.Size(56, 56);
            this.db5.TabIndex = 3;
            this.db5.Value = 1;
            // 
            // db3
            // 
            this.db3.Color = System.Drawing.Color.White;
            this.db3.Location = new System.Drawing.Point(136, 8);
            this.db3.Name = "db3";
            this.db3.Size = new System.Drawing.Size(56, 56);
            this.db3.TabIndex = 2;
            this.db3.Value = 1;
            // 
            // db2
            // 
            this.db2.Color = System.Drawing.Color.White;
            this.db2.Location = new System.Drawing.Point(72, 8);
            this.db2.Name = "db2";
            this.db2.Size = new System.Drawing.Size(56, 56);
            this.db2.TabIndex = 1;
            this.db2.Value = 1;
            // 
            // db1
            // 
            this.db1.Color = System.Drawing.Color.White;
            this.db1.Location = new System.Drawing.Point(8, 8);
            this.db1.Name = "db1";
            this.db1.Size = new System.Drawing.Size(56, 56);
            this.db1.TabIndex = 0;
            this.db1.Value = 1;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(8, 424);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvDiceCombos
            // 
            this.dgvDiceCombos.AllowUserToAddRows = false;
            this.dgvDiceCombos.AllowUserToDeleteRows = false;
            this.dgvDiceCombos.AllowUserToResizeColumns = false;
            this.dgvDiceCombos.AllowUserToResizeRows = false;
            this.dgvDiceCombos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiceCombos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiceCombos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiceCombos.Location = new System.Drawing.Point(8, 8);
            this.dgvDiceCombos.MultiSelect = false;
            this.dgvDiceCombos.Name = "dgvDiceCombos";
            this.dgvDiceCombos.ReadOnly = true;
            this.dgvDiceCombos.RowHeadersVisible = false;
            this.dgvDiceCombos.RowTemplate.Height = 23;
            this.dgvDiceCombos.Size = new System.Drawing.Size(226, 274);
            this.dgvDiceCombos.TabIndex = 4;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(128, 360);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 5;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(384, 280);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(88, 24);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblHP
            // 
            this.lblHP.BackColor = System.Drawing.Color.Transparent;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.ForeColor = System.Drawing.Color.Black;
            this.lblHP.Location = new System.Drawing.Point(56, 304);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(52, 24);
            this.lblHP.TabIndex = 6;
            this.lblHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHP.UseCompatibleTextRendering = true;
            // 
            // lblGold
            // 
            this.lblGold.BackColor = System.Drawing.Color.Transparent;
            this.lblGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGold.ForeColor = System.Drawing.Color.Black;
            this.lblGold.Location = new System.Drawing.Point(56, 376);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(52, 24);
            this.lblGold.TabIndex = 7;
            this.lblGold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGold.UseCompatibleTextRendering = true;
            // 
            // lblLvl
            // 
            this.lblLvl.BackColor = System.Drawing.Color.Transparent;
            this.lblLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvl.ForeColor = System.Drawing.Color.Black;
            this.lblLvl.Location = new System.Drawing.Point(56, 328);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(52, 24);
            this.lblLvl.TabIndex = 8;
            this.lblLvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLvl.UseCompatibleTextRendering = true;
            // 
            // lblXP
            // 
            this.lblXP.BackColor = System.Drawing.Color.Transparent;
            this.lblXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXP.ForeColor = System.Drawing.Color.Black;
            this.lblXP.Location = new System.Drawing.Point(56, 352);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(52, 24);
            this.lblXP.TabIndex = 9;
            this.lblXP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblXP.UseCompatibleTextRendering = true;
            // 
            // lblAtk
            // 
            this.lblAtk.BackColor = System.Drawing.Color.Transparent;
            this.lblAtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtk.ForeColor = System.Drawing.Color.Black;
            this.lblAtk.Location = new System.Drawing.Point(160, 304);
            this.lblAtk.Name = "lblAtk";
            this.lblAtk.Size = new System.Drawing.Size(52, 24);
            this.lblAtk.TabIndex = 10;
            this.lblAtk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAtk.UseCompatibleTextRendering = true;
            // 
            // lblDef
            // 
            this.lblDef.BackColor = System.Drawing.Color.Transparent;
            this.lblDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDef.ForeColor = System.Drawing.Color.Black;
            this.lblDef.Location = new System.Drawing.Point(160, 328);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(52, 24);
            this.lblDef.TabIndex = 11;
            this.lblDef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDef.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "HP: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lvl: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "XP: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gold: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(104, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Atk: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(104, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Def: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(128, 424);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 18;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnRoll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(645, 456);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDef);
            this.Controls.Add(this.lblAtk);
            this.Controls.Add(this.lblXP);
            this.Controls.Add(this.lblLvl);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.dgvDiceCombos);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pnlDice);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RogueZee";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlDice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiceCombos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDice;
        private DiceBox db1;
        private DiceBox db2;
        private DiceBox db3;
        private DiceBox db4;
        private DiceBox db5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvDiceCombos;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Label lblXP;
        private System.Windows.Forms.Label lblAtk;
        private System.Windows.Forms.Label lblDef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInventory;
    }
}

