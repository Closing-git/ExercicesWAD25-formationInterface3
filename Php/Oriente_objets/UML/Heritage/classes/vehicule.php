<?php

abstract class Vehicule {
    protected string $modele;
    protected int $vitesse;
    protected int $nbPassagers;

    public function __construct(string $modele, int $vitesse, int $nbPassagers) {
        $this->modele = $modele;
        $this->vitesse = $vitesse;
        $this->nbPassagers = $nbPassagers;
    }

    public function getModele():string {
        return $this->modele;
    }

    public function setModele(string $modele):void {
        $this->modele = $modele;
    }

    public function getVitesse():int {
        return $this->vitesse;
    }

    public function setVitesse(int $vitesse):void {
        $this->vitesse = $vitesse;
    }

    public function getNbPassagers():int {
        return $this->nbPassagers;
    }

    public function setNbPassagers(int $nbPassagers):void {
        $this->nbPassagers = $nbPassagers;
    }

    public function direBonjour():void {
        echo "Bonjour, je suis un vehicule.";
    }
    abstract public function demarrer():void;

    abstract public function arreter():void;
    
}

    

