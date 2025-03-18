namespace LibraryManagementSystem;

public static class BookLending
{
    public static DateTime CreationDate { get; set; }
    public static DateTime DueDate { get; set; }
    private static string BookId { get; set; }
    private static string MemberId { get; set; }
}
