<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    include "./classes/Chien.php";
    include "./classes/Chat.php";
    include "./classes/AnimalH.php";
    include "./classes/ChatH.php";


    $chien1 = new Chien("Rex", "blanc");
    var_dump($chien1);
    echo $chien1->getNom();

    $chien1->courrir();
    $chien1->manger();

    $chat1 = new Chat("Boulette", "noir");
    var_dump($chat1);
    echo $chat1->getNom();

    $chat1->courrir();
    $chat1->manger();

    $chatH1 = new ChatH("Castor", "tortue");
    var_dump($chatH1);
    echo $chatH1->getNom();

    $chatH1->courir();
    $chatH1->manger();
    $chatH1->miauler();
    ?>
</body>
</html>