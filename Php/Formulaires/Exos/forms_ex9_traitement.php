<!DOCTYPE html>
<html lang="fr-be">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Forms ex9 Traitement</title>
</head>

<body>
    <?php
    $price_double = 100;
    $price_simple = 60;
    $price_suite = 230;



    $nb_double = $_POST['chambre_double'];
    $nb_simple = $_POST['chambre_simple'];
    $nb_suite = $_POST['suite'];

    if (empty($nb_double)) {
        $nb_double = 0;
    }

    if (empty($nb_simple)) {
        $nb_simple = 0;
    }

    if (empty($nb_suite)) {
        $nb_suite = 0;
    }


    $total = $price_double * $nb_double + $price_simple * $nb_simple + $price_suite * $nb_suite;

    print("<p>" . $nb_double . " chambres double à " . $price_double . '€ </p>' .
        "<p>" . $nb_simple . " chambres simple à " . $price_simple . '€ </p>' .
        "<p>" . $nb_suite . " suites à " . $price_suite . '€ </p>' .
        "<p> Total : " . $total . " € </p>")



    ?>
</body>

</html>