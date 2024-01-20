namespace Week_02_lab_06_Medal_W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", MedalColor.Gold, 2012, true);

            // Print the object
            Console.WriteLine(m1);

            // Print only the name of the medal holder
            Console.WriteLine(m1.Name);

            // Create another object
            Medal m2 = new Medal("Michael Phelps", "Swimming", MedalColor.Gold, 2012, false);

            // Print the updated m2
            Console.WriteLine(m2);

            // Create a list to store the medal objects
            List<Medal> medals = new List<Medal>
            {
                m1,
                m2,
                new Medal("Ryan Cochrane", "Swimming", MedalColor.Silver, 2012, false),
                new Medal("Adam van Koeverden", "Canoeing", MedalColor.Silver, 2012, false),
                new Medal("Rosie MacLennan", "Gymnastics", MedalColor.Gold, 2012, false),
                new Medal("Christine Girard", "Weightlifting", MedalColor.Bronze, 2012, false),
                new Medal("Charles Hamelin", "Short Track", MedalColor.Gold, 2014, true),
                new Medal("Alexandre Bilodeau", "Freestyle skiing", MedalColor.Gold, 2012, true),
                new Medal("Jennifer Jones", "Curling", MedalColor.Gold, 2014, false),
                new Medal("Charle Cournoyer", "Short Track", MedalColor.Bronze, 2014, false),
                new Medal("Mark McMorris", "Snowboarding", MedalColor.Bronze, 2014, false),
                new Medal("Sidney Crosby ", "Ice Hockey", MedalColor.Gold, 2014, false),
                new Medal("Brad Jacobs", "Curling", MedalColor.Gold, 2014, false),
                new Medal("Ryan Fry", "Curling", MedalColor.Gold, 2014, false),
                new Medal("Antoine Valois-Fortier", "Judo", MedalColor.Bronze, 2012, false),
                new Medal("Brent Hayden", "Swimming", MedalColor.Bronze, 2012, false)
            };

            // Prints a numbered list of 16 medals.
            Console.WriteLine("\n\nAll 16 medals");
            for (int i = 0; i < medals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {medals[i]}");
            }

            // Prints a numbered list of 16 names (ONLY)
            Console.WriteLine("\n\nAll 16 names");
            for (int i = 0; i < medals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {medals[i].Name}");
            }

            // Prints a numbered list of 9 gold medals
            Console.WriteLine("\n\nAll 9 gold medals");
            int goldCount = 0;
            for (int i = 0; i < medals.Count; i++)
            {
                if (medals[i].Color == MedalColor.Gold)
                {
                    goldCount++;
                    Console.WriteLine($"{goldCount}. {medals[i]}");
                }
            }

            // Prints a numbered list of 9 medals in 2012
            Console.WriteLine("\n\nAll 9 medals in 2012");
            int year2012Count = 0;
            for (int i = 0; i < medals.Count; i++)
            {
                if (medals[i].Year == 2012)
                {
                    year2012Count++;
                    Console.WriteLine($"{year2012Count}. {medals[i]}");
                }
            }

            // Prints a numbered list of 4 gold medals in 2012
            Console.WriteLine("\n\nAll 4 gold medals in 2012");
            int gold2012Count = 0;
            for (int i = 0; i < medals.Count; i++)
            {
                if (medals[i].Year == 2012 && medals[i].Color == MedalColor.Gold)
                {
                    gold2012Count++;
                    Console.WriteLine($"{gold2012Count}. {medals[i]}");
                }
            }

            // Prints a numbered list of 3 world record medals
            Console.WriteLine("\n\nAll 3 records");
            int recordCount = 0;
            for (int i = 0; i < medals.Count; i++)
            {
                if (medals[i].IsRecord)
                {
                    recordCount++;
                    Console.WriteLine($"{recordCount}. {medals[i]}");
                }
            }

            // Saving all the medals to file Medals.txt
            Console.WriteLine("\n\nSaving to file");
            using (StreamWriter writer = new StreamWriter("Medals.txt"))
            {
                foreach (Medal medal in medals)
                {
                    writer.WriteLine(medal);
                }
            }
        }
    }

    public enum MedalColor
    {
        Bronze,
        Silver,
        Gold
    }

    public class Medal
    {
        public string Name { get; }
        public string TheEvent { get; }
        public MedalColor Color { get; }
        public int Year { get; }
        public bool IsRecord { get; }

        public Medal(string name, string theEvent, MedalColor color, int year, bool isRecord)
        {
            Name = name;
            TheEvent = theEvent;
            Color = color;
            Year = year;
            IsRecord = isRecord;
        }

        public override string ToString()
        {
            string recordString = IsRecord ? "(R)" : "";
            return $"{Year} - {TheEvent}{recordString} {Name}({Color})";
        }
    }
}