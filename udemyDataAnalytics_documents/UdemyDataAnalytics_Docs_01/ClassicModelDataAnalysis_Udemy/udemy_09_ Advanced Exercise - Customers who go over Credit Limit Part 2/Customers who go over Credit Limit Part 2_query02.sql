select *, sum(amount) over(partition by customerNumber order by paymentDate) as running_total_payments
from payments
