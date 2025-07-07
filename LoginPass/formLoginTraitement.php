    <?php
    session_start();
    //Obtenir les données
    $email = $_POST['email'];
    $password = $_POST['password'];


    //Chercher user dans la DB et comparer les passwords
    include "./db/config.php";
    try {
        $cnx = new PDO(DSN, USER, PASSWORD);
    } catch (Exception $e) {
        echo $e->getMessage();
        die();
    }

    $sql = "SELECT nom, email, password FROM stagiaire WHERE email=:email";

    $stmt = $cnx->prepare($sql);
    $stmt->bindValue(":email", $email);
    $stmt->execute();
    $res = $stmt->fetch(PDO::FETCH_ASSOC);

    if ($res === false) {
        //L'utilisateur n'existe pas
        header('location: ./formInscription.php');
    } else {
        $password_db = $res['password'];
        if (password_verify($password, $password_db)) {
            $_SESSION['email']=$email;
            $_SESSION['nom']=$res['nom'];
            header('location: ./accueil.php');
        } else {
            header('location: ./formLogin.php');
        }
    }
    var_dump($stmt->errorInfo());
    var_dump($res);

    ?>