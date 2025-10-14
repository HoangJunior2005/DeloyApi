using EV_RENTAL_SYSTEM.Data;
using EV_RENTAL_SYSTEM.Models;
using EV_RENTAL_SYSTEM.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EV_RENTAL_SYSTEM.Repositories.Implementations
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Payment>> GetPaymentsByUserIdAsync(int userId)
        {
            return await _context.Payments
                .Where(p => p.Contract.Order.UserId == userId)
                .Include(p => p.Contract)
                .ThenInclude(c => c.Order)
                .ThenInclude(o => o.User)
                .OrderByDescending(p => p.PaymentDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<Payment>> GetPaymentsByContractIdAsync(int contractId)
        {
            return await _context.Payments
                .Where(p => p.ContractId == contractId)
                .Include(p => p.Contract)
                .ThenInclude(c => c.Order)
                .OrderByDescending(p => p.PaymentDate)
                .ToListAsync();
        }

        public async Task<Payment?> GetPaymentByTransactionIdAsync(string transactionId)
        {
            return await _context.Payments
                .Include(p => p.Transactions)
                .ThenInclude(t => t.User)
                .FirstOrDefaultAsync(p => p.Transactions.Any(t => t.TransactionId.ToString() == transactionId));
        }

        public async Task<IEnumerable<Payment>> GetPaymentsWithPaginationAsync(int pageNumber, int pageSize)
        {
            return await _context.Payments
                .Include(p => p.Contract)
                .ThenInclude(c => c.Order)
                .ThenInclude(o => o.User)
                .OrderByDescending(p => p.PaymentDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTotalPaymentCountAsync()
        {
            return await _context.Payments.CountAsync();
        }
    }
}

