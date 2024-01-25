using FluentAssertions;
using Xunit;
using static Day03.PetType;

namespace Day03.Tests
{
    public class PopulationTests
    {
        private static readonly IEnumerable<Person> PopulationTest = new List<Person>
        {
            new("Peter", "Griffin", new Pet(Cat, "Tabby", 2)),
            new("Stewie", "Griffin", new Pet(Cat, "Dolly", 3), new Pet(Dog, "Brian", 9)),
            new("Joe", "Swanson", new Pet(Dog, "Spike", 4)),
            new("Lois", "Griffin", new Pet(Snake, "Serpy", 1)),
            new("Meg", "Griffin", new Pet(Bird, "Tweety", 1)),
            new("Chris", "Griffin", new Pet(Turtle, "Speedy", 4)),
            new("Cleveland", "Brown", new Pet(Hamster, "Fuzzy", 1), new Pet(Hamster, "Wuzzy", 2)),
            new("Glenn", "Quagmire")
        };

        [Fact]
        public void The_Youngest_Pet_Owner_In_PopulationTest_Should_not_be_null_and_be_Lois()
        {
            var filtered = PopulationTest.MinBy(NewMethod());

            filtered.Should().NotBeNull();
            filtered!.FirstName.Should().Be("Lois");
        }

        private static Func<Person, int> NewMethod()
        {
            return person =>
            {
                var youngestPetByAge = person.Pets.MinBy(p => p.Age);
                return youngestPetByAge?.Age
                    ?? int.MaxValue;
            };
        }
    }
}