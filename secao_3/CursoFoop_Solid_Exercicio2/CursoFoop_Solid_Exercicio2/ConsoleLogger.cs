﻿using System;

namespace CursoFoop_Solid_Exercicio2
{
    public class ConsoleLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
