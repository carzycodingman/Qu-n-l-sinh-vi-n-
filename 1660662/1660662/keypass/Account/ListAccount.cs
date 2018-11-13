using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keypass.Account
{
    public class ListAccount
    {
        public List<Account> listAccount;
        public ListAccount()
        {
            listAccount = new List<Account>();
        }
        public ListAccount(List<Account> list)
        {
            listAccount = list;
        }
        public List<Account>  getListAccount()
        {
            if (listAccount == null)
                return null;
            return listAccount;
        }
        public bool addAccount(Account account)
        {
            for (int i = 0; i < listAccount.Count; i++)
                if (listAccount[i].FindAccount(account) == true)
                    return false;
            listAccount.Add(account);
            return true;
        }

        public void removeAccount(Account account)
        {
            for (int i = 0; i < listAccount.Count; i++)
                if (listAccount[i].FindAccount(account) == true)
                {
                    listAccount.RemoveAt(i);
                    return;
                }
        }
    }
}
