namespace project
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumberAllTask = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNumberAllTaskCompleted = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNumberAllTaskUncompleted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "all available tasks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 216);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTaskToolStripMenuItem,
            this.taskCompletedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 48);
            // 
            // deleteTaskToolStripMenuItem
            // 
            this.deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            this.deleteTaskToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteTaskToolStripMenuItem.Text = "Delete Task";
            this.deleteTaskToolStripMenuItem.Click += new System.EventHandler(this.deleteTaskToolStripMenuItem_Click);
            // 
            // taskCompletedToolStripMenuItem
            // 
            this.taskCompletedToolStripMenuItem.Name = "taskCompletedToolStripMenuItem";
            this.taskCompletedToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.taskCompletedToolStripMenuItem.Text = "Task Completed";
            this.taskCompletedToolStripMenuItem.Click += new System.EventHandler(this.taskCompletedToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(376, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number Of Tasks";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumberAllTask
            // 
            this.labelNumberAllTask.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberAllTask.ForeColor = System.Drawing.Color.White;
            this.labelNumberAllTask.Location = new System.Drawing.Point(536, 34);
            this.labelNumberAllTask.Name = "labelNumberAllTask";
            this.labelNumberAllTask.Size = new System.Drawing.Size(100, 23);
            this.labelNumberAllTask.TabIndex = 4;
            this.labelNumberAllTask.Text = "label2";
            this.labelNumberAllTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(376, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number Of Tasks Completed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumberAllTaskCompleted
            // 
            this.labelNumberAllTaskCompleted.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberAllTaskCompleted.ForeColor = System.Drawing.Color.White;
            this.labelNumberAllTaskCompleted.Location = new System.Drawing.Point(536, 67);
            this.labelNumberAllTaskCompleted.Name = "labelNumberAllTaskCompleted";
            this.labelNumberAllTaskCompleted.Size = new System.Drawing.Size(100, 23);
            this.labelNumberAllTaskCompleted.TabIndex = 4;
            this.labelNumberAllTaskCompleted.Text = "label2";
            this.labelNumberAllTaskCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(376, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Number Of Tasks Uncompleted";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumberAllTaskUncompleted
            // 
            this.labelNumberAllTaskUncompleted.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberAllTaskUncompleted.ForeColor = System.Drawing.Color.White;
            this.labelNumberAllTaskUncompleted.Location = new System.Drawing.Point(536, 100);
            this.labelNumberAllTaskUncompleted.Name = "labelNumberAllTaskUncompleted";
            this.labelNumberAllTaskUncompleted.Size = new System.Drawing.Size(100, 23);
            this.labelNumberAllTaskUncompleted.TabIndex = 4;
            this.labelNumberAllTaskUncompleted.Text = "label2";
            this.labelNumberAllTaskUncompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(663, 436);
            this.Controls.Add(this.labelNumberAllTaskUncompleted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelNumberAllTaskCompleted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNumberAllTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Projects Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskCompletedToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumberAllTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNumberAllTaskCompleted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNumberAllTaskUncompleted;
    }
}