namespace module_10.University.Domain.Lectures
{
    public class LectureFacade : ILectureFacade
    {
        private readonly ILectureRepository _repository;

        public LectureFacade(ILectureRepository repository)
        {
            _repository = repository;
        }

        public void Create(Lecture lecture)
        {
            _repository.Create(lecture);
        }

        public Lecture Get(int id)
        {
            return _repository.Get(id);
        }

        public void Update(Lecture lecture)
        {
            _repository.Update(lecture);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}