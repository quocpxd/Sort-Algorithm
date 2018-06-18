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
    public partial class Setting : Form
    {
        Form1 parent;
        Color oldBackColor;
        Color oldNodeColor;
        Font oldFont;
        Color oldTextColor;
        public Setting(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            Init();
        }

        private void Init()
        {
            this.Icon = new Icon(@"icon/sort.ico");
            btnBackColor.BackColor = parent.BackColor;
            btnNodeColor.BackColor = NodeServices.DefaultColor;
            txtFontCode.Text = parent.listCode.Font.Name;
            txtFontCode.Font = parent.listCode.Font;
            txtFontCode.ForeColor = parent.listCode.ForeColor;

            this.ControlBox = false;

            oldBackColor = btnBackColor.BackColor;
            oldFont = parent.listCode.Font;
            oldNodeColor = btnNodeColor.BackColor;
            oldTextColor = parent.ForeColor;
            btnTextColor.BackColor = parent.ForeColor;
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                btnBackColor.BackColor = colorDialog.Color;
                parent.BackColor = btnBackColor.BackColor;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            parent.listCode.Font = txtFontCode.Font;
            parent.listCode.ForeColor = txtFontCode.ForeColor;
            NodeServices.DefaultColor = btnNodeColor.BackColor;
            this.Close();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.BackColor = oldBackColor;
            parent.listCode.Font = oldFont;
            parent.ForeColor = oldTextColor;
            NodeServices.DefaultColor = oldNodeColor;
            this.Close();
            this.Dispose();
        }

        private void btnNodeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                btnNodeColor.BackColor = colorDialog.Color;
            }
        }

        private void txtFontCode_MouseClick(object sender, MouseEventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.Font = txtFontCode.Font;
            fontDialog.Color = txtFontCode.ForeColor;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtFontCode.Font = fontDialog.Font;
                txtFontCode.Text = txtFontCode.Font.Name;
                txtFontCode.ForeColor = fontDialog.Color;

            }
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                parent.ForeColor = colorDialog.Color;
                btnTextColor.BackColor = colorDialog.Color;
            }
        }
    }
}
