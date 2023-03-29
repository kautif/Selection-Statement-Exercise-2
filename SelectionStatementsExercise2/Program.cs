namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was your favorite subject in school? Use a capital letter for the start of each new word");
            var subject = Console.ReadLine();

            switch (subject) {
                case "English":
                    Console.WriteLine("Nice. I'm pretty good at writing essays");
                    break;
                case "Art":
                    Console.WriteLine("Awesome. I'm actually learning how to draw right now but I was never good at it");
                    break;
                case "Math":
                    Console.WriteLine("I'm good with Math until Algebra. After that, I probably need a calculator");
                    break;
                case "Social Studies":
                    Console.WriteLine("That's cool. I think history on its own is interesting, but I just hate memorizing years, dates, and events");
                    break;
                case "Science":
                    Console.WriteLine("Nice. I think the funnest part of science was doing the experiments");
                    break;
                default:
                    Console.WriteLine("I don't think I took that subject or I forget which subjects I took");
                    break;
            }
        }
    }
}