using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
    }
}
