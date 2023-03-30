namespace CriadorCaes.Models
{
    /// <summary>
    /// Dados dos criadores dos animais
    /// </summary>
    public class Criadores{

        public int Id { get; set; }

        /// <summary>
        /// Nome do criador
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Nome pelo qual o criador é conhecido
        /// </summary>
        public string NomeComercial { get; set; }
        /// <summary>
        /// morada do criador
        /// </summary>
        public string Morada { get; set; }
        /// <summary>
        /// codigo postal do criador
        /// </summary>
        public string CodPostal { get; set; }
        /// <summary>
        /// Email do criador
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Telemovel do criador
        /// </summary>
        public string Telemovel { get; set; }
    }
}
