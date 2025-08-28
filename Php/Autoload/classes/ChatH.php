<?php

class ChatH extends AnimalH{
    // public function __construct(string $nom, string $couleur) {
    //     parent::__construct($nom, $couleur);
    // }

    public function miauler():void {
        echo "{$this->getNom()} miaule.";
    }
}