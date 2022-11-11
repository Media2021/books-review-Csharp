using BookReviews;
using BookReviews.classes;

namespace WebApp.DTO.DTOMapper
{
    public static class Mapper
    {
        public static  ReviewDTO mapToReviewDTO(Review review)
        {
            ReviewDTO reviewDTO = new ReviewDTO();
            reviewDTO.ReviewId = review.ReviewId;
            reviewDTO.Id = review.Id;
            reviewDTO.Title = review.Title;
            reviewDTO.User1 = review.User1.Name;
            reviewDTO.AddReview = review.AddReview;
            reviewDTO.Date = review.Date;
            return reviewDTO;
        }
        public static Review mapToReview(ReviewDTO reviewDTO,User user)
        {
            Review newReview = new Review(reviewDTO.ReviewId, reviewDTO.Id, reviewDTO.Title,user, reviewDTO.AddReview, reviewDTO.Date);
            
            return newReview;
        }
    }
}
