with cte_sales as
(
select 
orderDate,
customerName,
t1.customerNumber,
t1.orderNumber,
productCode,
creditLimit,
quantityOrdered * priceEach as sales_value
from orders t1
inner join orderdetails t2
on t1.orderNumber = t2.orderNumber
inner join customers t3
on t1.customerNumber = t3.customerNumber
),
running_total_sales_cte as 
(
select orderDate,
orderNumber,
customerNumber,
customerName,
creditLimit,
sum(sales_value) as sales_value
from cte_Sales 
group by 
orderDate,
orderNumber,
customerNumber,
customerName,
creditLimit
)

select *,
sum(sales_value) over(partition by customerNumber order by orderDate) as running_total_sales
from running_total_sales_cte