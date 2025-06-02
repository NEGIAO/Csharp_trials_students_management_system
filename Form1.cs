using System.Collections;

namespace 学生管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //怎么提交啊
        //学生集合的实例对象，存放添加
        private StudentCollection students = new StudentCollection();
        //添加学生 相应函数
        private void button1_add_student(object sender, EventArgs e)
        {
            int id;
            string name = input_name.Text.Trim();//去除首位空格的字符串
            //检验输入数据有效性
            if (!int.TryParse(input_ID.Text, out id))
            //out关键字的使用，函数内部必须赋值，运行逻辑结果自动赋值给out修饰值
            {
                MessageBox.Show("请输入正确的ID");
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入正确的学生姓名");
                return;
            }
            //判断学生的ID是否存在
            if (students[id] != null)
            {
                MessageBox.Show("该学生ID已存在");
                return;
            }

            //创建学生对象
            var student = new StudentCollection.Student(students, id, name);
            int grade;
            if (int.TryParse(input_score.Text, out grade))
            {
                student.Grade = grade;
            }
            students.Add(student);
            RefreshStudentList();//刷新学生列表

            //清空输入框
            input_ID.Clear();
            input_name.Clear();
            input_score.Clear();
            input_ID.Focus();//设置焦点到ID输入框

            listBox_information_dispaly.Items.Add(input_ID.Text + "                    " + input_name.Text + "                   " + input_score.Text + "\n");
        }
        //生成嵌套类，内部嵌套了学生类
        public class StudentCollection : System.Collections.IEnumerable
        {
            private List<Student> studentslist = new List<Student>();
            public event EventHandler<GradeUpdatedEventArgs> GradeUpdated;//事件的声明
            public int Count
            {
                get { return studentslist.Count; }
            }

            public void Add(Student s)
            {
                studentslist.Add(s);
            }

            public IEnumerator GetEnumerator()
            {
                return studentslist.GetEnumerator();
            }

            //索引器:返回值 + this +[]
            //作用：可以像数组一样的访问对象
            public Student this[int index]
            {
                get { return studentslist.Find(s => s.id == index); }
                //Find()方法会遍历列表元素，将元素作为s传入
                //遍历所有的元素，找到第一个符合条件的值（id等于索引值，即为条件）
                //条件为true时，返回改元素
                set { studentslist[index] = value; }
                //value:赋值操作右侧的值，类型为索引器的类型（Student）
            }
            public void Sort(int sortType)
            {
                switch (sortType)
                {
                    case 0:
                        studentslist.Sort((s1, s2) => s1.id.CompareTo(s2.id));
                        break;
                    case 1:
                        studentslist.Sort((s1, s2) => string.Compare(s1.name, s2.name));
                        break;
                    case 2:
                        studentslist.Sort((s1, s2) =>
                        {
                            if (s1.Grade < 0) return 1;
                            //如果成绩小于0，放在最后面
                            if (s2.Grade < 0) return -1;
                            return s2.Grade.CompareTo(s1.Grade);
                        }
                        );
                        break;
                    default:
                        throw new ArgumentException("Invalid sort type");
                }
            }
            public class Student//嵌套类
            {
                private readonly StudentCollection parent;
                //构造函数，传入父类的引用
                //This is the constructor for the Student class , which initializes the student with an ID and name.
                public Student(StudentCollection parent, int id, string name)
                {
                    this.parent = parent;
                    this.id = id;
                    this.name = name;
                }
                public int id { get; set; }
                public string name { get; set; }
                private int grade;
                public int Grade
                {
                    get { return grade; }//避免非法访问
                    set
                    {
                        if (grade != value)
                        {
                            grade = value;
                            OnGradeUpdated(new GradeUpdatedEventArgs(id, value));
                        }
                    }
                }
                private void OnGradeUpdated(GradeUpdatedEventArgs e)
                {
                    if (parent != null && parent.GradeUpdated != null)
                    {
                        parent.GradeUpdated(this, e);
                    }
                }
            }
            public class GradeUpdatedEventArgs : EventArgs
            {
                public int StudentId { get; private set; }
                public int NewGrade { get; private set; }
                public GradeUpdatedEventArgs(int studentId, int newGrade)
                {
                    this.StudentId = studentId;
                    this.NewGrade = newGrade;
                }
            }
        }

        //更新成绩
        private void button2_update_score(object sender, EventArgs e)
        {
            int id;
            int grade;
            if (!int.TryParse(input_ID.Text, out id) && int.TryParse(input_score.Text, out grade))
            {
                var student = students[id];
                if (student != null)
                {
                    student.Grade = grade;
                    RefreshStudentList();
                }
                else
                {
                    MessageBox.Show("没有找到该学生，请检查ID是否正确");
                }
            }
            else
            {
                MessageBox.Show("请输入正确的ID和成绩");
            }
        }

        //统计成绩
        private void button3_Click_statistics(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                label_display_outcome.Text = "没有学生信息";
                return;
            }
            int validCount = 0;
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (StudentCollection.Student student in students)
            {
                if (student.Grade >= 0)
                {
                    sum += student.Grade;
                    validCount++;
                    if (student.Grade > max)
                    {
                        max = student.Grade;
                    }
                    if (student.Grade < min)
                    {
                        min = student.Grade;
                    }
                }
                if (validCount == 0)
                {
                    label_display_outcome.Text = "没有有效成绩";
                    return;
                }
                double acerage = (double)sum / validCount;
                label_display_outcome.Text = $"有效成绩数量: {validCount}\n" +
                              $"总分: {sum}\n" +
                              $"平均分: {acerage:F2}\n" +
                              $"最高分: {max}\n" +
                              $"最低分: {min}";
            }
        }
        //按钮点击事件的响应函数
        private void button_click_search(object sender, EventArgs e)
        {
            string keyword = input_search.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                RefreshStudentList();
                MessageBox.Show("请输入搜索关键字");
                return;
            }
            listBox_information_dispaly.Items.Clear();
            bool found = false;
            foreach (StudentCollection.Student student in students)
            {
                if (student.name.Contains(keyword) || student.id.ToString() == keyword)
                {
                    listBox_information_dispaly.Items.Add($"{student.id}         {student.name}          {student.Grade}");
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show("没有找到匹配的学生");
            }

        }
        //排序的点击事件
        private void button5_Click_rank(object sender, EventArgs e)
        {
            if (input_rank.SelectedIndex < 0)
            {
                MessageBox.Show("请选择排序方式");
                return;
            }
            students.Sort(input_rank.SelectedIndex); //根据选择的排序方式进行排序
            RefreshStudentList(); //刷新学生列表
            if (input_rank.SelectedIndex == 0)
            {
                students.Sort(0); //按ID排序
            }
            else if (input_rank.SelectedIndex == 1)
            {
                students.Sort(1); //按姓名排序
            }
            else if (input_rank.SelectedIndex == 2)
            {
                students.Sort(2); //按成绩排序
            }
        }
        public void RefreshStudentList()
        {
            listBox_information_dispaly.Items.Clear();
            foreach (StudentCollection.Student student in students)
            {
                listBox_information_dispaly.Items.Add($"{student.id}         {student.name}          {student.Grade}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
