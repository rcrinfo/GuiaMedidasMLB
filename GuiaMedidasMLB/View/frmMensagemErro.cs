using System.Windows.Forms;

namespace GuiaMedidasMLB.View
{
    public partial class frmMensagemErro : Form
    {
        public frmMensagemErro(string Texto)
        {
            InitializeComponent();
            txtTexto.Text = Texto;
        }
    }
}
