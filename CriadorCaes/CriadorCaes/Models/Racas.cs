namespace CriadorCaes.Models {
    
    /// <summary>
    /// Descrição das raças de cães
    /// </summary>
    public class Racas {

        public Racas() { 
            ListaAnimais    = new HashSet<Animais>();
            ListaCriadores  = new HashSet<Criadores>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da raça
        /// </summary>
        public string Nome { get; set; }

        public ICollection<Animais> ListaAnimais { get; set; }

        public ICollection<Criadores> ListaCriadores { get; set; }

    }
}
