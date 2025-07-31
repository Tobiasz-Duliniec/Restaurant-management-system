namespace projekt_zaliczeniowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            Form2 productsForm = new Form2();
            productsForm.ShowDialog();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form3 orderForm = new Form3();
            orderForm.ShowDialog();
        }
    }
}
