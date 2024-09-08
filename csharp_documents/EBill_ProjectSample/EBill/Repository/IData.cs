using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBill.Models;

namespace EBill.Repository
{
    interface IData
	{
		void SaveBillDetails(BillDetail details);
		void SaveBillItems(List<Items> items,SqlConnection con,int id);
		List<BillDetail> GetAllDetails();
		BillDetail GetDetail(int id);
	}
}
