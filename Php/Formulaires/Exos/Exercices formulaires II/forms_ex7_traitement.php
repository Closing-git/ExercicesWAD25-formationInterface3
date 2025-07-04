<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    if ($_POST["car_type"] == "diesel") {
        $total = intval($_POST['nb_km']) * 0.25;
    }
    if ($_POST["car_type"] == "essence") {
        $total = intval($_POST['nb_km']) * 0.30;
    }

    echo ("<p>Le prix est de : " . $total . " € </p>");
    ?>
</body>

</html>