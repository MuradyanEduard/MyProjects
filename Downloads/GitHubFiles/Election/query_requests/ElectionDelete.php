<?php
session_start();
if(isset($_SESSION["Permission"]))
{
    if($_SESSION["Permission"] != 1)
    {
        header("Location: http://localhost/Election/");
        exit;
    }
}else{
    header("Location: http://localhost/Election/");
    exit;
}

    $servername = "localhost";
    $dbname = "test";
    $username = "root";
    $password = "";   


    $pdo = GetConnection("localhost","test","root","");

    try {
        $sql = "DELETE FROM closed WHERE idElection = ".$_GET['id'];
        $pdo->prepare($sql)->execute();

        $sql = "DELETE FROM election WHERE idElection = ".$_GET['id'];
        $pdo->prepare($sql)->execute();
        
        $_SESSION['regInfo'] = "Քվեարկությունը հեռացված է";

    }catch (Exception $e){
        $_SESSION['regInfo'] = $e;
    }


    $conn = null;

    header("Location: http://localhost/Election/MainForm.php");
    exit;
    

function GetConnection($servername, $dbname, $username,$password)
{
    try {
        $con = new PDO('mysql:host='.$servername.';dbname='.$dbname, $username, $password);
    } catch (PDOException $e) {
        print "Error!: " . $e->getMessage() . "<br/>";
        die();
    }

    return $con;
}

?>