using System.ComponentModel.DataAnnotations.Schema;

namespace CriadorCaes.Models {
    
    /// <summary>
    /// Descrição dos cães
    /// </summary>
    public class Animais {

        public Animais() { 
            ListaFotografias = new HashSet<Fotografias>();
        }

        public int Id { get; set; }

        /// <summary>
        /// Nome do cão/cadela
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Sexo do cão/cadela:
        /// F - Fêmea
        /// M - Macho
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// Data de nascimento do cão/cadela
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Data de aquisição do cão/cadela
        /// </summary>
        public DateTime DataCompra { get; set; }

        /// <summary>
        /// LOP de registo do cão/cadela
        /// </summary>
        public string NumLOP { get; set; }

        /*
         * Criação das chaves forasteiras 
         */

        /// <summary>
        /// FK para o Criador do cão/cadela
        /// </summary>
        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }
        public Criadores Criador { get; set; } // Efetivamente, esta é que é a FK.. chave forasteira

        /*
         * O uso de [anotadores] serve para formatar o comportamento
         * dos 'objetos' por ele referenciados.
         * Estes 'objetos' podem ser:
         * - atributos
         * - funções (métodos)
         * - classes
         */

        [ForeignKey(nameof(Raca))]
        public int RacaFK { get; set; }
        public Racas Raca { get; set; }

        public ICollection<Fotografias> ListaFotografias { get; set; }

    }
}
