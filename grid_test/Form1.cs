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
            InitializeDataGridView(); // DataGridView 초기화
        }

        // DataGridView 초기화 및 데이터 바인딩
        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersVisible = true;

            // 텍스트 컬럼 생성
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "ID";

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.HeaderText = "이름";
            nameColumn.DataPropertyName = "Name";

            DataGridViewTextBoxColumn ageColumn = new DataGridViewTextBoxColumn();
            ageColumn.Name = "Age";
            ageColumn.HeaderText = "나이";
            ageColumn.DataPropertyName = "Age";

            // ComboBox 컬럼 생성 (성별 선택)
            DataGridViewComboBoxColumn genderColumn = new DataGridViewComboBoxColumn();
            genderColumn.Name = "Gender";
            genderColumn.HeaderText = "성별";
            genderColumn.DataPropertyName = "Gender";  // 데이터 속성 바인딩
            genderColumn.Items.AddRange("Male", "Female", "Other");  // 선택 항목 설정

            // 컬럼을 DataGridView에 추가
            dataGridView1.Columns.Add(idColumn);
            dataGridView1.Columns.Add(nameColumn);
            dataGridView1.Columns.Add(ageColumn);
            dataGridView1.Columns.Add(genderColumn);  // ComboBox 컬럼 추가

            // 데이터 바인딩
            List<Person> people = new List<Person>
            {
                new Person { ID = 1, Name = "Alice", Age = 30, Gender = "Female" },
                new Person { ID = 2, Name = "Bob", Age = 25, Gender = "Male" },
                new Person { ID = 3, Name = "Charlie", Age = 35, Gender = "Other" }
            };

            dataGridView1.DataSource = people;

            // 정렬 가능 설정
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        // 데이터 소스 클래스 정의
        public class Person
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }  // 추가된 속성
        }
    }
}
