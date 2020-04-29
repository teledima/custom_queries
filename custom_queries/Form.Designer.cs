namespace custom_queries
{
    partial class Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fiels_page = new System.Windows.Forms.TabPage();
            this.listBox_selected_fields = new System.Windows.Forms.ListBox();
            this.listBox_all_fields = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_field_select_cancel_all = new System.Windows.Forms.Button();
            this.button_field_select_all = new System.Windows.Forms.Button();
            this.button_field_select_cancel = new System.Windows.Forms.Button();
            this.button_field_select = new System.Windows.Forms.Button();
            this.page_conditions = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFieldName = new System.Windows.Forms.ComboBox();
            this.comboBoxCriterion = new System.Windows.Forms.ComboBox();
            this.comboBoxValues = new System.Windows.Forms.ComboBox();
            this.comboBoxLink = new System.Windows.Forms.ComboBox();
            this.buttonConditionAdd = new System.Windows.Forms.Button();
            this.buttonConditionDel = new System.Windows.Forms.Button();
            this.listViewConditions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.page_orders = new System.Windows.Forms.TabPage();
            this.listBoxOrderFieldsSelected = new System.Windows.Forms.ListBox();
            this.listBoxOrderFieldsAll = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDESC = new System.Windows.Forms.RadioButton();
            this.radioButtonASC = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonOrderFieldSelectCancelAll = new System.Windows.Forms.Button();
            this.buttonOrderFieldSelectAll = new System.Windows.Forms.Button();
            this.buttonOrderFieldSelectCancel = new System.Windows.Forms.Button();
            this.buttonOrderFieldSelect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.page_result = new System.Windows.Forms.TabPage();
            this.dataGridViewRes = new System.Windows.Forms.DataGridView();
            this.button_execute_query = new System.Windows.Forms.Button();
            this.button_look_sql = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.fiels_page.SuspendLayout();
            this.page_conditions.SuspendLayout();
            this.page_orders.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.page_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.fiels_page);
            this.tabControl1.Controls.Add(this.page_conditions);
            this.tabControl1.Controls.Add(this.page_orders);
            this.tabControl1.Controls.Add(this.page_result);
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 18);
            this.tabControl1.Location = new System.Drawing.Point(16, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // fiels_page
            // 
            this.fiels_page.BackColor = System.Drawing.Color.White;
            this.fiels_page.Controls.Add(this.listBox_selected_fields);
            this.fiels_page.Controls.Add(this.listBox_all_fields);
            this.fiels_page.Controls.Add(this.label2);
            this.fiels_page.Controls.Add(this.label1);
            this.fiels_page.Controls.Add(this.button_field_select_cancel_all);
            this.fiels_page.Controls.Add(this.button_field_select_all);
            this.fiels_page.Controls.Add(this.button_field_select_cancel);
            this.fiels_page.Controls.Add(this.button_field_select);
            this.fiels_page.Location = new System.Drawing.Point(4, 22);
            this.fiels_page.Margin = new System.Windows.Forms.Padding(4);
            this.fiels_page.Name = "fiels_page";
            this.fiels_page.Padding = new System.Windows.Forms.Padding(4);
            this.fiels_page.Size = new System.Drawing.Size(658, 359);
            this.fiels_page.TabIndex = 0;
            this.fiels_page.Text = "Поля";
            // 
            // listBox_selected_fields
            // 
            this.listBox_selected_fields.FormattingEnabled = true;
            this.listBox_selected_fields.ItemHeight = 16;
            this.listBox_selected_fields.Location = new System.Drawing.Point(367, 38);
            this.listBox_selected_fields.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_selected_fields.Name = "listBox_selected_fields";
            this.listBox_selected_fields.Size = new System.Drawing.Size(265, 308);
            this.listBox_selected_fields.TabIndex = 12;
            // 
            // listBox_all_fields
            // 
            this.listBox_all_fields.FormattingEnabled = true;
            this.listBox_all_fields.ItemHeight = 16;
            this.listBox_all_fields.Location = new System.Drawing.Point(17, 38);
            this.listBox_all_fields.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_all_fields.Name = "listBox_all_fields";
            this.listBox_all_fields.Size = new System.Drawing.Size(276, 308);
            this.listBox_all_fields.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выбранные поля:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Все поля:";
            // 
            // button_field_select_cancel_all
            // 
            this.button_field_select_cancel_all.Location = new System.Drawing.Point(303, 222);
            this.button_field_select_cancel_all.Margin = new System.Windows.Forms.Padding(4);
            this.button_field_select_cancel_all.Name = "button_field_select_cancel_all";
            this.button_field_select_cancel_all.Size = new System.Drawing.Size(56, 28);
            this.button_field_select_cancel_all.TabIndex = 8;
            this.button_field_select_cancel_all.Text = "<<";
            this.button_field_select_cancel_all.UseVisualStyleBackColor = true;
            this.button_field_select_cancel_all.Click += new System.EventHandler(this.Select_All_Field_Cancel_Click);
            // 
            // button_field_select_all
            // 
            this.button_field_select_all.Location = new System.Drawing.Point(303, 185);
            this.button_field_select_all.Margin = new System.Windows.Forms.Padding(4);
            this.button_field_select_all.Name = "button_field_select_all";
            this.button_field_select_all.Size = new System.Drawing.Size(56, 28);
            this.button_field_select_all.TabIndex = 7;
            this.button_field_select_all.Text = ">>";
            this.button_field_select_all.UseVisualStyleBackColor = true;
            this.button_field_select_all.Click += new System.EventHandler(this.Select_All_Fields_Click);
            // 
            // button_field_select_cancel
            // 
            this.button_field_select_cancel.Location = new System.Drawing.Point(303, 148);
            this.button_field_select_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_field_select_cancel.Name = "button_field_select_cancel";
            this.button_field_select_cancel.Size = new System.Drawing.Size(56, 28);
            this.button_field_select_cancel.TabIndex = 6;
            this.button_field_select_cancel.Text = "<";
            this.button_field_select_cancel.UseVisualStyleBackColor = true;
            this.button_field_select_cancel.Click += new System.EventHandler(this.Select_Fiels_Cancel_Click);
            // 
            // button_field_select
            // 
            this.button_field_select.Location = new System.Drawing.Point(303, 112);
            this.button_field_select.Margin = new System.Windows.Forms.Padding(4);
            this.button_field_select.Name = "button_field_select";
            this.button_field_select.Size = new System.Drawing.Size(56, 28);
            this.button_field_select.TabIndex = 5;
            this.button_field_select.Text = ">";
            this.button_field_select.UseVisualStyleBackColor = true;
            this.button_field_select.Click += new System.EventHandler(this.Select_Field_Click);
            // 
            // page_conditions
            // 
            this.page_conditions.Controls.Add(this.label6);
            this.page_conditions.Controls.Add(this.label5);
            this.page_conditions.Controls.Add(this.label4);
            this.page_conditions.Controls.Add(this.label3);
            this.page_conditions.Controls.Add(this.comboBoxFieldName);
            this.page_conditions.Controls.Add(this.comboBoxCriterion);
            this.page_conditions.Controls.Add(this.comboBoxValues);
            this.page_conditions.Controls.Add(this.comboBoxLink);
            this.page_conditions.Controls.Add(this.buttonConditionAdd);
            this.page_conditions.Controls.Add(this.buttonConditionDel);
            this.page_conditions.Controls.Add(this.listViewConditions);
            this.page_conditions.Location = new System.Drawing.Point(4, 22);
            this.page_conditions.Margin = new System.Windows.Forms.Padding(4);
            this.page_conditions.Name = "page_conditions";
            this.page_conditions.Padding = new System.Windows.Forms.Padding(4);
            this.page_conditions.Size = new System.Drawing.Size(658, 359);
            this.page_conditions.TabIndex = 1;
            this.page_conditions.Text = "Условия";
            this.page_conditions.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Связка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выражение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Критерий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя поля";
            // 
            // comboBoxFieldName
            // 
            this.comboBoxFieldName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFieldName.FormattingEnabled = true;
            this.comboBoxFieldName.Location = new System.Drawing.Point(9, 287);
            this.comboBoxFieldName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFieldName.Name = "comboBoxFieldName";
            this.comboBoxFieldName.Size = new System.Drawing.Size(233, 24);
            this.comboBoxFieldName.TabIndex = 6;
            this.comboBoxFieldName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFieldName_SelectedIndexChanged);
            // 
            // comboBoxCriterion
            // 
            this.comboBoxCriterion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterion.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">="});
            this.comboBoxCriterion.Location = new System.Drawing.Point(252, 287);
            this.comboBoxCriterion.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCriterion.Name = "comboBoxCriterion";
            this.comboBoxCriterion.Size = new System.Drawing.Size(77, 24);
            this.comboBoxCriterion.TabIndex = 5;
            // 
            // comboBoxValues
            // 
            this.comboBoxValues.FormattingEnabled = true;
            this.comboBoxValues.Location = new System.Drawing.Point(339, 287);
            this.comboBoxValues.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxValues.Name = "comboBoxValues";
            this.comboBoxValues.Size = new System.Drawing.Size(205, 24);
            this.comboBoxValues.TabIndex = 4;
            // 
            // comboBoxLink
            // 
            this.comboBoxLink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLink.FormattingEnabled = true;
            this.comboBoxLink.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.comboBoxLink.Location = new System.Drawing.Point(553, 287);
            this.comboBoxLink.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLink.Name = "comboBoxLink";
            this.comboBoxLink.Size = new System.Drawing.Size(89, 24);
            this.comboBoxLink.TabIndex = 3;
            // 
            // buttonConditionAdd
            // 
            this.buttonConditionAdd.Location = new System.Drawing.Point(445, 327);
            this.buttonConditionAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConditionAdd.Name = "buttonConditionAdd";
            this.buttonConditionAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonConditionAdd.TabIndex = 2;
            this.buttonConditionAdd.Text = "Добавить";
            this.buttonConditionAdd.UseVisualStyleBackColor = true;
            this.buttonConditionAdd.Click += new System.EventHandler(this.buttonConditionAdd_Click);
            // 
            // buttonConditionDel
            // 
            this.buttonConditionDel.Location = new System.Drawing.Point(553, 327);
            this.buttonConditionDel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConditionDel.Name = "buttonConditionDel";
            this.buttonConditionDel.Size = new System.Drawing.Size(92, 28);
            this.buttonConditionDel.TabIndex = 1;
            this.buttonConditionDel.Text = "Удалить";
            this.buttonConditionDel.UseVisualStyleBackColor = true;
            this.buttonConditionDel.Click += new System.EventHandler(this.buttonConditionDel_Click);
            // 
            // listViewConditions
            // 
            this.listViewConditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewConditions.FullRowSelect = true;
            this.listViewConditions.HideSelection = false;
            this.listViewConditions.Location = new System.Drawing.Point(9, 7);
            this.listViewConditions.Margin = new System.Windows.Forms.Padding(4);
            this.listViewConditions.Name = "listViewConditions";
            this.listViewConditions.Size = new System.Drawing.Size(635, 237);
            this.listViewConditions.TabIndex = 0;
            this.listViewConditions.UseCompatibleStateImageBehavior = false;
            this.listViewConditions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя поля";
            this.columnHeader1.Width = 118;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Критерий";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Значение";
            this.columnHeader3.Width = 212;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Связка";
            // 
            // page_orders
            // 
            this.page_orders.Controls.Add(this.listBoxOrderFieldsSelected);
            this.page_orders.Controls.Add(this.listBoxOrderFieldsAll);
            this.page_orders.Controls.Add(this.groupBox1);
            this.page_orders.Controls.Add(this.label8);
            this.page_orders.Controls.Add(this.buttonOrderFieldSelectCancelAll);
            this.page_orders.Controls.Add(this.buttonOrderFieldSelectAll);
            this.page_orders.Controls.Add(this.buttonOrderFieldSelectCancel);
            this.page_orders.Controls.Add(this.buttonOrderFieldSelect);
            this.page_orders.Controls.Add(this.label7);
            this.page_orders.Location = new System.Drawing.Point(4, 22);
            this.page_orders.Margin = new System.Windows.Forms.Padding(4);
            this.page_orders.Name = "page_orders";
            this.page_orders.Size = new System.Drawing.Size(658, 359);
            this.page_orders.TabIndex = 2;
            this.page_orders.Text = "Порядок";
            this.page_orders.UseVisualStyleBackColor = true;
            // 
            // listBoxOrderFieldsSelected
            // 
            this.listBoxOrderFieldsSelected.FormattingEnabled = true;
            this.listBoxOrderFieldsSelected.ItemHeight = 16;
            this.listBoxOrderFieldsSelected.Location = new System.Drawing.Point(292, 44);
            this.listBoxOrderFieldsSelected.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxOrderFieldsSelected.Name = "listBoxOrderFieldsSelected";
            this.listBoxOrderFieldsSelected.Size = new System.Drawing.Size(192, 308);
            this.listBoxOrderFieldsSelected.TabIndex = 16;
            this.listBoxOrderFieldsSelected.SelectedIndexChanged += new System.EventHandler(this.listBoxOrderFieldsSelected_SelectedIndexChanged);
            // 
            // listBoxOrderFieldsAll
            // 
            this.listBoxOrderFieldsAll.FormattingEnabled = true;
            this.listBoxOrderFieldsAll.ItemHeight = 16;
            this.listBoxOrderFieldsAll.Location = new System.Drawing.Point(27, 44);
            this.listBoxOrderFieldsAll.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxOrderFieldsAll.Name = "listBoxOrderFieldsAll";
            this.listBoxOrderFieldsAll.Size = new System.Drawing.Size(192, 308);
            this.listBoxOrderFieldsAll.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDESC);
            this.groupBox1.Controls.Add(this.radioButtonASC);
            this.groupBox1.Location = new System.Drawing.Point(497, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(144, 82);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Порядок";
            // 
            // radioButtonDESC
            // 
            this.radioButtonDESC.AutoSize = true;
            this.radioButtonDESC.Location = new System.Drawing.Point(9, 53);
            this.radioButtonDESC.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDESC.Name = "radioButtonDESC";
            this.radioButtonDESC.Size = new System.Drawing.Size(108, 21);
            this.radioButtonDESC.TabIndex = 1;
            this.radioButtonDESC.Text = "Убывающий";
            this.radioButtonDESC.UseVisualStyleBackColor = true;
            this.radioButtonDESC.Click += new System.EventHandler(this.radioButtonDESC_Click);
            // 
            // radioButtonASC
            // 
            this.radioButtonASC.AutoSize = true;
            this.radioButtonASC.Checked = true;
            this.radioButtonASC.Location = new System.Drawing.Point(9, 25);
            this.radioButtonASC.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonASC.Name = "radioButtonASC";
            this.radioButtonASC.Size = new System.Drawing.Size(128, 21);
            this.radioButtonASC.TabIndex = 0;
            this.radioButtonASC.TabStop = true;
            this.radioButtonASC.Text = "Возрастающий";
            this.radioButtonASC.UseVisualStyleBackColor = true;
            this.radioButtonASC.Click += new System.EventHandler(this.radioButtonASC_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Последовательность сортировки:";
            // 
            // buttonOrderFieldSelectCancelAll
            // 
            this.buttonOrderFieldSelectCancelAll.Location = new System.Drawing.Point(228, 228);
            this.buttonOrderFieldSelectCancelAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrderFieldSelectCancelAll.Name = "buttonOrderFieldSelectCancelAll";
            this.buttonOrderFieldSelectCancelAll.Size = new System.Drawing.Size(56, 28);
            this.buttonOrderFieldSelectCancelAll.TabIndex = 12;
            this.buttonOrderFieldSelectCancelAll.Text = "<<";
            this.buttonOrderFieldSelectCancelAll.UseVisualStyleBackColor = true;
            this.buttonOrderFieldSelectCancelAll.Click += new System.EventHandler(this.buttonOrderFieldSelectCancelAll_Click);
            // 
            // buttonOrderFieldSelectAll
            // 
            this.buttonOrderFieldSelectAll.Location = new System.Drawing.Point(228, 191);
            this.buttonOrderFieldSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrderFieldSelectAll.Name = "buttonOrderFieldSelectAll";
            this.buttonOrderFieldSelectAll.Size = new System.Drawing.Size(56, 28);
            this.buttonOrderFieldSelectAll.TabIndex = 11;
            this.buttonOrderFieldSelectAll.Text = ">>";
            this.buttonOrderFieldSelectAll.UseVisualStyleBackColor = true;
            this.buttonOrderFieldSelectAll.Click += new System.EventHandler(this.buttonOrderFieldSelectAll_Click);
            // 
            // buttonOrderFieldSelectCancel
            // 
            this.buttonOrderFieldSelectCancel.Location = new System.Drawing.Point(228, 154);
            this.buttonOrderFieldSelectCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrderFieldSelectCancel.Name = "buttonOrderFieldSelectCancel";
            this.buttonOrderFieldSelectCancel.Size = new System.Drawing.Size(56, 28);
            this.buttonOrderFieldSelectCancel.TabIndex = 10;
            this.buttonOrderFieldSelectCancel.Text = "<";
            this.buttonOrderFieldSelectCancel.UseVisualStyleBackColor = true;
            this.buttonOrderFieldSelectCancel.Click += new System.EventHandler(this.buttonOrderFieldSelectCancel_Click);
            // 
            // buttonOrderFieldSelect
            // 
            this.buttonOrderFieldSelect.Location = new System.Drawing.Point(228, 118);
            this.buttonOrderFieldSelect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrderFieldSelect.Name = "buttonOrderFieldSelect";
            this.buttonOrderFieldSelect.Size = new System.Drawing.Size(56, 28);
            this.buttonOrderFieldSelect.TabIndex = 9;
            this.buttonOrderFieldSelect.Text = ">";
            this.buttonOrderFieldSelect.UseVisualStyleBackColor = true;
            this.buttonOrderFieldSelect.Click += new System.EventHandler(this.buttonOrderFieldSelect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Все поля:";
            // 
            // page_result
            // 
            this.page_result.Controls.Add(this.dataGridViewRes);
            this.page_result.Location = new System.Drawing.Point(4, 22);
            this.page_result.Margin = new System.Windows.Forms.Padding(4);
            this.page_result.Name = "page_result";
            this.page_result.Size = new System.Drawing.Size(658, 359);
            this.page_result.TabIndex = 3;
            this.page_result.Text = "Результат";
            this.page_result.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRes
            // 
            this.dataGridViewRes.AllowUserToAddRows = false;
            this.dataGridViewRes.AllowUserToDeleteRows = false;
            this.dataGridViewRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewRes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRes.Name = "dataGridViewRes";
            this.dataGridViewRes.ReadOnly = true;
            this.dataGridViewRes.RowHeadersWidth = 51;
            this.dataGridViewRes.Size = new System.Drawing.Size(635, 321);
            this.dataGridViewRes.TabIndex = 0;
            // 
            // button_execute_query
            // 
            this.button_execute_query.Location = new System.Drawing.Point(534, 427);
            this.button_execute_query.Margin = new System.Windows.Forms.Padding(4);
            this.button_execute_query.Name = "button_execute_query";
            this.button_execute_query.Size = new System.Drawing.Size(144, 28);
            this.button_execute_query.TabIndex = 2;
            this.button_execute_query.Text = "Выполнить запрос";
            this.button_execute_query.UseVisualStyleBackColor = true;
            this.button_execute_query.Click += new System.EventHandler(this.buttonRunQuery_Click);
            // 
            // button_look_sql
            // 
            this.button_look_sql.Location = new System.Drawing.Point(382, 427);
            this.button_look_sql.Margin = new System.Windows.Forms.Padding(4);
            this.button_look_sql.Name = "button_look_sql";
            this.button_look_sql.Size = new System.Drawing.Size(144, 28);
            this.button_look_sql.TabIndex = 3;
            this.button_look_sql.Text = "Просмотр SQL";
            this.button_look_sql.UseVisualStyleBackColor = true;
            this.button_look_sql.Click += new System.EventHandler(this.buttonViewSQL_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 474);
            this.Controls.Add(this.button_look_sql);
            this.Controls.Add(this.button_execute_query);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Нестандартный запрос";
            this.tabControl1.ResumeLayout(false);
            this.fiels_page.ResumeLayout(false);
            this.fiels_page.PerformLayout();
            this.page_conditions.ResumeLayout(false);
            this.page_conditions.PerformLayout();
            this.page_orders.ResumeLayout(false);
            this.page_orders.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.page_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage fiels_page;
        private System.Windows.Forms.TabPage page_conditions;
        private System.Windows.Forms.TabPage page_orders;
        private System.Windows.Forms.TabPage page_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_field_select_cancel_all;
        private System.Windows.Forms.Button button_field_select_all;
        private System.Windows.Forms.Button button_field_select_cancel;
        private System.Windows.Forms.Button button_field_select;
        private System.Windows.Forms.Button button_execute_query;
        private System.Windows.Forms.Button button_look_sql;
        private System.Windows.Forms.Button buttonConditionAdd;
        private System.Windows.Forms.Button buttonConditionDel;
        private System.Windows.Forms.ListView listViewConditions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFieldName;
        private System.Windows.Forms.ComboBox comboBoxValues;
        private System.Windows.Forms.ComboBox comboBoxLink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDESC;
        private System.Windows.Forms.RadioButton radioButtonASC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonOrderFieldSelectCancelAll;
        private System.Windows.Forms.Button buttonOrderFieldSelectAll;
        private System.Windows.Forms.Button buttonOrderFieldSelectCancel;
        private System.Windows.Forms.Button buttonOrderFieldSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewRes;
        private System.Windows.Forms.ListBox listBox_all_fields;
        private System.Windows.Forms.ListBox listBox_selected_fields;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListBox listBoxOrderFieldsAll;
        private System.Windows.Forms.ComboBox comboBoxCriterion;
        private System.Windows.Forms.ListBox listBoxOrderFieldsSelected;
    }
}

