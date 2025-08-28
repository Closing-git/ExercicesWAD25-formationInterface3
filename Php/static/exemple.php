<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    include "./classes/Medecin.php";
    $medecin1 = new Medecin(1, "Doe", "John", "Cardiologue");
    $medecin2 = new Medecin(2, "Pie", "Pierre", "Gynécologue");
    var_dump($medecin1);
    var_dump($medecin2);


echo Medecin::getCodeDeontologique();
    ?>
</body>
</html>