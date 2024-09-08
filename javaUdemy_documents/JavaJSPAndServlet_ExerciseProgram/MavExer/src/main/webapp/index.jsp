<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>main page</title>
</head>
<body>
it's home<br/>
<a href="<%=request.getContextPath() %>/Demo?page=login">Login</a><br/>
<a href="<%=request.getContextPath() %>/Demo?page=signup">SignUp</a><br/>
<a href="<%=request.getContextPath() %>/Demo?page=about">About</a><br/>
</body>
</html>