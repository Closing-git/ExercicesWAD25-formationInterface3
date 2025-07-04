<?php

declare(strict_types=1)
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>

</body>

</html><?php

        //EXERCICE 10
        // function arrayInverser(array &$myarray)
        // {
        //     $arrayInverse =  [];
        //     for ($i = count($myarray) - 1; $i >= 0; $i--) {
        //         $arrayInverse[] = $myarray[$i];
        //     }
        //     $myarray = $arrayInverse;
        // }
        // $myarray = [0,1,2,3,4];
        // arrayInverser($myarray);
        // var_dump($myarray);





        //EXERCICE 11-16

        //TEST AVEC UN OBJET (Pas dans l'exo)
        // class Film
        // {
        //     public $nom;
        //     public $genre;
        //     public $realisateur;
        //     public $date;

        //     function set_name($nom)
        //     {
        //         $this->nom = $nom;
        //     }
        //     function getName()
        //     {
        //         return $this->nom;
        //     }

        //     function set_genre($genre)
        //     {
        //         $this->genre = $genre;
        //     }
        //     function set_realisateur($realisateur)
        //     {
        //         $this->realisateur = $realisateur;
        //     }
        //     function set_date($date)
        //     {
        //         $this->date = $date;
        //     }
        // }

        // $Titanic = new Film();
        // $Titanic->set_name("Titanic");
        // $Titanic->set_date(1997);
        // $Titanic->set_genre("Drame");
        // $Titanic->set_realisateur("Cameron");

        // var_dump($Titanic);

        // function AfficheAssoc(object &$film)
        // {
        //     print($film->getName());
        // };

        // AfficheAssoc($Titanic);

        // FIN DU TEST



        // $film1 = array(
        //     "nom" => "Titanic",
        //     "genre" => "Drame",
        //     "date" => "1997",
        // );

        // $film2 = array(
        //     "nom" => "Isle of dogs",
        //     "genre" => "Comédie Dramatique",
        //     "réalisateur" => "Anderson",
        //     "date" => "2018",
        // );

        // $film3 = array(
        //     "nom" => "The beginners",
        //     "genre" => "Comédie romantique",
        //     "réalisateur" => "Mills",
        //     "date" => "2011",
        // );

        // foreach ($film1 as $key => $value) {
        //     print($film1[$key] . "<br>");
        // }


        // function AfficheAssoc(array &$film)
        // {
        //     foreach ($film as $key => $value) {
        //         print($film[$key] . "<br>");
        //     }
        // };

        // AfficheAssoc($film2);




        //EXERCICE 17-18

        // function soustraction(float|int $nb1, float|int $nb2): float | int
        // {
        //     if ($nb1 > $nb2) {
        //         print("Le résultat est positif");
        //     } elseif ($nb2 > $nb1) {
        //         print("Le résultat est négatif");
        //     } else {
        //         print("Le résultat est de 0.");
        //     };
        //     return $nb1 - $nb2;
        // };

        // print(soustraction(30, 30));




        //EXERCICE 19

        // function afficheValeurs(int $nb1, int $nb2)
        // {
        //     for ($i = $nb1; $i <= $nb2; $i++) {
        //         print($i . "<br>");
        //     }
        // }
        // afficheValeurs(40, 66);

        ?>