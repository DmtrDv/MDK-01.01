using ClassLib.Model;
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

namespace WorkWithTrees
{
    public partial class MainForm: Form
    {
        private List<TreeNodeModel> treeData_;
        private PlantsModel plantModel_;
        
        public MainForm()
        {
            InitializeComponent();

            treeData_ = new List<TreeNodeModel>();
            plantModel_ = new PlantsModel();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            {
                treeData_.Add(new TreeNodeModel("Растения"));
                var PlantsNode = treeData_[0];
                var grass = PlantsNode.AddChildNode("Трава");
                grass.AddChildNode("Подорожник");
                grass.AddChildNode("Клевер");
                grass.AddChildNode("Осока");

                var shrubs = PlantsNode.AddChildNode("Кустарники");
                shrubs.AddChildNode("Малина");
                shrubs.AddChildNode("Крыжовник");
                shrubs.AddChildNode("Сирень");

                var trees = PlantsNode.AddChildNode("Деревья");
                trees.AddChildNode("Малина");
                trees.AddChildNode("Крыжовник");
                trees.AddChildNode("Сирень");


                
               
            }
            FillTreeNodeCollection(treeData_, treeView1.Nodes);
            treeView1.ExpandAll();
        }
        static private void FillTreeNodeCollection(List<TreeNodeModel> sourceData, //данные источника - модели
                                                   TreeNodeCollection targetData) // данные приемника - представления
        {
            foreach (var node in sourceData)
            {
                var treeNode = new TreeNode(node.Name); // объект узла в представлении
                targetData.Add(treeNode); // добавили узел в дерево

                if (node.Children != null && node.Children.Count > 0)
                {
                    FillTreeNodeCollection(node.Children, treeNode.Nodes); //переносим дочерние элементы узла модели в дочерние элементы узла представления
                }
            }
        }
        

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                Plants Pl = plantModel_.getName(e.Node.Text);
                if (Pl != null)
                {
                    object[] newRow = { Pl.Name, Pl.Height, Pl.Area, Pl.TypeOfPlant };
                    Table_dataGridView.Rows.Add(newRow);
                }
            }
        }
       
    }
}
