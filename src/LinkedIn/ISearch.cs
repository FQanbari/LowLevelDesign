namespace LinkedIn;

public interface ISearch
{
    List<Account> SearchAccount(string name);
    List<Job> SearchPost(Job job);
}
