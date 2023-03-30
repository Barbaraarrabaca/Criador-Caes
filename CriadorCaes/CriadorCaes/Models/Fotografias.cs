namespace CriadorCaes.Models
{
 /// <summary>
 /// Fotogarfias dos cães, nas suas actividades
 /// </summary>
    public class Fotografias{
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do ficheiro com a fotografia
        /// </summary>
        public string NomeFicheiro { get; set; }
        /// <summary>
        /// nome do Local onde a fotografia foi tirada
        /// </summary>
        public string Local { get; set; }
        /// <summary>
        /// data da fotografia
        /// </summary>
        public DateTime DataFotografia { get; set; }

    }
}
