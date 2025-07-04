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
        }
        else {
            return null;
        }
    };
    echo ("Le résultat de la division : " . $division(4, 8) . "<br>");
    echo ("Le résultat de la division : " . $division(8, 4) . "<br>");
    echo ("Le résultat de la division : " . $division(12, 0) . "<br>");


    ?>
</body>

</html>