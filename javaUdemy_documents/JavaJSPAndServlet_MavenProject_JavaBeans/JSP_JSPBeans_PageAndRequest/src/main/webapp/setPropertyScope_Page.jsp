<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Set Property - Page</title>
</head>
<body>
<jsp:useBean id="user" class="org.studyeasy.beans.User" scope="page"></jsp:useBean>

<jsp:setProperty property="firstName" name="user" value="John"/><br/>
<jsp:setProperty property="lastName" name="user" value="Doe"/>

Values are updated.

<br/>
First Name: <jsp:getProperty property="firstName" name="user"/><br/>
Last Name : <jsp:getProperty property="lastName" name="user"/>

<%
 request.getRequestDispatcher("getPropertyScope_Page.jsp").forward(request, response);
%>
</body>
</html>