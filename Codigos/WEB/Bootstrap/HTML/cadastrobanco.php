<?php
    session_start();
            include("../PHP/conexaoBD.php");
                try{

                    $nome = $_SESSION["nome"];
                    $cpf = $_SESSION["cpf"];
                    $rg = $_SESSION["rg"];
                    $email = $_SESSION["email"];
                    $dataNascimento = $_SESSION["dataNascimento"]; 
                    $Senha = $_SESSION["Senha"];
                    $telefone1 = $_SESSION["telefone1"];
                    $telefone2 = $_SESSION["telefone2"];
                    $Rua = $_POST["Rua"];
                    $number = $_POST["number"];
                    $Complet = $_POST["Complet"];
                    $Bairro = $_POST["Bairro"];
                    $city = $_POST["city"];
                    $Estado = $_POST["Estado"];
                    $CEP = $_POST["CEP"];


                    if ((trim($dataNascimento) == "") || (trim($nome) == "") || (trim($cpf) == "") || (trim($rg) == "")|| (trim($email) == "") || (trim($Senha) == "") || (trim($telefone1) == "")
                    || (trim($Rua) == "") || (trim($number) == "") || (trim($Bairro) == "") || (trim($city) == "") || (trim($Estado) == "") || (trim($CEP) == "")) {
                            echo "<span id='warning'>Nome, CPF, RG, Email, DataNascimento, Senha, Tefone1 e CEP completo são campos obrigatórios!</span>";
                        }
                        else {                  
                            $stmt = $pdo->prepare("select * from Cliente where email = :email");
                            $stmt->bindParam(':email', $email);
                            $stmt->execute();

                            $rows = $stmt->rowCount();

                                if ($rows <= 0) {
                                    $stmt = $pdo->prepare("insert into Cliente (nome, dataNascimento, CPF, RG, telefone1, telefone2, rua, numero, complemento, bairro, cidade, estado, cep, email, senha) values(:nome, :dataNascimento, :CPF, :RG, :telefone1, :telefone2, :rua, :numero, :complemento, :bairro, :cidade, :estado, :cep, :email, :senha)");
                                    $stmt->bindParam(':nome', $nome);
                                    $stmt->bindParam(':dataNascimento', $dataNascimento);
                                    $stmt->bindParam(':CPF', $cpf);
                                    $stmt->bindParam(':RG', $rg);
                                    $stmt->bindParam(':telefone1', $telefone1);
                                    $stmt->bindParam(':telefone2', $telefone2);
                                    $stmt->bindParam(':rua', $Rua);
                                    $stmt->bindParam(':numero', $number);
                                    $stmt->bindParam(':complemento', $Complet);
                                    $stmt->bindParam(':bairro', $Bairro);
                                    $stmt->bindParam(':cidade', $city);
                                    $stmt->bindParam(':estado', $Estado);
                                    $stmt->bindParam(':cep', $CEP);
                                    $stmt->bindParam(':email', $email);
                                    $stmt->bindParam(':senha', $Senha);
                                    
                                    $stmt->execute();

                                    echo "<span id='sucess'>Cliente Cadastrado!</span>";
                                    //limpar ssession (unset($_SESSION['name']));
                                    echo "<script type='text/javascript'> window.open('index.html', '_top');</script>";
                                } else {
                                     echo "<span id='error'>Email já existente!</span>";
                                }
                        }
                    }catch(PDOException $e) {
                    echo 'Error: ' . $e->getMessage();
                }
                $pdo = null;
?>