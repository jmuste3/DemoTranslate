namespace DemoTranslate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anglèsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.japonèsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tibetàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomaToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.vistaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalàToolStripMenuItem,
            this.anglèsToolStripMenuItem,
            this.japonèsToolStripMenuItem,
            this.originalToolStripMenuItem,
            this.tibetàToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            resources.ApplyResources(this.idiomaToolStripMenuItem, "idiomaToolStripMenuItem");
            // 
            // catalàToolStripMenuItem
            // 
            this.catalàToolStripMenuItem.Name = "catalàToolStripMenuItem";
            resources.ApplyResources(this.catalàToolStripMenuItem, "catalàToolStripMenuItem");
            this.catalàToolStripMenuItem.Click += new System.EventHandler(this.catalàToolStripMenuItem_Click);
            // 
            // anglèsToolStripMenuItem
            // 
            this.anglèsToolStripMenuItem.Name = "anglèsToolStripMenuItem";
            resources.ApplyResources(this.anglèsToolStripMenuItem, "anglèsToolStripMenuItem");
            this.anglèsToolStripMenuItem.Click += new System.EventHandler(this.anglèsToolStripMenuItem_Click);
            // 
            // japonèsToolStripMenuItem
            // 
            this.japonèsToolStripMenuItem.Name = "japonèsToolStripMenuItem";
            resources.ApplyResources(this.japonèsToolStripMenuItem, "japonèsToolStripMenuItem");
            this.japonèsToolStripMenuItem.Click += new System.EventHandler(this.japonèsToolStripMenuItem_Click);
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            resources.ApplyResources(this.originalToolStripMenuItem, "originalToolStripMenuItem");
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            resources.ApplyResources(this.editarToolStripMenuItem, "editarToolStripMenuItem");
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            resources.ApplyResources(this.vistaToolStripMenuItem, "vistaToolStripMenuItem");
            // 
            // tibetàToolStripMenuItem
            // 
            this.tibetàToolStripMenuItem.Name = "tibetàToolStripMenuItem";
            resources.ApplyResources(this.tibetàToolStripMenuItem, "tibetàToolStripMenuItem");
            this.tibetàToolStripMenuItem.Click += new System.EventHandler(this.tibetàToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem idiomaToolStripMenuItem;
        private ToolStripMenuItem catalàToolStripMenuItem;
        private ToolStripMenuItem anglèsToolStripMenuItem;
        private ToolStripMenuItem japonèsToolStripMenuItem;
        private ToolStripMenuItem originalToolStripMenuItem;
        private ToolStripMenuItem tibetàToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem vistaToolStripMenuItem;
    }
}