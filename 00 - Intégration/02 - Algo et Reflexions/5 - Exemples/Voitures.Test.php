<?php
function ChargerClasse($classe)
{
    require $classe.".Class.php";
}
spl_autoload_register("ChargerClasse");

$v1 = new Voitures(["couleur"=>"noir","motorisation"=>"diesel","marque"=>"jeep","modele"=>"renegate","nbKilometres"=>20]);
var_dump($v1);
echo $v1->__toString()."\n";
$v1->rouler(200);
echo $v1;