﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC.DTO
{
    class tblClienteDTO
    {
        private int id_cliente, tp_usuario;
        private string nome_cliente,cpf_cliente,nome_mae ;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Tp_usuario { get => tp_usuario; set => tp_usuario = value; }
     
   

        public string Cpf_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.cpf_cliente = value;
                }
                else
                {
                    throw new Exception("O campo CPF é obrigatório.");
                }

            }
            get { return this.cpf_cliente; }
        }

        public string Nome_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_cliente = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatório.");
                }

            }
            get { return this.nome_cliente; }
        }
        public string Nome_mae
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_mae = value;
                }
                else
                {
                    throw new Exception("O campo nome mae é obrigatório.");
                }

            }
            get { return this.nome_mae; }
        }

    }

}