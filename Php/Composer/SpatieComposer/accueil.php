<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php

    require_once 'vendor/autoload.php';

    // use the factory to create a Faker\Generator instance
    $faker = Faker\Factory::create();
    // generate data by calling methods
    echo $faker->name();
    echo "<br>";
    // 'Vince Sporer'
    echo $faker->email();
    echo "<br>";
    // 'walter.sophia@hotmail.com'
    echo $faker->text();
    echo "<br>";
    // 'Numquam ut mollitia at consequuntur inventore dolorem.'
    ?>
</body>

</html>