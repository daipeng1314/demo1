using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : UIForm
    {
        int index;
        public Form1()
        {
            InitializeComponent();
            var box = new UIGroupBox();
            box.Width = 900;
            box.Height = 580;
            box.SetDPIScale();
            box.Text = "" + index++.ToString("D2");
            box.Name = box.Text;
            //UserContorl
            var uicontent = new UserControl1();
            uicontent.Dock = DockStyle.Top;
            box.Controls.Add(uicontent);
            //flowLayoutPanel1.Controls.Add(box);
            uiFlowLayoutPanel1.Add(box);
        }
    }
}
