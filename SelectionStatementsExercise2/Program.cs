namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;
            while (continueLoop)
            {    
            
                Console.WriteLine("Hi there! What is your favorite school subject?");
                
                string FavSubject = Console.ReadLine();


                switch (FavSubject.ToLower())
                {
                    case "math":
                    case "mathematics":
                        Console.WriteLine(
                            "\"Pure Mathematics is, in its way, the poetry of logical ideas.\" -Albert Einstein ");
                        break;

                    case "science":
                    case "sci":
                        Console.WriteLine(
                            "\"Research is what I'm doing when I don't know what I'm doing\" -Wernher von Braun");
                        break;

                    case "history":
                        Console.WriteLine("\"History repeats itself, first as tragedy, second as farce\" -Karl Marx");
                        break;

                    case "music":
                        Console.WriteLine(
                            "\"Music is the universal language of mankind.\" -Henry Wadsworth Longfellow");
                        break;

                    case "english":
                        Console.WriteLine(
                            "\"One language sets you in a corridor for life. Two languages open every door along the way\" -Frank Smith");
                        break;

                    default:
                        Console.WriteLine("\"It's what you learn after you know it all that counts.\" -Harry S. Truman");
                        continueLoop = false;
                        break;

                }
            }
        }
    }  
}