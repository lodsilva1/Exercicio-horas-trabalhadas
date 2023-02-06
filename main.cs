using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    
    Double salario_hora, horas_trabalhadas, horas_extras, salario_hora_extra, salario_extra, salario_total;
string entrada;
    
    Console.WriteLine ("horas trabalhadas no mês");
    entrada = Console.ReadLine ();
        horas_trabalhadas = Double.Parse(entrada);

    horas_extras = horas_trabalhadas - 150.0;

    salario_hora_extra = salario_hora * 1.5;

    salario_extra = salario_hora_extra * horas_extras;

    salario_total = (salario_hora_extra * horas_extras)
    
  }
}