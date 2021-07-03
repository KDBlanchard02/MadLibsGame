using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibsConsole
{
    public class ProgramUI
    {
        private bool _isRunning = true;

        public void Start()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            while (_isRunning)
            {
                string userInput = GetMenuSelection();
                OpenMenuItem(userInput);
            }
        }

        private string GetMenuSelection()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the MadLibs Console Game! Enter # for selection, then press enter. \n" +
                              "Select a Story: \n" +
                              "1 - National Anthem USA \n" +
                              "2 - Summer Heat \n" +
                              "3 - Pudding\n" +
                              "4 - Super Secure Password \n" +
                              "------------------------------------------------------------------------------ \n" +
                              "Dirty Limericks: \n" +
                              "5 - Limerick One \n" +
                              "6 - Limerick Two \n" +
                              "7 - Limerick Three \n" +
                              "8 - Limerick Four \n" +
                              "9 - Limerick Five \n" +
                              "10 - Limerick Six \n" +
                              "------------------------------------------------------------------------------ \n" +
                              "11 - Exit Game \n");

            string userInput = Console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    //Select paragraph 1
                    NationalAnthem();
                    break;
                case "2":
                    //Select paragraph 2
                    SummerHeat();
                    break;
                case "3":
                    Pudding();
                    break;
                case "4":
                    SuperSecurePassword();
                    break;
                case "5":
                    //Select paragraph 5
                    NumberOne();
                    break;
                case "6":
                    //Select paragraph 6
                    NumberTwo();
                    break;
                case "7":
                    //Select paragraph 7
                    NumberThree();
                    break;
                case "8":
                    //Select paragraph 8
                    NumberFour();
                    break;                   
                case "9":
                    //Select paragraph 9
                    NumberFive();
                    break;
                case "10":
                    //Select paragraph 10
                    NumberSix();
                    break;
                case "11":
                    //Exit
                    ExitGame();
                    break;
            }
        }

        public void NationalAnthem()
        {

            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an adverb, then press enter:");
            string adverbOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, past tense, then press enter:");
            string verbPastTenseOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a plural noun, then press enter:");
            string pluralNounOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a plural noun, then press enter:");
            string pluralNounTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an adjective, then press enter:");
            string adjectiveOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a plural noun, then press enter:");
            string pluralNounThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb ending in -ing, then press enter:");
            string enterVerbIngOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a color:");
            string colorOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a plural noun, then press enter:");
            string pluralNounFour = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an interjection, then press enter:");
            string interjectionOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an adjective, then press enter:");
            string adjectiveTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an adjective, then press enter:");
            string adjectiveThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an adjective, then press enter:");
            string adjectiveFour = Console.ReadLine();

            string paragraphOne = $"O say can you {verbOne} by the dawn's early {nounOne}, What so {adverbOne} we {verbPastTenseOne} at the twilight's last gleaming, Whose broad {pluralNounOne} and bright {pluralNounTwo} through the {adjectiveOne} fight, O'er the {pluralNounThree} we watched, were so gallantly {enterVerbIngOne}? And the rockets' {colorOne} glare, the {pluralNounFour} bursting in {nounTwo}, Gave proof through the night that our {nounThree} was still there; {interjectionOne} does that {adjectiveTwo} banner yet {verbThree}, O'er the land of the {adjectiveThree} and the home of the {adjectiveFour}?";

            Console.Clear();
            Console.WriteLine(paragraphOne);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        public void SummerHeat()
        {
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter: ");
            string verbOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter: ");
            string verbTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter: ");
            string nounOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a adjective, then press enter: ");
            string adjectiveOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a adjective, then press enter: ");
            string adjectiveTwo = Console.ReadLine();

            string paragraphTwo = $"I'm starting to believe in global warming, because when I wake up I'm {verbOne}. The temperature outside is {verbTwo} and I want to stay inside the {nounOne}. The Sun is {adjectiveOne} and needs to chill. Winter right now would be {adjectiveTwo}.";

            Console.Clear();
            Console.WriteLine(paragraphTwo);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        public void Pudding()
        {
            Console.Clear();

            Console.WriteLine("Enter a noun, past tense, then press enter:");
            string nounPastTenseOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb ending In -ed, then press enter:");
            string verbEndingInEdOne= Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb ending in -ed, then press enter:");
            string verbEndingInEdTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a sport, then press enter:");
            string sportOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbFour = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an adjective, then press enter:");
            string adjectiveOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an adverb, then press enter:");
            string adverbOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbFive = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a sport, then press enter:");
            string sportTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb ending in -ed, then press enter:");
            string verbEndingInEdThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb ending in -ing, then press enter:");
            string verbEndingInIngOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounFour = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter:");
            string bodyPartOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbSix = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounFive = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb ending in -ed, then press enter:");
            string verbEndingInEdFour = Console.ReadLine();

            string paragraphOne = $"Pudding, by Dianne C. Braley - After not having {nounPastTenseOne} in years, I {verbEndingInEdOne} to give it a {verbOne} with my four-year-old, hoping he might {verbTwo} it as {nounOne} once did. I {verbEndingInEdTwo} him in {sportOne} school for the day, and {verbThree} I went until I got a {verbFour} to get him. He didn’t {adjectiveOne} it and was {adverbOne} upset over the {nounTwo} they served except for the pudding. I {verbFive} how much I enjoy {sportTwo}, I {verbEndingInEdThree}, {verbEndingInIngOne} home. Me too, {nounThree}, he started. For a moment, {nounFour} thought he had a change of {bodyPartOne}. I {verbSix} how much {nounFive} liked pudding, he {verbEndingInEdFour}.";

            Console.Clear();
            Console.WriteLine(paragraphOne);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        public void SuperSecurePassword()
        {
            Console.Clear();

            Console.WriteLine("Enter a pronoun, then press enter:");
            string pronounOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a person, then press enter:");
            string personOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a name, then press enter:");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter:");
            string bodyPartOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a random word, then press enter:");
            string randomWordOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an adjective, then press enter:");
            string adjectiveOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an adjective, then press enter:");
            string adjectiveTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a random word, then press enter:");
            string randomWordTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a person, then press enter:");
            string personTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter:");
            string bodyPartTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a pronoun, then press enter:");
            string pronounTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a pronoun, then press enter:");
            string pronounThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a number, then press enter:");
            string number = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a plural noun, then press enter:");
            string pluralNounOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a person, then press enter:");
            string personThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter:");
            string bodyPartThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounFour = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounFive = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb ending in ed, then press enter:");
            string verbEndingInEdOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a plural noun, then press enter:");
            string nounSix = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a person, then press enter:");
            string personFour = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbEndingInEDThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun ending in ing, then press enter:");
            string nounEndingInIng = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter:");
            string nounSeven = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter:");
            string verbFour = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a date, then press enter:");
            string dateOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a date, then press enter:");
            string dateTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an adjective, then press enter:");
            string adjectiveThree = Console.ReadLine();

            string paragraphOne = $"Super Secure Password, by Jennifer Lai - {pronounOne} need to create a {nounOne}, Grandpa, {personOne} said. {name} stared at the {nounTwo} screen, scratching his {bodyPartOne}. How about {randomWordOne}? Too {adjectiveOne}. {randomWordTwo}? {personTwo} shook her {bodyPartTwo}" +
                $". Too {verbOne}. If {pronounTwo} too hard, {nounThree} might forget {pronounThree}. Then think of {number} random personal {pluralNounOne}. {personThree} tented his {bodyPartThree} for a {nounFour}. “What about combining my {nounFive} and the date I {verbEndingInEdOne} Leo from the {nounSix} shelter? {personFour}’s brows {verbEndingInEDThree}. “That’s {adjectiveTwo}. Even I don’t {verbTwo} the latter. {adjectiveThree}! George {verbEndingInEDThree} the keyboard then {verbThree} enter, {nounEndingInIng} satisfied. No {nounSeven} would ever {verbFour} to connect {dateOne} and {dateTwo}.";

            Console.Clear();
            Console.WriteLine(paragraphOne);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }



        public void NumberOne()
        {
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter: ");
            string nounOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a place, then press enter: ");
            string place = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter: ");
            string nounTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a planet, then press enter: ");
            string planet = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPart = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter: ");
            string nounThree = Console.ReadLine();

            string numberOne = $"There was a young {nounOne} from {place}, who fell asleep in his {nounTwo}, while dreaming of {planet}, he played with his {bodyPart}, and woke up covered in {nounThree}.";

            Console.Clear();
            Console.WriteLine(numberOne);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        public void NumberTwo()
        {
            Console.Clear();

            Console.WriteLine("Enter a place, then press enter: ");
            string placeOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPartOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter: ");
            string verbOne = Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Enter a verb, then press enter: ");
            string verbTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPartTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPartThree = Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPartFour = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter: ");
            string verbThree = Console.ReadLine();

            string numberTwo = $"There once was a man from {placeOne}, With a {bodyPartOne} so long he could {verbOne} it, He said with a {verbTwo}, as he licked off his {bodyPartTwo}, if my {bodyPartThree} was a {bodyPartFour} I would {verbThree} it.";

            Console.Clear();
            Console.WriteLine(numberTwo);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        public void NumberThree()
        {
            Console.Clear();

            Console.WriteLine("Enter a place, then press enter: ");
            string placeOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb, then press enter: ");
            string verbOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter: ");
            string nounOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPartOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPartTwo = Console.ReadLine();
            Console.Clear();

            string numberThree = $"There once was a man from {placeOne}, Who went for a {verbOne} in a rocket, The {nounOne} went bang, His {bodyPartOne} went clang, And he found his {bodyPartTwo} in his pocket!";

            Console.Clear();
            Console.WriteLine(numberThree);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        public void NumberFour()
        {
            Console.Clear();

            Console.WriteLine("Enter a name, then press enter: ");
            string nameOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb ending in -ed, then press enter: ");
            string verbEndinginEd = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an animal, then press enter: ");
            string animal = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter an adjective, then press enter: ");
            string adjectiveOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a piece of clothing, then press enter: ");
            string pieceOfClothing = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPartOne = Console.ReadLine();

            string numberFour = $" There once was a fella named {nameOne}, Who {verbEndinginEd} to date this hot {animal}, But brief was {adjectiveOne}, For tucked in her {pieceOfClothing} was a much larger {bodyPartOne}.";

            Console.Clear();
            Console.WriteLine(numberFour);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        public void NumberFive()
        {
            Console.Clear();

            Console.WriteLine("Enter a name, then press enter: ");
            string nameOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPartOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter: ");
            string nounOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a noun, then press enter: ");
            string nounTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPartTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a measurement, then press enter: ");
            string measurement = Console.ReadLine();

            string numberFive = $"There once was a guy named {nameOne}, whose {bodyPartOne} was covered with {nounOne}, but the {nounTwo} would play, with his {bodyPartTwo} anyway, 'cause good ol' {nameOne} came in {measurement}!";

            Console.Clear();
            Console.WriteLine(numberFive);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        public void NumberSix()
        {
            Console.Clear();

            Console.WriteLine("Enter a place, then press enter: ");
            string place = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a verb ending in -ed, then press enter: ");
            string verbEndingInEd = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPartOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter a body part, then press enter: ");
            string bodyPartTwo = Console.ReadLine();
            Console.Clear();

            string numberSix = $"There once was a man from {place}, who wasn't a very good climba', he {verbEndingInEd} on a rock, and cut of his {bodyPartOne}, and now he's got a {bodyPartTwo}.";

            Console.Clear();
            Console.WriteLine(numberSix);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

            public void ExitGame()
        {
            _isRunning = false;
        }
    }
}
