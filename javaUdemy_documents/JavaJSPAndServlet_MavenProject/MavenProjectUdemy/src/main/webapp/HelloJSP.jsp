<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Import Class file in Java</title>
<%@ page import="org.studyeasy.HelloClass,java.util.Date" %>
</head>
<body>
<%= new HelloClass().demo() %>

<%  out.print(new Date()); %>
</body>
</html>