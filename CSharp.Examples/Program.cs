using CSharp.Examples;

var myAnimals = new List<LifeForm>
{
    new Giraffe(),
    new Zebra()
};

// Allows multiple animals since they are all derived from LifeForm
new Variance().PrintLifeForms(myAnimals); // Giraffe, Zebra


var myGiraffes = new List<Giraffe>
{
    new Giraffe(), // "Jerry"
    new Giraffe() // "Melman"
};

// This FAILS
// Passing a collection of a sub-class (more derived type) will fail
new Variance().PrintLifeForms(myGiraffes); // Compile Error
