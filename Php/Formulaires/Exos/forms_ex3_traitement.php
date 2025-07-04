<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php

    $nb=mt_rand(0,10);
    print("Triche : " . $nb . "<br>");


    if ($nb==$_POST['user_number']){
        print("Bravo tu as trouvé ! <br>");
        print("<img src='./assets/img/victory.webp' alt='image de victoire'>");
    }
    else {
        print("Perdu ! <a href='./forms_ex3.php'>Recommencer</a>");
    }

    ?>

</body>

</html>