<?php

class Spheres extends Cercles
{

    /*****************Attributs***************** */
    

    /*****************Accesseurs***************** */

    
    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
       // parent::__construct($options);   Appel optionnel
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
        return parent::__toString()." - Volume de la sphère : ".$this->volume();
    }

    /**
     * Retourne le volume de la sphere
     *
     * @param Void
     * @return Float
     */
    public function volume()
    {       // 4/3 PI R3
        return 4/3*pi()*pow($this->getRayon(),3);
    }
}