<?php
    session_start();
        $_SESSION['nome'] = $_POST["nome"];
        $_SESSION['cpf'] = $_POST["cpf"];
        $_SESSION['rg'] = $_POST["rg"];
        $_SESSION['email'] = $_POST["email"];
        $_SESSION['dataNascimento'] = $_POST["dataNascimento"];
        $_SESSION['Senha'] = $_POST["Senha"];
        $_SESSION['telefone1'] = $_POST["telefone1"];
        $_SESSION['telefone2'] = $_POST["telefone2"];
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="../CSS/style.css">
    <title>Segunda Parte Cadastro</title>
 
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/56df592563.js" crossorigin="anonymous"></script>
    <style>
        * {
            padding: 0;
            margin: 0;
            color: whitesmoke;
        }
        .needs-validation {
            position: absolute; top: 53%; left: 50%;
            transform: translate(-50%,-50%);
            padding: 60px;
            background: #363636;
            border-radius: 50px;

        }
        .form-control {
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
        .needs-validation button[type="button"] {
            position: absolute; left: 35%; top: 90%;
            width: 180px;
        }
    </style>

    <script type="text/javascript"></script>

</head>
<body class="fundo fonte">
    
  <nav class="navbar navbar-expand-lg navbar-dark bg-black tamNavbar">
    <div class="container-fluid">
      <div class="marcaNavbar">
        <a class="navbar-brand" href="index.html">GearEVOLVED</a>
      </div>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
          <li class="nav-item dropdown zindexDropdown">
            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
              <i class="fa-solid fa-bars"></i>
            </a>
            <ul class="dropdown-menu bg-secondary zindexDropdown" aria-labelledby="navbarDropdown">
              <li><a class="dropdown-item" href="#"><i class="fa-solid fa-list-check"></i> Lista de Desejos</a></li>
              <li><a class="dropdown-item" href="#"><i class="fa-solid fa-basket-shopping"></i> Lista de Pedidos</a></li>
              <li><a class="dropdown-item" href="Atendimento ao Cliente.html"><i class="fa-solid fa-headset"></i> Atendimento ao Cliente</a></li>
              <li><a class="dropdown-item" href="Mapa.html"><i class="fa-solid fa-map-location-dot"></i> Loja Fisica</a></li>
              <li><hr class="dropdown-divider"></li>
              <li><a class="dropdown-item" href="Login.php">LOGIN</a></li>
              <li><a class="dropdown-item" href="Cadastro.php">CADASTRE-SE</a></li>
            </ul>
          </li>
          <div class="posMenu">
            <li class="nav-item">
              <a class="nav-link" href="#"><i class="fa-solid fa-circle-half-stroke"></i> Modo Claro</a>
           </li>
            <li class="nav-item">
              <a class="nav-link" href="#"><i class="fa-solid fa-cart-shopping"></i> Carrinho</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" aria-current="page" href="Perfil do Cliente.html"><i class="fa-solid fa-user"></i> Minha Conta</a>
            </li>
          </div>
        </ul>
      </div>
    </div>
  </nav>


    <form class="needs-validation" novalidate action="cadastrobanco.php" method="POST">
      <h4>Dados Pessoais</h4>
      <div class="row"> 
        <!-- Campo NOME -->
        <div class="col-md-12 col-sm-12">
          <label for="Rua">Rua: </label><br>
          <input type="text" class="form-control" name="Rua" required placeholder="Digite sua Rua">
            <div class="valid-feedback">Ok!</div>
              <div class="invalid-feedback">Campo Obrigatório!</div>
        </div>
      <!-- Campo CPF -->
      <div class="col-md-6 col-sm-12">	
        <label for="number">Numero: </label><br>
        <input type="text" class="form-control" name="number" id="" placeholder="Digite seu número">
      </div>
      <!-- Campo RG -->
      <div class="col-md-6 col-sm-12">	
        <label for="Complet">Complemento: </label><br>
        <input type="text" class="form-control" name="Complet" id="" placeholder="">
      </div>
      <!-- Campo Email -->
      <div class="col-md-12 col-sm-12">	
        <label for="Bairro">Bairro: </label><br>
        <input type="text" class="form-control" name="Bairro" id="" placeholder="Digite seu Bairro">
      </div>	
       <!-- Campo Data nascimento -->
      <div class="col-md-4 col-sm-12">	
        <label for="city">Cidade: </label><br>
        <input type="text" class="form-control" name="city" id="" placeholder="Digite sua Cidade">
      </div>
       <!-- Campo Senha -->
      <div class="col-md-4 col-sm-12">	
        <label for="Estado">Estado: </label><br>
        <input type="text" class="form-control" name="Estado"id="" placeholder="Digite seu Estado">
      </div>
      <!-- Campo Telefone 1 -->
      <div class="col-md-4 col-sm-12">
        <label for="CEP">CEP: </label><br>
        <input type="text"  name="CEP" class="form-control" id="" placeholder="Digite seu CEP">
      </div>   
      <div class="row" mt-3>
            <button type="submit" class="btn btn-outline-success">Finalizar</button>
        </div>
      </div>
    </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>
</html>