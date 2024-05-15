public class Prompt
{
        private string _prompt = "";
        public string quest = "";
        List<string> questions = new List<string>();
        public Prompt()
        {
            questions.Add("Who was the most interesting person you interacted with today? ");
            questions.Add("How did you show kindness or compassion today? ");
            questions.Add("How did you see the hand of the Lord in your life today? ");
            questions.Add("What was the strongest emotion you felt today? ");
            questions.Add("What challenges did you overcome today? ");
            questions.Add("Who made a positive impact on your day, and how? ");
            questions.Add("What are three things you appreciate about yourself today? ");
            questions.Add("What are some things that you are grateful for? ");
            questions.Add("What was the highlight of your day? ");
            questions.Add("How are you feeling? ");
            questions.Add("What is one thing you wish you had done differently today, and why? ");
            questions.Add("Anything funny that happened today? ");
            questions.Add("What is a moment today that made you feel truly alive? ");
            questions.Add("How did you connect with others today, and what did you learn from those interactions? ");
            questions.Add("What is something beautiful you noticed today? ");
            questions.Add("What small victories did you celebrate today? ");
            questions.Add("How did you practice mindfulness or self-awareness today? ");
            questions.Add("What did you do today that made you happy? ");
            questions.Add("How did you express creativity today? ");
            questions.Add("What did you let go of today that was holding you back? ");
            questions.Add("How did you practice self-love and acceptance today? ");
            questions.Add("What are you looking forward to tomorrow? ");
            questions.Add("How did you practice gratitude today? ");
            questions.Add("How did you make a difference in someone else's life today? ");
            questions.Add("What was the best decision you made today? ");
            questions.Add("What made you feel at peace today? ");
            questions.Add("How did you manage your time effectively today? ");

        }
        public string GetRandomPrompt()
        {
            Random randomGenerator = new Random();
            int num = randomGenerator.Next(0,questions.Count);
            quest = questions[num];
            return quest;
        }
}