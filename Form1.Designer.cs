namespace Cukraszda_forms
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
            menuStrip1 = new MenuStrip();
            fajlToolStripMenuItem = new ToolStripMenuItem();
            sutemenyekToolStripMenuItem = new ToolStripMenuItem();
            nevjegyekToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fajlToolStripMenuItem, sutemenyekToolStripMenuItem, nevjegyekToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(521, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            fajlToolStripMenuItem.Size = new Size(37, 20);
            fajlToolStripMenuItem.Text = "Fájl";
            fajlToolStripMenuItem.Click += fajlToolStripMenuItem_Click;
            // 
            // sutemenyekToolStripMenuItem
            // 
            sutemenyekToolStripMenuItem.Name = "sutemenyekToolStripMenuItem";
            sutemenyekToolStripMenuItem.Size = new Size(84, 20);
            sutemenyekToolStripMenuItem.Text = "Sütemények";
            // 
            // nevjegyekToolStripMenuItem
            // 
            nevjegyekToolStripMenuItem.Name = "nevjegyekToolStripMenuItem";
            nevjegyekToolStripMenuItem.Size = new Size(74, 20);
            nevjegyekToolStripMenuItem.Text = "Névjegyek";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 243);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 528);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fajlToolStripMenuItem;
        private ToolStripMenuItem sutemenyekToolStripMenuItem;
        private ToolStripMenuItem nevjegyekToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
