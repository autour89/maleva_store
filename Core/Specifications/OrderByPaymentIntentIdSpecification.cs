using Core.Entities.OrderAggregate;

namespace Core.Specifications;

public class OrderByPaymentIntentIdSpecification(string paymentIntentId)
    : BaseSpecification<Order>(o => o.PaymentIntentId == paymentIntentId) { }
