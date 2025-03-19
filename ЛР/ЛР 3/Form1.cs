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
        Dictionary<string, List<string>> medicationGroups; // Словарь для хранения групп медикаментов и их списка 

        Dictionary<string, Dictionary<string, int>> medicationsSelected; 
                                                           // Словарь для хранения выбранных медикоментов и их количества
        public Form1()
        {
            InitializeComponent();

            medicationGroups = new Dictionary<string, List<string>>
            {
                { "Обезболы", new List<string>{ "Морфин", "Немисил", "Какой-то обезбол" } },
                { "От горла", new List<string>{ "пропосол", "фурацилин", "гексорал" } },
                { "Остальное", new List<string>{ "уголь активированный", "уголь не активированный", "уголь неправильно активированный" } }
            };


            foreach (var group in medicationGroups.Keys)
            {
                listBox_groups.Items.Add(group);                
            }
            medicationsSelected = new Dictionary<string, Dictionary<string, int>>();
            foreach (var group in medicationGroups.Keys)
            {
                medicationsSelected[group] = new Dictionary<string, int>();
            }
        }

        private void listBox_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox_preporati.Items.Clear();
            string selectedItem = listBox_groups.SelectedItem.ToString();

            foreach (var med in medicationGroups[selectedItem])
            {
                checkedListBox_preporati.Items.Add(Text = med);                
            }
        }

        private void button_AddToZakaz_Click(object sender, EventArgs e)
        {
            string order = "";
            foreach(string group in checkedListBox_preporati.CheckedItems)
            {
                order += $"{group}:";
                if (medicationsSelected[group].Count > 0)
                {
                    foreach (var med in medicationsSelected[group])
                    {
                        order += $"- {med.Key} x {med.Value}\n";
                    }
                }
                else
                {
                    // Если блюда не выбраны, добавляем прочерк
                    order += "- \n";
                }

            }
            listBox_zakazano.Items.Add(order);
            
        }
    }
}
