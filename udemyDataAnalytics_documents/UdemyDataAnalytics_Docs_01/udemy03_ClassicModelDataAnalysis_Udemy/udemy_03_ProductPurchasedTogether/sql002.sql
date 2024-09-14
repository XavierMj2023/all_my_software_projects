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

-- Create a derived table (subquery) and perform a self-join
select t1.ordernumber, t1.product_one, t2.product_two
from (
    -- First instance of the derived table (t1) with aliased product line
    select distinct t1.orderNumber, t2.productLine as product_one
    from orderdetails t1
    inner join products t2
    on t1.productCode = t2.productCode
) as t1
left join (
    -- Second instance of the derived table (t2) with aliased product line
    select distinct t1.orderNumber, t2.productLine as product_two
    from orderdetails t1
    inner join products t2
    on t1.productCode = t2.productCode
) as t2
on t1.ordernumber = t2.ordernumber 
and t1.product_one <> t2.product_two
LIMIT 0, 2000;
