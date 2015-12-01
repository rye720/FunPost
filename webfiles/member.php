<?php 
session_start();
if(!isset($_SESSION["sess_user"])){
	header("location:index.html");
} else {
?>
<!doctype html>
<html>
<head>
<title>Welcome</title>
</head>
<body>
<h2>Welcome, <?=$_SESSION['sess_user'];?>! <a href="logout.php">Logout</a></h2>
<p>
test page to make sure it works
</p>
</body>
</html>
<?php
}
?>


