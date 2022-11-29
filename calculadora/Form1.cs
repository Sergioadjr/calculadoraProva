namespace calculadora
{
    public partial class Form1 : Form
    {

        Calculadora nova = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + btnVirgula.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            nova.Setelemento1(double.Parse(txtVisor.Text));
            nova.Setoperacao("/");
            txtVisor.Text = "";
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + btn3.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + btn6.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + btn5.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + btn4.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + btn9.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + btn8.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + btn7.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + btn0.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = " ";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            nova.Setelemento1(double.Parse(txtVisor.Text));
            nova.Setoperacao("+");
            txtVisor.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            nova.Setelemento2(double.Parse(txtVisor.Text));
            txtVisor.Text = nova.executarOperacao().ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            nova.Setelemento1(double.Parse(txtVisor.Text));
            nova.Setoperacao("-");
            txtVisor.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            nova.Setelemento1(double.Parse(txtVisor.Text));
            nova.Setoperacao("*");
            txtVisor.Text = "";
        }
    }
}