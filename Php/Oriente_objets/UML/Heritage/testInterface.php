<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
<?php

require_once "./classes/IPersonnage.php";
require_once "./classes/Robot.php";
require_once "./classes/Humain.php";

$robot1 = new Robot("Robot1", "BX12");
$humain1 = new Humain("Pierre", 15);


$robot1->sePresenter();
$humain1->sePresenter();
$humain1->sentir();
$robot1->calculerHauteVitesse();

$robot1->seDeplacer();
$humain1->seDeplacer();
$robot1->parler();
$humain1->parler();
?>
</body>
</html>