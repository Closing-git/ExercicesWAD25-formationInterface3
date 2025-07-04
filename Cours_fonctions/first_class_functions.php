<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php

    // //EXERCICE 1
    // $toLower = function (string $string) {
    //     return strtolower($string);
    // };

    // echo ($toLower("OUOAIUREOU"));
    // echo ("<br>");


    // //EXERCICE 2
    // $toUpper = function (string $string) {
    //     return strtoupper($string);
    // };
    // echo ($toUpper("oaijaezd"));
    // echo ("<br>");

    // //EXERCICE 3 + 4
    // $funcs = [$toLower, $toUpper];

    // echo ($funcs[0]("EFoi,eIOfj"));
    // echo ("<br>");
    // echo ($funcs[1]("EFoi,eIOfj"));
    // echo ("<br>");
    // echo ("<br>");


    // //EXERCICE 5-6

    // $premiereMaj = function (string $string) {
    //     return ucfirst($string);
    // };

    // $funcs[] = $premiereMaj;

    // foreach ($funcs as $func) {
    //     echo ($func("tEsT"));
    //     echo ("<br>");
    // }

    // //EXERCICE 7

    // $caller = function ($func, string $string) {
    //     echo ($func($string));
    //     echo ("<br>");
    // };
    // echo ("<br>");

    // $caller($premiereMaj, "alouette");
    // $strings = ["zeoifjezj", "oezfij", "foei"];
    // array_map($caller, $funcs, $strings);


    // //EXERCICE 8-14

    // $addition = function ($nb1, $nb2) {
    //     return $nb1 + $nb2;
    // };
    // $multiplication = function ($nb1, $nb2) {
    //     return $nb1 * $nb2;
    // };

    // $soustraction = function ($nb1, $nb2){
    //     return $nb1-$nb2;
    // };

    // $calcFunctions = [$addition, $multiplication, $soustraction];

    // foreach ($calcFunctions as $function){
    //     echo($function(5,10));
    //     echo("<br>");
    // }


    // $arr1 = [10,20,30];
    // $arr2 =[100,200,300];

    // var_dump(array_map($addition, $arr1, $arr2));


    // //EXERCICE 15

    // $arr = [1980, 1990, 2010, 2011, 2013, 2013];

    // $sup2000 = function (int $year) {
    //     if ($year >= 2000) {
    //         return TRUE;
    //     } else {
    //         return FALSE;
    //     }
    // };


    // $newArray = array_filter($arr, $sup2000);
    // var_dump($newArray);



    //EXERCICE 16

    $personnes = [
        [
            'nom' => 'Marwa',
            'annee' => 2000
        ],
        [
            'nom' => 'Anaïs',
            'annee' => 1998
        ],
        [
            'nom' => 'Gina',
            'annee' => 2002
        ],
        [
            'nom' => 'Jude',
            'annee' => 1997
        ],
    ];

    $post2000 = function (array $array) {
        if ($array["annee"] >= 2000) {
            return TRUE;
        } else {
            return FALSE;
        }
    };

    $personnesPost2000 = array_filter($personnes, $post2000);
    var_dump($personnesPost2000);
    ?>
</body>

</html>