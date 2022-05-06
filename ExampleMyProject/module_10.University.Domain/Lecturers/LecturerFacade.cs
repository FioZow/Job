namespace module_10.University.Domain.Lecturers
{
    public class LecturerFacade : ILecturerFacade
    {
        private readonly ILecturerRepository _repository;

        public LecturerFacade(ILecturerRepository repository)
        {
            _repository = repository;
        }

        public void Create(Lecturer lecturer)
        {
         _repository.Create(lecturer);   
        }

        public Lecturer Get(int id)
        {
            return _repository.Get(id);
        }

        public void Update(Lecturer lecturer)
        {
            _repository.Update(lecturer);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}