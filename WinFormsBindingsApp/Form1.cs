namespace WinFormsBindingsApp
{
    public partial class Form1 : Form
    {
        Employee employee;
        public Form1()
        {
            InitializeComponent();

            employee = new Employee() { Name = "Bobby", Age = 26 };

            this.DataContext = employee;

            textBox1.DataBindings.Add(new Binding("Text", this.DataContext, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
            numericUpDown1.DataBindings.Add(new Binding("Value", this.DataContext, "Age", false, DataSourceUpdateMode.OnPropertyChanged));

            label1.DataBindings.Add(new Binding("Text", this.DataContext, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
            label2.DataBindings.Add(new Binding("Text", this.DataContext, "Age", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee.Name = "Lenny";
            employee.Age = 33;
        }
    }
}
