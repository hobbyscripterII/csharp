using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaminationZone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Msg.Text = "기계를 가동합니다.";
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Msg.Text = "기계를 정지합니다.";
        }

        private void Msg_Click(object sender, EventArgs e)
        {

        }
    }
}
