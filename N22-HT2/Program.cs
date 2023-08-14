



public interface IReview
{
    public int Id { get; set; }
    public bool star { get; set; }
    public string message { get; set; }

}
public class Review : IReview
{
    public int Id { get ; set ; }
    public bool star { get ; set; }
    public string message { get ; set ; }
}

 public interface IReviewList<TReview> where TReview:TReview
{

}










