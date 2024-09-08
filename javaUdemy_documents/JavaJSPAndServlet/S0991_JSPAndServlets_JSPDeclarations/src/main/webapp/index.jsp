<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>JSP Declarations</title>
</head>
<body>
<strong>Hello JSP</strong>

<br/>

<%!int x = 10; %>
<%= x %>

<br/>

<%! public int x2 = 12; %>
<%= x2 %>

<br/>

<%!
	String message(){
		return "studyeasy";
	}
%>
<%= message() %>
</body>
</html>