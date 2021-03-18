namespace ToDoList.Repository
{
    public class BaseRepository 
    {
        protected readonly ApplicationDbContext DbContext;
        public BaseRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

    }
}
