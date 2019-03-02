<?php
include('tamernasser.com/connection.php');

$sql = "select Username,Password";
$result = mysqli_query($connect, $sql);

if(mysqli_num_row($result)>0){
	while($row = mysqli_fetch_assoc($result)){
		echo "Username:".$row['Username']."|Password:".$row['Password'].";";
	}
}
?>