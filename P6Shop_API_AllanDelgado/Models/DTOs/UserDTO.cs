namespace P6Shop_API_AllanDelgado.Models.DTOs
{
    public class UserDTO
    {
        //Un DTO (Data Transfer Object) es el método más usado 
        //para pasar estructuras entre un API y una APP (o cualquier otro UI) 
        //Se hace hace principalmente por dos razones: 

        //1. Para que el equipo de desarrollo del UI ( o posibles ingenierías inversas )
        // no entiendan la estructura de los models en el API.
        
        //2. simplificar objetos muy complejos, ya que es más rápido pasar la mínima data
        //requerida por los objetos json entre el app y el api.

        //3. Si es necesario volver a generar los modelos con el scaffold -f (porque hubo un 
        //cambio en la estrutura de una tabla por ejemplo) no es necesario cambiar nada en el
        //controller si la estructura del modelo cambíó y además habíamos hecho cambios en el 
        //modelo generado automáticame

        //NOTA: para efectos de ejemplificar el uso del DTO, voy a manejar los nombres
        //de propiedades en español. 

        public int IDUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;
        public string Contrasennia { get; set; } = null!;
        public string CorreoRespaldo { get; set; } = null!;
        public string NumeroTelefono { get; set; } = null!;
        public int IDRol { get; set; }
        public int IDPais { get; set; }
        public string RolDescripcion { get; set; } = null!;
        public string PaisNombre { get; set; } = null!;

        //No es necesario en todos los casos escribir las composiciones, este es uno. 

    }
}
