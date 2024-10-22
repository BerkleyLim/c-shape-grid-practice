using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace grid_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView(); // DataGridView �ʱ�ȭ
        }

        // DataGridView �ʱ�ȭ �� ������ ���ε�
        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersVisible = true;

            // �ؽ�Ʈ �÷� ����
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "ID";

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.HeaderText = "�̸�";
            nameColumn.DataPropertyName = "Name";

            DataGridViewTextBoxColumn ageColumn = new DataGridViewTextBoxColumn();
            ageColumn.Name = "Age";
            ageColumn.HeaderText = "����";
            ageColumn.DataPropertyName = "Age";

            // ComboBox �÷� ���� (���� ����)
            DataGridViewComboBoxColumn genderColumn = new DataGridViewComboBoxColumn();
            genderColumn.Name = "Gender";
            genderColumn.HeaderText = "����";
            genderColumn.DataPropertyName = "Gender";  // ������ �Ӽ� ���ε�
            genderColumn.Items.AddRange("Male", "Female", "Other");  // ���� �׸� ����

            // �÷��� DataGridView�� �߰�
            dataGridView1.Columns.Add(idColumn);
            dataGridView1.Columns.Add(nameColumn);
            dataGridView1.Columns.Add(ageColumn);
            dataGridView1.Columns.Add(genderColumn);  // ComboBox �÷� �߰�

            // ������ ���ε�
            List<Person> people = new List<Person>
            {
                new Person { ID = 1, Name = "Alice", Age = 30, Gender = "Female" },
                new Person { ID = 2, Name = "Bob", Age = 25, Gender = "Male" },
                new Person { ID = 3, Name = "Charlie", Age = 35, Gender = "Other" }
            };

            dataGridView1.DataSource = people;

            // ���� ���� ����
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        // ������ �ҽ� Ŭ���� ����
        public class Person
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }  // �߰��� �Ӽ�
        }
    }
}
