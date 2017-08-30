using Framework;
using Framework.Utilites;

namespace CarsTest.Models
{
    public class CarProperties
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        private const string Liter = "liter";
        private const string LiterAbbrev = "L";
        private Verify verify = new Verify();

        public void EqualCarDescription(CarProperties car, string message)
        {
            verify.IsTrue(car.Make.Contains(this.Make), message + " a Make is wrong");
            verify.IsTrue(car.Model.Contains(this.Model), message + " a Model is wrong");
            verify.AreEqual(this.Year, car.Year, message + " a Year is wrong");
        }

        public void EqualCarConfig(CarProperties car, string message)
        {
            verify.AreEqual(this.Engine.Replace(Liter, LiterAbbrev), car.Engine.Replace(Liter, LiterAbbrev), message + " engine is wrong");
            verify.AreEqual(this.Transmission,car.Transmission, message + " transmission is wrong");
        }
    }
}
