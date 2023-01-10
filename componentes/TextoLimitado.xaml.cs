
using System.Windows.Controls;


namespace ClaseComponenteVisual.componentes
{
    /// <summary>
    /// Lógica de interacción para TextoLimitado.xaml
    /// </summary>
    public partial class TextoLimitado : UserControl
    {
        public TextoLimitado()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public string Titulo { get; set; }
        public int LongitudTexto { get; set; }

        private void ContenidoDni_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = this.FindName("ContenidoDni") as TextBox;
            // Textbox "LetraDni"
            TextBox tb2 = this.FindName("LetraDni") as TextBox;
            if (tb.Text.Length == 8)
            {
                int dni = int.Parse(tb.Text);
                tb2.Text = CalculaLetra(dni).ToString();
            }

            if (tb.Text.Length < 8)
            {
                tb2.Text = "";
            }
        }

        private char CalculaLetra(int dni)
        {
            string tablaLetras = "TRWAGMYFPDXBNJZSQVHLCKE";
            int posicion = dni % 23;
            return tablaLetras[posicion];
        }
    }
}