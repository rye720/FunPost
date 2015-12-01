<?php

if(($_POST["submit"])){

   if($_POST['username']&& $_POST['password']!=""){
        $user=strip_tags(($_POST['username']));
        $pass=strip_tags(($_POST['password']));

        $dbc = mysqli_connect('localhost', 'forfamuc_damosco', 'tJc3Fb0+nsF#', 'forfamuc_socialsite')
        or die('error conecting to server');
       $sql="SELECT username, password FROM login WHERE username = '$user'";


        $query=mysqli_query($dbc,$sql) or die ('error querying database'.mysqli_connect_error()) ;;
    
        
            if($query){
                $row = mysqli_fetch_row($query);
                $dbusername = $row[0];
                $dbpassword = $row[1];


                echo $dbusername;
                echo $dbpassword;
            }

            if($user == $dbusername && $pass == $dbpassword)
            {
                session_start();
                $_SESSION['sess_user']=$user;

                /* Redirect browser */
                header("Location:http://funpost.website/member.php");
                echo'check';
            }
        } else {
            echo "Invalid username or password!";
        }

    } 

?>