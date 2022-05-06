using System.Threading.Tasks;

namespace module_10.University.Domain.Lectures
{
    public interface ILectureRepository
    {
        void Create(Lecture lecture);
        
        Lecture Get(int id);

        void Update(Lecture lecture);

        void Delete(int id);
    }
}