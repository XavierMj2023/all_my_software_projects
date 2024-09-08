using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using EBill.Models;

namespace EBill.Repository
{
	public class Data : IData
	{
		public string ConnectionString {  get; set; }
		public Data() 
		{ 
			ConnectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
		}
		public void SaveBillDetails(BillDetail details)
		{
			SqlConnection con = new SqlConnection(ConnectionString);
			try
			{
				details.TotalAmt = details.Items.Sum(i => i.Price * i.Quantity);
				con.Open();
				SqlCommand cmd = new SqlCommand("spt_saveEBillDetails", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@CustomerName",details.CustomerName);
				cmd.Parameters.AddWithValue("@MobileNumber",details.MobileNumber);
				cmd.Parameters.AddWithValue("@Address",details.Address);
				cmd.Parameters.AddWithValue("@TotalAmt",details.TotalAmt);

				SqlParameter outputPara = new SqlParameter();
				outputPara.DbType = DbType.Int32;
				//Mistake Input instaed of output
				outputPara.Direction = ParameterDirection.Output;
				outputPara.ParameterName = "@Id";
				cmd.Parameters.Add(outputPara);
				cmd.ExecuteNonQuery();
				int id = int.Parse(outputPara.Value.ToString());	
				if(details.Items.Count>0)
				{
					SaveBillItems(details.Items,con ,id);
				}
			}
			catch (Exception ex) 
			{
				throw;
			}
			finally
			{
				con.Close();
			}
		}
		public void SaveBillItems(List<Items> items, SqlConnection con, int id)
		{
			try
			{
				//Wrong
				//string qry = "insert into values tbl_BillItems(ProductName,Price,Quantity) values";

				//Right
				string qry = "insert into  tbl_BillItems(ProductName,Price,Quantity,BillId) values";
				foreach(var item in items) 
				{
					qry += String.Format("('{0}',{1},{2},{3}),",item.ProductName,item.Price,item.Quantity,id);
				}
				qry = qry.Remove(qry.Length-1);
				SqlCommand cmd = new SqlCommand(qry, con);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex) 
			{
				throw;
			}
		}
		public List<BillDetail> GetAllDetails()
		{
			List<BillDetail> list = new List<BillDetail>();
			BillDetail detail;
			//Items item;
			SqlConnection con = new SqlConnection(ConnectionString);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("spt_getAllEBillDetails", con);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) 
				{
					detail = new BillDetail();
					detail.Id = int.Parse(reader["Id"].ToString());
					detail.CustomerName = reader["CustomerName"].ToString();
					detail.MobileNumber = reader["MobileNumber"].ToString();
					detail.Address = reader["Address"].ToString();
					detail.TotalAmt = int.Parse(reader["TotalAmt"].ToString());
					list.Add(detail);
				}
			}
			catch (Exception ex) 
			{
				throw;
			}
			finally
			{
				con.Close() ;
			}
			return list;
		}
		public BillDetail GetDetail(int Id)
		{
			SqlConnection con = new SqlConnection(ConnectionString);
			BillDetail detail = new BillDetail();
			Items items;
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("spt_getEBillDetails", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Id", Id);
				SqlDataReader reader = cmd.ExecuteReader();
				if(reader.HasRows) 
				{
					
				}
				while (reader.Read()) 
				{
					detail.Id = int.Parse(reader["BillId"].ToString());
					detail.CustomerName = reader["CustomerName"].ToString();
					detail.MobileNumber = reader["MobileNumber"].ToString();
					detail.Address = reader["Address"].ToString();
					detail.TotalAmt = int.Parse(reader["TotalAmt"].ToString());
					items = new Items();
					items.Id = int.Parse(reader["ItemId"].ToString());
					items.ProductName = reader["ProductName"].ToString();
					items.Price = int.Parse(reader["Price"].ToString());
					items.Quantity = int.Parse(reader["Quantity"].ToString());
					detail.Items.Add(items);
				}
			}
			catch(Exception) 
			{ 
				throw;
			}
			finally
			{
				con.Close();
			}
			return detail;
		}
	}
}