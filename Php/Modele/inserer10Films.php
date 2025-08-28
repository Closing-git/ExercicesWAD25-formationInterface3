<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php


    include "./connexion/db.php";

    require_once "./classes/FilmManager.php";
    try {
        $cnx = new PDO(DSN, DBUSER, DBPASS);
    } catch (Exception $e) {
        // jamais en production car ça montre des infos
        // sensibles
        echo $e->getMessage();
        die();
    }


    require_once "./vendor/autoload.php";
    require_once "./classes/FilmManager.php";
    use Faker\Factory;  
    $faker = Factory::create();
    $manager = new FilmManager($cnx);

    for ($i=0; $i < 10; $i++) {
        $film = new Film ($faker->word(), $faker->numberBetween(60, 200), $faker->sentence(), $faker->dateTimeBetween('-50 years', 'now'));
        $manager->insert($film);
        
    }
    ?>

</body>

</html>