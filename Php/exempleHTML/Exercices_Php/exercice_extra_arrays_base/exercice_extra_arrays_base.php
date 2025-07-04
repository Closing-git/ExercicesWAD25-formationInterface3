<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">
</head>
<?php


$prices = [1000, 800, 900, 700, 800, 900, 1800, 1900, 1400, 1500];

?>

<body>
    <?php
    $nbvols = 0;
    $totalPrices = 0;
    print("<p>");
    foreach ($prices as $price) {
        //Moitié prix, promotion :
        $price = $price / 2;
        $new_prices[] = $price;
    }


    print("<p> Tableau après promo : ");
    foreach ($new_prices as $price) {
        //Ajout de l'id "promo" si <900
        if ($price < 900) {
            print("<span id=\"promo\">$price  $ </span>");
        } else {
            print("$price $ ");
        }

        //Nb de vols à moins de 700
        if ($price < 700) {
            $nbvols += 1;
        }

        $totalPrices += $price;
    }

    print("<p>Il y a $nbvols vols qui coûtent moins de 700 $, la moyenne des prix est de " . $totalPrices / (count($new_prices)) . "$ </p>");

    // print("</p> <p>");
    // for ($i = 0; $i < count($prices); $i++) {
    //     print($prices[$i] . " ");
    // }
    // print("</p>")
    ?>


</body>

</html>