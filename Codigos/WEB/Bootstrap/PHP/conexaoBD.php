<?php
    try {        
        // conexão PDO    // IP, nomeBD, usuario, senha    
        $db =  'mysql:host=143.106.241.3;dbname=cl201000;charset=utf8';
        $user = 'cl201000';
        $passwd = 'cl*07071994';
        $pdo = new PDO($db, $user, $passwd);
        
        // ativar o depurador de erros
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);        
    } catch (PDOException $e) {
        $output = 'Impossível conectar BD : ' . $e . '<br>';
        echo $output;
    }    
?>