namespace westcoasteducation.api.ViewModels;

public class CourseDetailListViewModel
{
    public int Id { get; set; }
    public string Status { get; set; }
    public string CourseNumber { get; set; }
    public string CourseTitle { get; set; }
    public DateOnly CourseStartDate { get; set; }
    public DateOnly CourseEndDate { get; set; }
    public string Teacher { get; set; }
    public IList<StudentListViewModel> Students { get; set; }
}
