<?php
class Chat {
    // Propriétés
    private string $nom;
    private string $couleur;

    // Méthodes
    public function __construct(string $nom, string $couleur) {
        $this->nom = $nom;
        $this->couleur = $couleur;
    }

    public function getNom():string {
        return $this->nom;
    }

    public function setNom(string $nom):void {
        $this->nom = $nom;
    }

    public function getCouleur():string {
        return $this->couleur;
    }

    public function setCouleur(string $couleur):void {
        $this->couleur = $couleur;
    }

    public function courrir(){
        echo "{$this->nom} court.";
    }

    public function manger(){
        echo "{$this->nom} mange.";
    }
}