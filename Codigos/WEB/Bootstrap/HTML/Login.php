<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="../CSS/style.css">
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/56df592563.js" crossorigin="anonymous"></script>
    <title>Login</title>
    <style>
        * {
            color: whitesmoke;    
        }
        .form-control {
            width: 400px;
            border: 2px solid whitesmoke;
            border-radius: 10px;
            background: #00000000;
            color: whitesmoke;  
            margin-bottom: 20px;
        }
        .form-control:focus {
            background-color: #00000000;            
            color: whitesmoke;  
        }
        .controle {
            position: absolute; top: 50%; left: 50%;
            transform: translate(-50%,-50%);
            padding: 40px;
            background: #363636;
            border-radius: 50px;
            
        }
        .Corf {
            padding: 40px;
            background: #363636;
            border-radius: 50px;
        }
        .controle button[type="button"] {
            position: absolute; left: 35%; top: 71%;
            width: 150px;
            
        }

        a{
            color: whitesmoke;
        }
    </style>

    <script type="text/javascript">
        function entrar(){
            var email = document.getElementById("formGroupExampleInput").value;
            var senha = document.getElementById("floatingPassword").value;

            if(email == ""){
                alert("Preencha o campo e-mail");
            }
            else if (senha == ""){
                alert("Preencha o campo senha");
            }
        }
    </script>

</head>
<body class="fonte" background="../Imagens/Fundo.jpg">
    <nav class="navbar navbar-expand-lg navbar-dark bg-black">
		<div class="container-fluid">
		  <a class="navbar-brand" href="index.html">GearEVOLVED</a>
		  <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
			<span class="navbar-toggler-icon"></span>
		  </button>
		  <div class="collapse navbar-collapse" id="navbarSupportedContent">
			<ul class="navbar-nav me-auto mb-2 mb-lg-0">
			  <li class="nav-item dropdown">
				<a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
				  <i class="fa-solid fa-bars"></i>
				</a>
				<ul class="dropdown-menu bg-secondary" aria-labelledby="navbarDropdown">
				  <li><a class="dropdown-item" href="#"><i class="fa-solid fa-list-check"></i> Lista de Desejos</a></li>
				  <li><a class="dropdown-item" href="#"><i class="fa-solid fa-basket-shopping"></i> Lista de Pedidos</a></li>
				  <li><a class="dropdown-item" href="Atendimento ao Cliente.html"><i class="fa-solid fa-headset"></i> Atendimento ao Cliente</a></li>
          <li><a class="dropdown-item" href="Mapa.html"><i class="fa-solid fa-map-location-dot"></i> Loja Fisica</a></li>
				  <li><hr class="dropdown-divider"></li>
				  <li><a class="dropdown-item" href="Login.php">LOGIN</a></li>
				  <li><a class="dropdown-item" href="Cadastro.php">CADASTRE-SE</a></li>
				</ul>
			  </li>
			  <li class="nav-item">
				<a class="nav-link" href="#"><i class="fa-solid fa-circle-half-stroke"></i> Modo Claro</a>
			  </li>
			  <li class="nav-item">
				<a class="nav-link" href="#"><i class="fa-solid fa-cart-shopping"></i> Carrinho</a>
			  </li>
			  <li class="nav-item">
				<a class="nav-link" aria-current="page" href="Perfil do Cliente.html"><i class="fa-solid fa-user"></i> Minha Conta</a>
			  </li>
			</ul>
		  </div>
		</div>
	  </nav>

    <form  method="POST">
        <div class="controle">
            <h4 style="text-align: center; margin-bottom: 15px; ">Faça seu login </h4>
            <div class="form-floating mb-3">
                <input type="text" class="form-control" name="email" placeholder="Email" >
                <label for="floatingInput">E-mail</label>
            </div>
            <div class="form-floating">
                <input type="password" class="form-control" name="senha" placeholder="Password" >
                <label for="floatingPassword">Senha</label>
                <p style="position: absolute; left: 68%; margin-top: -20px; font-size: 12px">Esqueci minha senha</p>
            </div>
            
            <button type="submit" class="btn btn-outline-success" >Entrar</button>
            
            <p style="padding-left: 145px; padding-top: 75px; font-size: 12px;"><a href="Cadastro.html">Não tem uma conta?</p></a>
        </div>
      </form>
      
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    
</body>
</html>
<?php
if ($_SERVER["REQUEST_METHOD"] === 'POST') {
include("../PHP/conexaoBD.php");

try {            
    $email = $_POST["email"];
    $senha = $_POST["senha"];


    if ((trim($email) == "") || (trim($senha) == "")) {
        echo "<span id='warning'>Email e Senha são obrigatórios!</span>";
    } else {                  
        $stmt = $pdo->prepare("select * from Cliente where email = :email and senha = :senha");
        $stmt->bindParam(':email', $email);
        $stmt->bindParam(':senha', $senha);
        $stmt->execute();

        $rows = $stmt->rowCount();

        if ($rows <= 0) {
            echo "<span id='error'>Email ou Senha incorretos</span>";  
        } else {
            echo "<script type='text/javascript'> window.open('index.html', '_top');</script>";
        }
    }
} catch(PDOException $e) {
    echo 'Error: ' . $e->getMessage();
}
$pdo = null;
}
?>