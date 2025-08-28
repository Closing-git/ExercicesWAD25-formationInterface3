<?php
namespace Magasin;
class Produit{
    private $id;
    private $nom;
    private $prix;
    private $stock;

    public function __construct(int $id, string $nom, float $prix, int $stock){
        $this->id = $id;
        $this->nom = $nom;
        $this->prix = $prix;
        $this->stock = $stock;
    }

    public function afficher(){
        echo "Nom : " . $this->nom . "<br>";
    }
    public function getId(){
        return $this->id;
    }
    public function getNom(){
        return $this->nom;
    }
    public function getPrix(){
        return $this->prix;
    }
    public function getStock(){
        return $this->stock;
    }

    public function setId(int $id){
        $this->id = $id;
    }
    public function setNom(string $nom){
        $this->nom = $nom;
    }
    public function setPrix(float $prix){
        $this->prix = $prix;
    }
    public function setStock(int $stock){
        $this->stock = $stock;
    }
}