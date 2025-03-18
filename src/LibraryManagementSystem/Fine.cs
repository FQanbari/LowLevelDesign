namespace LibraryManagementSystem;

public class Fine
{
    private DateTime CreationDate { get; set; }
    private string BookId { get; set; }
    private string MemberId { get; set; }
    private int FinePerDay { get; } = 1;

    public int CalculateFine(int days) => days * FinePerDay;
}
