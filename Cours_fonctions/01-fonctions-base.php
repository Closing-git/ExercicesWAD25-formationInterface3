<?php

declare(strict_types=1);
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    $prix = 30;
    $nom = "gsm";

    function afficherPrixTVAC(float $prix): void
    {
        print($prix * 1.21);
    }

    afficherPrixTVAC($prix);


    function calculerPrixTVAC(float $prix, ?float $tauxTVA=21): float | string
    {
        if ($prix < 0) {
            //Ca ne se fait pas vraiment comme ça, évidemment, c'est pour l'exemple
            return "Erreur";
        } else {
            $prixTVAC = $prix * (1 + $tauxTVA / 100);
            return $prixTVAC;
        }
    }
    print("<br>");
    print(calculerPrixTVAC($prix));
    print("<br>");
    print(calculerPrixTVAC((float) "12"));
    print("<br>");
    print(calculerPrixTVAC(-12, 3));

    function echangerValsRef (int &$x, int &$y){
        $temp = $x;
        $x=$y;
        $y=$temp;
    }

    $x=3;
    $y=12;
echangerValsRef($x, $y);
print("x : " . $x);




    ?>
</body>

</html>