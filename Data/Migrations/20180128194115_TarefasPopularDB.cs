﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tarefas.Data.Migrations
{
    public partial class TarefasPopularDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Tarefas(DataConclusao,EstaCompleta,Nome) VALUES ('20171010 08:00:00', 1 , 'Tarefa 1')");
            migrationBuilder.Sql("INSERT INTO Tarefas(DataConclusao,EstaCompleta,Nome) VALUES ('20171011 08:00:00', 0 , 'Tarefa 2')");
            migrationBuilder.Sql("INSERT INTO Tarefas(DataConclusao,EstaCompleta,Nome) VALUES ('20171005 08:00:00', 0 , 'Tarefa 3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Tabelas");
        }
    }
}