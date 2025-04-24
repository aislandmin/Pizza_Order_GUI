using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PizzaGUI
{
    public partial class frmApp : Form
    {
        List<String> toppingsList = new List<String>();
        List<Pizza> pizzasList = new List<Pizza>();
        List<CheckBox> checkboxList = new List<CheckBox>();

        public frmApp()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            // Bind enum values directly to the ListBox using DataSource
            lstPizzaSize.DataSource = Enum.GetValues(typeof(PizzaSize));
            lstPizzaSize.SelectedIndex = -1;

            GetCheckBoxes();

            ClearCheckBoxes();
            btnConfirm.Enabled = false;
        }

        private void GetCheckBoxes()
        {
            foreach(Control control in tabPageOrder.Controls)
            {
                if (control is CheckBox)
                {
                    checkboxList.Add(control as CheckBox);
                }
            }
        }

        private void ClearCheckBoxes()
        {
            foreach (CheckBox checkbox in checkboxList)
            {
                checkbox.Checked = false;
            }
        }

        List<string> GetToppings()
        {
            List<string> toppings = new List<string>();
            foreach(CheckBox checkbox in checkboxList)
            {
                if(checkbox.Checked)
                {
                    toppings.Add(checkbox.Text);
                }
            }
            return toppings;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<string> toppings = GetToppings();
            PizzaSize pizzaSize = (PizzaSize)Enum.Parse(typeof(PizzaSize), lstPizzaSize.SelectedItem.ToString());
            Pizza p = toppings.Count == 0 ? new Pizza(pizzaSize) : new Pizza(pizzaSize, toppings);
            pizzasList.Add(p);
            lblLastOrderTime.Text = $"Last Order Time: {p.Time}";

            displayListOfPizza(pizzasList);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //dgvPizza.DataSource = null;
            //dgvPizza.DataSource = pizzasList;

            ClearCheckBoxes();
            lstPizzaSize.SelectedIndex = -1;
            displayListOfPizza(pizzasList);
        }

        private void lstPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = true;
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            //dgvPizza.DataSource = pizzasList.Where(p => p.Size == PizzaSize.Large).ToList();
            displayListOfPizza(pizzasList.Where(p => p.Size == PizzaSize.Large).ToList());
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            //dgvPizza.DataSource = pizzasList.Where(p => p.Size == PizzaSize.Medium).ToList();
            displayListOfPizza(pizzasList.Where(p => p.Size == PizzaSize.Medium).ToList());
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            //dgvPizza.DataSource = pizzasList.Where(p => p.Size == PizzaSize.Small).ToList();
            displayListOfPizza(pizzasList.Where(p => p.Size == PizzaSize.Small).ToList());
        }

        private void btnXLarge_Click(object sender, EventArgs e)
        {
            //dgvPizza.DataSource = null;
            //dgvPizza.DataSource = pizzasList.Where(p => p.Size == PizzaSize.X_large).ToList();
            displayListOfPizza(pizzasList.Where(p => p.Size == PizzaSize.X_large).ToList());
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            //dgvPizza.DataSource = pizzasList;
            displayListOfPizza(pizzasList);
        }
        private void displayListOfPizza(List<Pizza> pizzasList)
        {
            // Clear any existing rows
            dgvPizza.Rows.Clear();

            // Manually add columns (if not already added)
            if (dgvPizza.Columns.Count == 0)
            {
                dgvPizza.Columns.Add("Time", "Time");
                dgvPizza.Columns.Add("Price", "Price");
                dgvPizza.Columns.Add("Size", "Size");
                dgvPizza.Columns.Add("Toppings", "Toppings");
            }

            // Loop through pizzasList and add rows using CreateRow()
            foreach (var pizza in pizzasList)
            {
                // Add the row to the DataGridView
                dgvPizza.Rows.Add(pizza.CreateRow());
            }

            //Set the last column to fill the remaining space
            dgvPizza.Columns[dgvPizza.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    
    }
}
