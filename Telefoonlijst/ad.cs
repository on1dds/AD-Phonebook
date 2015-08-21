using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Telefoonlijst
{
    
    public class User
    {
        public string Account { get; set; }
        public string Email { get; set; }
        public string Usergroup { get; set; }

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Naam
        {
            get { return Voornaam + " " + Achternaam; }
            set { Naam = value; }
            
        }

        public string DisplayName { get; set; }
        public string Functie { get; set; }
        public string Beschrijving { get; set; }
        public string Diensthoofd { get; set; }

        public string Bedrijf { get; set; }
        public string Afdeling { get; set; }
        public string Dienst { get; set; }

        public string TelefoonWerk { get; set; }
        public string TelefoonThuis { get; set; }
        public string Mobiel { get; set; }
        public string Fax { get; set; }
        public string Info { get; set; }
        public string Geslacht { get; set; }

        public string Details 
        {
            get 
            {
                return Dienst + " " + Functie + " " + TelefoonWerk + " " + Mobiel + " " + Fax + " " + Geslacht;
            }
           
        }

        public string Listview
        {
            get
            {
                if(Functie == "")
                    return DisplayName;
                else
                    return DisplayName + ", " + Functie.ToLower();
            }
        }

        public override string ToString()
        {
            return Voornaam + " " + Achternaam;
        }

    }

    static public class ad
    {
        static public List<User> GetAllUsers()
        {
            List<User> ADusers = new List<User>();

            StreamReader sr = new StreamReader("tellijst.ini");
            string input = null;
            while((input = sr.ReadLine())!=null)
            {
                ADusers.AddRange(GetUsers(input));
            }
            sr.Close();
            return ADusers;
            
        }
        static public List<User> GetUsers(string DomainPath)
        {
            List<User> lstADUsers = new List<User>();
            try
            {
                DirectoryEntry searchRoot = new DirectoryEntry(DomainPath);
                DirectorySearcher search = new DirectorySearcher(searchRoot);
                search.Filter = "(&(objectClass=user)(objectCategory=person))";

                // mailinfo
                search.PropertiesToLoad.Add("samaccountname");
                search.PropertiesToLoad.Add("mail");
                search.PropertiesToLoad.Add("usergroup");
                search.PropertiesToLoad.Add("displayname");
                // search.PropertiesToLoad.Add("mailNickname");

                // gebruikersinfo
                //search.PropertiesToLoad.Add("givenName");                   // voornaam
                //search.PropertiesToLoad.Add("SN");                          // achternaam

                search.PropertiesToLoad.Add("title");                       // functie binnen bedrijf
                search.PropertiesToLoad.Add("description");                 // beschrijving gebruiker
                //search.PropertiesToLoad.Add("manager");                     // LDAP van diensthoofd
                // dienstinfo
                //search.PropertiesToLoad.Add("company");                     // bedrijf
                //search.PropertiesToLoad.Add("department");                  // afdeling
                search.PropertiesToLoad.Add("physicalDeliveryOfficeName");      // dienst
                search.PropertiesToLoad.Add("extensionAttribute1");             // geslacht

                // telefooninfo
                search.PropertiesToLoad.Add("telephoneNumber");             // telefoon werk
                //search.PropertiesToLoad.Add("homePhone");                   // telefoon werk
                search.PropertiesToLoad.Add("mobile");                      // gsm nummer
                search.PropertiesToLoad.Add("facsimileTelephoneNumber");    // fax
                search.PropertiesToLoad.Add("info");                        // telefoon opmerking

                SearchResult result;
                SearchResultCollection resultCol = search.FindAll();
                if (resultCol != null)
                {
                    for (int counter = 0; counter < resultCol.Count; counter++)
                    {
                        string UserNameEmailString = string.Empty;
                        result = resultCol[counter];
                        if (result.Properties.Contains("displayname") &&
                            result.Properties.Contains("telephoneNumber") || result.Properties.Contains("mobile"))
                        {
                            User u = new User();

                            u.DisplayName = (String)result.Properties["displayname"][0];

                            if (result.Properties.Contains("samaccountname"))
                                u.Account = (String)result.Properties["samaccountname"][0];
                            else
                                u.Account = "";

                            if (result.Properties.Contains("mail"))
                                u.Email = (String)result.Properties["mail"][0];
                            else
                                u.Email = "";

                            if (result.Properties.Contains("extensionAttribute1"))
                                u.Geslacht = (String)result.Properties["extensionAttribute1"][0];
                            else
                                u.Geslacht = "";


                            if (result.Properties.Contains("physicalDeliveryOfficeName"))
                                u.Dienst = (String)result.Properties["physicalDeliveryOfficeName"][0];
                            else
                                u.Dienst = "";

                            if (result.Properties.Contains("mobile"))
                                u.Mobiel = (String)result.Properties["mobile"][0];
                            else
                                u.Mobiel = "";

                            if (result.Properties.Contains("description"))
                                u.Beschrijving = (String)result.Properties["description"][0];
                            else
                                u.Beschrijving = "";

                            if (result.Properties.Contains("info"))
                                u.Info = (String)result.Properties["info"][0];
                            else
                                u.Info = "";

                            if (result.Properties.Contains("facsimileTelephoneNumber"))
                                u.Fax = (String)result.Properties["facsimileTelephoneNumber"][0];
                            else
                                u.Fax = "";

                            if (result.Properties.Contains("title"))
                                u.Functie = (String)result.Properties["title"][0];
                            else
                                u.Functie = "";

                            // u.Usergroup = (String)result.Properties["usergroup"][0];
                            //u.Voornaam = (String)result.Properties["givenname"][0];
                            //u.Achternaam = (String)result.Properties["SN"][0];
                            //u.Functie = (String)result.Properties["title"][0];
                            //u.Diensthoofd = (String)result.Properties["Manager"][0];
                            //u.Bedrijf = (String)result.Properties["company"][0];

                            if (result.Properties.Contains("telephoneNumber"))
                                u.TelefoonWerk = (String)result.Properties["telephoneNumber"][0];
                            else
                                u.TelefoonWerk = "";
                            //u.TelefoonThuis = (String)result.Properties["homePhone"][0];

                            lstADUsers.Add(u);
                        }
                    }
                }
                return lstADUsers;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
