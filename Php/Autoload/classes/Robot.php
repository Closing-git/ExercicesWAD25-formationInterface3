<?php
class Robot implements IPersonnage
{
    protected string $nom;
    protected string $type;

    public function __construct(string $nom, string $type)
    {
        $this->nom = $nom;
        $this->type = $type;
    }

    public function getNom(): string
    {
        return $this->nom;
    }

    public function getType(): string
    {
        return $this->type;
    }

    public function setType(string $type): void
    {
        $this->type = $type;
    }

    public function setNom(string $nom): void
    {
        $this->nom = $nom;
    }

    public function calculerHauteVitesse(): void
    {
        echo "Vitesse Maximale";
    }

    public function sePresenter(): void
    {
        echo "Je suis un robot nommé {$this->nom} et je suis de type {$this->type}.";
    }
    public function seDeplacer(): void
    {
        echo "Je me deplace en tant que robot.";
    }
    public function parler(): void
    {
        echo "Je parle en tant que robot.";
    }
}
