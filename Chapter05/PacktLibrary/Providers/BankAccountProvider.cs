using System.Collections.Generic;

namespace Packt.Shared.Providers
{
    public class BankAccountProvider
    {
        public static IEnumerable<BankAccount> GetBankAccounts()
        {
            return new List<BankAccount>()
            {
                new BankAccount()
                { AccountName = "Mrs. Jones", Balance = 2400 },
                new BankAccount() { AccountName = "Ms. Garrier", Balance = 98 }
            };
        }
    }
}
