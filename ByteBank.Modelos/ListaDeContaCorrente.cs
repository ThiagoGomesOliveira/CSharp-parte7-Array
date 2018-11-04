﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContaCorrente( int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }


        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
            Console.WriteLine($"Adicionando no índice {_proximaPosicao} conta {item.Agencia}/{item.Numero}");
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
                ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

                for (int i = 0; i < _itens.Length; i++)
                {
                    novoArray[i] = _itens[i];
                }

                _itens = novoArray;
            }

        }


    }
}