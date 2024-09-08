<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Member Area</title>
</head>
<body>

<!-- Read Cookie -->
<%
String username = null, sessionId = null;

//It wil give all the available cookies in the available URL.
Cookie[] cookies = request.getCookies();

//getName() -> Used to get the cookie Name.

//Create a Cookie -> Cookie cookie = new Cookie("username", username);
//username  -> Whatever name is given above the same name will be used here.
if(cookies != null){
	for(Cookie cookie : cookies){
		if(cookie.getName().equals("username")){
			username = cookie.getValue();
		}
		if(cookie.getName().equals("JSESSIONID")){
			sessionId = cookie.getValue();
		}
	}
}
	if(sessionId == null || username == null){
		response.sendRedirect("Login.jsp");
	}
%>
Username : <%= username %> <br/>
SessionID : <%= sessionId %>

<h2>Member Area</h2>
<form action="<%= request.getContextPath() %>/MemberAreaController" method="get">
<input type="hidden" name="action" value="destroy">
<input type="submit" value="logout">
</form>
</body>
</html>