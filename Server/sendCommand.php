<?php
$servername = "Your_Server_IP";
$username = "DB_Username";
$password = "^ Password";
$dbname = "You Database name";
//$ID3=$_POST['addID'];
$CMD3=$_POST['addCMD'];
$conn = new mysqli($servername, $username, $password, $dbname);

    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    }
    
    

$sql = "INSERT INTO cmds (CMD) VALUES ('".$CMD3."')";

if ($conn->query($sql) === TRUE) {
    echo "New record created successfully";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>