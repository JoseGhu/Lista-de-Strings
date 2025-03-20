using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        var datas = new List<string> { "23 de março de 2021", "14 de abril de 2022", "8 de novembro de 2023", "14 de janeiro de 2024", "30 de dezembro de 2025", "06 de Janeiro de 2026", "02 de Fevereiro de 2027" };

        var datasConvertidas = datas.Select(d => DateTime.ParseExact(d.Trim(), "d 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"))).ToList();

        datasConvertidas.ForEach(d => Console.WriteLine(d.ToString("dd/MM/yyyy")));

    }
}

