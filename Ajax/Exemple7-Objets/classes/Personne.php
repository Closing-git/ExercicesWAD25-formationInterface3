<?php
class Personne {
    public $prenom;
    public $nom;
    public $age;

    public function __construct($prenom, $nom, $age) {
        $this->prenom = $prenom;
        $this->nom = $nom;
        $this->age = $age;
    }

    public function getPrenom() {
        return $this->prenom;
    }
    public function getNom() {
        return $this->nom;
    }
    public function getAge() {
        return $this->age;
    }

    public function setPrenom($prenom) {
        $this->prenom = $prenom;
    }
    public function setNom($nom) {
        $this->nom = $nom;
    }
    public function setAge($age) {
        $this->age = $age;
    }
}
?>
