using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR3
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> medicationGroups;
        public Form1()
        {
            InitializeComponent();

            medicationGroups = new Dictionary<string, List<string>>
            {
                { "Обезболы", new List<string>{ "Морфин", "Немисил", "Какой-то обезбол" } },
                { "От горла", new List<string>{ "пропосол", "фурацилин", "гексорал" } },
                { "Остальное", new List<string>{ "уголь активированный", "препорат какой-то 1", "препорат ещё 2" } }
            };
            foreach (var group in medicationGroups.Keys)
            {                
            listBox_groups.Items.Add(group);
            }
        }

        private void listBox_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox_groups.SelectedIndex;
                       
         
           
        }

        private void button_AddToZakaz_Click(object sender, EventArgs e)
        {
            foreach(string s in checkedListBox_preporati.CheckedItems)
            {
                listBox_zakazano.Items.Add(s);
            }
            
        }
    }
}
