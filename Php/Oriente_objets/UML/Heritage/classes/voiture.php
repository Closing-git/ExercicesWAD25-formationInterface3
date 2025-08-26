<?php

class voiture extends Vehicule {
    protected string $conducteur;
    protected int $nbPortes;

    public function __construct(string $modele, int $vitesse, int $nbPassagers, string $conducteur, int $nbPortes)
    {
        parent::__construct($modele, $vitesse, $nbPassagers);
        $this->conducteur = $conducteur;
        $this->nbPortes = $nbPortes;
    }

    public function getConducteur():string {
        return $this->conducteur;
    }

    public function setConducteur(string $conducteur):void {
        $this->conducteur = $conducteur;
    }

    public function getNbPortes():int {
        return $this->nbPortes;
    }

    public function setNbPortes(int $nbPortes):void {
        $this->nbPortes = $nbPortes;
    }

    public function rouler():void {
        echo "La voiture {$this->getModele()} roule.";
    }

    public function demarrer():void {
        echo "La voiture {$this->getModele()} démarre.";
    }

    public function arreter():void {
        echo "La voiture {$this->getModele()} s'arrête.";
    }
}