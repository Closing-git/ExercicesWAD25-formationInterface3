<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    $nb1 = intval($_GET['nb1']);
    $nb2 = intval($_GET['nb2']);

    if ($nb1 < $nb2) {

        print("<table>
        <thead>
            <tr>
                <th>Nombre entre $nb1 et $nb2</th>
            </tr>
        </thead>
        <tbody>");

        for ($i = $nb1; $i <= $nb2; $i++) {
            print("<tr>
                <td scope='column'>$i</td>
            </tr>");
        }

        print("</tbody>
    </table>");


    
    } else {

        print("<table>
        <thead>
            <tr>
                <th>Nombre entre $nb1 et $nb2</th>
            </tr>
        </thead>
        <tbody>");

        for ($i = $nb1; $i >= $nb2; $i--) {
            print("<tr>
                <td scope='column'>$i</td>
            </tr>");
        }

        print("</tbody>
    </table>");

    }

    ?>

</body>

</html>