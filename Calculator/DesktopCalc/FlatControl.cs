using System.ComponentModel;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace DesktopCalc
{
    public partial class FlatControl : Panel
    {

        public string Caption
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public FlatControl()
        {
            InitializeComponent();
        }

        
    }
}
