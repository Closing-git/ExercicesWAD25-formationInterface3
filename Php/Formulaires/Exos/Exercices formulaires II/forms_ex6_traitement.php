<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php

    $total = 8;

    if (intval($_POST['age']) < 12) {
        $total = 4;
    }

    //Si la valeur student existe (vu qu'avec une checkbox, on n'a pas de valeur off ou unchecked)
    if (isset($_POST["student"])) {
        $total = $total * 0.80;
    }

    echo ("<p>Total après réduction potentielle : " . $total . " € </p>")


    ?>
</body>

</html>