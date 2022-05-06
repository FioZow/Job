using System.Threading.Tasks;

namespace module_10.University.Domain.Students
{
    public interface IStudentRepository
    {
        void Create(Student student);
        
        Student Get(int id);

        void Update(Student student);

        void Delete(int id);
    }
}