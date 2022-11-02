<?php

/**
 * calcul de factorielle
 *
 * @param [type] $nb nombre dont on extrait la factorielle
 * @param string $aff  gestion de l'affichage, paramètre optionnel
 * @return int valeur de la factorielle
 */
function facto($nb,$aff="=")
{
    //echo $aff."\n";
    if ($nb==1) 
    {
        echo "1".$aff;
        return 1;
    }
    return facto($nb-1,"*".strval($nb).$aff)*$nb;
}
echo facto(5);