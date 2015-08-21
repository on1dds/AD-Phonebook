using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefoonlijst
{
    public partial class frmTelefoonlijst : Form
    {
        //
        // properties
        //

        public List<User> ADusers;
        public List<User> FilteredUsers;
        BindingSource bs = new BindingSource();


        public frmTelefoonlijst()
        {
            InitializeComponent();
        }

        //
        // Events
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            // Maak windows klaar
            int x = Screen.PrimaryScreen.WorkingArea.Right - (this.Width + 5);
            int y = Screen.PrimaryScreen.WorkingArea.Bottom - (this.Height + 5);
            this.Location = new Point(x, y);
            this.Text = "Telefoonlijst (" + Environment.MachineName + ")";
            nfiTel.ContextMenuStrip = cmsMenu;

            // lees de gebruikers uit de Active Directory
            ADusers = ad.GetAllUsers().OrderBy(o => o.DisplayName).ToList();
            if (ADusers==null)
                Application.Exit();

            FilteredUsers = ad.GetAllUsers().OrderBy(o => o.DisplayName).ToList(); 

            // koppel de gebruikerslijst aan de listview
            bs.DataSource = FilteredUsers;
            lstGebruikers.DataSource = bs;
            lstGebruikers.DisplayMember = "Listview";
            bs.ResetBindings(false);

            // maak de tekstvelden leeg
            lblGebruiker.Text = string.Empty;
            lblDienst.Text = string.Empty;
            lstGebruikers.ClearSelected();
        }

        private void lstGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectListItem(lstGebruikers.SelectedIndex);
            txtZoeken.Select();
            //if(lstGebruikers.SelectedIndex != -1)
            //    Debug.Print(FilteredUsers[lstGebruikers.SelectedIndex].Zoek);
        }

        private void txtZoeken_TextChanged(object sender, EventArgs e)
        {
            filter(txtZoeken.Text);
            bs.ResetBindings(false);
            if(lstGebruikers.SelectedIndex != -1)
                lstGebruikers.SelectedIndex = 0;
            SelectListItem(lstGebruikers.SelectedIndex);
        }

        private void SelectListItem(int index)
        {
            if (index >= 0 && index < FilteredUsers.Count)
            {
                // kopieer geselecteerde gebruiker
                User u = new User();
                u = FilteredUsers[index];

                // toon naam
                lblGebruiker.Text = u.DisplayName;

                if (u.Dienst == string.Empty)
                    lblDienst.Text = u.Functie;
                else
                    lblDienst.Text = u.Dienst;

                if (u.TelefoonWerk == string.Empty)
                    txtTelefoon.Text = string.Empty;
                else
                    txtTelefoon.Text = u.TelefoonWerk;

                txtTelefoon.Text =  u.TelefoonWerk;
                txtGSM.Text = u.Mobiel;

                lblMailTo.Text = u.Email.ToLower();
                //txtBeschrijving.Text = u.Info;
                //txtGeslacht.Text = u.Geslacht;
            }
            else
            {
                lblGebruiker.Text = string.Empty;
                lblDienst.Text = string.Empty;
                txtTelefoon.Text = string.Empty;
                txtGSM.Text = string.Empty;
                lblMailTo.Text = string.Empty;
            }
        }

        private void filter(string trefzin)
        {
            FilteredUsers.Clear();
            if (trefzin != "")
            {
                trefzin = Verzacht(trefzin).Trim();

                // doorzoek elke gebruiker
                foreach (User user in ADusers)
                {

                    string doorzoekzin = Verzacht(user.DisplayName + " " +user.Details);
                    int matchcount = 0;
                    // doorzoek met elk woord in de trefzin
                    foreach (string zoek in trefzin.Split(' '))
                    {
                        string trefwoord = " " + zoek.Trim();
                        if (doorzoekzin.Contains(trefwoord))
                            matchcount += 1;
                        else
                            break;
                    }
                    if (matchcount == trefzin.Split(' ').Length)
                    {
                        FilteredUsers.Add(user);
                        //Debug.Print(trefzin + ":" + doorzoekzin);
                    }

                }
                
            }
            else
                foreach (User user in ADusers)
                    FilteredUsers.Add(user);
        }

        // af
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }
        private void nfiTel_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private bool _reallyClose;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_reallyClose)
            {
                //  e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
        }
        private void tsmBestandAfsluiten_Click(object sender, EventArgs e)
        {
            _reallyClose = true;
            nfiTel.Dispose();
            Application.Exit();
        }
        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            ADusers = ad.GetAllUsers();
            //lstGebruikers.DataSource = ADusers;
            //lstGebruikers.DisplayMember = "DisplayName";
        }
        private void lblMailTo_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:" + lblMailTo.Text);
        }
        private void txtZoeken_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstGebruikers.Items.Count != -1)
            {
                int page = lstGebruikers.ClientSize.Height / lstGebruikers.ItemHeight - 1;
                int pos = lstGebruikers.SelectedIndex;
                switch (e.KeyCode)
                {
                    case (Keys.Down):
                        pos++;
                        break;
                    case (Keys.Up):
                        pos--;
                        break;
                    case (Keys.PageDown):
                        pos += page;
                        break;
                    case (Keys.PageUp):
                        pos -= page;
                        break;
                    case (Keys.F5):
                        // lees de gebruikers uit de Active Directory
                        ADusers = ad.GetAllUsers().OrderBy(o => o.DisplayName).ToList();
                        filter(txtZoeken.Text);
                        // koppel de gebruikerslijst aan de listview
                        //bs.ResetBindings(false);
                        lstGebruikers.DataSource = bs;
                        lstGebruikers.DisplayMember = "Displayname";
                        bs.ResetBindings(false);
                        lstGebruikers.Update();
                        break;
                }
                if (pos > -1)
                {
                    if (pos > lstGebruikers.Items.Count - 1)
                        lstGebruikers.SelectedIndex = lstGebruikers.Items.Count - 1;
                    else if (pos < 0)
                        lstGebruikers.SelectedIndex = 0;
                    else
                        lstGebruikers.SelectedIndex = pos;
                }
            }
        }
        public string Verzacht(string s1)
        {
            StringBuilder s = new StringBuilder();
            s = s.Append(" " + s1.ToLower() + " ");
            string[,] deel = new string[,]
            {   
                {"é","e" },{"è","e" },{"ë","e" },{"ê","e" },
                {"ú","u" },{"ù","u" },{"ü","u" },{"û","u" },
                {"ö","o" },{"ô","o" },{"ó","o" },{"ò","o" },{"õ","o" },
                {"ä","a" },{"â","a" },{"á","a" },{"à","a" },{"ã","a" }, 
                {"ï","i" },{"î","i" },{"í","i" },{"ì","i" },{"ie","i" },
                {"ç","s" },{"ñ","n" }, {"'h","" }, {"'",""},
                {"aux","o"}, {"eau","o" },  {"au","o"}, {"ou","o"}, {"oe","o" }, {"oz ","o " },

                {"ey","i" },  {"ij","i" }, { "ei","i"},
                {"uy","u" }, {"ui","u" }, {"y","i" }, {"j","i" },
                {"ois","wa" }, {"ouis","owi" },

                {"cx", "ks"}, {"x", "ks"},
                {" ch"," k"},{"ck", "k"},{"que","k"},
                {"sch ","s "},

                {" geo"," io"},{"van ","van"}, {"den","de"},
                {" gen"," ien"}, {"vander","vande"}, {"de ","de"},
                {"ne ","n "},  {"ue","e"}, {"rts","rs"},
                { "th", "t"}, { "ae","a"},
                
                {"ch","g"}, {"ce","se"}, {"ci","si"},{"c","k"},
                {"ph","f" },{"gh","g" },
            };

            // vereenvoudig schrijfwijze
            for (int x = 0; x < deel.GetLength(0); x++)
                s = s.Replace(deel[x, 0], deel[x, 1]);

            return Verkort(s.ToString());
        }

        public string Verkort(string s)
        {

            StringBuilder s1 = new StringBuilder();
            s1 = s1.Append(" " + s.ToLower() + " ");
            string[,] deel = new string[,] {{"-","" },{"."," " }, {"'","" }};

            // vereenvoudig schrijfwijze
            for (int x = 0; x < deel.GetLength(0); x++)
                s1 = s1.Replace(deel[x, 0], deel[x, 1]);

            // verwijder dubbele letters
            StringBuilder s2 = new StringBuilder();
            s2 = s2.Append(s1[0]);
            for(int i=1;i<s1.Length;i++)
                if (s1[i] != s2[s2.Length-1])
                    s2 = s2.Append(s1[i]);

            return s2.ToString();
        }
    }
}
