<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Get Property - Request</title>
</head>
<body>
<jsp:useBean id="user" class="org.studyeasy.beans.User" scope="request"></jsp:useBean>

Get property Page<br/>

First Name: <jsp:getProperty property="firstName" name="user"/><br/>
Last Name : <jsp:getProperty property="lastName" name="user"/>


</body>
</html>