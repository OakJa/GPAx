namespace Gpax
{
    public partial class Form1 : Form
    {
        GPAcalculator gpa;
        public Form1()
        {
            InitializeComponent();
            gpa = new GPAcalculator();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(this.tbGPAxinput.Text);
                gpa.setGpa(input);
                this.tbGPAx.Text = gpa.getGpa().ToString();
                this.tbGPAMax.Text = gpa.GetMaxGPA().ToString();
                this.tbGPAMin.Text = gpa.GetMinGPA().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}