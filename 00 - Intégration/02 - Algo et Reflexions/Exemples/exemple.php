<?php

echo "toto\n";
$a = readline("entrer un nombre");
echo $a;

$saisieOk = false;
do
{
    $reponse = readline("entrer un nombre");
    if (is_numeric($reponse))
    {
        var_dump($reponse);
        $valeur = intval($reponse);
        var_dump($valeur);
        $saisieOk = true;
    }
} while (!$saisieOk);
var_dump($valeur);
