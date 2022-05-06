namespace module_10.University.Domain.Students
{
    public class StudentFacade : IStudentFacade
    {
        
        private readonly IStudentRepository _repository;

        public StudentFacade(IStudentRepository repository)
        {
            _repository = repository;
        }

        public void Create(Student student)
        {
            _repository.Create(student);
        }

        public Student Get(int id)
        {
            return _repository.Get(id);
        }

        public void Update(Student student)
        {
            _repository.Update(student);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}