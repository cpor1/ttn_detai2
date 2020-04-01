using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom
{
    public partial class MainForm : Form
    {
        private bool isCollapsed = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
			if (isCollapsed)
			{
				panelTeacher.Height += 10;
				if (panelTeacher.Size == panelTeacher.MaximumSize)
				{
					timer1.Stop();
					isCollapsed = false;
				}
			}
			else
			{
				panelTeacher.Height -= 10;
				if (panelTeacher.Size == panelTeacher.MinimumSize)
				{
					timer1.Stop();
					isCollapsed = true;
				}
			}
		}

		private void buttonTeacher_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}
