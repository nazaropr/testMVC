using WebApplication1.Models;
using WebApplication1.Servuces.Infrastructures;

namespace WebApplication1.Servuces.Repositories
{
    public class TransactionRepository : ITransaction
    {
        private readonly 
        void ITransaction.Count()
        {
            throw new NotImplementedException();
        }

        void ITransaction.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Transaction ITransaction.GetTransaction(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Transaction> ITransaction.GetTransactions()
        {
            throw new NotImplementedException();
        }

        void ITransaction.Insert(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        void ITransaction.Update(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
