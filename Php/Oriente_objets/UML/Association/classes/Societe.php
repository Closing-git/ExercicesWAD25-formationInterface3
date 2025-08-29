<?php
namespace UML\Association\Entreprise;


class Societe {
    private string $nom;
    private string $email;
    private array $employes;

    public function __construct(string $nom, string $email) {
        $this->nom = $nom;
        $this->email = $email;
        $this->employes = [];

    }

    public function getNom(): string {
        return $this->nom;
    }

    public function getEmployes(): array {
        return $this->employes;
    }
    public function getEmail(): string {
        return $this->email;
    }

    public function setNom(string $nom): void {
        $this->nom = $nom;
    }
    public function setEmployes(array $employes): void {
        $this->employes = $employes;
    }

    public function setEmail(string $email): void {
        $this->email = $email;
    }

    public function addEmploye(Employe $employe):void {
        $this->employes[] = $employe;
        $employe->setEmployeur($this);
    }
}