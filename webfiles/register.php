<!doctype html>
<html>
<head>
<title>Register</title>

<link rel="stylesheet" href="../bs/css/bootstrap.min.css" integrity="sha512-dTfge/zgoMYpP7QbHy4gWMEGsbsdZeCXz7irItjcC3sPUFtf0kuFbDz/ixG7ArTxmDjLXDmezHubeNikyKGVyQ==" crossorigin="anonymous">

<!-- Optional theme -->
<link rel="stylesheet" href="../bs/css/bootstrap-theme.min.css" integrity="sha384-aUGj/X2zp5rLCbBxumKTCw2Z50WgIr1vs/PFN4praOTvYXWlVyh2UtNUU0KAUhAX" crossorigin="anonymous">

</head>
<body>

<p><a href="register.php">Register</a> | <a href="index.html">Login</a></p>




<h3>Registration Form</h3>
<div class="container">
<div class="row">
<div class="col-md-7">

<form action="" method="POST">
<div class="form-group">
<label for="username">User name</label>
 <input class="form-control" type="text" name="username"><br />
 </div>
 <div class="form-group">
 <label for="password">password</label>
 <input class="form-control" type="password" name="password">
 </div>	
<input type="submit" value="Register" name="submit" />

</form>

</div>
</div>
</div>
<?php
if(isset($_POST["submit"])){

if(!empty($_POST['username']) && !empty($_POST['password'])) {
	$user=$_POST['username'];
	$pass=$_POST['password'];

$dbc = mysqli_connect('localhost', 'forfamuc_damosco', 'tJc3Fb0+nsF#', 'forfamuc_socialsite')
or die('error conecting to server');

	
	$sql="INSERT INTO login(username,password) VALUES('$user','$pass')";

	$result=mysqli_query($dbc,$sql)or 
	die('unable to create account, please try again later');




	
}
}

?>
<script src="../../../AppData/Local/Temp/Temp1_user-registration.zip/bs/js/jquery-1.11.3.min.js"></script>
<!-- Latest compiled and minified JavaScript -->
<script src="../../../AppData/Local/Temp/Temp1_user-registration.zip/bs/js/bootstrap.min.js" integrity="sha512-K1qjQ+NcF2TYO/eI3M6v8EiNYZfA95pQumfvcVrTHtwQVDG+aHRqLi/ETn2uB+1JqwYqVG3LIvdm9lj6imS/pQ==" crossorigin="anonymous"></script>

</body>
</html>