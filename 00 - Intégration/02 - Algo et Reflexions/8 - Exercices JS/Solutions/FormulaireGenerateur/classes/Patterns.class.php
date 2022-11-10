<?php

class Patterns
{

    /*****************Attributs***************** */

    private static $_table  ;

    /*****************Accesseurs***************** */

    #region
    //////////
    public static function getTable()
    {
        return self::$_table;
    }
    //////////
    #endregion

    /*****************Constructeur***************** */

    #region
    //////////

    /**
     * La fonction magique __construct permet de créer un tableau de regex défini
     */
    public static function init()
    {
        self::$_table = [ 
            "chaineCaractere" =>
            new Regex([
                "name" => "chaineCaractere",
                "pattern" => "^[\p{L}\\\ \-]{2,}$",
                "message" => "Composé uniquement de lettres, espaces et tirés",
            ]),
            "num" =>
            new Regex([
                "name" => "num",
                "pattern" => "^[0|+33]\d((\.| )?\d{2}){4}$",
                "message" => "Composé uniquement de chiffres",
            ]),
            "code" =>
            new Regex([
                "name" => "code",
                "pattern" => "^\d{5}$",
                "message" => "Composé uniquement de chiffres",
            ]),
            "mail" =>
            new Regex([
                "name" => "mail",
                "pattern" => "^\w+([\.-_]?\w+)*@\w+([\.-_]?\w+)*\.\w{2,5}$",
                "message" => "Doit posséder un @ et une extension précédé d'un point",
            ]),
            "mdp" =>
            new Regex([
                "name" => "mdp",
                "pattern" => "(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[\W_]).{8,}",
                "message" => "Doit être composé d'au moins 8 caractères, un caractère spécial, une majuscule, une minuscule, un chiffre",
            ]),
        ];
    }
    //////////
    #endregion

    /*****************Autres Méthodes***************** */

    /**
     * Permet de trouver une regex grâce à une clé renseigné par l'utilisateur
     *
     * @param [string] $name // Nom de la regex
     * @return String
     */
    public static function findRegex($name)
    {
        if(self::getTable()[$name]){
            return self::getTable()[$name]->getPattern();
        }
        else{
            return "";
        }
    }

    /**
     * Permet de trouver le message d'erreur d'un regex grâce à une clé renseigné par l'utilisateur
     *
     * @param [string] $name // Nom de la regex
     * @return void
     */
    public static function findMsgErrorRegex($name)
    {
        if(self::getTable()[$name]){
            return self::getTable()[$name]->getMessage();
        }
        else{
            return "";
        }
    }

}