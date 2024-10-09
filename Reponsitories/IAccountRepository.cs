using BusinessObjects;

namespace Reponsitories
{
    public interface IAccountRepository
    {
        AccountMember GetAccountMember(string accountId);
    }
}
