using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_sort
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"image/Info.png");
            this.ControlBox = false;
            this.Icon = new Icon(@"icon/sort.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
