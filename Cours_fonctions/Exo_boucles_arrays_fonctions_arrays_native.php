<?php

declare(strict_types=1);
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php

    //EX 20

    // $myString = "un,deux,trois , quatre, cinq";

    // $explodeString = explode(",", $myString);
    // foreach($explodeString as &$value){
    //     $value =trim($value);
    // }
    // var_dump($explodeString);





    //EX 21
    // $myArray = [
    //     "un",
    //     "deux",
    //     "trois",
    //     "quatre",
    // ];

    // $implodeArray = implode(", ", $myArray);
    // var_dump($implodeArray);





    //EX 22
    // $array1 = [
    //     "clé1"=>1,
    //     "clé2"=> 'deux',
    //     "clé3"=> 3333,
    // ];

    //     $array2 = [
    //     "color"=>"blue",
    //     "clé2"=> 2,
    //     "autre"=> "misc",
    //     ];

    // $mergeArray = array_merge($array1, $array2);
    // $mergeArrayV2 = array_merge($array2, $array1);

    // var_dump($mergeArray);
    // var_dump($mergeArrayV2);




    //EX 23

    // $hobbies = [];

    // $hobbies = ["peindre", "chanter", "cinéma", "échecs"];

    // print_r($hobbies);
    // var_dump($hobbies);
    // foreach ($hobbies as $cle => $hobby) {
    //     print($cle . " => " . $hobby);
    // }

    // for ($i=0; $i < count($hobbies); $i++){
    //     print("<br>" . $hobbies[$i]);
    // }

    // $i=0;
    // print("<br>");
    // while ($i<count($hobbies)){
    //     print("<br>" . $hobbies[$i]);
    //     $i++;
    // }


    // print("<br>");
    // $i=count($hobbies)-1;
    // while ($i>=0){
    //     print("<br>" . $hobbies[$i]);
    //     $i--;
    // }



    //EXERCICE 24

    // $acteur1 = [
    //     "Prenom" => "Jean-Claude",
    //     "Nom" => "Van Damme",
    // ];

    // $acteur1["Nationalité"] = "Belgique";

    // var_dump($acteur1);

    // foreach ($acteur1 as $key => $value) {
    //     echo ("<p>" . $key . " : " . $value . "</p>");
    // }

    // print_r($acteur1);
    // //Récupére les noms des keys dans un tableau
    // $keys = array_keys($acteur1);
    // for ($i = 0; $i < count($acteur1); $i++) {
    //     echo ("<p>" . $keys[$i] . " : " . $acteur1[$keys[$i]] . "</p>");
    // }


    // $i = 0;
    // while ($i < count($acteur1)) {
    //     echo ("<p>" . $keys[$i] . " : " . $acteur1[$keys[$i]] . "</p>");
    //     $i++;
    // }

    // $i=count($acteur1)-1;
    // while ($i>=0){
    //     echo ("<p>" . $keys[$i] . " : " . $acteur1[$keys[$i]] . "</p>");
    //     $i--;
    // }


    ?>
</body>

</html>