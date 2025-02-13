using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox_groups.Items.Add("Обезболы");
            listBox_groups.Items.Add("От горла");
            listBox_groups.Items.Add("Остальное");


        }

        private void listBox_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox_groups.SelectedIndex;
            

           if ( selectedIndex == 0) 
           {
                checkedListBox_preporati.Items.Clear();
                checkedListBox_preporati.Items.Add("Морфин");
                checkedListBox_preporati.Items.Add("Немисил");
                checkedListBox_preporati.Items.Add("Какой-то обезбол");
           }
           if (selectedIndex == 1)
           {
                checkedListBox_preporati.Items.Clear();
                checkedListBox_preporati.Items.Add("пропосол");
                checkedListBox_preporati.Items.Add("фурацилин");
                checkedListBox_preporati.Items.Add("гексорал");
           }
           if (selectedIndex == 2)
           {
                checkedListBox_preporati.Items.Clear();
                checkedListBox_preporati.Items.Add("уголь активированный");
                checkedListBox_preporati.Items.Add("препорат какой-то 1");
                checkedListBox_preporati.Items.Add("препорат ещё 2");
           }
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
