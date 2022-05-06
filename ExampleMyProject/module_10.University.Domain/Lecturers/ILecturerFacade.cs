namespace module_10.University.Domain.Lecturers
{
    public interface ILecturerFacade
    {
        void Create(Lecturer lecturer);
        
        Lecturer Get(int id);

        void Update(Lecturer lecturer);

        void Delete(int id);
    }
}