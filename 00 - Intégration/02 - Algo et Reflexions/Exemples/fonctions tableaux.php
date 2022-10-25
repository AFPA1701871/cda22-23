<?php

//$tab = CreerTableau(2,3);
$tab = [[1, 2, 3], [4, 5, 6]];
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

function CreerTableau($x, $y)
{
    for ($i = 0; $i < $x; $i++)
    {
        for ($j = 0; $j < $y; $j++)
        {
            $lignes[$i][$j] = SaisieEntier("Veuillez entrer un chiffre : ");
        }
    }
    return $lignes;
}

function AfficheTableau($tablo)
{
    $nblignes = count($tablo);
    $nbCol = count($tablo[0]);
    // on prepare les tirets et les entetes
    $tirets ="+---+";
    $entete = "    ";
    for ($i=0; $i < $nbCol; $i++) { 
       $tirets .= "---+";
       $entete .= "| " . mb_chr($i+65) . " ";
    }
    // ligne entete + tirets
    echo $entete ."|\n".$tirets."\n";
    // traitement du tableau
    for ($i = 0; $i < $nblignes; $i++)
    {
        // traitement d'une ligne
        // debut de ligne
        echo "| " . ($i + 1) . " ";
        for ($j = 0; $j < $nbCol; $j++)
        {
            //traitement d'une colonnne
            echo "| " . $tablo[$i][$j] . " ";
        }
        // fin de ligne
        echo "|\n". $tirets."\n";
    }
}

// function AfficheTableau($tablo)
// {
//     $tiret="----"; //  pour prendre en compte le numero de ligne
//     $nomCol ="    ";
//     $nbCol = count($tablo[0]);
//     // on prepare les lignes de tirets + la ligne de nom de colonne
//     for ($i=0; $i < $nbCol; $i++) {
//         $tiret .= "----";
//         $nomCol .= "| " . mb_chr(65+$i)." "; // on se sert du code ascii correspondant à la colonne
//     }
//     $tiret .="\n"; // on ajoute le retour à la ligne après les tirets

//     echo $nomCol."|\n".$tiret; // on met l'entete de colonne + un | pour finir la ligne
//     foreach ($tablo as $numLigne=>$ligne) {
//         // traitement ligne
//         echo "| ".($numLigne+1) ." "; // gestion du numéro de ligne
//         foreach ($ligne as  $case) {
//             // traitement de chaque case
//            echo "| " .$case." ";// on ajoute à gauche de chaque valeur un |
//         }
//         echo "|\n". $tiret;
//     }
// }
