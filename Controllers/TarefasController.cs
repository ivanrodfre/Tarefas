﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Models;
using Tarefas.Services;

namespace Tarefas.Controllers
{
    public class TarefasController : Controller
    {
        private readonly ITarefaItemService _tarefaService;

        public TarefasController(ITarefaItemService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        //Retornar listar de tarefas
        public async Task<IActionResult> Index()
        {

            var tarefas = await _tarefaService.GetItemAsync();

            var model = new TarefaViewModel();
            {
                model.TarefaItens = tarefas;
            }

            return View(model);
        }

        public IActionResult AdicionarItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarItemTarefa(TarefaItem tarefa)
        {

            if (ModelState.IsValid)
            {
                await _tarefaService.AdicionarItem(tarefa);
                return RedirectToAction(nameof(Index));
            }

            return View(tarefa);
        }


    }
}