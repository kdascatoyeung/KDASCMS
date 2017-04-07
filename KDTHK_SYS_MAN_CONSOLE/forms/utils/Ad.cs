using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.DirectoryServices;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.forms.utils
{
    class Ad
    {
        public static string getUsernameByUserId(string userId)
        {
            string domain = IPGlobalProperties.GetIPGlobalProperties().DomainName;
            Debug.WriteLine(domain);
            DirectoryEntry domainEntry = new DirectoryEntry("LDAP://" + domain);

            DirectorySearcher searcher = new DirectorySearcher(domainEntry);
            searcher.Filter = "(&(objectClass=user)(sAMAccountName=" + userId + "))";
            SearchResult result = searcher.FindOne();
            DirectoryEntry entry = result.GetDirectoryEntry();

            return entry.Properties["displayName"].Value.ToString();
        }
    }
}
