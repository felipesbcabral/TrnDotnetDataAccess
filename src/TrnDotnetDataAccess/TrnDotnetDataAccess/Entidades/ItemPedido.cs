﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrnDotnetDataAccess.Entidades
{
    public class ItemPedido
    {
        public Guid Id { get; private set; }
        public Pedido Pedido { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }

    }
}
