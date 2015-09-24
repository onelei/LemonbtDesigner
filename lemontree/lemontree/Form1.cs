using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lemontree
{
    public partial class Form1 : Form
    {
        private int mActionNum=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // 关于界面;
            MessageBox.Show(
                "blog: onelei.github.io\n"
                +"email:ahleiwolong@163.com"
                );
        }

        // 行为节点;
        private void NodeAction_Click(object sender, EventArgs e)
        {
            ++mActionNum;
            Button button = new Button();
            button.Text = "Action" + mActionNum;
            Point mousePos = Control.MousePosition;
            this.Controls.Add(button);
            mousePos  = this.PointToClient(mousePos);
            Point parentPoint = listBox2.Location;
            mousePos.Offset(-parentPoint.X, -parentPoint.Y);
            button.Location = mousePos;
            button.Parent = listBox2;
            button.Visible = true;
            button.Click += actionClick;
        }

        private void actionClick(object sender, EventArgs e)
        {
            Point mousePos = Control.MousePosition;
        }
    }
}
