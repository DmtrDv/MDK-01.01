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
            this.NameZakaz = new System.Windows.Forms.Label();
            this.listBox_zakazano = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_groups
            // 
            this.listBox_groups.FormattingEnabled = true;
            this.listBox_groups.ItemHeight = 16;
            this.listBox_groups.Location = new System.Drawing.Point(52, 71);
            this.listBox_groups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // checkedListBox_preporati
            // 
            this.checkedListBox_preporati.FormattingEnabled = true;
            this.checkedListBox_preporati.Location = new System.Drawing.Point(219, 71);
            this.checkedListBox_preporati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox_preporati.Name = "checkedListBox_preporati";
            this.checkedListBox_preporati.Size = new System.Drawing.Size(200, 89);
            this.checkedListBox_preporati.TabIndex = 2;
            // 
            // button_AddToZakaz
            // 
            this.button_AddToZakaz.Location = new System.Drawing.Point(52, 264);
            this.button_AddToZakaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // listBox_zakazano
            // 
            this.listBox_zakazano.FormattingEnabled = true;
            this.listBox_zakazano.ItemHeight = 16;
            this.listBox_zakazano.Location = new System.Drawing.Point(680, 71);
            this.listBox_zakazano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_zakazano.Name = "listBox_zakazano";
            this.listBox_zakazano.Size = new System.Drawing.Size(291, 100);
            this.listBox_zakazano.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(426, 71);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(426, 96);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 22);
            this.numericUpDown2.TabIndex = 8;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(426, 121);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(54, 22);
            this.numericUpDown3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox_zakazano);
            this.Controls.Add(this.NameZakaz);
            this.Controls.Add(this.button_AddToZakaz);
            this.Controls.Add(this.checkedListBox_preporati);
            this.Controls.Add(this.ListB_group);
            this.Controls.Add(this.listBox_groups);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_groups;
        private System.Windows.Forms.Label ListB_group;
        private System.Windows.Forms.CheckedListBox checkedListBox_preporati;
        private System.Windows.Forms.Button button_AddToZakaz;
        private System.Windows.Forms.Label NameZakaz;
        private System.Windows.Forms.ListBox listBox_zakazano;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}

