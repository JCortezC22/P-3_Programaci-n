using CapaNegocio;
namespace CapaPresentacionn
{
    public partial class Form1 : Form
    {
        
        CN_productos objetoCN = new CN_productos();
        private string idproducto = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            MostrarProd();

        }

        private void MostrarProd()
        {
            CN_productos objetoCN = new CN_productos();
            dataGridView1.DataSource = objetoCN.MostrarProd();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                try
                {
                    objetoCN.InsertarProd(textNom.Text, textDes.Text, textPrec.Text, textCant.Text, textEsta.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarProd();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar por ", ex.Message);
                } 
         
        }

        //BtnEditar
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textNom.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textDes.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                textPrec.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                textCant.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
                textEsta.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                idproducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila por favor :) "); 
        }



        private void Limpiar()
        {
            textNom.Clear();
            textDes.Clear();
            textPrec.Clear();
            textCant.Clear();
            textEsta.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}