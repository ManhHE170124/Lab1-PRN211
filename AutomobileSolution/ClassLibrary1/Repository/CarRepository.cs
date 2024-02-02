using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarID(int carID) => CarDBContext.Instance.GetCarByID(carID);
        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList;
        public void InsertCar(Car car) => CarDBContext.Instance.Addnew(car);
        public void DeleteCar(int carId) => CarDBContext.Instance.Remove(carId);
        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);

        public Car GetCarById(int carId)
        {
            throw new NotImplementedException();
        }
    }
}