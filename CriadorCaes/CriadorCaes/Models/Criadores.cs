using System.ComponentModel.DataAnnotations;

namespace CriadorCaes.Models {
    
    /// <summary>
    /// Descrição dos criadores de animais
    /// </summary>
    public class Criadores {

        public Criadores() {
            // Inicializar a lista de animais do criador
            ListaAnimais    = new HashSet<Animais>();
            ListaRacas      = new HashSet<Racas>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do criador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(50)]
        public string Nome { get; set; }

        /// <summary>
        /// Nome comercial do criador
        /// </summary>
        [StringLength(50)]
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada do criador
        /// </summary>
         [StringLength(60)]
        public string Morada { get; set; }

        /// <summary>
        /// Código postal do criador
        /// </summary>
        [RegularExpression("[1-9][0-9]{3}-[0-9]{3}(){1,3}[A-Z -ÇÀÁÉÍÓÚÃÂÊÎÔÛ]+", ErrorMessage = " O {0} deve ter o formato")]
        [StringLength(40)]
        public string CodPostal { get; set; }
        
        /// <summary>
        /// Email do criador
        /// </summary>
        [EmailAddress]

        public string Email { get; set; }

        /// <summary>
        /// Número de telmóvel do criador
        /// </summary>
        [Display(Name = "Telemóvel")]
        //{0} - nome do atributo
        [StringLength(14,MinimumLength =5,ErrorMessage = "Deve escrever {1} digitos no número {0} ")]
        [RegularExpression("((+|00)351)?9[1236][0123456789]{7}")]

        public string Telemovel { get; set; }

        /*
         * Relacionamentos associados ao Criador
         */

        /// <summary>
        /// Lista dos animais associados ao Criador
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }

        public ICollection<Racas> ListaRacas { get; set; }

    }
}
