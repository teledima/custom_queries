using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Npgsql;
using SqlKata;
using SqlKata.Execution;
using SqlKata.Compilers;


namespace custom_queries
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly string connectionString = "host=localhost; username=postgres; password=postgres; database=lab6;";
        readonly PostgresCompiler postgres_compiler = new PostgresCompiler();
        readonly List<Fields> ordertype = new List<Fields>();
        readonly IEnumerable<Fields> fields;
        readonly IEnumerable<Relation_info> relations;

        public Form()
        {
            InitializeComponent();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                var qr = new QueryFactory(connection, postgres_compiler);
                fields = qr.Query("fields").OrderBy("table_name").Get<Fields>();
                relations = qr.Query("relation_table").Get<Relation_info>();
            }

            // Page Fields
            listBox_all_fields.Items.AddRange(fields.ToArray());
            listBox_all_fields.DisplayMember = "transl_ru";
            listBox_selected_fields.DisplayMember = "transl_ru";

            // Page Сondition
            comboBoxFieldName.Items.AddRange(fields.ToArray());
            comboBoxFieldName.DisplayMember = "transl_ru";

            comboBoxCriterion.SelectedIndex = 0;

            // Page order
            listBoxOrderFieldsAll.DisplayMember = "transl_ru";
            listBoxOrderFieldsSelected.DisplayMember = "transl_ru";
        }

        // Page Fields
        private void Select_Field_Click(object sender, EventArgs e)
        {
            if (listBox_all_fields.SelectedIndex >= 0)
            {
                listBox_selected_fields.Items.Add(listBox_all_fields.SelectedItem);
                listBoxOrderFieldsAll.Items.Add(listBox_all_fields.SelectedItem);

                listBox_all_fields.Items.Remove(listBox_all_fields.SelectedItem);
            }
        }

        private void Select_All_Fields_Click(object sender, EventArgs e)
        {
            listBox_selected_fields.Items.AddRange(listBox_all_fields.Items);
            listBoxOrderFieldsAll.Items.AddRange(listBox_all_fields.Items);

            listBox_all_fields.Items.Clear();
        }

        private void Select_Fiels_Cancel_Click(object sender, EventArgs e)
        {
            if (listBox_selected_fields.SelectedIndex >= 0)
            {
                listBox_all_fields.Items.Add(listBox_selected_fields.SelectedItem);
                listBoxOrderFieldsAll.Items.Remove(listBox_selected_fields.SelectedItem);
                listBoxOrderFieldsSelected.Items.Remove(listBox_selected_fields.SelectedItem);
                listBox_selected_fields.Items.Remove(listBox_selected_fields.SelectedItem);
            }
        }

        private void Select_All_Field_Cancel_Click(object sender, EventArgs e)
        {
            listBox_all_fields.Items.AddRange(listBox_selected_fields.Items);

            listBoxOrderFieldsAll.Items.Clear();
            listBoxOrderFieldsSelected.Items.Clear();
            listBox_selected_fields.Items.Clear();
        }


        // Page Сondition

        private void comboBoxFieldName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fields f = (Fields)comboBoxFieldName.SelectedItem;
            if (f != null)
            {
                using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                var qr = new QueryFactory(connection, postgres_compiler);
                // очищаем старые значения
                comboBoxValues.Items.Clear();
                // добавляем новые значения в comboBox
                comboBoxValues.Items.AddRange(qr.Query(f.Table_name).Select(f.Field_name).WhereNotNull(f.Field_name).Get<string>().ToArray());
            }
        }

        private void buttonConditionAdd_Click(object sender, EventArgs e)
        {
            // если выбрано поле
            if (comboBoxFieldName.SelectedIndex >= 0)
            {
                Fields f = (Fields)comboBoxFieldName.Items[comboBoxFieldName.SelectedIndex];
                // проверка корректности введёного типа
                if (validateType(comboBoxValues.Text, f.Field_type))
                {
                    ListViewItem t = new ListViewItem(f.Transl_ru);
                    t.SubItems.Add(comboBoxCriterion.Text);
                    t.SubItems.Add(comboBoxValues.Text);
                    t.SubItems.Add(comboBoxLink.Text);

                    // эти поля скрыты
                    t.SubItems.Add(f.Field_name);
                    t.SubItems.Add(f.Table_name);
                    t.SubItems.Add(f.Field_type);

                    // добавление нового listViewItem
                    listViewConditions.Items.Add(t);
                }
                else
                    MessageBox.Show("Не верный тип выражения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Поле не выбрано", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonConditionDel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem temp in listViewConditions.SelectedItems)
                listViewConditions.Items.Remove(temp);
        }


        // Page Order
        private void buttonOrderFieldSelect_Click(object sender, EventArgs e)
        {
            if (listBoxOrderFieldsAll.SelectedIndex >= 0)
            {
                listBoxOrderFieldsSelected.Items.Add(listBoxOrderFieldsAll.SelectedItem);

                listBoxOrderFieldsAll.Items.Remove(listBoxOrderFieldsAll.SelectedItem);
            }
        }

        private void buttonOrderFieldSelectCancel_Click(object sender, EventArgs e)
        {
            if (listBoxOrderFieldsSelected.SelectedIndex >= 0)
            {
                listBoxOrderFieldsAll.Items.Add(listBoxOrderFieldsSelected.SelectedItem);
                listBoxOrderFieldsSelected.Items.Remove(listBoxOrderFieldsSelected.SelectedItem);
            }
        }

        private void buttonOrderFieldSelectAll_Click(object sender, EventArgs e)
        {
            listBoxOrderFieldsSelected.Items.AddRange(listBoxOrderFieldsAll.Items);
            listBoxOrderFieldsAll.Items.Clear();
        }

        private void buttonOrderFieldSelectCancelAll_Click(object sender, EventArgs e)
        {
            listBoxOrderFieldsAll.Items.AddRange(listBoxOrderFieldsSelected.Items);
            listBoxOrderFieldsSelected.Items.Clear();
        }

        private void listBoxOrderFieldsSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordertype.Contains(listBoxOrderFieldsSelected.SelectedItem))
                radioButtonDESC.Checked = true;
            else
                radioButtonASC.Checked = true;
        }

        private void radioButtonASC_Click(object sender, EventArgs e)
        {
            if (listBoxOrderFieldsSelected.SelectedIndex >= 0)
                ordertype.Remove((Fields)listBoxOrderFieldsSelected.SelectedItem);
        }

        private void radioButtonDESC_Click(object sender, EventArgs e)
        {
            if (listBoxOrderFieldsSelected.SelectedIndex >= 0)
                ordertype.Add((Fields)listBoxOrderFieldsSelected.SelectedItem);
        }


        //
        private void buttonViewSQL_Click(object sender, EventArgs e)
        {
            MessageBox.Show(postgres_compiler.Compile(Generate()).Sql);
        }

        private void buttonRunQuery_Click(object sender, EventArgs e)
        {
            dataGridViewRes.Columns.Clear();

            // Create Columns
            foreach (Fields f in listBox_selected_fields.Items)
                dataGridViewRes.Columns.Add(f.Field_name, f.Transl_ru);


            using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            var qf = new QueryFactory(connection, postgres_compiler);
            foreach (var row in qf.FromQuery(Generate()).Get())
                dataGridViewRes.Rows.Add(((IDictionary<string, object>)row).Values.ToArray());
        }


        //
        private Query Generate()
        {
            List<string> fields = new List<string>();
            SortedSet<string> tables = new SortedSet<string>();
            SortedSet<string> sqlRelations = new SortedSet<string>();

            // добавляем все необходимые поля и таблицы
            foreach (Fields field in listBox_selected_fields.Items)
            {
                fields.Add(field.Table_name + "." + field.Field_name);
                tables.Add(field.Table_name);
            }

            // если в условии есть таблицы, которые ещё не содержаться в taables то добавляем
            foreach (ListViewItem i in listViewConditions.Items)
                tables.Add(i.SubItems[5].Text);

            // search relations
            List<string> tempTables = tables.ToList();
            var pairTable = new Stack<(string table1, string table2)>();
            for (int i = 0; i < tables.Count-1; i++)
                for (int j = i; j < tables.Count-1; j++)
                    pairTable.Push((tempTables[i], tempTables[j + 1]));


            while (pairTable.Count > 0)
            {
                var pt = pairTable.Pop();
                tables.Add(pt.table1);
                tables.Add(pt.table2);

                Relation_info t = relations.Where(x => x.Table_1 == pt.table1 && x.Table_2 == pt.table2 || x.Table_1 == pt.table2 && x.Table_2 == pt.table1).FirstOrDefault();
                if (t.Via is null)
                    sqlRelations.Add(t.Relations);
                else
                {
                    var new_pt1 = (t.Table_1, t.Via);
                    var new_pt2 = (t.Table_2, t.Via);

                    if (!pairTable.Contains(new_pt1))
                        pairTable.Push(new_pt1);
                    if (!pairTable.Contains(new_pt2))
                        pairTable.Push(new_pt2);
                }
            }

            // generate sql string
            var q = new Query()
                .Select(fields.ToArray())
                .FromRaw(string.Join(", ", tables.ToArray()))            // tables
                .WhereRaw(string.Join(" AND ", sqlRelations.ToArray())) // relations tables
                .Where(x => userConditions(x));                         // user conditions

            // user orders
            foreach (Fields field in listBoxOrderFieldsSelected.Items)
            {
                if (ordertype.Contains(field))
                    q.OrderByDesc(field.Table_name + "." + field.Field_name);
                else
                    q.OrderBy(field.Table_name + "." + field.Field_name);
            }

            return q;
        }

        private Query userConditions(Query x)
        {
            foreach (ListViewItem i in listViewConditions.Items)
            {
                if (i.SubItems[3].Text == "OR")
                    x.OrWhere(i.SubItems[5].Text + "." + i.SubItems[4].Text, i.SubItems[1].Text, toType(i.SubItems[2].Text, i.SubItems[6].Text));
                else
                    x.Where(i.SubItems[5].Text + "." + i.SubItems[4].Text, i.SubItems[1].Text, toType(i.SubItems[2].Text, i.SubItems[6].Text));
            }
            return x;
        }

        private bool validateType(string value, string type)
        {
            return type switch
            {
                "S" => true,
                "I" => int.TryParse(value, out _),
                _ => false,
            };
        }

        private object toType(string value, string type)
        {
            return type switch
            {
                "S" => value,
                "I" => int.Parse(value),
                _ => null,
            };
        }
    }

    public class Fields
    {
        public string Field_name { get; set; }
        public string Table_name { get; set; }
        public string Field_type { get; set; }
        public string Transl_ru { get; set; }
    }

    public class Relation_info
    {
        public string Table_1 { get; set; }
        public string Table_2 { get; set; }
        public string Relations { get; set; }
        public string Via { get; set; }
    }
}
