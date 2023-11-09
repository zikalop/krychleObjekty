namespace Animal
{
    public class ServiceAnimal
    {
        private List<Animal> Animals = new List<Animal>();

        public void AddAnimal(string name, int age)
        {
            Animals.Add(item: new Animal() { Age = age, Name = name });
        }
        public void RemoveAnimal(int index)
        {
            Animals.RemoveAt(index);
        }
        public void WriteAllAnimals()
        {
            int index = 0;
            foreach (Animal animal in Animals)
            {
                Console.WriteLine($"{index}, {animal.Name}, {animal.Age}");
                index++;
            }
        }
        public void SearchAnimalByName()
        {

        }

    }
}