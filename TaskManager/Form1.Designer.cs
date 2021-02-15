namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnEndTask = new System.Windows.Forms.Button();
            this.pcRAM = new System.Diagnostics.PerformanceCounter();
            this.L = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CPUprogressbar = new System.Windows.Forms.ProgressBar();
            this.ramLbl = new System.Windows.Forms.Label();
            this.cpulbl = new System.Windows.Forms.Label();
            this.pcCPU = new System.Diagnostics.PerformanceCounter();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(651, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNewTaskToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runNewTaskToolStripMenuItem
            // 
            this.runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
            this.runNewTaskToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.runNewTaskToolStripMenuItem.Text = "Run new task";
            this.runNewTaskToolStripMenuItem.Click += new System.EventHandler(this.runNewTaskToolStripMenuItem_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(13, 32);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(612, 532);
            this.listBox.TabIndex = 2;
            // 
            // btnEndTask
            // 
            this.btnEndTask.Location = new System.Drawing.Point(544, 573);
            this.btnEndTask.Name = "btnEndTask";
            this.btnEndTask.Size = new System.Drawing.Size(95, 32);
            this.btnEndTask.TabIndex = 3;
            this.btnEndTask.Text = "End Task";
            this.btnEndTask.UseVisualStyleBackColor = true;
            this.btnEndTask.Click += new System.EventHandler(this.btnEndTask_Click);
            // 
            // pcRAM
            // 
            this.pcRAM.CategoryName = "Memory";
            this.pcRAM.CounterName = "% Committed Bytes In Use";
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(13, 587);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(58, 17);
            this.L.TabIndex = 4;
            this.L.Text = "Memory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPU";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(116, 587);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // CPUprogressbar
            // 
            this.CPUprogressbar.Location = new System.Drawing.Point(116, 636);
            this.CPUprogressbar.Name = "CPUprogressbar";
            this.CPUprogressbar.Size = new System.Drawing.Size(362, 23);
            this.CPUprogressbar.TabIndex = 7;
            // 
            // ramLbl
            // 
            this.ramLbl.AutoSize = true;
            this.ramLbl.Location = new System.Drawing.Point(485, 592);
            this.ramLbl.Name = "ramLbl";
            this.ramLbl.Size = new System.Drawing.Size(51, 17);
            this.ramLbl.TabIndex = 8;
            this.ramLbl.Text = "ramLbl";
            // 
            // cpulbl
            // 
            this.cpulbl.AutoSize = true;
            this.cpulbl.Location = new System.Drawing.Point(488, 641);
            this.cpulbl.Name = "cpulbl";
            this.cpulbl.Size = new System.Drawing.Size(45, 17);
            this.cpulbl.TabIndex = 9;
            this.cpulbl.Text = "cpulbl";
            // 
            // pcCPU
            // 
            this.pcCPU.CategoryName = "Processor";
            this.pcCPU.CounterName = "% Processor Time";
            this.pcCPU.InstanceName = "_Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 767);
            this.Controls.Add(this.cpulbl);
            this.Controls.Add(this.ramLbl);
            this.Controls.Add(this.CPUprogressbar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L);
            this.Controls.Add(this.btnEndTask);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNewTaskToolStripMenuItem;
        private System.Windows.Forms.Button btnEndTask;
        private System.Windows.Forms.ListBox listBox;
        private System.Diagnostics.PerformanceCounter pcRAM;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar CPUprogressbar;
        private System.Windows.Forms.Label ramLbl;
        private System.Windows.Forms.Label cpulbl;
        private System.Diagnostics.PerformanceCounter pcCPU;
    }
}

