/*
-- This CTE (Common Table Expression) defines a temporary result set named 'prod_sales'
with prod_sales as (
    -- Select order number, product code, and product line from the joined tables
    select t1.orderNumber, t1.productCode, t2.productLine
    from orderdetails t1
    inner join products t2
    on t1.productCode = t2.productCode
)
-- Select everything from the CTE 'prod_sales'
select *
from prod_sales;
*/

-- Get the MySQL version
SELECT VERSION();

-- Create a derived table (subquery) named 'prod_sales'
select *
from (
    -- Select order number, product code, and product line from the joined tables
    select t1.orderNumber, t1.productCode, t2.productLine
    from orderdetails t1
    inner join products t2
    on t1.productCode = t2.productCode
) as prod_sales;

-- Perform a self-join on 'prod_sales' with a left join
-- The join condition matches records where order numbers are the same but product lines are different
select *
from prod_sales t1
left join prod_sales t2
on t1.ordernumber = t2.ordernumber 
and t1.productline <> t2.productline;
