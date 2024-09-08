using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace AspNetMvcPdfSyncfusion.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
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
		public ActionResult CreatePDFDocument()
		{
			//Step 1 : Creating Instance Of PdfDocument
			PdfDocument pdfDocument = new PdfDocument();

			//Step 2 : Add a page to the document.
			PdfPage page = pdfDocument.Pages.Add();

			//Step 3 : Create PDF graphics for the page
			PdfGraphics pdfgraphics = page.Graphics;

			//Step 4 : Set the standard font.
			PdfFont pdfFont = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

			//Step 5 : Draw the text
			pdfgraphics.DrawString("Hello Manoj", pdfFont, PdfBrushes.Black, new PointF(0, 0));

			//Step 6 : Open the document in browser after saving it
			pdfDocument.Save("Test1.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
			return View();
		}
	}
}