using System;

namespace Quiz
{

    class Question
    {
        public Question(string text,string[] choices,string answer)
        {
            this.Text = text;
            this.Choices = choices;
            this.Answer = answer;
        }
        public string Text { get; set; }

        public string[] Choices { get; set; }

        public string Answer { get; set; }

        public bool checkAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower();
        }
    }

    class Quiz
    {
        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
            this.Score = 0;
        }
        private Question[] Questions {get; set;}
        private int QuestionIndex { get; set; }

        private int Score { get; set; }

        private Question GetQuestion(){
            return this.Questions[this.QuestionIndex];
        }

        private void Guess(string answer){
            var question = this.GetQuestion();
            if(question.checkAnswer(answer)){
                this.Score++;
            }
            this.QuestionIndex++;

            if(this.Questions.Length == this.QuestionIndex){
                this.DisplayScore();
                return;
            }
            else{
                this.DisplayQuestion();
            }  

        }

        private void DisplayScore(){
            Console.WriteLine($"Score: {this.Score}");

        }

        private void DisplayProgress(){
            int totalQuestion = this.Questions.Length;
            int questionNumber = this.QuestionIndex+1;

            if(totalQuestion>=questionNumber)
                Console.WriteLine($"Question {questionNumber} of {totalQuestion}");
        }

        public void DisplayQuestion()
        {
            var question = this.GetQuestion();
            this.DisplayProgress();

            foreach(var c in question.Choices){
                    Console.WriteLine("-"+c);
            }

            Console.Write("Cevap: ");
            string cevap = Console.ReadLine();
            this.Guess(cevap);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Question("En iyi dil?",new string[]{"C#","Python","Javascript","Java"},"Javascript");
            var q2 = new Question("En populer dil?",new string[]{"C#","Python","Javascript","Java"},"Javascript");
            var q3 = new Question("En cok kazandıran dil?",new string[]{"C#","Python","Javascript","Java"},"Python");

            var questions = new Question[]{q1,q2,q3};
            var quiz = new Quiz(questions);

            quiz.DisplayQuestion();

        }
    }
}
