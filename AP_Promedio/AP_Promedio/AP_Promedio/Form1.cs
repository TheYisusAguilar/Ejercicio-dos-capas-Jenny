//usar logica de negocio 
using AP_Promedio;
namespace AP_Promedio
{
    public partial class promedio : Form
    {
        public promedio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            //obtener los numeros de las cajas de texto
            int num1, num2, num3;
            num1 = Convert.ToInt32(txt_numero1.Text);
            num2 = Convert.ToInt32(txt_numero2.Text);
            num3 = Convert.ToInt32(txt_numero3.Text);

            //Se instancia la clase 
            Promedio promedio = new promedio();

            // Establece números individuales usando métodos de establecimiento
            promedio.setNum1 = num1;
            promedio.setNum2 = num2;
            promedio.setNum3 = num3;
            if (!promedio.Calcular())
            {
                MessageBox.Show(promedio.getError);
                return;
            }
            txt_promedio.Text = promedio.getProm.ToString();
        }

        private void promedio_Load(object sender, EventArgs e)
        {

        }
    }
}