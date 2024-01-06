<?php
$dbhost= "localhost";
$dbuser= "root";
$dbpass= "";
$dbcorreo= "test";

$coon = mysqli_connect ($dbhost,$dbuser,$dbpass,$dbcorreo);
if (!$coon)
{
    die( "Sin conexion: ".mysqli_connect_error());
}

$correo = $_POST["emailuser_email"];
$pass = $_POST["passworduser_password"];

$query = mysqli_query ($coon,"SELECT * FROM Sesion WHERE Correo = '".$correo."' and Contra ='".$pass."'");
$nr= mysqli_num_rows ($query);

if ($nr ==1){
    
    echo "Bienvenido";
}
else if ($nr==0){
    echo "no existes muerete";
}
?>