﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3;

internal class FonteDados
{
    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
        {
            new Aluno () {Nome = "Maria", Nota = 8.75 },
            new Aluno () {Nome = "Manoel", Nota = 6.95 },
            new Aluno () { Nome = "Amanda", Nota = 7.25 },
            new Aluno () { Nome = "Carlos", Nota = 6.55 },
            new Aluno () { Nome = "Jaime", Nota = 8.50 },
            new Aluno () { Nome = "Débora", Nota = 5.95 },
            new Aluno () { Nome = "Alicia", Nota = 9.25 },
            new Aluno () { Nome = "Sandra", Nota = 5.55 },
            new Aluno () { Nome = "Marta", Nota = 7.85 },
            new Aluno () { Nome = "Sueli", Nota = 9.15 }
        };
        return alunos;
    }
}
