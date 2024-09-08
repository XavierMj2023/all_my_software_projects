<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Include Files</title>
</head>
<body>
<h2>Files</h2>
<hr/>
<%@ include file="file1.txt" %><!-- Static Include -->
<br/>
<jsp:include page="file2.txt"/><!-- Dynamic Include -->
</body>
</html>