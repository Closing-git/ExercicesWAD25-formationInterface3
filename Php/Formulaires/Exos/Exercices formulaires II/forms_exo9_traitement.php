<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    $temps = [
        "chaud" => [
            "Maroc",
            "Mexique",
            "Espagne",
        ],
        "froid" => [
            "Belgique",
            "Angleterre",
            "Hollande",
        ],

        "gelé" => [
            "Norvège",
            "Islande",
            "Finlande",
        ],
    ];


    foreach ($temps as $key => $arr_pays) {
        foreach ($arr_pays as $pays) {
            if ($pays == $_POST["pays"]) {
                echo ("<p>Le temps en " . $pays . " est " . $key . ". </p>");
                switch ($key) {
                        case ("chaud"):
                            echo('<img src="./assets/img/chaud.jpg" alt="climat chaud" width="350px">');
                            break;
                        case ("froid"):
                            echo('<img src="./assets/img/froid.jpg" alt="climat froid" width="350px">');
                            
                            break;
                        case ("gelé"):
                            echo('<img src="./assets/img/gelé.jpg" alt="climat gelé" width="350px">');

                            break;
                        }
            }
            }
        }
        

    ?>

</body>

</html>