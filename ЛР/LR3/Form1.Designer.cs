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
            this.checkedListBox_preporati = new System.Windows.Forms.CheckedListBox();
            this.button_AddToZakaz = new System.Windows.Forms.Button();
            this.Zakaz = new System.Windows.Forms.Label();
            this.NameZakaz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_groups
            // 
            this.listBox_groups.FormattingEnabled = true;
            this.listBox_groups.Location = new System.Drawing.Point(59, 58);
            this.listBox_groups.Name = "listBox_groups";
            this.listBox_groups.Size = new System.Drawing.Size(120, 95);
            this.listBox_groups.TabIndex = 0;
            this.listBox_groups.SelectedIndexChanged += new System.EventHandler(this.listBox_groups_SelectedIndexChanged);
            // 
            // ListB_group
            // 
            this.ListB_group.AutoSize = true;
            this.ListB_group.Location = new System.Drawing.Point(59, 39);
            this.ListB_group.Name = "ListB_group";
            this.ListB_group.Size = new System.Drawing.Size(75, 13);
            this.ListB_group.TabIndex = 1;
            this.ListB_group.Text = "Список групп";
            // 
            // checkedListBox_preporati
            // 
            this.checkedListBox_preporati.FormattingEnabled = true;
            this.checkedListBox_preporati.Location = new System.Drawing.Point(220, 58);
            this.checkedListBox_preporati.Name = "checkedListBox_preporati";
            this.checkedListBox_preporati.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_preporati.TabIndex = 2;
            // 
            // button_AddToZakaz
            // 
            this.button_AddToZakaz.Location = new System.Drawing.Point(374, 68);
            this.button_AddToZakaz.Name = "button_AddToZakaz";
            this.button_AddToZakaz.Size = new System.Drawing.Size(75, 38);
            this.button_AddToZakaz.TabIndex = 3;
            this.button_AddToZakaz.Text = "Добавить в заказ";
            this.button_AddToZakaz.UseVisualStyleBackColor = true;
            this.button_AddToZakaz.Click += new System.EventHandler(this.button_AddToZakaz_Click);
            // 
            // Zakaz
            // 
            this.Zakaz.AutoSize = true;
            this.Zakaz.Location = new System.Drawing.Point(520, 58);
            this.Zakaz.Name = "Zakaz";
            this.Zakaz.Size = new System.Drawing.Size(0, 13);
            this.Zakaz.TabIndex = 4;
            // 
            // NameZakaz
            // 
            this.NameZakaz.AutoSize = true;
            this.NameZakaz.Location = new System.Drawing.Point(508, 39);
            this.NameZakaz.Name = "NameZakaz";
            this.NameZakaz.Size = new System.Drawing.Size(99, 13);
            this.NameZakaz.TabIndex = 5;
            this.NameZakaz.Text = "Заказ состоит из:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameZakaz);
            this.Controls.Add(this.Zakaz);
            this.Controls.Add(this.button_AddToZakaz);
            this.Controls.Add(this.checkedListBox_preporati);
            this.Controls.Add(this.ListB_group);
            this.Controls.Add(this.listBox_groups);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_groups;
        private System.Windows.Forms.Label ListB_group;
        private System.Windows.Forms.CheckedListBox checkedListBox_preporati;
        private System.Windows.Forms.Button button_AddToZakaz;
        private System.Windows.Forms.Label Zakaz;
        private System.Windows.Forms.Label NameZakaz;
    }
}

