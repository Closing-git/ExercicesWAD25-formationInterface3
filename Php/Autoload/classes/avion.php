<?php   
class Avion extends Vehicule {
    protected string $pilote;
    protected string $compagnie;

    public function __construct(string $modele, int $vitesse, int $nbPassagers, string $pilote, string $compagnie)
    {
        parent::__construct($modele, $vitesse, $nbPassagers);
        $this->pilote = $pilote;
        $this->compagnie = $compagnie;
    }

    public function getPilote():string {
        return $this->pilote;
    }

    public function setPilote(string $pilote):void {
        $this->pilote = $pilote;
    }

    public function getCompagnie():string {
        return $this->compagnie;
    }

    public function setCompagnie(string $compagnie):void {
        $this->compagnie = $compagnie;
    }

    public function voler():void {
        echo "L'avion {$this->modele} vole.";
    }

    public function demarrer():void {
        echo "L'avion {$this->modele} démarre.";
    }

    public function arreter():void {
        echo "L'avion {$this->modele} s'arrête.";
    }
}