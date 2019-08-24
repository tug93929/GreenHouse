<?php 
    $dbusername = "userdemo";  
    $dbpassword = "localhost";  
    $server = "localhost"; 
  
    $dbconnect = mysqli_connect($server, $dbusername, $dbpassword);
    $dbselect = mysqli_select_db($dbconnect, "greenhousedemo");
  	
	$temp= $_GET['temp'];
	$hum= $_GET['hum'];
	$light= $_GET['light'];
	$soil= $_GET['soil'];

    $sql = "INSERT INTO greenhousedemo.data (temp,hum,light,soil) VALUES ('$temp', '$hum', '$light', '$soil')";    
 
    mysqli_query($dbconnect, $sql);

?>