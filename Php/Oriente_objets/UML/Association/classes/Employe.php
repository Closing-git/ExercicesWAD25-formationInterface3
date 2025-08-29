<?php
namespace UML\Association\Entreprise;

class Employe {
    private string $nom;
    private string $email;
    private Societe $employeur;

    public function __construct(string $nom, string $email) {
        $this->nom = $nom;
        $this->email = $email;
    }

    public function getNom(): string {
        return $this->nom;
    }

    public function getEmail(): string {
        return $this->email;
    }
    public function getEmployeur(): Societe {
        return $this->employeur;
    }

    public function setNom(string $nom): void {
        $this->nom = $nom;

    }
    
    public function setEmployeur(Societe $employeur): void {
        $this->employeur = $employeur;
    }

    public function setEmail(string $email): void {
        $this->email = $email;
    }
}