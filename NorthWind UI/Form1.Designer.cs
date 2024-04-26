namespace NorthWind_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            toolStripMenuManage = new ToolStripMenuItem();
            toolStripMenuILoad = new ToolStripMenuItem();
            toolStripMenuSave = new ToolStripMenuItem();
            toolStripMenuDown = new ToolStripMenuItem();
            toolStripMenuIUp = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 422);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuManage, toolStripMenuIUp, toolStripMenuDown });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "Manage";
            // 
            // toolStripMenuManage
            // 
            toolStripMenuManage.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuILoad, toolStripMenuSave });
            toolStripMenuManage.Name = "toolStripMenuManage";
            toolStripMenuManage.Size = new Size(77, 24);
            toolStripMenuManage.Text = "Manage";
            // 
            // toolStripMenuILoad
            // 
            toolStripMenuILoad.Name = "toolStripMenuILoad";
            toolStripMenuILoad.Size = new Size(125, 26);
            toolStripMenuILoad.Text = "Load";
            toolStripMenuILoad.Click += toolStripMenuILoad_Click;
            // 
            // toolStripMenuSave
            // 
            toolStripMenuSave.Name = "toolStripMenuSave";
            toolStripMenuSave.Size = new Size(125, 26);
            toolStripMenuSave.Text = "Save";
            // 
            // toolStripMenuDown
            // 
            toolStripMenuDown.Name = "toolStripMenuDown";
            toolStripMenuDown.Size = new Size(33, 24);
            toolStripMenuDown.Text = "<";
            toolStripMenuDown.Click += toolStripMenuUp_Click;
            // 
            // toolStripMenuIUp
            // 
            toolStripMenuIUp.Name = "toolStripMenuIUp";
            toolStripMenuIUp.Size = new Size(33, 24);
            toolStripMenuIUp.Text = ">";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuManage;
        private ToolStripMenuItem toolStripMenuILoad;
        private ToolStripMenuItem toolStripMenuSave;
        private ToolStripMenuItem toolStripMenuDown;
        private ToolStripMenuItem toolStripMenuIUp;
    }
}
