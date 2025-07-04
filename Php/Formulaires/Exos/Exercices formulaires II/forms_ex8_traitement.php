<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php


    $arr_pays = [
        [
            "nom" => "Belgique",
            "url_drapeau" => "belgique.png",
            "capitale" => "Bruxelles"
        ],
        [
            "nom" => "France",
            "url_drapeau" => "france.png",
            "capitale" => "Paris"
        ],
        [
            "nom" => "Espagne",
            "url_drapeau" => "espagne.png",
            "capitale" => "Madrid"
        ],
        [
            "nom" => "Portugal",
            "url_drapeau" => "portugal.png",
            "capitale" => "Lisbonne"
        ],
    ];



    foreach ($arr_pays as $info_pays) {
        if ($info_pays["nom"] == $_POST["pays"]) {
            // header('Location: http://www.google.fr');
            echo '<script>window.open("https://' . $_POST["langue"] . '.wikipedia.org/wiki/' . $info_pays["nom"] . '");</script>';
            echo ("<h1>" . $info_pays["nom"] . "</h1>");
            echo ("<h2> Capitale : " . $info_pays["capitale"] . "</h2>");
            echo ('<img src="./assets/img/' . $info_pays["url_drapeau"] . '" alt="drapeau de ' . $info_pays["nom"] . '">');
        }
    }

    ?>
</body>

</html>