using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drinksButton_Click(object sender, EventArgs e)
        {
            Drinks drinksPage = new Drinks();
            Navigation(drinksPage);
        }

        private void cakesButton_Click(object sender, EventArgs e)
        {
            Cakes cakesPage = new Cakes();
            Navigation(cakesPage);
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            Orders ordersPage = new Orders();
            Navigation(ordersPage);
        }

        public void Navigation(Form form)
        {
            form.TopLevel = false;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(form);
            form.Show();
        }
    }
}
