<?php
session_start();    
session_destroy();
header("Location: http://localhost/Election/index.php");
exit;

?>