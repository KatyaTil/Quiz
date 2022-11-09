namespace QuizData
{
    public class AnswerOption
    {
        String Id { get; set; }
        String ImageId { get; set; }
        Boolean IsTrue { get; set; }

        public AnswerOption (String id, String imageId, Boolean isTrue)
        {
            Id = id;
            ImageId = imageId;
            IsTrue = isTrue;
        }
    }
}