using BusinessObjects;

namespace DataAccessLayer
{
    public class AccountMemberDAO : SingletonBase<AccountMemberDAO>
    {
        public AccountMember getAccountById(string accountId)
        {
            AccountMember accountMember = new AccountMember();
            if (accountId.Equals("thehieu"))
            {
                accountMember.MemberId = accountId;
                accountMember.MemberPassword = "123";
                accountMember.MemberRole = 1;
                return accountMember;
            }
            return null;
        }

    }
}
