using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Digital_Notes_Manager.Forms
{
    public class CategorySelector : UserControl
    {
        private ComboBox cmbCategories;

        public event EventHandler? CategoryChanged;

        public CategorySelector()
        {
            //  InitializeComponent();
            cmbCategories = new ComboBox();
            cmbCategories.Dock = DockStyle.Fill;

            cmbCategories.Items.AddRange(new string[] { "Work", "Study", "Other" });

            cmbCategories.SelectedIndex = -1;

            cmbCategories.SelectedIndexChanged += CmbCategories_SelectedIndexChanged;

            this.Controls.Add(cmbCategories);
        }


        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryChanged?.Invoke(this, EventArgs.Empty);
        }

        private void InitializeComponent()
        {

        }

        public string SelectedCategory
        {
            get
            {
                return cmbCategories.SelectedItem?.ToString() ?? string.Empty;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    cmbCategories.SelectedItem = value;
                }
            }
        }
        private void CategorySelector_CategoryChanged(object sender, EventArgs e)
        {
            MessageBox.Show("ay haga");

        }
    }

 
}
