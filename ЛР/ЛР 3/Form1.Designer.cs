namespace LR3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_groups = new System.Windows.Forms.ListBox();
            this.ListB_group = new System.Windows.Forms.Label();
            this.button_AddToZakaz = new System.Windows.Forms.Button();
            this.NameZakaz = new System.Windows.Forms.Label();
            this.SelectionPanel_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBox_groups
            // 
            this.listBox_groups.FormattingEnabled = true;
            this.listBox_groups.ItemHeight = 16;
            this.listBox_groups.Location = new System.Drawing.Point(52, 71);
            this.listBox_groups.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_groups.Name = "listBox_groups";
            this.listBox_groups.Size = new System.Drawing.Size(159, 116);
            this.listBox_groups.TabIndex = 0;
            this.listBox_groups.SelectedIndexChanged += new System.EventHandler(this.listBox_groups_SelectedIndexChanged);
            // 
            // ListB_group
            // 
            this.ListB_group.AutoSize = true;
            this.ListB_group.Location = new System.Drawing.Point(49, 48);
            this.ListB_group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListB_group.Name = "ListB_group";
            this.ListB_group.Size = new System.Drawing.Size(95, 16);
            this.ListB_group.TabIndex = 1;
            this.ListB_group.Text = "Список групп";
            // 
            // button_AddToZakaz
            // 
            this.button_AddToZakaz.Location = new System.Drawing.Point(52, 264);
            this.button_AddToZakaz.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddToZakaz.Name = "button_AddToZakaz";
            this.button_AddToZakaz.Size = new System.Drawing.Size(100, 47);
            this.button_AddToZakaz.TabIndex = 3;
            this.button_AddToZakaz.Text = "Добавить в заказ";
            this.button_AddToZakaz.UseVisualStyleBackColor = true;
            this.button_AddToZakaz.Click += new System.EventHandler(this.button_AddToZakaz_Click);
            // 
            // NameZakaz
            // 
            this.NameZakaz.AutoSize = true;
            this.NameZakaz.Location = new System.Drawing.Point(677, 48);
            this.NameZakaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameZakaz.Name = "NameZakaz";
            this.NameZakaz.Size = new System.Drawing.Size(50, 16);
            this.NameZakaz.TabIndex = 5;
            this.NameZakaz.Text = "Заказ:";
            // 
            // SelectionPanel_flowLayoutPanel
            // 
            this.SelectionPanel_flowLayoutPanel.Location = new System.Drawing.Point(294, 71);
            this.SelectionPanel_flowLayoutPanel.Name = "SelectionPanel_flowLayoutPanel";
            this.SelectionPanel_flowLayoutPanel.Size = new System.Drawing.Size(230, 116);
            this.SelectionPanel_flowLayoutPanel.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(680, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(261, 276);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SelectionPanel_flowLayoutPanel);
            this.Controls.Add(this.NameZakaz);
            this.Controls.Add(this.button_AddToZakaz);
            this.Controls.Add(this.ListB_group);
            this.Controls.Add(this.listBox_groups);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_groups;
        private System.Windows.Forms.Label ListB_group;
        private System.Windows.Forms.Button button_AddToZakaz;
        private System.Windows.Forms.Label NameZakaz;
        private System.Windows.Forms.FlowLayoutPanel SelectionPanel_flowLayoutPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

