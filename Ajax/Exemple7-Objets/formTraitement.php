<?php
require_once "./classes/Personne.php";

$p1 = new Personne("Ayla", "Anderson", 25);
$p2 = new Personne("Annie", "Smith", 30);

$personnes = [$p1, $p2];

echo json_encode($personnes);
?>