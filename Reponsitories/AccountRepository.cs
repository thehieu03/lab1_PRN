using BusinessObjects;
using DataAccessLayer;

namespace Reponsitories
{
    public class AccountRepository : IAccountRepository
    {

        AccountMember IAccountRepository.GetAccountMember(string accountId) => AccountMemberDAO.Instance.getAccountById(accountId);
    }
}
