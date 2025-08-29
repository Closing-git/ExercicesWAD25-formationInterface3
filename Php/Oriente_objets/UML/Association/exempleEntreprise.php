<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    require_once 'classes/Societe.php';
    require_once 'classes/Employe.php';

    use UML\Association\Entreprise\Societe;
    use UML\Association\Entreprise\Employe;

    $employe1 = new Employe('Employe 1', 'employe1@gmail.com');
    $societe1 = new Societe('Societe 1', 'societe1@gmail.com');

    $societe1->addEmploye($employe1);

    var_dump($societe1);
    var_dump($employe1);

    ?>
</body>

</html>