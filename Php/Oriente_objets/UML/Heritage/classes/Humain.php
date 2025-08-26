<?php

class Humain implements IPersonnage
{
    protected string $nom;
    protected int $age;

    function __construct(string $nom, int $age)
    {
        $this->nom = $nom;
        $this->age = $age;
    }

    function getNom(): string
    {
        return $this->nom;
    }

    function getAge(): int
    {
        return $this->age;
    }

    function setNom(string $nom): void
    {
        $this->nom = $nom;
    }

    function setAge(int $age): void
    {
        $this->age = $age;
    }

    function sePresenter(): void
    {
        echo "Je suis un humain nommé {$this->nom} et j'ai {$this->age} ans.";
    }

    function sentir():void{
        echo "Je sent un robot.";
    }

    public function seDeplacer(): void
    {
        echo "Je me deplace en tant qu'humain.";
    }
    public function parler(): void
    {
        echo "Je parle en tant qu'humain.";
    }
}
