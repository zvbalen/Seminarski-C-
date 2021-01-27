using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] proc;

        void GetAllProcess()
        {
            proc = Process.GetProcesses();
            listBox.Items.Clear();
            foreach (Process p in proc)
                listBox.Items.Add(p.ProcessName);

        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();

        }

        private void btnEndTask_Click(object sender, EventArgs e)
        {
            try
            {
                proc[listBox.SelectedIndex].Kill();
                GetAllProcess();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
            }

        }

        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
