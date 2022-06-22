using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Principal
{
    public partial class Categoria
    {
        public override string ToString()
        {
            string str = $"{this.Nome}";
            return str;
        }
    }
    public partial class Cliente
    {
        public override string ToString()
        {
            string str = $"{this.Nome} ({this.Telemovel}) - {this.NIF}";
            return str;
        }
    }

    public partial class ItemMenu
    {
        public override string ToString()
        {
            string str = $"{this.Nome} - {this.Preco}�";
            return str;
        }
    }

    public partial class Morada
    {
        public override string ToString()
        {
            string str = $"{this.Rua}, {this.CodPostal}, {this.Cidade}, {this.Pais}";
            return str;
        }
    }

    public partial class MetodoPagamento
    {
        public override string ToString()
        {
            string str = $"{this.Nome}";
            return str;
        }
    }

    public partial class Pedido
    {
        public override string ToString()
        {
            string str = $"Pedido nº {this.Id} ({this.ValorTotal} €) - Cliente {this.Cliente.Nome}";
            return str;
        }
    }

    public partial class Restaurante
    {
        public override string ToString()
        {
            string str = $"{this.Nome}";
            return str;
        }
    }

    public partial class Trabalhador
    {
        public override string ToString()
        {
            string str = $"{this.Nome}";
            return str;
        }
    }

    public partial class Estado
    {
        public override string ToString()
        {
            string str = $"{this.Pronto}";
            return str;
        }
    }

    public partial class Pagamento
    {
        public override string ToString()
        {
            string str = $"{this.Valor} via {this.MetodoPagamento.Nome}";
            return str;
        }
    }

}
