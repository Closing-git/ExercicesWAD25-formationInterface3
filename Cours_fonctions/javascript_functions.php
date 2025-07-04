<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <script>
        function somme(val1, val2) {
            return val1 + val2
        }
        let res = somme(90, 100)
        console.log(`somme : ${res}`)

        const multiplication = function(val1, val2) {
            return (val1 * val2)
        }

        console.log(multiplication(2, 3))

        let tab3 = ["a", "b", "c", "d"]


        function majuscules(chaine) {
            return chaine.toUpperCase()
        }
        let new_tab = tab3.map(majuscules)
        console.log(new_tab)
    </script>


    <script>
        let tab = ["A", "B", "C", "D"];

        let genererAffichage = function genererAffichage(type) {
            switch (type) {
                case "select":
                    return function(tab) {
                        document.write("<select>");
                        tab.forEach((value) => {
                            document.write("<option>" + value + "</option>");
                        })
                        document.write("</select>");
                    };
                    break;


                case "ul":
                    return function(tab) {
                        document.write("<ul>");
                        tab.forEach((value) => {
                            document.write("<li>" + value + "</li>");
                        })
                        document.write("</ul>");
                    };
                    break;
            }
        }

        let fSelect = genererAffichage("select");
        let fUl = genererAffichage("ul");

        fSelect(tab);
        fUl(tab);
    </script>
</body>

</html>