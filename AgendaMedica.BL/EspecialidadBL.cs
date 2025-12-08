using System.Data;
using AgendaMedica.DAL;

namespace AgendaMedica.BL
{
    public class EspecialidadBL
    {
        EspecialidadDAL dal = new EspecialidadDAL();

        public DataTable Listar() => dal.Listar();
        public void Insertar(string nombre, string descripcion) => dal.Insertar(nombre, descripcion);
        public void Editar(int id, string nombre, string descripcion) => dal.Editar(id, nombre, descripcion);
        public void Eliminar(int id) => dal.Eliminar(id);
    }
}
