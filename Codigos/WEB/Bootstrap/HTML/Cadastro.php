<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="../CSS/style.css">
    <title>Cadastro</title>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/56df592563.js" crossorigin="anonymous"></script>
    <style>
        * {
            color: whitesmoke; 
        }
        .needs-validation {
            position: absolute; top: 57%; left: 50%;
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
        navbar-brand {
            margin-left: 70px;
            margin-top: 100px;
        } 

    </style>


    <script type="text/javascript">
        function avancar(){
            var email = document.getElementById("email").value;
            var senha = document.getElementById("floatingPassword").value;
            var nome = document.getElementById("nome").value;
            var cpf = document.getElementById("cpf").value;
            var rg = document.getElementById("rg").value;
            var telefone = document.getElementById("telefone").value;
            var data = document.getElementById("data").value;

            if(email == ""){
                alert("Preencha o campo e-mail");
            }
            else if (senha == ""){
                alert("Preencha o campo senha");
            }
            else if(nome == ""){
                alert("Preencha o campo nome");
            }
            else if (cpf == ""){
                alert("Preencha o campo CPF");
            }
            else if(rg == ""){
                alert("Preencha o campo RG");
            }
            else if (telefone == ""){
                alert("Preencha o campo telefone");
            }
            else if(data == ""){
                alert("Preencha o campo data");
            }
        }
    </script>
</head>


<body class="fonte" background="../Imagens/Fundo.jpg">


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
    
    <form class="needs-validation" novalidate method="POST" action="CadastroParte2.php">

    <h4>Dados Pessoais</h4>
        <div class="row"> 
            <!-- Campo NOME -->
            <div class="col-md-12 col-sm-12">
                <label for="name">Nome completo: </label><br>
                    <input type="text" class="form-control" name="nome" required placeholder="Digite seu Nome">
                    <div class="valid-feedback">Ok!</div>
                    <div class="invalid-feedback">Campo Obrigatório!</div>
            </div>
            <!-- Campo CPF -->
            <div class="col-md-6 col-sm-12">	
                    <label for="CPF">CPF: </label><br>
                    <input type="text" class="form-control" name="cpf" placeholder="Digite seu CPF">
            </div>
            <!-- Campo RG -->
             <div class="col-md-6 col-sm-12">	
                    <label for="RG">RG: </label><br>
                    <input type="text" class="form-control" name="rg" placeholder="Digite seu RG">
            </div>
            <!-- Campo Email -->
            <div class="col-md-12 col-sm-12">	
                    <label for="mail">E-mail: </label><br>
                    <input type="text" class="form-control" name="email" placeholder="Digite seu e-mail">
            </div>	
            <!-- Campo Data nascimento -->
            <div class="col-md-6 col-sm-12">	
                    <label for="date">Date de nascimento: </label><br>
                    <input type="text" class="form-control" name="dataNascimento" placeholder="Digite sua Data de Nasc.">
            </div>
            <!-- Campo Senha -->
            <div class="col-md-6 col-sm-12">	
                    <label for="date">Senha: </label><br>
                    <input type="password" class="form-control" name="Senha" placeholder="Digite seu Senha">
            </div>
            <!-- Campo Telefone 1 -->
            <div class="col-md-6 col-sm-12">
                    <label for="nascimento">Telefone 1: </label><br>
                    <input type="text"  class="form-control" name="telefone1" placeholder="Digite seu Telefone">
            </div>   
            <!-- Campo Telefone 2 -->
            <div class="col-md-6 col-sm-12">
                    <label for="nascimento">Telefone 2: </label><br>
                    <input type="text"  class="form-control" name="telefone2" placeholder="Digite seu Telefone">
            </div>
            <div class="row" mt-3>
                <a href="CadastroParte2.php">
                    <button type="submit" class="btn btn-outline-success" >Avançar</button>
                </a>
            </div>
        </div>
    </div>
    </form>


    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>
</html>