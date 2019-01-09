<?php
  session_start();
  if (isset($_POST['submit'])) {
    $username = $_POST['username'];
    $hash = $_POST['password'];
    $email = $_POST['email'];
    $conn = new mysqli('dblabs.it.teithe.gr', 'it154551', '123456', 'it154551', null, "/home/student/it/2015/it154551/mysql/run/mysql.sock");

    $sql = "INSERT INTO users (username, password, email) VALUES (?, ?, ?)";
    $statement = $conn->prepare($sql);
    $statement ? $statement->bind_param("sss", $username, $email, $hash) : die("sql syntax error");
    $statement ? $statement->execute()       : die("sql bind error");
    $statement -> close();

    // $sql = sprintf("INSERT INTO users (username, password, email) VALUES (
    //   '%s', '%s', '%s'
    // )", mysqli_real_escape_string($db, $username),
    //     mysqli_real_escape_string($db, $hash),
    //     mysqli_real_escape_string($db, $email));
    // mysqli_query($db, $sql);
    // mysqli_close($db);
    header('Location: index.html');
    exit();
  }
?>
<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <title>MCEG - Εγγραφή</title>
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700" rel="stylesheet">
    <link rel="stylesheet" href="register.css">
  </head>
  <body>
    <div class="logo">
      <img src="logo.png" alt="">
    </div>
    <form class="" action="" method="post">
      <input type="text" name="username" value="" placeholder="Όνομα Χρήστη">
      <input type="text" name="email" value="" placeholder="Email">
      <input type="password" name="password" value="" placeholder="Κωδικός">
      <input type="submit" name="submit" value="Εγγραφή">
    </form>
  </body>
</html>
