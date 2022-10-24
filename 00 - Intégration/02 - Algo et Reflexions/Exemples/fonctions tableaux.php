<?php

//$tab = CreerTableau(2,3);
$tab=[[1,2,3],[4,5,6]];
//print_r($tab);
AfficheTableau($tab);
//AfficherGrille($tab);

function SaisieEntier($invite)
{
    $saisieOk = false;
    do
    {
        $reponse = readline($invite);
        if (is_numeric($reponse))
        {
            $valeur = intval($reponse);
            $saisieOk = true;
        }
    } while (!$saisieOk);
    return $valeur;
}


function CreerTableau($x, $y){
    for($i=0; $i<$x;$i++){
        for($j=0; $j<$y;$j++){
            $lignes[$i][$j]= SaisieEntier("Veuillez entrer un chiffre : ");
        }
    }
    return $lignes;
}


function AfficheTableau($tablo)
{
    $tiret="----"; //  pour prendre en compte le numero de ligne
    $nomCol ="    ";
    $nbCol = count($tablo[0]);
    // on prepare les lignes de tirets + la ligne de nom de colonne
    for ($i=0; $i < $nbCol; $i++) { 
        $tiret .= "----";
        $nomCol .= "| " . mb_chr(65+$i)." "; // on se sert du code ascii correspondant à la colonne
    }
    $tiret .="\n"; // on ajoute le retour à la ligne après les tirets

    echo $nomCol."|\n".$tiret; // on met l'entete de colonne + un | pour finir la ligne
    foreach ($tablo as $numLigne=>$ligne) {
        // traitement ligne
        echo "| ".($numLigne+1) ." "; // gestion du numéro de ligne
        foreach ($ligne as  $case) {
            // traitement de chaque case
           echo "| " .$case." ";// on ajoute à gauche de chaque valeur un |
        }
        echo "|\n". $tiret;
    }
}
