namespace testTask;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        textBox1.Text = Interop.Sum(1, 1).ToString();
    }
}