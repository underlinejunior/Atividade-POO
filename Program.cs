using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {

            float valor_pag;
            Console.WriteLine("Informar Nome: ");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço: ");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Fisica(f) ou Juridica(j)? ");
            string var_tipo = Console.ReadLine();
            if (var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                Console.WriteLine("Informar RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Infomar Valor da Compra: ");
                valor_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(valor_pag);
                Console.WriteLine("-------Pessoa Física --------");
                Console.WriteLine("Nome: " + pf.nome);
                Console.WriteLine("Endereço: " + pf.endereco);
                Console.WriteLine("RG: " + pf.rg);
                Console.WriteLine("CPF: " + pf.cpf);
                Console.WriteLine("Valor Pago: " + pf.valor.ToString("C"));//C para colocar em formato de moeda
                Console.WriteLine("Imposto: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total: " + pf.total.ToString("C"));

            }
            else if(var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                Console.WriteLine("Informar CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Infomar Valor da Compra: ");
                valor_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(valor_pag);
                Console.WriteLine("-------Pessoa Juridica --------");
                Console.WriteLine("Nome: " + pj.nome);
                Console.WriteLine("Endereço: " + pj.endereco);
                Console.WriteLine("CNPJ: " + pj.cnpj);
                Console.WriteLine("IE: " + pj.ie);
                Console.WriteLine("Valor Pago: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total: " + pj.total.ToString("C"));
            }else{
                Console.WriteLine("Opção Inválida");
            }
        }
    }
}