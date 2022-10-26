<?php

class Voitures
{

    /*****************Attributs***************** */
    private $_couleur;
    private $_marque;
    private $_modele;
    private $_nbKilometres=0;
    private $_motorisation;

    /*****************Accesseurs***************** */

    public function getCouleur()
    {
        return $this->_couleur;
    }

    public function setCouleur($couleur)
    {
        $this->_couleur = strtoupper( $couleur);
    }

    public function getMarque()
    {
        return $this->_marque;
    }

    public function setMarque($marque)
    {
        $this->_marque = $marque;
    }

    public function getModele()
    {
        return $this->_modele;
    }

    public function setModele($modele)
    {
        $this->_modele = $modele;
    }

    public function getNbKilometres()
    {
        return $this->_nbKilometres;
    }

    public function setNbKilometres($nbKilometres)
    {
        $this->_nbKilometres = $nbKilometres;
    }

    public function getMotorisation()
    {
        return $this->_motorisation;
    }

    public function setMotorisation($motorisation)
    {
        $this->_motorisation = $motorisation;
    }
    
    // public function __construct($coul,$marq,$mod,$nbKm,$motor)
    // {
    //     $this->setCouleur = $coul;
    //     $this->setCouleur ( $coul);
    // }
    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        if (!empty($options)) // empty : renvoi vrai si le tableau est vide
        {
            $this->hydrate($options);
        }
    }
    public function hydrate($data)
    {
        foreach ($data as $key => $value)
        {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
    }

    /*****************Autres Méthodes***************** */
    
    /**
     * Transforme l'objet en chaine de caractères
     *
     * @return String
     */
    public function __toString()
    {
        return "Voiture " . $this->getCouleur()." ". $this->getMarque(). " ".$this->getModele(). " ".$this->getNbKilometres(). " ".$this->getMotorisation();
    }

    /**
     * Renvoi vrai si l'objet en paramètre est égal à l'objet appelant
     *
     * @param [type] $obj
     * @return bool
     */
    public function equalsTo($obj)
    {
        return true;
    }
    /**
     * Compare 2 objets
     * Renvoi 1 si le 1er est >
     *        0 si ils sont égaux
     *        -1 si le 1er est <
     *
     * @param [type] $obj1
     * @param [type] $obj2
     * @return void
     */
    public static function compareTo($obj1, $obj2)
    {
        return 0;
    }

     public function rouler($nbKmRoule)
       {
           $this->setNbKilometres($this->getNbKilometres()+$nbKmRoule);
       }
}