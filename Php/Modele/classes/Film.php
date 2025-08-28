<?php

class Film {
    private int $id;
    private string $titre;
    private int $duree;
    private string $description;
    private DateTime $dateSortie;

    public function __construct(string $titre, int $duree, string $description, DateTime $dateSortie) {
        $this->titre = $titre;
        $this->duree = $duree;
        $this->description = $description;
        $this->dateSortie = $dateSortie;
    }

    public function getId() {
        return $this->id;
    }

    public function getTitre() {
        return $this->titre;
    }

    public function getDuree() {
        return $this->duree;
    }

    public function getDescription() {
        return $this->description;
    }

    public function getDateSortie() {
        return $this->dateSortie;
    }
    public function setId(int $id) {
        $this->id = $id;
    }
    public function setTitre(string $titre) {
        $this->titre = $titre;
    }
    public function setDuree(int $duree) {
        $this->duree = $duree;
    }
    public function setDescription(string $description) {
        $this->description = $description;
    }
    public function setDateSortie(DateTime $dateSortie) {
        $this->dateSortie = $dateSortie;
    }
}

?>
