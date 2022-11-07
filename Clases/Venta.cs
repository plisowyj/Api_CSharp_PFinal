namespace Api_GestionCH.Clases
{
    public class Venta
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }

        public Venta(int id, string comentarios)
        {
            this.Id = id;
            this.Comentarios = comentarios;
        }
    }
}
