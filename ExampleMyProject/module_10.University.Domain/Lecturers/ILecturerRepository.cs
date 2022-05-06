using System.Threading.Tasks;

namespace module_10.University.Domain.Lecturers
{
    public interface ILecturerRepository
    {
        void Create(Lecturer lecturer);
        
        Lecturer Get(int id);

        void Update(Lecturer lecturer);

        void Delete(int id);
    }
}