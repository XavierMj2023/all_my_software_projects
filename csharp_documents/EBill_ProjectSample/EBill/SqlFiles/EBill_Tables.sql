create procedure spt_saveEBillDetails
@CustomerName varchar(255),
@MobileNumber varchar(255),
@Address varchar(255),
@TotalAmt int,
@Id int output
as
begin
insert into tbl_BillDetails(CustomerName,MobileNumber,Address,TotalAmt)
values(@CustomerName,@MobileNumber,@Address,@TotalAmt);

select @Id = SCOPE_IDENTITY();
end


create procedure spt_getAllEBillDetails
as
begin
select * from tbl_BillDetails;
end

create procedure spt_getEBillDetails
@Id int
as
begin
select d.Id as 'BillId', d.CustomerName,d.MobileNumber,d.Address,d.TotalAmt,
i.Id as ItemId,i.ProductName,i.Price,i.Quantity
from tbl_BillDetails d inner join tbl_BillItems i
on d.Id = i.BillId
where d.Id = @Id;
end