<?php
//Email and Password
$Email = $_REQUEST("Email");
$Password = $_REQUEST("Password");


//php only
$Hostname = " ";
$DBName = " ";
$User = " ";
$PasswordP = " ";

mysql_connect($Hostname, $User, $PasswordP) or die("can't connect to DB");
mysql_select_db($DBName) or die ("Can't Connect to DB");

if(!$Email || !$PasswordP){
    echo"empty";
}
else{
    $SQl = "SELECT * FROM Accounts WHERE Email = '" . $Email ."'";
    $Result = @mysql_query($SQl) or die ("DB Error");
    $Total = mysql_num_rows($Result);
    if($Total == 0){
        $insert = "INSERT INTO 'Accounts' ('Email', 'Password') VALUES ('" . $Email . "', MD5('" . $Password . "'))";
        $SQL1 = mysql_query($insert);
        echo"Succes";
    }
    else{
        echo"AlreadyUsed";
    }
}

//close mysql
mysql_close(); 
?>