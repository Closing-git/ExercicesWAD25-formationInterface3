<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exemple API</title>
</head>
<body>
    <?php
    $res=file_get_contents("https://official-joke-api.appspot.com/jokes/random/5");
    var_dump($res);

    $result=json_decode($res);
    var_dump($result);

    print("Blague 1 :");
    print($result[1]->setup);
    print($result[1]->punchline);

    ?>
</body>
</html>