<jsp:include page="include/header.jsp"></jsp:include>

<%@ page import="java.util.List" %>
<%@ page import="org.studyeasy.entity.User" %>

<h1>List Users</h1>

<table border="1">
	<thead>
		<tr>
			<th>User Id</th>
			<th>User Name</th>
			<th>Email</th>
			<th>Operation (s)</th>
		</tr>
	</thead>

<%
	List<User> listusers = (List)request.getAttribute("listusers");
	for(User _user : listusers){
		out.print("<tr>");
		out.print("<td>"+_user.getUser_id()+"</td>");
		out.print("<td>"+_user.getUsername()+"</td>");
		out.print("<td>"+_user.getEmail()+"</td>");
		out.print("<td> <a href="+request.getContextPath()+"/site?page=updateuser&user_id="+_user.getUser_id()+
				"&username="+_user.getUsername()+"&email="+_user.getEmail()+">Update</a></td>");
		out.print("<tr>");
	}
%>
</table>

<jsp:include page="include/footer.jsp"></jsp:include>