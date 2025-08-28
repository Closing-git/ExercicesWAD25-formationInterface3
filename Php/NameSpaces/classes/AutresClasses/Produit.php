<?php
namespace AutresClasses;
class Produit
{
    private $id;
    private $nom;
    private $prix;

    public function afficher(){
        echo 'Produit de l\'autre classe';
    }

    public function __construct(int $id, string $nom, float $prix)
    {
        $this->id = $id;
        $this->nom = $nom;
        $this->prix = $prix;
    }
}
