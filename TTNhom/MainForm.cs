using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNhom.Properties;

namespace TTNhom
{
    public partial class MainForm : Form
    {
        private bool isCollapsed = true;
		private bool isCollapsed2 = true;
		private bool isCollapsed3 = true;
		private bool isCollapsed4 = true;
		private bool isCollapsed5 = true;
		public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
			if (isCollapsed)
			{
				buttonTeacher.Image = Resources.Collapse_Arrow_20px;
				panelTeacher.Height += 10;
				if (panelTeacher.Size == panelTeacher.MaximumSize)
				{
					timer1.Stop();
					isCollapsed = false;
				}
			}
			else
			{
				buttonTeacher.Image = Resources.Expand_Arrow_20px;
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

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (isCollapsed2)
			{
				buttonStudent.Image = Resources.Collapse_Arrow_20px;
				panelStudent.Height += 10;
				if (panelStudent.Size == panelStudent.MaximumSize)
				{
					timer2.Stop();
					isCollapsed2 = false;
				}
			}
			else
			{
				buttonStudent.Image = Resources.Expand_Arrow_20px;
				panelStudent.Height -= 10;
				if (panelStudent.Size == panelStudent.MinimumSize)
				{
					timer2.Stop();
					isCollapsed2 = true;
				}
			}
		}

		private void buttonStudent_Click(object sender, EventArgs e)
		{
			timer2.Start();
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			if (isCollapsed3)
			{
				buttonSubject.Image = Resources.Collapse_Arrow_20px;
				panelSubject.Height += 10;
				if (panelSubject.Size == panelSubject.MaximumSize)
				{
					timer3.Stop();
					isCollapsed3 = false;
				}
			}
			else
			{
				buttonSubject.Image = Resources.Expand_Arrow_20px;
				panelSubject.Height -= 10;
				if (panelSubject.Size == panelSubject.MinimumSize)
				{
					timer3.Stop();
					isCollapsed3 = true;
				}
			}
		}

		private void buttonSubject_Click(object sender, EventArgs e)
		{
			timer3.Start();
		}

		private void timer4_Tick(object sender, EventArgs e)
		{
			if (isCollapsed4)
			{
				buttonClass.Image = Resources.Collapse_Arrow_20px;
				panelClass.Height += 10;
				if (panelClass.Size == panelClass.MaximumSize)
				{
					timer4.Stop();
					isCollapsed4 = false;
				}
			}
			else
			{
				buttonClass.Image = Resources.Expand_Arrow_20px;
				panelClass.Height -= 10;
				if (panelClass.Size == panelClass.MinimumSize)
				{
					timer4.Stop();
					isCollapsed4 = true;
				}
			}
		}

		private void buttonClass_Click(object sender, EventArgs e)
		{
			timer4.Start();
		}

		private void timer5_Tick(object sender, EventArgs e)
		{
			if (isCollapsed5)
			{
				buttonTimeTable.Image = Resources.Collapse_Arrow_20px;
				panelTimeTable.Height += 10;
				if (panelTimeTable.Size == panelTimeTable.MaximumSize)
				{
					timer5.Stop();
					isCollapsed5 = false;
				}
			}
			else
			{
				buttonTimeTable.Image = Resources.Expand_Arrow_20px;
				panelTimeTable.Height -= 10;
				if (panelTimeTable.Size == panelClass.MinimumSize)
				{
					timer5.Stop();
					isCollapsed5 = true;
				}
			}
		}

		private void buttonTimeTable_Click(object sender, EventArgs e)
		{
			timer5.Start();
		}
	}
}
