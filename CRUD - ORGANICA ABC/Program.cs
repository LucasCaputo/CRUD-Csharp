using System;
using System.Threading;
using System.Windows.Forms;

namespace ERP_OrgânicaABC
{
    class Program
    {
        static int index = 0;
        static ConsoleKeyInfo infoTecla;
        static Random random = new Random();
        static DialogResult fim, resultFuncionario, resultCliente, resultProduto, resulVenda;
        static string[,] matrizFuncionario = new string[15, 7], matrizCliente = new string[50, 7], matrizProduto = new string[30, 7];
        static int contFuncionario = 3, contCliente = 3, contProduto = 15;
        static string[,] AuxFuncionario = new string[5, 7], AuxCliente = new string[5, 7], AuxProduto = new string[5, 7];
        static int linha = -1;
        static int[,] matrizEstoque = new int[15, 2];

        static void TelaAbertura()
        {
            Console.Title = "ORGÂNICA ABC";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|=|==========================================================================================================================================|=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|       000000000000                                          000000                                                                       |=|");
            Console.WriteLine("|=|      00000000000000                                       0000  0000                        0000                                         |=|");
            Console.WriteLine("|=|     0000000000000000                                    0000      0000                      0000                                         |=|");
            Console.WriteLine("|=|     0000        0000                                                                                                                     |=|");
            Console.WriteLine("|=|     0000        0000   0000     0000     0000000000       0000000000       0000  000000     0000     0000000000       0000000000         |=|");
            Console.WriteLine("|=|     0000        0000   0000   000000    000000000000     000000000000      0000 00000000    0000    000000000000     000000000000        |=|");
            Console.WriteLine("|=|     0000        0000   0000  0000000   0000      0000   0000      0000     000000    0000   0000   0000      0000   0000      0000       |=|");
            Console.WriteLine("|=|     0000        0000   00000000        0000      0000   0000      0000     0000      0000   0000   0000             0000      0000       |=|");
            Console.WriteLine("|=|     0000        0000   00000           0000      0000   0000      0000     0000      0000   0000   0000             0000      0000       |=|");
            Console.WriteLine("|=|     0000000000000000   0000            0000      0000   0000      0000     0000      0000   0000   0000      0000   0000      0000       |=|");
            Console.WriteLine("|=|      00000000000000    0000             0000000000000    00000000000000    0000      0000   0000    000000000000     00000000000000      |=|");
            Console.WriteLine("|=|       000000000000     0000              000000000000     000000000  000   0000      0000   0000     0000000000       000000000  000     |=|");
            Console.WriteLine("|=|                                                  0000                                                                                    |=|");
            Console.WriteLine("|=|                                                  0000                                                                                    |=|");
            Console.WriteLine("|=|                                        0000      0000                                                                                    |=|");
            Console.WriteLine("|=|                                         000000000000                                                                                     |=|");
            Console.WriteLine("|=|                                          0000000000                                                                                      |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                              0000000000      00000000000         0000000000                                              |=|");
            Console.WriteLine("|=|                                             000000000000     000000000000       000000000000                                             |=|");
            Console.WriteLine("|=|                                            00000000000000    0000000000000     00000000000000                                            |=|");
            Console.WriteLine("|=|                                           0000        0000   0000      0000   0000        0000                                           |=|");
            Console.WriteLine("|=|                                           0000        0000   0000      0000   0000        0000                                           |=|");
            Console.WriteLine("|=|                                           0000        0000   0000     0000    0000                                                       |=|");
            Console.WriteLine("|=|                                           0000000000000000   000000000000     0000                                                       |=|");
            Console.WriteLine("|=|                                           0000000000000000   000000000000     0000                                                       |=|");
            Console.WriteLine("|=|                                           0000        0000   0000     0000    0000        0000                                           |=|");
            Console.WriteLine("|=|                                           0000        0000   0000      0000   0000        0000                                           |=|");
            Console.WriteLine("|=|                                           0000        0000   0000      0000    00000000000000                                            |=|");
            Console.WriteLine("|=|                                           0000        0000   0000000000000      000000000000                                             |=|");
            Console.WriteLine("|=|                                           0000        0000   000000000000        0000000000                                              |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|==========================================================================================================================================|=|");
            Console.ResetColor();
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine(" \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                Aguarde.....");
            Thread.Sleep(3000);
            Console.Clear();
        }
        static void TelaCarregamento()
        {
            
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                 Carregando.....");
            Console.WriteLine("                                                                      {0}%", random.Next(0, 6));
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  ");
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                 Carregando.....");
            Console.WriteLine("                                                                      {0}%", random.Next(15, 26));
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                             ");
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                 Carregando.....");
            Console.WriteLine("                                                                      {0}%", random.Next(35, 46));
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                          ");
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                 Carregando.....");
            Console.WriteLine("                                                                      {0}%", random.Next(55, 66));
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                       ");
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                 Carregando.....");
            Console.WriteLine("                                                                      {0}%", random.Next(75, 86));
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                                                                                                    ");
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                 Carregando.....");
            Console.WriteLine("                                                                      {0}%", 100);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("                                                                                                                                                ");
            Thread.Sleep(3000);
            Console.ResetColor();


        }
        static string PedeNome()
        {
            string usuario;

            Console.Write("Informe seu usuário: ");

            usuario = Console.ReadLine().ToLower();

            return usuario;
        }
        static bool validaUsuario(string usuario, string[,] matrizFuncionario)
        {
            for (int i = 0; i < matrizFuncionario.GetLength(0); i++)
            {
                if (matrizFuncionario[i, 4] == usuario)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }
        static string PedeSenha()
        {
            string senha;

            Console.Write("Informe sua senha: ");

            senha = Console.ReadLine().ToLower();

            return senha;
        }
        static bool validaSenha(string[,] matrizFuncionario)
        {
            for (int j = 0; j < 3; j++)
            {
                if (validaSenha(PedeSenha(), matrizFuncionario) == true)
                {
                    Console.WriteLine("Senha Válida");
                    return true;
                }
                else
                {
                    Console.WriteLine("Senha Errada, Repita");
                }
            }
            return false;
        }
        static bool validaSenha(string senha, string[,] matrizFuncionario)
        {
            if (matrizFuncionario[index, 5] == senha)
            {
                return true;
            }
            return false;
        }
        static void erroLogin()
        {
            Console.WriteLine("Você foi bloqueado, o sistema será finalizado");
            Thread.Sleep(2500);
            TelaFinalizacao();
        }
        static bool AcessoUsuário()
        {
            Console.Title = "LOGIN";

            for (int i = 0; i < 3; i++)
            {
                if (validaUsuario(PedeNome(), matrizFuncionario) == true)
                {
                    Console.WriteLine("Usuário Liberado");
                    return true;

                }
                else
                {
                    Console.WriteLine("Usuário inválido, Repita");
                }
            }
            return false;
        }
        static void MenuPrincipal()
        {
            do
            {
                Console.Title = "MENU PRINCIPAL";
                Console.Clear();
                Console.WriteLine("|=|==========================================     MENU PRINCIPAL     ==========================================|=|");
                Console.WriteLine("|=|                                                                                                            |=|");
                Console.WriteLine("|=|     F2     |=|     Gestão de Funcionários                                                                  |=|");
                Console.WriteLine("|=|     F3     |=|     Gestão de Clientes                                                                      |=|");
                Console.WriteLine("|=|     F4     |=|     Gestão Financeira                                                                       |=|");
                Console.WriteLine("|=|     F5     |=|     Gestão de Produtos                                                                      |=|");
                Console.WriteLine("|=|     F6     |=|     Vendas                                                                                  |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.WriteLine("|=|     F1     |=|     Ajuda                                                                                   |=|");
                Console.WriteLine("|=|     ESC    |=|     Finalizar Programa                                                                      |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.Write("Digite a opção desejada: ");
                infoTecla = Console.ReadKey();

                switch (infoTecla.Key)
                {
                    case ConsoleKey.F1:
                        {
                            AjudaMenuPrincipal();
                        }
                        break;
                    case ConsoleKey.F2:
                        {
                            SubMenuFuncionario();
                        }
                        break;
                    case ConsoleKey.F3:
                        {
                            SubMenuCliente();
                        }
                        break;
                    case ConsoleKey.F4:
                        {
                            SubMenuFinanceiro();
                        }
                        break;
                    case ConsoleKey.F5:
                        {
                            SubMenuProduto();
                        }
                        break;
                    case ConsoleKey.F6:
                        {
                            Venda();
                        }
                        break;
                    case ConsoleKey.Escape:
                        {
                            fim = MessageBox.Show("Tem certeza que quer finalizar o programa?", "Finalizar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (fim == DialogResult.No)
                            {
                                MenuPrincipal();
                            }
                            else if (fim == DialogResult.Yes)
                            {
                                TelaFinalizacao();

                            }
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Tecla digitada é inválida.");
                            Console.WriteLine("Pressione Enter para prosseguir.");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (infoTecla.Key != ConsoleKey.F1 && infoTecla.Key != ConsoleKey.F2 && infoTecla.Key != ConsoleKey.F3 &&
                    infoTecla.Key != ConsoleKey.F4 && infoTecla.Key != ConsoleKey.F5 && infoTecla.Key != ConsoleKey.Escape);
        }
        static void AjudaMenuPrincipal()
        {
            Console.Title = "AJUDA MENU PRINCIPAL";
            Console.Clear();
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                             GESTÃO DE FUNCIONÁRIOS                                             |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F2 para acessar o Sub Menu de Gestão de Funcionários e todas as suas funcionalidades.         |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                               GESTÃO DE CLIENTES                                               |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F3 para acessar o Sub Menu de Gestão de Clientes e todas as suas funcionalidades.             |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                               GESTÃO FINANCEIRA                                                |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F4 para acessar o Sub Menu de Gestão Financeira e todas as suas funcionalidades.              |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                               GESTÃO DE PRODUTOS                                               |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F5 para acessar o Sub Menu de Gestão de Produtos e todas as suas funcionalidades.             |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|Pressione a tecla ESC para sair do programa.                                                                    |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                  Pressione qualquer tecla para sair da Ajuda.                                  |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.ReadKey();
            MenuPrincipal();
        }
        static void SubMenuFuncionario()
        {
            do
            {
                Console.Title = "SUBMENU FUNCIONÁRIOS";
                Console.Clear();
                Console.WriteLine("|=|=======================================     SUBMENU FUNCIONÁRIOS     =======================================|=|");
                Console.WriteLine("|=|                                                                                                            |=|");
                Console.WriteLine("|=|     F2     |=|     Cadastro de Funcionários                                                                |=|");
                Console.WriteLine("|=|     F3     |=|     Editar e Excluir Funcionários                                                           |=|");
                Console.WriteLine("|=|     F4     |=|     Consultar Funcionários                                                                  |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.WriteLine("|=|     F1     |=|     Ajuda                                                                                   |=|");
                Console.WriteLine("|=|     ESC    |=|     Retornar para MENU PRINCIPAL                                                            |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.Write("Digite a opção desejada: ");
                infoTecla = Console.ReadKey();

                switch (infoTecla.Key)
                {
                    case ConsoleKey.F1:
                        {
                            AjudaSubMenuFuncionario();
                        }
                        break;
                    case ConsoleKey.F2:
                        {
                            CadastroFuncionario();
                        }
                        break;
                    case ConsoleKey.F3:
                        {
                            EditaFuncionario();
                        }
                        break;
                    case ConsoleKey.F4:
                        {
                            ConsultaFuncionario();
                        }
                        break;

                    case ConsoleKey.Escape:
                        {
                            MenuPrincipal();
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Tecla digitada é inválida.");
                            Console.WriteLine("Pressione Enter para prosseguir.");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (infoTecla.Key != ConsoleKey.F1 && infoTecla.Key != ConsoleKey.F2 && infoTecla.Key != ConsoleKey.F3 &&
                    infoTecla.Key != ConsoleKey.F4 && infoTecla.Key != ConsoleKey.F5 && infoTecla.Key != ConsoleKey.Escape);
        }
        static void AjudaSubMenuFuncionario()
        {
            Console.Title = "AJUDA SUBMENU FUNCIONÁRIOS";
            Console.Clear();
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                            CADASTRO DE FUNCIONÁRIOS                                            |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F2 para cadastrar um novo funcionário.                                                        |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                              EDITAR FUNCIONÁRIOS                                               |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F3 para editar um funcionário.                                                                |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                              EXCLUIR FUNCIONÁRIOS                                              |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F4 para excluir um funcionário.                                                               |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                             CONSULTAR FUNCIONÁRIOS                                             |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F5 para consultar as informações de um funcionário.                                           |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|Pressione a tecla ESC para retornar ao Menu Principal.                                                          |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                  Pressione qualquer tecla para sair da Ajuda.                                  |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.ReadKey();
            SubMenuFuncionario();
        }

        static void SubMenuCliente()
        {
            do
            {
                Console.Title = "SUBMENU CLIENTES";
                Console.Clear();
                Console.WriteLine("|=|=========================================     SUBMENU CLIENTES     =========================================|=|");
                Console.WriteLine("|=|                                                                                                            |=|");
                Console.WriteLine("|=|     F2     |=|     Cadastro de Clientes                                                                    |=|");
                Console.WriteLine("|=|     F3     |=|     Editar e Exclui Clientes                                                                |=|");
                Console.WriteLine("|=|     F4     |=|     Consultar Clientes                                                                      |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.WriteLine("|=|     F1     |=|     Ajuda                                                                                   |=|");
                Console.WriteLine("|=|     ESC    |=|     Retornar para MENU PRINCIPAL                                                            |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.Write("Digite a opção desejada: ");
                infoTecla = Console.ReadKey();

                switch (infoTecla.Key)
                {
                    case ConsoleKey.F1:
                        {
                            AjudaSubMenuCliente();
                        }
                        break;
                    case ConsoleKey.F2:
                        {
                            CadastroCliente();
                        }
                        break;
                    case ConsoleKey.F3:
                        {
                            EditaCliente();
                        }
                        break;
                    case ConsoleKey.F4:
                        {
                            ConsultaCliente();
                        }
                        break;

                    case ConsoleKey.Escape:
                        {
                            MenuPrincipal();
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Tecla digitada é inválida.");
                            Console.WriteLine("Pressione Enter para prosseguir.");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (infoTecla.Key != ConsoleKey.F1 && infoTecla.Key != ConsoleKey.F2 && infoTecla.Key != ConsoleKey.F3 &&
                    infoTecla.Key != ConsoleKey.F4 && infoTecla.Key != ConsoleKey.F5 && infoTecla.Key != ConsoleKey.Escape);
        }
        static void AjudaSubMenuCliente()
        {
            Console.Title = "AJUDA SUBMENU CLIENTES";
            Console.Clear();
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                              CADASTRO DE CLIENTES                                              |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F2 para cadastrar um novo cliente.                                                            |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                                EDITAR CLIENTES                                                 |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F3 para editar um cliente.                                                                    |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                                EXCLUIR CLIENTES                                                |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F4 para excluir um cliente.                                                                   |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                               CONSULTAR CLIENTES                                               |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F5 para consultar as informações de um cliente.                                               |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|Pressione a tecla ESC para retornar ao Menu Principal.                                                          |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                  Pressione qualquer tecla para sair da Ajuda.                                  |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.ReadKey();
            SubMenuCliente();
        }

        static void SubMenuProduto()
        {
            do
            {
                Console.Title = "SUBMENU GESTÃO DE PRODUTOS";
                Console.Clear();
                Console.WriteLine("|=|====================================     SUBMENU GESTÃO DE PRODUTOS     ====================================|=|");
                Console.WriteLine("|=|                                                                                                            |=|");
                Console.WriteLine("|=|     F2     |=|     Cadastro de Produtos                                                                    |=|");
                Console.WriteLine("|=|     F3     |=|     Editar e Exclui Produtos                                                                |=|");
                Console.WriteLine("|=|     F4     |=|     Consultar Produtos                                                                      |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.WriteLine("|=|     F1     |=|     Ajuda                                                                                   |=|");
                Console.WriteLine("|=|     ESC    |=|     Retornar para MENU PRINCIPAL                                                            |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.Write("Digite a opção desejada: ");
                infoTecla = Console.ReadKey();

                switch (infoTecla.Key)
                {
                    case ConsoleKey.F1:
                        {
                            AjudaSubMenuProduto();
                        }
                        break;
                    case ConsoleKey.F2:
                        {
                            CadastroProduto();
                        }
                        break;
                    case ConsoleKey.F3:
                        {
                            EditaProduto();
                        }
                        break;
                    case ConsoleKey.F4:
                        {
                            ConsultaProduto();
                        }
                        break;

                    case ConsoleKey.Escape:
                        {
                            MenuPrincipal();
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Tecla digitada é inválida.");
                            Console.WriteLine("Pressione Enter para prosseguir.");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (infoTecla.Key != ConsoleKey.F1 && infoTecla.Key != ConsoleKey.F2 && infoTecla.Key != ConsoleKey.F3 &&
                    infoTecla.Key != ConsoleKey.F4 && infoTecla.Key != ConsoleKey.F5 && infoTecla.Key != ConsoleKey.Escape);
        }
        static void AjudaSubMenuProduto()
        {
            Console.Title = "AJUDA SUBMENU GESTÃO DE PRODUTOS";
            Console.Clear();
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                              CADASTRO DE PRODUTOS                                              |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F2 para cadastrar um novo produto.                                                            |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                                EDITAR PRODUTOS                                                 |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F3 para editar um produto.                                                                    |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                                EXCLUIR PRODUTOS                                                |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F4 para excluir um produto.                                                                   |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                               CONSULTAR PRODUTOS                                               |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F5 para consultar as informações de um produto.                                               |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|Pressione a tecla ESC para retornar ao Menu Principal.                                                          |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                  Pressione qualquer tecla para sair da Ajuda.                                  |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.ReadKey();
            SubMenuProduto();
        }

        static void SubMenuFinanceiro()
        {
            do
            {
                Console.Title = "SUBMENU GESTÃO FINANCEIRA";
                Console.Clear();
                Console.WriteLine("|=|====================================     SUBMENU GESTÃO FINANCEIRA     =====================================|=|");
                Console.WriteLine("|=|                                                                                                            |=|");
                Console.WriteLine("|=|     F2     |=|     Relatório financeiro de vendas mensal                                                   |=|");
                Console.WriteLine("|=|     F3     |=|     Relatório financeiro de vendas do dia                                                   |=|");
                Console.WriteLine("|=|     F4     |=|     Relatório financeiro de vendas por cliente                                              |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.WriteLine("|=|     F1     |=|     Ajuda                                                                                   |=|");
                Console.WriteLine("|=|     ESC    |=|     Retornar para MENU PRINCIPAL                                                            |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.Write("Digite a opção desejada: ");
                infoTecla = Console.ReadKey();

                switch (infoTecla.Key)
                {
                    case ConsoleKey.F1:
                        {
                            AjudaSubMenuFinanceiro();
                        }
                        break;
                    case ConsoleKey.F2:
                        {

                        }
                        break;
                    case ConsoleKey.F3:
                        {

                        }
                        break;
                    case ConsoleKey.F4:
                        {

                        }
                        break;
                    case ConsoleKey.Escape:
                        {
                            MenuPrincipal();
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Tecla digitada é inválida.");
                            Console.WriteLine("Pressione Enter para prosseguir.");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (infoTecla.Key != ConsoleKey.F1 && infoTecla.Key != ConsoleKey.F2 && infoTecla.Key != ConsoleKey.F3 &&
                    infoTecla.Key != ConsoleKey.F4 && infoTecla.Key != ConsoleKey.Escape);
        }
        static void AjudaSubMenuFinanceiro()
        {
            Console.Title = "AJUDA SUBMENU GESTÃO FINANCEIRA";
            Console.Clear();
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                     RELATÓRIO FINANCEIRO DE VENDAS MENSAL                                      |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F2 para abrir um relatório de vendas do mês.                                                  |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                     RELATÓRIO FINANCEIRO DE VENDAS DO DIA                                      |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F3 para abrir um relatório de vendas do dia.                                                  |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                   RELATÓRIO FINANCEIRO DE VENDAS POR CLIENTE                                   |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|Pressione a tecla F4 para buscar um relatório de vendas de um cliente.                                          |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|Pressione a tecla ESC para retornar ao Menu Principal.                                                          |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("                                                                                                                      ");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                  Pressione qualquer tecla para sair da Ajuda.                                  |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.ReadKey();
            SubMenuFinanceiro();
        }

        static void CadastroFuncionario()
        {
            string senha, repeatsenha;
            int codigoFuncionario = 5002;
            resultFuncionario = DialogResult.Yes;
            Console.Title = "CADASTRO DE FUNCIONÁRIOS";
            while (resultFuncionario == DialogResult.Yes)
            {
                Console.Clear();

                matrizFuncionario[contFuncionario, 0] = Convert.ToString(codigoFuncionario);
                Console.Write("Digite o nome do funcionário: ");
                matrizFuncionario[contFuncionario, 1] = Console.ReadLine().ToUpper();
                Console.Write("Digite o CPF do funcionário: ");
                matrizFuncionario[contFuncionario, 2] = Console.ReadLine();
                Console.Write("Digite o cargo do funcionário: ");
                matrizFuncionario[contFuncionario, 3] = Console.ReadLine().ToUpper();
                Console.Write("Digite o login do funcionário: ");
                matrizFuncionario[contFuncionario, 4] = Console.ReadLine().ToLower();
                Console.Write("Digite a senha do funcionário: ");
                senha = Console.ReadLine();
                Console.Write("Digite a senha novamente: ");
                repeatsenha = Console.ReadLine();
                codigoFuncionario++;
                if (senha != repeatsenha)
                {
                    while (senha != repeatsenha)
                    {

                        Console.WriteLine("[ERRO] As senhas são diferentes");
                        Console.Write("Digite a senha do funcionário: ");
                        senha = Console.ReadLine();
                        Console.Write("Digite a senha novamente: ");
                        repeatsenha = Console.ReadLine();
                    }
                }
                matrizFuncionario[contFuncionario, 5] = senha;
                resultFuncionario = MessageBox.Show("Gostaria de cadastrar outro funcionário?", "Cadastro Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                contFuncionario++;
                if (resultFuncionario == DialogResult.No)
                {
                    SubMenuFuncionario();
                }
            }
        }
        static void ConsultaFuncionario()
        {

            string busca;
            do
            {
                Console.Clear();

                Console.Title = "CONSULTA FUNCIONÁRIO";
                Console.Clear();
                Console.WriteLine("|=|====================================     CONSULTAR FUNCIONÁRIO:   ==========================================|=|");
                Console.WriteLine("|=|                                                                                                            |=|");
                Console.WriteLine("|=|     F2     |=|     NOME                                                                                    |=|");
                Console.WriteLine("|=|     F3     |=|     CPF                                                                                     |=|");
                Console.WriteLine("|=|     F4     |=|     Listar todos os funcionários                                                            |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.WriteLine("|=|     ESC    |=|     Retornar para SUB MENU FUNCIONÁRIO                                                      |=|");
                Console.WriteLine("|=|============================================================================================================|=|");


                infoTecla = Console.ReadKey();
            } while (infoTecla.Key != ConsoleKey.F2 && infoTecla.Key != ConsoleKey.F3 && infoTecla.Key != ConsoleKey.F4 && infoTecla.Key != ConsoleKey.Escape);

            switch (infoTecla.Key)
            {
                case ConsoleKey.F2:
                    {
                        Console.Clear();
                        Console.Write("Digite o nome do funcionário para pesquisar: ");
                        busca = Console.ReadLine().ToUpper();
                        for (int i = 0; i < matrizFuncionario.GetLength(0); i++)
                        {
                            if (matrizFuncionario[i, 1] == busca)
                            {
                                Console.WriteLine("Funcionário encontrado!");
                                Console.WriteLine("Código: {0}\tNome: {1}\tCPF: {2}\tCargo: {3}\tLogin: {4}\tSituação: {5}", matrizFuncionario[i, 0], matrizFuncionario[i, 1], matrizFuncionario[i, 2], matrizFuncionario[i, 3], matrizFuncionario[i, 4], matrizFuncionario[i, 6]);
                            }
                        }
                        Console.ReadKey();
                        ConsultaFuncionario();
                    }
                    break;
                case ConsoleKey.F3:
                    {
                        Console.Write("Digite o CPF do funcionário para pesquisar: ");
                        busca = Console.ReadLine();
                        for (int i = 0; i < matrizFuncionario.GetLength(0); i++)
                        {
                            if (matrizFuncionario[i, 2] == busca)
                            {
                                Console.WriteLine("Funcionário encontrado!");
                                Console.WriteLine("Código: {0}\tNome: {1}\tCPF: {2}\tCargo: {3}\tLogin: {4}", matrizFuncionario[i, 0], matrizFuncionario[i, 1], matrizFuncionario[i, 2], matrizFuncionario[i, 3], matrizFuncionario[i, 4]);
                                break;
                            }
                        }

                        Console.ReadKey();
                        ConsultaFuncionario();
                    }
                    break;
                case ConsoleKey.F4:
                    {
                        Console.Clear();
                        for (int i = 0; i < matrizFuncionario.GetLength(0); i++)
                        {
                            if (matrizFuncionario[i, 1] != null)
                            {
                                Console.WriteLine("Código: {0}\tNome: {1}\tCPF: {2}\tCargo: {3}\tLogin: {4}\tSituação: {5}", matrizFuncionario[i, 0], matrizFuncionario[i, 1], matrizFuncionario[i, 2], matrizFuncionario[i, 3], matrizFuncionario[i, 4], matrizFuncionario[i, 6]);
                            }
                        }
                        Console.WriteLine("Aperte qualquer tecla para voltar para o Sub Menu de Funcionário.");
                        Console.ReadKey();
                        SubMenuFuncionario();
                    }
                    break;
                case ConsoleKey.Escape:
                    {
                        SubMenuFuncionario();
                    }
                    break;
            }
        }
        static void EditaFuncionario()
        {
            string busca;
            Boolean ok = false;

            Console.Clear();
            Console.Write("Digite o nome do funcionário para pesquisar: ");
            busca = Console.ReadLine().ToUpper();
            for (int i = 0; i < matrizFuncionario.GetLength(0); i++)
            {
                if (matrizFuncionario[i, 1] == busca)
                {
                    ok = true;
                    AuxFuncionario = (string[,])matrizFuncionario.Clone();
                    busca = matrizFuncionario[i, 1];
                    linha = i;
                    Console.WriteLine("Funcionário encontrado!");
                    Console.WriteLine("Código: {0}\tNome: {1}\tCPF: {2}\tCargo: {3}\tLogin: {4}\tSituação: {5}", matrizFuncionario[i, 0], matrizFuncionario[i, 1], matrizFuncionario[i, 2], matrizFuncionario[i, 3], matrizFuncionario[i, 4], matrizFuncionario[i, 6]);
                    break;
                }
                if (i != linha)
                {

                    Console.WriteLine("Funcionário não encontrado! Tente novamente.");

                    Console.WriteLine("Digite ESC para voltar ao sub menu funcionários");
                    Console.WriteLine("Digite qualquer tecla para voltar a pesquisa de funcionário");
                    infoTecla = Console.ReadKey();


                    switch (infoTecla.Key)
                    {
                        case ConsoleKey.Escape:

                            SubMenuFuncionario();

                            break;
                    }

                    EditaFuncionario();
                }
            }

            if (ok == true)
            {
                resultFuncionario = MessageBox.Show("Gostaria de Editar esse funcionário?", "Editar Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultFuncionario == DialogResult.Yes)
                {
                    do
                    {
                        Console.WriteLine("|=|============================================================================================================|=|");
                        Console.WriteLine("|=|                                                                                                            |=|");
                        Console.WriteLine("|=|     F2     |=|     Editar Nome                                                                             |=|");
                        Console.WriteLine("|=|     F3     |=|     Editar CPF                                                                              |=|");
                        Console.WriteLine("|=|     F4     |=|     Editar Cargo                                                                            |=|");
                        Console.WriteLine("|=|     F5     |=|     Editar Login                                                                            |=|");
                        Console.WriteLine("|=|     F6     |=|     Editar Senha                                                                            |=|");
                        Console.WriteLine("|=|     F7     |=|     Excluir Funcionário                                                                     |=|");
                        Console.WriteLine("|=|============================================================================================================|=|");
                        Console.WriteLine("|=|     ESC    |=|     Retornar para SUB MENU FUNCIONÁRIO                                                      |=|");
                        Console.WriteLine("|=|============================================================================================================|=|");

                        Console.WriteLine("");

                        Console.Write("Digite a opção desejada: ");
                        infoTecla = Console.ReadKey();

                        Console.WriteLine("");


                        switch (infoTecla.Key)
                        {
                            case ConsoleKey.F2:
                                {
                                    Console.Write("Informe o novo nome do funcionário: ");
                                    AuxFuncionario[linha, 1] = Console.ReadLine().ToUpper();
                                    resultFuncionario = MessageBox.Show("Deseja realmente mudar o nome do funcionário?", "Editar Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                    if (resultFuncionario == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizFuncionario.GetLength(0); i++)
                                        {
                                            matrizFuncionario[i, 1] = AuxFuncionario[i, 1];
                                        }
                                    }
                                    else
                                    {
                                        SubMenuFuncionario();
                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu Funcionário");
                                    Console.ReadKey();
                                    SubMenuFuncionario();
                                }
                                break;
                            case ConsoleKey.F3:
                                {
                                    Console.Write("Informe o novo CPF do funcionário: ");
                                    AuxFuncionario[linha, 2] = Console.ReadLine();
                                    resultFuncionario = MessageBox.Show("Deseja realmente mudar o CPF do funcionário?", "Editar CPF Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                    if (resultFuncionario == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizFuncionario.GetLength(0); i++)
                                        {
                                            matrizFuncionario[i, 2] = AuxFuncionario[i, 2];
                                        }

                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu Funcionário");
                                    Console.ReadKey();
                                    SubMenuFuncionario();
                                }
                                break;
                            case ConsoleKey.F4:
                                {

                                    Console.Write("Informe o novo cargo do funcionário: ");
                                    AuxFuncionario[linha, 3] = Console.ReadLine().ToUpper();
                                    resultFuncionario = MessageBox.Show("Deseja realmente mudar o cargo do funcionário?", "Editar Cargo Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                    if (resultFuncionario == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizFuncionario.GetLength(0); i++)
                                        {
                                            matrizFuncionario[i, 3] = AuxFuncionario[i, 3];
                                        }

                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu Funcionário");
                                    Console.ReadKey();
                                    SubMenuFuncionario();
                                }
                                break;
                            case ConsoleKey.F5:
                                {

                                    Console.Write("Informe o novo login do funcionário: ");
                                    AuxFuncionario[linha, 4] = Console.ReadLine();
                                    resultFuncionario = MessageBox.Show("Deseja realmente mudar o login do funcionário?", "Editar Login Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                    if (resultFuncionario == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizFuncionario.GetLength(0); i++)
                                        {
                                            matrizFuncionario[i, 4] = AuxFuncionario[i, 4];
                                        }

                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu Funcionário");
                                    Console.ReadKey();
                                    SubMenuFuncionario();
                                }
                                break;
                            case ConsoleKey.F6:
                                {

                                    Console.Write("Informe a nova senha do funcionário: ");
                                    AuxFuncionario[linha, 5] = Console.ReadLine();
                                    resultFuncionario = MessageBox.Show("Deseja realmente mudar a senha do funcionário?", "Editar Senha Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                    if (resultFuncionario == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizFuncionario.GetLength(0); i++)
                                        {
                                            matrizFuncionario[i, 3] = AuxFuncionario[i, 3];
                                        }

                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu Funcionário");
                                    Console.ReadKey();
                                    SubMenuFuncionario();
                                }
                                break;
                            case ConsoleKey.F7:
                                {

                                    resultFuncionario = MessageBox.Show("Deseja realmente excluir o funcionário?", "Excluir Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    AuxFuncionario[linha, 6] = "Inativo";

                                    if (resultFuncionario == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizFuncionario.GetLength(0); i++)
                                        {
                                            matrizFuncionario[i, 6] = AuxFuncionario[i, 6];
                                        }

                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu Funcionário");
                                    Console.ReadKey();
                                    SubMenuFuncionario();

                                }
                                break;
                            case ConsoleKey.Escape:
                                {
                                    SubMenuFuncionario();
                                }
                                break;
                        }
                    } while (infoTecla.Key != ConsoleKey.F1 && infoTecla.Key != ConsoleKey.F2 && infoTecla.Key != ConsoleKey.F3 &&
                            infoTecla.Key != ConsoleKey.F4 && infoTecla.Key != ConsoleKey.F5 && infoTecla.Key != ConsoleKey.F6 && infoTecla.Key != ConsoleKey.F7 && infoTecla.Key != ConsoleKey.Escape);



                }
                else
                {
                    SubMenuFuncionario();
                }

            }
        }

        static void CadastroCliente()
        {
            int codigoCliente = 4;
            resultCliente = DialogResult.Yes;
            Console.Title = "CADASTRO DE CLIENTES";
            while (resultCliente == DialogResult.Yes)
            {
                Console.Clear();
                matrizCliente[contCliente, 0] = Convert.ToString(codigoCliente);
                Console.Write("Digite o nome do cliente: ");
                matrizCliente[contCliente, 1] = Console.ReadLine().ToUpper();
                Console.Write("Digite o telefone do cliente: ");
                matrizCliente[contCliente, 2] = Console.ReadLine();
                Console.Write("Digite o CPF do cliente: ");
                matrizCliente[contCliente, 3] = Console.ReadLine();
                Console.Write("Digite a cidade do cliente: ");
                matrizCliente[contCliente, 4] = Console.ReadLine().ToUpper();
                Console.Write("Digite o email do cliente: ");
                matrizCliente[contCliente, 5] = Console.ReadLine().ToLower();
                matrizCliente[contCliente, 6] = "Ativo";
                resultCliente = MessageBox.Show("Gostaria de cadastrar outro cliente?", "Cadastro Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                contCliente++;
                codigoCliente++;
                if (resultCliente == DialogResult.No)
                {
                    SubMenuCliente();
                }
            }
        }

        static void MenuConsultaCliente()
        {

            Console.Title = "CONSULTA CLIENTE";
            Console.Clear();
            Console.WriteLine("|=|====================================     CONSULTAR CLIENTE POR:   ==========================================|=|");
            Console.WriteLine("|=|                                                                                                            |=|");
            Console.WriteLine("|=|     F2     |=|     NOME                                                                                    |=|");
            Console.WriteLine("|=|     F3     |=|     CPF                                                                                     |=|");
            Console.WriteLine("|=|     F4     |=|     Listar todos os clientes                                                                |=|");
            Console.WriteLine("|=|============================================================================================================|=|");
            Console.WriteLine("|=|     ESC    |=|     Retornar para SUB MENU CIENTE                                                           |=|");
            Console.WriteLine("|=|============================================================================================================|=|");


        }

        static bool ConsultaClienteNome(string nome)
        {
            for (int i = 0; i < matrizCliente.GetLength(0); i++)
            {
                if (matrizCliente[i, 1] == nome)
                {
                    Console.WriteLine("Cliente encontrado!");
                    Console.WriteLine("Código: {0}\tNome: {1}\tTelefone: {2}\tCPF: {3}\tCidade: {4} \tE-mail: {5} \tSituação: {6}", matrizCliente[i, 0], matrizCliente[i, 1], matrizCliente[i, 2], matrizCliente[i, 3], matrizCliente[i, 4], matrizCliente[i, 5], matrizCliente[i, 6]);
                    return true;
                }            

            }
            return false;
        }

        static void ConsultaClienteCPF(string cpf)
        {
            for (int i = 0; i < matrizCliente.GetLength(0); i++)
            {
                if (matrizCliente[i, 2] == cpf)
                {
                    Console.WriteLine("Cliente encontrado!");
                    Console.WriteLine("Código: {0}\tNome: {1}\tTelefone: {2}\tCPF: {3}\tCidade: {4} \tE-mail: {5} \tSituação: {6}", matrizCliente[i, 0], matrizCliente[i, 1], matrizCliente[i, 2], matrizCliente[i, 3], matrizCliente[i, 4], matrizCliente[i, 5], matrizCliente[i, 6]);
                }
            }
        }

        static void ConsultaClienteTodos()
        {
            for (int i = 0; i < matrizCliente.GetLength(0); i++)
            {
                if (matrizCliente[i, 0] != null)
                {
                    Console.WriteLine("Código: {0}\tNome: {1}\tTelefone: {2}\tCPF: {3}\tCidade: {4} \tE-mail: {5} \tSituação: {6}", matrizCliente[i, 0], matrizCliente[i, 1], matrizCliente[i, 2], matrizCliente[i, 3], matrizCliente[i, 4], matrizCliente[i, 5], matrizCliente[i, 6]);
                }
            }
        }

        static void ConsultaCliente()
        {
            string busca;
            do
            {
                Console.Clear();
                MenuConsultaCliente();
                infoTecla = Console.ReadKey();
            } while (infoTecla.Key != ConsoleKey.F2 && infoTecla.Key != ConsoleKey.F3 && infoTecla.Key != ConsoleKey.F4 && infoTecla.Key != ConsoleKey.Escape);

            switch (infoTecla.Key)
            {
                case ConsoleKey.F2:
                    {

                        Console.Write("Digite o nome do cliente para pesquisar: ");
                        busca = Console.ReadLine().ToUpper();
                        ConsultaClienteNome(busca);
                        Console.ReadKey();
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu consultas");
                        ConsultaCliente();
                    }
                    break;
                case ConsoleKey.F3:
                    {
                        Console.Write("Digite o CPF do cliente para pesquisar: ");
                        busca = Console.ReadLine();
                        ConsultaClienteCPF(busca);
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu consultas");
                        Console.ReadKey();
                        ConsultaCliente();
                    }
                    break;
                case ConsoleKey.F4:
                    {

                        ConsultaClienteTodos();                        
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu consultas");
                        Console.ReadKey();
                        ConsultaCliente();
                    }
                    break;
                case ConsoleKey.Escape:
                    {
                        SubMenuCliente();
                    }
                    break;
            }
        }
        static void SubMenuEditaCliente()
        {
            Console.WriteLine("|=|============================================================================================================|=|");
            Console.WriteLine("|=|                                                                                                            |=|");
            Console.WriteLine("|=|     F2     |=|     Editar Nome                                                                             |=|");
            Console.WriteLine("|=|     F3     |=|     Editar Telefone                                                                         |=|");
            Console.WriteLine("|=|     F4     |=|     Editar CPF                                                                              |=|");
            Console.WriteLine("|=|     F5     |=|     Editar Cidade                                                                           |=|");
            Console.WriteLine("|=|     F6     |=|     Editar Email                                                                            |=|");
            Console.WriteLine("|=|     F7     |=|     Excluir Cliente                                                                         |=|");
            Console.WriteLine("|=|============================================================================================================|=|");
            Console.WriteLine("|=|     ESC    |=|     Retornar para SUB MENU CLIENTE                                                          |=|");
            Console.WriteLine("|=|============================================================================================================|=|");

          

        }

        static void EditaCliente()
        {
            string busca;
          
            Console.Write("\nDigite o nome do cliente que deseja editar ou excluir: ");
            busca = Console.ReadLine().ToUpper();
            if (ConsultaClienteNome(busca) == false)
            {
                Console.WriteLine("Cliente não encontrado! Tente novamente.");
                Console.WriteLine("Digite ESC para voltar ao sub menu cliente");
                Console.WriteLine("Digite qualquer tecla para voltar a pesquisa de cliente");
                infoTecla = Console.ReadKey();


                switch (infoTecla.Key)
                {
                    case ConsoleKey.Escape:

                        SubMenuCliente();

                        break;
                }

                EditaCliente();
            }
            else {              

                    do
                    {
                        SubMenuEditaCliente();
                        Console.Write("\nDigite a opção desejada: ");
                        infoTecla = Console.ReadKey();                    

                        switch (infoTecla.Key)
                        {
                            case ConsoleKey.F2:
                                {
                                    Console.Write("\nInforme o novo nome do cliente: ");
                                    string alteracao = Console.ReadLine().ToUpper();
                                    resultCliente = MessageBox.Show("Deseja realmente mudar o nome do cliente?", "Editar Nome do Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                if (resultCliente == DialogResult.Yes)
                                {

                                    for (int i = 0; i < matrizCliente.GetLength(0); i++)
                                    {
                                        matrizCliente[i, 1] = alteracao.ToUpper();

                                        Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu cliente");
                                        Console.ReadKey();
                                        SubMenuCliente();

                                    }
                                }
                            }
                            break;
                            case ConsoleKey.F3:
                                {
                                    Console.Write("\nInforme o novo telefone do cliente: ");
                                    string alteracao = Console.ReadLine().ToUpper();
                                    resultCliente = MessageBox.Show("Deseja realmente mudar o telefone do cliente?", "Editar Telefone do Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                if (resultCliente == DialogResult.Yes)
                                {

                                    for (int i = 0; i < matrizCliente.GetLength(0); i++)
                                    {
                                        matrizCliente[i, 2] = alteracao;

                                        Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu cliente");
                                        Console.ReadKey();
                                        SubMenuCliente();

                                    }
                                }
                            }
                            break;
                            case ConsoleKey.F4:
                                {

                                    Console.Write("\nInforme o novo CPF do cliente: ");
                                    string alteracao = Console.ReadLine().ToUpper();
                                    resultCliente = MessageBox.Show("Deseja realmente mudar o CPF do cliente?", "Editar CPF do Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                if (resultCliente == DialogResult.Yes)
                                {

                                    for (int i = 0; i < matrizCliente.GetLength(0); i++)
                                    {
                                        matrizCliente[i, 3] = alteracao;

                                        Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu cliente");
                                        Console.ReadKey();
                                        SubMenuCliente();

                                    }
                                }
                            }
                            break;
                            case ConsoleKey.F5:
                                {

                                    Console.Write("\nInforme o nova cidade do cliente: ");
                                    string alteracao = Console.ReadLine().ToUpper();
                                    resultCliente = MessageBox.Show("Deseja realmente mudar a cidade do cliente?", "Editar Cidade do Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                    if (resultCliente == DialogResult.Yes)
                                    {

                                        for (int i = 0; i < matrizCliente.GetLength(0); i++)
                                        {                                           
                                                matrizCliente[i, 4] = alteracao.ToUpper();

                                                Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu cliente");
                                                Console.ReadKey();
                                                SubMenuCliente();                                         

                                        }
                                    }
                                }
                                break;
                            case ConsoleKey.F6:
                                {

                                    Console.Write("\nInforme o novo email do cliente: ");
                                    string alteracao = Console.ReadLine();
                                    resultCliente = MessageBox.Show("Deseja realmente mudar o e-mail do cliente?", "Editar E-mail do Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                if (resultCliente == DialogResult.Yes)
                                {

                                    for (int i = 0; i < matrizCliente.GetLength(0); i++)
                                    {
                                        matrizCliente[i, 5] = alteracao;

                                        Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu cliente");
                                        Console.ReadKey();
                                        SubMenuCliente();

                                    }
                                }
                            }
                            break;
                            case ConsoleKey.F7:
                                {
                                    resultCliente = MessageBox.Show("Deseja realmente excluir o cliente?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    string alteracao = "Inativo";

                                    if (resultCliente == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizCliente.GetLength(0); i++)
                                        {
                                            matrizCliente[i, 6] = alteracao;

                                            Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu cliente");
                                            Console.ReadKey();
                                            SubMenuCliente();
                                        }
                                    }                                   
                                }
                                break;
                            case ConsoleKey.Escape:
                                {
                                    SubMenuCliente();
                                }
                                break;
                        }
                    } while (infoTecla.Key != ConsoleKey.F1 && infoTecla.Key != ConsoleKey.F2 && infoTecla.Key != ConsoleKey.F3 &&
                            infoTecla.Key != ConsoleKey.F4 && infoTecla.Key != ConsoleKey.F5 && infoTecla.Key != ConsoleKey.F6 && infoTecla.Key != ConsoleKey.F7 && infoTecla.Key != ConsoleKey.Escape);
            }
        }
        static void CadastroProduto()
        {
            resultProduto = DialogResult.Yes;
            Console.Title = "CADASTRO DE PRODUTOS";
            while (resultProduto == DialogResult.Yes)
            {
                Console.Clear();

                Console.Write("Digite o código do produto: ");
                matrizProduto[contProduto, 0] = Console.ReadLine().ToUpper();
                Console.Write("Digite o nome do produto: ");
                matrizProduto[contProduto, 1] = Console.ReadLine().ToUpper();
                Console.Write("Digite a descrição do produto: ");
                matrizProduto[contProduto, 2] = Console.ReadLine();
                Console.Write("Digite a quantidade em estoque: ");
                matrizProduto[contProduto, 3] = Console.ReadLine();
                Console.Write("Digite o valor do produto: ");
                matrizProduto[contProduto, 4] = Console.ReadLine();
                Console.Write("Digite a categoria do produto: ");
                matrizProduto[contProduto, 5] = Console.ReadLine().ToUpper();
                resultProduto = MessageBox.Show("Gostaria de cadastrar outro produto?", "Cadastro Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                contProduto++;
                matrizProduto[contProduto, 6] = "Ativo";
                if (resultProduto == DialogResult.No)
                {
                    SubMenuProduto();
                }
            }
        }
        static void ConsultaProduto()
        {

            string busca;
            do
            {
                Console.Clear();

                Console.Title = "CONSULTA CLIENTE";
                Console.Clear();
                Console.WriteLine("|=|====================================     CONSULTAR PRODUTO:       ==========================================|=|");
                Console.WriteLine("|=|                                                                                                            |=|");
                Console.WriteLine("|=|     F2     |=|     NOME                                                                                    |=|");
                Console.WriteLine("|=|     F3     |=|     CÓDIGO                                                                                  |=|");
                Console.WriteLine("|=|     F4     |=|     Listar todos os Produtos                                                                |=|");
                Console.WriteLine("|=|============================================================================================================|=|");
                Console.WriteLine("|=|     ESC    |=|     Retornar para SUB MENU PRODUTO                                                          |=|");
                Console.WriteLine("|=|============================================================================================================|=|");


                infoTecla = Console.ReadKey();
            } while (infoTecla.Key != ConsoleKey.F2 && infoTecla.Key != ConsoleKey.F3 && infoTecla.Key != ConsoleKey.F4 && infoTecla.Key != ConsoleKey.Escape);

            switch (infoTecla.Key)
            {
                case ConsoleKey.F2:
                    {
                        Console.Clear();
                        Console.Write("Digite o nome do produto para pesquisar: ");
                        busca = Console.ReadLine().ToUpper();
                        for (int i = 0; i < matrizProduto.GetLength(0); i++)
                        {
                            if (matrizProduto[i, 1] == busca)
                            {
                                Console.WriteLine("Produto encontrado!");
                                Console.WriteLine("Código: {0}\tNome: {1}\tDescrição: {2}\tEstoque: {3}\tPreço: {4}\tCategoria: {5}\tSituação: {6}", matrizProduto[i, 0], matrizProduto[i, 1], matrizProduto[i, 2], matrizProduto[i, 3], matrizProduto[i, 4], matrizProduto[i, 5], matrizProduto[i, 6]);
                            }
                        }
                        Console.ReadKey();
                        ConsultaProduto();
                    }
                    break;
                case ConsoleKey.F3:
                    {
                        Console.Write("Digite o código do produto para pesquisar: ");
                        busca = Console.ReadLine();
                        for (int i = 0; i < matrizProduto.GetLength(0); i++)
                        {
                            if (matrizProduto[i, 0] == busca)
                            {
                                Console.WriteLine("Produto encontrado!");
                                Console.WriteLine("Código: {0}\tNome: {1}\tDescrição: {2}\tEstoque: {3}\tPreço: {4}\tCategoria: {5}", matrizProduto[i, 0], matrizProduto[i, 1], matrizProduto[i, 2], matrizProduto[i, 3], matrizProduto[i, 4], matrizProduto[i, 5]);
                            }
                        }
                        Console.ReadKey();
                        ConsultaProduto();
                    }
                    break;
                case ConsoleKey.F4:
                    {
                        Console.Clear();
                        for (int i = 0; i < matrizProduto.GetLength(0); i++)
                        {
                            if (matrizProduto[i, 0] != null)
                            {
                                Console.WriteLine("Código: {0}\tNome: {1}\tDescrição: {2}\tEstoque: {3}\tPreço: {4}\tCategoria: {5}", matrizProduto[i, 0], matrizProduto[i, 1], matrizProduto[i, 2], matrizProduto[i, 3], matrizProduto[i, 4], matrizProduto[i, 5]);
                            }
                        }
                        Console.WriteLine("Aperte qualquer tecla para voltar para o Sub Menu de Produto.");
                        Console.ReadKey();
                        ConsultaProduto();
                    }
                    break;
                case ConsoleKey.Escape:
                    {
                        SubMenuProduto();
                    }
                    break;
            }
        }
        static void EditaProduto()
        {
            string busca;
            Boolean ok = false;

            Console.Clear();
            Console.Write("Digite o nome do produto para pesquisar: ");
            busca = Console.ReadLine().ToUpper();
            for (int i = 0; i < matrizProduto.GetLength(0); i++)
            {
                if (matrizProduto[i, 1] == busca)
                {
                    ok = true;
                    AuxProduto = (string[,])matrizProduto.Clone();
                    busca = matrizProduto[i, 1];
                    linha = i;
                    Console.WriteLine("Produto encontrado!");
                    Console.WriteLine("Código: {0}\tNome: {1}\tDescrição: {2}\tEstoque: {3}\tValor: {4}\tCategoria: {5} \tSituação: {6}", matrizProduto[i, 0], matrizProduto[i, 1], matrizProduto[i, 2], matrizProduto[i, 3], matrizProduto[i, 4], matrizProduto[i, 5], matrizProduto[i, 6]);
                    break;
                }
                if (i != linha)
                {

                    Console.WriteLine("Produto não encontrado! Tente novamente.");

                    Console.WriteLine("Digite ESC para voltar ao sub menu cliente");
                    Console.WriteLine("Digite qualquer tecla para voltar a pesquisa de cliente");
                    infoTecla = Console.ReadKey();


                    switch (infoTecla.Key)
                    {
                        case ConsoleKey.Escape:

                            SubMenuProduto();

                            break;
                    }

                    EditaProduto();
                }
            }

            if (ok == true)
            {
                resultProduto = MessageBox.Show("Gostaria de Editar esse produto?", "Editar Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultProduto == DialogResult.Yes)
                {
                    do
                    {
                        Console.WriteLine("|=|============================================================================================================|=|");
                        Console.WriteLine("|=|                                                                                                            |=|");
                        Console.WriteLine("|=|     F2     |=|     Editar Nome                                                                             |=|");
                        Console.WriteLine("|=|     F3     |=|     Editar Descrição                                                                        |=|");
                        Console.WriteLine("|=|     F4     |=|     Editar Estoque                                                                          |=|");
                        Console.WriteLine("|=|     F5     |=|     Editar Valor                                                                            |=|");
                        Console.WriteLine("|=|     F6     |=|     Editar Categoria                                                                        |=|");
                        Console.WriteLine("|=|     F7     |=|     Excluir Produto                                                                         |=|");
                        Console.WriteLine("|=|============================================================================================================|=|");
                        Console.WriteLine("|=|     ESC    |=|     Retornar para SUB MENU PRODUTO                                                          |=|");
                        Console.WriteLine("|=|============================================================================================================|=|");

                        Console.WriteLine("");

                        Console.Write("Digite a opção desejada: ");
                        infoTecla = Console.ReadKey();

                        Console.WriteLine("");


                        switch (infoTecla.Key)
                        {
                            case ConsoleKey.F2:
                                {
                                    Console.Write("Informe o novo nome do produto: ");
                                    AuxProduto[linha, 1] = Console.ReadLine().ToUpper();
                                    resultProduto = MessageBox.Show("Deseja realmente mudar o nome do produto?", "Editar Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                    if (resultProduto == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizProduto.GetLength(0); i++)
                                        {
                                            matrizProduto[i, 1] = AuxProduto[i, 1];
                                        }
                                    }
                                    else
                                    {
                                        SubMenuProduto();
                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu produto");
                                    Console.ReadKey();
                                    SubMenuProduto();
                                }
                                break;
                            case ConsoleKey.F3:
                                {
                                    Console.Write("Informe o nova descrição do produto: ");
                                    AuxProduto[linha, 2] = Console.ReadLine();
                                    resultProduto = MessageBox.Show("Deseja realmente mudar a descrição do produto?", "Editar descrição do produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                    if (resultProduto == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizProduto.GetLength(0); i++)
                                        {
                                            matrizProduto[i, 2] = AuxProduto[i, 2];
                                        }

                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu produto");
                                    Console.ReadKey();
                                    SubMenuProduto();
                                }
                                break;
                            case ConsoleKey.F4:
                                {

                                    Console.Write("Informe o novo estoque do produto: ");
                                    AuxProduto[linha, 3] = Console.ReadLine().ToUpper();
                                    resultProduto = MessageBox.Show("Deseja realmente mudar o estoque do produto?", "Editar Estoque", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                    if (resultProduto == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizProduto.GetLength(0); i++)
                                        {
                                            matrizProduto[i, 3] = AuxProduto[i, 3];
                                        }

                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu produto");
                                    Console.ReadKey();
                                    SubMenuProduto();
                                }
                                break;
                            case ConsoleKey.F5:
                                {

                                    Console.Write("Informe o novo valor do produto: ");
                                    AuxProduto[linha, 4] = Console.ReadLine();
                                    resultProduto = MessageBox.Show("Deseja realmente mudar o valor do produto?", "Editar Valor do Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                    if (resultProduto == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizProduto.GetLength(0); i++)
                                        {
                                            matrizProduto[i, 4] = AuxProduto[i, 4];
                                        }

                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu produto");
                                    Console.ReadKey();
                                    SubMenuProduto();
                                }
                                break;
                            case ConsoleKey.F6:
                                {

                                    Console.Write("Informe a nova categoria do produto: ");
                                    AuxProduto[linha, 5] = Console.ReadLine();
                                    resultProduto = MessageBox.Show("Deseja realmente mudar a categoria do produto", "Editar Categoria Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                                    if (resultProduto == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizProduto.GetLength(0); i++)
                                        {
                                            matrizProduto[i, 3] = matrizProduto[i, 3];
                                        }

                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu produto");
                                    Console.ReadKey();
                                    SubMenuProduto();
                                }
                                break;
                            case ConsoleKey.F7:
                                {

                                    resultCliente = MessageBox.Show("Deseja realmente excluir o produto?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    AuxProduto[linha, 6] = "Inativo";

                                    if (resultCliente == DialogResult.Yes)
                                    {
                                        for (int i = 0; i < matrizProduto.GetLength(0); i++)
                                        {
                                            matrizProduto[i, 6] = AuxProduto[i, 6];
                                        }

                                    }

                                    Console.WriteLine("Alteração realizada com sucesso! Precione qualquer tecla para voltar ao submenu produto");
                                    Console.ReadKey();
                                    SubMenuProduto();

                                }
                                break;
                            case ConsoleKey.Escape:
                                {
                                    SubMenuProduto();
                                }
                                break;
                        }
                    } while (infoTecla.Key != ConsoleKey.F1 && infoTecla.Key != ConsoleKey.F2 && infoTecla.Key != ConsoleKey.F3 &&
                            infoTecla.Key != ConsoleKey.F4 && infoTecla.Key != ConsoleKey.F5 && infoTecla.Key != ConsoleKey.F6 && infoTecla.Key != ConsoleKey.F7 && infoTecla.Key != ConsoleKey.Escape);



                }
                else
                {
                    SubMenuProduto();
                }

            }
        }
        static void ExibirTodosProdutos()
        {
            for (int i = 0; i < matrizProduto.GetLength(0); i++)
            {
                if (matrizProduto[i, 0] != null)
                {
                    Console.WriteLine("|=| Código: {0}\tNome: {1}\tDescrição: {2}\tEstoque: {3}\tPreço: {4}\tCategoria: {5}", matrizProduto[i, 0], matrizProduto[i, 1], matrizProduto[i, 2], matrizProduto[i, 3], matrizProduto[i, 4], matrizProduto[i, 5]);
                }
            }

        }
        static void Venda()
        {
            string codigo, cpf;
            decimal valortotal = 0, valor, valorPago, troco;

            Console.Title = "VENDAS";
            Console.Clear();
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.WriteLine("|=|                                             EMISSÃO DE VENDAS                                                  |=|");
            Console.WriteLine("|=|                                                                                                                |=|");
            Console.WriteLine("|=|   ORGANICA ABC - FRUTAS, LEGUMES E VERDURAS                              TELEFONE: 31 9 9999-9999              |=|");
            Console.WriteLine("|=|                                                                          BARROCA - BELO HORIZONTE              |=|");
            Console.WriteLine("|=|================================================================================================================|=|");
            Console.Write("|=| Informe o CPF do cliente para iniciar a venda: ");
            cpf = Console.ReadLine();

            Console.Clear();

            for (int i = 0; i < matrizCliente.GetLength(0); i++)
            {
                if (matrizCliente[i, 3] == cpf)
                {
                    Console.Clear();
                    Console.WriteLine("|=|                                                                                                                |=|");
                    Console.WriteLine("|=|                                         USUÁRIO ENCONTRADO                                                     |=|");
                    Console.WriteLine("|=|================================================================================================================|=|");
                    Console.WriteLine("|=|Código: {0}                                                                                                    |=|", matrizCliente[i, 0]);
                    Console.WriteLine("|=|Nome: {0}                           Telefone:{1}                          |=|", matrizCliente[i, 1], matrizCliente[i, 2]);
                    Console.WriteLine("|=|CPF: {0}                            Cidade: {1}                           |=|", matrizCliente[i, 3], matrizCliente[i, 4]);
                    Console.WriteLine("|=|E-mail: {0}                         Situação: {1}                         |=|", matrizCliente[i, 5], matrizCliente[i, 6]);
                    Console.WriteLine("|=|================================================================================================================|=|");

                    ExibirTodosProdutos();

                    Console.WriteLine("|=|================================================================================================================|=|");

                    do
                    {
                        Console.Write("Informe o código do produto: ");
                        codigo = Console.ReadLine();

                        for (int j = 0; j < matrizProduto.GetLength(0); j++)
                        {

                            if (matrizProduto[j, 0] == codigo)
                            {
                                Console.WriteLine("{0}", matrizProduto[j, 1]);
                                Console.WriteLine("Digite a quantidade: ");
                                matrizEstoque[j, 1] = Convert.ToInt32(Console.ReadLine());
                                valor = Convert.ToDecimal(matrizProduto[j, 4]) * Convert.ToDecimal(matrizEstoque[j, 1]);
                                valortotal += valor;

                                Console.WriteLine("Aperte ENTER para adquirir um novo produto, ou qualquer tecla para fechar a compra");
                                infoTecla = Console.ReadKey();

                            }


                        }
                    } while (infoTecla.Key == ConsoleKey.Enter);


                    Console.WriteLine("\nVALOR TOTAL DA COMPRA: {0}", valortotal);
                    Console.Write("\nDeseja confirmar a compra? Digite S ou N");
                    infoTecla = Console.ReadKey();

                    if (infoTecla.Key == ConsoleKey.S)
                    {
                        Console.Clear();
                        Console.Write("Informe o valor que o cliente está pagando: ");
                        valorPago = Convert.ToDecimal(Console.ReadLine());

                        if (valorPago >= valortotal)
                        {
                            troco = valorPago - valortotal;
                            Console.WriteLine("Troco = {0}", troco);

                        }
                        else
                        {
                            Console.WriteLine("Venda cancelada, valor não suficiente para realizar a compra");
                        }


                        resulVenda = MessageBox.Show("Deseja emitir outra venda?", "Emissão de Venda ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resulVenda == DialogResult.Yes)
                        {
                            Console.Clear();
                            Venda();
                        }
                        else
                        {
                            MenuPrincipal();
                        }

                    }

                    if (infoTecla.Key == ConsoleKey.N)
                    {
                        Console.WriteLine("\nCompra Cancelada, aperte qualquer tecla para voltar ao menu principal");
                        Console.ReadKey();
                        MenuPrincipal();
                    }
                }

            }

            for (int i = 0; i < matrizCliente.GetLength(0); i++)
            {
                if (matrizCliente[i, 3] != cpf)
                {
                    Console.Clear();
                    Console.WriteLine("Usuário não Encontrado");
                    Console.WriteLine("Clique em qualquer tecla para ir ao cadastro de clientes");
                    Console.ReadKey();
                    CadastroCliente();

                }
            }


        }

        static void TelaFinalizacao()
        {
            Console.Title = "ORGÂNICA ABC";
            Console.Clear();
            Console.WriteLine("|=|==========================================================================================================================================|=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                              0000000000      00000000000         0000000000                                              |=|");
            Console.WriteLine("|=|                                             000000000000     000000000000       000000000000                                             |=|");
            Console.WriteLine("|=|                                            00000000000000    0000000000000     00000000000000                                            |=|");
            Console.WriteLine("|=|                                           0000        0000   0000      0000   0000        0000                                           |=|");
            Console.WriteLine("|=|                                           0000        0000   0000      0000   0000        0000                                           |=|");
            Console.WriteLine("|=|                                           0000        0000   0000     0000    0000                                                       |=|");
            Console.WriteLine("|=|                                           0000000000000000   000000000000     0000                                                       |=|");
            Console.WriteLine("|=|                                           0000000000000000   000000000000     0000                                                       |=|");
            Console.WriteLine("|=|                                           0000        0000   0000     0000    0000        0000                                           |=|");
            Console.WriteLine("|=|                                           0000        0000   0000      0000   0000        0000                                           |=|");
            Console.WriteLine("|=|                                           0000        0000   0000      0000    00000000000000                                            |=|");
            Console.WriteLine("|=|                                           0000        0000   0000000000000      000000000000                                             |=|");
            Console.WriteLine("|=|                                           0000        0000   000000000000        0000000000                                              |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|                                                                                                                                          |=|");
            Console.WriteLine("|=|==========================================================================================================================================|=|");
            Thread.Sleep(1000);
        }

        static void BancodeDados()
        {
            matrizFuncionario[0, 0] = "0000";
            matrizFuncionario[0, 1] = "ADMINISTRADOR";
            matrizFuncionario[0, 2] = "000.000.000-00";
            matrizFuncionario[0, 3] = "PROPRIETÁRIO";
            matrizFuncionario[0, 4] = "admin";
            matrizFuncionario[0, 5] = "admin1234";
            matrizFuncionario[0, 6] = "Ativo";
            matrizFuncionario[1, 0] = "5000";
            matrizFuncionario[1, 1] = "FERNANDA";
            matrizFuncionario[1, 2] = "122.200.543-34";
            matrizFuncionario[1, 3] = "GERENTE ADMINISTRATIVO";
            matrizFuncionario[1, 4] = "fernanda";
            matrizFuncionario[1, 5] = "veludoauau0412";
            matrizFuncionario[1, 6] = "Ativo";
            matrizFuncionario[2, 0] = "5001";
            matrizFuncionario[2, 1] = "BRUNO";
            matrizFuncionario[2, 2] = "125.097.351-27";
            matrizFuncionario[2, 3] = "ESTOQUISTA";
            matrizFuncionario[2, 4] = "bruno";
            matrizFuncionario[2, 5] = "hempa420";
            matrizFuncionario[2, 6] = "Ativo";
            matrizCliente[0, 0] = "01";
            matrizCliente[0, 1] = "MARLON REIS";
            matrizCliente[0, 2] = "33987562332";
            matrizCliente[0, 3] = "130.388.518-59";
            matrizCliente[0, 4] = "TEÓFILO OTONI";
            matrizCliente[0, 5] = "marlon.reis@gmail.com";
            matrizCliente[0, 6] = "Ativo";
            matrizCliente[1, 0] = "02";
            matrizCliente[1, 1] = "BRUNO ROSA";
            matrizCliente[1, 2] = "35999244298";
            matrizCliente[1, 3] = "114.573.921-66";
            matrizCliente[1, 4] = "OLIVEIRA";
            matrizCliente[1, 5] = "bruno.rosa24@bandamole.com";
            matrizCliente[1, 6] = "Ativo";
            matrizCliente[2, 0] = "03";
            matrizCliente[2, 1] = "MARCELO SILVA";
            matrizCliente[2, 2] = "31997213344";
            matrizCliente[2, 3] = "054.495.123-64";
            matrizCliente[2, 4] = "BELO HORIZONTE";
            matrizCliente[2, 5] = "marcelosilva02@gmail.com";
            matrizCliente[2, 6] = "Ativo";
            matrizProduto[0, 0] = "01";
            matrizProduto[0, 1] = "BANANA";
            matrizProduto[0, 2] = "Caixa de banana 20Kg";
            matrizProduto[0, 3] = "50";
            matrizProduto[0, 4] = "60,00";
            matrizProduto[0, 5] = "FRUTA";
            matrizProduto[0, 6] = "Ativo";
            matrizProduto[1, 0] = "02";
            matrizProduto[1, 1] = "LARANJA";
            matrizProduto[1, 2] = "Saco de laranja 20Kg";
            matrizProduto[1, 3] = "50";
            matrizProduto[1, 4] = "30,00";
            matrizProduto[1, 5] = "FRUTA";
            matrizProduto[1, 6] = "Ativo";
            matrizProduto[2, 0] = "03";
            matrizProduto[2, 1] = "MAÇÃ";
            matrizProduto[2, 2] = "Caixa de Maçã 20Kg";
            matrizProduto[2, 3] = "50";
            matrizProduto[2, 4] = "120,00";
            matrizProduto[2, 5] = "FRUTA";
            matrizProduto[2, 6] = "Ativo";
            matrizProduto[3, 0] = "04";
            matrizProduto[3, 1] = "UVA";
            matrizProduto[3, 2] = "Caixa de uva 20Kg";
            matrizProduto[3, 3] = "50";
            matrizProduto[3, 4] = "220,00";
            matrizProduto[3, 5] = "FRUTA";
            matrizProduto[3, 6] = "Ativo";
            matrizProduto[4, 0] = "05";
            matrizProduto[4, 1] = "LIMÃO";
            matrizProduto[4, 2] = "Caixa de limão 20Kg";
            matrizProduto[4, 3] = "50";
            matrizProduto[4, 4] = "180,00";
            matrizProduto[4, 5] = "FRUTA";
            matrizProduto[4, 6] = "Ativo";
            matrizProduto[5, 0] = "06";
            matrizProduto[5, 1] = "COUVE";
            matrizProduto[5, 2] = "Caixa de couve 1Kg";
            matrizProduto[5, 3] = "50";
            matrizProduto[5, 4] = "10,00";
            matrizProduto[5, 5] = "VERDURA";
            matrizProduto[5, 6] = "Ativo";
            matrizProduto[6, 0] = "07";
            matrizProduto[6, 1] = "CEBOLINHA";
            matrizProduto[6, 2] = "Caixa de cebolinha 1Kg";
            matrizProduto[6, 3] = "50";
            matrizProduto[6, 4] = "40,00";
            matrizProduto[6, 5] = "VERDURA";
            matrizProduto[6, 6] = "Ativo";
            matrizProduto[7, 0] = "08";
            matrizProduto[7, 1] = "SALSINHA";
            matrizProduto[7, 2] = "Caixa de salsinha 1Kg";
            matrizProduto[7, 3] = "50";
            matrizProduto[7, 4] = "60,00";
            matrizProduto[7, 5] = "VERDURA";
            matrizProduto[7, 6] = "Ativo";
            matrizProduto[8, 0] = "09";
            matrizProduto[8, 1] = "ESPINAFRE";
            matrizProduto[8, 2] = "Caixa de espinafre 1Kg";
            matrizProduto[8, 3] = "50";
            matrizProduto[8, 4] = "80,00";
            matrizProduto[8, 5] = "VERDURA";
            matrizProduto[8, 6] = "Ativo";
            matrizProduto[9, 0] = "10";
            matrizProduto[9, 1] = "AGRIÃO";
            matrizProduto[9, 2] = "Caixa de agrião 1Kg";
            matrizProduto[9, 3] = "50";
            matrizProduto[9, 4] = "90,00";
            matrizProduto[9, 5] = "VERDURA";
            matrizProduto[9, 6] = "Ativo";
            matrizProduto[10, 0] = "11";
            matrizProduto[10, 1] = "CENOURA";
            matrizProduto[10, 2] = "Caixa de cenoura 20Kg";
            matrizProduto[10, 3] = "50";
            matrizProduto[10, 4] = "100,00";
            matrizProduto[10, 5] = "OUTROS";
            matrizProduto[10, 6] = "Ativo";
            matrizProduto[11, 0] = "12";
            matrizProduto[11, 1] = "BATATA";
            matrizProduto[11, 2] = "Caixa de batata 20Kg";
            matrizProduto[11, 3] = "50";
            matrizProduto[11, 4] = "100,00";
            matrizProduto[11, 5] = "OUTROS";
            matrizProduto[11, 6] = "Ativo";
            matrizProduto[12, 0] = "13";
            matrizProduto[12, 1] = "MANDIOCA";
            matrizProduto[12, 2] = "Caixa de mandioca 20Kg";
            matrizProduto[12, 3] = "50";
            matrizProduto[12, 4] = "40,00";
            matrizProduto[12, 5] = "OUTROS";
            matrizProduto[12, 6] = "Ativo";
            matrizProduto[13, 0] = "14";
            matrizProduto[13, 1] = "BETERRABA";
            matrizProduto[13, 2] = "Caixa de beterraba 20Kg";
            matrizProduto[13, 3] = "50";
            matrizProduto[13, 4] = "60,00";
            matrizProduto[13, 5] = "OUTROS";
            matrizProduto[13, 6] = "Ativo";
            matrizProduto[14, 0] = "15";
            matrizProduto[14, 1] = "CEBOLA";
            matrizProduto[14, 2] = "Caixa de cebola 20Kg";
            matrizProduto[14, 3] = "50";
            matrizProduto[14, 4] = "70,00";
            matrizProduto[14, 5] = "OUTROS";
            matrizProduto[14, 6] = "Ativo";
        }
        static void Main(string[] args)
        {
             BancodeDados();
             Console.SetWindowSize(145, 38);
             //TelaAbertura();
            // TelaCarregamento();

            if (AcessoUsuário() == true)
            {
                if (validaSenha(matrizFuncionario) == true)
                {
                    MenuPrincipal();
                }
                else
                {
                    erroLogin();
                }
            }
            else
            {
                erroLogin();
            }





        }
    }
}