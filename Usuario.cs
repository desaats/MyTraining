using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining
{
    public class Usuario
    {
        private string Nome {  get; set; }
        private int Idade {  get; set; }
        private int Matricula {  get; set; }
        private string Email {  get; set; }

        public Usuario(string nome, int idade, int matricula, string email)
        {
            Nome = nome;
            Idade = idade;
            Matricula = matricula;
            Email = email;
        }
       public void Imprimir()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Email: {Email}");
        }
    }

}
