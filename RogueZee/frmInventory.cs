using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace RogueZee
{
    public partial class frmInventory : Form
    {
        //
        // Class Variables
        //

        // Stores player inventory items
        private List<InventoryItem> playerInventory = new List<InventoryItem>();
        public frmInventory()
        {
            InitializeComponent();
        }
        public frmInventory(Player player)
        {
            InitializeComponent();

            foreach (InventoryItem ii in player.Inventory)
            {
                playerInventory.Add(new InventoryItem(World.ItemByID(ii.Details.ID), ii.Quantity));
            }
        }

        public void RefreshUI()
        {
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Item Name";
            dgvInventory.Columns[1].Name = "Quantity";
            dgvInventory.Rows.Clear();

            DataGridViewCell cell;

            // Adds rows and item descriptions
            foreach (InventoryItem ii in playerInventory)
            {

                // Adding combo information to grid view
                dgvInventory.Rows.Add(new[] {
                    ii.Details.Name,
                    ii.Quantity.ToString() });

                // Setting cell tooltip
                cell = dgvInventory.Rows[dgvInventory.Rows.Count - 1].Cells[0];
                cell.ToolTipText = ii.Details.Description;

            }
        }
    }
}
