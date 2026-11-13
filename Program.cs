
using System.ComponentModel;
using System.Security.AccessControl;
using RelacionamentosEntreObjetos;

// Veiculo veiculo = new Veiculo("Audi", "A3");
// veiculo.ExibirMarcaModelo();

// Carro carro =new Carro(4);
// carro.Marca = "BMW";
// carro.Modelo = "320I";
// carro.ExibirInformacoesCarro();

// Moto moto =new Moto(1200);
// moto.Marca ="Honda";
// moto.Modelo = "Africa TWIN";
// moto.ExibirCilindradas();



// CursoOnline curso = new CursoOnline("ADS", 700 , 2400);
// curso.ExibirCursoOnline();


// ProdutoDigital Produto = new Ebook("As historia de peppa pig", 19m, 250);


// ProdutoDigital Curso = new CursoOnline("Curso de C#", 199m, 40);

// Produto.ExibirProduto();
// Curso.ExibirProduto();




// JogoDigital jogo1 = new JogoDigital("Cyberpunk 2077", "PC", 70.5);
// JogoFisico jogo2 = new JogoFisico("The Last of Us Part II", "PS4", true);

// jogo1.ExibirInformacoes();
// jogo2.ExibirInformacoes();




// Notificacao email = new NotificacaoEmail();
// Notificacao sms = new NotificacaoSMS();
// Notificacao push = new NotificacaoPush  ();
// Notificacao notificacao = new Notificacao();

// email.Enviar();
// sms.Enviar();
// push.Enviar();
// notificacao.Enviar();




// List<Entrega> listaDeEntregas = new List<Entrega>
//         {
//             new EntregaExpressa(15.5), // 15.5 km
//             new EntregaEconomica(15.5),
//             new RetiradaLocal()
//         };

//         Console.WriteLine("--- Cálculo de Fretes ---");
//         foreach (Entrega entrega in listaDeEntregas)
//         {
//             Console.WriteLine($"Distância: {entrega.Distancia} km");
//             Console.WriteLine($"Valor do Frete: R$ {entrega.CalcularFrete():F2}\n");
//         }


//Relatorio meuRelatorio = new Relatorio();
//Contrato meuContrato = new Contrato();

//Console.WriteLine("--- Ações do Relatório ---");
        
//meuRelatorio.Imprimir(); 
//meuRelatorio.Exportar(); 

//Console.WriteLine("\n--- Ações do Contrato ---");
        
//meuContrato.Imprimir();


//Notebook meuNotebook = new Notebook("mac book air", "676767", 16);
//Smartphone meuSmartphone = new Smartphone("iPhone 15 Pro", "IMEI-123456", 256);

//Console.WriteLine("--- Informações do Notebook ---");
//meuNotebook.ExibirInformacoes();

//Console.WriteLine("\n--- Informações do Smartphone ---");
//meuSmartphone.ExibirInformacoes();

// List<Animal> animais = new List<Animal>
//         {
            
//             new Cachorro("Snow"),
//             new Gato("Tom"),
//             new Passaro("flamengo")
//         };

//         Console.WriteLine("--- Apresentação dos Animais ---");

//         foreach (Animal animal in animais)
//         {
//             animal.Apresentar();
//             animal.EmitirSom();
//             Console.WriteLine("-------------------");
//         }




        // IArmazenavel sistemaArmazenamento;

        // Console.WriteLine("Arquivo de Texto");
        
        // sistemaArmazenamento = new ArquivoTexto();

        // sistemaArmazenamento.Salvar("Registo de Logs");
        // sistemaArmazenamento.Ler();

        // Console.WriteLine("\nTeste com Banco de Dados");
       
        // sistemaArmazenamento = new BancoDados();
        
        // sistemaArmazenamento.Salvar("Ficha de Cliente");
        // sistemaArmazenamento.Ler();



        Hospedagem minhaHospedagem = new Hospedagem("Hotel Mar e Sol");
        Consultoria minhaConsultoria = new Consultoria("Consultoria Financeira XP");

        Console.WriteLine("---Teste de Contratos---");
        
        IContratavel servicoContratado;

        servicoContratado = minhaHospedagem;
        servicoContratado.Contratar(); 

        servicoContratado = minhaConsultoria;
        servicoContratado.Contratar(); 

        Console.WriteLine("\n---Teste de Cancelamento---");
        
        minhaHospedagem.Cancelar();















