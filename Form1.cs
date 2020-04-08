using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxes
{
    public partial class ListBox : Form
    {
        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();
        Random generator = new Random();
        public ListBox()
        {
            InitializeComponent();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));

            lstNumbers.DataSource = numbers;

            heroes.Add("Superman");
            heroes.Add("Batman");

            lstHeroes.DataSource = heroes;
        }

        private void btnSortNums_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;

            lblStatus.Text = "Status: numbers sorted";
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;

            lblStatus.Text = "Status: heroes sorted";
        }

        private void btnNewNums_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;

            lblStatus.Text = "Status: new numbers list";
        }

        private void btnNewHoreos_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("Superman");
            heroes.Add("Batman");
        }

        private void btnRemoveNum_Click(object sender, EventArgs e)
        {
            numbers.RemoveAt(lstNumbers.SelectedIndex);
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;

            lblStatus.Text = "Status: number removed";
        }

        private void btnRemoveAllNums_Click(object sender, EventArgs e)
        {
            while (numbers.Remove((Int32)lstNumbers.SelectedItem))
                numbers.Remove((Int32)lstNumbers.SelectedItem);

            lblStatus.Text = $"Status: all {(Int32)lstNumbers.SelectedItem}s are removed";
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            
        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {
            txtRemoveHero.Text.Trim();
            heroes.RemoveAt(heroes.FindIndex(n => n.Equals((string)txtRemoveHero.Text, StringComparison.OrdinalIgnoreCase)));

            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = $"Status: {txtRemoveHero.Text} was removed";
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            heroes.Add(txtAddHero.Text.Trim());
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = $"Status: {txtAddHero.Text} was added";
        }
    }
}
