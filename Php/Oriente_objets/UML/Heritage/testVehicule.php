<?php

require_once "./classes/vehicule.php";
require_once "./classes/voiture.php";
require_once "./classes/avion.php";

$voiture1 = new Voiture("Mercedes", 100, 4, "Pierre", 2);

$voiture2 = new Voiture("BMW", 12, 5, "Marie",4);

$avion1 = new Avion("A650", 3, 800, "Dupont", "Air France");
$avion2 = new Avion("B1258", 5, 900, "Martin", "Airbus");

var_dump($voiture1);
var_dump($voiture2);
var_dump($avion1);
var_dump($avion2);

$voiture1->demarrer();
$voiture2->arreter();

$avion1->demarrer();
$avion2->arreter();

$voiture1->rouler();

$avion1->voler();


