using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

using Engine;

namespace RogueZee
{
    public partial class frmMain : Form
    {
        //
        // Class variables
        //
        
        // Player variable
        private Player _player = new Player(10, 10, 5, 0);
        // Inventory window variable
        private Form frmInventory;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Keeps track of dice rolls
        private bool rollAgain = true;
        // Rolls all dice
        private async void btnRoll_Click(object sender, EventArgs e)
        {
            if (rollAgain == true)
            {
                foreach (DiceBox db in pnlDice.Controls)
                {
                    db.RollDice();
                }

                rollAgain = false;

                // Wait for rolling animation to finish
                await Task.Delay(800);
                RefreshUI();
            }
            else if (rollAgain == false)
            {
                btnRoll.Enabled = false;

                foreach (DiceBox db in pnlDice.Controls)
                {
                    db.RollDice();
                }

                // Wait for rolling animation to finish
                await Task.Delay(800);
                RefreshUI();
            }
        }

        // Clears & re-populates data grid
        private void RefreshUI()
        {
            dgvDiceCombos.RowHeadersVisible = false;
            dgvDiceCombos.ColumnCount = 2;
            dgvDiceCombos.Columns[0].Name = "Combo";
            dgvDiceCombos.Columns[1].Name = "Damage"; // Possibly also "Effect" e.g. 2x dmg, 3x dmg, etc.
            dgvDiceCombos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDiceCombos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDiceCombos.Rows.Clear();

            List<int> diceValues = new List<int>();

            // Accumulates dice values for use with DiceCombo
            foreach (DiceBox db in pnlDice.Controls)
            {
                diceValues.Add(db.Value);
            }

            DataGridViewCell cell;

            // Adds rows & calculates damage
            foreach (ComboType combo in Enum.GetValues(typeof(ComboType)))
            {
                // Adding combo information to grid view
                dgvDiceCombos.Rows.Add(new[] {
                    DiceCombo.Name(combo),
                    DiceCombo.Damage(combo, diceValues).ToString() });

                // Setting cell tooltip
                cell = dgvDiceCombos.Rows[dgvDiceCombos.Rows.Count - 1].Cells[0];
                cell.ToolTipText = DiceCombo.Description(combo);
            }

            lblHP.Text = _player.CurrentHP.ToString();
            lblLvl.Text = _player.Lvl.ToString();
            lblXP.Text = _player.XP.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblAtk.Text = _player.Attack.ToString();
            lblDef.Text = _player.Defense.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RefreshUI();
            frmInventory = new frmInventory();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            // Resetting variables
            rollAgain = true;
            btnRoll.Enabled = true;

            // Resetting held dice
            foreach (DiceBox db in pnlDice.Controls)
            {
                db.Hold(false);
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }
    }
}
