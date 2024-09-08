<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Java Forms with Java Beans</title>
</head>
<body>
Submit Form <br/>
<jsp:useBean id="user" class="org.studyeasy.beans.User" scope="session"></jsp:useBean>

<form action="formValue.jsp">
	First Name : <input type="text" name="firstName" value='<jsp:getProperty property="firstName" name="user"/>'>
	Last Name : <input type="text" name="lastName" value='<jsp:getProperty property="lastName" name="user"/>'>
	<input type="submit" value="submit">
</form>

</body>
</html>