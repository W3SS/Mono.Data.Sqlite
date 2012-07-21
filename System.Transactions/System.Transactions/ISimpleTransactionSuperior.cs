//
// ISimpleTransactionSuperior.cs
//
// Author:
//	Atsushi Enomoto  <atsushi@ximian.com>
//
// (C)2005 Novell Inc,
//

namespace System.Transactions
{
    public interface ISimpleTransactionSuperior : ITransactionPromoter
    {
        void Rollback();
    }
}
