<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    if ($_POST["moyen_paiement"] == "Mastercard") {
        $total_price = intval($_POST["prix"]) + 5;
    } else {
        $total_price = intval($_POST["prix"]) + 3;
    }

    echo ("<p>Prix total : " . $total_price . " €")
    ?>
</body>

</html>