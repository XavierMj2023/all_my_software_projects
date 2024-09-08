using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using AspNetMvcPdfISharp.DataModelFolder;
using AspNetMvcPdfISharp.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace AspNetMvcPdfISharp.Controllers
{
	public class HomeController : Controller
	{
		private readonly DataModel _context = new DataModel();
		public ActionResult Index()
		{
			List<Employees> employees = _context.Employees.ToList<Employees>();
			return View(employees);
		}
		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}
		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public FileResult CreatePdf()
		{
			//MemoryStream doesn’t interact with the hard disk; instead, it works entirely within the
			//application's memory.
			MemoryStream ms = new MemoryStream();

			//DateTime
			DateTime dt = DateTime.Now;

			//Defines the file name for the PDF using the current date and time.
			string pdfFileName = $"SamplePdf{dt:yyyyMMdd}.pdf";

			//Document Details
			Document doc = new Document(PageSize.A4,10f,10f,10f,0f);

			//Gets a PdfWriter instance and links it to the MemoryStream without closing the stream.
			PdfWriter.GetInstance(doc,ms).CloseStream = false;

			//Opens the document and creates a PdfPTable with 5 columns.
			doc.Open();

			PdfPTable pTable = new PdfPTable(5);

			//Setting Headers -define the widths of the columns in a PDF table
			float[] headers = { 50,24,45,35,50};

			//Settings for Table
			pTable.SetWidths(headers);
			pTable.WidthPercentage = 100;
			pTable.HeaderRows = 1;

			doc.Add(AddContentToPdf(pTable));

			doc.Close();

			return File(ms, "application/pdf", pdfFileName);

		}
		public IElement AddContentToPdf(PdfPTable tableLayout)
		{
			List<Employees> employees = _context.Employees.ToList<Employees>();

			// Add Title to the PDF file at the top
			PdfPCell titleCell = new PdfPCell(new Phrase("Creating Pdf using iTextSharp", FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLD, BaseColor.BLACK)))
			{
				Colspan = 5,
				Border = 0,
				PaddingBottom = 5,
				HorizontalAlignment = Element.ALIGN_CENTER
			};
			tableLayout.AddCell(titleCell);

			// Add Table headers
			AddCellToHeader(tableLayout, "EmployeeId");
			AddCellToHeader(tableLayout, "Name");
			AddCellToHeader(tableLayout, "Gender");
			AddCellToHeader(tableLayout, "City");
			AddCellToHeader(tableLayout, "Hire Date");

			// Add body
			foreach (var emp in employees)
			{
				AddCellToBody(tableLayout, emp.EmployeeId.ToString());
				AddCellToBody(tableLayout, emp.Name);
				AddCellToBody(tableLayout, emp.Gender);
				AddCellToBody(tableLayout, emp.City);
				AddCellToBody(tableLayout, emp.Hire_Date.ToString());
			}
			return tableLayout;
		}
		public void AddCellToBody(PdfPTable tableLayout, string cellText)
		{
			PdfPCell cell = new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK)))
			{
				HorizontalAlignment = Element.ALIGN_LEFT,
				Padding = 5,
				BackgroundColor = new BaseColor(255, 255, 255)
			};
			tableLayout.AddCell(cell);
		}
		public void AddCellToHeader(PdfPTable tableLayout, string cellText)
		{
			PdfPCell cell = new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLD, BaseColor.YELLOW)))
			{
				HorizontalAlignment = Element.ALIGN_LEFT,
				Padding = 5,
				BackgroundColor = new BaseColor(128, 0, 0)
			};
			tableLayout.AddCell(cell);
		}
	}
}