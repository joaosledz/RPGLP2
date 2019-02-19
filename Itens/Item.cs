using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos_Divinity.Itens
{
    class Item
    {
        private string nome { get; } //nome do item/equipamento/consumívle
        private string classes { get; } //qual profissão poder usar o item
        private string tipo { get; } //equipameno, poção, comida, texto, outros     
        private string categoria { get; } //normal, raro, lendário
        private Status atributos { get; set; } //mudar ou pegar status
    }
}
