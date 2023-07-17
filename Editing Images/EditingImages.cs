using Editing_Images.entity;

public class EditingImages
{
    static void Main()
    {
        try {
            /* Taking from user amount of images for editing */
            Console.WriteLine("Enter amount of images: ");
            int imagesAmount;

            /* Handling error if user inputs not a number */
            if (!int.TryParse(Console.ReadLine(), out imagesAmount))
            {
                throw new FormatException("Invalid input. The value entered for total number of images is not an number.");
            }
            /* Taking from user amount of people in crew */
            Console.WriteLine("Enter amount of people in crew: ");
            int crewSize;

            /* Handling error if user inputs not a number */
            if (!int.TryParse(Console.ReadLine(), out crewSize))
            {
                throw new FormatException("Invalid input. The value entered for amount of people in crew is not an number.");
            }

            /* Creating array of peoples */
            Person[] crew = new Person[crewSize];

            /* Taking info about every person in crew */
            for (int i = 0; i < crewSize; i++) {
                Console.WriteLine("Enter the rate (in minutes) for person {0}: ", i + 1);
                double rate;

                /* Handling error if user inputs not a number */
                if (!double.TryParse(Console.ReadLine(), out rate))
                {
                    throw new FormatException("Invalid input. The value entered for editing rate is not an number.");
                }

                crew[i] = new Person(1.0 / rate);
            }

            /* Variable for combined rate of every person in crew */
            double totalRate = 0;

            foreach (Person person in crew)
            {
                totalRate += person.Rate;
            }

            /* Calculating the time spent on editing the specified amount images */
            double totalTime = imagesAmount / totalRate;

            Console.WriteLine("Total time spend for editing {0} images for crew of {1} peoples is - {2} minutes", imagesAmount, crewSize, totalTime);
        }
        catch (Exception exception)
        {
            Console.WriteLine("An error occurred: " + exception.Message);
        }
        }
}
