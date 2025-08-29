<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    require_once 'classes/User.php';
    require_once 'classes/Post.php';

    $user1 = new User('John Doe', 'john.doe@gmail.com');
    $post1 = new Post('Post 1', new DateTime(), $user1);
    $post2 = new Post('Post 2', new DateTime(), $user1);
    $user2=new User('Jane Doe', 'jane.doe@gmail.com');

    var_dump($user1);
    var_dump($post1);

    $post1->setAuthor($user2);
    var_dump($user1);
    var_dump($user2);
    var_dump($post1);
    
    
    ?>
</body>
</html>