with sales as (
    -- Select order number, product code, and product line from the joined tables
    select t1.orderNumber,t1.customerNumber, productCode, quantityOrdered, priceEach, priceEach * quantityOrdered as sales_value,
    creditLimit
    from orders t1
    inner join orderdetails t2
    on t1.orderNumber = t2.orderNumber
    inner join customers t3
    on t1.customerNumber = t3.customerNumber
)
-- Select everything from the CTE 'prod_sales'
select ordernumber, customernumber, 
case when creditLimit < 75000 then 'a: Less than $75k'
when creditLimit between 75000 and 100000 then 'b: $75k to $100k'
when creditLimit between 100000 and 150000 then 'c: $100k to $150k'
when creditLimit > 150000 then 'd: over $150k'
else 'Other'
end as creditlimit_group, 
sum(sales_value) as sales_value
from sales
group by ordernumber, customernumber, creditlimit_group;

SELECT VERSION();