
namespace EDnevnik
{
    partial class Glavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jedanBezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedanSaFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaBezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smeroviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skolskeGodineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaSaFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_user = new System.Windows.Forms.Label();
            this.raspodelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jedanBezToolStripMenuItem,
            this.jedanSaFKToolStripMenuItem,
            this.tabelaBezToolStripMenuItem,
            this.tabelaSaFKToolStripMenuItem,
            this.izvestajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jedanBezToolStripMenuItem
            // 
            this.jedanBezToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobeToolStripMenuItem});
            this.jedanBezToolStripMenuItem.Name = "jedanBezToolStripMenuItem";
            this.jedanBezToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.jedanBezToolStripMenuItem.Text = "Jedan Bez";
            // 
            // osobeToolStripMenuItem
            // 
            this.osobeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.osobeToolStripMenuItem.Name = "osobeToolStripMenuItem";
            this.osobeToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.osobeToolStripMenuItem.Text = "Osobe";
            this.osobeToolStripMenuItem.Click += new System.EventHandler(this.osobeToolStripMenuItem_Click);
            // 
            // jedanSaFKToolStripMenuItem
            // 
            this.jedanSaFKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raspodelaToolStripMenuItem});
            this.jedanSaFKToolStripMenuItem.Name = "jedanSaFKToolStripMenuItem";
            this.jedanSaFKToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.jedanSaFKToolStripMenuItem.Text = "Jedan SaFK";
            // 
            // tabelaBezToolStripMenuItem
            // 
            this.tabelaBezToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smeroviToolStripMenuItem,
            this.skolskeGodineToolStripMenuItem,
            this.predmetiToolStripMenuItem,
            this.osobeToolStripMenuItem1});
            this.tabelaBezToolStripMenuItem.Name = "tabelaBezToolStripMenuItem";
            this.tabelaBezToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.tabelaBezToolStripMenuItem.Text = "Tabela Bez";
            // 
            // smeroviToolStripMenuItem
            // 
            this.smeroviToolStripMenuItem.Name = "smeroviToolStripMenuItem";
            this.smeroviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smeroviToolStripMenuItem.Text = "Smerovi";
            this.smeroviToolStripMenuItem.Click += new System.EventHandler(this.SmeroviToolStripMenuItem_Click);
            // 
            // skolskeGodineToolStripMenuItem
            // 
            this.skolskeGodineToolStripMenuItem.Name = "skolskeGodineToolStripMenuItem";
            this.skolskeGodineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.skolskeGodineToolStripMenuItem.Text = "Skolske godine";
            this.skolskeGodineToolStripMenuItem.Click += new System.EventHandler(this.SkolskeGodineToolStripMenuItem_Click);
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.predmetiToolStripMenuItem.Text = "Predmeti";
            this.predmetiToolStripMenuItem.Click += new System.EventHandler(this.PredmetiToolStripMenuItem_Click);
            // 
            // osobeToolStripMenuItem1
            // 
            this.osobeToolStripMenuItem1.Name = "osobeToolStripMenuItem1";
            this.osobeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.osobeToolStripMenuItem1.Text = "Osobe";
            this.osobeToolStripMenuItem1.Click += new System.EventHandler(this.OsobeToolStripMenuItem1_Click);
            // 
            // tabelaSaFKToolStripMenuItem
            // 
            this.tabelaSaFKToolStripMenuItem.Name = "tabelaSaFKToolStripMenuItem";
            this.tabelaSaFKToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.tabelaSaFKToolStripMenuItem.Text = "Tabela SaFK";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_user.Location = new System.Drawing.Point(418, 6);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(75, 13);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "Denis Krajacic";
            // 
            // raspodelaToolStripMenuItem
            // 
            this.raspodelaToolStripMenuItem.Name = "raspodelaToolStripMenuItem";
            this.raspodelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raspodelaToolStripMenuItem.Text = "Raspodela";
            this.raspodelaToolStripMenuItem.Click += new System.EventHandler(this.RaspodelaToolStripMenuItem_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 316);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(576, 355);
            this.MinimumSize = new System.Drawing.Size(576, 355);
            this.Name = "Glavna";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna_FormClosed);
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jedanBezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedanSaFKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaBezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaSaFKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.ToolStripMenuItem smeroviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skolskeGodineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem raspodelaToolStripMenuItem;
    }
}