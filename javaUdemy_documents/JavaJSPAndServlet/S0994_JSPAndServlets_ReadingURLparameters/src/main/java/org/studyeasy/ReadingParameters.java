package org.studyeasy;

import java.io.IOException;
import java.io.PrintWriter;

import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class ReadingParameters
 */
public class ReadingParameters extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ReadingParameters() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		//Whenever we want to get writer, we use (HttpServletResponse) response parameter.
		response.getWriter().print("Hello ");
		
		
		//Whenever we want to fetch URL parameter details, we use HttpServletRequest request
		//parameter.
		//Single parameter
		response.getWriter().print(request.getParameter("val1"));
		
		//Whenever we want to fetch URL parameter details, we use HttpServletRequest request
		//parameter.
		//Multiple parameter
		PrintWriter out = response.getWriter();
		out.println("Value of val1 : "+request.getParameter("val1"));
		out.println("Value of val2 : "+request.getParameter("val2"));
		
		//Whenever we want to fetch URL parameter details, we use HttpServletRequest request
		//parameter.
		//Multiple parameter
		//Add multiple lines or tag
		PrintWriter out2 = response.getWriter();
		out2.println("<br/>Value of val1 : "+request.getParameter("val1"));
		out2.println("Value of val2 : "+request.getParameter("val2"));
	}

}
