namespace Telefoonlijst
{
    partial class frmTelefoonlijst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefoonlijst));
            this.nfiTel = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.tsmBestand = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBestandAfsluiten = new System.Windows.Forms.ToolStripMenuItem();
            this.stmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.stmHelpHandleiding = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmHelpOver = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsMenuAfsluiten = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.lstGebruikers = new System.Windows.Forms.ListBox();
            this.txtZoeken = new System.Windows.Forms.TextBox();
            this.lblZoeken = new System.Windows.Forms.Label();
            this.lblMailTo = new System.Windows.Forms.LinkLabel();
            this.lblDienst = new System.Windows.Forms.Label();
            this.txtGSM = new System.Windows.Forms.Label();
            this.txtTelefoon = new System.Windows.Forms.Label();
            this.mnuMenu.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // nfiTel
            // 
            this.nfiTel.Icon = ((System.Drawing.Icon)(resources.GetObject("nfiTel.Icon")));
            this.nfiTel.Text = "Telefoonlijst";
            this.nfiTel.Visible = true;
            this.nfiTel.DoubleClick += new System.EventHandler(this.nfiTel_DoubleClick);
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBestand,
            this.stmHelp});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(355, 24);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // tsmBestand
            // 
            this.tsmBestand.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBestandAfsluiten});
            this.tsmBestand.Name = "tsmBestand";
            this.tsmBestand.Size = new System.Drawing.Size(61, 20);
            this.tsmBestand.Text = "&Bestand";
            // 
            // tsmBestandAfsluiten
            // 
            this.tsmBestandAfsluiten.Name = "tsmBestandAfsluiten";
            this.tsmBestandAfsluiten.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmBestandAfsluiten.Size = new System.Drawing.Size(163, 22);
            this.tsmBestandAfsluiten.Text = "Af&sluiten";
            this.tsmBestandAfsluiten.Click += new System.EventHandler(this.tsmBestandAfsluiten_Click);
            // 
            // stmHelp
            // 
            this.stmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmHelpHandleiding,
            this.toolStripSeparator1,
            this.tsmHelpOver});
            this.stmHelp.Enabled = false;
            this.stmHelp.Name = "stmHelp";
            this.stmHelp.Size = new System.Drawing.Size(44, 20);
            this.stmHelp.Text = "&Help";
            // 
            // stmHelpHandleiding
            // 
            this.stmHelpHandleiding.Name = "stmHelpHandleiding";
            this.stmHelpHandleiding.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.stmHelpHandleiding.Size = new System.Drawing.Size(158, 22);
            this.stmHelpHandleiding.Text = "Handleiding";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmHelpOver
            // 
            this.tsmHelpOver.Name = "tsmHelpOver";
            this.tsmHelpOver.Size = new System.Drawing.Size(158, 22);
            this.tsmHelpOver.Text = "Over";
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsMenuAfsluiten});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(122, 26);
            // 
            // cmsMenuAfsluiten
            // 
            this.cmsMenuAfsluiten.Name = "cmsMenuAfsluiten";
            this.cmsMenuAfsluiten.Size = new System.Drawing.Size(121, 22);
            this.cmsMenuAfsluiten.Text = "Afsluiten";
            this.cmsMenuAfsluiten.Click += new System.EventHandler(this.tsmBestandAfsluiten_Click);
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.Location = new System.Drawing.Point(6, 24);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(341, 35);
            this.lblGebruiker.TabIndex = 2;
            this.lblGebruiker.Text = "Joske Vermeulen";
            this.lblGebruiker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstGebruikers
            // 
            this.lstGebruikers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGebruikers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGebruikers.FormattingEnabled = true;
            this.lstGebruikers.ItemHeight = 18;
            this.lstGebruikers.Location = new System.Drawing.Point(6, 176);
            this.lstGebruikers.Name = "lstGebruikers";
            this.lstGebruikers.Size = new System.Drawing.Size(341, 148);
            this.lstGebruikers.TabIndex = 6;
            this.lstGebruikers.SelectedIndexChanged += new System.EventHandler(this.lstGebruikers_SelectedIndexChanged);
            // 
            // txtZoeken
            // 
            this.txtZoeken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZoeken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoeken.Location = new System.Drawing.Point(80, 335);
            this.txtZoeken.Name = "txtZoeken";
            this.txtZoeken.Size = new System.Drawing.Size(267, 24);
            this.txtZoeken.TabIndex = 8;
            this.txtZoeken.TextChanged += new System.EventHandler(this.txtZoeken_TextChanged);
            this.txtZoeken.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZoeken_KeyDown);
            // 
            // lblZoeken
            // 
            this.lblZoeken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZoeken.AutoSize = true;
            this.lblZoeken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoeken.Location = new System.Drawing.Point(6, 338);
            this.lblZoeken.Name = "lblZoeken";
            this.lblZoeken.Size = new System.Drawing.Size(62, 18);
            this.lblZoeken.TabIndex = 12;
            this.lblZoeken.Text = "Zoeken:";
            // 
            // lblMailTo
            // 
            this.lblMailTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMailTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailTo.Location = new System.Drawing.Point(6, 149);
            this.lblMailTo.Name = "lblMailTo";
            this.lblMailTo.Size = new System.Drawing.Size(341, 23);
            this.lblMailTo.TabIndex = 14;
            this.lblMailTo.TabStop = true;
            this.lblMailTo.Text = "e-mail";
            this.lblMailTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMailTo.Click += new System.EventHandler(this.lblMailTo_Click);
            // 
            // lblDienst
            // 
            this.lblDienst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDienst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienst.Location = new System.Drawing.Point(6, 61);
            this.lblDienst.Name = "lblDienst";
            this.lblDienst.Size = new System.Drawing.Size(341, 18);
            this.lblDienst.TabIndex = 15;
            this.lblDienst.Text = "Dienst";
            this.lblDienst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGSM
            // 
            this.txtGSM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGSM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGSM.Location = new System.Drawing.Point(6, 114);
            this.txtGSM.Name = "txtGSM";
            this.txtGSM.Size = new System.Drawing.Size(341, 35);
            this.txtGSM.TabIndex = 16;
            this.txtGSM.Text = "0498-93.90.00";
            this.txtGSM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTelefoon
            // 
            this.txtTelefoon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefoon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTelefoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoon.Location = new System.Drawing.Point(6, 79);
            this.txtTelefoon.Name = "txtTelefoon";
            this.txtTelefoon.Size = new System.Drawing.Size(341, 35);
            this.txtTelefoon.TabIndex = 17;
            this.txtTelefoon.Text = "0498-93.90.00";
            this.txtTelefoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTelefoonlijst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 371);
            this.Controls.Add(this.txtTelefoon);
            this.Controls.Add(this.txtGSM);
            this.Controls.Add(this.lblDienst);
            this.Controls.Add(this.lblMailTo);
            this.Controls.Add(this.lblZoeken);
            this.Controls.Add(this.txtZoeken);
            this.Controls.Add(this.lstGebruikers);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.mnuMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenu;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "frmTelefoonlijst";
            this.Text = "Telefoonlijst";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nfiTel;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmBestand;
        private System.Windows.Forms.ToolStripMenuItem tsmBestandAfsluiten;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsMenuAfsluiten;
        private System.Windows.Forms.ToolStripMenuItem stmHelp;
        private System.Windows.Forms.ToolStripMenuItem stmHelpHandleiding;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmHelpOver;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.ListBox lstGebruikers;
        private System.Windows.Forms.TextBox txtZoeken;
        private System.Windows.Forms.Label lblZoeken;
        private System.Windows.Forms.LinkLabel lblMailTo;
        private System.Windows.Forms.Label lblDienst;
        private System.Windows.Forms.Label txtGSM;
        private System.Windows.Forms.Label txtTelefoon;
    }
}

