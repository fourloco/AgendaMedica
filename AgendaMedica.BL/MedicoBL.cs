using System.Data;
using AgendaMedica.DAL;

namespace AgendaMedica.BL
{
    public class MedicoBL
    {
        MedicoDAL dal = new MedicoDAL();

        public DataTable Listar() => dal.Listar();
        public void Insertar(string nombre, string telefono, string correo, int idEspecialidad)
            => dal.Insertar(nombre, telefono, correo, idEspecialidad);

        public void Editar(int id, string nombre, string telefono, string correo, int idEspecialidad)
            => dal.Editar(id, nombre, telefono, correo, idEspecialidad);

        public void Eliminar(int id) => dal.Eliminar(id);
    }
}
