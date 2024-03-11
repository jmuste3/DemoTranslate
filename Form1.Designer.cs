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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            idiomaToolStripMenuItem = new ToolStripMenuItem();
            catalàToolStripMenuItem = new ToolStripMenuItem();
            anglèsToolStripMenuItem = new ToolStripMenuItem();
            japonèsToolStripMenuItem = new ToolStripMenuItem();
            originalToolStripMenuItem = new ToolStripMenuItem();
            tibetàToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            vistaToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { idiomaToolStripMenuItem, editarToolStripMenuItem, vistaToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // idiomaToolStripMenuItem
            // 
            idiomaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { catalàToolStripMenuItem, anglèsToolStripMenuItem, japonèsToolStripMenuItem, originalToolStripMenuItem, tibetàToolStripMenuItem });
            idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            resources.ApplyResources(idiomaToolStripMenuItem, "idiomaToolStripMenuItem");
            // 
            // catalàToolStripMenuItem
            // 
            catalàToolStripMenuItem.Name = "catalàToolStripMenuItem";
            resources.ApplyResources(catalàToolStripMenuItem, "catalàToolStripMenuItem");
            catalàToolStripMenuItem.Click += catalàToolStripMenuItem_Click;
            // 
            // anglèsToolStripMenuItem
            // 
            anglèsToolStripMenuItem.Name = "anglèsToolStripMenuItem";
            resources.ApplyResources(anglèsToolStripMenuItem, "anglèsToolStripMenuItem");
            anglèsToolStripMenuItem.Click += anglèsToolStripMenuItem_Click;
            // 
            // japonèsToolStripMenuItem
            // 
            japonèsToolStripMenuItem.Name = "japonèsToolStripMenuItem";
            resources.ApplyResources(japonèsToolStripMenuItem, "japonèsToolStripMenuItem");
            japonèsToolStripMenuItem.Click += japonèsToolStripMenuItem_Click;
            // 
            // originalToolStripMenuItem
            // 
            originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            resources.ApplyResources(originalToolStripMenuItem, "originalToolStripMenuItem");
            originalToolStripMenuItem.Click += originalToolStripMenuItem_Click;
            // 
            // tibetàToolStripMenuItem
            // 
            tibetàToolStripMenuItem.Name = "tibetàToolStripMenuItem";
            resources.ApplyResources(tibetàToolStripMenuItem, "tibetàToolStripMenuItem");
            tibetàToolStripMenuItem.Click += tibetàToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            resources.ApplyResources(editarToolStripMenuItem, "editarToolStripMenuItem");
            // 
            // vistaToolStripMenuItem
            // 
            vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            resources.ApplyResources(vistaToolStripMenuItem, "vistaToolStripMenuItem");
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
    }
}