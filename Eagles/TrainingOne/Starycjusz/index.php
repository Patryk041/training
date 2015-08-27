<html>
    <head>
        <meta charset="UTF-8">
        <?php
            require_once('Persons.php');
        ?>
    </head>
    <body>
        <form action="index.php" method="post">
            <input type="text" name="content" /><br />
            <select name="country">
                <option value="PL">Poland</option>
                <option value="FR">France</option>
                <option value="SL">Slovenia</option>
            </select>
            <input type="submit" name="submit" value="Wyslij!" />
        </form>
        
        <?php
            if (isset($_POST["content"])) 
            {
                $MyPerson = new Person();
                $MyPerson->ShowData($_POST["content"], $_POST["country"]);                
            }
        ?>
    </body>
</html>
