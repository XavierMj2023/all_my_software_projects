<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>JSP Comments</title>
</head>
<body>
<strong>Hello JSP</strong>
<br/>
<%
	int x = 25;
    //out.println("The value of x: ");
    out.println(x);
%>


<br/>

<%= x %>
<%
	int x2 = 26;
    /*out.println("The value of x: ");
    out.println(x2);*/
%>
<br/>
<%= x2 %>
<!-- 
	<%--
		int x3 = 36;
	    out.println("The value of x: ");
	    out.println(x2);
	    response.sendRedirect("http://studyeasy.org");
	--%>
 -->

</body>
</html>