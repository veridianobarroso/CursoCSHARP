// See https://aka.ms/new-console-template for more information
public class Program {
    public static void Main(){
         
    Pessoa pessoa = new Pessoa();
    pessoa.Name = "Capivara";
    Console.WriteLine(pessoa.Name);
    
    pessoa.Sacar();

    //
    Banco conta = new Banco();
    conta.Saca(100.0);
    conta.Deposita(250.0);

    conta.saldo -= 100.0;
    //Nada nos impede de acessar os atributos diretamente
    // em um arquivo
    conta.saldo -= 100.0;
    // em outro arquivo
    conta.saldo -= 371.0;
    // e se a cada saque realizado, o banco cobrará 0.10 centavos.

    // Sabemos o quê esse método faz pelo seu nome. 
    // Mas como ele faz o trabalho dele só saberemos se entrarmos
    // dentro de sua implementação. 
    // Portanto, o comportamento está encapsulado nesse método.

    // método -> private
    // agora para escrevermos ou lermos o valor de um atributo precisamos utilizar os métodos
    // public int Numero { get; set; }

    // get é público e pode ser acessado por qualquer classe
    // set é privado e por isso só pode ser usado pela conta.

    }
}

