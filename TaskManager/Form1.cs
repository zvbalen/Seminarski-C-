using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1;
        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetAllProcess();
        }


        public Form1()
        {
            InitializeComponent();


        }

        Process[] arrayOfProcesses;


        void GetAllProcess()
        {

            try
            {
                float cpu = pcCPU.NextValue();
                float memory = pcRAM.NextValue();

                progressBar1.Value = (int)memory;
                ramLbl.Text = string.Format("{0:0.00}%", memory);

                CPUprogressbar.Value = ((int)cpu);

                cpulbl.Text = string.Format("{0:0.00}%", cpu);

                arrayOfProcesses = Process.GetProcesses();
                listBox.Items.Clear();
                foreach (Process process in arrayOfProcesses)
                {
                    listBox.Items.Add(process.ProcessName);

                }
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }


        private void btnEndTask_Click(object sender, EventArgs e)
        {
            try
            {
                arrayOfProcesses[listBox.SelectedIndex].Kill();
                GetAllProcess();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RunTask Rt = new RunTask())
            {
                if (Rt.ShowDialog() == DialogResult.OK)
                    GetAllProcess();
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            InitTimer();

        }
    }
}
