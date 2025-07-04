<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    $division = function (float $v1, float $v2): ?float {
        if ($v2 != 0) {
            return $v1 / $v2;
        } else {
            throw new Exception("Erreur : Division par zéro");
        }
    };



    try {
        echo ("Le résultat de la division : " . $division(12, 0) . "<br>");
    } catch (Exception $e) {
        echo $e->getMessage();
        die();
        
    }
    echo ("<br> On continue");


    ?>
</body>

</html>