<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Get Property - Page</title>
</head>
<body>
<jsp:useBean id="user" class="org.studyeasy.beans.User" scope="page"></jsp:useBean>

First Name: <jsp:getProperty property="firstName" name="user"/><br/>
Last Name : <jsp:getProperty property="lastName" name="user"/>


</body>
</html>