<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php

    // function addition (int $val1, int $val2){
    //     return $val1 + $val2;
    // }

    // echo (addition(2, 3));
    // print("<br>");
    // $addition2 = function (int $val1, int $val2):int{
    //     return $val1 + $val2;
    // };

    // echo ($addition2 (9,10));

    // $soustraction = function (int $val1, int $val2):int{
    //     return $val1 - $val2;
    // };

    // $tab = [$addition2, $soustraction];

    // foreach ($tab as $uneFonction){
    //     echo($uneFonction(10,20));
    // }



    //PARTIE 2

    function afficheArrayUL(array $tab): void
    {
        echo ("<ul>");
        foreach ($tab as $value) {
            echo ("<li>" . $value . "</li>");
        }
        echo ("</ul>");
    }

    function createSelect(array $tab): void
    {
        echo ("<select>");
        foreach ($tab as $value) {
            echo ("<option>"  . $value . "</option>");
        }
        echo ("</select>");
    }


    $tab = ["A", "B", "C", "D"];
    afficheArrayUL($tab);
    createSelect($tab);

    
    // Avec des First class, on peut simplifier : 

    function genererAffichage(string $type)
    {
        switch ($type) {
            case "select":
                return function (array $tab) {
                    echo ("<select>");
                    foreach ($tab as $value) {
                        echo ("<option>"  . $value . "</option>");
                    }
                    echo ("</select>");
                };
                break;


            case "ul":
                return function (array $tab) {
                    echo ("<ul>");
                    foreach ($tab as $value) {
                        echo ("<li>" . $value . "</li>");
                    }
                    echo ("</ul>");
                };
                break;
        }
    }

    $fSelect = genererAffichage("select");
    $fUl = genererAffichage("ul");

    $fSelect($tab);
    $fUl($tab);


    ?>


</body>

</html>