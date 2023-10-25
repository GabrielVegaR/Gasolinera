namespace Gasolinera
{
    public partial class Form1 : Form
    {
        int contador = 0;

        const double precioRegular = 1.41;
        const double precioPremium = 1.90;
        const double precioSuperPremium = 3.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            int cantidadGalones = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("indique la cantidad total de gasolina a servir: "));

            Total(btnRegular.Text, cantidadGalones);
        }

        public void Total(string tipoCombustible, int cantGalones)
        {
            double total = 0;

            switch (tipoCombustible) 
            {
                case "Regular":
                    total = precioRegular * cantGalones;
                    lblTotal.Text = String.Format("{0:C}", total);
                    break;
                case "Premium":
                    total = precioPremium * cantGalones;
                    lblTotal.Text = String.Format("{0:C}", total);
                    break;
                case "Super Premium":
                    total = precioSuperPremium * cantGalones;
                    lblTotal.Text = String.Format("{0:C}", total);
                    break;
            }
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            int cantidadGalones = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("indique la cantidad total de gasolina a servir: "));

            Total(btnPremium.Text, cantidadGalones);
        }

        private void btnSuperPremium_Click(object sender, EventArgs e)
        {
            int cantidadGalones = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("indique la cantidad total de gasolina a servir: "));

            Total(btnSuperPremium.Text, cantidadGalones);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador = contador + 1;

        }
    }
}