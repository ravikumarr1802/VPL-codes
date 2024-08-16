using System.Windows.Forms;
using System.Drawing;
namespace first
{
    public class MyForm:Form
    {
        public MyForm()
        {
            InitComponents();
        }
        private void InitComponents()
        {
            ColorDialog dlg=new ColorDialog();
            dlg.ShowDialog();
        }
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(new MyForm());
        }
    }
}